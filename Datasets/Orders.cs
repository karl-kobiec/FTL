using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.ServiceModel.Description;
using IQ6.Core;
using System.Web;

namespace FTL
{
    public static class OrdersExt
    {
        public static HtmlString GetCustAddr(this Orders ord)
        {
            string ret = "";
            if (ord.OrdCustValue > 0)
            {
                var c = DS.GetByKey<Customer>(ord.OrdCustValue);
            
                if (!string.IsNullOrEmpty(c.CustAddrValue))
                    ret += c.CustAddrValue + "<br />";
                if (!string.IsNullOrEmpty(c.CustAddr2Value))
                    ret += c.CustAddr2Value + "<br />";
                if (!string.IsNullOrEmpty(c.CustAddr3Value))
                    ret += c.CustAddr3Value + "<br />";
                if (!string.IsNullOrEmpty(c.CustPCValue))
                    ret += c.CustPCValue + "<br />";
            }
            return new HtmlString(ret);
        }
        public static HtmlString GetSuppAddr(this Orders ord)
        {
            string ret = "";
            if (ord.OrdSuppValue > 0)
            {
                var c = DS.GetByKey<Customer>(ord.OrdCustValue);

                if (!string.IsNullOrEmpty(c.CustNameValue))
                    ret += c.CustNameValue + "<br />";
                if (!string.IsNullOrEmpty(c.CustAddrValue))
                    ret += c.CustAddrValue + "<br />";
                if (!string.IsNullOrEmpty(c.CustAddr2Value))
                    ret += c.CustAddr2Value + "<br />";
                if (!string.IsNullOrEmpty(c.CustAddr3Value))
                    ret += c.CustAddr3Value + "<br />";
                if (!string.IsNullOrEmpty(c.CustPCValue))
                    ret += c.CustPCValue + "<br />";
            }
            return new HtmlString(ret);
        }
        
    }

