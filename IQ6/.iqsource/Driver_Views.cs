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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Drivers&Cards.cshtml")]
    public partial class Views_Driver_Drivers_Cards_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Drivers_Cards_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 62), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 70), Tuple.Create("IQLabel101911", 70), true)
, Tuple.Create(Tuple.Create(" ", 83), Tuple.Create<System.Object, System.Int32>(!Model.DrvName.LabelVisible ? " hide " : ""
, 84), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 334)
      , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvName.BackHEXColor) ? "" : "color:" + Model.DrvName.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 242), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 242), true)
);
WriteLiteral(">Driver Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.DrvName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.DrvName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:240px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 918), Tuple.Create("\'", 987)
, Tuple.Create(Tuple.Create("", 926), Tuple.Create("IQLabel101912", 926), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 939), Tuple.Create<System.Object, System.Int32>(!Model.DrvSDate.LabelVisible ? " hide " : ""
, 940), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 988), Tuple.Create("\'", 1193)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvSDate.BackHEXColor) ? "" : "color:" + Model.DrvSDate.BackHEXColor + ";"
, 997), false)
, Tuple.Create(Tuple.Create("", 1101), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1101), true)
);
WriteLiteral(">Start Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvSDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvSDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.DrvSDate.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvSDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvSDate/',$(this));\""));
WriteLiteral("   name=\'PopulateDrvSDate\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.DrvSDate.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1861), Tuple.Create("\'", 1882)
, Tuple.Create(Tuple.Create("", 1869), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1869), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateDrvSDate.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateDrvSDate]\"");
WriteLiteral(" data-url=\"/Week/Load/?WkId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Week/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Weeks</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2751), Tuple.Create("\'", 2822)
, Tuple.Create(Tuple.Create("", 2759), Tuple.Create("IQLabel101913", 2759), true)
, Tuple.Create(Tuple.Create(" ", 2772), Tuple.Create<System.Object, System.Int32>(!Model.DrvVehicle.LabelVisible ? " hide " : ""
, 2773), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2823), Tuple.Create("\'", 3032)
                            , Tuple.Create(Tuple.Create("", 2832), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvVehicle.BackHEXColor) ? "" : "color:" + Model.DrvVehicle.BackHEXColor + ";"
, 2832), false)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2940), true)
);
WriteLiteral(">Vehicle Assigned To</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvVehicle\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvVehicle.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.DrvVehicle.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvVehicle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvVehicle/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvVehicle\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.DrvVehicle.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 3645), Tuple.Create("\'", 3711)
, Tuple.Create(Tuple.Create("", 3653), Tuple.Create("IQLabel101915", 3653), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 3666), Tuple.Create<System.Object, System.Int32>(!Model.DrvId.LabelVisible ? " hide " : ""
, 3667), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3712), Tuple.Create("\'", 3910)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 3721), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvId.BackHEXColor) ? "" : "color:" + Model.DrvId.BackHEXColor + ";"
, 3721), false)
, Tuple.Create(Tuple.Create("", 3819), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 3819), true)
);
WriteLiteral(">Driver ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3998), Tuple.Create("\'", 4060)
, Tuple.Create(Tuple.Create("", 4006), Tuple.Create("form-control", 4006), true)
, Tuple.Create(Tuple.Create("   ", 4018), Tuple.Create<System.Object, System.Int32>(!Model.DrvId.Visible ? " hide " : ""
, 4021), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                Write(Model.DrvId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4421), Tuple.Create("\'", 4492)
, Tuple.Create(Tuple.Create("", 4429), Tuple.Create("IQLabel101916", 4429), true)
                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 4442), Tuple.Create<System.Object, System.Int32>(!Model.DrvAddress.LabelVisible ? " hide " : ""
, 4443), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4493), Tuple.Create("\'", 4703)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 4502), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvAddress.BackHEXColor) ? "" : "color:" + Model.DrvAddress.BackHEXColor + ";"
, 4502), false)
, Tuple.Create(Tuple.Create("", 4610), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4610), true)
);
WriteLiteral(">Address</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'250\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:250px;top:103px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Address\'");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvAddress\'");
WriteLiteral(" ");
                                                                                                                                                                                                                 Write(Model.RecordLocked || !Model.DrvAddress.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvAddress/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvAddress/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.DrvAddress.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateDrvAddress\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateDrvAddress);
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
WriteLiteral(" data-target=\"*[name=PopulateDrvAddress]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5886), Tuple.Create("\'", 5953)
, Tuple.Create(Tuple.Create("", 5894), Tuple.Create("IQLabel101919", 5894), true)
, Tuple.Create(Tuple.Create(" ", 5907), Tuple.Create<System.Object, System.Int32>(!Model.DrvDoB.LabelVisible ? " hide " : ""
, 5908), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5954), Tuple.Create("\'", 6156)
                            , Tuple.Create(Tuple.Create("", 5963), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvDoB.BackHEXColor) ? "" : "color:" + Model.DrvDoB.BackHEXColor + ";"
, 5963), false)
, Tuple.Create(Tuple.Create("", 6063), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 6063), true)
);
WriteLiteral(">Date Of Birth</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:178px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvDoB\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvDoB.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                           Write(!Model.DrvDoB.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvDoB/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvDoB/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateDrvDoB\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.DrvDoB.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateDrvDoB]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7081), Tuple.Create("\'", 7151)
, Tuple.Create(Tuple.Create("", 7089), Tuple.Create("IQLabel101921", 7089), true)
, Tuple.Create(Tuple.Create(" ", 7102), Tuple.Create<System.Object, System.Int32>(!Model.DrvMobile.LabelVisible ? " hide " : ""
, 7103), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7152), Tuple.Create("\'", 7360)
                               , Tuple.Create(Tuple.Create("", 7161), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvMobile.BackHEXColor) ? "" : "color:" + Model.DrvMobile.BackHEXColor + ";"
, 7161), false)
, Tuple.Create(Tuple.Create("", 7267), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 7267), true)
);
WriteLiteral(">Mobile Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:228px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvMobile\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvMobile.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.DrvMobile.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvMobile/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvMobile/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvMobile\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.DrvMobile.ValueFormatted);
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
                 Write(itm.Description(Model.DrvMobile, Driver.DrvMobileField, Model));
WriteLiteral(";");
WriteLiteral("\r\n");
            }
