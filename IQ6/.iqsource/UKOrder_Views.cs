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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_UKOrders.cshtml")]
    public partial class Views_UKOrder_UKOrders_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_UKOrders_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel101011", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.UKOTransp.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 341)
        , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOTransp.BackHEXColor) ? "" : "color:" + Model.UKOTransp.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 249), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 249), true)
);
WriteLiteral(">Haulier Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:240px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'UKOrders_UKOTransp\'");
                                     Write(Model.RecordLocked || !Model.UKOTransp.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOTransp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOTransp/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                Write(!Model.UKOTransp.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/UKOrder/AutoCompleteUKOTransp/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateUKOTransp\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateUKOTransp.ToString() != "" && Model.PopulateUKOTransp.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.UKOTransp.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateUKOTransp]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 2030), Tuple.Create("\'", 2102)
, Tuple.Create(Tuple.Create("", 2038), Tuple.Create("IQLabel101012", 2038), true)
, Tuple.Create(Tuple.Create(" ", 2051), Tuple.Create<System.Object, System.Int32>(!Model.UKOCollDate.LabelVisible ? " hide " : ""
, 2052), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2103), Tuple.Create("\'", 2314)
                             , Tuple.Create(Tuple.Create("", 2112), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOCollDate.BackHEXColor) ? "" : "color:" + Model.UKOCollDate.BackHEXColor + ";"
, 2112), false)
, Tuple.Create(Tuple.Create("", 2222), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2222), true)
);
WriteLiteral(">Collection Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'105\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:105px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOCollDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOCollDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                    Write(!Model.UKOCollDate.Visible ? " hide " : "");
WriteLiteral(" mandatory\'  ");
                                                                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCollDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOCollDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateUKOCollDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.UKOCollDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateUKOCollDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3293), Tuple.Create("\'", 3365)
, Tuple.Create(Tuple.Create("", 3301), Tuple.Create("IQLabel101013", 3301), true)
, Tuple.Create(Tuple.Create(" ", 3314), Tuple.Create<System.Object, System.Int32>(!Model.UKOCollFrom.LabelVisible ? " hide " : ""
, 3315), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3366), Tuple.Create("\'", 3578)
                                 , Tuple.Create(Tuple.Create("", 3375), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOCollFrom.BackHEXColor) ? "" : "color:" + Model.UKOCollFrom.BackHEXColor + ";"
