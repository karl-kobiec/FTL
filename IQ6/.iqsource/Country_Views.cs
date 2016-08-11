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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Countries.cshtml")]
    public partial class Views_Country_Countries_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Countries_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel103511", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.CtryId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 331)
     , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CtryId.BackHEXColor) ? "" : "color:" + Model.CtryId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 240), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 240), true)
);
WriteLiteral(">Country ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Countries_CtryId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 418), Tuple.Create("\'", 481)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("form-control", 426), true)
, Tuple.Create(Tuple.Create("   ", 438), Tuple.Create<System.Object, System.Int32>(!Model.CtryId.Visible ? " hide " : ""
, 441), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Country/SaveCtryId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Country/CallbackCtryId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCtryId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                      Write(Model.CtryId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 848), Tuple.Create("\'", 917)
, Tuple.Create(Tuple.Create("", 856), Tuple.Create("IQLabel103512", 856), true)
                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 869), Tuple.Create<System.Object, System.Int32>(!Model.CtryCode.LabelVisible ? " hide " : ""
, 870), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 918), Tuple.Create("\'", 1123)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 927), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CtryCode.BackHEXColor) ? "" : "color:" + Model.CtryCode.BackHEXColor + ";"
, 927), false)
, Tuple.Create(Tuple.Create("", 1031), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1031), true)
);
WriteLiteral(">Country Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Countries_CtryCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CtryCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CtryCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Country/SaveCtryCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Country/CallbackCtryCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCtryCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.CtryCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1714), Tuple.Create("\'", 1783)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create("IQLabel103513", 1722), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 1735), Tuple.Create<System.Object, System.Int32>(!Model.CtryName.LabelVisible ? " hide " : ""
, 1736), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1784), Tuple.Create("\'", 1989)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1793), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CtryName.BackHEXColor) ? "" : "color:" + Model.CtryName.BackHEXColor + ";"
, 1793), false)
, Tuple.Create(Tuple.Create("", 1897), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1897), true)
);
WriteLiteral(">Country</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Countries_CtryName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CtryName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CtryName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Country/SaveCtryName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Country/CallbackCtryName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCtryName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.CtryName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Edit_1.cshtml")]
    public partial class Views_Country_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Country/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Countries</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/Country/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Countr" +
"y/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Country", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Country\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.CtryIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1626), Tuple.Create("\"", 1649)
, Tuple.Create(Tuple.Create("", 1634), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1634), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1691), Tuple.Create("\"", 1714)
, Tuple.Create(Tuple.Create("", 1699), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1699), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Country/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2012), Tuple.Create("\"", 2113)
, Tuple.Create(Tuple.Create("", 2019), Tuple.Create("/Country/ViewHistory/?RecId=", 2019), true)
, Tuple.Create(Tuple.Create("", 2047), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2047), false)
, Tuple.Create(Tuple.Create("", 2062), Tuple.Create("&dt=", 2062), true)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2066), false)
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
WriteLiteral(" id=\"Countries\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Country_Countries.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2898), Tuple.Create("\"", 2913)
, Tuple.Create(Tuple.Create("", 2905), Tuple.Create("#", 2905), true)
, Tuple.Create(Tuple.Create("", 2906), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2906), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3129), Tuple.Create("\"", 3141)
, Tuple.Create(Tuple.Create("", 3134), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3134), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Add_1.cshtml")]
    public partial class Views_Country_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Countries";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Countries\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Country/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Countries\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Country_Countries.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_List_1.cshtml")]
    public partial class Views_Country_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Country>>
    {
        public Views_Country_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Countries List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Countries List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Countries</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/Country/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Country ID</th><th>Country Code</th><th>Country</th>\t\t</tr>\r\n\t</" +
"thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/Country/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CtryId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1239), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1250), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryCode/?RecId=", 1250), true)
                                                                     , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'CtryCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1426)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryCode.HTMLValue)
, 1393), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1613), Tuple.Create("\"", 1700)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryName/?RecId=", 1624), true)
                                                                     , Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1676), false)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create("\',$(this));", 1689), true)
);
WriteLiteral(" data-bound-name=\'CtryName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1759), Tuple.Create("\'", 1800)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryName.HTMLValue)
, 1767), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Edit_2.cshtml")]
    public partial class Views_Country_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Country/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Countries</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/Country/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Countr" +