WriteLiteral("\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 8576), Tuple.Create("\'", 8648)
, Tuple.Create(Tuple.Create("", 8584), Tuple.Create("IQLabel101922", 8584), true)
, Tuple.Create(Tuple.Create(" ", 8597), Tuple.Create<System.Object, System.Int32>(!Model.DrvEmpStart.LabelVisible ? " hide " : ""
, 8598), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8649), Tuple.Create("\'", 8861)
                             , Tuple.Create(Tuple.Create("", 8658), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvEmpStart.BackHEXColor) ? "" : "color:" + Model.DrvEmpStart.BackHEXColor + ";"
, 8658), false)
, Tuple.Create(Tuple.Create("", 8768), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:278px;", 8768), true)
);
WriteLiteral(">Emp Start Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:278px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvEmpStart\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvEmpStart.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                Write(!Model.DrvEmpStart.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvEmpStart/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvEmpStart/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateDrvEmpStart\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.DrvEmpStart.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateDrvEmpStart]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9827), Tuple.Create("\'", 9898)
, Tuple.Create(Tuple.Create("", 9835), Tuple.Create("IQLabel101931", 9835), true)
, Tuple.Create(Tuple.Create(" ", 9848), Tuple.Create<System.Object, System.Int32>(!Model.DrvLicense.LabelVisible ? " hide " : ""
, 9849), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9899), Tuple.Create("\'", 10110)
                                , Tuple.Create(Tuple.Create("", 9908), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvLicense.BackHEXColor) ? "" : "color:" + Model.DrvLicense.BackHEXColor + ";"
, 9908), false)
, Tuple.Create(Tuple.Create("", 10016), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:28px;", 10016), true)
);
WriteLiteral(">Drivers License No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvLicense\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvLicense.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.DrvLicense.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvLicense/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvLicense/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvLicense\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.DrvLicense.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 10722), Tuple.Create("\'", 10791)
, Tuple.Create(Tuple.Create("", 10730), Tuple.Create("IQLabel101932", 10730), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 10743), Tuple.Create<System.Object, System.Int32>(!Model.DrvTacho.LabelVisible ? " hide " : ""
, 10744), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10792), Tuple.Create("\'", 10999)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 10801), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvTacho.BackHEXColor) ? "" : "color:" + Model.DrvTacho.BackHEXColor + ";"
, 10801), false)
, Tuple.Create(Tuple.Create("", 10905), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:18" +
"0px;top:53px;", 10905), true)
);
WriteLiteral(">Drivers Digital Tacho Card No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvTacho\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvTacho.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.DrvTacho.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvTacho/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvTacho/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvTacho\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.DrvTacho.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 11608), Tuple.Create("\'", 11675)
, Tuple.Create(Tuple.Create("", 11616), Tuple.Create("IQLabel101933", 11616), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 11629), Tuple.Create<System.Object, System.Int32>(!Model.DrvCPC.LabelVisible ? " hide " : ""
, 11630), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11676), Tuple.Create("\'", 11879)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 11685), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvCPC.BackHEXColor) ? "" : "color:" + Model.DrvCPC.BackHEXColor + ";"
, 11685), false)
, Tuple.Create(Tuple.Create("", 11785), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:78px;", 11785), true)
);
WriteLiteral(">Drivers CPC Card No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvCPC\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvCPC.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.DrvCPC.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvCPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvCPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvCPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.DrvCPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 12464), Tuple.Create("\'", 12532)
, Tuple.Create(Tuple.Create("", 12472), Tuple.Create("IQLabel101934", 12472), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 12485), Tuple.Create<System.Object, System.Int32>(!Model.DrvPpNo.LabelVisible ? " hide " : ""
, 12486), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12533), Tuple.Create("\'", 12739)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 12542), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvPpNo.BackHEXColor) ? "" : "color:" + Model.DrvPpNo.BackHEXColor + ";"
, 12542), false)
, Tuple.Create(Tuple.Create("", 12644), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:103px;", 12644), true)
);
WriteLiteral(">Passport No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvPpNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvPpNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.DrvPpNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvPpNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvPpNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateDrvPpNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.DrvPpNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:160px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 13324), Tuple.Create("\'", 13397)
, Tuple.Create(Tuple.Create("", 13332), Tuple.Create("IQLabel101935", 13332), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 13345), Tuple.Create<System.Object, System.Int32>(!Model.DrvPspExpiry.LabelVisible ? " hide " : ""
, 13346), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13398), Tuple.Create("\'", 13614)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 13407), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvPspExpiry.BackHEXColor) ? "" : "color:" + Model.DrvPspExpiry.BackHEXColor + ";"
, 13407), false)
, Tuple.Create(Tuple.Create("", 13519), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:128px;", 13519), true)
);
WriteLiteral(">Passport Expiry</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:21px;width:80px;top:128px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvPspExpiry\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.DrvPspExpiry.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                 Write(!Model.DrvPspExpiry.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvPspExpiry/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvPspExpiry/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateDrvPspExpiry\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.DrvPspExpiry.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateDrvPspExpiry]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 14589), Tuple.Create("\'", 14659)
, Tuple.Create(Tuple.Create("", 14597), Tuple.Create("IQLabel101936", 14597), true)
, Tuple.Create(Tuple.Create(" ", 14610), Tuple.Create<System.Object, System.Int32>(!Model.DrvActive.LabelVisible ? " hide " : ""
, 14611), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14660), Tuple.Create("\'", 14868)
                              , Tuple.Create(Tuple.Create("", 14669), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvActive.BackHEXColor) ? "" : "color:" + Model.DrvActive.BackHEXColor + ";"
, 14669), false)
, Tuple.Create(Tuple.Create("", 14775), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:3px;", 14775), true)
);
WriteLiteral(">Active</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvActive\'");
WriteAttribute("class", Tuple.Create(" class=\'", 14942), Tuple.Create("\'", 14995)
, Tuple.Create(Tuple.Create("  ", 14950), Tuple.Create<System.Object, System.Int32>(!Model.DrvActive.Visible ? " hide " : ""
, 14952), false)
);
WriteLiteral(" ");
                                                                                                          Write(Model.RecordLocked || !Model.DrvActive.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvActive/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvActive/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:500px;height:16px;width:16px;top:3px;\' name=\'Po" +
"pulateDrvActive\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.PopulateDrvActive ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateDrvActive\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                Write(!Model.PopulateDrvActive ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 15612), Tuple.Create("\'", 15685)
, Tuple.Create(Tuple.Create("", 15620), Tuple.Create("IQLabel101938", 15620), true)
, Tuple.Create(Tuple.Create(" ", 15633), Tuple.Create<System.Object, System.Int32>(!Model.DrvNextOfKin.LabelVisible ? " hide " : ""
, 15634), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15686), Tuple.Create("\'", 15902)
                 , Tuple.Create(Tuple.Create("", 15695), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.DrvNextOfKin.BackHEXColor) ? "" : "color:" + Model.DrvNextOfKin.BackHEXColor + ";"
, 15695), false)
, Tuple.Create(Tuple.Create("", 15807), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:178px;", 15807), true)
);
WriteLiteral(">Next of Kin</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:71px;width:400px;top:178px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Next of Kin\'");
WriteLiteral(" data-ScreenInfo=\'DriversCards_DrvNextOfKin\'");
WriteLiteral(" ");
                                                                                                                                                                                                                       Write(Model.RecordLocked || !Model.DrvNextOfKin.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Driver/SaveDrvNextOfKin/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Driver/CallbackDrvNextOfKin/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(!Model.DrvNextOfKin.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateDrvNextOfKin\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateDrvNextOfKin);
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
WriteLiteral(" data-target=\"*[name=PopulateDrvNextOfKin]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Edit_1.cshtml")]
    public partial class Views_Driver_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Driver/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Drivers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 402), Tuple.Create("\'", 462)
