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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_DeliveryZones.cshtml")]
    public partial class Views_DelZone_DeliveryZones_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_DeliveryZones_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel108201", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.DelZId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 331)
     , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DelZId.BackHEXColor) ? "" : "color:" + Model.DelZId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 240), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 240), true)
);
WriteLiteral(">Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DeliveryZones_DelZId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DelZId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.DelZId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DelZone/SaveDelZId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DelZone/CallbackDelZId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDelZId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.DelZId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 901), Tuple.Create("\'", 970)
, Tuple.Create(Tuple.Create("", 909), Tuple.Create("IQLabel108202", 909), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 922), Tuple.Create<System.Object, System.Int32>(!Model.DelZName.LabelVisible ? " hide " : ""
, 923), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 971), Tuple.Create("\'", 1176)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 980), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DelZName.BackHEXColor) ? "" : "color:" + Model.DelZName.BackHEXColor + ";"
, 980), false)
, Tuple.Create(Tuple.Create("", 1084), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:27px;", 1084), true)
);
WriteLiteral(">Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DeliveryZones_DelZName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DelZName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.DelZName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DelZone/SaveDelZName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DelZone/CallbackDelZName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDelZName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.DelZName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:27px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Edit_1.cshtml")]
    public partial class Views_DelZone_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Edit_1_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DelZon" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DelZone", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DelZone\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1364)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.DelZIdValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1410), Tuple.Create("\"", 1433)
, Tuple.Create(Tuple.Create("", 1418), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1418), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1475), Tuple.Create("\"", 1498)
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1483), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DelZone/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1796), Tuple.Create("\"", 1897)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("/DelZone/ViewHistory/?RecId=", 1803), true)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1831), false)
, Tuple.Create(Tuple.Create("", 1846), Tuple.Create("&dt=", 1846), true)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1850), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2489), Tuple.Create("\"", 2504)
, Tuple.Create(Tuple.Create("", 2496), Tuple.Create("#", 2496), true)
, Tuple.Create(Tuple.Create("", 2497), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2497), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2720), Tuple.Create("\"", 2732)
, Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2725), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Add_1.cshtml")]
    public partial class Views_DelZone_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Delivery Zones";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Delivery Zones\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DelZone/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_List_1.cshtml")]
    public partial class Views_DelZone_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DelZone>>
    {
        public Views_DelZone_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Delivery Zones List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Delivery Zones List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Delivery Zones</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DelZone/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Id</th><th>Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 873), Tuple.Create("\"", 914)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("/DelZone/Load/?RecId=", 880), true)
                , Tuple.Create(Tuple.Create("", 901), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 901), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1163), Tuple.Create("\"", 1248)
, Tuple.Create(Tuple.Create("", 1174), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZId/?RecId=", 1174), true)
                                                                   , Tuple.Create(Tuple.Create("", 1224), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1224), false)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("\',$(this));", 1237), true)
);
WriteLiteral(" data-bound-name=\'DelZId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1305), Tuple.Create("\'", 1344)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1313), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZId.HTMLValue)
, 1313), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1531), Tuple.Create("\"", 1618)
, Tuple.Create(Tuple.Create("", 1542), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZName/?RecId=", 1542), true)
                                                                     , Tuple.Create(Tuple.Create("", 1594), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1594), false)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create("\',$(this));", 1607), true)
);
WriteLiteral(" data-bound-name=\'DelZName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1677), Tuple.Create("\'", 1718)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZName.HTMLValue)
, 1685), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Edit_2.cshtml")]
    public partial class Views_DelZone_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Edit_2_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DelZon" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DelZone", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DelZone\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1364)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.DelZIdValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1410), Tuple.Create("\"", 1433)
