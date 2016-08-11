using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public class TruckMileageCalc
    {
        public int RecordId { get; set; }
        public string TrkMOdometer {get;set;}
    }
    public partial class TruckMileageRegister
    {
        public static void Register()
        {
            DS.AddOnLoad<TruckMileage>(data=> {
                if (data.RecordID.HasValue)
                {
                    var itms = IQApp.DB.Load<TruckMileageCalc>("SELECT TrkMTruck, TrkMOdometer FROM TruckMileage WHERE Truck=" + data.TrkMTruckValue + " AND RecordId<>" + data.RecordID.Value
                        + " AND TrkMPurchDate<'" + data.TrkMPurchDateValue.ToSQLString() + "' ORDER BY TrkMPurchDate DESC");
                  
                    if (itms.Any())
                    {
                        DS.SetValueByKey<TruckMileage>(x=> x.TrkMNextReading, itms.First().TrkMOdometer, itms.First().RecordId);
                        IQApp.DB.Execute("UPDATE TruckMileage SET Mpg=(TrkMNextReading-TrkMOdometer)*0.621371192/(TrkMPurchLitre*0.219969157) WHERE RecordID=" + itms.First().RecordId);
                    }
                }
            });
            DS.AddOnChange<TruckMileage>(x=> x.TrkMOdometer, data=> {
                string SQL = "SELECT Max(TrkMOdometer) AS Last FROM TruckMileage WHERE Truck=" + data.TrkMTruckValue + " AND RecordID<>" + data.RecordID.Value;
                int i = IQApp.DB.GetInt(SQL);
                if (i > 0)
                {
                    int LastOdo = i;
                    if (data.TrkMOdometerValue < LastOdo)
                    {
                        IQApp.CR.MessageBoxOK("TrkMOdometer reading entered is less than the highest reading entered for this truck. Please check and make sure this is correct.");
                    }
                    if ((data.TrkMOdometerValue - LastOdo) > 2500)
                    {
                        IQApp.CR.MessageBoxOK("TrkMOdometer reading is more than 2500km more than the previous highest reading entered for this truck. Please check and make sure this is correct.");
                    }
                }
            });
        }
       
    }
}