, Tuple.Create(Tuple.Create("", 412), Tuple.Create("IQJSCall(\"/Driver/Delete/?RecId=", 412), true)
       , Tuple.Create(Tuple.Create("", 444), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 444), false)
, Tuple.Create(Tuple.Create("", 459), Tuple.Create("\");", 459), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Driver", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1353), Tuple.Create("\'", 1375)
, Tuple.Create(Tuple.Create("", 1361), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1361), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1421), Tuple.Create("\'", 1445)
, Tuple.Create(Tuple.Create("", 1429), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1429), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Driver\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1545), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1553), Tuple.Create<System.Object, System.Int32>(Model.DrvIdValue
, 1553), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1616), Tuple.Create("\"", 1639)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1624), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1681), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1689), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Driver/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2001), Tuple.Create("\"", 2101)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("/Driver/ViewHistory/?RecId=", 2008), true)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2035), false)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("&dt=", 2050), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2054), false)
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
WriteLiteral(" id=\"DriversCards\"");
WriteLiteral(" style=\'position:relative;height:329px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Driver_Drivers&Cards.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Driver Hours").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2879), Tuple.Create("\'", 2983)
, Tuple.Create(Tuple.Create("", 2887), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "DriverHrs" ? "active" :  "") : "" )
, 2887), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#DriverHrs\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Driver Hours</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3189), Tuple.Create("\"", 3204)
, Tuple.Create(Tuple.Create("", 3196), Tuple.Create("#", 3196), true)
, Tuple.Create(Tuple.Create("", 3197), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3197), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Driver Hours").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "DriverHrs" ? "data-loadTarget='#a99e86fea93945f69d84c0bdf327d035' data-dynamicContent='/DriverHrs/ListFromQuery?Limit=50&Ord=DrvHWk%20DESC&Clause=DrvHDriver=" + Model.DrvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "DriverHrs" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"DriverHrs\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/DriverHrs/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Driver Hours</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "DriverHrs") {
                      Html.RenderPartial("~/Views/DriverHrs_List_1.cshtml", Model.DriverHrss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"a99e86fea93945f69d84c0bdf327d035\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 4429), Tuple.Create("\"", 4441)
