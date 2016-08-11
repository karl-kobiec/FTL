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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Emails.cshtml")]
    public partial class Views_EMail_Emails_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Emails_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 61), Tuple.Create("\'", 128)
, Tuple.Create(Tuple.Create("", 69), Tuple.Create("IQLabel104611", 69), true)
, Tuple.Create(Tuple.Create(" ", 82), Tuple.Create<System.Object, System.Int32>(!Model.EMName.LabelVisible ? " hide " : ""
, 83), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 129), Tuple.Create("\'", 328)
     , Tuple.Create(Tuple.Create("", 138), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMName.BackHEXColor) ? "" : "color:" + Model.EMName.BackHEXColor + ";"
, 138), false)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:60px" +
";top:3px;", 238), true)
);
WriteLiteral(">E-mail</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Emails_EMName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                     Write(!Model.EMName.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMName/',$(this));\""));
WriteLiteral("   name=\'PopulateEMName\'  style=\'position: absolute; left:70px;height:21px;width:" +
"200px;top:3px;\'>\r\n");
             foreach(var itm in Model.EMName.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 898), Tuple.Create("\'", 919)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 906), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateEMName.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                       Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1049), Tuple.Create("\'", 1116)
, Tuple.Create(Tuple.Create("", 1057), Tuple.Create("IQLabel104612", 1057), true)
, Tuple.Create(Tuple.Create(" ", 1070), Tuple.Create<System.Object, System.Int32>(!Model.EMFrom.LabelVisible ? " hide " : ""
, 1071), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1117), Tuple.Create("\'", 1317)
                     , Tuple.Create(Tuple.Create("", 1126), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMFrom.BackHEXColor) ? "" : "color:" + Model.EMFrom.BackHEXColor + ";"
, 1126), false)
, Tuple.Create(Tuple.Create("", 1226), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:60px" +
";top:28px;", 1226), true)
);
WriteLiteral(">From</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Emails_EMFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.EMFrom.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMFrom/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMFrom\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.EMFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:70px;height:21px;width:160px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1878), Tuple.Create("\'", 1947)
, Tuple.Create(Tuple.Create("", 1886), Tuple.Create("IQLabel104613", 1886), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 1899), Tuple.Create<System.Object, System.Int32>(!Model.EMStatus.LabelVisible ? " hide " : ""
, 1900), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1948), Tuple.Create("\'", 2153)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1957), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMStatus.BackHEXColor) ? "" : "color:" + Model.EMStatus.BackHEXColor + ";"
, 1957), false)
, Tuple.Create(Tuple.Create("", 2061), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:70" +
"px;top:3px;", 2061), true)
);
WriteLiteral(">Status</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Emails_EMStatus\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMStatus.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.EMStatus.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMStatus/',$(this));\""));
WriteLiteral("   name=\'PopulateEMStatus\'  style=\'position: absolute; left:350px;height:21px;wid" +
"th:160px;top:3px;\'>\r\n");
             foreach(var itm in Model.EMStatus.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2738), Tuple.Create("\'", 2759)
, Tuple.Create(Tuple.Create("", 2746), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2746), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateEMStatus.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2891), Tuple.Create("\'", 2962)
, Tuple.Create(Tuple.Create("", 2899), Tuple.Create("IQLabel104614", 2899), true)
, Tuple.Create(Tuple.Create(" ", 2912), Tuple.Create<System.Object, System.Int32>(!Model.EMDateSent.LabelVisible ? " hide " : ""
, 2913), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2963), Tuple.Create("\'", 3173)
                         , Tuple.Create(Tuple.Create("", 2972), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMDateSent.BackHEXColor) ? "" : "color:" + Model.EMDateSent.BackHEXColor + ";"
