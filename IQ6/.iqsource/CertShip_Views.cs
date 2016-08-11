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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_CertificatesofShipment.cshtml")]
    public partial class Views_CertShip_CertificatesofShipment_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_CertificatesofShipment_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 129)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel101711", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.CSId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 130), Tuple.Create("\'", 326)
   , Tuple.Create(Tuple.Create("", 139), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSId.BackHEXColor) ? "" : "color:" + Model.CSId.BackHEXColor + ";"
, 139), false)
, Tuple.Create(Tuple.Create("", 235), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 235), true)
);
WriteLiteral(">Certificate Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 432), Tuple.Create("\'", 493)
, Tuple.Create(Tuple.Create("", 440), Tuple.Create("form-control", 440), true)
, Tuple.Create(Tuple.Create("   ", 452), Tuple.Create<System.Object, System.Int32>(!Model.CSId.Visible ? " hide " : ""
, 455), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                Write(Model.CSId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 854), Tuple.Create("\'", 922)
, Tuple.Create(Tuple.Create("", 862), Tuple.Create("IQLabel101712", 862), true)
                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 875), Tuple.Create<System.Object, System.Int32>(!Model.CSJobNo.LabelVisible ? " hide " : ""
, 876), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 923), Tuple.Create("\'", 1126)
                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 932), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSJobNo.BackHEXColor) ? "" : "color:" + Model.CSJobNo.BackHEXColor + ";"
, 932), false)
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1034), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:140px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CertificatesofShipment_CSJobNo\'");
                                                 Write(Model.RecordLocked || !Model.CSJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSJobNo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                        Write(!Model.CSJobNo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CertShip/AutoCompleteCSJobNo/");
                                               Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCSJobNo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCSJobNo.ToString() != "" && Model.PopulateCSJobNo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CSJobNo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCSJobNo]\"");
WriteLiteral(" data-url=\"/Job/Load/?JobId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Job/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Jobs</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2792), Tuple.Create("\'", 2864)
, Tuple.Create(Tuple.Create("", 2800), Tuple.Create("IQLabel101713", 2800), true)
, Tuple.Create(Tuple.Create(" ", 2813), Tuple.Create<System.Object, System.Int32>(!Model.CSJobLetter.LabelVisible ? " hide " : ""
, 2814), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2865), Tuple.Create("\'", 3076)
                             , Tuple.Create(Tuple.Create("", 2874), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSJobLetter.BackHEXColor) ? "" : "color:" + Model.CSJobLetter.BackHEXColor + ";"
, 2874), false)
, Tuple.Create(Tuple.Create("", 2984), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2984), true)
);
WriteLiteral(">Job Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSJobLetter\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSJobLetter.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.CSJobLetter.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSJobLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSJobLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSJobLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.CSJobLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3700), Tuple.Create("\'", 3768)
, Tuple.Create(Tuple.Create("", 3708), Tuple.Create("IQLabel101714", 3708), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 3721), Tuple.Create<System.Object, System.Int32>(!Model.CSOrder.LabelVisible ? " hide " : ""
, 3722), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3769), Tuple.Create("\'", 3972)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3778), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSOrder.BackHEXColor) ? "" : "color:" + Model.CSOrder.BackHEXColor + ";"
, 3778), false)
, Tuple.Create(Tuple.Create("", 3880), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3880), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:140px;top:78px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CertificatesofShipment_CSOrder\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSOrder/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                               Write(!Model.CSOrder.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CertShip/AutoCompleteCSOrder/");
                                               Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCSOrder\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCSOrder.ToString() != "" && Model.PopulateCSOrder.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CSOrder.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCSOrder]\"");
