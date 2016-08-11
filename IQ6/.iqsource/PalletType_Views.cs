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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_PalletTypes.cshtml")]
    public partial class Views_PalletType_PalletTypes_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_PalletTypes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 66), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 74), Tuple.Create("IQLabel103011", 74), true)
, Tuple.Create(Tuple.Create(" ", 87), Tuple.Create<System.Object, System.Int32>(!Model.PallId.LabelVisible ? " hide " : ""
, 88), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 334)
     , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.PallId.BackHEXColor) ? "" : "color:" + Model.PallId.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 243), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 243), true)
);
WriteLiteral(">Pallet Type ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'PalletTypes_PallId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 427), Tuple.Create("\'", 490)
, Tuple.Create(Tuple.Create("", 435), Tuple.Create("form-control", 435), true)
, Tuple.Create(Tuple.Create("   ", 447), Tuple.Create<System.Object, System.Int32>(!Model.PallId.Visible ? " hide " : ""
, 450), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/PalletType/SavePallId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/PalletType/CallbackPallId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulatePallId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.PallId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 863), Tuple.Create("\'", 932)
, Tuple.Create(Tuple.Create("", 871), Tuple.Create("IQLabel103012", 871), true)
                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 884), Tuple.Create<System.Object, System.Int32>(!Model.PallName.LabelVisible ? " hide " : ""
, 885), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 933), Tuple.Create("\'", 1138)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 942), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.PallName.BackHEXColor) ? "" : "color:" + Model.PallName.BackHEXColor + ";"
, 942), false)
, Tuple.Create(Tuple.Create("", 1046), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1046), true)
);
WriteLiteral(">Pallet Type</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'PalletTypes_PallName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.PallName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.PallName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/PalletType/SavePallName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/PalletType/CallbackPallName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulatePallName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PallName.ValueFormatted);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Edit_1.cshtml")]
    public partial class Views_PalletType_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Edit_1_cshtml()
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
WriteLiteral(" href=\"/PalletType/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Pallet Types</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/PalletType/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Pallet" +
"Type/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("PalletType", Model.RecordID.Value))
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
WriteLiteral(" value=\"PalletType\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1604)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.PallIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1650), Tuple.Create("\"", 1673)
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1658), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1715), Tuple.Create("\"", 1738)
, Tuple.Create(Tuple.Create("", 1723), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1723), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/PalletType/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2039), Tuple.Create("\"", 2143)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create("/PalletType/ViewHistory/?RecId=", 2046), true)
, Tuple.Create(Tuple.Create("", 2077), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2077), false)
, Tuple.Create(Tuple.Create("", 2092), Tuple.Create("&dt=", 2092), true)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2096), false)
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
WriteLiteral(" id=\"PalletTypes\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/PalletType_PalletTypes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2934), Tuple.Create("\"", 2949)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create("#", 2941), true)
, Tuple.Create(Tuple.Create("", 2942), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2942), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3165), Tuple.Create("\"", 3177)
, Tuple.Create(Tuple.Create("", 3170), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3170), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Add_1.cshtml")]
    public partial class Views_PalletType_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Pallet Types";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Pallet Types\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/PalletType/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"PalletTypes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/PalletType_PalletTypes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_List_1.cshtml")]
    public partial class Views_PalletType_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.PalletType>>
    {
        public Views_PalletType_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Pallet Types List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Pallet Types List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Pallet Types</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/PalletType/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Pallet Type ID</th><th>Pallet Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 898), Tuple.Create("\"", 942)
, Tuple.Create(Tuple.Create("", 905), Tuple.Create("/PalletType/Load/?RecId=", 905), true)
                   , Tuple.Create(Tuple.Create("", 929), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 929), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.PallId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.PallName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/PalletType/SavePallName/?RecId=", 1261), true)
                                                                        , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'PallName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1440)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.PallName.HTMLValue)
