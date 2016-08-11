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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_SMS.cshtml")]
    public partial class Views_SMS_SMS_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_SMS_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 59), Tuple.Create("\'", 129)
, Tuple.Create(Tuple.Create("", 67), Tuple.Create("IQLabel106311", 67), true)
, Tuple.Create(Tuple.Create(" ", 80), Tuple.Create<System.Object, System.Int32>(!Model.SMSSender.LabelVisible ? " hide " : ""
, 81), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 130), Tuple.Create("\'", 336)
        , Tuple.Create(Tuple.Create("", 139), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSSender.BackHEXColor) ? "" : "color:" + Model.SMSSender.BackHEXColor + ";"
, 139), false)
, Tuple.Create(Tuple.Create("", 245), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 245), true)
);
WriteLiteral(">Sender</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSSender\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSSender.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.SMSSender.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSSender/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSSender/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSSender\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.SMSSender.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 913), Tuple.Create("\'", 988)
, Tuple.Create(Tuple.Create("", 921), Tuple.Create("IQLabel106312", 921), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 934), Tuple.Create<System.Object, System.Int32>(!Model.SMSDestination.LabelVisible ? " hide " : ""
, 935), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 989), Tuple.Create("\'", 1206)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 998), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSDestination.BackHEXColor) ? "" : "color:" + Model.SMSDestination.BackHEXColor + ";"
, 998), false)
, Tuple.Create(Tuple.Create("", 1114), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1114), true)
);
WriteLiteral(">Destination</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSDestination\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSDestination.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.SMSDestination.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDestination/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSDestination/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSDestination\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.SMSDestination.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1824), Tuple.Create("\'", 1895)
, Tuple.Create(Tuple.Create("", 1832), Tuple.Create("IQLabel106313", 1832), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 1845), Tuple.Create<System.Object, System.Int32>(!Model.SMSContent.LabelVisible ? " hide " : ""
, 1846), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1896), Tuple.Create("\'", 2106)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSContent.BackHEXColor) ? "" : "color:" + Model.SMSContent.BackHEXColor + ";"
, 1905), false)
, Tuple.Create(Tuple.Create("", 2013), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 2013), true)
);
WriteLiteral(">Content</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:400px;top:103px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Content\'");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSContent\'");
WriteLiteral(" ");
                                                                                                                                                                                                        Write(Model.RecordLocked || !Model.SMSContent.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSContent/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSContent/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(!Model.SMSContent.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSMSContent\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.PopulateSMSContent);
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
WriteLiteral(" data-target=\"*[name=PopulateSMSContent]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3274), Tuple.Create("\'", 3348)
, Tuple.Create(Tuple.Create("", 3282), Tuple.Create("IQLabel106331", 3282), true)
, Tuple.Create(Tuple.Create(" ", 3295), Tuple.Create<System.Object, System.Int32>(!Model.SMSDateQueued.LabelVisible ? " hide " : ""
, 3296), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3349), Tuple.Create("\'", 3565)
                                   , Tuple.Create(Tuple.Create("", 3358), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSDateQueued.BackHEXColor) ? "" : "color:" + Model.SMSDateQueued.BackHEXColor + ";"
, 3358), false)
, Tuple.Create(Tuple.Create("", 3472), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 3472), true)
);
WriteLiteral(">Queued</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSDateQueued\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3649), Tuple.Create("\'", 3719)
, Tuple.Create(Tuple.Create("", 3657), Tuple.Create("form-control", 3657), true)
, Tuple.Create(Tuple.Create("   ", 3669), Tuple.Create<System.Object, System.Int32>(!Model.SMSDateQueued.Visible ? " hide " : ""
, 3672), false)
);
WriteLiteral(" ");
                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDateQueued/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSDateQueued/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSDateQueued\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                          Write(Model.SMSDateQueued.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4106), Tuple.Create("\'", 4183)
, Tuple.Create(Tuple.Create("", 4114), Tuple.Create("IQLabel106332", 4114), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 4127), Tuple.Create<System.Object, System.Int32>(!Model.SMSDateConfirmed.LabelVisible ? " hide " : ""
, 4128), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4184), Tuple.Create("\'", 4407)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 4193), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSDateConfirmed.BackHEXColor) ? "" : "color:" + Model.SMSDateConfirmed.BackHEXColor + ";"
, 4193), false)
, Tuple.Create(Tuple.Create("", 4313), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 4313), true)
);
WriteLiteral(">Delivered</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSDateConfirmed\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4497), Tuple.Create("\'", 4570)
, Tuple.Create(Tuple.Create("", 4505), Tuple.Create("form-control", 4505), true)
, Tuple.Create(Tuple.Create("   ", 4517), Tuple.Create<System.Object, System.Int32>(!Model.SMSDateConfirmed.Visible ? " hide " : ""
, 4520), false)
);
WriteLiteral(" ");
                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDateConfirmed/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSDateConfirmed/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSDateConfirmed\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.SMSDateConfirmed.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 4970), Tuple.Create("\'", 5040)
