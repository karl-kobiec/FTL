using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class UnDecWithMonth : FTLQueryScreen
    {
        public bool UnDecOnlyValue { get; set; }
        public int MonthValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            UnDecOnlyValue = xf.GetBool("UnDecOnlyValue");
            MonthValue = xf.GetInt("MonthValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            wd.Add("UnDecOnlyValue", UnDecOnlyValue);
            if (MonthValue > 0)
                wd.Add("MonthValue", MonthValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetInt("MonthValue") == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"UnDecOnlyValue={UnDecOnlyValue}&MonthValue={MonthValue}";
        }

        public override string ToHTML()
        {
            return $@"<input type='hidden' name='UnDecOnlyValue' value='{UnDecOnlyValue}' /><input type='hidden' name='MonthValue' value='{MonthValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Month:</label>

<br />
<label><input type='checkbox' name='UnDecOnlyValue' value='true' />Undeclared records only</label><br />";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            UnDecOnlyValue = xf.GetBool("UnDecOnlyValue");
            MonthValue = xf.GetInt("MonthValue");

        }
    }
}