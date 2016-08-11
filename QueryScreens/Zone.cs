using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using IQ6.Core;

namespace FTL.QueryScreens
{
    public class Zone : FTLQueryScreen
    {
        public int ZoneValue { get; set; }
        public override IScreenBase PopulateFromWD(WebData xf)
        {
            ZoneValue = xf.GetInt("ZoneValue");
            return this;
        }

        public override WebData ToPairList()
        {
            var wd = new WebData();
            if (ZoneValue > 0)
                wd.Add("ZoneValue", ZoneValue);
            return wd;
        }

        public override bool IsPopulated(WebData xf)
        {
            bool populated = true;
            if (xf.GetInt("ZoneValue") >0)
                populated = false;
            if (string.IsNullOrEmpty(xf.GetString("RecordIDs")) && xf.GetString("AllRecords") == "")
                populated = false;
            return populated;
        }

        public override string ToParams()
        {
            return "ZoneValue=" + ZoneValue;
        }

        public override string ToHTML()
        {
            return $"<input type='hidden' name='ZoneValue' value='{ZoneValue}' />";
        }

        public override string ExecuteView()
        {
            return
                $@"<label>Zone:</label><select name='ZoneValue' class='form-control'>
                {string.Join(
                    "",
                    IQApp.DB.Load<Pair<string, string>>(@"select * from (
                select 0 as KeyValue, '*All Zones' as [Description]
union select 11 as KeyValue, 'Northampton (Tesco)' as [Description]
union select 12 as KeyValue, 'Corsham' as [Description]
union select 13 as KeyValue, 'Nailsea' as [Description]
union select 14 as KeyValue, 'Burton-on-Trent' as [Description]
union select 15 as KeyValue, 'Preston' as [Description]
union select 16 as KeyValue, 'Rotherham' as [Description]
union select 17 as KeyValue, 'London E16' as [Description]
union select 18 as KeyValue, 'Hoddesdon' as [Description]
union select 19 as KeyValue, 'Dorchester' as [Description]
union select 20 as KeyValue, 'Barking' as [Description]
union select 21 as KeyValue, 'Basildon (Schenker)' as [Description]
union select 22 as KeyValue, 'Cirencester' as [Description]
union select 23 as KeyValue, 'Tilbury' as [Description]
union select 24 as KeyValue, 'Basildon (Eurobox)' as [Description]
union select 25 as KeyValue, 'Coventry (Morrisons)' as [Description]
union select 26 as KeyValue, 'Scotland' as [Description]
union select 27 as KeyValue, 'Moulton (Tesco)' as [Description]
union select 28 as KeyValue, 'Belvedere' as [Description]
union select 31 as KeyValue, 'North WEST' as [Description]
union select 32 as KeyValue, 'East Anglia' as [Description]
union select 33 as KeyValue, 'Midlands' as [Description]
union select 34 as KeyValue, 'Wales & Bristol' as [Description]
union select 35 as KeyValue, 'London' as [Description]
union select 36 as KeyValue, 'South-East' as [Description]
union select 37 as KeyValue, 'South-West' as [Description]
union select 38 as KeyValue, 'North EAST' as [Description]
union select 39 as KeyValue, 'Home Counties' as [Description]
union select 40 as KeyValue, 'Wakefield (Morrisons)' as [Description]
union select 41 as KeyValue, 'Basingstoke' as [Description]
union select 42 as KeyValue, 'West Hallam' as [Description]
union select 43 as KeyValue, 'Theale (Nr Reading)' as [Description]
union select 44 as KeyValue, 'Northampton (Morrisons)' as [Description]) P order by P.[Description]
            ").Select(f => $" < option value='{f.KeyValue}'>{f.Description}</option>"))}</select>";
        }

        public override void UpdateFromWebData(WebData xf)
        {
            ZoneValue = xf.GetInt("ZoneValue");
        }
    }
}