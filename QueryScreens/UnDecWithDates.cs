using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class UnDecWithDates : FTLQueryScreen
    {
        public bool UnDecOnlyValue { get; set; }
        public DateTime DateFromValue { get; set; }
        public DateTime DateToValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            UnDecOnlyValue = xf.GetBool("UnDecOnlyValue");
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("ToValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            wd.Add("UnDecOnlyValue", UnDecOnlyValue);
            if (DateFromValue > DateTime.MinValue)
                wd.Add("DateFromValue", DateFromValue.ToLongDateString());
            if (DateToValue > DateTime.MinValue)
                wd.Add("ToValue", DateToValue.ToLongDateString());
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetDateTime("DateFromValue") == DateTime.MinValue)
                populated = false;
            if (xf.GetDateTime("DateToValue") == DateTime.MinValue)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"UnDecOnlyValue={UnDecOnlyValue}&DateFromValue={DateFromValue}&ToValue={DateToValue}";
        }

        public override string ToHTML()
        {
            return $@"<input type='hidden' name='UnDecOnlyValue' value='{UnDecOnlyValue}' /><input type='hidden' name='DateFromValue' value='{DateFromValue.ToString("dd MMM yy")}' />
<input type='hidden' name='DateToValue' value='{DateToValue.ToString("dd MMM yy")}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><input name='DateFromValue' class='form-control dateBox' type='text' /><br />
<label>To:</label><input name='DateToValue' class='form-control dateBox' type='text' /><br />
<label><input type='checkbox' name='UnDecOnlyValue' value='true' />Undeclared records only</label><br />";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            UnDecOnlyValue = xf.GetBool("UnDecOnlyValue");
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("DateToValue");
        }
    }
}