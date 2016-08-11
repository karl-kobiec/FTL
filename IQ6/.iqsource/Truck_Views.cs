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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Trucks.cshtml")]
    public partial class Views_Truck_Trucks_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Trucks_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 61), Tuple.Create("\'", 127)
, Tuple.Create(Tuple.Create("", 69), Tuple.Create("IQLabel103311", 69), true)
, Tuple.Create(Tuple.Create(" ", 82), Tuple.Create<System.Object, System.Int32>(!Model.TrkId.LabelVisible ? " hide " : ""
, 83), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 128), Tuple.Create("\'", 326)
    , Tuple.Create(Tuple.Create("", 137), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkId.BackHEXColor) ? "" : "color:" + Model.TrkId.BackHEXColor + ";"
, 137), false)
, Tuple.Create(Tuple.Create("", 235), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 235), true)
);
WriteLiteral(">Truck ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 407), Tuple.Create("\'", 469)
, Tuple.Create(Tuple.Create("", 415), Tuple.Create("form-control", 415), true)
, Tuple.Create(Tuple.Create("   ", 427), Tuple.Create<System.Object, System.Int32>(!Model.TrkId.Visible ? " hide " : ""
, 430), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkId\' value=\'");
                                                                                                                                                                                                                                                                                                                                              Write(Model.TrkId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 828), Tuple.Create("\'", 896)
, Tuple.Create(Tuple.Create("", 836), Tuple.Create("IQLabel103312", 836), true)
                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 849), Tuple.Create<System.Object, System.Int32>(!Model.TrkName.LabelVisible ? " hide " : ""
, 850), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 897), Tuple.Create("\'", 1100)
                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 906), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkName.BackHEXColor) ? "" : "color:" + Model.TrkName.BackHEXColor + ";"
, 906), false)
, Tuple.Create(Tuple.Create("", 1008), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1008), true)
);
WriteLiteral(">Registration No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                              Write(!Model.TrkName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.TrkName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1689), Tuple.Create("\'", 1758)
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create("IQLabel103313", 1697), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 1710), Tuple.Create<System.Object, System.Int32>(!Model.TrkNotes.LabelVisible ? " hide " : ""
, 1711), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1759), Tuple.Create("\'", 1965)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1768), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkNotes.BackHEXColor) ? "" : "color:" + Model.TrkNotes.BackHEXColor + ";"
, 1768), false)
, Tuple.Create(Tuple.Create("", 1872), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:253px;", 1872), true)
);
WriteLiteral(">Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:400px;top:253px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Notes\'");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                       Write(Model.RecordLocked || !Model.TrkNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.TrkNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateTrkNotes\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.PopulateTrkNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateTrkNotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3120), Tuple.Create("\'", 3190)
, Tuple.Create(Tuple.Create("", 3128), Tuple.Create("IQLabel103314", 3128), true)
, Tuple.Create(Tuple.Create(" ", 3141), Tuple.Create<System.Object, System.Int32>(!Model.TrkDriver.LabelVisible ? " hide " : ""
, 3142), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3191), Tuple.Create("\'", 3398)
                               , Tuple.Create(Tuple.Create("", 3200), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkDriver.BackHEXColor) ? "" : "color:" + Model.TrkDriver.BackHEXColor + ";"
