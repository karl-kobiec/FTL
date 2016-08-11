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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_BottleSizes.cshtml")]
    public partial class Views_BottleSize_BottleSizes_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_BottleSizes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 66), Tuple.Create("\'", 132)
, Tuple.Create(Tuple.Create("", 74), Tuple.Create("IQLabel102911", 74), true)
, Tuple.Create(Tuple.Create(" ", 87), Tuple.Create<System.Object, System.Int32>(!Model.BSzId.LabelVisible ? " hide " : ""
, 88), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 133), Tuple.Create("\'", 331)
    , Tuple.Create(Tuple.Create("", 142), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.BSzId.BackHEXColor) ? "" : "color:" + Model.BSzId.BackHEXColor + ";"
, 142), false)
, Tuple.Create(Tuple.Create("", 240), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 240), true)
);
WriteLiteral(">Size ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'BottleSizes_BSzId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 416), Tuple.Create("\'", 487)
, Tuple.Create(Tuple.Create("", 424), Tuple.Create("form-control", 424), true)
, Tuple.Create(Tuple.Create(" ", 436), Tuple.Create("mandatory", 437), true)
, Tuple.Create(Tuple.Create("  ", 446), Tuple.Create<System.Object, System.Int32>(!Model.BSzId.Visible ? " hide " : ""
, 448), false)
);
WriteLiteral(" ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/BottleSize/CallbackBSzId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateBSzId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                 Write(Model.BSzId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 856), Tuple.Create("\'", 924)
, Tuple.Create(Tuple.Create("", 864), Tuple.Create("IQLabel102912", 864), true)
                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 877), Tuple.Create<System.Object, System.Int32>(!Model.BSzSize.LabelVisible ? " hide " : ""
, 878), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 925), Tuple.Create("\'", 1128)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 934), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.BSzSize.BackHEXColor) ? "" : "color:" + Model.BSzSize.BackHEXColor + ";"
, 934), false)
, Tuple.Create(Tuple.Create("", 1036), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1036), true)
);
WriteLiteral(">Bottle Size</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'BottleSizes_BSzSize\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.BSzSize.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.BSzSize.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzSize/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/BottleSize/CallbackBSzSize/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateBSzSize\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.BSzSize.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1719), Tuple.Create("\'", 1788)
, Tuple.Create(Tuple.Create("", 1727), Tuple.Create("IQLabel102913", 1727), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 1740), Tuple.Create<System.Object, System.Int32>(!Model.BSzOrder.LabelVisible ? " hide " : ""
, 1741), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1789), Tuple.Create("\'", 1994)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1798), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.BSzOrder.BackHEXColor) ? "" : "color:" + Model.BSzOrder.BackHEXColor + ";"
, 1798), false)
, Tuple.Create(Tuple.Create("", 1902), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1902), true)
);
WriteLiteral(">Sort Order</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'BottleSizes_BSzOrder\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.BSzOrder.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.BSzOrder.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/BottleSize/CallbackBSzOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateBSzOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.BSzOrder.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:50px;top:53px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Edit_1.cshtml")]
    public partial class Views_BottleSize_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Edit_1_cshtml()
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
WriteLiteral(" href=\"/BottleSize/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Bottle Sizes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/BottleSize/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Bottle" +
"Size/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("BottleSize", Model.RecordID.Value))
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
WriteLiteral(" value=\"BottleSize\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.BSzIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/BottleSize/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2038), Tuple.Create("\"", 2142)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create("/BottleSize/ViewHistory/?RecId=", 2045), true)
, Tuple.Create(Tuple.Create("", 2076), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2076), false)
, Tuple.Create(Tuple.Create("", 2091), Tuple.Create("&dt=", 2091), true)
, Tuple.Create(Tuple.Create("", 2095), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2095), false)
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
WriteLiteral(" id=\"BottleSizes\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/BottleSize_BottleSizes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Add_1.cshtml")]
    public partial class Views_BottleSize_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Bottle Sizes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Bottle Sizes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/BottleSize/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"BottleSizes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/BottleSize_BottleSizes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_List_1.cshtml")]
    public partial class Views_BottleSize_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.BottleSize>>
    {
        public Views_BottleSize_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Bottle Sizes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Bottle Sizes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Bottle Sizes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/BottleSize/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Size ID</th><th>Bottle Size</th><th>Sort Order</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/BottleSize/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.BSzId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:55%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1260), Tuple.Create("\"", 1349)
, Tuple.Create(Tuple.Create("", 1271), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzSize/?RecId=", 1271), true)
                                                                       , Tuple.Create(Tuple.Create("", 1325), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1325), false)
