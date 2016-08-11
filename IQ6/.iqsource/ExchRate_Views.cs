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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_ExchangeRates.cshtml")]
    public partial class Views_ExchRate_ExchangeRates_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_ExchangeRates_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel102011", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.ExRId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 329)
    , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ExRId.BackHEXColor) ? "" : "color:" + Model.ExRId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 238), true)
);
WriteLiteral(">Period Rate ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ExchangeRates_ExRId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 423), Tuple.Create("\'", 485)
, Tuple.Create(Tuple.Create("", 431), Tuple.Create("form-control", 431), true)
, Tuple.Create(Tuple.Create("   ", 443), Tuple.Create<System.Object, System.Int32>(!Model.ExRId.Visible ? " hide " : ""
, 446), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ExchRate/CallbackExRId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateExRId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                    Write(Model.ExRId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 850), Tuple.Create("\'", 918)
, Tuple.Create(Tuple.Create("", 858), Tuple.Create("IQLabel102012", 858), true)
                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 871), Tuple.Create<System.Object, System.Int32>(!Model.ExRName.LabelVisible ? " hide " : ""
, 872), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 919), Tuple.Create("\'", 1122)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 928), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ExRName.BackHEXColor) ? "" : "color:" + Model.ExRName.BackHEXColor + ";"
, 928), false)
, Tuple.Create(Tuple.Create("", 1030), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1030), true)
);
WriteLiteral(">Period Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ExchangeRates_ExRName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ExRName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.ExRName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ExchRate/CallbackExRName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateExRName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.ExRName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1711), Tuple.Create("\'", 1780)
, Tuple.Create(Tuple.Create("", 1719), Tuple.Create("IQLabel102013", 1719), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 1732), Tuple.Create<System.Object, System.Int32>(!Model.ExRSDate.LabelVisible ? " hide " : ""
, 1733), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1781), Tuple.Create("\'", 1986)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 1790), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ExRSDate.BackHEXColor) ? "" : "color:" + Model.ExRSDate.BackHEXColor + ";"
, 1790), false)
, Tuple.Create(Tuple.Create("", 1894), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1894), true)
);
WriteLiteral(">From</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ExchangeRates_ExRSDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ExRSDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.ExRSDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRSDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ExchRate/CallbackExRSDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateExRSDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.ExRSDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2574), Tuple.Create("\'", 2643)
, Tuple.Create(Tuple.Create("", 2582), Tuple.Create("IQLabel102014", 2582), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 2595), Tuple.Create<System.Object, System.Int32>(!Model.ExREDate.LabelVisible ? " hide " : ""
, 2596), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2644), Tuple.Create("\'", 2849)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 2653), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ExREDate.BackHEXColor) ? "" : "color:" + Model.ExREDate.BackHEXColor + ";"
, 2653), false)
, Tuple.Create(Tuple.Create("", 2757), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2757), true)
);
WriteLiteral(">To</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ExchangeRates_ExREDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ExREDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.ExREDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ExchRate/SaveExREDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ExchRate/CallbackExREDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateExREDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.ExREDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3435), Tuple.Create("\'", 3503)
, Tuple.Create(Tuple.Create("", 3443), Tuple.Create("IQLabel102015", 3443), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 3456), Tuple.Create<System.Object, System.Int32>(!Model.ExRRate.LabelVisible ? " hide " : ""
, 3457), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3504), Tuple.Create("\'", 3708)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 3513), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ExRRate.BackHEXColor) ? "" : "color:" + Model.ExRRate.BackHEXColor + ";"
, 3513), false)
, Tuple.Create(Tuple.Create("", 3615), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3615), true)
);
WriteLiteral(">Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ExchangeRates_ExRRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ExRRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.ExRRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ExchRate/CallbackExRRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateExRRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.ExRRate.ValueFormatted);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Edit_1.cshtml")]
    public partial class Views_ExchRate_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Edit_1_cshtml()
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
WriteLiteral(" href=\"/ExchRate/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Exchange Rates</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 413), Tuple.Create("\'", 475)
, Tuple.Create(Tuple.Create("", 423), Tuple.Create("IQJSCall(\"/ExchRate/Delete/?RecId=", 423), true)
         , Tuple.Create(Tuple.Create("", 457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 457), false)
, Tuple.Create(Tuple.Create("", 472), Tuple.Create("\");", 472), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ExchRa" +
"te/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ExchRate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1372), Tuple.Create("\'", 1394)
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1380), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1464)
, Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1448), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ExchRate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1566), Tuple.Create("\"", 1591)
, Tuple.Create(Tuple.Create("", 1574), Tuple.Create<System.Object, System.Int32>(Model.ExRIdValue
, 1574), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1637), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1702), Tuple.Create("\"", 1725)
, Tuple.Create(Tuple.Create("", 1710), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1710), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ExchRate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2024), Tuple.Create("\"", 2126)
, Tuple.Create(Tuple.Create("", 2031), Tuple.Create("/ExchRate/ViewHistory/?RecId=", 2031), true)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2060), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("&dt=", 2075), true)
, Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2079), false)
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
WriteLiteral(" id=\"ExchangeRates\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ExchRate_ExchangeRates.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2920), Tuple.Create("\"", 2935)
, Tuple.Create(Tuple.Create("", 2927), Tuple.Create("#", 2927), true)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2928), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3151), Tuple.Create("\"", 3163)
, Tuple.Create(Tuple.Create("", 3156), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3156), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Add_1.cshtml")]
    public partial class Views_ExchRate_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Exchange Rates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Exchange Rates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ExchRate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ExchangeRates\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ExchRate_ExchangeRates.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_List_1.cshtml")]
    public partial class Views_ExchRate_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ExchRate>>
    {
        public Views_ExchRate_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Exchange Rates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Exchange Rates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Exchange Rates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 590)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/ExchRate/ListFromQuery/?Clause=", 526), true)
                                                                    , Tuple.Create(Tuple.Create("", 558), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 558), false)