, 2972), false)
, Tuple.Create(Tuple.Create("", 3080), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:70" +
"px;top:28px;", 3080), true)
);
WriteLiteral(">Date Sent</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'110\'");
WriteLiteral(" style=\'position: absolute; left:350px;height:21px;width:110px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Emails_EMDateSent\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY HH:mm\'");
WriteAttribute("class", Tuple.Create(" class=\'", 3420), Tuple.Create("\'", 3496)
, Tuple.Create(Tuple.Create("", 3428), Tuple.Create("form-control", 3428), true)
, Tuple.Create(Tuple.Create(" ", 3440), Tuple.Create("dateBox", 3441), true)
           , Tuple.Create(Tuple.Create("   ", 3448), Tuple.Create<System.Object, System.Int32>(!Model.EMDateSent.Visible ? " hide " : ""
, 3451), false)
, Tuple.Create(Tuple.Create(" ", 3495), Tuple.Create("", 3495), true)
);
WriteLiteral("  ");
                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMDateSent/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMDateSent/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateEMDateSent\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.EMDateSent.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateEMDateSent]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4065), Tuple.Create("\'", 4130)
, Tuple.Create(Tuple.Create("", 4073), Tuple.Create("IQLabel104615", 4073), true)
, Tuple.Create(Tuple.Create(" ", 4086), Tuple.Create<System.Object, System.Int32>(!Model.EMTo.LabelVisible ? " hide " : ""
, 4087), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4131), Tuple.Create("\'", 4327)
                          , Tuple.Create(Tuple.Create("", 4140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTo.BackHEXColor) ? "" : "color:" + Model.EMTo.BackHEXColor + ";"
, 4140), false)
, Tuple.Create(Tuple.Create("", 4236), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:60px" +
";top:53px;", 4236), true)
);
WriteLiteral(">To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:70px;height:46px;width:200px;top:53px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'To\'");
WriteLiteral(" data-ScreenInfo=\'Emails_EMTo\'");
WriteLiteral(" ");
                                                                                                                                                                                            Write(Model.RecordLocked || !Model.EMTo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMTo/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.EMTo.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateEMTo\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.PopulateEMTo);
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
WriteLiteral(" data-target=\"*[name=PopulateEMTo]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5442), Tuple.Create("\'", 5507)
, Tuple.Create(Tuple.Create("", 5450), Tuple.Create("IQLabel104616", 5450), true)
, Tuple.Create(Tuple.Create(" ", 5463), Tuple.Create<System.Object, System.Int32>(!Model.EMCC.LabelVisible ? " hide " : ""
, 5464), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5508), Tuple.Create("\'", 5706)
                          , Tuple.Create(Tuple.Create("", 5517), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMCC.BackHEXColor) ? "" : "color:" + Model.EMCC.BackHEXColor + ";"
, 5517), false)
, Tuple.Create(Tuple.Create("", 5613), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:30" +
"px;top:53px;", 5613), true)
);
WriteLiteral(">CC</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:310px;height:46px;width:200px;top:53px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'CC\'");
WriteLiteral(" data-ScreenInfo=\'Emails_EMCC\'");
WriteLiteral(" ");
                                                                                                                                                                                            Write(Model.RecordLocked || !Model.EMCC.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMCC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMCC/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.EMCC.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateEMCC\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.PopulateEMCC);
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
WriteLiteral(" data-target=\"*[name=PopulateEMCC]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6822), Tuple.Create("\'", 6891)
, Tuple.Create(Tuple.Create("", 6830), Tuple.Create("IQLabel104617", 6830), true)
, Tuple.Create(Tuple.Create(" ", 6843), Tuple.Create<System.Object, System.Int32>(!Model.EMAttach.LabelVisible ? " hide " : ""
, 6844), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6892), Tuple.Create("\'", 7098)
                              , Tuple.Create(Tuple.Create("", 6901), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMAttach.BackHEXColor) ? "" : "color:" + Model.EMAttach.BackHEXColor + ";"
, 6901), false)
, Tuple.Create(Tuple.Create("", 7005), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:525px;height:21px;width:90" +
"px;top:53px;", 7005), true)
);
WriteLiteral(">Attachments</label>\r\n\t\t<div");
WriteLiteral(" id=\'FilesFor-PopulateEMAttach\'");
WriteLiteral(" data-target=\'*[PopulateEMAttach]\'");
WriteLiteral(" style=\'border:1px solid #ccc;border-radius:5px;padding:1px;font-size:11px;positi" +
"on:absolute;left:620px;height:46px;width:200px;top:53px;\'");
WriteLiteral(">\r\n\t\t\r\n");
              Html.RenderPartial("~/Views/DFPartial_EMAttach.cshtml", Model); 
