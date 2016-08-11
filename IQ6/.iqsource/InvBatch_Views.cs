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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_InvoiceBatches.cshtml")]
    public partial class Views_InvBatch_InvoiceBatches_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_InvoiceBatches_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 131)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel102511", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.InvBId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 132), Tuple.Create("\'", 332)
     , Tuple.Create(Tuple.Create("", 141), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvBId.BackHEXColor) ? "" : "color:" + Model.InvBId.BackHEXColor + ";"
, 141), false)
, Tuple.Create(Tuple.Create("", 241), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 241), true)
);
WriteLiteral(">Batch Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceBatches_InvBId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 426), Tuple.Create("\'", 489)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create("form-control", 434), true)
, Tuple.Create(Tuple.Create("   ", 446), Tuple.Create<System.Object, System.Int32>(!Model.InvBId.Visible ? " hide " : ""
, 449), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvBatch/CallbackInvBId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvBId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                        Write(Model.InvBId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 858), Tuple.Create("\'", 927)
, Tuple.Create(Tuple.Create("", 866), Tuple.Create("IQLabel102512", 866), true)
                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 879), Tuple.Create<System.Object, System.Int32>(!Model.InvBType.LabelVisible ? " hide " : ""
, 880), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 928), Tuple.Create("\'", 1133)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 937), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvBType.BackHEXColor) ? "" : "color:" + Model.InvBType.BackHEXColor + ";"
, 937), false)
, Tuple.Create(Tuple.Create("", 1041), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1041), true)
);
WriteLiteral(">Invoice Type</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'InvoiceBatches_InvBType\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 1230), Tuple.Create("\'", 1296)
, Tuple.Create(Tuple.Create("", 1238), Tuple.Create("form-control", 1238), true)
, Tuple.Create(Tuple.Create("    ", 1250), Tuple.Create<System.Object, System.Int32>(!Model.InvBType.Visible ? " hide " : ""
, 1254), false)
);
WriteLiteral("  ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvBatch/CallbackInvBType/',$(this));\""));
WriteLiteral("   name=\'PopulateInvBType\'  style=\'position: absolute; left:130px;height:21px;wid" +
"th:160px;top:28px;\'>\r\n");
             foreach(var itm in Model.InvBType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1681), Tuple.Create("\'", 1702)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1689), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvBType.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1834), Tuple.Create("\'", 1908)
, Tuple.Create(Tuple.Create("", 1842), Tuple.Create("IQLabel102513", 1842), true)
, Tuple.Create(Tuple.Create(" ", 1855), Tuple.Create<System.Object, System.Int32>(!Model.InvBPrintedOn.LabelVisible ? " hide " : ""
, 1856), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1909), Tuple.Create("\'", 2124)
                            , Tuple.Create(Tuple.Create("", 1918), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvBPrintedOn.BackHEXColor) ? "" : "color:" + Model.InvBPrintedOn.BackHEXColor + ";"
, 1918), false)
, Tuple.Create(Tuple.Create("", 2032), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2032), true)
);
WriteLiteral(">Printed On</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceBatches_InvBPrintedOn\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 2223), Tuple.Create("\'", 2293)
, Tuple.Create(Tuple.Create("", 2231), Tuple.Create("form-control", 2231), true)
, Tuple.Create(Tuple.Create("   ", 2243), Tuple.Create<System.Object, System.Int32>(!Model.InvBPrintedOn.Visible ? " hide " : ""
, 2246), false)
);
WriteLiteral(" ");
                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBPrintedOn/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvBatch/CallbackInvBPrintedOn/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvBPrintedOn\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.InvBPrintedOn.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2691), Tuple.Create("\'", 2764)
, Tuple.Create(Tuple.Create("", 2699), Tuple.Create("IQLabel102514", 2699), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 2712), Tuple.Create<System.Object, System.Int32>(!Model.InvBExported.LabelVisible ? " hide " : ""
, 2713), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2765), Tuple.Create("\'", 2978)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2774), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvBExported.BackHEXColor) ? "" : "color:" + Model.InvBExported.BackHEXColor + ";"
, 2774), false)
, Tuple.Create(Tuple.Create("", 2886), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2886), true)
);
WriteLiteral(">Sent</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceBatches_InvBExported\'");
WriteAttribute("class", Tuple.Create(" class=\'", 3055), Tuple.Create("\'", 3111)
, Tuple.Create(Tuple.Create("  ", 3063), Tuple.Create<System.Object, System.Int32>(!Model.InvBExported.Visible ? " hide " : ""
, 3065), false)
);
WriteLiteral(" ");
                                                                                                                  Write(Model.RecordLocked || !Model.InvBExported.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBExported/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvBatch/CallbackInvBExported/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:78px;\' name=\'P" +
"opulateInvBExported\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.PopulateInvBExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateInvBExported\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                   Write(!Model.PopulateInvBExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 3754), Tuple.Create("\'", 3831)
, Tuple.Create(Tuple.Create("", 3762), Tuple.Create("IQLabel102515", 3762), true)
, Tuple.Create(Tuple.Create(" ", 3775), Tuple.Create<System.Object, System.Int32>(!Model.InvBExportedDate.LabelVisible ? " hide " : ""
, 3776), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3832), Tuple.Create("\'", 4054)
                      , Tuple.Create(Tuple.Create("", 3841), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvBExportedDate.BackHEXColor) ? "" : "color:" + Model.InvBExportedDate.BackHEXColor + ";"
, 3841), false)
, Tuple.Create(Tuple.Create("", 3961), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3961), true)
);
WriteLiteral(">Sent to Dover On</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceBatches_InvBExportedDate\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4162), Tuple.Create("\'", 4235)
, Tuple.Create(Tuple.Create("", 4170), Tuple.Create("form-control", 4170), true)
, Tuple.Create(Tuple.Create("   ", 4182), Tuple.Create<System.Object, System.Int32>(!Model.InvBExportedDate.Visible ? " hide " : ""
, 4185), false)
);
WriteLiteral(" ");
                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBExportedDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvBatch/CallbackInvBExportedDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvBExportedDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.InvBExportedDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:103px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Edit_1.cshtml")]
    public partial class Views_InvBatch_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvBat" +