, Tuple.Create(Tuple.Create("", 573), Tuple.Create("&Ord=", 573), true)
                                                                                        , Tuple.Create(Tuple.Create("", 578), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 578), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Period Rate ID</th><th>Period Rate</th><th>Rate</th><th>From</th" +
"><th>To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 933), Tuple.Create("\"", 975)
, Tuple.Create(Tuple.Create("", 940), Tuple.Create("/ExchRate/Load/?RecId=", 940), true)
                 , Tuple.Create(Tuple.Create("", 962), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 962), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ExRId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1281), Tuple.Create("\"", 1368)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRName/?RecId=", 1292), true)
                                                                     , Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1344), false)
, Tuple.Create(Tuple.Create("", 1357), Tuple.Create("\',$(this));", 1357), true)
);
WriteLiteral(" data-bound-name=\'ExRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1426), Tuple.Create("\'", 1466)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1434), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRName.HTMLValue)
, 1434), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1652), Tuple.Create("\"", 1739)
, Tuple.Create(Tuple.Create("", 1663), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRRate/?RecId=", 1663), true)
                                                                     , Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1715), false)
, Tuple.Create(Tuple.Create("", 1728), Tuple.Create("\',$(this));", 1728), true)
);
WriteLiteral(" data-bound-name=\'ExRRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1797), Tuple.Create("\'", 1837)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1805), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRRate.HTMLValue)
, 1805), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2024), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRSDate/?RecId=", 2035), true)
                                                                      , Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2088), false)
, Tuple.Create(Tuple.Create("", 2101), Tuple.Create("\',$(this));", 2101), true)
);
WriteLiteral(" data-bound-name=\'ExRSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2171), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2179), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRSDate.HTMLValue)
, 2179), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExREDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2399), Tuple.Create("\"", 2487)
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExREDate/?RecId=", 2410), true)
                                                                      , Tuple.Create(Tuple.Create("", 2463), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2463), false)
