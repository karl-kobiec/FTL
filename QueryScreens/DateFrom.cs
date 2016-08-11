using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class DateFrom : FTLQueryScreen
    {
        public DateTime DateFromValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (DateFromValue > DateTime.MinValue)
                wd.Add("DateFromValue", DateFromValue.ToLongDateString());
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetDateTime("DateFromValue") == DateTime.MinValue)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return "DateFromValue=" + DateFromValue;
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='DateFromValue' value='{DateFromValue.ToString("dd MMM yy")}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><input name='DateFromValue' class='form-control dateBox' type='text' />";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
        }
    }
}