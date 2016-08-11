using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class ExciseSummary : FTLQueryScreen
    {
        public bool SepPageValue { get; set; }
        public DateTime DateFromValue { get; set; }
        public DateTime DateToValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("ToValue");
            SepPageValue = xf.GetBool("SepPageValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (DateFromValue > DateTime.MinValue)
                wd.Add("DateFromValue", DateFromValue.ToLongDateString());
            if (DateToValue > DateTime.MinValue)
                wd.Add("ToValue", DateToValue.ToLongDateString());
            wd.Add("SepPageValue", SepPageValue);
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
            return $"SepPageValue={SepPageValue}&DateFromValue={DateFromValue}&ToValue={DateToValue}";
        }

        public override string ToHTML()
        {
            return $@"<input type='hidden' name='DateFromValue' value='{DateFromValue.ToString("dd MMM yy")}' />
<input type='hidden' name='DateToValue' value='{DateToValue.ToString("dd MMM yy")}' /><input type='hidden' name='SepPageValue' value='{SepPageValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><input name='DateFromValue' class='form-control dateBox' type='text' /><br />
<label>To:</label><input name='DateToValue' class='form-control dateBox' type='text' /><br />
<label><input name='SepPageValue' value='true' type='checkbox' /> Show separate page</label><br />
";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("DateToValue");
            SepPageValue = xf.GetBool("SepPageValue");
        }
    }
}