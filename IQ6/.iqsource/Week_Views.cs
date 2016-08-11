using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Web.Mvc;
using IQ6.Core;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace FTL { 

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Weeks.cshtml")]
    public partial class Views_Week_Weeks_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Weeks_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 60), Tuple.Create("\'", 125)
, Tuple.Create(Tuple.Create("", 68), Tuple.Create("IQLabel102311", 68), true)
, Tuple.Create(Tuple.Create(" ", 81), Tuple.Create<System.Object, System.Int32>(!Model.WkId.LabelVisible ? " hide " : ""
, 82), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 126), Tuple.Create("\'", 322)
   , Tuple.Create(Tuple.Create("", 135), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkId.BackHEXColor) ? "" : "color:" + Model.WkId.BackHEXColor + ";"
, 135), false)
, Tuple.Create(Tuple.Create("", 231), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 231), true)
);
WriteLiteral(">Week ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 400), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 408), Tuple.Create("form-control", 408), true)
, Tuple.Create(Tuple.Create("   ", 420), Tuple.Create<System.Object, System.Int32>(!Model.WkId.Visible ? " hide " : ""
, 423), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkId\' value=\'");
                                                                                                                                                                                                                                                                                                                                        Write(Model.WkId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 814), Tuple.Create("\'", 886)
, Tuple.Create(Tuple.Create("", 822), Tuple.Create("IQLabel102312", 822), true)
                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 835), Tuple.Create<System.Object, System.Int32>(!Model.WkBelongsTo.LabelVisible ? " hide " : ""
, 836), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 887), Tuple.Create("\'", 1098)
                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 896), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkBelongsTo.BackHEXColor) ? "" : "color:" + Model.WkBelongsTo.BackHEXColor + ";"
, 896), false)
, Tuple.Create(Tuple.Create("", 1006), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1006), true)
);
WriteLiteral(">Belongs to Period</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkBelongsTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.WkBelongsTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.WkBelongsTo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkBelongsTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkBelongsTo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkBelongsTo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.WkBelongsTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:50px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1704), Tuple.Create("\'", 1772)
, Tuple.Create(Tuple.Create("", 1712), Tuple.Create("IQLabel102313", 1712), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 1725), Tuple.Create<System.Object, System.Int32>(!Model.WkSDate.LabelVisible ? " hide " : ""
, 1726), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1773), Tuple.Create("\'", 1976)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkSDate.BackHEXColor) ? "" : "color:" + Model.WkSDate.BackHEXColor + ";"
, 1782), false)
, Tuple.Create(Tuple.Create("", 1884), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1884), true)
);
WriteLiteral(">Week Start (Mon)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkSDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.WkSDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.WkSDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkSDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkSDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkSDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.WkSDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2554), Tuple.Create("\'", 2626)
, Tuple.Create(Tuple.Create("", 2562), Tuple.Create("IQLabel102314", 2562), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 2575), Tuple.Create<System.Object, System.Int32>(!Model.WkSDateText.LabelVisible ? " hide " : ""
, 2576), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2627), Tuple.Create("\'", 2838)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2636), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkSDateText.BackHEXColor) ? "" : "color:" + Model.WkSDateText.BackHEXColor + ";"
, 2636), false)
, Tuple.Create(Tuple.Create("", 2746), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2746), true)
);
WriteLiteral(">Monday Text</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkSDateText\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 2927), Tuple.Create("\'", 2995)
, Tuple.Create(Tuple.Create("", 2935), Tuple.Create("form-control", 2935), true)
, Tuple.Create(Tuple.Create("   ", 2947), Tuple.Create<System.Object, System.Int32>(!Model.WkSDateText.Visible ? " hide " : ""
, 2950), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkSDateText/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkSDateText/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkSDateText\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.WkSDateText.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 3378), Tuple.Create("\'", 3446)
, Tuple.Create(Tuple.Create("", 3386), Tuple.Create("IQLabel102315", 3386), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 3399), Tuple.Create<System.Object, System.Int32>(!Model.WkEDate.LabelVisible ? " hide " : ""
, 3400), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3447), Tuple.Create("\'", 3651)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3456), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkEDate.BackHEXColor) ? "" : "color:" + Model.WkEDate.BackHEXColor + ";"
, 3456), false)
, Tuple.Create(Tuple.Create("", 3558), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3558), true)
);
WriteLiteral(">Week End (Sun)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkEDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.WkEDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.WkEDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkEDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkEDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkEDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.WkEDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 4228), Tuple.Create("\'", 4300)
, Tuple.Create(Tuple.Create("", 4236), Tuple.Create("IQLabel102316", 4236), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 4249), Tuple.Create<System.Object, System.Int32>(!Model.WkEDateText.LabelVisible ? " hide " : ""
, 4250), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4301), Tuple.Create("\'", 4513)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 4310), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WkEDateText.BackHEXColor) ? "" : "color:" + Model.WkEDateText.BackHEXColor + ";"
, 4310), false)
, Tuple.Create(Tuple.Create("", 4420), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 4420), true)
);
WriteLiteral(">Sunday Text</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Weeks_WkEDateText\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4602), Tuple.Create("\'", 4670)
, Tuple.Create(Tuple.Create("", 4610), Tuple.Create("form-control", 4610), true)
, Tuple.Create(Tuple.Create("   ", 4622), Tuple.Create<System.Object, System.Int32>(!Model.WkEDateText.Visible ? " hide " : ""
, 4625), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Week/SaveWkEDateText/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Week/CallbackWkEDateText/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWkEDateText\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.WkEDateText.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:128px;\'/>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Edit_1.cshtml")]
    public partial class Views_Week_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Edit_1_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/Week/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Weeks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 396), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 406), Tuple.Create("IQJSCall(\"/Week/Delete/?RecId=", 406), true)
     , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Week/V" +