, 3200), false)
, Tuple.Create(Tuple.Create("", 3306), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 3306), true)
);
WriteLiteral(">Driver</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkDriver\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkDriver.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                        Write(!Model.TrkDriver.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDriver/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkDriver/',$(this));\""));
WriteLiteral("   name=\'PopulateTrkDriver\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.TrkDriver.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4061), Tuple.Create("\'", 4082)
, Tuple.Create(Tuple.Create("", 4069), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4069), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateTrkDriver.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateTrkDriver]\"");
WriteLiteral(" data-url=\"/Driver/Load/?DrvId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Driver/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Drivers</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4960), Tuple.Create("\'", 5032)
, Tuple.Create(Tuple.Create("", 4968), Tuple.Create("IQLabel103315", 4968), true)
, Tuple.Create(Tuple.Create(" ", 4981), Tuple.Create<System.Object, System.Int32>(!Model.TrkPermitNo.LabelVisible ? " hide " : ""
, 4982), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5033), Tuple.Create("\'", 5244)
                             , Tuple.Create(Tuple.Create("", 5042), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkPermitNo.BackHEXColor) ? "" : "color:" + Model.TrkPermitNo.BackHEXColor + ";"
, 5042), false)
, Tuple.Create(Tuple.Create("", 5152), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 5152), true)
);
WriteLiteral(">Permit No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkPermitNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkPermitNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.TrkPermitNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkPermitNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkPermitNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkPermitNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.TrkPermitNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5847), Tuple.Create("\'", 5917)
, Tuple.Create(Tuple.Create("", 5855), Tuple.Create("IQLabel103317", 5855), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 5868), Tuple.Create<System.Object, System.Int32>(!Model.TrkAS24No.LabelVisible ? " hide " : ""
, 5869), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5918), Tuple.Create("\'", 6126)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 5927), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkAS24No.BackHEXColor) ? "" : "color:" + Model.TrkAS24No.BackHEXColor + ";"
, 5927), false)
, Tuple.Create(Tuple.Create("", 6033), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 6033), true)
);
WriteLiteral(">AS24 Card No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkAS24No\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkAS24No.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.TrkAS24No.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkAS24No/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkAS24No/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkAS24No\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.TrkAS24No.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6719), Tuple.Create("\'", 6788)
, Tuple.Create(Tuple.Create("", 6727), Tuple.Create("IQLabel103318", 6727), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 6740), Tuple.Create<System.Object, System.Int32>(!Model.TrkDKVNo.LabelVisible ? " hide " : ""
, 6741), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6789), Tuple.Create("\'", 6995)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 6798), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkDKVNo.BackHEXColor) ? "" : "color:" + Model.TrkDKVNo.BackHEXColor + ";"
, 6798), false)
, Tuple.Create(Tuple.Create("", 6902), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 6902), true)
);
WriteLiteral(">DKV No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkDKVNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkDKVNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.TrkDKVNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDKVNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkDKVNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkDKVNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.TrkDKVNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7575), Tuple.Create("\'", 7646)
, Tuple.Create(Tuple.Create("", 7583), Tuple.Create("IQLabel103319", 7583), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 7596), Tuple.Create<System.Object, System.Int32>(!Model.TrkShellNo.LabelVisible ? " hide " : ""
, 7597), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7647), Tuple.Create("\'", 7857)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 7656), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkShellNo.BackHEXColor) ? "" : "color:" + Model.TrkShellNo.BackHEXColor + ";"
, 7656), false)
, Tuple.Create(Tuple.Create("", 7764), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 7764), true)
);
WriteLiteral(">Shell No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkShellNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkShellNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.TrkShellNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkShellNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkShellNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkShellNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.TrkShellNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 8453), Tuple.Create("\'", 8524)
, Tuple.Create(Tuple.Create("", 8461), Tuple.Create("IQLabel103331", 8461), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 8474), Tuple.Create<System.Object, System.Int32>(!Model.TrkMOTDate.LabelVisible ? " hide " : ""
, 8475), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8525), Tuple.Create("\'", 8735)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 8534), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMOTDate.BackHEXColor) ? "" : "color:" + Model.TrkMOTDate.BackHEXColor + ";"
, 8534), false)
, Tuple.Create(Tuple.Create("", 8642), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 8642), true)
);
WriteLiteral(">MOT Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:80px;top:3px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkMOTDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkMOTDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                               Write(!Model.TrkMOTDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkMOTDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkMOTDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrkMOTDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.TrkMOTDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrkMOTDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9677), Tuple.Create("\'", 9748)
, Tuple.Create(Tuple.Create("", 9685), Tuple.Create("IQLabel103332", 9685), true)
, Tuple.Create(Tuple.Create(" ", 9698), Tuple.Create<System.Object, System.Int32>(!Model.TrkTAXDate.LabelVisible ? " hide " : ""
, 9699), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9749), Tuple.Create("\'", 9960)
                                , Tuple.Create(Tuple.Create("", 9758), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkTAXDate.BackHEXColor) ? "" : "color:" + Model.TrkTAXDate.BackHEXColor + ";"
, 9758), false)
, Tuple.Create(Tuple.Create("", 9866), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 9866), true)
);
WriteLiteral(">TAX Due Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkTAXDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkTAXDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                               Write(!Model.TrkTAXDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkTAXDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkTAXDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrkTAXDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.TrkTAXDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrkTAXDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10907), Tuple.Create("\'", 10981)
, Tuple.Create(Tuple.Create("", 10915), Tuple.Create("IQLabel103333", 10915), true)
, Tuple.Create(Tuple.Create(" ", 10928), Tuple.Create<System.Object, System.Int32>(!Model.TrkServiceDue.LabelVisible ? " hide " : ""
, 10929), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10982), Tuple.Create("\'", 11199)
                                  , Tuple.Create(Tuple.Create("", 10991), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkServiceDue.BackHEXColor) ? "" : "color:" + Model.TrkServiceDue.BackHEXColor + ";"
, 10991), false)
, Tuple.Create(Tuple.Create("", 11105), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 11105), true)
);
WriteLiteral(">Service Due</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:80px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkServiceDue\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkServiceDue.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                  Write(!Model.TrkServiceDue.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkServiceDue/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkServiceDue/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrkServiceDue\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.TrkServiceDue.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrkServiceDue]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 12169), Tuple.Create("\'", 12241)
, Tuple.Create(Tuple.Create("", 12177), Tuple.Create("IQLabel103334", 12177), true)
, Tuple.Create(Tuple.Create(" ", 12190), Tuple.Create<System.Object, System.Int32>(!Model.TrkTruckMob.LabelVisible ? " hide " : ""
, 12191), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12242), Tuple.Create("\'", 12455)
                                , Tuple.Create(Tuple.Create("", 12251), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkTruckMob.BackHEXColor) ? "" : "color:" + Model.TrkTruckMob.BackHEXColor + ";"
, 12251), false)
, Tuple.Create(Tuple.Create("", 12361), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 12361), true)
);
WriteLiteral(">Truck Mobile:</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:160px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkTruckMob\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkTruckMob.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.TrkTruckMob.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkTruckMob/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkTruckMob/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkTruckMob\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.TrkTruckMob.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/><div");
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
WriteLiteral(">\r\n\t\t\t\r\n");
                     foreach (var itm in DS.GlobalManager.CustomFieldElements.Where(f => f.KeyValue == DSFieldContentType.Phone))
            {
WriteLiteral("                ");
                 Write(itm.Description(Model.TrkTruckMob, Truck.TrkTruckMobField, Model));
WriteLiteral(";");
WriteLiteral("\r\n");
            }
