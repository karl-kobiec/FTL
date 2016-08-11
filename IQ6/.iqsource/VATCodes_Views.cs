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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_VATCodes.cshtml")]
    public partial class Views_VATCodes_VATCodes_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_VATCodes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel101411", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.VATId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 329)
    , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.VATId.BackHEXColor) ? "" : "color:" + Model.VATId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 238), true)
);
WriteLiteral(">VAT Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'VATCodes_VATId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 410), Tuple.Create("\'", 472)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("form-control", 418), true)
, Tuple.Create(Tuple.Create("   ", 430), Tuple.Create<System.Object, System.Int32>(!Model.VATId.Visible ? " hide " : ""
, 433), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/VATCodes/CallbackVATId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateVATId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                    Write(Model.VATId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 837), Tuple.Create("\'", 905)
, Tuple.Create(Tuple.Create("", 845), Tuple.Create("IQLabel101412", 845), true)
                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 858), Tuple.Create<System.Object, System.Int32>(!Model.VATCode.LabelVisible ? " hide " : ""
, 859), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 906), Tuple.Create("\'", 1109)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 915), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.VATCode.BackHEXColor) ? "" : "color:" + Model.VATCode.BackHEXColor + ";"
, 915), false)
, Tuple.Create(Tuple.Create("", 1017), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1017), true)
);
WriteLiteral(">VAT Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'VATCodes_VATCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.VATCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                              Write(!Model.VATCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/VATCodes/CallbackVATCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateVATCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.VATCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1699), Tuple.Create("\'", 1767)
, Tuple.Create(Tuple.Create("", 1707), Tuple.Create("IQLabel101413", 1707), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 1720), Tuple.Create<System.Object, System.Int32>(!Model.VATName.LabelVisible ? " hide " : ""
, 1721), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1768), Tuple.Create("\'", 1971)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1777), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.VATName.BackHEXColor) ? "" : "color:" + Model.VATName.BackHEXColor + ";"
, 1777), false)
, Tuple.Create(Tuple.Create("", 1879), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1879), true)
);
WriteLiteral(">Description</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'VATCodes_VATName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.VATName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.VATName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/VATCodes/CallbackVATName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateVATName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.VATName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2555), Tuple.Create("\'", 2623)
, Tuple.Create(Tuple.Create("", 2563), Tuple.Create("IQLabel101414", 2563), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 2576), Tuple.Create<System.Object, System.Int32>(!Model.VATRate.LabelVisible ? " hide " : ""
, 2577), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2624), Tuple.Create("\'", 2827)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 2633), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.VATRate.BackHEXColor) ? "" : "color:" + Model.VATRate.BackHEXColor + ";"
, 2633), false)
, Tuple.Create(Tuple.Create("", 2735), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2735), true)
);
WriteLiteral(">VAT Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'VATCodes_VATRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.VATRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.VATRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/VATCodes/CallbackVATRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateVATRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.VATRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Edit_1.cshtml")]
    public partial class Views_VATCodes_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Edit_1_cshtml()
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
WriteLiteral(" href=\"/VATCodes/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add VAT Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/VATCodes/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/VATCod" +
"es/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("VATCodes", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"VATCodes\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.VATIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/VATCodes/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2121)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/VATCodes/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2055), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2055), false)
, Tuple.Create(Tuple.Create("", 2070), Tuple.Create("&dt=", 2070), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2074), false)
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
WriteLiteral(" id=\"VATCodes\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/VATCodes_VATCodes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2905), Tuple.Create("\"", 2920)
, Tuple.Create(Tuple.Create("", 2912), Tuple.Create("#", 2912), true)
, Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2913), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3136), Tuple.Create("\"", 3148)
, Tuple.Create(Tuple.Create("", 3141), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3141), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Add_1.cshtml")]
    public partial class Views_VATCodes_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add VAT Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add VAT Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/VATCodes/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"VATCodes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/VATCodes_VATCodes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_List_1.cshtml")]
    public partial class Views_VATCodes_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.VATCodes>>
    {
        public Views_VATCodes_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "VAT Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"VAT Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add VAT Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/VATCodes/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>VAT Code</th><th>Description</th><th>VAT Rate</th>\t\t</tr>\r\n\t</th" +
"ead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 892), Tuple.Create("\"", 934)
, Tuple.Create(Tuple.Create("", 899), Tuple.Create("/VATCodes/Load/?RecId=", 899), true)
                 , Tuple.Create(Tuple.Create("", 921), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 921), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1184), Tuple.Create("\"", 1271)