, 3375), false)
, Tuple.Create(Tuple.Create("", 3485), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3485), true)
);
WriteLiteral(">Collection From</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOCollFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOCollFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.UKOCollFrom.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCollFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOCollFrom/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOCollFrom\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.UKOCollFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:240px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 4193), Tuple.Create("\'", 4262)
, Tuple.Create(Tuple.Create("", 4201), Tuple.Create("IQLabel101014", 4201), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 4214), Tuple.Create<System.Object, System.Int32>(!Model.UKODelTo.LabelVisible ? " hide " : ""
, 4215), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4263), Tuple.Create("\'", 4469)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 4272), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKODelTo.BackHEXColor) ? "" : "color:" + Model.UKODelTo.BackHEXColor + ";"
, 4272), false)
, Tuple.Create(Tuple.Create("", 4376), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 4376), true)
);
WriteLiteral(">Delivery To</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKODelTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKODelTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.UKODelTo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKODelTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKODelTo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKODelTo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.UKODelTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:240px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5059), Tuple.Create("\'", 5131)
, Tuple.Create(Tuple.Create("", 5067), Tuple.Create("IQLabel101015", 5067), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 5080), Tuple.Create<System.Object, System.Int32>(!Model.UKODelProof.LabelVisible ? " hide " : ""
, 5081), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5132), Tuple.Create("\'", 5344)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 5141), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKODelProof.BackHEXColor) ? "" : "color:" + Model.UKODelProof.BackHEXColor + ";"
, 5141), false)
, Tuple.Create(Tuple.Create("", 5251), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 5251), true)
);
WriteLiteral(">Proof of Delivery</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKODelProof\'");
WriteAttribute("class", Tuple.Create(" class=\'", 5427), Tuple.Create("\'", 5482)
, Tuple.Create(Tuple.Create("  ", 5435), Tuple.Create<System.Object, System.Int32>(!Model.UKODelProof.Visible ? " hide " : ""
, 5437), false)
);
WriteLiteral(" ");
                                                                                                          Write(Model.RecordLocked || !Model.UKODelProof.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKODelProof/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKODelProof/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:153px;\' name=\'" +
"PopulateUKODelProof\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateUKODelProof ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateUKODelProof\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateUKODelProof ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 6117), Tuple.Create("\'", 6184)
, Tuple.Create(Tuple.Create("", 6125), Tuple.Create("IQLabel101016", 6125), true)
, Tuple.Create(Tuple.Create(" ", 6138), Tuple.Create<System.Object, System.Int32>(!Model.UKOQty.LabelVisible ? " hide " : ""
, 6139), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6185), Tuple.Create("\'", 6387)
            , Tuple.Create(Tuple.Create("", 6194), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOQty.BackHEXColor) ? "" : "color:" + Model.UKOQty.BackHEXColor + ";"
, 6194), false)
, Tuple.Create(Tuple.Create("", 6294), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 6294), true)
);
WriteLiteral(">Quantity</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOQty\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOQty.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.UKOQty.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOQty/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOQty/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOQty\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.UKOQty.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6960), Tuple.Create("\'", 7030)
, Tuple.Create(Tuple.Create("", 6968), Tuple.Create("IQLabel101017", 6968), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 6981), Tuple.Create<System.Object, System.Int32>(!Model.UKOWeight.LabelVisible ? " hide " : ""
, 6982), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7031), Tuple.Create("\'", 7239)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 7040), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOWeight.BackHEXColor) ? "" : "color:" + Model.UKOWeight.BackHEXColor + ";"
, 7040), false)
, Tuple.Create(Tuple.Create("", 7146), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 7146), true)
);
WriteLiteral(">Weight</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOWeight\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOWeight.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.UKOWeight.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOWeight/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOWeight/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOWeight\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.UKOWeight.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7831), Tuple.Create("\'", 7899)
, Tuple.Create(Tuple.Create("", 7839), Tuple.Create("IQLabel101018", 7839), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 7852), Tuple.Create<System.Object, System.Int32>(!Model.UKODesc.LabelVisible ? " hide " : ""
, 7853), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7900), Tuple.Create("\'", 8104)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 7909), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKODesc.BackHEXColor) ? "" : "color:" + Model.UKODesc.BackHEXColor + ";"
, 7909), false)
, Tuple.Create(Tuple.Create("", 8011), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 8011), true)
);
WriteLiteral(">Description</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKODesc\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKODesc.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.UKODesc.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKODesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKODesc/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKODesc\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.UKODesc.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:280px;top:228px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 8687), Tuple.Create("\'", 8756)
, Tuple.Create(Tuple.Create("", 8695), Tuple.Create("IQLabel101019", 8695), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 8708), Tuple.Create<System.Object, System.Int32>(!Model.UKONotes.LabelVisible ? " hide " : ""
, 8709), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8757), Tuple.Create("\'", 8963)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 8766), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKONotes.BackHEXColor) ? "" : "color:" + Model.UKONotes.BackHEXColor + ";"
, 8766), false)
, Tuple.Create(Tuple.Create("", 8870), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:253px;", 8870), true)
);
WriteLiteral(">Comments</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'600\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:600px;top:253px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Comments\'");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKONotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                            Write(Model.RecordLocked || !Model.UKONotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKONotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKONotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.UKONotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateUKONotes\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.PopulateUKONotes);
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
WriteLiteral(" data-target=\"*[name=PopulateUKONotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10130), Tuple.Create("\'", 10196)
, Tuple.Create(Tuple.Create("", 10138), Tuple.Create("IQLabel101020", 10138), true)
, Tuple.Create(Tuple.Create(" ", 10151), Tuple.Create<System.Object, System.Int32>(!Model.UKOId.LabelVisible ? " hide " : ""
, 10152), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10197), Tuple.Create("\'", 10395)
                          , Tuple.Create(Tuple.Create("", 10206), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOId.BackHEXColor) ? "" : "color:" + Model.UKOId.BackHEXColor + ";"
, 10206), false)
, Tuple.Create(Tuple.Create("", 10304), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 10304), true)
);
WriteLiteral(">UK Order ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 10481), Tuple.Create("\'", 10543)
, Tuple.Create(Tuple.Create("", 10489), Tuple.Create("form-control", 10489), true)
, Tuple.Create(Tuple.Create("   ", 10501), Tuple.Create<System.Object, System.Int32>(!Model.UKOId.Visible ? " hide " : ""
, 10504), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                  Write(Model.UKOId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10906), Tuple.Create("\'", 10974)
, Tuple.Create(Tuple.Create("", 10914), Tuple.Create("IQLabel101031", 10914), true)
                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 10927), Tuple.Create<System.Object, System.Int32>(!Model.UKOCust.LabelVisible ? " hide " : ""
, 10928), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10975), Tuple.Create("\'", 11180)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 10984), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOCust.BackHEXColor) ? "" : "color:" + Model.UKOCust.BackHEXColor + ";"
, 10984), false)
, Tuple.Create(Tuple.Create("", 11086), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:28px;", 11086), true)
);
WriteLiteral(">Customer Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:21px;width:240px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'UKOrders_UKOCust\'");
                                   Write(Model.RecordLocked || !Model.UKOCust.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOCust/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                        Write(!Model.UKOCust.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/UKOrder/AutoCompleteUKOCust/");
                                              Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateUKOCust\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateUKOCust.ToString() != "" && Model.PopulateUKOCust.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.UKOCust.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateUKOCust]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 12848), Tuple.Create("\'", 12919)
