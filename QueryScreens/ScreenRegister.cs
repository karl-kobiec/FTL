using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class FTLScreenMapper : IScreenMapper
    {
        public IReportBase GetScreenModel(string name)
        {
            switch (name)
            {
                case "DateFrom":
                    return new FTL.QueryScreens.DateFrom();
                case "StaffSelect":
                    return new FTL.QueryScreens.StaffSelect();
                case "DateFromTo":
                    return new FTL.QueryScreens.DateFromTo();
                case "DateType":
                    return new DateType();
                case "ExciseDetail":
                    return new ExciseDetail();
                case "ExciseSummary":
                    return new ExciseSummary();
                case "HM2Form":
                    return new HM2Form();
                case  "JobSingle":
                    return new JobSingle();
                case "SummaryDetail":
                    return new SummaryDetail();
                case  "TransportDet":
                    return new TransportDet();
                case  "UnDecWithDates":
                    return new UnDecWithDates();
                case  "UnDecWithMonth":
                    return new UnDecWithMonth();
                case  "Zone":
                    return new Zone();
            }
            return null;
        }

        public string QueryScreensAsQuery()
        {
            Dictionary<string, string> QueryScreens = new Dictionary<string, string>
            {
                {"DateFrom", "Date From"},
                {"DateFromTo", "Date From To"},
                {"DateType", "Date Type"},
                {"ExciseDetail", "Excise Detail"},
                {"ExciseSummary", "Excise Summary"},
                {"HM2Form", "HM2 Form"},
                {"JobSingle", "Job Single"},
                {"MonthRange", "Month Range"},
                {"StaffSelect", "Staff Select"},
                {"SummaryDetail", "Summary Detail"},
                {"TransportDet", "Transport Detail"},
                {"UnDecWithDates", "Undec with Dates"},
                {"UnDecWithMonth", "Undec with Month"},
                {"Zone", "Zone"}
            };
            return QueryScreens.ToSQLQuery();
        }
    }
}