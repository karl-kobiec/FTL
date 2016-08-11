using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class StaffSelect : FTLQueryScreen
    {
        public int StaffValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            StaffValue = xf.GetInt("StaffValue");
            return this;
        }
        
        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (StaffValue > 0)
                wd.Add("StaffValue", StaffValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetInt("StaffValue") == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return "StaffValue=" + StaffValue;
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='StaffValue' value='{StaffValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>From:</label><select name='StaffValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.User.GetUsersAsPairs().Select(f => $"<option value='{f.KeyValue}'>{f.Description}</option>"))}</select>";
        }

        public override void UpdateFromWebData(WebData xf)
        {
            StaffValue = xf.GetInt("StaffValue");
        }
    }
}