"ch/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvBatch", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1149), Tuple.Create("\'", 1171)
, Tuple.Create(Tuple.Create("", 1157), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1157), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1217), Tuple.Create("\'", 1241)
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1225), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvBatch\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1343), Tuple.Create("\"", 1369)
, Tuple.Create(Tuple.Create("", 1351), Tuple.Create<System.Object, System.Int32>(Model.InvBIdValue
, 1351), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1415), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1423), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1423), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1480), Tuple.Create("\"", 1503)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1488), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvBatch/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1802), Tuple.Create("\"", 1904)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("/InvBatch/ViewHistory/?RecId=", 1809), true)
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1838), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("&dt=", 1853), true)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1857), false)
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
WriteLiteral(" id=\"InvoiceBatches\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvBatch_InvoiceBatches.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2700), Tuple.Create("\"", 2715)
, Tuple.Create(Tuple.Create("", 2707), Tuple.Create("#", 2707), true)
, Tuple.Create(Tuple.Create("", 2708), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2708), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2931), Tuple.Create("\"", 2943)
, Tuple.Create(Tuple.Create("", 2936), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2936), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Add_1.cshtml")]
    public partial class Views_InvBatch_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Batches";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Batches\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvBatch/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceBatches\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvBatch_InvoiceBatches.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_List_1.cshtml")]
    public partial class Views_InvBatch_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvBatch>>
    {
        public Views_InvBatch_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Batches List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Batches List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Batches</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 593)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/InvBatch/ListFromQuery/?Clause=", 529), true)
                                                                    , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 561), false)
, Tuple.Create(Tuple.Create("", 576), Tuple.Create("&Ord=", 576), true)
                                                                                        , Tuple.Create(Tuple.Create("", 581), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 581), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Batch Number</th><th>Invoice Type</th><th>Printed On</th><th>Sen" +
"t to Dover On</th><th>Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 955), Tuple.Create("\"", 997)
, Tuple.Create(Tuple.Create("", 962), Tuple.Create("/InvBatch/Load/?RecId=", 962), true)
                 , Tuple.Create(Tuple.Create("", 984), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 984), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvBId.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                Write(itm.InvBType.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                           Write(itm.InvBPrintedOn.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                                                                           Write(itm.InvBExportedDate.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                                                                                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvBExported.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 1481), Tuple.Create("\"", 1572)
, Tuple.Create(Tuple.Create("", 1491), Tuple.Create("javascript:IQAutoSave(\'/InvBatch/SaveInvBExported/?RecId=", 1491), true)
                                                       , Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1548), false)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("\',$(this));", 1561), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'InvBExported\'");
WriteLiteral(" ");
                                                                                                                                                                                                        Write(Html.Raw(itm.InvBExported.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'InvBExported\' value=\'false\'  /></td>\r\n" +
"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Edit_2.cshtml")]
    public partial class Views_InvBatch_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvBat" +
"ch/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvBatch", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1149), Tuple.Create("\'", 1171)
, Tuple.Create(Tuple.Create("", 1157), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1157), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1217), Tuple.Create("\'", 1241)
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1225), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvBatch\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1343), Tuple.Create("\"", 1369)
, Tuple.Create(Tuple.Create("", 1351), Tuple.Create<System.Object, System.Int32>(Model.InvBIdValue
, 1351), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1415), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1423), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1423), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1480), Tuple.Create("\"", 1503)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1488), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvBatch/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1802), Tuple.Create("\"", 1904)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("/InvBatch/ViewHistory/?RecId=", 1809), true)
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1838), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("&dt=", 1853), true)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1857), false)
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
WriteLiteral(" id=\"InvoiceBatches\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvBatch_InvoiceBatches.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2700), Tuple.Create("\"", 2715)
, Tuple.Create(Tuple.Create("", 2707), Tuple.Create("#", 2707), true)
, Tuple.Create(Tuple.Create("", 2708), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2708), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2931), Tuple.Create("\"", 2943)
, Tuple.Create(Tuple.Create("", 2936), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2936), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Add_2.cshtml")]
    public partial class Views_InvBatch_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Batches";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Batches\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvBatch/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceBatches\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvBatch_InvoiceBatches.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_List_2.cshtml")]
    public partial class Views_InvBatch_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvBatch>>
    {
        public Views_InvBatch_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Batches List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Batches List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Batches</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 593)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/InvBatch/ListFromQuery/?Clause=", 529), true)
                                                                    , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 561), false)