, Tuple.Create(Tuple.Create("", 4978), Tuple.Create("IQLabel106333", 4978), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 4991), Tuple.Create<System.Object, System.Int32>(!Model.SMSStatus.LabelVisible ? " hide " : ""
, 4992), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5041), Tuple.Create("\'", 5250)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 5050), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSStatus.BackHEXColor) ? "" : "color:" + Model.SMSStatus.BackHEXColor + ";"
, 5050), false)
, Tuple.Create(Tuple.Create("", 5156), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 5156), true)
);
WriteLiteral(">Status</label>\r\n\t\t<select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'SMS_SMSStatus\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSStatus/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                 Write(!Model.SMSStatus.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/SMS/AutoCompleteSMSStatus/");
                                            Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateSMSStatus\'  style=\'position: absolute; left:420px;height:21px;wi" +
"dth:160px;top:53px;\'>\r\n");
                 if(Model.PopulateSMSStatus.ToString() != "" && Model.PopulateSMSStatus.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.SMSStatus.HTMLValue));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6028), Tuple.Create("\'", 6099)
, Tuple.Create(Tuple.Create("", 6036), Tuple.Create("IQLabel106351", 6036), true)
, Tuple.Create(Tuple.Create(" ", 6049), Tuple.Create<System.Object, System.Int32>(!Model.SMSDataset.LabelVisible ? " hide " : ""
, 6050), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6100), Tuple.Create("\'", 6310)
                         , Tuple.Create(Tuple.Create("", 6109), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSDataset.BackHEXColor) ? "" : "color:" + Model.SMSDataset.BackHEXColor + ";"
, 6109), false)
, Tuple.Create(Tuple.Create("", 6217), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:575px;height:21px;width:12" +
"0px;top:3px;", 6217), true)
);
WriteLiteral(">Dataset</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSDataset\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSDataset.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SMSDataset.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDataset/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSDataset/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSDataset\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.SMSDataset.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:700px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 6895), Tuple.Create("\'", 6967)
, Tuple.Create(Tuple.Create("", 6903), Tuple.Create("IQLabel106352", 6903), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 6916), Tuple.Create<System.Object, System.Int32>(!Model.SMSRecordID.LabelVisible ? " hide " : ""
, 6917), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6968), Tuple.Create("\'", 7181)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 6977), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SMSRecordID.BackHEXColor) ? "" : "color:" + Model.SMSRecordID.BackHEXColor + ";"
, 6977), false)
, Tuple.Create(Tuple.Create("", 7087), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:575px;height:21px;width:12" +
"0px;top:28px;", 7087), true)
);
WriteLiteral(">RecordID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'SMS_SMSRecordID\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SMSRecordID.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SMSRecordID.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/SMS/SaveSMSRecordID/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/SMS/CallbackSMSRecordID/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSMSRecordID\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.SMSRecordID.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:700px;height:21px;width:80px;top:28px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Edit_1.cshtml")]
    public partial class Views_SMS_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMS/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMS", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1129), Tuple.Create("\'", 1151)
, Tuple.Create(Tuple.Create("", 1137), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1137), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1197), Tuple.Create("\'", 1221)
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1205), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMS\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1318), Tuple.Create("\"", 1343)
, Tuple.Create(Tuple.Create("", 1326), Tuple.Create<System.Object, System.Int32>(Model.SMSIdValue
, 1326), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1389), Tuple.Create("\"", 1412)
, Tuple.Create(Tuple.Create("", 1397), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1397), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1454), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1462), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMS/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1771), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1778), Tuple.Create("/SMS/ViewHistory/?RecId=", 1778), true)
, Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1802), false)
, Tuple.Create(Tuple.Create("", 1817), Tuple.Create("&dt=", 1817), true)
, Tuple.Create(Tuple.Create("", 1821), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1821), false)
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2637), Tuple.Create("\"", 2652)
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create("#", 2644), true)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2645), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2868), Tuple.Create("\"", 2880)
, Tuple.Create(Tuple.Create("", 2873), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2873), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Add_1.cshtml")]
    public partial class Views_SMS_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMS/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_List_1.cshtml")]
    public partial class Views_SMS_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMS>>
    {
        public Views_SMS_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 471), Tuple.Create("\"", 537)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("/SMS/ListFromQuery/?Clause=", 478), true)
                                                               , Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 505), false)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("&Ord=", 520), true)
                                                                                   , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 525), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 800), Tuple.Create("\"", 837)
