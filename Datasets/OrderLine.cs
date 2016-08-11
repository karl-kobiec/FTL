using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class OrderLineRegister
    {
        public static void Register()
        {
            DS.AddOnDataSource<OrderLine>(x=> x.OrdLSize, data => "SELECT BSzId AS KeyValue, BSzSize AS Description, BSzOrder FROM BottleSize UNION SELECT 0, '', 0 ORDER BY BSzOrder, KeyValue");
            DS.AddOnValidate<OrderLine>(data =>
            {
                if (data.OrdLLineNoValue == 0)
                {
                    string SQL = "SELECT Max(OrdLLineNo) AS Last FROM OrderLine WHERE OrdLOrder='" + data.OrdLOrderValue +
                                 "'";

                    data.OrdLLineNoValue = IQApp.DB.GetInt(SQL) + 1;
                    if (data.OrdLCustOrdValue == "") data.OrdLCustOrdValue = data.Parent.OrdCustOrdValue;
                }
                return true;
            });

        }
    }
}