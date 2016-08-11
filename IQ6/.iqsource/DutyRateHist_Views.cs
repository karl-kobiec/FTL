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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_DutyRateHistory.cshtml")]
    public partial class Views_DutyRateHist_DutyRateHistory_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_DutyRateHistory_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 68), Tuple.Create("\'", 134)
, Tuple.Create(Tuple.Create("", 76), Tuple.Create("IQLabel103911", 76), true)
, Tuple.Create(Tuple.Create(" ", 89), Tuple.Create<System.Object, System.Int32>(!Model.DRHId.LabelVisible ? " hide " : ""
, 90), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 135), Tuple.Create("\'", 333)
    , Tuple.Create(Tuple.Create("", 144), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DRHId.BackHEXColor) ? "" : "color:" + Model.DRHId.BackHEXColor + ";"
, 144), false)
, Tuple.Create(Tuple.Create("", 242), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 242), true)
);
WriteLiteral(">History Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DutyRateHistory_DRHId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 425), Tuple.Create("\'", 487)
, Tuple.Create(Tuple.Create("", 433), Tuple.Create("form-control", 433), true)
, Tuple.Create(Tuple.Create("   ", 445), Tuple.Create<System.Object, System.Int32>(!Model.DRHId.Visible ? " hide " : ""
, 448), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DutyRateHist/CallbackDRHId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDRHId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.DRHId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 860), Tuple.Create("\'", 931)
, Tuple.Create(Tuple.Create("", 868), Tuple.Create("IQLabel103912", 868), true)
                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 881), Tuple.Create<System.Object, System.Int32>(!Model.DRHTaxCode.LabelVisible ? " hide " : ""
, 882), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 932), Tuple.Create("\'", 1141)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DRHTaxCode.BackHEXColor) ? "" : "color:" + Model.DRHTaxCode.BackHEXColor + ";"
, 941), false)
, Tuple.Create(Tuple.Create("", 1049), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1049), true)
);
WriteLiteral(">Tax Code</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'DutyRateHistory_DRHTaxCode\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHTaxCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DutyRateHist/CallbackDRHTaxCode/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                         Write(!Model.DRHTaxCode.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/DutyRateHist/AutoCompleteDRHTaxCode/");
                                                      Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateDRHTaxCode\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateDRHTaxCode.ToString() != "" && Model.PopulateDRHTaxCode.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.DRHTaxCode.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateDRHTaxCode]\"");
WriteLiteral(" data-url=\"/REDSTax/Load/?RDTaxId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/REDSTax/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All REDS Tax Codes</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2801), Tuple.Create("\'", 2875)
, Tuple.Create(Tuple.Create("", 2809), Tuple.Create("IQLabel103913", 2809), true)
, Tuple.Create(Tuple.Create(" ", 2822), Tuple.Create<System.Object, System.Int32>(!Model.DRHChangeDate.LabelVisible ? " hide " : ""
, 2823), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2876), Tuple.Create("\'", 3091)
                               , Tuple.Create(Tuple.Create("", 2885), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DRHChangeDate.BackHEXColor) ? "" : "color:" + Model.DRHChangeDate.BackHEXColor + ";"
, 2885), false)
, Tuple.Create(Tuple.Create("", 2999), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2999), true)
);
WriteLiteral(">Date of Change</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DutyRateHistory_DRHChangeDate\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3195), Tuple.Create("\'", 3265)
, Tuple.Create(Tuple.Create("", 3203), Tuple.Create("form-control", 3203), true)
, Tuple.Create(Tuple.Create("   ", 3215), Tuple.Create<System.Object, System.Int32>(!Model.DRHChangeDate.Visible ? " hide " : ""
, 3218), false)
);
WriteLiteral(" ");
                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHChangeDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DutyRateHist/CallbackDRHChangeDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDRHChangeDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.DRHChangeDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3671), Tuple.Create("\'", 3743)