WriteLiteral(" data-url=\"/Orders/Load/?OrdId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Orders/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Orders</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5591), Tuple.Create("\'", 5661)
, Tuple.Create(Tuple.Create("", 5599), Tuple.Create("IQLabel101715", 5599), true)
, Tuple.Create(Tuple.Create(" ", 5612), Tuple.Create<System.Object, System.Int32>(!Model.CSVehicle.LabelVisible ? " hide " : ""
, 5613), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5662), Tuple.Create("\'", 5870)
                           , Tuple.Create(Tuple.Create("", 5671), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSVehicle.BackHEXColor) ? "" : "color:" + Model.CSVehicle.BackHEXColor + ";"
, 5671), false)
, Tuple.Create(Tuple.Create("", 5777), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 5777), true)
);
WriteLiteral(">Vehicle</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSVehicle\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSVehicle.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CSVehicle.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSVehicle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSVehicle/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSVehicle\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CSVehicle.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6479), Tuple.Create("\'", 6546)
, Tuple.Create(Tuple.Create("", 6487), Tuple.Create("IQLabel101716", 6487), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 6500), Tuple.Create<System.Object, System.Int32>(!Model.CSShip.LabelVisible ? " hide " : ""
, 6501), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6547), Tuple.Create("\'", 6749)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 6556), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSShip.BackHEXColor) ? "" : "color:" + Model.CSShip.BackHEXColor + ";"
, 6556), false)
, Tuple.Create(Tuple.Create("", 6656), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 6656), true)
);
WriteLiteral(">Ship</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSShip\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSShip.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CSShip.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSShip/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSShip/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSShip\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.CSShip.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7334), Tuple.Create("\'", 7401)
, Tuple.Create(Tuple.Create("", 7342), Tuple.Create("IQLabel101717", 7342), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 7355), Tuple.Create<System.Object, System.Int32>(!Model.CSDate.LabelVisible ? " hide " : ""
, 7356), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7402), Tuple.Create("\'", 7604)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 7411), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSDate.BackHEXColor) ? "" : "color:" + Model.CSDate.BackHEXColor + ";"
, 7411), false)
, Tuple.Create(Tuple.Create("", 7511), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 7511), true)
);
WriteLiteral(">Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:153px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                           Write(!Model.CSDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateCSDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.CSDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateCSDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 8534), Tuple.Create("\'", 8601)
, Tuple.Create(Tuple.Create("", 8542), Tuple.Create("IQLabel101718", 8542), true)
, Tuple.Create(Tuple.Create(" ", 8555), Tuple.Create<System.Object, System.Int32>(!Model.CSTime.LabelVisible ? " hide " : ""
, 8556), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8602), Tuple.Create("\'", 8804)
                            , Tuple.Create(Tuple.Create("", 8611), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSTime.BackHEXColor) ? "" : "color:" + Model.CSTime.BackHEXColor + ";"
, 8611), false)
, Tuple.Create(Tuple.Create("", 8711), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 8711), true)
);
WriteLiteral(">Time</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSTime\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSTime.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CSTime.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSTime/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSTime/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSTime\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.CSTime.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 9388), Tuple.Create("\'", 9456)
, Tuple.Create(Tuple.Create("", 9396), Tuple.Create("IQLabel101719", 9396), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 9409), Tuple.Create<System.Object, System.Int32>(!Model.CSRoute.LabelVisible ? " hide " : ""
, 9410), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9457), Tuple.Create("\'", 9661)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 9466), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSRoute.BackHEXColor) ? "" : "color:" + Model.CSRoute.BackHEXColor + ";"
, 9466), false)
, Tuple.Create(Tuple.Create("", 9568), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 9568), true)
);
WriteLiteral(">Route</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSRoute\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSRoute.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.CSRoute.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSRoute/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSRoute/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSRoute\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.CSRoute.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:220px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 10254), Tuple.Create("\'", 10321)
, Tuple.Create(Tuple.Create("", 10262), Tuple.Create("IQLabel101731", 10262), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 10275), Tuple.Create<System.Object, System.Int32>(!Model.CSCust.LabelVisible ? " hide " : ""
, 10276), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10322), Tuple.Create("\'", 10524)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 10331), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSCust.BackHEXColor) ? "" : "color:" + Model.CSCust.BackHEXColor + ";"
, 10331), false)
, Tuple.Create(Tuple.Create("", 10431), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 10431), true)
);
WriteLiteral(">Client</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CertificatesofShipment_CSCust\'");
                                                Write(Model.RecordLocked || !Model.CSCust.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSCust/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.CSCust.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CertShip/AutoCompleteCSCust/");
                                              Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCSCust\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCSCust.ToString() != "" && Model.PopulateCSCust.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CSCust.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCSCust]\"");