WriteLiteral("\r\n\t\t</div>\t\t<textarea");
WriteLiteral(" data-Label=\'Attachments\'");
WriteLiteral(" data-ScreenInfo=\'Emails_EMAttach\'");
WriteLiteral(" ");
                                                                                     Write(Model.RecordLocked || !Model.EMAttach.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMAttach/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMAttach/',$(this));\""));
WriteLiteral("  class=\'form-control  hide  ");
                                                                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.EMAttach.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateEMAttach\' style=\'position: absolute; left:620px;height:46px;widt" +
"h:200px;top:53px;\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.PopulateEMAttach);
WriteLiteral("</textarea><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7991), Tuple.Create("\'", 8061)
, Tuple.Create(Tuple.Create("", 7999), Tuple.Create("IQLabel104618", 7999), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 8012), Tuple.Create<System.Object, System.Int32>(!Model.EMSubject.LabelVisible ? " hide " : ""
, 8013), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8062), Tuple.Create("\'", 8269)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 8071), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMSubject.BackHEXColor) ? "" : "color:" + Model.EMSubject.BackHEXColor + ";"
, 8071), false)
, Tuple.Create(Tuple.Create("", 8177), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:60px" +
";top:103px;", 8177), true)
);
WriteLiteral(">Subject</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'750\'");
WriteLiteral(" style=\'position: absolute; left:70px;height:21px;width:750px;top:103px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Subject\'");
WriteLiteral(" data-ScreenInfo=\'Emails_EMSubject\'");
WriteLiteral(" ");
                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.EMSubject.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMSubject/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMSubject/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.EMSubject.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateEMSubject\' style=\'height:21px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.PopulateEMSubject);
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
WriteLiteral(" data-target=\"*[name=PopulateEMSubject]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9435), Tuple.Create("\'", 9502)
, Tuple.Create(Tuple.Create("", 9443), Tuple.Create("IQLabel104619", 9443), true)
, Tuple.Create(Tuple.Create(" ", 9456), Tuple.Create<System.Object, System.Int32>(!Model.EMBody.LabelVisible ? " hide " : ""
, 9457), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9503), Tuple.Create("\'", 9704)
                            , Tuple.Create(Tuple.Create("", 9512), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMBody.BackHEXColor) ? "" : "color:" + Model.EMBody.BackHEXColor + ";"
, 9512), false)
, Tuple.Create(Tuple.Create("", 9612), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:60px" +
";top:128px;", 9612), true)
);
WriteLiteral(">Body</label>\r\n\t\t\t\t<div");
WriteLiteral(" id=\"RichEditor-PopulateEMBody\"");
WriteLiteral(" ");
                                                Write(Model.RecordLocked ? "data-disabled='true'" :"");
WriteLiteral("  data-target=\"textarea[name=PopulateEMBody]\" class=\'RichEditor\' style=\'position:" +
" absolute; left:70px;height:371px;width:750px;top:128px;\'>");
                                                                                                                                                                                                                                            Write(Html.Raw(Model.PopulateEMBody));
WriteLiteral("</div>\r\n\t\t<textarea");
WriteLiteral("  data-ScreenInfo=\'Emails_EMBody\'");
                                              Write(Model.RecordLocked || !Model.EMBody.Enabled ? "disabled=disabled" : "");
WriteLiteral(" ");
                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMBody/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMBody/',$(this));\""));
WriteLiteral("  class=\' ");
                                                                                                                                                                                                                                                                                                                                                     Write(!Model.EMBody.Visible ? " hide " : "");