, Tuple.Create(Tuple.Create("", 12856), Tuple.Create("IQLabel101032", 12856), true)
, Tuple.Create(Tuple.Create(" ", 12869), Tuple.Create<System.Object, System.Int32>(!Model.UKOCustRef.LabelVisible ? " hide " : ""
, 12870), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12920), Tuple.Create("\'", 13131)
                           , Tuple.Create(Tuple.Create("", 12929), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOCustRef.BackHEXColor) ? "" : "color:" + Model.UKOCustRef.BackHEXColor + ";"
, 12929), false)
, Tuple.Create(Tuple.Create("", 13037), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:53px;", 13037), true)
);
WriteLiteral(">Customer Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOCustRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOCustRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.UKOCustRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCustRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOCustRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOCustRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.UKOCustRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:120px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 13735), Tuple.Create("\'", 13809)
, Tuple.Create(Tuple.Create("", 13743), Tuple.Create("IQLabel101033", 13743), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 13756), Tuple.Create<System.Object, System.Int32>(!Model.UKOChargeCust.LabelVisible ? " hide " : ""
, 13757), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13810), Tuple.Create("\'", 14027)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 13819), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOChargeCust.BackHEXColor) ? "" : "color:" + Model.UKOChargeCust.BackHEXColor + ";"
, 13819), false)
, Tuple.Create(Tuple.Create("", 13933), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:78px;", 13933), true)
);
WriteLiteral(">Charge Customer</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOChargeCust\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOChargeCust.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.UKOChargeCust.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOChargeCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOChargeCust/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOChargeCust\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.UKOChargeCust.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:120px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 14655), Tuple.Create("\'", 14726)
, Tuple.Create(Tuple.Create("", 14663), Tuple.Create("IQLabel101034", 14663), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 14676), Tuple.Create<System.Object, System.Int32>(!Model.UKOFTLCost.LabelVisible ? " hide " : ""
, 14677), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14727), Tuple.Create("\'", 14939)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 14736), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOFTLCost.BackHEXColor) ? "" : "color:" + Model.UKOFTLCost.BackHEXColor + ";"
, 14736), false)
, Tuple.Create(Tuple.Create("", 14844), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:103px;", 14844), true)
);
WriteLiteral(">Cost to FTL</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOFTLCost\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOFTLCost.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.UKOFTLCost.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOFTLCost/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOFTLCost/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOFTLCost\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.UKOFTLCost.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:120px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 15543), Tuple.Create("\'", 15612)
, Tuple.Create(Tuple.Create("", 15551), Tuple.Create("IQLabel101035", 15551), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 15564), Tuple.Create<System.Object, System.Int32>(!Model.UKOJobNo.LabelVisible ? " hide " : ""
, 15565), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15613), Tuple.Create("\'", 15821)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 15622), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOJobNo.BackHEXColor) ? "" : "color:" + Model.UKOJobNo.BackHEXColor + ";"
, 15622), false)
, Tuple.Create(Tuple.Create("", 15726), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:128px;", 15726), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOJobNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.UKOJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                               Write(!Model.UKOJobNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOJobNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateUKOJobNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.UKOJobNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:120px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 16419), Tuple.Create("\'", 16491)
, Tuple.Create(Tuple.Create("", 16427), Tuple.Create("IQLabel101036", 16427), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 16440), Tuple.Create<System.Object, System.Int32>(!Model.UKOInvoiced.LabelVisible ? " hide " : ""
, 16441), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16492), Tuple.Create("\'", 16706)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 16501), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOInvoiced.BackHEXColor) ? "" : "color:" + Model.UKOInvoiced.BackHEXColor + ";"
, 16501), false)
, Tuple.Create(Tuple.Create("", 16611), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:153px;", 16611), true)
);
WriteLiteral(">Invoiced</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOInvoiced\'");
WriteAttribute("class", Tuple.Create(" class=\'", 16780), Tuple.Create("\'", 16835)
, Tuple.Create(Tuple.Create("  ", 16788), Tuple.Create<System.Object, System.Int32>(!Model.UKOInvoiced.Visible ? " hide " : ""
, 16790), false)
);
WriteLiteral(" ");
                                                                                                          Write(Model.RecordLocked || !Model.UKOInvoiced.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOInvoiced/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOInvoiced/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:500px;height:16px;width:16px;top:153px;\' name=\'" +
"PopulateUKOInvoiced\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateUKOInvoiced ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateUKOInvoiced\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateUKOInvoiced ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 17470), Tuple.Create("\'", 17543)
, Tuple.Create(Tuple.Create("", 17478), Tuple.Create("IQLabel101037", 17478), true)
, Tuple.Create(Tuple.Create(" ", 17491), Tuple.Create<System.Object, System.Int32>(!Model.UKOCreatedBy.LabelVisible ? " hide " : ""
, 17492), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17544), Tuple.Create("\'", 17760)
                 , Tuple.Create(Tuple.Create("", 17553), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.UKOCreatedBy.BackHEXColor) ? "" : "color:" + Model.UKOCreatedBy.BackHEXColor + ";"
, 17553), false)
, Tuple.Create(Tuple.Create("", 17665), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
"0px;top:178px;", 17665), true)
);
WriteLiteral(">Created By</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:21px;width:120px;top:178px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'UKOrders_UKOCreatedBy\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 17977), Tuple.Create("\'", 18047)
, Tuple.Create(Tuple.Create("", 17985), Tuple.Create("form-control", 17985), true)
, Tuple.Create(Tuple.Create("    ", 17997), Tuple.Create<System.Object, System.Int32>(!Model.UKOCreatedBy.Visible ? " hide " : ""
, 18001), false)
);
WriteLiteral("  ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCreatedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/UKOrder/CallbackUKOCreatedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateUKOCreatedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.UKOCreatedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 18393), Tuple.Create("\'", 18414)
, Tuple.Create(Tuple.Create("", 18401), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 18401), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateUKOCreatedBy.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateUKOCreatedBy]\"");
WriteLiteral(" data-url=\"/Staff/Load/?StfId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Staff/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Staff</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Edit_1.cshtml")]
    public partial class Views_UKOrder_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Edit_1_cshtml()
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
WriteLiteral(" href=\"/UKOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add UK Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/UKOrder/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/UKOrde" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("UKOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"UKOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1579)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.UKOIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1625), Tuple.Create("\"", 1648)
, Tuple.Create(Tuple.Create("", 1633), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1633), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1690), Tuple.Create("\"", 1713)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1698), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/UKOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2011), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("/UKOrder/ViewHistory/?RecId=", 2018), true)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2046), false)
, Tuple.Create(Tuple.Create("", 2061), Tuple.Create("&dt=", 2061), true)
, Tuple.Create(Tuple.Create("", 2065), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2065), false)
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
WriteLiteral(" id=\"UKOrders\"");
WriteLiteral(" style=\'position:relative;height:354px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/UKOrder_UKOrders.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2895), Tuple.Create("\"", 2910)
, Tuple.Create(Tuple.Create("", 2902), Tuple.Create("#", 2902), true)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2903), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3126), Tuple.Create("\"", 3138)
, Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3131), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Add_1.cshtml")]
    public partial class Views_UKOrder_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add UK Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add UK Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/UKOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"UKOrders\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/UKOrder_UKOrders.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_List_1.cshtml")]
    public partial class Views_UKOrder_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.UKOrder>>
    {
        public Views_UKOrder_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "UK Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"UK Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add UK Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/UKOrder/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>UK Order ID</th><th>Collection Date</th><th>Customer Name</th><t" +
"h>Collection From</th><th>Delivery To</th><th>Haulier Name</th>\t\t</tr>\r\n\t</thead" +
">\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1006)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/UKOrder/Load/?RecId=", 972), true)
                , Tuple.Create(Tuple.Create("", 993), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 993), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.UKOId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1348), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollDate/?RecId=", 1359), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 1414), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1414), false)
