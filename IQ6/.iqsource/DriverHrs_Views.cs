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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_DriverHours.cshtml")]
    public partial class Views_DriverHrs_DriverHours_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_DriverHours_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 65), Tuple.Create("\'", 136)
, Tuple.Create(Tuple.Create("", 73), Tuple.Create("IQLabel102411", 73), true)
, Tuple.Create(Tuple.Create(" ", 86), Tuple.Create<System.Object, System.Int32>(!Model.DrvHDriver.LabelVisible ? " hide " : ""
, 87), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 137), Tuple.Create("\'", 345)
         , Tuple.Create(Tuple.Create("", 146), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvHDriver.BackHEXColor) ? "" : "color:" + Model.DrvHDriver.BackHEXColor + ";"
, 146), false)
, Tuple.Create(Tuple.Create("", 254), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 254), true)
);
WriteLiteral(">Driver</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'DriverHours_DrvHDriver\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHDriver/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DriverHrs/CallbackDrvHDriver/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                               Write(!Model.DrvHDriver.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/DriverHrs/AutoCompleteDrvHDriver/");
                                                   Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateDrvHDriver\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateDrvHDriver.ToString() != "" && Model.PopulateDrvHDriver.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.DrvHDriver.HTMLValue));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select><div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral("><button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs dropdown-toggle\"");
WriteLiteral(" data-toggle=\"dropdown\"");
WriteLiteral(" aria-haspopup=\"true\"");
WriteLiteral(" aria-expanded=\"false\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/popover.png\'");
WriteLiteral(" style=\'max-height:10px;\'");
WriteLiteral("/></button>\r\n        <ul");
WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");
WriteLiteral(">\r\n\t\t\t\r\n\t\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'if($($(this).attr(\"data-target\")).val() != \"0\") { IQTargetButton(this) " +
"} else { alert(\"No record selected\"); }\'");
WriteLiteral(" data-target=\"*[name=PopulateDrvHDriver]\"");
WriteLiteral(" data-url=\"/Driver/Load/?DrvId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Driver/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Drivers</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1980), Tuple.Create("\'", 2047)
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create("IQLabel102412", 1988), true)
, Tuple.Create(Tuple.Create(" ", 2001), Tuple.Create<System.Object, System.Int32>(!Model.DrvHWk.LabelVisible ? " hide " : ""
, 2002), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2048), Tuple.Create("\'", 2249)
                        , Tuple.Create(Tuple.Create("", 2057), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvHWk.BackHEXColor) ? "" : "color:" + Model.DrvHWk.BackHEXColor + ";"
, 2057), false)
, Tuple.Create(Tuple.Create("", 2157), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 2157), true)
);
WriteLiteral(">Week</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'DriverHours_DrvHWk\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvHWk.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                     Write(!Model.DrvHWk.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHWk/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DriverHrs/CallbackDrvHWk/',$(this));\""));
WriteLiteral("   name=\'PopulateDrvHWk\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.DrvHWk.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2902), Tuple.Create("\'", 2923)
, Tuple.Create(Tuple.Create("", 2910), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2910), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateDrvHWk.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                       Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral("><button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs dropdown-toggle\"");
WriteLiteral(" data-toggle=\"dropdown\"");
WriteLiteral(" aria-haspopup=\"true\"");
WriteLiteral(" aria-expanded=\"false\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/popover.png\'");
WriteLiteral(" style=\'max-height:10px;\'");
WriteLiteral("/></button>\r\n        <ul");
WriteLiteral(" class=\"dropdown-menu dropdown-menu-right\"");
WriteLiteral(">\r\n\t\t\t\r\n\t\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'if($($(this).attr(\"data-target\")).val() != \"0\") { IQTargetButton(this) " +
"} else { alert(\"No record selected\"); }\'");
WriteLiteral(" data-target=\"*[name=PopulateDrvHWk]\"");
WriteLiteral(" data-url=\"/Week/Load/?WkId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Week/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Weeks</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3788), Tuple.Create("\'", 3856)
, Tuple.Create(Tuple.Create("", 3796), Tuple.Create("IQLabel102413", 3796), true)
, Tuple.Create(Tuple.Create(" ", 3809), Tuple.Create<System.Object, System.Int32>(!Model.DrvHHrs.LabelVisible ? " hide " : ""
, 3810), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3857), Tuple.Create("\'", 4060)
                         , Tuple.Create(Tuple.Create("", 3866), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvHHrs.BackHEXColor) ? "" : "color:" + Model.DrvHHrs.BackHEXColor + ";"
, 3866), false)
, Tuple.Create(Tuple.Create("", 3968), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 3968), true)
);
WriteLiteral(">Hours</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriverHours_DrvHHrs\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvHHrs.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.DrvHHrs.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHHrs/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DriverHrs/CallbackDrvHHrs/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvHHrs\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.DrvHHrs.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Edit_1.cshtml")]
    public partial class Views_DriverHrs_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Edit_1_cshtml()
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
WriteLiteral(" >\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/DriverHrs/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"Hrs/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DriverHrs", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DriverHrs\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1524)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.DrvHDriverValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1570), Tuple.Create("\"", 1593)
, Tuple.Create(Tuple.Create("", 1578), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1578), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1635), Tuple.Create("\"", 1658)
, Tuple.Create(Tuple.Create("", 1643), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1643), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DriverHrs/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1958), Tuple.Create("\"", 2061)
, Tuple.Create(Tuple.Create("", 1965), Tuple.Create("/DriverHrs/ViewHistory/?RecId=", 1965), true)
, Tuple.Create(Tuple.Create("", 1995), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1995), false)
, Tuple.Create(Tuple.Create("", 2010), Tuple.Create("&dt=", 2010), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2014), false)
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
WriteLiteral(" id=\"DriverHours\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DriverHrs_DriverHours.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2852), Tuple.Create("\"", 2867)
, Tuple.Create(Tuple.Create("", 2859), Tuple.Create("#", 2859), true)
, Tuple.Create(Tuple.Create("", 2860), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2860), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3083), Tuple.Create("\"", 3095)
, Tuple.Create(Tuple.Create("", 3088), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3088), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Add_1.cshtml")]
    public partial class Views_DriverHrs_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Driver Hours";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Driver Hours\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DriverHrs/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DriverHours\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DriverHrs_DriverHours.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_List_1.cshtml")]
    public partial class Views_DriverHrs_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DriverHrs>>
    {
        public Views_DriverHrs_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Driver Hours List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Driver Hours List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Driver Hours</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 588)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DriverHrs/ListFromQuery/?Clause=", 523), true)
                                                                     , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 556), false)