WriteLiteral(" data-url=\"/Customer/Load/?CustId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Customer/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Customers</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 12190), Tuple.Create("\'", 12261)
, Tuple.Create(Tuple.Create("", 12198), Tuple.Create("IQLabel101732", 12198), true)
, Tuple.Create(Tuple.Create(" ", 12211), Tuple.Create<System.Object, System.Int32>(!Model.CSDelPoint.LabelVisible ? " hide " : ""
, 12212), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12262), Tuple.Create("\'", 12473)
                           , Tuple.Create(Tuple.Create("", 12271), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSDelPoint.BackHEXColor) ? "" : "color:" + Model.CSDelPoint.BackHEXColor + ";"
, 12271), false)
, Tuple.Create(Tuple.Create("", 12379), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 12379), true)
);
WriteLiteral(">Delivery Point</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CertificatesofShipment_CSDelPoint\'");
                                                    Write(Model.RecordLocked || !Model.CSDelPoint.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSDelPoint/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSDelPoint/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.CSDelPoint.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CertShip/AutoCompleteCSDelPoint/");
                                                  Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCSDelPoint\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCSDelPoint.ToString() != "" && Model.PopulateCSDelPoint.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CSDelPoint.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCSDelPoint]\"");
WriteLiteral(" data-url=\"/Customer/Load/?CustId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Customer/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Customers</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 14192), Tuple.Create("\'", 14264)
, Tuple.Create(Tuple.Create("", 14200), Tuple.Create("IQLabel101733", 14200), true)
, Tuple.Create(Tuple.Create(" ", 14213), Tuple.Create<System.Object, System.Int32>(!Model.CSGoodsDesc.LabelVisible ? " hide " : ""
, 14214), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14265), Tuple.Create("\'", 14478)
                            , Tuple.Create(Tuple.Create("", 14274), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSGoodsDesc.BackHEXColor) ? "" : "color:" + Model.CSGoodsDesc.BackHEXColor + ";"
, 14274), false)
, Tuple.Create(Tuple.Create("", 14384), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 14384), true)
);
WriteLiteral(">Goods Desc</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:121px;width:400px;top:78px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Goods Desc\'");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSGoodsDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                                               Write(Model.RecordLocked || !Model.CSGoodsDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSGoodsDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSGoodsDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(!Model.CSGoodsDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCSGoodsDesc\' style=\'height:121px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.PopulateCSGoodsDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateCSGoodsDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 15690), Tuple.Create("\'", 15759)
, Tuple.Create(Tuple.Create("", 15698), Tuple.Create("IQLabel101738", 15698), true)
, Tuple.Create(Tuple.Create(" ", 15711), Tuple.Create<System.Object, System.Int32>(!Model.CSWeight.LabelVisible ? " hide " : ""
, 15712), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15760), Tuple.Create("\'", 15967)
                             , Tuple.Create(Tuple.Create("", 15769), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSWeight.BackHEXColor) ? "" : "color:" + Model.CSWeight.BackHEXColor + ";"
, 15769), false)
, Tuple.Create(Tuple.Create("", 15873), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:355px;height:21px;width:60" +
"px;top:203px;", 15873), true)
);
WriteLiteral(">Weight</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSWeight\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSWeight.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CSWeight.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSWeight/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSWeight/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSWeight\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.CSWeight.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:120px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 16568), Tuple.Create("\'", 16638)
, Tuple.Create(Tuple.Create("", 16576), Tuple.Create("IQLabel101739", 16576), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 16589), Tuple.Create<System.Object, System.Int32>(!Model.CSCustOrd.LabelVisible ? " hide " : ""
, 16590), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16639), Tuple.Create("\'", 16848)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 16648), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CSCustOrd.BackHEXColor) ? "" : "color:" + Model.CSCustOrd.BackHEXColor + ";"
, 16648), false)
, Tuple.Create(Tuple.Create("", 16754), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 16754), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CertificatesofShipment_CSCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CSCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CSCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CertShip/SaveCSCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CertShip/CallbackCSCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCSCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CSCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:28px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Edit_1.cshtml")]
    public partial class Views_CertShip_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Edit_1_cshtml()
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
WriteLiteral(" href=\"/CertShip/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Certificates of Shipment</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 423), Tuple.Create("\'", 485)
, Tuple.Create(Tuple.Create("", 433), Tuple.Create("IQJSCall(\"/CertShip/Delete/?RecId=", 433), true)
         , Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 467), false)
