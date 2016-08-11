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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_FerryRoutes.cshtml")]
    public partial class Views_FerryRoute_FerryRoutes_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_FerryRoutes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 66), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 74), Tuple.Create("IQLabel101111", 74), true)
, Tuple.Create(Tuple.Create(" ", 87), Tuple.Create<System.Object, System.Int32>(!Model.FRCode.LabelVisible ? " hide " : ""
, 88), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 335)
     , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FRCode.BackHEXColor) ? "" : "color:" + Model.FRCode.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 243), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 243), true)
);
WriteLiteral(">Route Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'FerryRoutes_FRCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.FRCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.FRCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/FerryRoute/CallbackFRCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateFRCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.FRCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 918), Tuple.Create("\'", 985)
, Tuple.Create(Tuple.Create("", 926), Tuple.Create("IQLabel101112", 926), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 939), Tuple.Create<System.Object, System.Int32>(!Model.FRName.LabelVisible ? " hide " : ""
, 940), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 986), Tuple.Create("\'", 1187)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 995), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FRName.BackHEXColor) ? "" : "color:" + Model.FRName.BackHEXColor + ";"
, 995), false)
, Tuple.Create(Tuple.Create("", 1095), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1095), true)
);
WriteLiteral(">Route</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'FerryRoutes_FRName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.FRName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                             Write(!Model.FRName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/FerryRoute/CallbackFRName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateFRName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.FRName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1774), Tuple.Create("\'", 1839)
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create("IQLabel101113", 1782), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 1795), Tuple.Create<System.Object, System.Int32>(!Model.FRId.LabelVisible ? " hide " : ""
, 1796), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1840), Tuple.Create("\'", 2036)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1849), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.FRId.BackHEXColor) ? "" : "color:" + Model.FRId.BackHEXColor + ";"
, 1849), false)
, Tuple.Create(Tuple.Create("", 1945), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 1945), true)
);
WriteLiteral(">Route Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'FerryRoutes_FRId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 2121), Tuple.Create("\'", 2182)
, Tuple.Create(Tuple.Create("", 2129), Tuple.Create("form-control", 2129), true)
, Tuple.Create(Tuple.Create("   ", 2141), Tuple.Create<System.Object, System.Int32>(!Model.FRId.Visible ? " hide " : ""
, 2144), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/FerryRoute/CallbackFRId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateFRId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                    Write(Model.FRId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Edit_1.cshtml")]
    public partial class Views_FerryRoute_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Edit_1_cshtml()
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
WriteLiteral(" href=\"/FerryRoute/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Ferry Routes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/FerryRoute/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/FerryR" +
"oute/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("FerryRoute", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1382), Tuple.Create("\'", 1404)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1390), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1450), Tuple.Create("\'", 1474)
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1458), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"FerryRoute\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1602)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.FRIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1648), Tuple.Create("\"", 1671)
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1656), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1713), Tuple.Create("\"", 1736)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1721), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/FerryRoute/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2141)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/FerryRoute/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2075), false)
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create("&dt=", 2090), true)
, Tuple.Create(Tuple.Create("", 2094), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2094), false)
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
WriteLiteral(" id=\"FerryRoutes\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/FerryRoute_FerryRoutes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2933), Tuple.Create("\"", 2948)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create("#", 2940), true)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2941), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3164), Tuple.Create("\"", 3176)
, Tuple.Create(Tuple.Create("", 3169), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3169), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Add_1.cshtml")]
    public partial class Views_FerryRoute_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Ferry Routes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Ferry Routes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/FerryRoute/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"FerryRoutes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/FerryRoute_FerryRoutes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_List_1.cshtml")]
    public partial class Views_FerryRoute_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.FerryRoute>>
    {
        public Views_FerryRoute_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Ferry Routes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Ferry Routes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Ferry Routes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/FerryRoute/ListFromQuery/?Clause=", 526), true)
                                                                      , Tuple.Create(Tuple.Create("", 560), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 560), false)
, Tuple.Create(Tuple.Create("", 575), Tuple.Create("&Ord=", 575), true)
                                                                                          , Tuple.Create(Tuple.Create("", 580), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 580), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Route Code</th><th>Route</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 888), Tuple.Create("\"", 932)
, Tuple.Create(Tuple.Create("", 895), Tuple.Create("/FerryRoute/Load/?RecId=", 895), true)
                   , Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 919), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1181), Tuple.Create("\"", 1269)
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRCode/?RecId=", 1192), true)
                                                                      , Tuple.Create(Tuple.Create("", 1245), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1245), false)