, Tuple.Create(Tuple.Create("", 4434), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4434), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Add_1.cshtml")]
    public partial class Views_Driver_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Drivers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Drivers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Driver/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DriversCards\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Driver_Drivers&Cards.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_List_1.cshtml")]
    public partial class Views_Driver_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Driver>>
    {
        public Views_Driver_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Drivers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Drivers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Drivers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 492), Tuple.Create("\"", 561)
, Tuple.Create(Tuple.Create("", 499), Tuple.Create("/Driver/ListFromQuery/?Clause=", 499), true)
                                                                  , Tuple.Create(Tuple.Create("", 529), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 529), false)
, Tuple.Create(Tuple.Create("", 544), Tuple.Create("&Ord=", 544), true)
                                                                                      , Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 549), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver ID</th><th>Driver Name</th><th>Start Date</th><th>Mobile " +
"Number</th><th>Vehicle Assigned To</th><th>Active</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 946), Tuple.Create("\"", 986)
, Tuple.Create(Tuple.Create("", 953), Tuple.Create("/Driver/Load/?RecId=", 953), true)
               , Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 973), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1377)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvName/?RecId=", 1303), true)
                                                                   , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1353), false)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create("\',$(this));", 1366), true)
);
WriteLiteral(" data-bound-name=\'DrvName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1475)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvName.HTMLValue)
, 1443), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1660), Tuple.Create("\"", 1746)
, Tuple.Create(Tuple.Create("", 1671), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvSDate/?RecId=", 1671), true)
                                                                  , Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1722), false)
