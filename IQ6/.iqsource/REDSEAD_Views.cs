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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_REDSeADNumbers.cshtml")]
    public partial class Views_REDSEAD_REDSeADNumbers_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_REDSeADNumbers_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel104011", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.RDEADRDId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 340)
        , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDEADRDId.BackHEXColor) ? "" : "color:" + Model.RDEADRDId.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 249), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 249), true)
);
WriteLiteral(">REDS ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSeADNumbers_RDEADRDId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 432), Tuple.Create("\'", 498)
, Tuple.Create(Tuple.Create("", 440), Tuple.Create("form-control", 440), true)
, Tuple.Create(Tuple.Create("   ", 452), Tuple.Create<System.Object, System.Int32>(!Model.RDEADRDId.Visible ? " hide " : ""
, 455), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSEAD/SaveRDEADRDId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSEAD/CallbackRDEADRDId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDEADRDId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                  Write(Model.RDEADRDId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 877), Tuple.Create("\'", 945)
, Tuple.Create(Tuple.Create("", 885), Tuple.Create("IQLabel104012", 885), true)
                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 898), Tuple.Create<System.Object, System.Int32>(!Model.RDEADId.LabelVisible ? " hide " : ""
, 899), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 946), Tuple.Create("\'", 1149)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 955), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDEADId.BackHEXColor) ? "" : "color:" + Model.RDEADId.BackHEXColor + ";"
, 955), false)
, Tuple.Create(Tuple.Create("", 1057), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1057), true)
);
WriteLiteral(">eAD Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSeADNumbers_RDEADId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDEADId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                              Write(!Model.RDEADId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSEAD/SaveRDEADId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSEAD/CallbackRDEADId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDEADId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.RDEADId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Edit_1.cshtml")]
    public partial class Views_REDSEAD_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Edit_1_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/REDSEAD/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSEA" +
"D/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSEAD", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSEAD\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.RDEADRDIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSEAD/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/REDSEAD/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteLiteral(" id=\"REDSeADNumbers\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSEAD_REDSeADNumbers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2838), Tuple.Create("\"", 2853)
, Tuple.Create(Tuple.Create("", 2845), Tuple.Create("#", 2845), true)
, Tuple.Create(Tuple.Create("", 2846), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2846), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3069), Tuple.Create("\"", 3081)
, Tuple.Create(Tuple.Create("", 3074), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3074), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Add_1.cshtml")]
    public partial class Views_REDSEAD_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSEAD/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSeADNumbers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSEAD_REDSeADNumbers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_List_1.cshtml")]
    public partial class Views_REDSEAD_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSEAD>>
    {
        public Views_REDSEAD_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/REDSEAD/ListFromQuery/?Clause=", 529), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>REDS ID</th><th>eAD Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/REDSEAD/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.RDEADRDId.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDEADId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1241), Tuple.Create("\"", 1327)
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create("javascript:IQAutoSave(\'/REDSEAD/SaveRDEADId/?RecId=", 1252), true)
                                                                    , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1303), false)
, Tuple.Create(Tuple.Create("", 1316), Tuple.Create("\',$(this));", 1316), true)
);
WriteLiteral(" data-bound-name=\'RDEADId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1425)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDEADId.HTMLValue)
, 1393), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Edit_2.cshtml")]
    public partial class Views_REDSEAD_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Edit_2_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/REDSEAD/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSEA" +
"D/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSEAD", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSEAD\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.RDEADRDIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSEAD/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/REDSEAD/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteLiteral(" id=\"REDSeADNumbers\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSEAD_REDSeADNumbers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2838), Tuple.Create("\"", 2853)
, Tuple.Create(Tuple.Create("", 2845), Tuple.Create("#", 2845), true)
, Tuple.Create(Tuple.Create("", 2846), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2846), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3069), Tuple.Create("\"", 3081)
, Tuple.Create(Tuple.Create("", 3074), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3074), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Add_2.cshtml")]
    public partial class Views_REDSEAD_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSEAD/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSeADNumbers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSEAD_REDSeADNumbers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_List_2.cshtml")]
    public partial class Views_REDSEAD_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSEAD>>
    {
        public Views_REDSEAD_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/REDSEAD/ListFromQuery/?Clause=", 529), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>REDS ID</th><th>eAD Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/REDSEAD/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.RDEADRDId.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDEADId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1241), Tuple.Create("\"", 1327)
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create("javascript:IQAutoSave(\'/REDSEAD/SaveRDEADId/?RecId=", 1252), true)
                                                                    , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1303), false)
, Tuple.Create(Tuple.Create("", 1316), Tuple.Create("\',$(this));", 1316), true)
);
WriteLiteral(" data-bound-name=\'RDEADId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1425)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDEADId.HTMLValue)
, 1393), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Edit_3.cshtml")]
    public partial class Views_REDSEAD_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Edit_3_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/REDSEAD/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSEA" +
"D/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSEAD", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSEAD\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.RDEADRDIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSEAD/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/REDSEAD/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2636), Tuple.Create("\"", 2651)
, Tuple.Create(Tuple.Create("", 2643), Tuple.Create("#", 2643), true)
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2644), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2867), Tuple.Create("\"", 2879)
, Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2872), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_Add_3.cshtml")]
    public partial class Views_REDSEAD_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSEAD>
    {
        public Views_REDSEAD_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSEAD/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSEAD>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSEAD_List_3.cshtml")]
    public partial class Views_REDSEAD_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSEAD>>
    {
        public Views_REDSEAD_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSEAD/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 592)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/REDSEAD/ListFromQuery/?Clause=", 529), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>REDS ID</th><th>eAD Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 890), Tuple.Create("\"", 931)
, Tuple.Create(Tuple.Create("", 897), Tuple.Create("/REDSEAD/Load/?RecId=", 897), true)
                , Tuple.Create(Tuple.Create("", 918), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 918), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.RDEADRDId.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDEADId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1241), Tuple.Create("\"", 1327)
, Tuple.Create(Tuple.Create("", 1252), Tuple.Create("javascript:IQAutoSave(\'/REDSEAD/SaveRDEADId/?RecId=", 1252), true)
                                                                    , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1303), false)
, Tuple.Create(Tuple.Create("", 1316), Tuple.Create("\',$(this));", 1316), true)
);
WriteLiteral(" data-bound-name=\'RDEADId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1385), Tuple.Create("\'", 1425)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1393), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDEADId.HTMLValue)
, 1393), false)
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
