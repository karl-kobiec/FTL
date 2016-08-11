using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class TransportDet : FTLQueryScreen
    {
        public int StaffValue { get; set; }
        public int TypeValue { get; set; }

        public override IScreenBase PopulateFromWD(WebData xf)
        {
            StaffValue = xf.GetInt("StaffValue");
            TypeValue = xf.GetInt("TypeValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (StaffValue > 0)
                wd.Add("StaffValue", StaffValue);
            if (TypeValue > 0)
                wd.Add("TypeValue", TypeValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (StaffValue == 0)
                populated = false;
            if (TypeValue == 0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"&StaffValue={StaffValue}&TypeValue={TypeValue}";
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='TypeValue' value='{TypeValue}' /><input type='hidden' name='StaffValue' value='{StaffValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Staff:</label><select name='StaffValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.User.GetUsersAsPairs().Select(f => $"<option value='{f.KeyValue}'>{f.Description}</option>"))}</select><br />
<label>Type:</label><select name='StaffValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"select 0 as KeyValue, 'Full Load' as [Description] union
                                    select 1 as KeyVAlue, 'FTL Driver' as [Description]
                                union select 2 as KeyValue, 'Subcontractor' as [Description]
                               union select 3 as KeyValue, 'Tesco Load' as [Description]").Select(f => $"<option value='{f.KeyValue}'>{f.Description}</option>"))}</select>";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            StaffValue = xf.GetInt("StaffValue");
            TypeValue = xf.GetInt("TypeValue");
        }
    }
}