, Tuple.Create(Tuple.Create("", 1735), Tuple.Create("\',$(this));", 1735), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvSDate\'");
WriteLiteral("  >");
                                                                                                                                                                                                                        Write(Html.Raw(itm.DrvSDate.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvMobile.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2023), Tuple.Create("\"", 2110)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvMobile/?RecId=", 2034), true)
                                                                     , Tuple.Create(Tuple.Create("", 2086), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2086), false)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create("\',$(this));", 2099), true)
);
WriteLiteral(" data-bound-name=\'DrvMobile\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2170), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2178), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvMobile.HTMLValue)
, 2178), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvVehicle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2401), Tuple.Create("\"", 2489)
, Tuple.Create(Tuple.Create("", 2412), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvVehicle/?RecId=", 2412), true)
                                                                      , Tuple.Create(Tuple.Create("", 2465), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2465), false)
, Tuple.Create(Tuple.Create("", 2478), Tuple.Create("\',$(this));", 2478), true)
);
WriteLiteral(" data-bound-name=\'DrvVehicle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2550), Tuple.Create("\'", 2593)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvVehicle.HTMLValue)
, 2558), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvActive.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2763), Tuple.Create("\"", 2849)
, Tuple.Create(Tuple.Create("", 2773), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvActive/?RecId=", 2773), true)
                                                  , Tuple.Create(Tuple.Create("", 2825), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2825), false)
, Tuple.Create(Tuple.Create("", 2838), Tuple.Create("\',$(this));", 2838), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'DrvActive\'");
WriteLiteral(" ");
                                                                                                                                                                                                Write(Html.Raw(itm.DrvActive.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'DrvActive\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Edit_2.cshtml")]
    public partial class Views_Driver_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Driver/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Drivers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 402), Tuple.Create("\'", 462)
, Tuple.Create(Tuple.Create("", 412), Tuple.Create("IQJSCall(\"/Driver/Delete/?RecId=", 412), true)
       , Tuple.Create(Tuple.Create("", 444), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 444), false)
, Tuple.Create(Tuple.Create("", 459), Tuple.Create("\");", 459), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Driver", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1353), Tuple.Create("\'", 1375)
, Tuple.Create(Tuple.Create("", 1361), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1361), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1421), Tuple.Create("\'", 1445)
, Tuple.Create(Tuple.Create("", 1429), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1429), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Driver\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1545), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1553), Tuple.Create<System.Object, System.Int32>(Model.DrvIdValue
, 1553), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1616), Tuple.Create("\"", 1639)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1624), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1681), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1689), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Driver/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2001), Tuple.Create("\"", 2101)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("/Driver/ViewHistory/?RecId=", 2008), true)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2035), false)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("&dt=", 2050), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2054), false)
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
WriteLiteral(" id=\"DriversCards\"");
WriteLiteral(" style=\'position:relative;height:329px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Driver_Drivers&Cards.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Driver Hours").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2879), Tuple.Create("\'", 2983)
, Tuple.Create(Tuple.Create("", 2887), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "DriverHrs" ? "active" :  "") : "" )
, 2887), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#DriverHrs\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Driver Hours</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3189), Tuple.Create("\"", 3204)
, Tuple.Create(Tuple.Create("", 3196), Tuple.Create("#", 3196), true)
, Tuple.Create(Tuple.Create("", 3197), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3197), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Driver Hours").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "DriverHrs" ? "data-loadTarget='#813329b7f8e54aec988c13743c6a14bf' data-dynamicContent='/DriverHrs/ListFromQuery?Limit=50&Ord=DrvHWk%20DESC&Clause=DrvHDriver=" + Model.DrvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "DriverHrs" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"DriverHrs\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/DriverHrs/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Driver Hours</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "DriverHrs") {
                      Html.RenderPartial("~/Views/DriverHrs_List_2.cshtml", Model.DriverHrss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"813329b7f8e54aec988c13743c6a14bf\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 4429), Tuple.Create("\"", 4441)