, Tuple.Create(Tuple.Create("", 3679), Tuple.Create("IQLabel103914", 3679), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 3692), Tuple.Create<System.Object, System.Int32>(!Model.DRHDutyRate.LabelVisible ? " hide " : ""
, 3693), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3744), Tuple.Create("\'", 3955)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3753), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DRHDutyRate.BackHEXColor) ? "" : "color:" + Model.DRHDutyRate.BackHEXColor + ";"
, 3753), false)
, Tuple.Create(Tuple.Create("", 3863), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3863), true)
);
WriteLiteral(">Duty Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DutyRateHistory_DRHDutyRate\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4052), Tuple.Create("\'", 4120)
, Tuple.Create(Tuple.Create("", 4060), Tuple.Create("form-control", 4060), true)
, Tuple.Create(Tuple.Create("   ", 4072), Tuple.Create<System.Object, System.Int32>(!Model.DRHDutyRate.Visible ? " hide " : ""
, 4075), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHDutyRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DutyRateHist/CallbackDRHDutyRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDRHDutyRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.DRHDutyRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 4518), Tuple.Create("\'", 4588)
, Tuple.Create(Tuple.Create("", 4526), Tuple.Create("IQLabel103915", 4526), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 4539), Tuple.Create<System.Object, System.Int32>(!Model.DRHAlcPct.LabelVisible ? " hide " : ""
, 4540), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4589), Tuple.Create("\'", 4797)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 4598), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DRHAlcPct.BackHEXColor) ? "" : "color:" + Model.DRHAlcPct.BackHEXColor + ";"
, 4598), false)
, Tuple.Create(Tuple.Create("", 4704), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4704), true)
);
WriteLiteral(">Alcohol %age</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DutyRateHistory_DRHAlcPct\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4895), Tuple.Create("\'", 4961)
, Tuple.Create(Tuple.Create("", 4903), Tuple.Create("form-control", 4903), true)
, Tuple.Create(Tuple.Create("   ", 4915), Tuple.Create<System.Object, System.Int32>(!Model.DRHAlcPct.Visible ? " hide " : ""
, 4918), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHAlcPct/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/DutyRateHist/CallbackDRHAlcPct/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDRHAlcPct\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                            Write(Model.DRHAlcPct.ValueFormatted);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Edit_1.cshtml")]
    public partial class Views_DutyRateHist_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Edit_1_cshtml()
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
WriteLiteral(" href=\"/DutyRateHist/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Duty Rate History</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 424), Tuple.Create("\'", 490)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create("IQJSCall(\"/DutyRateHist/Delete/?RecId=", 434), true)
             , Tuple.Create(Tuple.Create("", 472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 472), false)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("\");", 487), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DutyRa" +
"teHist/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DutyRateHist", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1421)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1467), Tuple.Create("\'", 1491)
, Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1475), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DutyRateHist\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1597), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create<System.Object, System.Int32>(Model.DRHIdValue
, 1605), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1668), Tuple.Create("\"", 1691)
, Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1676), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1733), Tuple.Create("\"", 1756)
, Tuple.Create(Tuple.Create("", 1741), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1741), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DutyRateHist/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2059), Tuple.Create("\"", 2165)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("/DutyRateHist/ViewHistory/?RecId=", 2066), true)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2099), false)
, Tuple.Create(Tuple.Create("", 2114), Tuple.Create("&dt=", 2114), true)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2118), false)
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
WriteLiteral(" id=\"DutyRateHistory\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DutyRateHist_DutyRateHistory.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2967), Tuple.Create("\"", 2982)
, Tuple.Create(Tuple.Create("", 2974), Tuple.Create("#", 2974), true)
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2975), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3198), Tuple.Create("\"", 3210)
, Tuple.Create(Tuple.Create("", 3203), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3203), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Add_1.cshtml")]
    public partial class Views_DutyRateHist_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Duty Rate History";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Duty Rate History\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DutyRateHist/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DutyRateHistory\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DutyRateHist_DutyRateHistory.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_List_1.cshtml")]
    public partial class Views_DutyRateHist_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DutyRateHist>>
    {
        public Views_DutyRateHist_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Duty Rate History List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Duty Rate History List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Duty Rate History</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 540), Tuple.Create("\"", 615)
, Tuple.Create(Tuple.Create("", 547), Tuple.Create("/DutyRateHist/ListFromQuery/?Clause=", 547), true)
                                                                        , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 583), false)
, Tuple.Create(Tuple.Create("", 598), Tuple.Create("&Ord=", 598), true)
                                                                                            , Tuple.Create(Tuple.Create("", 603), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 603), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Date of Change</th><th>Tax Code</th><th>Duty Rate</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 936), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("/DutyRateHist/Load/?RecId=", 943), true)
                     , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DRHChangeDate.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                       Write(itm.DRHTaxCode.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                    Write(itm.DRHDutyRate.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Edit_2.cshtml")]
    public partial class Views_DutyRateHist_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Edit_2_cshtml()
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
WriteLiteral(" href=\"/DutyRateHist/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Duty Rate History</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 424), Tuple.Create("\'", 490)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create("IQJSCall(\"/DutyRateHist/Delete/?RecId=", 434), true)
             , Tuple.Create(Tuple.Create("", 472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 472), false)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("\");", 487), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DutyRa" +
"teHist/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DutyRateHist", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1421)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1467), Tuple.Create("\'", 1491)
, Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1475), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DutyRateHist\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1597), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create<System.Object, System.Int32>(Model.DRHIdValue
, 1605), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1668), Tuple.Create("\"", 1691)
, Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1676), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1733), Tuple.Create("\"", 1756)
, Tuple.Create(Tuple.Create("", 1741), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1741), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DutyRateHist/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2059), Tuple.Create("\"", 2165)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("/DutyRateHist/ViewHistory/?RecId=", 2066), true)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2099), false)
, Tuple.Create(Tuple.Create("", 2114), Tuple.Create("&dt=", 2114), true)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2118), false)
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
WriteLiteral(" id=\"DutyRateHistory\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DutyRateHist_DutyRateHistory.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2967), Tuple.Create("\"", 2982)
, Tuple.Create(Tuple.Create("", 2974), Tuple.Create("#", 2974), true)
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2975), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3198), Tuple.Create("\"", 3210)
, Tuple.Create(Tuple.Create("", 3203), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3203), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Add_2.cshtml")]
    public partial class Views_DutyRateHist_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Duty Rate History";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Duty Rate History\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DutyRateHist/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DutyRateHistory\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/DutyRateHist_DutyRateHistory.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_List_2.cshtml")]
    public partial class Views_DutyRateHist_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DutyRateHist>>
    {
        public Views_DutyRateHist_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Duty Rate History List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Duty Rate History List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Duty Rate History</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 540), Tuple.Create("\"", 615)