WriteLiteral("\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 13679), Tuple.Create("\'", 13749)
, Tuple.Create(Tuple.Create("", 13687), Tuple.Create("IQLabel103336", 13687), true)
, Tuple.Create(Tuple.Create(" ", 13700), Tuple.Create<System.Object, System.Int32>(!Model.TrkDKVPIN.LabelVisible ? " hide " : ""
, 13701), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13750), Tuple.Create("\'", 13960)
                          , Tuple.Create(Tuple.Create("", 13759), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkDKVPIN.BackHEXColor) ? "" : "color:" + Model.TrkDKVPIN.BackHEXColor + ";"
, 13759), false)
, Tuple.Create(Tuple.Create("", 13865), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:153px;", 13865), true)
);
WriteLiteral(">DKV Pin No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkDKVPIN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkDKVPIN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.TrkDKVPIN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDKVPIN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkDKVPIN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkDKVPIN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.TrkDKVPIN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 14551), Tuple.Create("\'", 14623)
, Tuple.Create(Tuple.Create("", 14559), Tuple.Create("IQLabel103337", 14559), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 14572), Tuple.Create<System.Object, System.Int32>(!Model.TrkShellPIN.LabelVisible ? " hide " : ""
, 14573), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14624), Tuple.Create("\'", 14838)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 14633), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkShellPIN.BackHEXColor) ? "" : "color:" + Model.TrkShellPIN.BackHEXColor + ";"
, 14633), false)
, Tuple.Create(Tuple.Create("", 14743), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:178px;", 14743), true)
);
WriteLiteral(">Shell Pin No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkShellPIN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkShellPIN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.TrkShellPIN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkShellPIN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkShellPIN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkShellPIN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.TrkShellPIN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 15445), Tuple.Create("\'", 15516)
, Tuple.Create(Tuple.Create("", 15453), Tuple.Create("IQLabel103338", 15453), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 15466), Tuple.Create<System.Object, System.Int32>(!Model.TrkAS24PIN.LabelVisible ? " hide " : ""
, 15467), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15517), Tuple.Create("\'", 15729)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 15526), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkAS24PIN.BackHEXColor) ? "" : "color:" + Model.TrkAS24PIN.BackHEXColor + ";"
, 15526), false)
, Tuple.Create(Tuple.Create("", 15634), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:128px;", 15634), true)
);
WriteLiteral(">AS24 Pin No:</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trucks_TrkAS24PIN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkAS24PIN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.TrkAS24PIN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Truck/SaveTrkAS24PIN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Truck/CallbackTrkAS24PIN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkAS24PIN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.TrkAS24PIN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:128px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Edit_1.cshtml")]
    public partial class Views_Truck_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Truck/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trucks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 458)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/Truck/Delete/?RecId=", 409), true)
      , Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 440), false)