, Tuple.Create(Tuple.Create("", 4434), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4434), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Add_2.cshtml")]
    public partial class Views_Driver_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Drivers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Drivers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Driver/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"DriversCards\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Driver_Drivers&Cards.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_List_2.cshtml")]
    public partial class Views_Driver_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Driver>>
    {
        public Views_Driver_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Drivers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Drivers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Drivers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 492), Tuple.Create("\"", 561)
, Tuple.Create(Tuple.Create("", 499), Tuple.Create("/Driver/ListFromQuery/?Clause=", 499), true)
                                                                  , Tuple.Create(Tuple.Create("", 529), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 529), false)
, Tuple.Create(Tuple.Create("", 544), Tuple.Create("&Ord=", 544), true)
                                                                                      , Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 549), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver ID</th><th>Driver Name</th><th>Start Date</th><th>Mobile " +
"Number</th><th>Vehicle Assigned To</th><th>Active</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 946), Tuple.Create("\"", 986)
, Tuple.Create(Tuple.Create("", 953), Tuple.Create("/Driver/Load/?RecId=", 953), true)
               , Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 973), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1377)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvName/?RecId=", 1303), true)
                                                                   , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1353), false)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create("\',$(this));", 1366), true)
);
WriteLiteral(" data-bound-name=\'DrvName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1475)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvName.HTMLValue)
, 1443), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1660), Tuple.Create("\"", 1746)
, Tuple.Create(Tuple.Create("", 1671), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvSDate/?RecId=", 1671), true)
                                                                  , Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1722), false)
, Tuple.Create(Tuple.Create("", 1735), Tuple.Create("\',$(this));", 1735), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvSDate\'");
WriteLiteral("  >");
                                                                                                                                                                                                                        Write(Html.Raw(itm.DrvSDate.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvMobile.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2023), Tuple.Create("\"", 2110)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvMobile/?RecId=", 2034), true)
                                                                     , Tuple.Create(Tuple.Create("", 2086), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2086), false)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create("\',$(this));", 2099), true)
);
WriteLiteral(" data-bound-name=\'DrvMobile\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2170), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2178), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvMobile.HTMLValue)
, 2178), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvVehicle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2401), Tuple.Create("\"", 2489)
, Tuple.Create(Tuple.Create("", 2412), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvVehicle/?RecId=", 2412), true)
                                                                      , Tuple.Create(Tuple.Create("", 2465), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2465), false)
, Tuple.Create(Tuple.Create("", 2478), Tuple.Create("\',$(this));", 2478), true)
);
WriteLiteral(" data-bound-name=\'DrvVehicle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2550), Tuple.Create("\'", 2593)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvVehicle.HTMLValue)
, 2558), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvActive.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2763), Tuple.Create("\"", 2849)
, Tuple.Create(Tuple.Create("", 2773), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvActive/?RecId=", 2773), true)
                                                  , Tuple.Create(Tuple.Create("", 2825), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2825), false)
