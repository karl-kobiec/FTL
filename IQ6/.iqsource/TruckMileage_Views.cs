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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_TruckFuelMileage.cshtml")]
    public partial class Views_TruckMileage_TruckFuelMileage_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_TruckFuelMileage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 68), Tuple.Create("\'", 138)
, Tuple.Create(Tuple.Create("", 76), Tuple.Create("IQLabel103411", 76), true)
, Tuple.Create(Tuple.Create(" ", 89), Tuple.Create<System.Object, System.Int32>(!Model.TrkMTruck.LabelVisible ? " hide " : ""
, 90), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 139), Tuple.Create("\'", 345)
        , Tuple.Create(Tuple.Create("", 148), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMTruck.BackHEXColor) ? "" : "color:" + Model.TrkMTruck.BackHEXColor + ";"
, 148), false)
, Tuple.Create(Tuple.Create("", 254), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 254), true)
);
WriteLiteral(">Truck</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMTruck\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkMTruck.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                 Write(!Model.TrkMTruck.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMTruck/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMTruck/',$(this));\""));
WriteLiteral("   name=\'PopulateTrkMTruck\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.TrkMTruck.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1040), Tuple.Create("\'", 1061)
, Tuple.Create(Tuple.Create("", 1048), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1048), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateTrkMTruck.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateTrkMTruck]\"");
WriteLiteral(" data-url=\"/Truck/Load/?TrkId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Truck/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Trucks</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1936), Tuple.Create("\'", 2010)
, Tuple.Create(Tuple.Create("", 1944), Tuple.Create("IQLabel103412", 1944), true)
, Tuple.Create(Tuple.Create(" ", 1957), Tuple.Create<System.Object, System.Int32>(!Model.TrkMPurchDate.LabelVisible ? " hide " : ""
, 1958), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2011), Tuple.Create("\'", 2226)
                               , Tuple.Create(Tuple.Create("", 2020), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMPurchDate.BackHEXColor) ? "" : "color:" + Model.TrkMPurchDate.BackHEXColor + ";"
, 2020), false)
, Tuple.Create(Tuple.Create("", 2134), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 2134), true)
);
WriteLiteral(">Date of Purchase</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMPurchDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkMPurchDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.TrkMPurchDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMPurchDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMPurchDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkMPurchDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.TrkMPurchDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2873), Tuple.Create("\'", 2948)
, Tuple.Create(Tuple.Create("", 2881), Tuple.Create("IQLabel103413", 2881), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 2894), Tuple.Create<System.Object, System.Int32>(!Model.TrkMPurchLitre.LabelVisible ? " hide " : ""
, 2895), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2949), Tuple.Create("\'", 3166)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 2958), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMPurchLitre.BackHEXColor) ? "" : "color:" + Model.TrkMPurchLitre.BackHEXColor + ";"
, 2958), false)
, Tuple.Create(Tuple.Create("", 3074), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 3074), true)
);
WriteLiteral(">Litres purchased</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMPurchLitre\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkMPurchLitre.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.TrkMPurchLitre.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMPurchLitre/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMPurchLitre/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkMPurchLitre\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.TrkMPurchLitre.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3820), Tuple.Create("\'", 3893)
, Tuple.Create(Tuple.Create("", 3828), Tuple.Create("IQLabel103414", 3828), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 3841), Tuple.Create<System.Object, System.Int32>(!Model.TrkMOdometer.LabelVisible ? " hide " : ""
, 3842), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3894), Tuple.Create("\'", 4107)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 3903), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMOdometer.BackHEXColor) ? "" : "color:" + Model.TrkMOdometer.BackHEXColor + ";"
, 3903), false)
, Tuple.Create(Tuple.Create("", 4015), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 4015), true)
);
WriteLiteral(">Odometer (km)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMOdometer\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrkMOdometer.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.TrkMOdometer.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMOdometer/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMOdometer/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkMOdometer\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.TrkMOdometer.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 4744), Tuple.Create("\'", 4820)
, Tuple.Create(Tuple.Create("", 4752), Tuple.Create("IQLabel103415", 4752), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 4765), Tuple.Create<System.Object, System.Int32>(!Model.TrkMNextReading.LabelVisible ? " hide " : ""
, 4766), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4821), Tuple.Create("\'", 5041)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 4830), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMNextReading.BackHEXColor) ? "" : "color:" + Model.TrkMNextReading.BackHEXColor + ";"
, 4830), false)
, Tuple.Create(Tuple.Create("", 4948), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4948), true)
);
WriteLiteral(">Next reading (km)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMNextReading\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 5152), Tuple.Create("\'", 5224)
, Tuple.Create(Tuple.Create("", 5160), Tuple.Create("form-control", 5160), true)
, Tuple.Create(Tuple.Create("   ", 5172), Tuple.Create<System.Object, System.Int32>(!Model.TrkMNextReading.Visible ? " hide " : ""
, 5175), false)
);
WriteLiteral(" ");
                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMNextReading/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMNextReading/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkMNextReading\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.TrkMNextReading.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5639), Tuple.Create("\'", 5707)