"y/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Country", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Country\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.CtryIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1626), Tuple.Create("\"", 1649)
, Tuple.Create(Tuple.Create("", 1634), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1634), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1691), Tuple.Create("\"", 1714)
, Tuple.Create(Tuple.Create("", 1699), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1699), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Country/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2012), Tuple.Create("\"", 2113)
, Tuple.Create(Tuple.Create("", 2019), Tuple.Create("/Country/ViewHistory/?RecId=", 2019), true)
, Tuple.Create(Tuple.Create("", 2047), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2047), false)
, Tuple.Create(Tuple.Create("", 2062), Tuple.Create("&dt=", 2062), true)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2066), false)
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
WriteLiteral(" id=\"Countries\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Country_Countries.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2898), Tuple.Create("\"", 2913)
, Tuple.Create(Tuple.Create("", 2905), Tuple.Create("#", 2905), true)
, Tuple.Create(Tuple.Create("", 2906), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2906), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3129), Tuple.Create("\"", 3141)
, Tuple.Create(Tuple.Create("", 3134), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3134), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Add_2.cshtml")]
    public partial class Views_Country_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Countries";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Countries\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Country/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Countries\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Country_Countries.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_List_2.cshtml")]
    public partial class Views_Country_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Country>>
    {
        public Views_Country_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Countries List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Countries List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Countries</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/Country/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Country ID</th><th>Country Code</th><th>Country</th>\t\t</tr>\r\n\t</" +
"thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/Country/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CtryId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1239), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1250), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryCode/?RecId=", 1250), true)
                                                                     , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'CtryCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1426)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryCode.HTMLValue)
, 1393), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1613), Tuple.Create("\"", 1700)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryName/?RecId=", 1624), true)
                                                                     , Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1676), false)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create("\',$(this));", 1689), true)
);
WriteLiteral(" data-bound-name=\'CtryName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1759), Tuple.Create("\'", 1800)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryName.HTMLValue)
, 1767), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Edit_3.cshtml")]
    public partial class Views_Country_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Country/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Countries</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/Country/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Countr" +
"y/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Country", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Country\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.CtryIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1626), Tuple.Create("\"", 1649)
, Tuple.Create(Tuple.Create("", 1634), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1634), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1691), Tuple.Create("\"", 1714)
, Tuple.Create(Tuple.Create("", 1699), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1699), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Country/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2012), Tuple.Create("\"", 2113)
, Tuple.Create(Tuple.Create("", 2019), Tuple.Create("/Country/ViewHistory/?RecId=", 2019), true)
, Tuple.Create(Tuple.Create("", 2047), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2047), false)
, Tuple.Create(Tuple.Create("", 2062), Tuple.Create("&dt=", 2062), true)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2066), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2705), Tuple.Create("\"", 2720)
, Tuple.Create(Tuple.Create("", 2712), Tuple.Create("#", 2712), true)
, Tuple.Create(Tuple.Create("", 2713), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2713), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2936), Tuple.Create("\"", 2948)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2941), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_Add_3.cshtml")]
    public partial class Views_Country_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Country>
    {
        public Views_Country_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Countries";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Countries\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Country/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Country>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Country_List_3.cshtml")]
    public partial class Views_Country_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Country>>
    {
        public Views_Country_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Countries List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Countries List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Countries</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Country/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/Country/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Country ID</th><th>Country Code</th><th>Country</th>\t\t</tr>\r\n\t</" +
"thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/Country/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CtryId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1239), Tuple.Create("\"", 1326)
, Tuple.Create(Tuple.Create("", 1250), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryCode/?RecId=", 1250), true)
                                                                     , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1302), false)
, Tuple.Create(Tuple.Create("", 1315), Tuple.Create("\',$(this));", 1315), true)
);
WriteLiteral(" data-bound-name=\'CtryCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1426)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryCode.HTMLValue)
, 1393), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CtryName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1613), Tuple.Create("\"", 1700)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create("javascript:IQAutoSave(\'/Country/SaveCtryName/?RecId=", 1624), true)
                                                                     , Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1676), false)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create("\',$(this));", 1689), true)
);
WriteLiteral(" data-bound-name=\'CtryName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1759), Tuple.Create("\'", 1800)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1767), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CtryName.HTMLValue)
, 1767), false)
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