, Tuple.Create(Tuple.Create("", 2476), Tuple.Create("\',$(this));", 2476), true)
);
WriteLiteral(" data-bound-name=\'ExREDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2546), Tuple.Create("\'", 2587)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2554), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExREDate.HTMLValue)
, 2554), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Edit_2.cshtml")]
    public partial class Views_ExchRate_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Edit_2_cshtml()
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
WriteLiteral(" href=\"/ExchRate/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Exchange Rates</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 413), Tuple.Create("\'", 475)
, Tuple.Create(Tuple.Create("", 423), Tuple.Create("IQJSCall(\"/ExchRate/Delete/?RecId=", 423), true)
         , Tuple.Create(Tuple.Create("", 457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 457), false)
, Tuple.Create(Tuple.Create("", 472), Tuple.Create("\");", 472), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ExchRa" +
"te/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ExchRate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1372), Tuple.Create("\'", 1394)
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1380), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1464)
, Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1448), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ExchRate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1566), Tuple.Create("\"", 1591)
, Tuple.Create(Tuple.Create("", 1574), Tuple.Create<System.Object, System.Int32>(Model.ExRIdValue
, 1574), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1637), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1702), Tuple.Create("\"", 1725)
, Tuple.Create(Tuple.Create("", 1710), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1710), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ExchRate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2024), Tuple.Create("\"", 2126)
, Tuple.Create(Tuple.Create("", 2031), Tuple.Create("/ExchRate/ViewHistory/?RecId=", 2031), true)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2060), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("&dt=", 2075), true)
, Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2079), false)
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
WriteLiteral(" id=\"ExchangeRates\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ExchRate_ExchangeRates.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2920), Tuple.Create("\"", 2935)
, Tuple.Create(Tuple.Create("", 2927), Tuple.Create("#", 2927), true)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2928), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3151), Tuple.Create("\"", 3163)
, Tuple.Create(Tuple.Create("", 3156), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3156), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Add_2.cshtml")]
    public partial class Views_ExchRate_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Exchange Rates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Exchange Rates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ExchRate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ExchangeRates\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ExchRate_ExchangeRates.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_List_2.cshtml")]
    public partial class Views_ExchRate_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ExchRate>>
    {
        public Views_ExchRate_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Exchange Rates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Exchange Rates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Exchange Rates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 590)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/ExchRate/ListFromQuery/?Clause=", 526), true)
                                                                    , Tuple.Create(Tuple.Create("", 558), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 558), false)
, Tuple.Create(Tuple.Create("", 573), Tuple.Create("&Ord=", 573), true)
                                                                                        , Tuple.Create(Tuple.Create("", 578), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 578), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Period Rate ID</th><th>Period Rate</th><th>Rate</th><th>From</th" +
"><th>To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 933), Tuple.Create("\"", 975)
, Tuple.Create(Tuple.Create("", 940), Tuple.Create("/ExchRate/Load/?RecId=", 940), true)
                 , Tuple.Create(Tuple.Create("", 962), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 962), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ExRId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1281), Tuple.Create("\"", 1368)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRName/?RecId=", 1292), true)
                                                                     , Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1344), false)
, Tuple.Create(Tuple.Create("", 1357), Tuple.Create("\',$(this));", 1357), true)
);
WriteLiteral(" data-bound-name=\'ExRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1426), Tuple.Create("\'", 1466)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1434), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRName.HTMLValue)
, 1434), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1652), Tuple.Create("\"", 1739)
, Tuple.Create(Tuple.Create("", 1663), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRRate/?RecId=", 1663), true)
                                                                     , Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1715), false)
, Tuple.Create(Tuple.Create("", 1728), Tuple.Create("\',$(this));", 1728), true)
);
WriteLiteral(" data-bound-name=\'ExRRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1797), Tuple.Create("\'", 1837)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1805), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRRate.HTMLValue)
, 1805), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2024), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRSDate/?RecId=", 2035), true)
                                                                      , Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2088), false)
, Tuple.Create(Tuple.Create("", 2101), Tuple.Create("\',$(this));", 2101), true)
);
WriteLiteral(" data-bound-name=\'ExRSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2171), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2179), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRSDate.HTMLValue)
, 2179), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExREDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2399), Tuple.Create("\"", 2487)
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExREDate/?RecId=", 2410), true)
                                                                      , Tuple.Create(Tuple.Create("", 2463), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2463), false)