, Tuple.Create(Tuple.Create("", 1427), Tuple.Create("\',$(this));", 1427), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'UKOCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1553)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollDate.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1784), Tuple.Create("\"", 1870)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCust/?RecId=", 1795), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1846), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1846), false)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create("\',$(this));", 1859), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.UKOCust.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2166), Tuple.Create("\"", 2256)
, Tuple.Create(Tuple.Create("", 2177), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollFrom/?RecId=", 2177), true)
                                                                        , Tuple.Create(Tuple.Create("", 2232), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2232), false)
, Tuple.Create(Tuple.Create("", 2245), Tuple.Create("\',$(this));", 2245), true)
);
WriteLiteral(" data-bound-name=\'UKOCollFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2318), Tuple.Create("\'", 2362)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 2326), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollFrom.HTMLValue)
, 2326), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKODelTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2549), Tuple.Create("\"", 2636)
, Tuple.Create(Tuple.Create("", 2560), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKODelTo/?RecId=", 2560), true)
                                                                     , Tuple.Create(Tuple.Create("", 2612), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2612), false)
, Tuple.Create(Tuple.Create("", 2625), Tuple.Create("\',$(this));", 2625), true)
);
WriteLiteral(" data-bound-name=\'UKODelTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2695), Tuple.Create("\'", 2736)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKODelTo.HTMLValue)
, 2703), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2971), Tuple.Create("\"", 3059)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOTransp/?RecId=", 2982), true)
                                                                                                                     , Tuple.Create(Tuple.Create("", 3035), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3035), false)