, Tuple.Create(Tuple.Create("", 576), Tuple.Create("&Ord=", 576), true)
                                                                                        , Tuple.Create(Tuple.Create("", 581), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 581), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Batch Number</th><th>Invoice Type</th><th>Printed On</th><th>Sen" +
"t to Dover On</th><th>Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 955), Tuple.Create("\"", 997)
, Tuple.Create(Tuple.Create("", 962), Tuple.Create("/InvBatch/Load/?RecId=", 962), true)
                 , Tuple.Create(Tuple.Create("", 984), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 984), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvBId.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                Write(itm.InvBType.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                           Write(itm.InvBPrintedOn.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                                                                           Write(itm.InvBExportedDate.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                                                                                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvBExported.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 1481), Tuple.Create("\"", 1572)
, Tuple.Create(Tuple.Create("", 1491), Tuple.Create("javascript:IQAutoSave(\'/InvBatch/SaveInvBExported/?RecId=", 1491), true)
                                                       , Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1548), false)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("\',$(this));", 1561), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'InvBExported\'");
WriteLiteral(" ");
                                                                                                                                                                                                        Write(Html.Raw(itm.InvBExported.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'InvBExported\' value=\'false\'  /></td>\r\n" +
"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Edit_3.cshtml")]
    public partial class Views_InvBatch_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvBat" +
"ch/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvBatch", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1149), Tuple.Create("\'", 1171)
, Tuple.Create(Tuple.Create("", 1157), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1157), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1217), Tuple.Create("\'", 1241)
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1225), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvBatch\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1343), Tuple.Create("\"", 1369)
, Tuple.Create(Tuple.Create("", 1351), Tuple.Create<System.Object, System.Int32>(Model.InvBIdValue
, 1351), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1415), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1423), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1423), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1480), Tuple.Create("\"", 1503)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1488), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvBatch/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1802), Tuple.Create("\"", 1904)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("/InvBatch/ViewHistory/?RecId=", 1809), true)
, Tuple.Create(Tuple.Create("", 1838), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1838), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("&dt=", 1853), true)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1857), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2496), Tuple.Create("\"", 2511)
, Tuple.Create(Tuple.Create("", 2503), Tuple.Create("#", 2503), true)
, Tuple.Create(Tuple.Create("", 2504), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2504), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2727), Tuple.Create("\"", 2739)
, Tuple.Create(Tuple.Create("", 2732), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2732), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_Add_3.cshtml")]
    public partial class Views_InvBatch_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvBatch>
    {
        public Views_InvBatch_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Batches";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Batches\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvBatch/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvBatch>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvBatch_List_3.cshtml")]
    public partial class Views_InvBatch_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvBatch>>
    {
        public Views_InvBatch_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Batches List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Batches List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Batches</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvBatch/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 593)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/InvBatch/ListFromQuery/?Clause=", 529), true)
                                                                    , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 561), false)
, Tuple.Create(Tuple.Create("", 576), Tuple.Create("&Ord=", 576), true)
                                                                                        , Tuple.Create(Tuple.Create("", 581), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 581), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Batch Number</th><th>Invoice Type</th><th>Printed On</th><th>Sen" +
"t to Dover On</th><th>Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 955), Tuple.Create("\"", 997)
, Tuple.Create(Tuple.Create("", 962), Tuple.Create("/InvBatch/Load/?RecId=", 962), true)
                 , Tuple.Create(Tuple.Create("", 984), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 984), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvBId.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                Write(itm.InvBType.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                           Write(itm.InvBPrintedOn.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                                                                           Write(itm.InvBExportedDate.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                                                                                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvBExported.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 1481), Tuple.Create("\"", 1572)
, Tuple.Create(Tuple.Create("", 1491), Tuple.Create("javascript:IQAutoSave(\'/InvBatch/SaveInvBExported/?RecId=", 1491), true)
                                                       , Tuple.Create(Tuple.Create("", 1548), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1548), false)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create("\',$(this));", 1561), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'InvBExported\'");
WriteLiteral(" ");
                                                                                                                                                                                                        Write(Html.Raw(itm.InvBExported.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'InvBExported\' value=\'false\'  /></td>\r\n" +
"");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