"iewHistory/?RecId=");
                                                                                                 Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Week", Model.RecordID.Value))
                {
WriteLiteral("                   ");
                    Write(Html.Raw(elem.HTML));
WriteLiteral("\r\n");
                }
            }
WriteLiteral("\t\t\t\r\n\t\t\t</div>\r\n\t</div>\r\n");
}
WriteLiteral("\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentUrl\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1339), Tuple.Create("\'", 1361)
, Tuple.Create(Tuple.Create("", 1347), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1347), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1431)
, Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1415), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Week\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1529), Tuple.Create("\"", 1553)
, Tuple.Create(Tuple.Create("", 1537), Tuple.Create<System.Object, System.Int32>(Model.WkIdValue
, 1537), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1599), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1607), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1664), Tuple.Create("\"", 1687)
, Tuple.Create(Tuple.Create("", 1672), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1672), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Week/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1982), Tuple.Create("\"", 2080)
, Tuple.Create(Tuple.Create("", 1989), Tuple.Create("/Week/ViewHistory/?RecId=", 1989), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2014), false)
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create("&dt=", 2029), true)
, Tuple.Create(Tuple.Create("", 2033), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2033), false)
);
WriteLiteral(">");
                                                                                                                 Write(dt.UpdateDate.ToString("dd-MM hh:mm:ss"));
WriteLiteral("</a></td><td>");
                                                                                                                                                                       Write(dt.Username);
WriteLiteral("</td></tr>\r\n");
	}
WriteLiteral("\t");
Write(Html.Raw("</table></div><div class='col-sm-10'>"));
WriteLiteral("\r\n<label>Changes made on ");
                   Write((DateTime)ViewBag.HistoryCurrentDate);
WriteLiteral(" (highlighted in Red)</label>\r\n\t");
WriteLiteral("\r\n");
}
WriteLiteral("<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Weeks\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Week_Weeks.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n</div>\r\n\r\n");
 if(ViewBag.HistoryView == true) {
Write(Html.Raw("</div></div>"));
                             ;
}
WriteLiteral("\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2854), Tuple.Create("\"", 2869)
, Tuple.Create(Tuple.Create("", 2861), Tuple.Create("#", 2861), true)
, Tuple.Create(Tuple.Create("", 2862), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2862), false)
);
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">");
                                                                                               Write(itm.Title);
WriteLiteral("</a></li>");
WriteLiteral("\r\n");
		}
WriteLiteral("\t</ul>\r\n");
WriteLiteral("\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 3085), Tuple.Create("\"", 3097)
, Tuple.Create(Tuple.Create("", 3090), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3090), false)
);
WriteLiteral(">");
                                                          Write(Html.Raw(itm.DrawContents(Model, "")));
WriteLiteral("</div>\r\n");
		}
WriteLiteral("\t</div>\r\n");
}
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Add_1.cshtml")]
    public partial class Views_Week_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Weeks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Weeks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Week/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n</div>\r\n<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Weeks\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Week_Weeks.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_List_1.cshtml")]
    public partial class Views_Week_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Week>>
    {
        public Views_Week_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Weeks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Weeks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Weeks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/ExportAll\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Export List</a>\r\n");
}
 if(ViewBag.MoreResults == true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"alert alert-warning\"");
