using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class MonthRange : FTLQueryScreen
    {
        public int StartMonthValue { get; set; }
        public int EndMonthValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            StartMonthValue = xf.GetInt("StartMonthValue");
            EndMonthValue = xf.GetInt("EndMonthValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (StartMonthValue > 0)
                wd.Add("StartMonthValue", StartMonthValue);
            if(EndMonthValue > 0)
                wd.Add("EndMonthValue", EndMonthValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetInt("StartMonthValue") == 0)
                populated = false;
            if (xf.GetInt("EndMonthValue") == 0)
                populated = false;

            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"StartMonthValue={StartMonthValue}&EndMonthValue={EndMonthValue}";
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='StartMonthValue' value='{StartMonthValue}' /><input type='hidden' name='EndMonthValue' value='{EndMonthValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Start Month:</label><select name='StartMonthValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"select MthId as KeyValue, MthNAme as [Description] from Months
            ").Select(f => $" < option value='{f.KeyValue}'>{f.Description}</option>"))}</select><br />
<label>End Month:</label><select name='EndMonthValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"select MthId as KeyValue, MthNAme as [Description] from Months
            ").Select(f => $" < option value='{f.KeyValue}'>{f.Description}</option>"))}</select><br />

    ";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            StartMonthValue = xf.GetInt("StartMonthValue");
            EndMonthValue = xf.GetInt("EndMonthValue");
        }
    }
}