, Tuple.Create(Tuple.Create("", 482), Tuple.Create("\");", 482), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CertSh" +
"ip/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CertShip", Model.RecordID.Value))
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
WriteLiteral(" value=\"CertShip\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1600)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.CSIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1646), Tuple.Create("\"", 1669)
, Tuple.Create(Tuple.Create("", 1654), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1654), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1711), Tuple.Create("\"", 1734)
, Tuple.Create(Tuple.Create("", 1719), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1719), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CertShip/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2033), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("/CertShip/ViewHistory/?RecId=", 2040), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteLiteral(" id=\"CertificatesofShipment\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CertShip_CertificatesofShipment.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2947), Tuple.Create("\"", 2962)
, Tuple.Create(Tuple.Create("", 2954), Tuple.Create("#", 2954), true)
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2955), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3178), Tuple.Create("\"", 3190)
, Tuple.Create(Tuple.Create("", 3183), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3183), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Add_1.cshtml")]
    public partial class Views_CertShip_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Certificates of Shipment";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Certificates of Shipment\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CertShip/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CertificatesofShipment\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CertShip_CertificatesofShipment.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_List_1.cshtml")]
    public partial class Views_CertShip_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CertShip>>
    {
        public Views_CertShip_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Certificates of Shipment List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Certificates of Shipment List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Certificates of Shipment</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 620)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/CertShip/ListFromQuery/?Clause=", 556), true)
                                                                    , Tuple.Create(Tuple.Create("", 588), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 588), false)
, Tuple.Create(Tuple.Create("", 603), Tuple.Create("&Ord=", 603), true)
                                                                                        , Tuple.Create(Tuple.Create("", 608), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 608), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Certificate Number</th><th>Job Number</th><th>Job Letter</th><th" +
">Order Number</th><th>Client</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 984), Tuple.Create("\"", 1026)
, Tuple.Create(Tuple.Create("", 991), Tuple.Create("/CertShip/Load/?RecId=", 991), true)
                , Tuple.Create(Tuple.Create("", 1013), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1013), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CSId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1377), Tuple.Create("\"", 1464)
, Tuple.Create(Tuple.Create("", 1388), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobNo/?RecId=", 1388), true)
                                                                                                                   , Tuple.Create(Tuple.Create("", 1440), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1440), false)