    public partial class OrdersRegister
    {
        public static void Register()
        {
            DS.AddOnLoad<Orders>(data =>
            {
                if (data.RecordID.HasValue)
                {
                    //   data.OrdCustId.Enabled = false;
                    data.OrdReqDate.Enabled = false;
                    data.OrdExpImp.Enabled = false;
                    data.OrdDate.Enabled = false;
                    data.OrdStatus.Enabled = false;
                    data.OrdCust.Enabled = false;
                    data.OrdCustName.Enabled = false;
                    data.OrdCustOrd.Enabled = false;
                    data.OrdConsign.Enabled = false;
                    //  data.OrdConsignId.Enabled = false;
                    data.OrdConsOrd.Enabled = false;
                    data.OrdTescoRef.Enabled = false;
                    data.OrdDelRef.Enabled = false;
                    data.OrdSupp.Enabled = false;
                    // data.OrdSuppId.Enabled = false;
                    data.OrdSuppRef.Enabled = false;
                    data.OrdCollPoint.Enabled = false;
                    // data.OrdCollPointId.Enabled = false;
                    data.OrdDelPoint.Enabled = false;
                    // data.OrdDelPointId.Enabled = false;
                    data.OrdNotes.Enabled = false;
                    data.OrdDateAvail.Enabled = false;
                    data.OrdTimeAvail.Enabled = false;
                    data.OrdDANNoFrom.Enabled = false;
                    data.OrdBondFrom.Enabled = false;
                    data.OrdGBWKNoFrom.Enabled = false;
                    data.OrdVATPaidBy.Enabled = false;
                    data.OrdAgentId.Enabled = false;
                    data.OrdAgent.Enabled = false;
                    data.OrdEMTo.Enabled = false;
                    data.OrdSelEMTo.Enabled = false;
                    data.OrdFaxTo.Enabled = false;
                    data.OrdSelFaxTo.Enabled = false;
                    data.OrdAADSys.Enabled = false;
                    data.OrdARCRef.Enabled = false;
                }
            });
            DS.AddOnDrawSingleToolbar<Orders>(data =>
            {
                List<Element> ret = new List<Element>();
                ret.Add(WebButton.NewWindowButton("Add Company", "/Customer/Add"));

                if (data.RecordID.HasValue)
                {
                    ret.Add(WebButton.CallbackButton<Orders>("Copy Order", CopyOrder));
                    ret.Add(WebButton.CallbackButton<Orders>("Edit Order", EditOrder));
                }
                return ret;
            });
            DS.AddOnDataSource<Orders>(x => x.OrdSelEMTo, data =>
            {
                string SQL = "SELECT 0 AS KeyValue, '' AS Description";
                if (data.OrdSuppValue > 0)
                {
                    SQL = "SELECT 1 As KeyValue, ' S1: ' + CustEM AS Description FROM Customer WHERE CustId=" +
                          data.OrdSuppValue
                          +
                          " UNION SELECT 2 As KeyValue, ' S2: ' + CustEM2 AS Description FROM Customer WHERE CustEM2 Is Not Null AND CustId=" +
                          data.OrdSuppValue
                          +
                          " UNION SELECT 3 As KeyValue, ' S3: ' + CustEM3 AS Description FROM Customer WHERE CustEM3 Is Not Null AND CustId=" +
                          data.OrdSuppValue
                          +
                          " UNION SELECT 4 As KeyValue, ' S4: ' + CustEM4 AS Description FROM Customer WHERE CustEM4 Is Not Null AND CustId=" +
                          data.OrdSuppValue;
                    if (data.OrdCollPointValue > 0 & data.OrdSuppValue != data.OrdCollPointValue)
                    {
                        SQL = SQL +
                              " UNION SELECT 5 AS KeyValue, 'CP1: ' + CustEM AS Description FROM Customer WHERE CustEM Is Not Null AND CustId=" +
                              data.OrdCollPointValue
                              +
                              " UNION SELECT 6 As KeyValue, 'CP2: ' + CustEM2 AS Description FROM Customer WHERE CustEM2 Is Not Null AND CustId=" +
                              data.OrdCollPointValue
                              +
                              " UNION SELECT 7 As KeyValue, 'CP3: ' + CustEM3 AS Description FROM Customer WHERE CustEM3 Is Not Null AND CustId=" +
                              data.OrdCollPointValue
                              +
                              " UNION SELECT 8 As KeyValue, 'CP4: ' + CustEM4 AS Description FROM Customer WHERE CustEM4 Is Not Null AND CustID=" +
                              data.OrdCollPointValue;
                    }
                    SQL = SQL + " UNION SELECT 0, '' ORDER BY KeyValue";
                }
                return SQL;
            });

            DS.AddOnChange<Orders>(x => x.OrdSelEMTo, data =>
            {
                data.OrdEMToValue = data.OrdSelEMTo.DisplayValue;
                data.OrdSelEMTo.DataValue = 0;
            });

            DS.AddOnDataSource<Orders>(x => x.OrdSelFaxTo, data =>
            {

                string SQL = "SELECT 0 AS KeyValue, '' AS Description";
                if (data.OrdSuppValue > 0)
                {
                    SQL = "SELECT 1 AS KeyValue, ' S:' + CustFax AS Description FROM Customer WHERE CustId=" +
                          data.OrdSuppValue;
                    if (data.OrdCollPointValue > 0 & data.OrdSuppValue != data.OrdCollPointValue)
                        SQL = SQL +
                              " UNION SELECT 2 AS KeyValue, 'CP:' + CustFax AS Description FROM Customer WHERE CustId=" +
                              data.OrdCollPointValue;
                    SQL = SQL + " UNION SELECT 0, '' ORDER BY KeyValue";
                }
                return SQL;
            });

            DS.AddOnChange<Orders>(x => x.OrdSelFaxTo, data =>
            {
                data.OrdFaxToValue = data.OrdSelFaxTo.DisplayValue;
                data.OrdSelFaxTo.DataValue = 0;
            });
            DS.AddOnAdd<Orders>(data =>
            {

                string SQL = "SELECT Max(OrdId) AS Last FROM Orders WHERE OrdExpImp='" + data.OrdExpImpValue + "'";

                data.OrdIdValue = IQApp.DB.GetInt(SQL) + 1;

                data.Save();

                OrderLine l = new OrderLine();
                l.OrdLOrderValue = data.OrdIdValue;
                l.OrdLCustOrdValue = data.OrdCustOrdValue;
                l.OrdLLineNoValue = 1;
                l.Save();
            });

            DS.AddOnChange<Orders>(x => x.OrdAgent, data =>
            {
                data.OrdAgentId.DataValue = data.OrdAgentValue;
            });
            DS.AddOnChange<Orders>(x => x.OrdAgentId, data =>
            {
                data.OrdAgent.DataValue = data.OrdAgentIdValue;
            });
            DS.AddOnChange<Orders>(x => x.OrdARCRef, data =>
            {
                if (data.OrdARCRefValue != "")
                {
                    string SQL = "SELECT count(EADNo) FROM EADNo WHERE EADNo='" + data.OrdARCRefValue +
                                 "' AND EADOrder=" + data.OrdIdValue;
                    if (IQApp.DB.GetInt(SQL) == 0)
                    {
                        EADNum e = new EADNum();
                        e.EADNoValue = data.OrdARCRefValue;
                        e.EADOrderValue = data.OrdIdValue;
                        e.Save();
                    }
                }
            });
            DS.AddOnChange<Orders>(x => x.OrdBondFrom, data =>
            {
                int x1 = 0;
                switch (data.OrdBondFromValue)
                {
                    case 1:
                        x1 = data.OrdCustValue;
                        break;
                    case 2:
                        x1 = data.OrdConsignValue;
                        break;
                    case 3:
                        x1 = data.OrdSuppValue;
                        break;
                    case 4:
                        x1 = data.OrdDelPointValue;
                        break;
                }
                if (x1 == 0) data.OrdBondCodeValue = "";
                else data.OrdBondCodeValue = DS.GetStringByKey<Customer>(x => x.CustBondCodeValue, x1);
            });

            DS.AddOnChange<Orders>(x => x.OrdCollPoint, CP);

            DS.AddOnChange<Orders>(x => x.OrdConsign, data =>
            {
                //     data.OrdConsignId.DataValue = data.OrdConsignValue;
                data.OrdConsignPCValue = DS.GetStringByKey<Customer>(x=> x.CustPCValue,data.OrdConsignValue);
                if (data.OrdExpImpValue == OrdExpImps.Export) data.OrdDelPointValue = data.OrdConsignValue;
            });

            DS.AddOnChange<Orders>(x => x.OrdCust, data =>
            {

                //    data.OrdCustId.DataValue = data.OrdCustValue;
                var c = DS.GetByKey<Customer>(data.OrdCustValue);
                data.OrdCustNameValue = c.CustNameValue;
                data.OrdCustPCValue = c.CustPCValue;
            });
            DS.AddOnChange<Orders>(x => x.OrdCustOrd, data =>
            {
                if (data.OrdIdValue > 0)
                    DS.SetValueByField<OrderLine>(x=> x.OrdLCustOrd, data.OrdCustOrdValue, x=> x.OrdLOrder,data.OrdIdValue);
            });
            DS.AddOnChange<Orders>(x => x.OrdDANNoFrom, data => {
                int x1 = 0;
                switch (data.OrdDANNoFromValue)
                {
                    case 1:
                        x1 = data.OrdCustValue;
                        break;
                    case 2:
                        x1 = data.OrdConsignValue;
                        break;
                    case 3:
                        x1 = data.OrdSuppValue;
                        break;
                }
                data.OrdDANNoValue = x1 == 0 ? "" : DS.GetStringByKey<Customer>(x=> x.CustDANNoValue ,x1);
            });
            DS.AddOnChange<Orders>(x => x.OrdDate, data =>
            {
                if (
                    FTLExtensions.FTLCheckDate(data.OrdDateValue) ==
                    false) data.OrdDateValue = DateTime.MinValue;
            });
            DS.AddOnChange<Orders>(x => x.OrdDateAvail, data =>
            {
                if (FTLExtensions.FTLCheckDate(data.OrdDateAvailValue) == false)
                    data.OrdDateAvailValue = DateTime.MinValue;
                data.OrdAvailChangedValue = DateTime.Today;
            });
            DS.AddOnChange<Orders>(x => x.OrdDelPoint, data =>
            {
                //     data.OrdDelPointId.DataValue = data.OrdDelPointValue;
                data.OrdDelPointPCValue = DS.GetStringByKey<Customer>(x=> x.CustPCValue, data.OrdDelPointValue);
            });

            DS.AddOnChange<Orders>(x => x.OrdExpImp, data =>
            {
                if (data.OrdCreatedByValue == 0) data.OrdCreatedByValue = IQApp.User.GetUserId();
            });
            DS.AddOnChange<Orders>(x => x.OrdGBWKNoFrom, data =>
            {
                int x1 = 0;
                switch (data.OrdGBWKNoFromValue)
                {
                    case 1:
                        x1 = data.OrdCustValue;
                        break;
                    case 2:
                        x1 = data.OrdConsignValue;
                        break;
                    case 3:
                        x1 = data.OrdSuppValue;
                        break;
                    case 4:
                        x1 = data.OrdDelPointValue;
                        break;
                }
                if (x1 == 0) data.OrdGBWKNoValue = "";
                else data.OrdGBWKNoValue = DS.GetStringByKey<Customer>(x=> x.CustGBWKValue, x1);
            });
            DS.AddOnChange<Orders>(x => x.OrdSupp, data =>
            {
                var c = DS.GetByKey<Customer>(data.OrdSuppValue);
                data.OrdSupPCValue = c.CustPCValue;
                data.OrdCollPointValue = data.OrdSuppValue;
                //    data.OrdCollPointIdValue = data.OrdSuppValue;
                data.OrdCollPointPCValue = c.CustPCValue;
                data.OrdCollectCtryValue = DS.GetStringByKey<Country>(x=> x.CtryNameValue, c.CustCtryValue);
                data.OrdSelEMTo.DataSourceChanged = true;
                data.OrdSelFaxTo.DataSourceChanged = true;
            });
            DS.AddOnChange<Orders>(x => x.OrdVATPaidBy, data =>
            {
                int x1 = 0;
                switch (data.OrdVATPaidByValue)
                {
                    case 1:
                        x1 = data.OrdCustValue;
                        break;
                    case 2:
                        x1 = data.OrdConsignValue;
                        break;
                    case 3:
                        x1 = data.OrdSuppValue;
                        break;
                }
                if (x1 == 0) data.OrdVATNoValue = "";
                else data.OrdVATNoValue = DS.GetStringByKey<Customer>(x=> x.CustVATNoValue,x1);
            });
        }
      

