using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class IStatRecRegister
    {
        public static void Register()
        {
            DS.AddOnChange<IStatRec>(x => x.IStCommCode, data =>
            {

                string CC = data.IStCommCodeValue.ToString();
                CC = CC.Substring(0, 4);
                switch (CC)
                {
                    case "2203":
                    case "2204":
                    case "2205":
                    case "2206":
                    case "2209":
                        data.IStSuppUnitTypeValue = "l";
                        break;

                    case "2208":
                        data.IStSuppUnitTypeValue = "l alc.";
                        break;
                }
            });
            DS.AddOnChange<IStatRec>(x => x.IStCustId, data =>
            {
                data.IStCustValue = DS.GetStringByKey<Customer>(x=> x.CustNameValue,  data.IStCustIdValue);
            });

            DS.AddOnChange<IStatRec>(x => x.IStDate, data =>
            {
                string SQL = "SELECT ExRId FROM ExchRate WHERE ExRSDate<='" + data.IStDateValue.ToSQLString() +
                             "' AND ExREDate>='" + data.IStDateValue.ToSQLString() + "'";
                data.IStRatePeriodValue = IQApp.DB.GetInt(SQL);

                SQL = "SELECT IStMId FROM IStatMonth WHERE IStMSDate<='" + data.IStDateValue.ToSQLString() +
                      "' AND IStMEDate>='" + data.IStDateValue.ToSQLString() + "'";
                data.IStMonthValue = IQApp.DB.GetInt(SQL);

                SetCurrencyValues(data);
            });

            DS.AddOnChange<IStatRec>(x => x.IStInvCurr, SetCurrencyValues);
            DS.AddOnChange<IStatRec>(x => x.IStInvVal, SetCurrencyValues);
            DS.AddOnChange<IStatRec>(x => x.IStOrder, data =>
            {
                var o = DS.GetByKey<Orders>(data.IStOrderValue);
                if (o == null)
                {
                    IQApp.CR.MessageBoxOK("This order is not in the system");
                    return;
                }
                data.IStCustIdValue = o.OrdCustValue;
                data.IStCustValue = DS.GetStringByKey<Customer>(x => x.CustNameValue, o.OrdCustValue);
                data.IStCustOrdValue = o.OrdCustOrdValue;
                data.IStJobNoValue = o.OrdJobValue;
                data.IStSuppIdValue = o.OrdSuppValue;
                data.IStSuppValue = DS.GetStringByKey<Customer>(x => x.CustNameValue, o.OrdSuppValue);
            });
            DS.AddOnChange<IStatRec>(x => x.IStSuppId, data =>
            {
                data.IStSuppValue = DS.GetStringByKey<Customer>(x=> x.CustNameValue,
                        data.IStSuppIdValue);
            });
        }

        public static void SetCurrencyValues(IStatRec data)
        {
            if (data.IStInvCurrValue == CustCurrs.PoundSterling)
            {
                data.IStSterlingValValue = data.IStInvValValue;
            }
            else if (data.IStInvCurrValue == CustCurrs.Euro)
            {
                data.IStSterlingValValue = data.IStInvValValue / DS.GetDoubleByKey<ExchRate>(x => x.ExRRateValue, data.IStRatePeriodValue);
            }
        }
        
    }
}