, Tuple.Create(Tuple.Create("", 1418), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1418), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1475), Tuple.Create("\"", 1498)
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1483), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DelZone/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1796), Tuple.Create("\"", 1897)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("/DelZone/ViewHistory/?RecId=", 1803), true)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1831), false)
, Tuple.Create(Tuple.Create("", 1846), Tuple.Create("&dt=", 1846), true)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1850), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2489), Tuple.Create("\"", 2504)
, Tuple.Create(Tuple.Create("", 2496), Tuple.Create("#", 2496), true)
, Tuple.Create(Tuple.Create("", 2497), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2497), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2720), Tuple.Create("\"", 2732)
, Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2725), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Add_2.cshtml")]
    public partial class Views_DelZone_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Delivery Zones";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Delivery Zones\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DelZone/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_List_2.cshtml")]
    public partial class Views_DelZone_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DelZone>>
    {
        public Views_DelZone_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Delivery Zones List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Delivery Zones List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Delivery Zones</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DelZone/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Id</th><th>Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 873), Tuple.Create("\"", 914)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("/DelZone/Load/?RecId=", 880), true)
                , Tuple.Create(Tuple.Create("", 901), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 901), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1163), Tuple.Create("\"", 1248)
, Tuple.Create(Tuple.Create("", 1174), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZId/?RecId=", 1174), true)
                                                                   , Tuple.Create(Tuple.Create("", 1224), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1224), false)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("\',$(this));", 1237), true)
);
WriteLiteral(" data-bound-name=\'DelZId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1305), Tuple.Create("\'", 1344)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1313), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZId.HTMLValue)
, 1313), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1531), Tuple.Create("\"", 1618)
, Tuple.Create(Tuple.Create("", 1542), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZName/?RecId=", 1542), true)
                                                                     , Tuple.Create(Tuple.Create("", 1594), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1594), false)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create("\',$(this));", 1607), true)
);
WriteLiteral(" data-bound-name=\'DelZName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1677), Tuple.Create("\'", 1718)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZName.HTMLValue)
, 1685), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Edit_3.cshtml")]
    public partial class Views_DelZone_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Edit_3_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DelZon" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DelZone", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DelZone\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1364)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.DelZIdValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1410), Tuple.Create("\"", 1433)
, Tuple.Create(Tuple.Create("", 1418), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1418), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1475), Tuple.Create("\"", 1498)
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1483), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DelZone/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1796), Tuple.Create("\"", 1897)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("/DelZone/ViewHistory/?RecId=", 1803), true)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1831), false)
, Tuple.Create(Tuple.Create("", 1846), Tuple.Create("&dt=", 1846), true)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1850), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2489), Tuple.Create("\"", 2504)
, Tuple.Create(Tuple.Create("", 2496), Tuple.Create("#", 2496), true)
, Tuple.Create(Tuple.Create("", 2497), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2497), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2720), Tuple.Create("\"", 2732)
, Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2725), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_Add_3.cshtml")]
    public partial class Views_DelZone_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DelZone>
    {
        public Views_DelZone_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Delivery Zones";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Delivery Zones\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DelZone/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DelZone>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DelZone_List_3.cshtml")]
    public partial class Views_DelZone_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DelZone>>
    {
        public Views_DelZone_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Delivery Zones List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Delivery Zones List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Delivery Zones</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DelZone/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/DelZone/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Id</th><th>Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 873), Tuple.Create("\"", 914)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("/DelZone/Load/?RecId=", 880), true)
                , Tuple.Create(Tuple.Create("", 901), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 901), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1163), Tuple.Create("\"", 1248)
, Tuple.Create(Tuple.Create("", 1174), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZId/?RecId=", 1174), true)
                                                                   , Tuple.Create(Tuple.Create("", 1224), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1224), false)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("\',$(this));", 1237), true)
);
WriteLiteral(" data-bound-name=\'DelZId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1305), Tuple.Create("\'", 1344)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1313), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZId.HTMLValue)
, 1313), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DelZName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1531), Tuple.Create("\"", 1618)
, Tuple.Create(Tuple.Create("", 1542), Tuple.Create("javascript:IQAutoSave(\'/DelZone/SaveDelZName/?RecId=", 1542), true)
                                                                     , Tuple.Create(Tuple.Create("", 1594), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1594), false)
, Tuple.Create(Tuple.Create("", 1607), Tuple.Create("\',$(this));", 1607), true)
);
WriteLiteral(" data-bound-name=\'DelZName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1677), Tuple.Create("\'", 1718)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DelZName.HTMLValue)
, 1685), false)
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