, Tuple.Create(Tuple.Create("", 3048), Tuple.Create("\',$(this));", 3048), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.UKOTransp.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Edit_2.cshtml")]
    public partial class Views_UKOrder_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Edit_2_cshtml()
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
WriteLiteral(" href=\"/UKOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add UK Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/UKOrder/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/UKOrde" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("UKOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"UKOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1579)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.UKOIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1625), Tuple.Create("\"", 1648)
, Tuple.Create(Tuple.Create("", 1633), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1633), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1690), Tuple.Create("\"", 1713)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1698), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/UKOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2011), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("/UKOrder/ViewHistory/?RecId=", 2018), true)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2046), false)
, Tuple.Create(Tuple.Create("", 2061), Tuple.Create("&dt=", 2061), true)
, Tuple.Create(Tuple.Create("", 2065), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2065), false)
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
WriteLiteral(" id=\"UKOrders\"");
WriteLiteral(" style=\'position:relative;height:354px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/UKOrder_UKOrders.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2895), Tuple.Create("\"", 2910)
, Tuple.Create(Tuple.Create("", 2902), Tuple.Create("#", 2902), true)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2903), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3126), Tuple.Create("\"", 3138)
, Tuple.Create(Tuple.Create("", 3131), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3131), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Add_2.cshtml")]
    public partial class Views_UKOrder_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add UK Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add UK Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/UKOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"UKOrders\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/UKOrder_UKOrders.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_List_2.cshtml")]
    public partial class Views_UKOrder_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.UKOrder>>
    {
        public Views_UKOrder_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "UK Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"UK Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add UK Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/UKOrder/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>UK Order ID</th><th>Collection Date</th><th>Customer Name</th><t" +
"h>Collection From</th><th>Delivery To</th><th>Haulier Name</th>\t\t</tr>\r\n\t</thead" +
">\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1006)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/UKOrder/Load/?RecId=", 972), true)
                , Tuple.Create(Tuple.Create("", 993), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 993), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.UKOId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1348), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollDate/?RecId=", 1359), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 1414), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1414), false)
