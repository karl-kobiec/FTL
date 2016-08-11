using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class DateType : FTLQueryScreen
    {
        public int DateTypeValue { get; set; }
        public DateTime DateFromValue { get; set; }
        public DateTime DateToValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("ToValue");
            DateTypeValue = xf.GetInt("DateTypeValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (DateFromValue > DateTime.MinValue)
                wd.Add("DateFromValue", DateFromValue.ToLongDateString());
            if (DateToValue > DateTime.MinValue)
                wd.Add("ToValue", DateToValue.ToLongDateString());
            if (DateTypeValue > 0)
                wd.Add("DateTypeValue", DateTypeValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetDateTime("DateFromValue") == DateTime.MinValue)
                populated = false;
            if (xf.GetDateTime("DateToValue") == DateTime.MinValue)
                populated = false;
            if (xf.GetInt("DateTypeValue") == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"DateFromValue={DateFromValue}&ToValue={DateToValue}&DateTypeValue={DateTypeValue}";
        }

        public override string ToHTML()
        {
            return $@"<input type='hidden' name='DateFromValue' value='{DateFromValue.ToString("dd MMM yy")}' />
<input type='hidden' name='DateToValue' value='{DateToValue.ToString("dd MMM yy")}' />
<input type='hidden' name='DateTypeValue' value='{DateTypeValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><input name='DateFromValue' class='form-control dateBox' type='text' /><br />
<label>To:</label><input name='DateToValue' class='form-control dateBox' type='text' /><br />
<label>Date Type:</label><select name='DateTypeValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"
               select 1 as KeyValue, 'Order Date' as [Description]
                    union select 2 as KeyValue, 'Required Date' as [Description]
                    union select 3 as KeyValue, 'Available Date' as [Description]
                    union select 4 as KeyValue, 'Collection Date' as [Description]
                    union select 5 as KeyValue, 'Delivery Date' as [Description]
            ").Select(f => $" < option value='{f.KeyValue}'>{f.Description}</option>"))}</select>";
       
        }

        public override void UpdateFromWebData(WebData xf)
        {
            DateFromValue = xf.GetDateTime("DateFromValue");
            DateToValue = xf.GetDateTime("DateToValue");
            DateTypeValue = xf.GetInt("DateTypeValue");
        }
    }
}