, Tuple.Create(Tuple.Create("", 5647), Tuple.Create("IQLabel103416", 5647), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 5660), Tuple.Create<System.Object, System.Int32>(!Model.TrkMMpg.LabelVisible ? " hide " : ""
, 5661), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5708), Tuple.Create("\'", 5912)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 5717), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMMpg.BackHEXColor) ? "" : "color:" + Model.TrkMMpg.BackHEXColor + ";"
, 5717), false)
, Tuple.Create(Tuple.Create("", 5819), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 5819), true)
);
WriteLiteral(">Mpg</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMMpg\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 6001), Tuple.Create("\'", 6065)
, Tuple.Create(Tuple.Create("", 6009), Tuple.Create("form-control", 6009), true)
, Tuple.Create(Tuple.Create("   ", 6021), Tuple.Create<System.Object, System.Int32>(!Model.TrkMMpg.Visible ? " hide " : ""
, 6024), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMMpg/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMMpg/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrkMMpg\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.TrkMMpg.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6448), Tuple.Create("\'", 6518)
, Tuple.Create(Tuple.Create("", 6456), Tuple.Create("IQLabel103432", 6456), true)
                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 6469), Tuple.Create<System.Object, System.Int32>(!Model.TrkMNotes.LabelVisible ? " hide " : ""
, 6470), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6519), Tuple.Create("\'", 6728)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 6528), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrkMNotes.BackHEXColor) ? "" : "color:" + Model.TrkMNotes.BackHEXColor + ";"
, 6528), false)
, Tuple.Create(Tuple.Create("", 6634), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:12" +
"0px;top:28px;", 6634), true)
);
WriteLiteral(">Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'360\'");
WriteLiteral(" style=\'position: absolute; left:360px;height:71px;width:360px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Notes\'");
WriteLiteral(" data-ScreenInfo=\'TruckFuel/Mileage_TrkMNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                               Write(Model.RecordLocked || !Model.TrkMNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/TruckMileage/CallbackTrkMNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.TrkMNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateTrkMNotes\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.PopulateTrkMNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateTrkMNotes]\"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Edit_1.cshtml")]
    public partial class Views_TruckMileage_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Edit_1_cshtml()
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
WriteLiteral(" href=\"/TruckMileage/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 427), Tuple.Create("\'", 493)
, Tuple.Create(Tuple.Create("", 437), Tuple.Create("IQJSCall(\"/TruckMileage/Delete/?RecId=", 437), true)
             , Tuple.Create(Tuple.Create("", 475), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 475), false)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("\");", 490), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/TruckM" +
"ileage/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("TruckMileage", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1424)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1470), Tuple.Create("\'", 1494)
, Tuple.Create(Tuple.Create("", 1478), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1478), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"TruckMileage\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1600), Tuple.Create("\"", 1629)
, Tuple.Create(Tuple.Create("", 1608), Tuple.Create<System.Object, System.Int32>(Model.TrkMTruckValue
, 1608), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1675), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1683), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1740), Tuple.Create("\"", 1763)
, Tuple.Create(Tuple.Create("", 1748), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1748), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/TruckMileage/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2066), Tuple.Create("\"", 2172)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create("/TruckMileage/ViewHistory/?RecId=", 2073), true)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2106), false)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("&dt=", 2121), true)
, Tuple.Create(Tuple.Create("", 2125), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2125), false)
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
WriteLiteral(" id=\"TruckFuel/Mileage\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/TruckMileage_TruckFuelMileage.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2977), Tuple.Create("\"", 2992)
, Tuple.Create(Tuple.Create("", 2984), Tuple.Create("#", 2984), true)
, Tuple.Create(Tuple.Create("", 2985), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2985), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3208), Tuple.Create("\"", 3220)
, Tuple.Create(Tuple.Create("", 3213), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3213), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Add_1.cshtml")]
    public partial class Views_TruckMileage_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Truck Fuel / Mileage";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Truck Fuel / Mileage\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/TruckMileage/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TruckFuel/Mileage\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/TruckMileage_TruckFuelMileage.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_List_1.cshtml")]
    public partial class Views_TruckMileage_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.TruckMileage>>
    {
        public Views_TruckMileage_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Truck Fuel / Mileage List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Truck Fuel / Mileage List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 624)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/TruckMileage/ListFromQuery/?Clause=", 556), true)
                                                                        , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 592), false)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create("&Ord=", 607), true)
                                                                                            , Tuple.Create(Tuple.Create("", 612), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 612), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck</th><th>Date of Purchase</th><th>Litres purchased</th><th>" +