, Tuple.Create(Tuple.Create("", 2838), Tuple.Create("\',$(this));", 2838), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'DrvActive\'");
WriteLiteral(" ");
                                                                                                                                                                                                Write(Html.Raw(itm.DrvActive.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'DrvActive\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Edit_3.cshtml")]
    public partial class Views_Driver_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Driver/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Drivers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 402), Tuple.Create("\'", 462)
, Tuple.Create(Tuple.Create("", 412), Tuple.Create("IQJSCall(\"/Driver/Delete/?RecId=", 412), true)
       , Tuple.Create(Tuple.Create("", 444), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 444), false)
, Tuple.Create(Tuple.Create("", 459), Tuple.Create("\");", 459), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Driver" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Driver", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1353), Tuple.Create("\'", 1375)
, Tuple.Create(Tuple.Create("", 1361), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1361), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1421), Tuple.Create("\'", 1445)
, Tuple.Create(Tuple.Create("", 1429), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1429), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Driver\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1545), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1553), Tuple.Create<System.Object, System.Int32>(Model.DrvIdValue
, 1553), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1616), Tuple.Create("\"", 1639)
, Tuple.Create(Tuple.Create("", 1624), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1624), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1681), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1689), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1689), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Driver/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2001), Tuple.Create("\"", 2101)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("/Driver/ViewHistory/?RecId=", 2008), true)
, Tuple.Create(Tuple.Create("", 2035), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2035), false)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("&dt=", 2050), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2054), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2693), Tuple.Create("\"", 2708)
, Tuple.Create(Tuple.Create("", 2700), Tuple.Create("#", 2700), true)
, Tuple.Create(Tuple.Create("", 2701), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2701), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2924), Tuple.Create("\"", 2936)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2929), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_Add_3.cshtml")]
    public partial class Views_Driver_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Driver>
    {
        public Views_Driver_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Drivers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Drivers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Driver/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Driver>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Driver_List_3.cshtml")]
    public partial class Views_Driver_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Driver>>
    {
        public Views_Driver_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Drivers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Drivers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Drivers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Driver/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 492), Tuple.Create("\"", 561)
, Tuple.Create(Tuple.Create("", 499), Tuple.Create("/Driver/ListFromQuery/?Clause=", 499), true)
                                                                  , Tuple.Create(Tuple.Create("", 529), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 529), false)
, Tuple.Create(Tuple.Create("", 544), Tuple.Create("&Ord=", 544), true)
                                                                                      , Tuple.Create(Tuple.Create("", 549), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 549), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Driver ID</th><th>Driver Name</th><th>Start Date</th><th>Mobile " +
"Number</th><th>Vehicle Assigned To</th><th>Active</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 946), Tuple.Create("\"", 986)
, Tuple.Create(Tuple.Create("", 953), Tuple.Create("/Driver/Load/?RecId=", 953), true)
               , Tuple.Create(Tuple.Create("", 973), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 973), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.DrvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1377)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvName/?RecId=", 1303), true)
                                                                   , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1353), false)
, Tuple.Create(Tuple.Create("", 1366), Tuple.Create("\',$(this));", 1366), true)
);
WriteLiteral(" data-bound-name=\'DrvName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1475)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvName.HTMLValue)
, 1443), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1660), Tuple.Create("\"", 1746)
, Tuple.Create(Tuple.Create("", 1671), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvSDate/?RecId=", 1671), true)
                                                                  , Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1722), false)
, Tuple.Create(Tuple.Create("", 1735), Tuple.Create("\',$(this));", 1735), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'DrvSDate\'");
WriteLiteral("  >");
                                                                                                                                                                                                                        Write(Html.Raw(itm.DrvSDate.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvMobile.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2023), Tuple.Create("\"", 2110)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvMobile/?RecId=", 2034), true)
                                                                     , Tuple.Create(Tuple.Create("", 2086), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2086), false)
, Tuple.Create(Tuple.Create("", 2099), Tuple.Create("\',$(this));", 2099), true)
);
WriteLiteral(" data-bound-name=\'DrvMobile\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2170), Tuple.Create("\'", 2212)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2178), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvMobile.HTMLValue)
, 2178), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvVehicle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2401), Tuple.Create("\"", 2489)
, Tuple.Create(Tuple.Create("", 2412), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvVehicle/?RecId=", 2412), true)
                                                                      , Tuple.Create(Tuple.Create("", 2465), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2465), false)
, Tuple.Create(Tuple.Create("", 2478), Tuple.Create("\',$(this));", 2478), true)
);
WriteLiteral(" data-bound-name=\'DrvVehicle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2550), Tuple.Create("\'", 2593)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.DrvVehicle.HTMLValue)
, 2558), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.DrvActive.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2763), Tuple.Create("\"", 2849)
, Tuple.Create(Tuple.Create("", 2773), Tuple.Create("javascript:IQAutoSave(\'/Driver/SaveDrvActive/?RecId=", 2773), true)
                                                  , Tuple.Create(Tuple.Create("", 2825), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2825), false)
, Tuple.Create(Tuple.Create("", 2838), Tuple.Create("\',$(this));", 2838), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'DrvActive\'");
WriteLiteral(" ");
                                                                                                                                                                                                Write(Html.Raw(itm.DrvActive.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'DrvActive\' value=\'false\'  /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