, Tuple.Create(Tuple.Create("", 455), Tuple.Create("\");", 455), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Truck/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Truck", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1346), Tuple.Create("\'", 1368)
, Tuple.Create(Tuple.Create("", 1354), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1354), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1414), Tuple.Create("\'", 1438)
, Tuple.Create(Tuple.Create("", 1422), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1422), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Truck\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1537), Tuple.Create("\"", 1562)
, Tuple.Create(Tuple.Create("", 1545), Tuple.Create<System.Object, System.Int32>(Model.TrkIdValue
, 1545), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1608), Tuple.Create("\"", 1631)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1616), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1673), Tuple.Create("\"", 1696)
, Tuple.Create(Tuple.Create("", 1681), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1681), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Truck/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1992), Tuple.Create("\"", 2091)
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create("/Truck/ViewHistory/?RecId=", 1999), true)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2025), false)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("&dt=", 2040), true)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2044), false)
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
WriteLiteral(" id=\"Trucks\"");
WriteLiteral(" style=\'position:relative;height:354px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Truck_Trucks.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2868), Tuple.Create("\"", 2883)
, Tuple.Create(Tuple.Create("", 2875), Tuple.Create("#", 2875), true)
, Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2876), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3099), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3104), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Add_1.cshtml")]
    public partial class Views_Truck_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trucks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trucks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Truck/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Trucks\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Truck_Trucks.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_List_1.cshtml")]
    public partial class Views_Truck_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Truck>>
    {
        public Views_Truck_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trucks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trucks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trucks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 554)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Truck/ListFromQuery/?Clause=", 493), true)
                                                                 , Tuple.Create(Tuple.Create("", 522), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 522), false)
, Tuple.Create(Tuple.Create("", 537), Tuple.Create("&Ord=", 537), true)
                                                                                     , Tuple.Create(Tuple.Create("", 542), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 542), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck ID</th><th>Registration No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 858), Tuple.Create("\"", 897)
, Tuple.Create(Tuple.Create("", 865), Tuple.Create("/Truck/Load/?RecId=", 865), true)
              , Tuple.Create(Tuple.Create("", 884), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 884), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.TrkId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:60%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1203), Tuple.Create("\"", 1287)
, Tuple.Create(Tuple.Create("", 1214), Tuple.Create("javascript:IQAutoSave(\'/Truck/SaveTrkName/?RecId=", 1214), true)
                                                                  , Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1263), false)
, Tuple.Create(Tuple.Create("", 1276), Tuple.Create("\',$(this));", 1276), true)
);
WriteLiteral(" data-bound-name=\'TrkName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1385)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkName.HTMLValue)
, 1353), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Edit_2.cshtml")]
    public partial class Views_Truck_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Truck/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trucks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 458)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/Truck/Delete/?RecId=", 409), true)
      , Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 440), false)
, Tuple.Create(Tuple.Create("", 455), Tuple.Create("\");", 455), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Truck/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Truck", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1346), Tuple.Create("\'", 1368)
, Tuple.Create(Tuple.Create("", 1354), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1354), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1414), Tuple.Create("\'", 1438)
, Tuple.Create(Tuple.Create("", 1422), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1422), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Truck\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1537), Tuple.Create("\"", 1562)
, Tuple.Create(Tuple.Create("", 1545), Tuple.Create<System.Object, System.Int32>(Model.TrkIdValue
, 1545), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1608), Tuple.Create("\"", 1631)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1616), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1673), Tuple.Create("\"", 1696)
, Tuple.Create(Tuple.Create("", 1681), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1681), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Truck/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1992), Tuple.Create("\"", 2091)
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create("/Truck/ViewHistory/?RecId=", 1999), true)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2025), false)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("&dt=", 2040), true)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2044), false)
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
WriteLiteral(" id=\"Trucks\"");
WriteLiteral(" style=\'position:relative;height:354px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Truck_Trucks.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2868), Tuple.Create("\"", 2883)
, Tuple.Create(Tuple.Create("", 2875), Tuple.Create("#", 2875), true)
, Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2876), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3099), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3104), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Add_2.cshtml")]
    public partial class Views_Truck_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trucks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trucks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Truck/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Trucks\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Truck_Trucks.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_List_2.cshtml")]
    public partial class Views_Truck_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Truck>>
    {
        public Views_Truck_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trucks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trucks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trucks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 554)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Truck/ListFromQuery/?Clause=", 493), true)
                                                                 , Tuple.Create(Tuple.Create("", 522), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 522), false)
