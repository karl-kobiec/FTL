using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class JobSingle : FTLQueryScreen
    {
        public int JobValue { get; set; }
        public int OrderValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            JobValue = xf.GetInt("JobValue");
            OrderValue = xf.GetInt("OrderValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (JobValue >0)
                wd.Add("JobValue", JobValue);
            if (OrderValue > 0)
                wd.Add("OrderValue", OrderValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;

            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return $"JobValue={JobValue}&OrderValue={OrderValue}";
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='JobValue' value='{JobValue}' /><input type='hidden' name='OrderValue' value='{OrderValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Job:</label><select name='JobValue' class='form-control searchautocomplete' data-ajaz--url='/Query/FindRecords/?DS=Job'></select><br />
<label>Order:</label><select name='OrderValue' class='form-control searchautocomplete' data-ajaz--url='/Query/FindRecords/?DS=Order'></select><br />
        ";

        }

        public override void UpdateFromWebData(WebData xf)
        {
            JobValue = xf.GetInt("JobValue");
            OrderValue = xf.GetInt("OrderValue");
        }
    }
}