, Tuple.Create(Tuple.Create("", 547), Tuple.Create("/DutyRateHist/ListFromQuery/?Clause=", 547), true)
                                                                        , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 583), false)
, Tuple.Create(Tuple.Create("", 598), Tuple.Create("&Ord=", 598), true)
                                                                                            , Tuple.Create(Tuple.Create("", 603), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 603), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Date of Change</th><th>Tax Code</th><th>Duty Rate</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 936), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("/DutyRateHist/Load/?RecId=", 943), true)
                     , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DRHChangeDate.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                       Write(itm.DRHTaxCode.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                    Write(itm.DRHDutyRate.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Edit_3.cshtml")]
    public partial class Views_DutyRateHist_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Edit_3_cshtml()
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
WriteLiteral(" href=\"/DutyRateHist/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Duty Rate History</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 424), Tuple.Create("\'", 490)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create("IQJSCall(\"/DutyRateHist/Delete/?RecId=", 434), true)
             , Tuple.Create(Tuple.Create("", 472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 472), false)
, Tuple.Create(Tuple.Create("", 487), Tuple.Create("\");", 487), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/DutyRa" +
"teHist/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("DutyRateHist", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1399), Tuple.Create("\'", 1421)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1467), Tuple.Create("\'", 1491)
, Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1475), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"DutyRateHist\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1597), Tuple.Create("\"", 1622)
, Tuple.Create(Tuple.Create("", 1605), Tuple.Create<System.Object, System.Int32>(Model.DRHIdValue
, 1605), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1668), Tuple.Create("\"", 1691)
, Tuple.Create(Tuple.Create("", 1676), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1676), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1733), Tuple.Create("\"", 1756)
, Tuple.Create(Tuple.Create("", 1741), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1741), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/DutyRateHist/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2059), Tuple.Create("\"", 2165)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("/DutyRateHist/ViewHistory/?RecId=", 2066), true)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2099), false)
, Tuple.Create(Tuple.Create("", 2114), Tuple.Create("&dt=", 2114), true)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2118), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2757), Tuple.Create("\"", 2772)
, Tuple.Create(Tuple.Create("", 2764), Tuple.Create("#", 2764), true)
, Tuple.Create(Tuple.Create("", 2765), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2765), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2988), Tuple.Create("\"", 3000)
, Tuple.Create(Tuple.Create("", 2993), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2993), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_Add_3.cshtml")]
    public partial class Views_DutyRateHist_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.DutyRateHist>
    {
        public Views_DutyRateHist_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Duty Rate History";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Duty Rate History\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/DutyRateHist/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<DutyRateHist>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DutyRateHist_List_3.cshtml")]
    public partial class Views_DutyRateHist_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.DutyRateHist>>
    {
        public Views_DutyRateHist_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Duty Rate History List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Duty Rate History List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Duty Rate History</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/DutyRateHist/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 540), Tuple.Create("\"", 615)
, Tuple.Create(Tuple.Create("", 547), Tuple.Create("/DutyRateHist/ListFromQuery/?Clause=", 547), true)
                                                                        , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 583), false)
, Tuple.Create(Tuple.Create("", 598), Tuple.Create("&Ord=", 598), true)
                                                                                            , Tuple.Create(Tuple.Create("", 603), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 603), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Date of Change</th><th>Tax Code</th><th>Duty Rate</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 936), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("/DutyRateHist/Load/?RecId=", 943), true)
                     , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DRHChangeDate.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                       Write(itm.DRHTaxCode.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                                                                                    Write(itm.DRHDutyRate.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