WriteLiteral(" form-control \' name=\'PopulateEMBody\' style=\'display:none\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Html.Raw(Model.PopulateEMBody));
WriteLiteral("</textarea>\r\n\t\t\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 10482), Tuple.Create("\'", 10547)
, Tuple.Create(Tuple.Create("", 10490), Tuple.Create("IQLabel104631", 10490), true)
, Tuple.Create(Tuple.Create(" ", 10503), Tuple.Create<System.Object, System.Int32>(!Model.EMId.LabelVisible ? " hide " : ""
, 10504), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10548), Tuple.Create("\'", 10745)
         , Tuple.Create(Tuple.Create("", 10557), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMId.BackHEXColor) ? "" : "color:" + Model.EMId.BackHEXColor + ";"
, 10557), false)
, Tuple.Create(Tuple.Create("", 10653), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:555px;height:21px;width:60" +
"px;top:3px;", 10653), true)
);
WriteLiteral(">Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Emails_EMId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 10819), Tuple.Create("\'", 10880)
, Tuple.Create(Tuple.Create("", 10827), Tuple.Create("form-control", 10827), true)
, Tuple.Create(Tuple.Create("   ", 10839), Tuple.Create<System.Object, System.Int32>(!Model.EMId.Visible ? " hide " : ""
, 10842), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMId\' value=\'");
                                                                                                                                                                                                                                                                                                                                          Write(Model.EMId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:620px;height:21px;width:60px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 11235), Tuple.Create("\'", 11307)
, Tuple.Create(Tuple.Create("", 11243), Tuple.Create("IQLabel104633", 11243), true)
                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 11256), Tuple.Create<System.Object, System.Int32>(!Model.EMToRecords.LabelVisible ? " hide " : ""
, 11257), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11308), Tuple.Create("\'", 11519)
                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 11317), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMToRecords.BackHEXColor) ? "" : "color:" + Model.EMToRecords.BackHEXColor + ";"
, 11317), false)
, Tuple.Create(Tuple.Create("", 11427), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:830px;height:21px;width:120" +
"px;top:3px;", 11427), true)
);
WriteLiteral(">To (Records)</label>\r\n\t\t<select");
WriteLiteral(" multiple=multiple");
WriteLiteral("\r\n\t data-ScreenInfo=\'Emails_EMToRecords\'");
                                     Write(Model.RecordLocked || !Model.EMToRecords.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMToRecords/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMToRecords/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                           Write(!Model.EMToRecords.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/EMail/AutoCompleteEMToRecords/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateEMToRecords\'  style=\'position: absolute; left:830px;height:71px;" +
"width:180px;top:28px;overflow-y:auto;\'>\r\n");
                 if(Model.PopulateEMToRecords.ToString() != "" && Model.PopulateEMToRecords.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.EMToRecords.HTMLValue));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 12424), Tuple.Create("\'", 12497)
, Tuple.Create(Tuple.Create("", 12432), Tuple.Create("IQLabel104636", 12432), true)
, Tuple.Create(Tuple.Create(" ", 12445), Tuple.Create<System.Object, System.Int32>(!Model.EMBCCRecords.LabelVisible ? " hide " : ""
, 12446), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12498), Tuple.Create("\'", 12713)
                          , Tuple.Create(Tuple.Create("", 12507), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMBCCRecords.BackHEXColor) ? "" : "color:" + Model.EMBCCRecords.BackHEXColor + ";"
, 12507), false)
, Tuple.Create(Tuple.Create("", 12619), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:830px;height:21px;width:120" +
"px;top:103px;", 12619), true)
);
WriteLiteral(">BCC (Records)</label>\r\n\t\t<select");
WriteLiteral(" multiple=multiple");
WriteLiteral("\r\n\t data-ScreenInfo=\'Emails_EMBCCRecords\'");
                                      Write(Model.RecordLocked || !Model.EMBCCRecords.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMBCCRecords/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMBCCRecords/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                               Write(!Model.EMBCCRecords.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/EMail/AutoCompleteEMBCCRecords/");
                                                 Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateEMBCCRecords\'  style=\'position: absolute; left:830px;height:71px" +
";width:180px;top:128px;overflow-y:auto;\'>\r\n");
                 if(Model.PopulateEMBCCRecords.ToString() != "" && Model.PopulateEMBCCRecords.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.EMBCCRecords.HTMLValue));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 13630), Tuple.Create("\'", 13702)
