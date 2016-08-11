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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_SMSTemplate.cshtml")]
    public partial class Views_SMSTemplate_SMSTemplate_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_SMSTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 67), Tuple.Create("\'", 136)
, Tuple.Create(Tuple.Create("", 75), Tuple.Create("IQLabel106211", 75), true)
, Tuple.Create(Tuple.Create(" ", 88), Tuple.Create<System.Object, System.Int32>(!Model.SMSTName.LabelVisible ? " hide " : ""
, 89), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 137), Tuple.Create("\'", 341)
       , Tuple.Create(Tuple.Create("", 146), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTName.BackHEXColor) ? "" : "color:" + Model.SMSTName.BackHEXColor + ";"
, 146), false)
, Tuple.Create(Tuple.Create("", 250), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 250), true)
);
WriteLiteral(">Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSTName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SMSTName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSTName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.SMSTName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:220px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 933), Tuple.Create("\'", 1004)
, Tuple.Create(Tuple.Create("", 941), Tuple.Create("IQLabel106212", 941), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 954), Tuple.Create<System.Object, System.Int32>(!Model.SMSTSender.LabelVisible ? " hide " : ""
, 955), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1005), Tuple.Create("\'", 1214)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1014), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTSender.BackHEXColor) ? "" : "color:" + Model.SMSTSender.BackHEXColor + ";"
, 1014), false)
, Tuple.Create(Tuple.Create("", 1122), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1122), true)
);
WriteLiteral(">Sender</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTSender\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSTSender.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SMSTSender.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTSender/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTSender/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSTSender\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.SMSTSender.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:220px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1823), Tuple.Create("\'", 1895)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create("IQLabel106213", 1831), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 1844), Tuple.Create<System.Object, System.Int32>(!Model.SMSTContent.LabelVisible ? " hide " : ""
, 1845), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1896), Tuple.Create("\'", 2106)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTContent.BackHEXColor) ? "" : "color:" + Model.SMSTContent.BackHEXColor + ";"
, 1905), false)
, Tuple.Create(Tuple.Create("", 2015), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:5px;height:21px;width:120px" +
";top:53px;", 2015), true)
);
WriteLiteral(">Content</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'600\'");
WriteLiteral(" style=\'position: absolute; left:5px;height:146px;width:600px;top:78px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Content\'");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTContent\'");
WriteLiteral(" ");
                                                                                                                                                                                                             Write(Model.RecordLocked || !Model.SMSTContent.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTContent/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTContent/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(!Model.SMSTContent.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSMSTContent\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PopulateSMSTContent);
WriteLiteral("</textarea><div");
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
WriteLiteral(">\r\n\t\t\t\r\n\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:IQPopupEditor(this)\'");
WriteLiteral(" data-target=\"*[name=PopulateSMSTContent]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3305), Tuple.Create("\'", 3377)
, Tuple.Create(Tuple.Create("", 3313), Tuple.Create("IQLabel106231", 3313), true)
, Tuple.Create(Tuple.Create(" ", 3326), Tuple.Create<System.Object, System.Int32>(!Model.SMSTDataset.LabelVisible ? " hide " : ""
, 3327), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3378), Tuple.Create("\'", 3590)
                                 , Tuple.Create(Tuple.Create("", 3387), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTDataset.BackHEXColor) ? "" : "color:" + Model.SMSTDataset.BackHEXColor + ";"
, 3387), false)
, Tuple.Create(Tuple.Create("", 3497), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:3px;", 3497), true)
);
WriteLiteral(">Applies To</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTDataset\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSTDataset.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.SMSTDataset.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTDataset/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTDataset/',$(this));\""));
WriteLiteral("   name=\'PopulateSMSTDataset\'  style=\'position: absolute; left:500px;height:21px;" +
"width:200px;top:3px;\'>\r\n");
             foreach(var itm in Model.SMSTDataset.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4217), Tuple.Create("\'", 4238)
, Tuple.Create(Tuple.Create("", 4225), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4225), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateSMSTDataset.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                            Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4373), Tuple.Create("\'", 4449)
, Tuple.Create(Tuple.Create("", 4381), Tuple.Create("IQLabel106232", 4381), true)
, Tuple.Create(Tuple.Create(" ", 4394), Tuple.Create<System.Object, System.Int32>(!Model.SMSTDestination.LabelVisible ? " hide " : ""
, 4395), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4450), Tuple.Create("\'", 4671)
                              , Tuple.Create(Tuple.Create("", 4459), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTDestination.BackHEXColor) ? "" : "color:" + Model.SMSTDestination.BackHEXColor + ";"
