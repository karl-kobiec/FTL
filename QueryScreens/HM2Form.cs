using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class HM2Form : FTLQueryScreen
    {
        public int SelectionValue { get; set; }
        public DateTime DateFromValue { get; set; }
        public DateTime DateToValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("ToValue");
            SelectionValue = xf.GetInt("SelectionValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (DateFromValue > DateTime.MinValue)
                wd.Add("DateFromValue", DateFromValue.ToLongDateString());
            if (DateToValue > DateTime.MinValue)
                wd.Add("ToValue", DateToValue.ToLongDateString());
            if (SelectionValue > 0)
                wd.Add("SelectionValue", SelectionValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetDateTime("DateFromValue") == DateTime.MinValue)
                populated = false;
            if (xf.GetDateTime("DateToValue") == DateTime.MinValue)
                populated = false;
            if (xf.GetInt("SelectionValue") == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"SelectionValue={SelectionValue}&DateFromValue={DateFromValue}&ToValue={DateToValue}";
        }

        public override string ToHTML()
        {
            return $@"<input type='hidden' name='DateFromValue' value='{DateFromValue.ToString("dd MMM yy")}' />
<input type='hidden' name='DateToValue' value='{DateToValue.ToString("dd MMM yy")}' />
<input type='hidden' name='SelectionValue' value='{SelectionValue}'/>";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><input name='DateFromValue' class='form-control dateBox' type='text' /><br />
<label>To:</label><input name='DateToValue' class='form-control dateBox' type='text' /><br />
<label>Selection:</label><select name='SelectionValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"select 0 as KeyValue, 'All' as [Description] union 
                                    select 1 as KeyVAlue, 'All FTL' as [Description]
                                union select 3 as KeyValue, 'Selected Customer' as [Description]
            ").Select(f => $" < option value='{f.KeyValue}'>{f.Description}</option>"))}</select><br />";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("DateToValue");
            SelectionValue = xf.GetInt("SelectionValue");
        }
    }
}