        public static void EditOrder(Orders data)
        {
            //  data.OrdCustId.Enabled = true;
            data.OrdReqDate.Enabled = true;
            data.OrdExpImp.Enabled = true;
            data.OrdDate.Enabled = true;
            data.OrdStatus.Enabled = true;
            data.OrdCust.Enabled = true;
            data.OrdCustName.Enabled = true;
            data.OrdCustOrd.Enabled = true;
            data.OrdConsign.Enabled = true;
            // data.OrdConsignId.Enabled = true;
            data.OrdConsOrd.Enabled = true;
            data.OrdTescoRef.Enabled = true;
            data.OrdDelRef.Enabled = true;
            data.OrdSupp.Enabled = true;
            //  data.OrdSuppId.Enabled = true;
            data.OrdSuppRef.Enabled = true;
            data.OrdCollPoint.Enabled = true;
            //  data.OrdCollPointId.Enabled = true;
            data.OrdDelPoint.Enabled = true;
            //data.OrdDelPointId.Enabled = true;
            data.OrdNotes.Enabled = true;
            data.OrdDateAvail.Enabled = true;
            data.OrdTimeAvail.Enabled = true;
            data.OrdDANNoFrom.Enabled = true;
            data.OrdBondFrom.Enabled = true;
            data.OrdGBWKNoFrom.Enabled = true;
            data.OrdVATPaidBy.Enabled = true;
            data.OrdAgentId.Enabled = true;
            data.OrdAgent.Enabled = true;
            data.OrdEMTo.Enabled = true;
            data.OrdSelEMTo.Enabled = true;
            data.OrdFaxTo.Enabled = true;
            data.OrdSelFaxTo.Enabled = true;
            data.OrdAADSys.Enabled = true;
            data.OrdARCRef.Enabled = true;
        }
        public static void CP(Orders data)
        {
            var c = DS.GetByKey<Customer>(data.OrdCollPointValue);
            data.OrdCollPointPCValue = c.CustPCValue;
            data.OrdCollectCtryValue = DS.GetStringByKey<Country>(x => x.CtryNameValue, c.CustCtryValue);
            data.OrdSelEMTo.DataSourceChanged = true;
            data.OrdSelFaxTo.DataSourceChanged = true;
        }
        public static void CopyOrder(Orders data)
        {

            // display copy when done
            string SQL = "SELECT Max(OrdId) AS Last FROM Orders WHERE OrdExpImp='" + data.OrdExpImpValue + "'";
            int intrdrdId = IQApp.DB.GetInt(SQL) + 1;

            Orders o = new Orders();

            o.OrdIdValue = intrdrdId;
            o.OrdExpImpValue = data.OrdExpImpValue;
            o.OrdStatusValue = data.OrdStatusValue;
            o.OrdSuppValue = data.OrdSuppValue;
            o.OrdSupPCValue = data.OrdSupPCValue;
            o.OrdCollPointValue = data.OrdCollPointValue;
            o.OrdCollPointPCValue = data.OrdCollPointPCValue;
            o.OrdSuppRefValue = data.OrdSuppRefValue;
            o.OrdConsignValue = data.OrdConsignValue;
            o.OrdConsignPCValue = data.OrdConsignPCValue;
            o.OrdDelPointValue = data.OrdDelPointValue;
            o.OrdDelPointPCValue = data.OrdDelPointPCValue;
            o.OrdVATPaidByValue = data.OrdVATPaidByValue;
            o.OrdVATNoValue = data.OrdVATNoValue;
            o.OrdDANNoFromValue = data.OrdDANNoFromValue;
            o.OrdDANNoValue = data.OrdDANNoValue;
            o.OrdBondFromValue = data.OrdBondFromValue;
            o.OrdBondCodeValue = data.OrdBondCodeValue;
            o.OrdCustValue = data.OrdCustValue;
            o.OrdCustPCValue = data.OrdCustPCValue;
            //   o.OrdCustIdValue = data.OrdCustIdValue;
            //    o.OrdConsignIdValue = data.OrdConsignIdValue;
            //    o.OrdSuppIdValue = data.OrdSuppIdValue;
            //    o.OrdCollPointIdValue = data.OrdCollPointIdValue;
            //    o.OrdDelPointIdValue = data.OrdDelPointIdValue;
            o.OrdEMToValue = data.OrdEMToValue;
            o.OrdFaxToValue = data.OrdFaxToValue;
            o.OrdAgentIdValue = data.OrdAgentIdValue;
            o.OrdAgentValue = data.OrdAgentValue;
            o.OrdAADSysValue = data.OrdAADSysValue;
            o.OrdGBWKNoFromValue = data.OrdGBWKNoFromValue;
            o.OrdGBWKNoValue = data.OrdGBWKNoValue;
            o.OrdCollectCtryValue = data.OrdCollectCtryValue;
            o.Save();
            IQApp.CR.LoadScreen<Orders>(data.RecordID.Value);
        }

    }
}