, Tuple.Create(Tuple.Create("", 13638), Tuple.Create("IQLabel104639", 13638), true)
, Tuple.Create(Tuple.Create(" ", 13651), Tuple.Create<System.Object, System.Int32>(!Model.EMCCRecords.LabelVisible ? " hide " : ""
, 13652), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13703), Tuple.Create("\'", 13916)
                         , Tuple.Create(Tuple.Create("", 13712), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMCCRecords.BackHEXColor) ? "" : "color:" + Model.EMCCRecords.BackHEXColor + ";"
, 13712), false)
, Tuple.Create(Tuple.Create("", 13822), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:830px;height:21px;width:120" +
"px;top:203px;", 13822), true)
);
WriteLiteral(">CC (Records)</label>\r\n\t\t<select");
WriteLiteral(" multiple=multiple");
WriteLiteral("\r\n\t data-ScreenInfo=\'Emails_EMCCRecords\'");
                                     Write(Model.RecordLocked || !Model.EMCCRecords.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EMail/SaveEMCCRecords/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EMail/CallbackEMCCRecords/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                           Write(!Model.EMCCRecords.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/EMail/AutoCompleteEMCCRecords/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateEMCCRecords\'  style=\'position: absolute; left:830px;height:71px;" +
"width:180px;top:228px;overflow-y:auto;\'>\r\n");
                 if(Model.PopulateEMCCRecords.ToString() != "" && Model.PopulateEMCCRecords.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.EMCCRecords.HTMLValue));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Edit_1.cshtml")]
    public partial class Views_EMail_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EMail/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EMail", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EMail\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.EMIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1398), Tuple.Create("\"", 1421)
, Tuple.Create(Tuple.Create("", 1406), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1406), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1463), Tuple.Create("\"", 1486)
, Tuple.Create(Tuple.Create("", 1471), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1471), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EMail/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1782), Tuple.Create("\"", 1881)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("/EMail/ViewHistory/?RecId=", 1789), true)
, Tuple.Create(Tuple.Create("", 1815), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1815), false)
, Tuple.Create(Tuple.Create("", 1830), Tuple.Create("&dt=", 1830), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1834), false)
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
WriteLiteral(" id=\"Emails\"");
WriteLiteral(" style=\'position:relative;height:529px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EMail_Emails.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2658), Tuple.Create("\"", 2673)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create("#", 2665), true)
, Tuple.Create(Tuple.Create("", 2666), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2666), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2889), Tuple.Create("\"", 2901)
, Tuple.Create(Tuple.Create("", 2894), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2894), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Add_1.cshtml")]
    public partial class Views_EMail_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add E-mails";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add E-mails\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EMail/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Emails\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EMail_Emails.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_List_1.cshtml")]
    public partial class Views_EMail_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EMail>>
    {
        public Views_EMail_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "E-mails List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"E-mails List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add E-mails</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 557)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/EMail/ListFromQuery/?Clause=", 496), true)
                                                                 , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 525), false)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create("&Ord=", 540), true)
                                                                                     , Tuple.Create(Tuple.Create("", 545), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 545), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>From</th><th>Subject</th><th>Date Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 867), Tuple.Create("\"", 906)
, Tuple.Create(Tuple.Create("", 874), Tuple.Create("/EMail/Load/?RecId=", 874), true)
              , Tuple.Create(Tuple.Create("", 893), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 893), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1155), Tuple.Create("\"", 1238)
, Tuple.Create(Tuple.Create("", 1166), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMFrom/?RecId=", 1166), true)
                                                                 , Tuple.Create(Tuple.Create("", 1214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1214), false)
, Tuple.Create(Tuple.Create("", 1227), Tuple.Create("\',$(this));", 1227), true)
);
WriteLiteral(" data-bound-name=\'EMFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1295), Tuple.Create("\'", 1334)
                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMFrom.HTMLValue)
, 1303), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:50%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1522), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMSubject/?RecId=", 1533), true)
                                                                    , Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1584), false)