WriteLiteral(">There are ");
                                          Write(ViewBag.ResultCount);
WriteLiteral(" results, only showing ");
                                                                                     Write(ViewBag.Limit);
WriteLiteral(", <a");
WriteAttribute("href", Tuple.Create(" href=\"", 480), Tuple.Create("\"", 547)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("/Week/ListFromQuery/?Clause=", 487), true)
                                                                , Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 515), false)
, Tuple.Create(Tuple.Create("", 530), Tuple.Create("&Ord=", 530), true)
                                                                                    , Tuple.Create(Tuple.Create("", 535), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 535), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                     Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Week ID</th><th>Week Start (Mon)</th><th>Week End (Sun)</th><th>" +
"Belongs to Period</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 900), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 907), Tuple.Create("/Week/Load/?RecId=", 907), true)
             , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.WkId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1243), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1254), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkSDate/?RecId=", 1254), true)
                                                                 , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'WkSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1384), Tuple.Create("\'", 1424)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkSDate.HTMLValue)
, 1392), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkEDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1610), Tuple.Create("\"", 1693)
, Tuple.Create(Tuple.Create("", 1621), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkEDate/?RecId=", 1621), true)
                                                                 , Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1669), false)
, Tuple.Create(Tuple.Create("", 1682), Tuple.Create("\',$(this));", 1682), true)
);
WriteLiteral(" data-bound-name=\'WkEDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1751), Tuple.Create("\'", 1791)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1759), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkEDate.HTMLValue)
, 1759), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkBelongsTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1981), Tuple.Create("\"", 2068)
, Tuple.Create(Tuple.Create("", 1992), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkBelongsTo/?RecId=", 1992), true)
                                                                     , Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2044), false)
, Tuple.Create(Tuple.Create("", 2057), Tuple.Create("\',$(this));", 2057), true)
);
WriteLiteral(" data-bound-name=\'WkBelongsTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2130), Tuple.Create("\'", 2174)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkBelongsTo.HTMLValue)
, 2138), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Edit_2.cshtml")]
    public partial class Views_Week_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Edit_2_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/Week/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Weeks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 396), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 406), Tuple.Create("IQJSCall(\"/Week/Delete/?RecId=", 406), true)
     , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Week/V" +
"iewHistory/?RecId=");
                                                                                                 Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Week", Model.RecordID.Value))
                {
WriteLiteral("                   ");
                    Write(Html.Raw(elem.HTML));
WriteLiteral("\r\n");
                }
            }
WriteLiteral("\t\t\t\r\n\t\t\t</div>\r\n\t</div>\r\n");
}
WriteLiteral("\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentUrl\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1339), Tuple.Create("\'", 1361)
, Tuple.Create(Tuple.Create("", 1347), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1347), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1431)
, Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1415), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Week\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1529), Tuple.Create("\"", 1553)
, Tuple.Create(Tuple.Create("", 1537), Tuple.Create<System.Object, System.Int32>(Model.WkIdValue
, 1537), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1599), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1607), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1664), Tuple.Create("\"", 1687)
, Tuple.Create(Tuple.Create("", 1672), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1672), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Week/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1982), Tuple.Create("\"", 2080)
, Tuple.Create(Tuple.Create("", 1989), Tuple.Create("/Week/ViewHistory/?RecId=", 1989), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2014), false)
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create("&dt=", 2029), true)
, Tuple.Create(Tuple.Create("", 2033), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2033), false)
);
WriteLiteral(">");
                                                                                                                 Write(dt.UpdateDate.ToString("dd-MM hh:mm:ss"));
WriteLiteral("</a></td><td>");
                                                                                                                                                                       Write(dt.Username);
WriteLiteral("</td></tr>\r\n");
	}
WriteLiteral("\t");
Write(Html.Raw("</table></div><div class='col-sm-10'>"));
WriteLiteral("\r\n<label>Changes made on ");
                   Write((DateTime)ViewBag.HistoryCurrentDate);
WriteLiteral(" (highlighted in Red)</label>\r\n\t");
WriteLiteral("\r\n");
}
WriteLiteral("<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Weeks\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Week_Weeks.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n</div>\r\n\r\n");
 if(ViewBag.HistoryView == true) {
Write(Html.Raw("</div></div>"));
                             ;
}
WriteLiteral("\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2854), Tuple.Create("\"", 2869)
, Tuple.Create(Tuple.Create("", 2861), Tuple.Create("#", 2861), true)
, Tuple.Create(Tuple.Create("", 2862), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2862), false)
);
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">");
                                                                                               Write(itm.Title);
