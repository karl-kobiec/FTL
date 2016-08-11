using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class REDSOrdesRegister
    {
        public static void Register()
        {
            DS.AddOnChange<REDSOrder>(x=> x.RDOrdCustId, data=> {
                var c = DS.GetByKey<Customer>(data.RDOrdCustIdValue);
                data.RDOrdCustValue = c.CustNameValue;
                data.RDOrdDANNoValue = c.CustDANNoValue;
            });
            DS.AddOnChange<REDSOrder>(x => x.RDOrdOrder, data =>
            {
                var o = DS.GetByKey<Orders>(data.RDOrdOrderValue);
                if (o == null)
                {
                    IQApp.CR.MessageBoxOK("This order is not in the system");
                    return;
                }
                data.RDOrdCustIdValue = o.OrdCustValue;
                data.RDOrdCustOrdValue = o.OrdCustOrdValue;
                data.RDOrdDANNoValue = o.OrdDANNoValue;
                data.RDOrdJobNoValue = o.OrdJobNoValue;
                data.RDOrdJobLetterValue = o.OrdJobLetterValue;
                data.RDOrdARCNoValue = o.OrdARCRefValue;

                if (o.OrdBondFromValue == OrdBondFroms.Client)
                    data.RDOrdCustValue = DS.GetStringByKey<Customer>(x=> x.CustNameValue, o.OrdCustValue);
                else if (o.OrdBondFromValue == OrdBondFroms.Consignee)
                    data.RDOrdCustValue = DS.GetStringByKey<Customer>(x => x.CustNameValue, o.OrdConsignValue);
                else if (o.OrdBondFromValue == OrdBondFroms.DeliveryPoint)
                    data.RDOrdCustValue = DS.GetStringByKey<Customer>(x => x.CustNameValue, o.OrdDelPointValue);
                else if (o.OrdBondFromValue == OrdBondFroms.Supplier)
                    data.RDOrdCustValue = DS.GetStringByKey<Customer>(x => x.CustNameValue, o.OrdSuppValue);

                //Multiple eADs
                var eADs = DS.FetchByField<EADNum>(x=> x.EADOrder,data.RDOrdOrderValue);
                foreach (var ea in eADs.OrderBy(f => f.EADNoValue))
                {
                    REDSEAD e = new REDSEAD();
                    e.RDEADRDIdValue = data.RDOrdIdValue;
                    e.RDEADIdValue = ea.EADNoValue;
                    e.Save();
                }
            });

            DS.AddOnChange<REDSOrder>(x => x.RDOrdARCNo, data =>
            {
                if (data.RDOrdARCNoValue != "")
                {
                    string SQL = "SELECT count(RDEADId) FROM REDSEAD WHERE RDEADId='" + data.RDOrdARCNoValue +
                                 "' AND RDEADRDId=" + data.RDOrdIdValue;

                    if (IQApp.DB.GetInt(SQL) == 0)
                    {
                        REDSEAD e = new REDSEAD();
                        e.RDEADRDIdValue = data.RDOrdIdValue;
                        e.RDEADIdValue = data.RDOrdARCNoValue;
                        e.Save();
                    }
                }
            });
        }
      
          
    }
}