, Tuple.Create(Tuple.Create("", 1597), Tuple.Create("\',$(this));", 1597), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.EMSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EMDateSent.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DFPartial_EMAttach.cshtml")]
    public partial class Views_DFPartial_EMAttach_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_DFPartial_EMAttach_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral(" \r\n");
     if(Model.EMAttachValue.Split(';').Where(f=> !string.IsNullOrEmpty(f)).Count() < 0) {
             foreach(var f in Model.EMAttachValue.Split(';').Where(f=> !string.IsNullOrEmpty(f))) {
				var uid = Guid.NewGuid().ToString();
WriteLiteral("\t\t\t\t");
WriteLiteral("<div");
WriteAttribute("id", Tuple.Create(" id=\'", 300), Tuple.Create("\'", 309)
, Tuple.Create(Tuple.Create("", 305), Tuple.Create<System.Object, System.Int32>(uid
, 305), false)
);
WriteLiteral(" class=\'FileHolder\'");
WriteLiteral(" data-mode=\'#ViewFilesFor-EMAttachValue\'");
WriteLiteral(" data-target=\'*[name=EMAttachValue]\'");
WriteLiteral(" data-file=\'");
                                                                                                                                          Write(f);
WriteLiteral("\'");
WriteLiteral("><a");
WriteLiteral(" target=\"_blank\"");
WriteLiteral(" class=\"notpjax\"");
WriteAttribute("href", Tuple.Create(" href=\"", 455), Tuple.Create("\"", 489)
                                                                                                             , Tuple.Create(Tuple.Create("", 462), Tuple.Create<System.Object, System.Int32>(IQApp.Files.GetFileUrl(@f)
, 462), false)
);
WriteLiteral(">");
                                                                                                                                                                                                                    Write(f);
WriteLiteral("</a>&nbsp;<a");
WriteLiteral(" href=\"#\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 514), Tuple.Create("\'", 555)
, Tuple.Create(Tuple.Create("", 524), Tuple.Create("javascript:IQRemoveFile(\"", 524), true)
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(uid
, 549), false)
, Tuple.Create(Tuple.Create("", 553), Tuple.Create("\")", 553), true)
);
WriteLiteral(" ><img");
WriteLiteral(" src=\"/IQ6/trash.png\"");
WriteLiteral(" style=\'max-height:21px;margin-left:5px;\'");
WriteLiteral(" /></a></div><br />");
WriteLiteral("\r\n");
			}
		}else {
WriteLiteral("\t\t\t");
WriteLiteral("<b>Files:</b> ");
                           Write(Model.EMAttachValue.Split(';').Where(f=> !string.IsNullOrEmpty(f)).Count());
WriteLiteral("<br />\r\n\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" data-toggle=\"modal\"");
WriteLiteral(" data-target=\"#ViewFilesFor-EMAttachValue\"");
WriteAttribute("class", Tuple.Create(" class=\'", 861), Tuple.Create("\'", 985)
, Tuple.Create(Tuple.Create("", 869), Tuple.Create("btn", 869), true)
, Tuple.Create(Tuple.Create(" ", 872), Tuple.Create("btn-info", 873), true)
, Tuple.Create(Tuple.Create(" ", 881), Tuple.Create("btn-xs", 882), true)
                                            , Tuple.Create(Tuple.Create(" ", 888), Tuple.Create<System.Object, System.Int32>(Model.EMAttachValue.Split(';').Where(f=> !string.IsNullOrEmpty(f)).Count() == 0 ? "hide" : ""
, 889), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/files.png\"");
WriteLiteral(" style=\'max-height:15px;float:left;\'");
WriteLiteral(" />View Files</button>");
WriteLiteral("\r\n");
WriteLiteral("\t\t\t<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\'ViewFilesFor-EMAttachValue\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n\t\t\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"close\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral("><span");
WriteLiteral(" aria-hidden=\"true\"");
WriteLiteral(">&times;</span></button>\r\n\t\t\t\t\t<h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(">Attachments</h4>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n");
                     foreach(var f in Model.EMAttachValue.Split(';').Where(f=> !string.IsNullOrEmpty(f))) {
					var uid = Guid.NewGuid().ToString();
WriteLiteral("\t\t\t\t\t\t");
WriteLiteral("<div");
WriteAttribute("id", Tuple.Create(" id=\'", 1619), Tuple.Create("\'", 1628)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(uid
, 1624), false)
);
WriteLiteral(" class=\'FileHolder\'");
WriteLiteral(" data-file=\'");
                                                                      Write(f);
WriteLiteral("\'");
WriteLiteral(" data-mode=\'#ViewFilesFor-EMAttachValue\'");
WriteLiteral(" data-target=\'*[name=EMAttachValue]\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1742), Tuple.Create("\"", 1776)
                                                                                    , Tuple.Create(Tuple.Create("", 1749), Tuple.Create<System.Object, System.Int32>(IQApp.Files.GetFileUrl(@f)
, 1749), false)
);
WriteLiteral(" class=\"notpjax\"");
WriteLiteral(" target=\"_blank\"");
WriteLiteral(">");
                                                                                                                                                                                                                            Write(System.IO.Path.GetFileName(f));
WriteLiteral("</a>&nbsp;<a");
WriteLiteral("  href=\"#\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 1862), Tuple.Create("\'", 1903)
, Tuple.Create(Tuple.Create("", 1872), Tuple.Create("javascript:IQRemoveFile(\"", 1872), true)
                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1897), Tuple.Create<System.Object, System.Int32>(uid
, 1897), false)
, Tuple.Create(Tuple.Create("", 1901), Tuple.Create("\")", 1901), true)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/trash.png\"");
WriteLiteral(" style=\'max-height:21px;margin-left:5px;\'");
WriteLiteral(" /></a></div><br />");
WriteLiteral("\r\n");
					}
WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-footer\"");
WriteLiteral(">\r\n\t\t\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(">Close</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div><!-- /.modal-content -->\r\n\t\t\t\t</div><!-- " +
"/.modal-dialog -->\r\n\t\t\t</div>");
WriteLiteral("<!-- /.modal -->\r\n");
		}
WriteLiteral("\t\t");
         if(!Model.RecordLocked) {
WriteLiteral("\t\t\t");
WriteLiteral("<button");
WriteLiteral(" onclick=\'ShowFilePicker(\"*[name=EMAttachValue]\", true);\'");
WriteLiteral(" type=\'button\'");
WriteLiteral(" class=\'btn btn-primary btn-xs\'");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/file.png\"");
WriteLiteral(" style=\'max-height:15px;float:left;\'");
WriteLiteral(" />Add File</a>");
WriteLiteral("</text>\r\n");
		}
WriteLiteral("\t\r\n\r\n\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Edit_2.cshtml")]
    public partial class Views_EMail_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EMail/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EMail", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EMail\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.EMIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1398), Tuple.Create("\"", 1421)
, Tuple.Create(Tuple.Create("", 1406), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1406), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1463), Tuple.Create("\"", 1486)
, Tuple.Create(Tuple.Create("", 1471), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1471), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EMail/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1782), Tuple.Create("\"", 1881)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("/EMail/ViewHistory/?RecId=", 1789), true)
, Tuple.Create(Tuple.Create("", 1815), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1815), false)
, Tuple.Create(Tuple.Create("", 1830), Tuple.Create("&dt=", 1830), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1834), false)
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
WriteLiteral(" id=\"Emails\"");
WriteLiteral(" style=\'position:relative;height:529px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EMail_Emails.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2658), Tuple.Create("\"", 2673)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create("#", 2665), true)
, Tuple.Create(Tuple.Create("", 2666), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2666), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2889), Tuple.Create("\"", 2901)
, Tuple.Create(Tuple.Create("", 2894), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2894), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Add_2.cshtml")]
    public partial class Views_EMail_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add E-mails";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add E-mails\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EMail/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Emails\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EMail_Emails.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_List_2.cshtml")]
    public partial class Views_EMail_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EMail>>
    {
        public Views_EMail_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "E-mails List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"E-mails List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add E-mails</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 557)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/EMail/ListFromQuery/?Clause=", 496), true)
                                                                 , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 525), false)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create("&Ord=", 540), true)
                                                                                     , Tuple.Create(Tuple.Create("", 545), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 545), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>From</th><th>Subject</th><th>Date Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 867), Tuple.Create("\"", 906)