, Tuple.Create(Tuple.Create("", 1453), Tuple.Create("\',$(this));", 1453), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                           Write(Html.Raw(itm.CSJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1760), Tuple.Create("\"", 1851)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobLetter/?RecId=", 1771), true)
                                                                         , Tuple.Create(Tuple.Create("", 1827), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1827), false)
, Tuple.Create(Tuple.Create("", 1840), Tuple.Create("\',$(this));", 1840), true)
);
WriteLiteral(" data-bound-name=\'CSJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1913), Tuple.Create("\'", 1957)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 1921), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CSJobLetter.HTMLValue)
, 1921), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CSOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2245), Tuple.Create("\"", 2331)
, Tuple.Create(Tuple.Create("", 2256), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSCust/?RecId=", 2256), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 2307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2307), false)
, Tuple.Create(Tuple.Create("", 2320), Tuple.Create("\',$(this));", 2320), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.CSCust.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Edit_2.cshtml")]
    public partial class Views_CertShip_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Edit_2_cshtml()
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
WriteLiteral(" href=\"/CertShip/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Certificates of Shipment</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 423), Tuple.Create("\'", 485)
, Tuple.Create(Tuple.Create("", 433), Tuple.Create("IQJSCall(\"/CertShip/Delete/?RecId=", 433), true)
         , Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 467), false)
, Tuple.Create(Tuple.Create("", 482), Tuple.Create("\");", 482), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CertSh" +
"ip/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CertShip", Model.RecordID.Value))
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
WriteLiteral(" value=\"CertShip\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1600)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.CSIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1646), Tuple.Create("\"", 1669)
, Tuple.Create(Tuple.Create("", 1654), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1654), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1711), Tuple.Create("\"", 1734)
, Tuple.Create(Tuple.Create("", 1719), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1719), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CertShip/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2033), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("/CertShip/ViewHistory/?RecId=", 2040), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteLiteral(" id=\"CertificatesofShipment\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CertShip_CertificatesofShipment.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2947), Tuple.Create("\"", 2962)
, Tuple.Create(Tuple.Create("", 2954), Tuple.Create("#", 2954), true)
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2955), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3178), Tuple.Create("\"", 3190)
, Tuple.Create(Tuple.Create("", 3183), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3183), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Add_2.cshtml")]
    public partial class Views_CertShip_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Certificates of Shipment";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Certificates of Shipment\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CertShip/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CertificatesofShipment\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CertShip_CertificatesofShipment.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_List_2.cshtml")]
    public partial class Views_CertShip_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CertShip>>
    {
        public Views_CertShip_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Certificates of Shipment List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Certificates of Shipment List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Certificates of Shipment</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 620)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/CertShip/ListFromQuery/?Clause=", 556), true)
                                                                    , Tuple.Create(Tuple.Create("", 588), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 588), false)
, Tuple.Create(Tuple.Create("", 603), Tuple.Create("&Ord=", 603), true)
                                                                                        , Tuple.Create(Tuple.Create("", 608), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 608), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Certificate Number</th><th>Job Number</th><th>Job Letter</th><th" +
">Order Number</th><th>Client</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 984), Tuple.Create("\"", 1026)
, Tuple.Create(Tuple.Create("", 991), Tuple.Create("/CertShip/Load/?RecId=", 991), true)
                , Tuple.Create(Tuple.Create("", 1013), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1013), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CSId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1377), Tuple.Create("\"", 1464)
, Tuple.Create(Tuple.Create("", 1388), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobNo/?RecId=", 1388), true)
                                                                                                                   , Tuple.Create(Tuple.Create("", 1440), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1440), false)