, Tuple.Create(Tuple.Create("", 807), Tuple.Create("/SMS/Load/?RecId=", 807), true)
            , Tuple.Create(Tuple.Create("", 824), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 824), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Edit_2.cshtml")]
    public partial class Views_SMS_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMS/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMS", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1129), Tuple.Create("\'", 1151)
, Tuple.Create(Tuple.Create("", 1137), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1137), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1197), Tuple.Create("\'", 1221)
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1205), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMS\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1318), Tuple.Create("\"", 1343)
, Tuple.Create(Tuple.Create("", 1326), Tuple.Create<System.Object, System.Int32>(Model.SMSIdValue
, 1326), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1389), Tuple.Create("\"", 1412)
, Tuple.Create(Tuple.Create("", 1397), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1397), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1454), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1462), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMS/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1771), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1778), Tuple.Create("/SMS/ViewHistory/?RecId=", 1778), true)
, Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1802), false)
, Tuple.Create(Tuple.Create("", 1817), Tuple.Create("&dt=", 1817), true)
, Tuple.Create(Tuple.Create("", 1821), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1821), false)
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2637), Tuple.Create("\"", 2652)
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create("#", 2644), true)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2645), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2868), Tuple.Create("\"", 2880)
, Tuple.Create(Tuple.Create("", 2873), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2873), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Add_2.cshtml")]
    public partial class Views_SMS_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMS/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_List_2.cshtml")]
    public partial class Views_SMS_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMS>>
    {
        public Views_SMS_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 471), Tuple.Create("\"", 537)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("/SMS/ListFromQuery/?Clause=", 478), true)
                                                               , Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 505), false)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("&Ord=", 520), true)
                                                                                   , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 525), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 800), Tuple.Create("\"", 837)
, Tuple.Create(Tuple.Create("", 807), Tuple.Create("/SMS/Load/?RecId=", 807), true)
            , Tuple.Create(Tuple.Create("", 824), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 824), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Edit_3.cshtml")]
    public partial class Views_SMS_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/SMS/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("SMS", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1129), Tuple.Create("\'", 1151)
, Tuple.Create(Tuple.Create("", 1137), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1137), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1197), Tuple.Create("\'", 1221)
, Tuple.Create(Tuple.Create("", 1205), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1205), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"SMS\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1318), Tuple.Create("\"", 1343)
, Tuple.Create(Tuple.Create("", 1326), Tuple.Create<System.Object, System.Int32>(Model.SMSIdValue
, 1326), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1389), Tuple.Create("\"", 1412)
, Tuple.Create(Tuple.Create("", 1397), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1397), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1454), Tuple.Create("\"", 1477)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1462), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/SMS/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1771), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1778), Tuple.Create("/SMS/ViewHistory/?RecId=", 1778), true)
, Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1802), false)
, Tuple.Create(Tuple.Create("", 1817), Tuple.Create("&dt=", 1817), true)
, Tuple.Create(Tuple.Create("", 1821), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1821), false)
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2637), Tuple.Create("\"", 2652)
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create("#", 2644), true)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2645), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2868), Tuple.Create("\"", 2880)
, Tuple.Create(Tuple.Create("", 2873), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2873), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_Add_3.cshtml")]
    public partial class Views_SMS_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.SMS>
    {
        public Views_SMS_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add SMS";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add SMS\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/SMS/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<SMS>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"SMS\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/SMS_SMS.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/SMS_List_3.cshtml")]
    public partial class Views_SMS_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.SMS>>
    {
        public Views_SMS_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SMS List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"SMS List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add SMS</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/SMS/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 471), Tuple.Create("\"", 537)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("/SMS/ListFromQuery/?Clause=", 478), true)
                                                               , Tuple.Create(Tuple.Create("", 505), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 505), false)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("&Ord=", 520), true)
                                                                                   , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 525), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 800), Tuple.Create("\"", 837)
, Tuple.Create(Tuple.Create("", 807), Tuple.Create("/SMS/Load/?RecId=", 807), true)
            , Tuple.Create(Tuple.Create("", 824), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 824), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