, Tuple.Create(Tuple.Create("", 1258), Tuple.Create("\',$(this));", 1258), true)
);
WriteLiteral(" data-bound-name=\'FRCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1326), Tuple.Create("\'", 1365)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1334), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRCode.HTMLValue)
, 1334), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1550), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRName/?RecId=", 1561), true)
                                                                      , Tuple.Create(Tuple.Create("", 1614), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1614), false)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create("\',$(this));", 1627), true)
);
WriteLiteral(" data-bound-name=\'FRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1734)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRName.HTMLValue)
, 1703), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Edit_2.cshtml")]
    public partial class Views_FerryRoute_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Edit_2_cshtml()
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
WriteLiteral(" href=\"/FerryRoute/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Ferry Routes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/FerryRoute/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/FerryR" +
"oute/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("FerryRoute", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1382), Tuple.Create("\'", 1404)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1390), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1450), Tuple.Create("\'", 1474)
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1458), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"FerryRoute\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1602)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.FRIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1648), Tuple.Create("\"", 1671)
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1656), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1713), Tuple.Create("\"", 1736)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1721), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/FerryRoute/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2141)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/FerryRoute/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2075), false)
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create("&dt=", 2090), true)
, Tuple.Create(Tuple.Create("", 2094), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2094), false)
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
WriteLiteral(" id=\"FerryRoutes\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/FerryRoute_FerryRoutes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2933), Tuple.Create("\"", 2948)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create("#", 2940), true)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2941), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3164), Tuple.Create("\"", 3176)
, Tuple.Create(Tuple.Create("", 3169), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3169), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Add_2.cshtml")]
    public partial class Views_FerryRoute_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Ferry Routes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Ferry Routes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/FerryRoute/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"FerryRoutes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/FerryRoute_FerryRoutes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_List_2.cshtml")]
    public partial class Views_FerryRoute_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.FerryRoute>>
    {
        public Views_FerryRoute_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Ferry Routes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Ferry Routes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Ferry Routes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/FerryRoute/ListFromQuery/?Clause=", 526), true)
                                                                      , Tuple.Create(Tuple.Create("", 560), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 560), false)
, Tuple.Create(Tuple.Create("", 575), Tuple.Create("&Ord=", 575), true)
                                                                                          , Tuple.Create(Tuple.Create("", 580), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 580), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Route Code</th><th>Route</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 888), Tuple.Create("\"", 932)
, Tuple.Create(Tuple.Create("", 895), Tuple.Create("/FerryRoute/Load/?RecId=", 895), true)
                   , Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 919), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1181), Tuple.Create("\"", 1269)
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRCode/?RecId=", 1192), true)
                                                                      , Tuple.Create(Tuple.Create("", 1245), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1245), false)
, Tuple.Create(Tuple.Create("", 1258), Tuple.Create("\',$(this));", 1258), true)
);
WriteLiteral(" data-bound-name=\'FRCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1326), Tuple.Create("\'", 1365)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1334), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRCode.HTMLValue)
, 1334), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1550), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRName/?RecId=", 1561), true)
                                                                      , Tuple.Create(Tuple.Create("", 1614), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1614), false)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create("\',$(this));", 1627), true)
);
WriteLiteral(" data-bound-name=\'FRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1734)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRName.HTMLValue)
, 1703), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Edit_3.cshtml")]
    public partial class Views_FerryRoute_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Edit_3_cshtml()
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
WriteLiteral(" href=\"/FerryRoute/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Ferry Routes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/FerryRoute/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/FerryR" +
"oute/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("FerryRoute", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1382), Tuple.Create("\'", 1404)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1390), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1450), Tuple.Create("\'", 1474)
, Tuple.Create(Tuple.Create("", 1458), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1458), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"FerryRoute\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1602)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.FRIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1648), Tuple.Create("\"", 1671)
, Tuple.Create(Tuple.Create("", 1656), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1656), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1713), Tuple.Create("\"", 1736)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1721), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/FerryRoute/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2141)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/FerryRoute/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2075), false)
, Tuple.Create(Tuple.Create("", 2090), Tuple.Create("&dt=", 2090), true)
, Tuple.Create(Tuple.Create("", 2094), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2094), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2733), Tuple.Create("\"", 2748)
, Tuple.Create(Tuple.Create("", 2740), Tuple.Create("#", 2740), true)
, Tuple.Create(Tuple.Create("", 2741), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2741), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2964), Tuple.Create("\"", 2976)
, Tuple.Create(Tuple.Create("", 2969), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2969), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_Add_3.cshtml")]
    public partial class Views_FerryRoute_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.FerryRoute>
    {
        public Views_FerryRoute_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Ferry Routes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Ferry Routes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/FerryRoute/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<FerryRoute>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/FerryRoute_List_3.cshtml")]
    public partial class Views_FerryRoute_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.FerryRoute>>
    {
        public Views_FerryRoute_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Ferry Routes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Ferry Routes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Ferry Routes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/FerryRoute/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/FerryRoute/ListFromQuery/?Clause=", 526), true)
                                                                      , Tuple.Create(Tuple.Create("", 560), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 560), false)
, Tuple.Create(Tuple.Create("", 575), Tuple.Create("&Ord=", 575), true)
                                                                                          , Tuple.Create(Tuple.Create("", 580), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 580), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Route Code</th><th>Route</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 888), Tuple.Create("\"", 932)
, Tuple.Create(Tuple.Create("", 895), Tuple.Create("/FerryRoute/Load/?RecId=", 895), true)
                   , Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 919), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1181), Tuple.Create("\"", 1269)
, Tuple.Create(Tuple.Create("", 1192), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRCode/?RecId=", 1192), true)
                                                                      , Tuple.Create(Tuple.Create("", 1245), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1245), false)
, Tuple.Create(Tuple.Create("", 1258), Tuple.Create("\',$(this));", 1258), true)
);
WriteLiteral(" data-bound-name=\'FRCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1326), Tuple.Create("\'", 1365)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1334), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRCode.HTMLValue)
, 1334), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.FRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1550), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("javascript:IQAutoSave(\'/FerryRoute/SaveFRName/?RecId=", 1561), true)
                                                                      , Tuple.Create(Tuple.Create("", 1614), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1614), false)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create("\',$(this));", 1627), true)
);
WriteLiteral(" data-bound-name=\'FRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1734)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.FRName.HTMLValue)
, 1703), false)
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
