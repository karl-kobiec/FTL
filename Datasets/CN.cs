using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using IQ6.Core;

namespace FTL
{
    public partial class CNRegister
    {
        public static void Register()
        {
            DS.AddOnChange<CN>(x=> x.CNCurr, data=> {
                if (data.CNCurrValue == 1) data.CNExchRateValue = 1;
                else
                    data.CNExchRateValue = DS.GetDoubleByClause<ExchRate>(x=> x.ExRRateValue,"ExRSDate<='" + data.CNDateValue.ToSQLString() + "' AND ExREDate>='" + data.CNDateValue.ToSQLString() + "'");
            });
            DS.AddOnChange<CN>(x => x.CNImpExp, data =>
            {
                if (data.RecordID.Value == 0)
                    data.CNIdValue =
                        IQApp.DB.GetInt("SELECT Max(CNId) AS Last FROM CN WHERE CNImpExp='" + data.CNImpExpValue + "'") +
                        1;

            });
            DS.AddOnChange<CN>(x => x.CNJobLetter, data =>
            {
                var o = DS.GetByFields<Orders>(x => x.OrdJobNo, data.CNJobNoValue, x => x.OrdJobLetter,
                    data.CNJobLetterValue);
                data.CNOrderValue = o.OrdIdValue;
                data.CNToValue = o.OrdCustValue;
                data.CNToIdValue = o.OrdCustValue;
                data.CNCustOrdValue = o.OrdCustOrdValue;
            });

            DS.AddOnChange<CN>(x => x.CNJobNo, data =>
            {
                var j = DS.GetByField<Job>(x => x.JobId, data.CNJobNoValue);
                data.CNVehicleValue = j.JobVehNoValue;
                data.CNTrailerValue = j.JobTrailerNoValue;
                data.CNRouteFromValue = j.JobRouteFromValue;
                data.CNRouteToValue = j.JobRouteToValue;
            });

            DS.AddOnChange<CN>(x => x.CNTo, data => {
                                                        data.CNToId.DataValue = data.CNToValue;
            });
            DS.AddOnChange<CN>(x => x.CNToId, data => {
                                                          data.CNTo.DataValue = data.CNToIdValue; });
        }
     
    }
}