, Tuple.Create(Tuple.Create("", 2476), Tuple.Create("\',$(this));", 2476), true)
);
WriteLiteral(" data-bound-name=\'ExREDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2546), Tuple.Create("\'", 2587)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2554), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExREDate.HTMLValue)
, 2554), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Edit_3.cshtml")]
    public partial class Views_ExchRate_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Edit_3_cshtml()
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
WriteLiteral(" href=\"/ExchRate/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Exchange Rates</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 413), Tuple.Create("\'", 475)
, Tuple.Create(Tuple.Create("", 423), Tuple.Create("IQJSCall(\"/ExchRate/Delete/?RecId=", 423), true)
         , Tuple.Create(Tuple.Create("", 457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 457), false)
, Tuple.Create(Tuple.Create("", 472), Tuple.Create("\");", 472), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ExchRa" +
"te/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ExchRate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1372), Tuple.Create("\'", 1394)
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1380), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1464)
, Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1448), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ExchRate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1566), Tuple.Create("\"", 1591)
, Tuple.Create(Tuple.Create("", 1574), Tuple.Create<System.Object, System.Int32>(Model.ExRIdValue
, 1574), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1637), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1702), Tuple.Create("\"", 1725)
, Tuple.Create(Tuple.Create("", 1710), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1710), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ExchRate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2024), Tuple.Create("\"", 2126)
, Tuple.Create(Tuple.Create("", 2031), Tuple.Create("/ExchRate/ViewHistory/?RecId=", 2031), true)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2060), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("&dt=", 2075), true)
, Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2079), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2718), Tuple.Create("\"", 2733)
, Tuple.Create(Tuple.Create("", 2725), Tuple.Create("#", 2725), true)
, Tuple.Create(Tuple.Create("", 2726), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2726), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2949), Tuple.Create("\"", 2961)
, Tuple.Create(Tuple.Create("", 2954), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2954), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_Add_3.cshtml")]
    public partial class Views_ExchRate_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ExchRate>
    {
        public Views_ExchRate_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Exchange Rates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Exchange Rates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ExchRate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ExchRate>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ExchRate_List_3.cshtml")]
    public partial class Views_ExchRate_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ExchRate>>
    {
        public Views_ExchRate_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Exchange Rates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Exchange Rates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Exchange Rates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ExchRate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 519), Tuple.Create("\"", 590)
, Tuple.Create(Tuple.Create("", 526), Tuple.Create("/ExchRate/ListFromQuery/?Clause=", 526), true)
                                                                    , Tuple.Create(Tuple.Create("", 558), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 558), false)
, Tuple.Create(Tuple.Create("", 573), Tuple.Create("&Ord=", 573), true)
                                                                                        , Tuple.Create(Tuple.Create("", 578), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 578), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Period Rate ID</th><th>Period Rate</th><th>Rate</th><th>From</th" +
"><th>To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 933), Tuple.Create("\"", 975)
, Tuple.Create(Tuple.Create("", 940), Tuple.Create("/ExchRate/Load/?RecId=", 940), true)
                 , Tuple.Create(Tuple.Create("", 962), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 962), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ExRId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1281), Tuple.Create("\"", 1368)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRName/?RecId=", 1292), true)
                                                                     , Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1344), false)
, Tuple.Create(Tuple.Create("", 1357), Tuple.Create("\',$(this));", 1357), true)
);
WriteLiteral(" data-bound-name=\'ExRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1426), Tuple.Create("\'", 1466)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1434), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRName.HTMLValue)
, 1434), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1652), Tuple.Create("\"", 1739)
, Tuple.Create(Tuple.Create("", 1663), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRRate/?RecId=", 1663), true)
                                                                     , Tuple.Create(Tuple.Create("", 1715), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1715), false)
, Tuple.Create(Tuple.Create("", 1728), Tuple.Create("\',$(this));", 1728), true)
);
WriteLiteral(" data-bound-name=\'ExRRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1797), Tuple.Create("\'", 1837)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1805), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRRate.HTMLValue)
, 1805), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExRSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2024), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExRSDate/?RecId=", 2035), true)
                                                                      , Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2088), false)
, Tuple.Create(Tuple.Create("", 2101), Tuple.Create("\',$(this));", 2101), true)
);
WriteLiteral(" data-bound-name=\'ExRSDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2171), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2179), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExRSDate.HTMLValue)
, 2179), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ExREDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2399), Tuple.Create("\"", 2487)
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create("javascript:IQAutoSave(\'/ExchRate/SaveExREDate/?RecId=", 2410), true)
                                                                      , Tuple.Create(Tuple.Create("", 2463), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2463), false)
, Tuple.Create(Tuple.Create("", 2476), Tuple.Create("\',$(this));", 2476), true)
);
WriteLiteral(" data-bound-name=\'ExREDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2546), Tuple.Create("\'", 2587)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2554), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ExREDate.HTMLValue)
, 2554), false)
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