, Tuple.Create(Tuple.Create("", 1453), Tuple.Create("\',$(this));", 1453), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                           Write(Html.Raw(itm.CSJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1760), Tuple.Create("\"", 1851)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobLetter/?RecId=", 1771), true)
                                                                         , Tuple.Create(Tuple.Create("", 1827), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1827), false)
, Tuple.Create(Tuple.Create("", 1840), Tuple.Create("\',$(this));", 1840), true)
);
WriteLiteral(" data-bound-name=\'CSJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1913), Tuple.Create("\'", 1957)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 1921), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CSJobLetter.HTMLValue)
, 1921), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CSOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2245), Tuple.Create("\"", 2331)
, Tuple.Create(Tuple.Create("", 2256), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSCust/?RecId=", 2256), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 2307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2307), false)
, Tuple.Create(Tuple.Create("", 2320), Tuple.Create("\',$(this));", 2320), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.CSCust.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Edit_3.cshtml")]
    public partial class Views_CertShip_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Edit_3_cshtml()
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
WriteLiteral(" href=\"/CertShip/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Certificates of Shipment</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 423), Tuple.Create("\'", 485)
, Tuple.Create(Tuple.Create("", 433), Tuple.Create("IQJSCall(\"/CertShip/Delete/?RecId=", 433), true)
         , Tuple.Create(Tuple.Create("", 467), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 467), false)
, Tuple.Create(Tuple.Create("", 482), Tuple.Create("\");", 482), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CertSh" +
"ip/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CertShip", Model.RecordID.Value))
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
WriteLiteral(" value=\"CertShip\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1600)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.CSIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1646), Tuple.Create("\"", 1669)
, Tuple.Create(Tuple.Create("", 1654), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1654), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1711), Tuple.Create("\"", 1734)
, Tuple.Create(Tuple.Create("", 1719), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1719), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CertShip/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2033), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("/CertShip/ViewHistory/?RecId=", 2040), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2727), Tuple.Create("\"", 2742)
, Tuple.Create(Tuple.Create("", 2734), Tuple.Create("#", 2734), true)
, Tuple.Create(Tuple.Create("", 2735), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2735), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2958), Tuple.Create("\"", 2970)
, Tuple.Create(Tuple.Create("", 2963), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2963), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_Add_3.cshtml")]
    public partial class Views_CertShip_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CertShip>
    {
        public Views_CertShip_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Certificates of Shipment";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Certificates of Shipment\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CertShip/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CertShip>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CertShip_List_3.cshtml")]
    public partial class Views_CertShip_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CertShip>>
    {
        public Views_CertShip_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Certificates of Shipment List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Certificates of Shipment List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Certificates of Shipment</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CertShip/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 620)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/CertShip/ListFromQuery/?Clause=", 556), true)
                                                                    , Tuple.Create(Tuple.Create("", 588), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 588), false)
, Tuple.Create(Tuple.Create("", 603), Tuple.Create("&Ord=", 603), true)
                                                                                        , Tuple.Create(Tuple.Create("", 608), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 608), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Certificate Number</th><th>Job Number</th><th>Job Letter</th><th" +
">Order Number</th><th>Client</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 984), Tuple.Create("\"", 1026)
, Tuple.Create(Tuple.Create("", 991), Tuple.Create("/CertShip/Load/?RecId=", 991), true)
                , Tuple.Create(Tuple.Create("", 1013), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1013), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CSId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1377), Tuple.Create("\"", 1464)
, Tuple.Create(Tuple.Create("", 1388), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobNo/?RecId=", 1388), true)
                                                                                                                   , Tuple.Create(Tuple.Create("", 1440), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1440), false)
, Tuple.Create(Tuple.Create("", 1453), Tuple.Create("\',$(this));", 1453), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                           Write(Html.Raw(itm.CSJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1760), Tuple.Create("\"", 1851)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSJobLetter/?RecId=", 1771), true)
                                                                         , Tuple.Create(Tuple.Create("", 1827), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1827), false)
, Tuple.Create(Tuple.Create("", 1840), Tuple.Create("\',$(this));", 1840), true)
);
WriteLiteral(" data-bound-name=\'CSJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1913), Tuple.Create("\'", 1957)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 1921), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CSJobLetter.HTMLValue)
, 1921), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CSOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CSCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CertShip/AutoCompleteCSCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2245), Tuple.Create("\"", 2331)
, Tuple.Create(Tuple.Create("", 2256), Tuple.Create("javascript:IQAutoSave(\'/CertShip/SaveCSCust/?RecId=", 2256), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 2307), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2307), false)
, Tuple.Create(Tuple.Create("", 2320), Tuple.Create("\',$(this));", 2320), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CSCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.CSCust.HTMLValue));
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