, Tuple.Create(Tuple.Create("", 1195), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATCode/?RecId=", 1195), true)
                                                                     , Tuple.Create(Tuple.Create("", 1247), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1247), false)
, Tuple.Create(Tuple.Create("", 1260), Tuple.Create("\',$(this));", 1260), true)
);
WriteLiteral(" data-bound-name=\'VATCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1329), Tuple.Create("\'", 1369)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1337), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATCode.HTMLValue)
, 1337), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1555), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1566), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATName/?RecId=", 1566), true)
                                                                     , Tuple.Create(Tuple.Create("", 1618), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1618), false)
, Tuple.Create(Tuple.Create("", 1631), Tuple.Create("\',$(this));", 1631), true)
);
WriteLiteral(" data-bound-name=\'VATName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1700), Tuple.Create("\'", 1740)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATName.HTMLValue)
, 1708), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1926), Tuple.Create("\"", 2013)
, Tuple.Create(Tuple.Create("", 1937), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATRate/?RecId=", 1937), true)
                                                                     , Tuple.Create(Tuple.Create("", 1989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1989), false)
, Tuple.Create(Tuple.Create("", 2002), Tuple.Create("\',$(this));", 2002), true)
);
WriteLiteral(" data-bound-name=\'VATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2071), Tuple.Create("\'", 2111)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATRate.HTMLValue)
, 2079), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Edit_2.cshtml")]
    public partial class Views_VATCodes_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Edit_2_cshtml()
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
WriteLiteral(" href=\"/VATCodes/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add VAT Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/VATCodes/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/VATCod" +
"es/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("VATCodes", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"VATCodes\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.VATIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/VATCodes/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2121)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/VATCodes/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2055), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2055), false)
, Tuple.Create(Tuple.Create("", 2070), Tuple.Create("&dt=", 2070), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2074), false)
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
WriteLiteral(" id=\"VATCodes\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/VATCodes_VATCodes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2905), Tuple.Create("\"", 2920)
, Tuple.Create(Tuple.Create("", 2912), Tuple.Create("#", 2912), true)
, Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2913), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3136), Tuple.Create("\"", 3148)
, Tuple.Create(Tuple.Create("", 3141), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3141), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Add_2.cshtml")]
    public partial class Views_VATCodes_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add VAT Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add VAT Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/VATCodes/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"VATCodes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/VATCodes_VATCodes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_List_2.cshtml")]
    public partial class Views_VATCodes_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.VATCodes>>
    {
        public Views_VATCodes_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "VAT Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"VAT Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add VAT Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/VATCodes/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>VAT Code</th><th>Description</th><th>VAT Rate</th>\t\t</tr>\r\n\t</th" +
"ead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 892), Tuple.Create("\"", 934)
, Tuple.Create(Tuple.Create("", 899), Tuple.Create("/VATCodes/Load/?RecId=", 899), true)
                 , Tuple.Create(Tuple.Create("", 921), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 921), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1184), Tuple.Create("\"", 1271)
, Tuple.Create(Tuple.Create("", 1195), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATCode/?RecId=", 1195), true)
                                                                     , Tuple.Create(Tuple.Create("", 1247), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1247), false)
, Tuple.Create(Tuple.Create("", 1260), Tuple.Create("\',$(this));", 1260), true)
);
WriteLiteral(" data-bound-name=\'VATCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1329), Tuple.Create("\'", 1369)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1337), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATCode.HTMLValue)
, 1337), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1555), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1566), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATName/?RecId=", 1566), true)
                                                                     , Tuple.Create(Tuple.Create("", 1618), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1618), false)