, 1407), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Edit_2.cshtml")]
    public partial class Views_PalletType_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Edit_2_cshtml()
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
WriteLiteral(" href=\"/PalletType/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Pallet Types</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/PalletType/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Pallet" +
"Type/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("PalletType", Model.RecordID.Value))
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
WriteLiteral(" value=\"PalletType\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1604)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.PallIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1650), Tuple.Create("\"", 1673)
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1658), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1715), Tuple.Create("\"", 1738)
, Tuple.Create(Tuple.Create("", 1723), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1723), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/PalletType/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2039), Tuple.Create("\"", 2143)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create("/PalletType/ViewHistory/?RecId=", 2046), true)
, Tuple.Create(Tuple.Create("", 2077), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2077), false)
, Tuple.Create(Tuple.Create("", 2092), Tuple.Create("&dt=", 2092), true)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2096), false)
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
WriteLiteral(" id=\"PalletTypes\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/PalletType_PalletTypes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2934), Tuple.Create("\"", 2949)
, Tuple.Create(Tuple.Create("", 2941), Tuple.Create("#", 2941), true)
, Tuple.Create(Tuple.Create("", 2942), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2942), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3165), Tuple.Create("\"", 3177)
, Tuple.Create(Tuple.Create("", 3170), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3170), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Add_2.cshtml")]
    public partial class Views_PalletType_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Pallet Types";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Pallet Types\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/PalletType/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"PalletTypes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/PalletType_PalletTypes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_List_2.cshtml")]
    public partial class Views_PalletType_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.PalletType>>
    {
        public Views_PalletType_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Pallet Types List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Pallet Types List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Pallet Types</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/PalletType/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Pallet Type ID</th><th>Pallet Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 898), Tuple.Create("\"", 942)
, Tuple.Create(Tuple.Create("", 905), Tuple.Create("/PalletType/Load/?RecId=", 905), true)
                   , Tuple.Create(Tuple.Create("", 929), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 929), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.PallId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.PallName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/PalletType/SavePallName/?RecId=", 1261), true)
                                                                        , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'PallName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1440)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.PallName.HTMLValue)
, 1407), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Edit_3.cshtml")]
    public partial class Views_PalletType_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Edit_3_cshtml()
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
WriteLiteral(" href=\"/PalletType/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Pallet Types</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/PalletType/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Pallet" +
"Type/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("PalletType", Model.RecordID.Value))
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
WriteLiteral(" value=\"PalletType\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1604)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.PallIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1650), Tuple.Create("\"", 1673)
, Tuple.Create(Tuple.Create("", 1658), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1658), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1715), Tuple.Create("\"", 1738)
, Tuple.Create(Tuple.Create("", 1723), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1723), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/PalletType/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2039), Tuple.Create("\"", 2143)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create("/PalletType/ViewHistory/?RecId=", 2046), true)
, Tuple.Create(Tuple.Create("", 2077), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2077), false)
, Tuple.Create(Tuple.Create("", 2092), Tuple.Create("&dt=", 2092), true)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2096), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2735), Tuple.Create("\"", 2750)
, Tuple.Create(Tuple.Create("", 2742), Tuple.Create("#", 2742), true)
, Tuple.Create(Tuple.Create("", 2743), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2743), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2966), Tuple.Create("\"", 2978)
, Tuple.Create(Tuple.Create("", 2971), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2971), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_Add_3.cshtml")]
    public partial class Views_PalletType_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.PalletType>
    {
        public Views_PalletType_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Pallet Types";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Pallet Types\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/PalletType/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<PalletType>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/PalletType_List_3.cshtml")]
    public partial class Views_PalletType_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.PalletType>>
    {
        public Views_PalletType_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Pallet Types List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Pallet Types List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Pallet Types</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/PalletType/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/PalletType/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Pallet Type ID</th><th>Pallet Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 898), Tuple.Create("\"", 942)
, Tuple.Create(Tuple.Create("", 905), Tuple.Create("/PalletType/Load/?RecId=", 905), true)
                   , Tuple.Create(Tuple.Create("", 929), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 929), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.PallId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.PallName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/PalletType/SavePallName/?RecId=", 1261), true)
                                                                        , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'PallName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1440)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.PallName.HTMLValue)
, 1407), false)
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