"Odometer (km)</th><th>Notes</th><th>Next reading (km)</th><th>Mpg</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1025), Tuple.Create("\"", 1071)
, Tuple.Create(Tuple.Create("", 1032), Tuple.Create("/TruckMileage/Load/?RecId=", 1032), true)
                    , Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1058), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMTruck.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1321), Tuple.Create("\"", 1414)
, Tuple.Create(Tuple.Create("", 1332), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMTruck/?RecId=", 1332), true)
                                                                         , Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1390), false)
, Tuple.Create(Tuple.Create("", 1403), Tuple.Create("\',$(this));", 1403), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMTruck\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.TrkMTruck.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1696), Tuple.Create("\"", 1793)
, Tuple.Create(Tuple.Create("", 1707), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchDate/?RecId=", 1707), true)
                                                                              , Tuple.Create(Tuple.Create("", 1769), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1769), false)
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create("\',$(this));", 1782), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1857), Tuple.Create("\'", 1903)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchDate.HTMLValue)
, 1865), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchLitre.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2095), Tuple.Create("\"", 2193)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchLitre/?RecId=", 2106), true)
                                                                               , Tuple.Create(Tuple.Create("", 2169), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2169), false)
, Tuple.Create(Tuple.Create("", 2182), Tuple.Create("\',$(this));", 2182), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchLitre\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2258), Tuple.Create("\'", 2305)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2266), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchLitre.HTMLValue)
, 2266), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMOdometer.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2495), Tuple.Create("\"", 2591)
, Tuple.Create(Tuple.Create("", 2506), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMOdometer/?RecId=", 2506), true)
                                                                             , Tuple.Create(Tuple.Create("", 2567), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2567), false)
, Tuple.Create(Tuple.Create("", 2580), Tuple.Create("\',$(this));", 2580), true)
);
WriteLiteral(" data-bound-name=\'TrkMOdometer\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2654), Tuple.Create("\'", 2699)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMOdometer.HTMLValue)
, 2662), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:43%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2887), Tuple.Create("\"", 2980)
, Tuple.Create(Tuple.Create("", 2898), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMNotes/?RecId=", 2898), true)
                                                                           , Tuple.Create(Tuple.Create("", 2956), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2956), false)
, Tuple.Create(Tuple.Create("", 2969), Tuple.Create("\',$(this));", 2969), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.TrkMNotes.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrkMNextReading.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                 Write(itm.TrkMMpg.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Edit_2.cshtml")]
    public partial class Views_TruckMileage_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Edit_2_cshtml()
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
WriteLiteral(" href=\"/TruckMileage/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 427), Tuple.Create("\'", 493)
, Tuple.Create(Tuple.Create("", 437), Tuple.Create("IQJSCall(\"/TruckMileage/Delete/?RecId=", 437), true)
             , Tuple.Create(Tuple.Create("", 475), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 475), false)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("\");", 490), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/TruckM" +
"ileage/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("TruckMileage", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1424)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1470), Tuple.Create("\'", 1494)
, Tuple.Create(Tuple.Create("", 1478), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1478), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"TruckMileage\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1600), Tuple.Create("\"", 1629)
, Tuple.Create(Tuple.Create("", 1608), Tuple.Create<System.Object, System.Int32>(Model.TrkMTruckValue
, 1608), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1675), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1683), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1740), Tuple.Create("\"", 1763)
, Tuple.Create(Tuple.Create("", 1748), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1748), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/TruckMileage/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2066), Tuple.Create("\"", 2172)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create("/TruckMileage/ViewHistory/?RecId=", 2073), true)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2106), false)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("&dt=", 2121), true)
, Tuple.Create(Tuple.Create("", 2125), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2125), false)
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
WriteLiteral(" id=\"TruckFuel/Mileage\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/TruckMileage_TruckFuelMileage.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2977), Tuple.Create("\"", 2992)
, Tuple.Create(Tuple.Create("", 2984), Tuple.Create("#", 2984), true)
, Tuple.Create(Tuple.Create("", 2985), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2985), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3208), Tuple.Create("\"", 3220)
, Tuple.Create(Tuple.Create("", 3213), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3213), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Add_2.cshtml")]
    public partial class Views_TruckMileage_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Truck Fuel / Mileage";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Truck Fuel / Mileage\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/TruckMileage/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TruckFuel/Mileage\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/TruckMileage_TruckFuelMileage.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_List_2.cshtml")]
    public partial class Views_TruckMileage_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.TruckMileage>>
    {
        public Views_TruckMileage_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Truck Fuel / Mileage List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Truck Fuel / Mileage List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 624)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/TruckMileage/ListFromQuery/?Clause=", 556), true)
                                                                        , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 592), false)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create("&Ord=", 607), true)
                                                                                            , Tuple.Create(Tuple.Create("", 612), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 612), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck</th><th>Date of Purchase</th><th>Litres purchased</th><th>" +
