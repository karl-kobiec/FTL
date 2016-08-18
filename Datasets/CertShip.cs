using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public class CertShipRegister
    {
        public static void Register()
        {
            // github test

            DS.AddOnChange<CertShip>(x => x.CSJobLetter, data =>
            {
                Orders o = DS.GetByFields<Orders>(x => x.OrdJobNo, data.CSJobNoValue,
                    x => x.OrdJobLetter, data.CSJobLetterValue);

                data.CSOrderValue = o.OrdIdValue;
                data.CSCustValue = o.OrdCustValue;
                data.CSDelPointValue = o.OrdDelPointValue;
                data.CSCustOrdValue = o.OrdCustOrdValue;

                string v1 = "";
                foreach (
                    OrderLine r in
                        DS.FetchByField<OrderLine>(x => x.OrdLOrder, o.OrdIdValue).OrderBy(f => f.OrdLLineNoValue))
                {
                    string v2 = DS.GetStringByKey<PackageType>(x => x.PackNameValue, r.OrdLPackageTypeValue);
                    string v3 = DS.GetStringByKey<BottleSize>(x => x.BSzSizeValue, r.OrdLSizeValue);
                    v1 = v1 + r.OrdLQtyValue + "  " + v2 + "  " + v3 + "  " + r.OrdLDescValue + Environment.NewLine;
                }
                data.CSGoodsDescValue = v1;
            });
            DS.AddOnChange<CertShip>(x => x.CSJobNo, data =>
            {
                var j = DS.GetByField<Job>(x => x.JobId, data.CSJobNoValue);
                data.CSShipValue = j.JobFerryNameValue;
                data.CSDateValue = j.JobFerryDateValue;
                data.CSTimeValue = j.JobFerryTimeValue;
                data.CSVehicleValue = j.JobVehNoValue;

                string SQL =
                    "SELECT FRId FROM FerryRoute INNER JOIN Job ON FerryRoute.FRName = Job.JobRouteFrom WHERE JobNo='" +
                    data.CSJobNoValue + "'";
                string v1 = IQApp.DB.GetString(SQL);

                SQL = "SELECT FRId FROM FerryRoute INNER JOIN Job ON FerryRoute.FRName = Job.JobRouteTo WHERE JobNo='" +
                      data.CSJobNoValue + "'";
                v1 = v1 + " - " + IQApp.DB.GetString("FRId");
                data.CSRouteValue = v1;
            });
        }
    }
}