, 4459), false)
, Tuple.Create(Tuple.Create("", 4577), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:28px;", 4577), true)
);
WriteLiteral(">Destination</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTDestination\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSTDestination.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                             Write(!Model.SMSTDestination.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTDestination/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTDestination/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSTDestination\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.SMSTDestination.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:220px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5320), Tuple.Create("\'", 5390)
, Tuple.Create(Tuple.Create("", 5328), Tuple.Create("IQLabel106233", 5328), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 5341), Tuple.Create<System.Object, System.Int32>(!Model.SMSTQuery.LabelVisible ? " hide " : ""
, 5342), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5391), Tuple.Create("\'", 5600)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 5400), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSTQuery.BackHEXColor) ? "" : "color:" + Model.SMSTQuery.BackHEXColor + ";"
, 5400), false)
, Tuple.Create(Tuple.Create("", 5506), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:53px;", 5506), true)
);
WriteLiteral(">Query</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'SMSTemplate_SMSTQuery\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSTQuery.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                        Write(!Model.SMSTQuery.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTQuery/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMSTemplate/CallbackSMSTQuery/',$(this));\""));
WriteLiteral("   name=\'PopulateSMSTQuery\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.SMSTQuery.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 6279), Tuple.Create("\'", 6300)
, Tuple.Create(Tuple.Create("", 6287), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 6287), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateSMSTQuery.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
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
WriteLiteral(" data-target=\"*[name=PopulateSMSTQuery]\"");
WriteLiteral(" data-url=\"/Query/Load/?QryId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Query/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Query</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Edit_1.cshtml")]
    public partial class Views_SMSTemplate_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMSTem" +
"plate/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMSTemplate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1161), Tuple.Create("\'", 1183)
, Tuple.Create(Tuple.Create("", 1169), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1169), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1229), Tuple.Create("\'", 1253)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1237), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMSTemplate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1358), Tuple.Create("\"", 1384)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Model.SMSTIdValue
, 1366), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1430), Tuple.Create("\"", 1453)
, Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1438), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1495), Tuple.Create("\"", 1518)
, Tuple.Create(Tuple.Create("", 1503), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1503), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMSTemplate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1820), Tuple.Create("\"", 1925)
, Tuple.Create(Tuple.Create("", 1827), Tuple.Create("/SMSTemplate/ViewHistory/?RecId=", 1827), true)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1859), false)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create("&dt=", 1874), true)
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1878), false)
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Add_1.cshtml")]
    public partial class Views_SMSTemplate_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS Template";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS Template\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMSTemplate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_List_1.cshtml")]
    public partial class Views_SMSTemplate_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMSTemplate>>
    {
        public Views_SMSTemplate_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS Template List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS Template List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS Template</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 596)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/SMSTemplate/ListFromQuery/?Clause=", 529), true)
                                                                       , Tuple.Create(Tuple.Create("", 564), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 564), false)
, Tuple.Create(Tuple.Create("", 579), Tuple.Create("&Ord=", 579), true)
                                                                                           , Tuple.Create(Tuple.Create("", 584), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 584), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Applies To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 891), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 898), Tuple.Create("/SMSTemplate/Load/?RecId=", 898), true)
                    , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1187), Tuple.Create("\"", 1278)
, Tuple.Create(Tuple.Create("", 1198), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTName/?RecId=", 1198), true)
                                                                         , Tuple.Create(Tuple.Create("", 1254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1254), false)
, Tuple.Create(Tuple.Create("", 1267), Tuple.Create("\',$(this));", 1267), true)
);
WriteLiteral(" data-bound-name=\'SMSTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1337), Tuple.Create("\'", 1378)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.SMSTName.HTMLValue)
, 1345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTDataset.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1566), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTDataset/?RecId=", 1577), true)
                                                                          , Tuple.Create(Tuple.Create("", 1636), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1636), false)
, Tuple.Create(Tuple.Create("", 1649), Tuple.Create("\',$(this));", 1649), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SMSTDataset\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.SMSTDataset.HTMLValue));
WriteLiteral("</select></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Edit_2.cshtml")]
    public partial class Views_SMSTemplate_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMSTem" +
"plate/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMSTemplate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1161), Tuple.Create("\'", 1183)
, Tuple.Create(Tuple.Create("", 1169), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1169), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1229), Tuple.Create("\'", 1253)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1237), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMSTemplate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1358), Tuple.Create("\"", 1384)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Model.SMSTIdValue
, 1366), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1430), Tuple.Create("\"", 1453)
, Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1438), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1495), Tuple.Create("\"", 1518)
, Tuple.Create(Tuple.Create("", 1503), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1503), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMSTemplate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1820), Tuple.Create("\"", 1925)
, Tuple.Create(Tuple.Create("", 1827), Tuple.Create("/SMSTemplate/ViewHistory/?RecId=", 1827), true)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1859), false)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create("&dt=", 1874), true)
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1878), false)
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Add_2.cshtml")]
    public partial class Views_SMSTemplate_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS Template";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS Template\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMSTemplate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_List_2.cshtml")]
    public partial class Views_SMSTemplate_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMSTemplate>>
    {
        public Views_SMSTemplate_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS Template List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS Template List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS Template</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 596)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/SMSTemplate/ListFromQuery/?Clause=", 529), true)
                                                                       , Tuple.Create(Tuple.Create("", 564), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 564), false)
