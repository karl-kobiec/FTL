using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class DriverHrsRegister
    {
        public static void Register()
        {
            DS.AddOnAdd<DriverHrs>(OnAddOrSave);
            DS.AddOnSave<DriverHrs>(OnAddOrSave);
        }
      
        public static void OnAddOrSave(DriverHrs data)
        {
            TimeSpan Diff = DateTime.Today - Convert.ToDateTime("4 April 2005");
            int wk = Diff.Days;
            wk = wk / 7;

            int BelTo = DS.GetIntByKey<Week>(x => x.WkBelongsToValue, wk);
            string SQL = "SELECT Min(WkId) AS PS FROM Week WHERE WkBelongsTo=" + BelTo;
            int x2 = IQApp.DB.GetInt(SQL);
            int x4;
            int x5;

            int SD = DS.GetIntByKey<Driver>(x=> x.DrvSDateValue,data.DrvHDriverValue);
            if (SD <= x2)
            {
                wk = wk - x2 + 1;
                x4 = 26 - wk;
                x5 = 1248;
            }
            else
            {
                wk = wk - SD + 1;
                x4 = (x2 - SD + 26);
                x5 = x4 * 48;
                x4 = x4 - wk;
            }
            if (x4 == 0) x4 = 1;

            SQL = "SELECT Sum(DrvHHrs) AS Total FROM DriverHrs INNER JOIN Week ON DriverHrs.DrvHWk = Week.WkId WHERE WkBelongsTo=" + BelTo + " AND DrvHDriver=" + data.DrvHDriverValue;
            int Total = IQApp.DB.GetInt(SQL);
            SQL = "UPDATE Driver SET DrvHrsWorked=" + Total + ", DrvHrsLeft=" + (x5 - Total) +
                ", DrvAvgHrsWorked=" + (Total / wk)
                + ", DrvAvgHrsLeft=" + ((x5 - Total / x4)) + " WHERE DrvId=" + data.DrvHDriverValue;
            IQApp.DB.Execute(SQL);
        }
    }
}