WriteLiteral("</a></li>");
WriteLiteral("\r\n");
		}
WriteLiteral("\t</ul>\r\n");
WriteLiteral("\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 3085), Tuple.Create("\"", 3097)
, Tuple.Create(Tuple.Create("", 3090), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3090), false)
);
WriteLiteral(">");
                                                          Write(Html.Raw(itm.DrawContents(Model, "")));
WriteLiteral("</div>\r\n");
		}
WriteLiteral("\t</div>\r\n");
}
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Add_2.cshtml")]
    public partial class Views_Week_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Weeks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Weeks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Week/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n</div>\r\n<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Weeks\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Week_Weeks.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t</div>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_List_2.cshtml")]
    public partial class Views_Week_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Week>>
    {
        public Views_Week_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Weeks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Weeks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Weeks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/ExportAll\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Export List</a>\r\n");
}
 if(ViewBag.MoreResults == true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"alert alert-warning\"");
WriteLiteral(">There are ");
                                          Write(ViewBag.ResultCount);
WriteLiteral(" results, only showing ");
                                                                                     Write(ViewBag.Limit);
WriteLiteral(", <a");
WriteAttribute("href", Tuple.Create(" href=\"", 480), Tuple.Create("\"", 547)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("/Week/ListFromQuery/?Clause=", 487), true)
                                                                , Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 515), false)
, Tuple.Create(Tuple.Create("", 530), Tuple.Create("&Ord=", 530), true)
                                                                                    , Tuple.Create(Tuple.Create("", 535), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 535), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                     Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Week ID</th><th>Week Start (Mon)</th><th>Week End (Sun)</th><th>" +
"Belongs to Period</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 900), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 907), Tuple.Create("/Week/Load/?RecId=", 907), true)
             , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.WkId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1243), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1254), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkSDate/?RecId=", 1254), true)
                                                                 , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'WkSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1384), Tuple.Create("\'", 1424)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkSDate.HTMLValue)
, 1392), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkEDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1610), Tuple.Create("\"", 1693)
, Tuple.Create(Tuple.Create("", 1621), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkEDate/?RecId=", 1621), true)
                                                                 , Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1669), false)
, Tuple.Create(Tuple.Create("", 1682), Tuple.Create("\',$(this));", 1682), true)
);
WriteLiteral(" data-bound-name=\'WkEDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1751), Tuple.Create("\'", 1791)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1759), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkEDate.HTMLValue)
, 1759), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkBelongsTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1981), Tuple.Create("\"", 2068)
, Tuple.Create(Tuple.Create("", 1992), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkBelongsTo/?RecId=", 1992), true)
                                                                     , Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2044), false)
, Tuple.Create(Tuple.Create("", 2057), Tuple.Create("\',$(this));", 2057), true)
);
WriteLiteral(" data-bound-name=\'WkBelongsTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2130), Tuple.Create("\'", 2174)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkBelongsTo.HTMLValue)
, 2138), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Edit_3.cshtml")]
    public partial class Views_Week_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Edit_3_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/Week/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Weeks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 396), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 406), Tuple.Create("IQJSCall(\"/Week/Delete/?RecId=", 406), true)
     , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Week/V" +
"iewHistory/?RecId=");
                                                                                                 Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Week", Model.RecordID.Value))
                {
WriteLiteral("                   ");
                    Write(Html.Raw(elem.HTML));
WriteLiteral("\r\n");
                }
            }
WriteLiteral("\t\t\t\r\n\t\t\t</div>\r\n\t</div>\r\n");
}
WriteLiteral("\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentUrl\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1339), Tuple.Create("\'", 1361)
, Tuple.Create(Tuple.Create("", 1347), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1347), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1431)
, Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1415), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Week\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1529), Tuple.Create("\"", 1553)
, Tuple.Create(Tuple.Create("", 1537), Tuple.Create<System.Object, System.Int32>(Model.WkIdValue
, 1537), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1599), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1607), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1664), Tuple.Create("\"", 1687)
, Tuple.Create(Tuple.Create("", 1672), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1672), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Week/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1982), Tuple.Create("\"", 2080)
, Tuple.Create(Tuple.Create("", 1989), Tuple.Create("/Week/ViewHistory/?RecId=", 1989), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2014), false)
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create("&dt=", 2029), true)
, Tuple.Create(Tuple.Create("", 2033), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2033), false)
);
WriteLiteral(">");
                                                                                                                 Write(dt.UpdateDate.ToString("dd-MM hh:mm:ss"));
