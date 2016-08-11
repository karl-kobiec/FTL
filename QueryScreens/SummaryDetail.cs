using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class SummaryDetail : FTLQueryScreen
    {
        public int  TypeValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            TypeValue = xf.GetInt("TypeValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (TypeValue >0)
                wd.Add("TypeValue", TypeValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetInt("TypeValue") == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"TypeValue={TypeValue}";
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='TypeValue' value='{TypeValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Type:</label><select name='TypeValue' class='form-control'><option value='1'>Summary</option><option value='2'>Detail</option></select>";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            TypeValue = xf.GetInt("TypeValue");
        }
    }
}