, Tuple.Create(Tuple.Create("", 1427), Tuple.Create("\',$(this));", 1427), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'UKOCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1553)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollDate.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1784), Tuple.Create("\"", 1870)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCust/?RecId=", 1795), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1846), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1846), false)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create("\',$(this));", 1859), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.UKOCust.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2166), Tuple.Create("\"", 2256)
, Tuple.Create(Tuple.Create("", 2177), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollFrom/?RecId=", 2177), true)
                                                                        , Tuple.Create(Tuple.Create("", 2232), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2232), false)
, Tuple.Create(Tuple.Create("", 2245), Tuple.Create("\',$(this));", 2245), true)
);
WriteLiteral(" data-bound-name=\'UKOCollFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2318), Tuple.Create("\'", 2362)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 2326), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollFrom.HTMLValue)
, 2326), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKODelTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2549), Tuple.Create("\"", 2636)
, Tuple.Create(Tuple.Create("", 2560), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKODelTo/?RecId=", 2560), true)
                                                                     , Tuple.Create(Tuple.Create("", 2612), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2612), false)
, Tuple.Create(Tuple.Create("", 2625), Tuple.Create("\',$(this));", 2625), true)
);
WriteLiteral(" data-bound-name=\'UKODelTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2695), Tuple.Create("\'", 2736)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKODelTo.HTMLValue)
, 2703), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2971), Tuple.Create("\"", 3059)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOTransp/?RecId=", 2982), true)
                                                                                                                     , Tuple.Create(Tuple.Create("", 3035), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3035), false)