, Tuple.Create(Tuple.Create("", 874), Tuple.Create("/EMail/Load/?RecId=", 874), true)
              , Tuple.Create(Tuple.Create("", 893), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 893), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1155), Tuple.Create("\"", 1238)
, Tuple.Create(Tuple.Create("", 1166), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMFrom/?RecId=", 1166), true)
                                                                 , Tuple.Create(Tuple.Create("", 1214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1214), false)
, Tuple.Create(Tuple.Create("", 1227), Tuple.Create("\',$(this));", 1227), true)
);
WriteLiteral(" data-bound-name=\'EMFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1295), Tuple.Create("\'", 1334)
                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMFrom.HTMLValue)
, 1303), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:50%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1522), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMSubject/?RecId=", 1533), true)
                                                                    , Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1584), false)
, Tuple.Create(Tuple.Create("", 1597), Tuple.Create("\',$(this));", 1597), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.EMSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EMDateSent.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Edit_3.cshtml")]
    public partial class Views_EMail_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EMail/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EMail", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EMail\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.EMIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1398), Tuple.Create("\"", 1421)
, Tuple.Create(Tuple.Create("", 1406), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1406), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1463), Tuple.Create("\"", 1486)
, Tuple.Create(Tuple.Create("", 1471), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1471), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EMail/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1782), Tuple.Create("\"", 1881)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("/EMail/ViewHistory/?RecId=", 1789), true)
, Tuple.Create(Tuple.Create("", 1815), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1815), false)
, Tuple.Create(Tuple.Create("", 1830), Tuple.Create("&dt=", 1830), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1834), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2473), Tuple.Create("\"", 2488)
, Tuple.Create(Tuple.Create("", 2480), Tuple.Create("#", 2480), true)
, Tuple.Create(Tuple.Create("", 2481), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2481), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2704), Tuple.Create("\"", 2716)
, Tuple.Create(Tuple.Create("", 2709), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2709), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_Add_3.cshtml")]
    public partial class Views_EMail_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EMail>
    {
        public Views_EMail_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add E-mails";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add E-mails\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EMail/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EMail>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EMail_List_3.cshtml")]
    public partial class Views_EMail_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EMail>>
    {
        public Views_EMail_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "E-mails List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"E-mails List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add E-mails</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EMail/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 557)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/EMail/ListFromQuery/?Clause=", 496), true)
                                                                 , Tuple.Create(Tuple.Create("", 525), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 525), false)
, Tuple.Create(Tuple.Create("", 540), Tuple.Create("&Ord=", 540), true)
                                                                                     , Tuple.Create(Tuple.Create("", 545), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 545), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>From</th><th>Subject</th><th>Date Sent</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 867), Tuple.Create("\"", 906)
, Tuple.Create(Tuple.Create("", 874), Tuple.Create("/EMail/Load/?RecId=", 874), true)
              , Tuple.Create(Tuple.Create("", 893), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 893), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1155), Tuple.Create("\"", 1238)
, Tuple.Create(Tuple.Create("", 1166), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMFrom/?RecId=", 1166), true)
                                                                 , Tuple.Create(Tuple.Create("", 1214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1214), false)
, Tuple.Create(Tuple.Create("", 1227), Tuple.Create("\',$(this));", 1227), true)
);
WriteLiteral(" data-bound-name=\'EMFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1295), Tuple.Create("\'", 1334)
                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1303), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMFrom.HTMLValue)
, 1303), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:50%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1522), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create("javascript:IQAutoSave(\'/EMail/SaveEMSubject/?RecId=", 1533), true)
                                                                    , Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1584), false)
, Tuple.Create(Tuple.Create("", 1597), Tuple.Create("\',$(this));", 1597), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.EMSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EMDateSent.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