"Odometer (km)</th><th>Notes</th><th>Next reading (km)</th><th>Mpg</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1025), Tuple.Create("\"", 1071)
, Tuple.Create(Tuple.Create("", 1032), Tuple.Create("/TruckMileage/Load/?RecId=", 1032), true)
                    , Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1058), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMTruck.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1321), Tuple.Create("\"", 1414)
, Tuple.Create(Tuple.Create("", 1332), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMTruck/?RecId=", 1332), true)
                                                                         , Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1390), false)
, Tuple.Create(Tuple.Create("", 1403), Tuple.Create("\',$(this));", 1403), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMTruck\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.TrkMTruck.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1696), Tuple.Create("\"", 1793)
, Tuple.Create(Tuple.Create("", 1707), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchDate/?RecId=", 1707), true)
                                                                              , Tuple.Create(Tuple.Create("", 1769), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1769), false)
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create("\',$(this));", 1782), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1857), Tuple.Create("\'", 1903)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchDate.HTMLValue)
, 1865), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchLitre.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2095), Tuple.Create("\"", 2193)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchLitre/?RecId=", 2106), true)
                                                                               , Tuple.Create(Tuple.Create("", 2169), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2169), false)
, Tuple.Create(Tuple.Create("", 2182), Tuple.Create("\',$(this));", 2182), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchLitre\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2258), Tuple.Create("\'", 2305)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2266), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchLitre.HTMLValue)
, 2266), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMOdometer.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2495), Tuple.Create("\"", 2591)
, Tuple.Create(Tuple.Create("", 2506), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMOdometer/?RecId=", 2506), true)
                                                                             , Tuple.Create(Tuple.Create("", 2567), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2567), false)
, Tuple.Create(Tuple.Create("", 2580), Tuple.Create("\',$(this));", 2580), true)
);
WriteLiteral(" data-bound-name=\'TrkMOdometer\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2654), Tuple.Create("\'", 2699)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMOdometer.HTMLValue)
, 2662), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:43%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2887), Tuple.Create("\"", 2980)
, Tuple.Create(Tuple.Create("", 2898), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMNotes/?RecId=", 2898), true)
                                                                           , Tuple.Create(Tuple.Create("", 2956), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2956), false)