, Tuple.Create(Tuple.Create("", 571), Tuple.Create("&Ord=", 571), true)
                                                                                         , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 576), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver</th><th>Week</th><th>Hours</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 893), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 900), Tuple.Create("/DriverHrs/Load/?RecId=", 900), true)
                  , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvHDriver.DisplayValue);
WriteLiteral("</td>");
                                                                                              if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHWk.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1244), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHWk/?RecId=", 1255), true)
                                                                   , Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1307), false)
, Tuple.Create(Tuple.Create("", 1320), Tuple.Create("\',$(this));", 1320), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvHWk\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.DrvHWk.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHHrs.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1602), Tuple.Create("\"", 1690)
, Tuple.Create(Tuple.Create("", 1613), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHHrs/?RecId=", 1613), true)
                                                                      , Tuple.Create(Tuple.Create("", 1666), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1666), false)
, Tuple.Create(Tuple.Create("", 1679), Tuple.Create("\',$(this));", 1679), true)
);
WriteLiteral(" data-bound-name=\'DrvHHrs\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1748), Tuple.Create("\'", 1788)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvHHrs.HTMLValue)
, 1756), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Edit_2.cshtml")]
    public partial class Views_DriverHrs_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Edit_2_cshtml()
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
WriteLiteral(" >\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/DriverHrs/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"Hrs/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DriverHrs", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DriverHrs\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1524)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.DrvHDriverValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1570), Tuple.Create("\"", 1593)
, Tuple.Create(Tuple.Create("", 1578), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1578), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1635), Tuple.Create("\"", 1658)
, Tuple.Create(Tuple.Create("", 1643), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1643), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DriverHrs/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1958), Tuple.Create("\"", 2061)
, Tuple.Create(Tuple.Create("", 1965), Tuple.Create("/DriverHrs/ViewHistory/?RecId=", 1965), true)
, Tuple.Create(Tuple.Create("", 1995), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1995), false)
, Tuple.Create(Tuple.Create("", 2010), Tuple.Create("&dt=", 2010), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2014), false)
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
WriteLiteral(" id=\"DriverHours\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DriverHrs_DriverHours.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2852), Tuple.Create("\"", 2867)
, Tuple.Create(Tuple.Create("", 2859), Tuple.Create("#", 2859), true)
, Tuple.Create(Tuple.Create("", 2860), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2860), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3083), Tuple.Create("\"", 3095)
, Tuple.Create(Tuple.Create("", 3088), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3088), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Add_2.cshtml")]
    public partial class Views_DriverHrs_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Driver Hours";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Driver Hours\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DriverHrs/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DriverHours\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DriverHrs_DriverHours.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_List_2.cshtml")]
    public partial class Views_DriverHrs_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DriverHrs>>
    {
        public Views_DriverHrs_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Driver Hours List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Driver Hours List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Driver Hours</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 588)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DriverHrs/ListFromQuery/?Clause=", 523), true)
                                                                     , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 556), false)