, Tuple.Create(Tuple.Create("", 579), Tuple.Create("&Ord=", 579), true)
                                                                                           , Tuple.Create(Tuple.Create("", 584), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 584), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Applies To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 891), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 898), Tuple.Create("/SMSTemplate/Load/?RecId=", 898), true)
                    , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1187), Tuple.Create("\"", 1278)
, Tuple.Create(Tuple.Create("", 1198), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTName/?RecId=", 1198), true)
                                                                         , Tuple.Create(Tuple.Create("", 1254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1254), false)
, Tuple.Create(Tuple.Create("", 1267), Tuple.Create("\',$(this));", 1267), true)
);
WriteLiteral(" data-bound-name=\'SMSTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1337), Tuple.Create("\'", 1378)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.SMSTName.HTMLValue)
, 1345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTDataset.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1566), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTDataset/?RecId=", 1577), true)
                                                                          , Tuple.Create(Tuple.Create("", 1636), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1636), false)
, Tuple.Create(Tuple.Create("", 1649), Tuple.Create("\',$(this));", 1649), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SMSTDataset\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.SMSTDataset.HTMLValue));
WriteLiteral("</select></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Edit_3.cshtml")]
    public partial class Views_SMSTemplate_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMSTem" +
"plate/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMSTemplate", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1161), Tuple.Create("\'", 1183)
, Tuple.Create(Tuple.Create("", 1169), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1169), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1229), Tuple.Create("\'", 1253)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1237), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMSTemplate\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1358), Tuple.Create("\"", 1384)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create<System.Object, System.Int32>(Model.SMSTIdValue
, 1366), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1430), Tuple.Create("\"", 1453)
, Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1438), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1495), Tuple.Create("\"", 1518)
, Tuple.Create(Tuple.Create("", 1503), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1503), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMSTemplate/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1820), Tuple.Create("\"", 1925)
, Tuple.Create(Tuple.Create("", 1827), Tuple.Create("/SMSTemplate/ViewHistory/?RecId=", 1827), true)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1859), false)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create("&dt=", 1874), true)
, Tuple.Create(Tuple.Create("", 1878), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1878), false)
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_Add_3.cshtml")]
    public partial class Views_SMSTemplate_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.SMSTemplate>
    {
        public Views_SMSTemplate_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS Template";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS Template\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMSTemplate/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMSTemplate>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMSTemplate\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMSTemplate_SMSTemplate.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMSTemplate_List_3.cshtml")]
    public partial class Views_SMSTemplate_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMSTemplate>>
    {
        public Views_SMSTemplate_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS Template List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS Template List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS Template</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMSTemplate/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 596)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/SMSTemplate/ListFromQuery/?Clause=", 529), true)
                                                                       , Tuple.Create(Tuple.Create("", 564), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 564), false)
, Tuple.Create(Tuple.Create("", 579), Tuple.Create("&Ord=", 579), true)
                                                                                           , Tuple.Create(Tuple.Create("", 584), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 584), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Applies To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 891), Tuple.Create("\"", 936)
, Tuple.Create(Tuple.Create("", 898), Tuple.Create("/SMSTemplate/Load/?RecId=", 898), true)
                    , Tuple.Create(Tuple.Create("", 923), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 923), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1187), Tuple.Create("\"", 1278)
, Tuple.Create(Tuple.Create("", 1198), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTName/?RecId=", 1198), true)
                                                                         , Tuple.Create(Tuple.Create("", 1254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1254), false)
, Tuple.Create(Tuple.Create("", 1267), Tuple.Create("\',$(this));", 1267), true)
);
WriteLiteral(" data-bound-name=\'SMSTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1337), Tuple.Create("\'", 1378)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.SMSTName.HTMLValue)
, 1345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SMSTDataset.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1566), Tuple.Create("\"", 1660)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create("javascript:IQAutoSave(\'/SMSTemplate/SaveSMSTDataset/?RecId=", 1577), true)
                                                                          , Tuple.Create(Tuple.Create("", 1636), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1636), false)
, Tuple.Create(Tuple.Create("", 1649), Tuple.Create("\',$(this));", 1649), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SMSTDataset\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.SMSTDataset.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