, Tuple.Create(Tuple.Create("", 537), Tuple.Create("&Ord=", 537), true)
                                                                                     , Tuple.Create(Tuple.Create("", 542), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 542), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck ID</th><th>Registration No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 858), Tuple.Create("\"", 897)
, Tuple.Create(Tuple.Create("", 865), Tuple.Create("/Truck/Load/?RecId=", 865), true)
              , Tuple.Create(Tuple.Create("", 884), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 884), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.TrkId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:60%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1203), Tuple.Create("\"", 1287)
, Tuple.Create(Tuple.Create("", 1214), Tuple.Create("javascript:IQAutoSave(\'/Truck/SaveTrkName/?RecId=", 1214), true)
                                                                  , Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1263), false)
, Tuple.Create(Tuple.Create("", 1276), Tuple.Create("\',$(this));", 1276), true)
);
WriteLiteral(" data-bound-name=\'TrkName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1385)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkName.HTMLValue)
, 1353), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Edit_3.cshtml")]
    public partial class Views_Truck_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Truck/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trucks</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 458)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/Truck/Delete/?RecId=", 409), true)
      , Tuple.Create(Tuple.Create("", 440), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 440), false)
, Tuple.Create(Tuple.Create("", 455), Tuple.Create("\");", 455), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Truck/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Truck", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1346), Tuple.Create("\'", 1368)
, Tuple.Create(Tuple.Create("", 1354), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1354), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1414), Tuple.Create("\'", 1438)
, Tuple.Create(Tuple.Create("", 1422), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1422), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Truck\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1537), Tuple.Create("\"", 1562)
, Tuple.Create(Tuple.Create("", 1545), Tuple.Create<System.Object, System.Int32>(Model.TrkIdValue
, 1545), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1608), Tuple.Create("\"", 1631)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1616), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1673), Tuple.Create("\"", 1696)
, Tuple.Create(Tuple.Create("", 1681), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1681), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Truck/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1992), Tuple.Create("\"", 2091)
, Tuple.Create(Tuple.Create("", 1999), Tuple.Create("/Truck/ViewHistory/?RecId=", 1999), true)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2025), false)
, Tuple.Create(Tuple.Create("", 2040), Tuple.Create("&dt=", 2040), true)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2044), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2683), Tuple.Create("\"", 2698)
, Tuple.Create(Tuple.Create("", 2690), Tuple.Create("#", 2690), true)
, Tuple.Create(Tuple.Create("", 2691), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2691), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2914), Tuple.Create("\"", 2926)
, Tuple.Create(Tuple.Create("", 2919), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2919), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_Add_3.cshtml")]
    public partial class Views_Truck_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Truck>
    {
        public Views_Truck_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trucks";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trucks\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Truck/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Truck>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Truck_List_3.cshtml")]
    public partial class Views_Truck_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Truck>>
    {
        public Views_Truck_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trucks List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trucks List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trucks</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Truck/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 554)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Truck/ListFromQuery/?Clause=", 493), true)
                                                                 , Tuple.Create(Tuple.Create("", 522), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 522), false)
, Tuple.Create(Tuple.Create("", 537), Tuple.Create("&Ord=", 537), true)
                                                                                     , Tuple.Create(Tuple.Create("", 542), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 542), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck ID</th><th>Registration No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 858), Tuple.Create("\"", 897)
, Tuple.Create(Tuple.Create("", 865), Tuple.Create("/Truck/Load/?RecId=", 865), true)
              , Tuple.Create(Tuple.Create("", 884), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 884), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.TrkId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:60%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1203), Tuple.Create("\"", 1287)
, Tuple.Create(Tuple.Create("", 1214), Tuple.Create("javascript:IQAutoSave(\'/Truck/SaveTrkName/?RecId=", 1214), true)
                                                                  , Tuple.Create(Tuple.Create("", 1263), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1263), false)
, Tuple.Create(Tuple.Create("", 1276), Tuple.Create("\',$(this));", 1276), true)
);
WriteLiteral(" data-bound-name=\'TrkName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1385)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkName.HTMLValue)
, 1353), false)
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