, Tuple.Create(Tuple.Create("", 2969), Tuple.Create("\',$(this));", 2969), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.TrkMNotes.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrkMNextReading.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                 Write(itm.TrkMMpg.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Edit_3.cshtml")]
    public partial class Views_TruckMileage_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Edit_3_cshtml()
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
WriteLiteral(" href=\"/TruckMileage/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 427), Tuple.Create("\'", 493)
, Tuple.Create(Tuple.Create("", 437), Tuple.Create("IQJSCall(\"/TruckMileage/Delete/?RecId=", 437), true)
             , Tuple.Create(Tuple.Create("", 475), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 475), false)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("\");", 490), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/TruckM" +
"ileage/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("TruckMileage", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1424)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1470), Tuple.Create("\'", 1494)
, Tuple.Create(Tuple.Create("", 1478), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1478), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"TruckMileage\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1600), Tuple.Create("\"", 1629)
, Tuple.Create(Tuple.Create("", 1608), Tuple.Create<System.Object, System.Int32>(Model.TrkMTruckValue
, 1608), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1675), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1683), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1740), Tuple.Create("\"", 1763)
, Tuple.Create(Tuple.Create("", 1748), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1748), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/TruckMileage/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2066), Tuple.Create("\"", 2172)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create("/TruckMileage/ViewHistory/?RecId=", 2073), true)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2106), false)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("&dt=", 2121), true)
, Tuple.Create(Tuple.Create("", 2125), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2125), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2764), Tuple.Create("\"", 2779)
, Tuple.Create(Tuple.Create("", 2771), Tuple.Create("#", 2771), true)
, Tuple.Create(Tuple.Create("", 2772), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2772), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2995), Tuple.Create("\"", 3007)
, Tuple.Create(Tuple.Create("", 3000), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3000), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_Add_3.cshtml")]
    public partial class Views_TruckMileage_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.TruckMileage>
    {
        public Views_TruckMileage_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Truck Fuel / Mileage";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Truck Fuel / Mileage\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/TruckMileage/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<TruckMileage>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/TruckMileage_List_3.cshtml")]
    public partial class Views_TruckMileage_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.TruckMileage>>
    {
        public Views_TruckMileage_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Truck Fuel / Mileage List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Truck Fuel / Mileage List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Truck Fuel / Mileage</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/TruckMileage/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 549), Tuple.Create("\"", 624)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("/TruckMileage/ListFromQuery/?Clause=", 556), true)
                                                                        , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 592), false)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create("&Ord=", 607), true)
                                                                                            , Tuple.Create(Tuple.Create("", 612), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 612), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Truck</th><th>Date of Purchase</th><th>Litres purchased</th><th>" +
"Odometer (km)</th><th>Notes</th><th>Next reading (km)</th><th>Mpg</th>\t\t</tr>\r\n\t" +
"</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1025), Tuple.Create("\"", 1071)
, Tuple.Create(Tuple.Create("", 1032), Tuple.Create("/TruckMileage/Load/?RecId=", 1032), true)
                    , Tuple.Create(Tuple.Create("", 1058), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1058), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMTruck.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1321), Tuple.Create("\"", 1414)
, Tuple.Create(Tuple.Create("", 1332), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMTruck/?RecId=", 1332), true)
                                                                         , Tuple.Create(Tuple.Create("", 1390), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1390), false)
, Tuple.Create(Tuple.Create("", 1403), Tuple.Create("\',$(this));", 1403), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMTruck\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.TrkMTruck.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1696), Tuple.Create("\"", 1793)
, Tuple.Create(Tuple.Create("", 1707), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchDate/?RecId=", 1707), true)
                                                                              , Tuple.Create(Tuple.Create("", 1769), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1769), false)
, Tuple.Create(Tuple.Create("", 1782), Tuple.Create("\',$(this));", 1782), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchDate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1857), Tuple.Create("\'", 1903)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchDate.HTMLValue)
, 1865), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMPurchLitre.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2095), Tuple.Create("\"", 2193)
, Tuple.Create(Tuple.Create("", 2106), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMPurchLitre/?RecId=", 2106), true)
                                                                               , Tuple.Create(Tuple.Create("", 2169), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2169), false)
, Tuple.Create(Tuple.Create("", 2182), Tuple.Create("\',$(this));", 2182), true)
);
WriteLiteral(" data-bound-name=\'TrkMPurchLitre\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2258), Tuple.Create("\'", 2305)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2266), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMPurchLitre.HTMLValue)
, 2266), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMOdometer.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2495), Tuple.Create("\"", 2591)
, Tuple.Create(Tuple.Create("", 2506), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMOdometer/?RecId=", 2506), true)
                                                                             , Tuple.Create(Tuple.Create("", 2567), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2567), false)
, Tuple.Create(Tuple.Create("", 2580), Tuple.Create("\',$(this));", 2580), true)
);
WriteLiteral(" data-bound-name=\'TrkMOdometer\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2654), Tuple.Create("\'", 2699)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrkMOdometer.HTMLValue)
, 2662), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrkMNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:43%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2887), Tuple.Create("\"", 2980)
, Tuple.Create(Tuple.Create("", 2898), Tuple.Create("javascript:IQAutoSave(\'/TruckMileage/SaveTrkMNotes/?RecId=", 2898), true)
                                                                           , Tuple.Create(Tuple.Create("", 2956), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2956), false)
, Tuple.Create(Tuple.Create("", 2969), Tuple.Create("\',$(this));", 2969), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'TrkMNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.TrkMNotes.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrkMNextReading.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                                 Write(itm.TrkMMpg.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