, Tuple.Create(Tuple.Create("", 3048), Tuple.Create("\',$(this));", 3048), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.UKOTransp.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Edit_3.cshtml")]
    public partial class Views_UKOrder_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Edit_3_cshtml()
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
WriteLiteral(" href=\"/UKOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add UK Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 406), Tuple.Create("\'", 467)
, Tuple.Create(Tuple.Create("", 416), Tuple.Create("IQJSCall(\"/UKOrder/Delete/?RecId=", 416), true)
        , Tuple.Create(Tuple.Create("", 449), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 449), false)
, Tuple.Create(Tuple.Create("", 464), Tuple.Create("\");", 464), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/UKOrde" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("UKOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1361), Tuple.Create("\'", 1383)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1369), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1429), Tuple.Create("\'", 1453)
, Tuple.Create(Tuple.Create("", 1437), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1437), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"UKOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1579)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.UKOIdValue
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1625), Tuple.Create("\"", 1648)
, Tuple.Create(Tuple.Create("", 1633), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1633), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1690), Tuple.Create("\"", 1713)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1698), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/UKOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2011), Tuple.Create("\"", 2112)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("/UKOrder/ViewHistory/?RecId=", 2018), true)
, Tuple.Create(Tuple.Create("", 2046), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2046), false)
, Tuple.Create(Tuple.Create("", 2061), Tuple.Create("&dt=", 2061), true)
, Tuple.Create(Tuple.Create("", 2065), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2065), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2704), Tuple.Create("\"", 2719)
, Tuple.Create(Tuple.Create("", 2711), Tuple.Create("#", 2711), true)
, Tuple.Create(Tuple.Create("", 2712), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2712), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2935), Tuple.Create("\"", 2947)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2940), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_Add_3.cshtml")]
    public partial class Views_UKOrder_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.UKOrder>
    {
        public Views_UKOrder_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add UK Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add UK Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/UKOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<UKOrder>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/UKOrder_List_3.cshtml")]
    public partial class Views_UKOrder_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.UKOrder>>
    {
        public Views_UKOrder_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "UK Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"UK Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add UK Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/UKOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 501), Tuple.Create("\"", 571)
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/UKOrder/ListFromQuery/?Clause=", 508), true)
                                                                   , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 539), false)
, Tuple.Create(Tuple.Create("", 554), Tuple.Create("&Ord=", 554), true)
                                                                                       , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 559), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>UK Order ID</th><th>Collection Date</th><th>Customer Name</th><t" +
"h>Collection From</th><th>Delivery To</th><th>Haulier Name</th>\t\t</tr>\r\n\t</thead" +
">\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1006)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/UKOrder/Load/?RecId=", 972), true)
                , Tuple.Create(Tuple.Create("", 993), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 993), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.UKOId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1348), Tuple.Create("\"", 1438)
, Tuple.Create(Tuple.Create("", 1359), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollDate/?RecId=", 1359), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 1414), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1414), false)
, Tuple.Create(Tuple.Create("", 1427), Tuple.Create("\',$(this));", 1427), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'UKOCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1553)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollDate.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1784), Tuple.Create("\"", 1870)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCust/?RecId=", 1795), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1846), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1846), false)
, Tuple.Create(Tuple.Create("", 1859), Tuple.Create("\',$(this));", 1859), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.UKOCust.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOCollFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2166), Tuple.Create("\"", 2256)
, Tuple.Create(Tuple.Create("", 2177), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOCollFrom/?RecId=", 2177), true)
                                                                        , Tuple.Create(Tuple.Create("", 2232), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2232), false)
, Tuple.Create(Tuple.Create("", 2245), Tuple.Create("\',$(this));", 2245), true)
);
WriteLiteral(" data-bound-name=\'UKOCollFrom\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2318), Tuple.Create("\'", 2362)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 2326), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKOCollFrom.HTMLValue)
, 2326), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKODelTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2549), Tuple.Create("\"", 2636)
, Tuple.Create(Tuple.Create("", 2560), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKODelTo/?RecId=", 2560), true)
                                                                     , Tuple.Create(Tuple.Create("", 2612), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2612), false)
, Tuple.Create(Tuple.Create("", 2625), Tuple.Create("\',$(this));", 2625), true)
);
WriteLiteral(" data-bound-name=\'UKODelTo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2695), Tuple.Create("\'", 2736)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.UKODelTo.HTMLValue)
, 2703), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.UKOTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/UKOrder/AutoCompleteUKOTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2971), Tuple.Create("\"", 3059)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("javascript:IQAutoSave(\'/UKOrder/SaveUKOTransp/?RecId=", 2982), true)
                                                                                                                     , Tuple.Create(Tuple.Create("", 3035), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3035), false)
, Tuple.Create(Tuple.Create("", 3048), Tuple.Create("\',$(this));", 3048), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'UKOTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.UKOTransp.HTMLValue));
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