, Tuple.Create(Tuple.Create("", 1631), Tuple.Create("\',$(this));", 1631), true)
);
WriteLiteral(" data-bound-name=\'VATName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1700), Tuple.Create("\'", 1740)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATName.HTMLValue)
, 1708), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1926), Tuple.Create("\"", 2013)
, Tuple.Create(Tuple.Create("", 1937), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATRate/?RecId=", 1937), true)
                                                                     , Tuple.Create(Tuple.Create("", 1989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1989), false)
, Tuple.Create(Tuple.Create("", 2002), Tuple.Create("\',$(this));", 2002), true)
);
WriteLiteral(" data-bound-name=\'VATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2071), Tuple.Create("\'", 2111)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATRate.HTMLValue)
, 2079), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Edit_3.cshtml")]
    public partial class Views_VATCodes_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Edit_3_cshtml()
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
WriteLiteral(" href=\"/VATCodes/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add VAT Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/VATCodes/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/VATCod" +
"es/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("VATCodes", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"VATCodes\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.VATIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/VATCodes/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2121)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/VATCodes/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2055), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2055), false)
, Tuple.Create(Tuple.Create("", 2070), Tuple.Create("&dt=", 2070), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2074), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2713), Tuple.Create("\"", 2728)
, Tuple.Create(Tuple.Create("", 2720), Tuple.Create("#", 2720), true)
, Tuple.Create(Tuple.Create("", 2721), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2721), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2944), Tuple.Create("\"", 2956)
, Tuple.Create(Tuple.Create("", 2949), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2949), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_Add_3.cshtml")]
    public partial class Views_VATCodes_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.VATCodes>
    {
        public Views_VATCodes_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add VAT Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add VAT Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/VATCodes/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<VATCodes>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/VATCodes_List_3.cshtml")]
    public partial class Views_VATCodes_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.VATCodes>>
    {
        public Views_VATCodes_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "VAT Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"VAT Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add VAT Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/VATCodes/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/VATCodes/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>VAT Code</th><th>Description</th><th>VAT Rate</th>\t\t</tr>\r\n\t</th" +
"ead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 892), Tuple.Create("\"", 934)
, Tuple.Create(Tuple.Create("", 899), Tuple.Create("/VATCodes/Load/?RecId=", 899), true)
                 , Tuple.Create(Tuple.Create("", 921), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 921), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1184), Tuple.Create("\"", 1271)
, Tuple.Create(Tuple.Create("", 1195), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATCode/?RecId=", 1195), true)
                                                                     , Tuple.Create(Tuple.Create("", 1247), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1247), false)
, Tuple.Create(Tuple.Create("", 1260), Tuple.Create("\',$(this));", 1260), true)
);
WriteLiteral(" data-bound-name=\'VATCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1329), Tuple.Create("\'", 1369)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1337), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATCode.HTMLValue)
, 1337), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:47%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1555), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1566), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATName/?RecId=", 1566), true)
                                                                     , Tuple.Create(Tuple.Create("", 1618), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1618), false)
, Tuple.Create(Tuple.Create("", 1631), Tuple.Create("\',$(this));", 1631), true)
);
WriteLiteral(" data-bound-name=\'VATName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1700), Tuple.Create("\'", 1740)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATName.HTMLValue)
, 1708), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.VATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1926), Tuple.Create("\"", 2013)
, Tuple.Create(Tuple.Create("", 1937), Tuple.Create("javascript:IQAutoSave(\'/VATCodes/SaveVATRate/?RecId=", 1937), true)
                                                                     , Tuple.Create(Tuple.Create("", 1989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1989), false)
, Tuple.Create(Tuple.Create("", 2002), Tuple.Create("\',$(this));", 2002), true)
);
WriteLiteral(" data-bound-name=\'VATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2071), Tuple.Create("\'", 2111)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.VATRate.HTMLValue)
, 2079), false)
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