WriteLiteral("</a></td><td>");
                                                                                                                                                                       Write(dt.Username);
WriteLiteral("</td></tr>\r\n");
	}
WriteLiteral("\t");
Write(Html.Raw("</table></div><div class='col-sm-10'>"));
WriteLiteral("\r\n<label>Changes made on ");
                   Write((DateTime)ViewBag.HistoryCurrentDate);
WriteLiteral(" (highlighted in Red)</label>\r\n\t");
WriteLiteral("\r\n");
}
WriteLiteral("<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t</div>\r\n</div>\r\n\r\n");
 if(ViewBag.HistoryView == true) {
Write(Html.Raw("</div></div>"));
                             ;
}
WriteLiteral("\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2672), Tuple.Create("\"", 2687)
, Tuple.Create(Tuple.Create("", 2679), Tuple.Create("#", 2679), true)
, Tuple.Create(Tuple.Create("", 2680), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2680), false)
);
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">");
                                                                                               Write(itm.Title);
WriteLiteral("</a></li>");
WriteLiteral("\r\n");
		}
WriteLiteral("\t</ul>\r\n");
WriteLiteral("\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n");
                 foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 2903), Tuple.Create("\"", 2915)
, Tuple.Create(Tuple.Create("", 2908), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2908), false)
);
WriteLiteral(">");
                                                          Write(Html.Raw(itm.DrawContents(Model, "")));
WriteLiteral("</div>\r\n");
		}
WriteLiteral("\t</div>\r\n");
}
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_Add_3.cshtml")]
    public partial class Views_Week_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Week>
    {
        public Views_Week_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Weeks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Weeks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Week/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Week>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n</div>\r\n<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t</div>");
        }
    }
}

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    using FTL;
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Week_List_3.cshtml")]
    public partial class Views_Week_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Week>>
    {
        public Views_Week_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Weeks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Weeks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Weeks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Week/ExportAll\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Export List</a>\r\n");
}
 if(ViewBag.MoreResults == true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"alert alert-warning\"");
WriteLiteral(">There are ");
                                          Write(ViewBag.ResultCount);
WriteLiteral(" results, only showing ");
                                                                                     Write(ViewBag.Limit);
WriteLiteral(", <a");
WriteAttribute("href", Tuple.Create(" href=\"", 480), Tuple.Create("\"", 547)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("/Week/ListFromQuery/?Clause=", 487), true)
                                                                , Tuple.Create(Tuple.Create("", 515), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 515), false)
, Tuple.Create(Tuple.Create("", 530), Tuple.Create("&Ord=", 530), true)
                                                                                    , Tuple.Create(Tuple.Create("", 535), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 535), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                     Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Week ID</th><th>Week Start (Mon)</th><th>Week End (Sun)</th><th>" +
"Belongs to Period</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 900), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 907), Tuple.Create("/Week/Load/?RecId=", 907), true)
             , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.WkId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1243), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1254), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkSDate/?RecId=", 1254), true)
                                                                 , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'WkSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1384), Tuple.Create("\'", 1424)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1392), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkSDate.HTMLValue)
, 1392), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkEDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1610), Tuple.Create("\"", 1693)
, Tuple.Create(Tuple.Create("", 1621), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkEDate/?RecId=", 1621), true)
                                                                 , Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1669), false)
, Tuple.Create(Tuple.Create("", 1682), Tuple.Create("\',$(this));", 1682), true)
);
WriteLiteral(" data-bound-name=\'WkEDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1751), Tuple.Create("\'", 1791)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1759), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkEDate.HTMLValue)
, 1759), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WkBelongsTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1981), Tuple.Create("\"", 2068)
, Tuple.Create(Tuple.Create("", 1992), Tuple.Create("javascript:IQAutoSave(\'/Week/SaveWkBelongsTo/?RecId=", 1992), true)
                                                                     , Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2044), false)
, Tuple.Create(Tuple.Create("", 2057), Tuple.Create("\',$(this));", 2057), true)
);
WriteLiteral(" data-bound-name=\'WkBelongsTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2130), Tuple.Create("\'", 2174)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WkBelongsTo.HTMLValue)
, 2138), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