, Tuple.Create(Tuple.Create("", 1338), Tuple.Create("\',$(this));", 1338), true)
);
WriteLiteral(" data-bound-name=\'BSzSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1447)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzSize.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1724)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzOrder/?RecId=", 1645), true)
                                                                        , Tuple.Create(Tuple.Create("", 1700), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1700), false)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create("\',$(this));", 1713), true)
);
WriteLiteral(" data-bound-name=\'BSzOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1783), Tuple.Create("\'", 1824)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1791), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzOrder.HTMLValue)
, 1791), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Edit_2.cshtml")]
    public partial class Views_BottleSize_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Edit_2_cshtml()
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
WriteLiteral(" href=\"/BottleSize/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Bottle Sizes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/BottleSize/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Bottle" +
"Size/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("BottleSize", Model.RecordID.Value))
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
WriteLiteral(" value=\"BottleSize\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.BSzIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/BottleSize/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2038), Tuple.Create("\"", 2142)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create("/BottleSize/ViewHistory/?RecId=", 2045), true)
, Tuple.Create(Tuple.Create("", 2076), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2076), false)
, Tuple.Create(Tuple.Create("", 2091), Tuple.Create("&dt=", 2091), true)
, Tuple.Create(Tuple.Create("", 2095), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2095), false)
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
WriteLiteral(" id=\"BottleSizes\"");
WriteLiteral(" style=\'position:relative;height:104px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/BottleSize_BottleSizes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Add_2.cshtml")]
    public partial class Views_BottleSize_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Bottle Sizes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Bottle Sizes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/BottleSize/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"BottleSizes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/BottleSize_BottleSizes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_List_2.cshtml")]
    public partial class Views_BottleSize_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.BottleSize>>
    {
        public Views_BottleSize_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Bottle Sizes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Bottle Sizes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Bottle Sizes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/BottleSize/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Size ID</th><th>Bottle Size</th><th>Sort Order</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/BottleSize/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.BSzId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:55%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1260), Tuple.Create("\"", 1349)
, Tuple.Create(Tuple.Create("", 1271), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzSize/?RecId=", 1271), true)
                                                                       , Tuple.Create(Tuple.Create("", 1325), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1325), false)
, Tuple.Create(Tuple.Create("", 1338), Tuple.Create("\',$(this));", 1338), true)
);
WriteLiteral(" data-bound-name=\'BSzSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1447)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzSize.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1724)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzOrder/?RecId=", 1645), true)
                                                                        , Tuple.Create(Tuple.Create("", 1700), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1700), false)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create("\',$(this));", 1713), true)
);
WriteLiteral(" data-bound-name=\'BSzOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1783), Tuple.Create("\'", 1824)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1791), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzOrder.HTMLValue)
, 1791), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Edit_3.cshtml")]
    public partial class Views_BottleSize_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Edit_3_cshtml()
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
WriteLiteral(" href=\"/BottleSize/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Bottle Sizes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/BottleSize/Delete/?RecId=", 425), true)
           , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Bottle" +
"Size/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("BottleSize", Model.RecordID.Value))
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
WriteLiteral(" value=\"BottleSize\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1578), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(Model.BSzIdValue
, 1586), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/BottleSize/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2038), Tuple.Create("\"", 2142)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create("/BottleSize/ViewHistory/?RecId=", 2045), true)
, Tuple.Create(Tuple.Create("", 2076), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2076), false)
, Tuple.Create(Tuple.Create("", 2091), Tuple.Create("&dt=", 2091), true)
, Tuple.Create(Tuple.Create("", 2095), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2095), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2734), Tuple.Create("\"", 2749)
, Tuple.Create(Tuple.Create("", 2741), Tuple.Create("#", 2741), true)
, Tuple.Create(Tuple.Create("", 2742), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2742), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2965), Tuple.Create("\"", 2977)
, Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2970), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_Add_3.cshtml")]
    public partial class Views_BottleSize_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.BottleSize>
    {
        public Views_BottleSize_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Bottle Sizes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Bottle Sizes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/BottleSize/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<BottleSize>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/BottleSize_List_3.cshtml")]
    public partial class Views_BottleSize_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.BottleSize>>
    {
        public Views_BottleSize_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Bottle Sizes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Bottle Sizes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Bottle Sizes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/BottleSize/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/BottleSize/ListFromQuery/?Clause=", 526), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Size ID</th><th>Bottle Size</th><th>Sort Order</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/BottleSize/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.BSzId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:55%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1260), Tuple.Create("\"", 1349)
, Tuple.Create(Tuple.Create("", 1271), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzSize/?RecId=", 1271), true)
                                                                       , Tuple.Create(Tuple.Create("", 1325), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1325), false)
, Tuple.Create(Tuple.Create("", 1338), Tuple.Create("\',$(this));", 1338), true)
);
WriteLiteral(" data-bound-name=\'BSzSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1447)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzSize.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.BSzOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1724)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/BottleSize/SaveBSzOrder/?RecId=", 1645), true)
                                                                        , Tuple.Create(Tuple.Create("", 1700), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1700), false)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create("\',$(this));", 1713), true)
);
WriteLiteral(" data-bound-name=\'BSzOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1783), Tuple.Create("\'", 1824)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1791), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.BSzOrder.HTMLValue)
, 1791), false)
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