, Tuple.Create(Tuple.Create("", 571), Tuple.Create("&Ord=", 571), true)
                                                                                         , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 576), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver</th><th>Week</th><th>Hours</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 893), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 900), Tuple.Create("/DriverHrs/Load/?RecId=", 900), true)
                  , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvHDriver.DisplayValue);
WriteLiteral("</td>");
                                                                                              if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHWk.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1244), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHWk/?RecId=", 1255), true)
                                                                   , Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1307), false)
, Tuple.Create(Tuple.Create("", 1320), Tuple.Create("\',$(this));", 1320), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvHWk\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.DrvHWk.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHHrs.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1602), Tuple.Create("\"", 1690)
, Tuple.Create(Tuple.Create("", 1613), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHHrs/?RecId=", 1613), true)
                                                                      , Tuple.Create(Tuple.Create("", 1666), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1666), false)
, Tuple.Create(Tuple.Create("", 1679), Tuple.Create("\',$(this));", 1679), true)
);
WriteLiteral(" data-bound-name=\'DrvHHrs\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1748), Tuple.Create("\'", 1788)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvHHrs.HTMLValue)
, 1756), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Edit_3.cshtml")]
    public partial class Views_DriverHrs_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Edit_3_cshtml()
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
WriteLiteral(" >\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/DriverHrs/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"Hrs/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DriverHrs", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DriverHrs\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1524)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.DrvHDriverValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1570), Tuple.Create("\"", 1593)
, Tuple.Create(Tuple.Create("", 1578), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1578), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1635), Tuple.Create("\"", 1658)
, Tuple.Create(Tuple.Create("", 1643), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1643), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DriverHrs/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1958), Tuple.Create("\"", 2061)
, Tuple.Create(Tuple.Create("", 1965), Tuple.Create("/DriverHrs/ViewHistory/?RecId=", 1965), true)
, Tuple.Create(Tuple.Create("", 1995), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1995), false)
, Tuple.Create(Tuple.Create("", 2010), Tuple.Create("&dt=", 2010), true)
, Tuple.Create(Tuple.Create("", 2014), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2014), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2653), Tuple.Create("\"", 2668)
, Tuple.Create(Tuple.Create("", 2660), Tuple.Create("#", 2660), true)
, Tuple.Create(Tuple.Create("", 2661), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2661), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2884), Tuple.Create("\"", 2896)
, Tuple.Create(Tuple.Create("", 2889), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2889), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_Add_3.cshtml")]
    public partial class Views_DriverHrs_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DriverHrs>
    {
        public Views_DriverHrs_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Driver Hours";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Driver Hours\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DriverHrs/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DriverHrs>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DriverHrs_List_3.cshtml")]
    public partial class Views_DriverHrs_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DriverHrs>>
    {
        public Views_DriverHrs_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Driver Hours List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Driver Hours List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Driver Hours</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DriverHrs/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 588)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DriverHrs/ListFromQuery/?Clause=", 523), true)
                                                                     , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 556), false)
, Tuple.Create(Tuple.Create("", 571), Tuple.Create("&Ord=", 571), true)
                                                                                         , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 576), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver</th><th>Week</th><th>Hours</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 893), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 900), Tuple.Create("/DriverHrs/Load/?RecId=", 900), true)
                  , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvHDriver.DisplayValue);
WriteLiteral("</td>");
                                                                                              if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHWk.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1244), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1255), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHWk/?RecId=", 1255), true)
                                                                   , Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1307), false)
, Tuple.Create(Tuple.Create("", 1320), Tuple.Create("\',$(this));", 1320), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvHWk\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.DrvHWk.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvHHrs.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1602), Tuple.Create("\"", 1690)
, Tuple.Create(Tuple.Create("", 1613), Tuple.Create("javascript:IQAutoSave(\'/DriverHrs/SaveDrvHHrs/?RecId=", 1613), true)
                                                                      , Tuple.Create(Tuple.Create("", 1666), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1666), false)
, Tuple.Create(Tuple.Create("", 1679), Tuple.Create("\',$(this));", 1679), true)
);
WriteLiteral(" data-bound-name=\'DrvHHrs\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1748), Tuple.Create("\'", 1788)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvHHrs.HTMLValue)
, 1756), false)
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
