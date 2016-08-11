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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_ShippingDocuments.cshtml")]
    public partial class Views_ShipDoc_ShippingDocuments_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_ShippingDocuments_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 132)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel103211", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.SDSuppId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 133), Tuple.Create("\'", 338)
       , Tuple.Create(Tuple.Create("", 142), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSuppId.BackHEXColor) ? "" : "color:" + Model.SDSuppId.BackHEXColor + ";"
, 142), false)
, Tuple.Create(Tuple.Create("", 246), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 246), true)
);
WriteLiteral(">Supplier ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDSuppId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDSuppId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SDSuppId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSuppId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSuppId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDSuppId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.SDSuppId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 935), Tuple.Create("\'", 1002)
, Tuple.Create(Tuple.Create("", 943), Tuple.Create("IQLabel103212", 943), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 956), Tuple.Create<System.Object, System.Int32>(!Model.SDSupp.LabelVisible ? " hide " : ""
, 957), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1003), Tuple.Create("\'", 1204)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1012), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSupp.BackHEXColor) ? "" : "color:" + Model.SDSupp.BackHEXColor + ";"
, 1012), false)
, Tuple.Create(Tuple.Create("", 1112), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1112), true)
);
WriteLiteral(">Supplier Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'ShippingDocuments_SDSupp\'");
                                           Write(Model.RecordLocked || !Model.SDSupp.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSupp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSupp/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.SDSupp.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/ShipDoc/AutoCompleteSDSupp/");
                                             Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateSDSupp\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateSDSupp.ToString() != "" && Model.PopulateSDSupp.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.SDSupp.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateSDSupp]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 2870), Tuple.Create("\'", 2941)
, Tuple.Create(Tuple.Create("", 2878), Tuple.Create("IQLabel103213", 2878), true)
, Tuple.Create(Tuple.Create(" ", 2891), Tuple.Create<System.Object, System.Int32>(!Model.SDSuppAddr.LabelVisible ? " hide " : ""
, 2892), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2942), Tuple.Create("\'", 3151)
                            , Tuple.Create(Tuple.Create("", 2951), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSuppAddr.BackHEXColor) ? "" : "color:" + Model.SDSuppAddr.BackHEXColor + ";"
, 2951), false)
, Tuple.Create(Tuple.Create("", 3059), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3059), true)
);
WriteLiteral(">Supplier Address</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:160px;top:78px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Supplier Address\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDSuppAddr\'");
WriteLiteral(" ");
                                                                                                                                                                                                                           Write(Model.RecordLocked || !Model.SDSuppAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSuppAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSuppAddr/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(!Model.SDSuppAddr.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDSuppAddr\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PopulateSDSuppAddr);
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
WriteLiteral(" data-target=\"*[name=PopulateSDSuppAddr]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4358), Tuple.Create("\'", 4430)
, Tuple.Create(Tuple.Create("", 4366), Tuple.Create("IQLabel103216", 4366), true)
, Tuple.Create(Tuple.Create(" ", 4379), Tuple.Create<System.Object, System.Int32>(!Model.SDSuppVATNo.LabelVisible ? " hide " : ""
, 4380), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4431), Tuple.Create("\'", 4643)
                                 , Tuple.Create(Tuple.Create("", 4440), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSuppVATNo.BackHEXColor) ? "" : "color:" + Model.SDSuppVATNo.BackHEXColor + ";"
, 4440), false)
, Tuple.Create(Tuple.Create("", 4550), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 4550), true)
);
WriteLiteral(">Supplier VAT No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDSuppVATNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDSuppVATNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SDSuppVATNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSuppVATNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSuppVATNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDSuppVATNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.SDSuppVATNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5267), Tuple.Create("\'", 5337)
, Tuple.Create(Tuple.Create("", 5275), Tuple.Create("IQLabel103217", 5275), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 5288), Tuple.Create<System.Object, System.Int32>(!Model.SDRecipId.LabelVisible ? " hide " : ""
, 5289), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5338), Tuple.Create("\'", 5546)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 5347), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRecipId.BackHEXColor) ? "" : "color:" + Model.SDRecipId.BackHEXColor + ";"
, 5347), false)
, Tuple.Create(Tuple.Create("", 5453), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 5453), true)
);
WriteLiteral(">Recipient ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDRecipId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDRecipId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.SDRecipId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecipId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRecipId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDRecipId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.SDRecipId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6152), Tuple.Create("\'", 6220)
, Tuple.Create(Tuple.Create("", 6160), Tuple.Create("IQLabel103218", 6160), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 6173), Tuple.Create<System.Object, System.Int32>(!Model.SDRecip.LabelVisible ? " hide " : ""
, 6174), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6221), Tuple.Create("\'", 6425)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 6230), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRecip.BackHEXColor) ? "" : "color:" + Model.SDRecip.BackHEXColor + ";"
, 6230), false)
, Tuple.Create(Tuple.Create("", 6332), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 6332), true)
);
WriteLiteral(">Recipient Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:203px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'ShippingDocuments_SDRecip\'");
                                            Write(Model.RecordLocked || !Model.SDRecip.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecip/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRecip/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                 Write(!Model.SDRecip.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/ShipDoc/AutoCompleteSDRecip/");
                                              Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateSDRecip\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateSDRecip.ToString() != "" && Model.PopulateSDRecip.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.SDRecip.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateSDRecip]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 8104), Tuple.Create("\'", 8176)
, Tuple.Create(Tuple.Create("", 8112), Tuple.Create("IQLabel103219", 8112), true)
, Tuple.Create(Tuple.Create(" ", 8125), Tuple.Create<System.Object, System.Int32>(!Model.SDRecipAddr.LabelVisible ? " hide " : ""
, 8126), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8177), Tuple.Create("\'", 8389)
                             , Tuple.Create(Tuple.Create("", 8186), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRecipAddr.BackHEXColor) ? "" : "color:" + Model.SDRecipAddr.BackHEXColor + ";"
, 8186), false)
, Tuple.Create(Tuple.Create("", 8296), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 8296), true)
);
WriteLiteral(">Recipient Address</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:160px;top:228px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Recipient Address\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDRecipAddr\'");
WriteLiteral(" ");
                                                                                                                                                                                                                                 Write(Model.RecordLocked || !Model.SDRecipAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecipAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRecipAddr/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(!Model.SDRecipAddr.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDRecipAddr\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.PopulateSDRecipAddr);
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
WriteLiteral(" data-target=\"*[name=PopulateSDRecipAddr]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9607), Tuple.Create("\'", 9680)
, Tuple.Create(Tuple.Create("", 9615), Tuple.Create("IQLabel103222", 9615), true)
, Tuple.Create(Tuple.Create(" ", 9628), Tuple.Create<System.Object, System.Int32>(!Model.SDRecipVATNo.LabelVisible ? " hide " : ""
, 9629), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9681), Tuple.Create("\'", 9895)
                                  , Tuple.Create(Tuple.Create("", 9690), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRecipVATNo.BackHEXColor) ? "" : "color:" + Model.SDRecipVATNo.BackHEXColor + ";"
, 9690), false)
, Tuple.Create(Tuple.Create("", 9802), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:303px;", 9802), true)
);
WriteLiteral(">Recipient VAT No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDRecipVATNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDRecipVATNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.SDRecipVATNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecipVATNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRecipVATNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDRecipVATNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.SDRecipVATNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:303px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 10527), Tuple.Create("\'", 10598)
, Tuple.Create(Tuple.Create("", 10535), Tuple.Create("IQLabel103223", 10535), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 10548), Tuple.Create<System.Object, System.Int32>(!Model.SDTransRef.LabelVisible ? " hide " : ""
, 10549), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10599), Tuple.Create("\'", 10809)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 10608), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDTransRef.BackHEXColor) ? "" : "color:" + Model.SDTransRef.BackHEXColor + ";"
, 10608), false)
, Tuple.Create(Tuple.Create("", 10716), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:328px;", 10716), true)
);
WriteLiteral(">Transaction Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDTransRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDTransRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDTransRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDTransRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDTransRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDTransRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDTransRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:328px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 11426), Tuple.Create("\'", 11494)
, Tuple.Create(Tuple.Create("", 11434), Tuple.Create("IQLabel103224", 11434), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 11447), Tuple.Create<System.Object, System.Int32>(!Model.SDVehNo.LabelVisible ? " hide " : ""
, 11448), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11495), Tuple.Create("\'", 11699)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 11504), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDVehNo.BackHEXColor) ? "" : "color:" + Model.SDVehNo.BackHEXColor + ";"
, 11504), false)
, Tuple.Create(Tuple.Create("", 11606), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:353px;", 11606), true)
);
WriteLiteral(">Vehicle / Trailer No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDVehNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDVehNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.SDVehNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDVehNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDVehNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDVehNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.SDVehNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:353px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 12300), Tuple.Create("\'", 12368)
, Tuple.Create(Tuple.Create("", 12308), Tuple.Create("IQLabel103225", 12308), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 12321), Tuple.Create<System.Object, System.Int32>(!Model.SDRefNo.LabelVisible ? " hide " : ""
, 12322), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12369), Tuple.Create("\'", 12573)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 12378), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRefNo.BackHEXColor) ? "" : "color:" + Model.SDRefNo.BackHEXColor + ";"
, 12378), false)
, Tuple.Create(Tuple.Create("", 12480), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:378px;", 12480), true)
);
WriteLiteral(">Reference Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDRefNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDRefNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.SDRefNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRefNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRefNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDRefNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.SDRefNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:378px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 13170), Tuple.Create("\'", 13244)
, Tuple.Create(Tuple.Create("", 13178), Tuple.Create("IQLabel103226", 13178), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 13191), Tuple.Create<System.Object, System.Int32>(!Model.SDDeclareDate.LabelVisible ? " hide " : ""
, 13192), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13245), Tuple.Create("\'", 13461)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 13254), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDeclareDate.BackHEXColor) ? "" : "color:" + Model.SDDeclareDate.BackHEXColor + ";"
, 13254), false)
, Tuple.Create(Tuple.Create("", 13368), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:403px;", 13368), true)
);
WriteLiteral(">Declaration Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:403px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDeclareDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDDeclareDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                  Write(!Model.SDDeclareDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDeclareDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDeclareDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateSDDeclareDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.SDDeclareDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateSDDeclareDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 14452), Tuple.Create("\'", 14523)
, Tuple.Create(Tuple.Create("", 14460), Tuple.Create("IQLabel103227", 14460), true)
, Tuple.Create(Tuple.Create(" ", 14473), Tuple.Create<System.Object, System.Int32>(!Model.SDDelPlace.LabelVisible ? " hide " : ""
, 14474), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14524), Tuple.Create("\'", 14734)
                               , Tuple.Create(Tuple.Create("", 14533), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDelPlace.BackHEXColor) ? "" : "color:" + Model.SDDelPlace.BackHEXColor + ";"
, 14533), false)
, Tuple.Create(Tuple.Create("", 14641), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:428px;", 14641), true)
);
WriteLiteral(">Place of delivery</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDelPlace\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDDelPlace.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDDelPlace.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDelPlace/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDelPlace/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDDelPlace\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDDelPlace.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:428px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 15353), Tuple.Create("\'", 15424)
, Tuple.Create(Tuple.Create("", 15361), Tuple.Create("IQLabel103228", 15361), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 15374), Tuple.Create<System.Object, System.Int32>(!Model.SDSignedBy.LabelVisible ? " hide " : ""
, 15375), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15425), Tuple.Create("\'", 15635)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 15434), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSignedBy.BackHEXColor) ? "" : "color:" + Model.SDSignedBy.BackHEXColor + ";"
, 15434), false)
, Tuple.Create(Tuple.Create("", 15542), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:453px;", 15542), true)
);
WriteLiteral(">Signed by</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:453px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDSignedBy\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDSignedBy.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.SDSignedBy.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSignedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSignedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateSDSignedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.SDSignedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 16324), Tuple.Create("\'", 16345)
, Tuple.Create(Tuple.Create("", 16332), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 16332), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateSDSignedBy.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateSDSignedBy]\"");
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
WriteLiteral(" />View All Staff</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 17221), Tuple.Create("\'", 17296)
, Tuple.Create(Tuple.Create("", 17229), Tuple.Create("IQLabel103229", 17229), true)
, Tuple.Create(Tuple.Create(" ", 17242), Tuple.Create<System.Object, System.Int32>(!Model.SDSignedByText.LabelVisible ? " hide " : ""
, 17243), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17297), Tuple.Create("\'", 17515)
                               , Tuple.Create(Tuple.Create("", 17306), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDSignedByText.BackHEXColor) ? "" : "color:" + Model.SDSignedByText.BackHEXColor + ";"
, 17306), false)
, Tuple.Create(Tuple.Create("", 17422), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:478px;", 17422), true)
);
WriteLiteral(">Signed by text</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDSignedByText\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDSignedByText.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.SDSignedByText.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSignedByText/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDSignedByText/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDSignedByText\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.SDSignedByText.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:478px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 18159), Tuple.Create("\'", 18224)
, Tuple.Create(Tuple.Create("", 18167), Tuple.Create("IQLabel103230", 18167), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 18180), Tuple.Create<System.Object, System.Int32>(!Model.SDId.LabelVisible ? " hide " : ""
, 18181), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 18225), Tuple.Create("\'", 18421)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 18234), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDId.BackHEXColor) ? "" : "color:" + Model.SDId.BackHEXColor + ";"
, 18234), false)
, Tuple.Create(Tuple.Create("", 18330), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 18330), true)
);
WriteLiteral(">Document ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 18515), Tuple.Create("\'", 18576)
, Tuple.Create(Tuple.Create("", 18523), Tuple.Create("form-control", 18523), true)
, Tuple.Create(Tuple.Create("   ", 18535), Tuple.Create<System.Object, System.Int32>(!Model.SDId.Visible ? " hide " : ""
, 18538), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDId\' value=\'");
                                                                                                                                                                                                                                                                                                                                              Write(Model.SDId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 18935), Tuple.Create("\'", 19002)
, Tuple.Create(Tuple.Create("", 18943), Tuple.Create("IQLabel103231", 18943), true)
                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 18956), Tuple.Create<System.Object, System.Int32>(!Model.SDDesc.LabelVisible ? " hide " : ""
, 18957), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19003), Tuple.Create("\'", 19206)
                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 19012), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDesc.BackHEXColor) ? "" : "color:" + Model.SDDesc.BackHEXColor + ";"
, 19012), false)
, Tuple.Create(Tuple.Create("", 19112), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 19112), true)
);
WriteLiteral(">Description (1)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:46px;width:160px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description (1)\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.SDDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(!Model.SDDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDDesc\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.PopulateSDDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateSDDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 20379), Tuple.Create("\'", 20451)
, Tuple.Create(Tuple.Create("", 20387), Tuple.Create("IQLabel103233", 20387), true)
, Tuple.Create(Tuple.Create(" ", 20400), Tuple.Create<System.Object, System.Int32>(!Model.SDCommCode1.LabelVisible ? " hide " : ""
, 20401), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20452), Tuple.Create("\'", 20665)
                                , Tuple.Create(Tuple.Create("", 20461), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCommCode1.BackHEXColor) ? "" : "color:" + Model.SDCommCode1.BackHEXColor + ";"
, 20461), false)
, Tuple.Create(Tuple.Create("", 20571), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 20571), true)
);
WriteLiteral(">Comm Code (1)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCommCode1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDCommCode1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SDCommCode1.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCommCode1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCommCode1/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDCommCode1\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.SDCommCode1.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 21286), Tuple.Create("\'", 21353)
, Tuple.Create(Tuple.Create("", 21294), Tuple.Create("IQLabel103234", 21294), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 21307), Tuple.Create<System.Object, System.Int32>(!Model.SDQty1.LabelVisible ? " hide " : ""
, 21308), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21354), Tuple.Create("\'", 21558)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 21363), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDQty1.BackHEXColor) ? "" : "color:" + Model.SDQty1.BackHEXColor + ";"
, 21363), false)
, Tuple.Create(Tuple.Create("", 21463), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:103px;", 21463), true)
);
WriteLiteral(">Quantity (1)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDQty1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDQty1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.SDQty1.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDQty1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDQty1/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDQty1\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.SDQty1.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 22143), Tuple.Create("\'", 22214)
, Tuple.Create(Tuple.Create("", 22151), Tuple.Create("IQLabel103235", 22151), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 22164), Tuple.Create<System.Object, System.Int32>(!Model.SDGWeight1.LabelVisible ? " hide " : ""
, 22165), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 22215), Tuple.Create("\'", 22427)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 22224), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDGWeight1.BackHEXColor) ? "" : "color:" + Model.SDGWeight1.BackHEXColor + ";"
, 22224), false)
, Tuple.Create(Tuple.Create("", 22332), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:128px;", 22332), true)
);
WriteLiteral(">Gross weight (1)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDGWeight1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDGWeight1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDGWeight1.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDGWeight1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDGWeight1/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDGWeight1\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDGWeight1.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 23044), Tuple.Create("\'", 23115)
, Tuple.Create(Tuple.Create("", 23052), Tuple.Create("IQLabel103236", 23052), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 23065), Tuple.Create<System.Object, System.Int32>(!Model.SDNWeight1.LabelVisible ? " hide " : ""
, 23066), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23116), Tuple.Create("\'", 23328)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 23125), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDNWeight1.BackHEXColor) ? "" : "color:" + Model.SDNWeight1.BackHEXColor + ";"
, 23125), false)
, Tuple.Create(Tuple.Create("", 23233), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:153px;", 23233), true)
);
WriteLiteral(">Net weight (1)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDNWeight1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDNWeight1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDNWeight1.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDNWeight1/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDNWeight1\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDNWeight1.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:153px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 23943), Tuple.Create("\'", 24012)
, Tuple.Create(Tuple.Create("", 23951), Tuple.Create("IQLabel103237", 23951), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 23964), Tuple.Create<System.Object, System.Int32>(!Model.SDValue1.LabelVisible ? " hide " : ""
, 23965), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24013), Tuple.Create("\'", 24221)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 24022), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDValue1.BackHEXColor) ? "" : "color:" + Model.SDValue1.BackHEXColor + ";"
, 24022), false)
, Tuple.Create(Tuple.Create("", 24126), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:178px;", 24126), true)
);
WriteLiteral(">Value (1)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDValue1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDValue1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SDValue1.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDValue1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDValue1/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDValue1\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.SDValue1.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 24818), Tuple.Create("\'", 24886)
, Tuple.Create(Tuple.Create("", 24826), Tuple.Create("IQLabel103239", 24826), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 24839), Tuple.Create<System.Object, System.Int32>(!Model.SDDesc2.LabelVisible ? " hide " : ""
, 24840), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24887), Tuple.Create("\'", 25093)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 24896), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDesc2.BackHEXColor) ? "" : "color:" + Model.SDDesc2.BackHEXColor + ";"
, 24896), false)
, Tuple.Create(Tuple.Create("", 24998), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:228px;", 24998), true)
);
WriteLiteral(">Description (2)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:46px;width:160px;top:228px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description (2)\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDesc2\'");
WriteLiteral(" ");
                                                                                                                                                                                                                           Write(Model.RecordLocked || !Model.SDDesc2.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDesc2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDesc2/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(!Model.SDDesc2.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDDesc2\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateSDDesc2);
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
WriteLiteral(" data-target=\"*[name=PopulateSDDesc2]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 26275), Tuple.Create("\'", 26347)
, Tuple.Create(Tuple.Create("", 26283), Tuple.Create("IQLabel103241", 26283), true)
, Tuple.Create(Tuple.Create(" ", 26296), Tuple.Create<System.Object, System.Int32>(!Model.SDCommCode2.LabelVisible ? " hide " : ""
, 26297), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 26348), Tuple.Create("\'", 26562)
                                , Tuple.Create(Tuple.Create("", 26357), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCommCode2.BackHEXColor) ? "" : "color:" + Model.SDCommCode2.BackHEXColor + ";"
, 26357), false)
, Tuple.Create(Tuple.Create("", 26467), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:278px;", 26467), true)
);
WriteLiteral(">Comm Code (2)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCommCode2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDCommCode2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SDCommCode2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCommCode2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCommCode2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDCommCode2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.SDCommCode2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:278px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 27184), Tuple.Create("\'", 27251)
, Tuple.Create(Tuple.Create("", 27192), Tuple.Create("IQLabel103242", 27192), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 27205), Tuple.Create<System.Object, System.Int32>(!Model.SDQty2.LabelVisible ? " hide " : ""
, 27206), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27252), Tuple.Create("\'", 27456)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 27261), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDQty2.BackHEXColor) ? "" : "color:" + Model.SDQty2.BackHEXColor + ";"
, 27261), false)
, Tuple.Create(Tuple.Create("", 27361), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:303px;", 27361), true)
);
WriteLiteral(">Quantity (2)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDQty2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDQty2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.SDQty2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDQty2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDQty2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDQty2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.SDQty2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:303px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 28041), Tuple.Create("\'", 28112)
, Tuple.Create(Tuple.Create("", 28049), Tuple.Create("IQLabel103243", 28049), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 28062), Tuple.Create<System.Object, System.Int32>(!Model.SDGWeight2.LabelVisible ? " hide " : ""
, 28063), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 28113), Tuple.Create("\'", 28325)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 28122), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDGWeight2.BackHEXColor) ? "" : "color:" + Model.SDGWeight2.BackHEXColor + ";"
, 28122), false)
, Tuple.Create(Tuple.Create("", 28230), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:328px;", 28230), true)
);
WriteLiteral(">Gross weight (2)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDGWeight2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDGWeight2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDGWeight2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDGWeight2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDGWeight2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDGWeight2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDGWeight2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:328px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 28942), Tuple.Create("\'", 29013)
, Tuple.Create(Tuple.Create("", 28950), Tuple.Create("IQLabel103244", 28950), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 28963), Tuple.Create<System.Object, System.Int32>(!Model.SDNWeight2.LabelVisible ? " hide " : ""
, 28964), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29014), Tuple.Create("\'", 29226)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 29023), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDNWeight2.BackHEXColor) ? "" : "color:" + Model.SDNWeight2.BackHEXColor + ";"
, 29023), false)
, Tuple.Create(Tuple.Create("", 29131), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:353px;", 29131), true)
);
WriteLiteral(">Net weight (2)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDNWeight2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDNWeight2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDNWeight2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDNWeight2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDNWeight2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDNWeight2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:353px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 29841), Tuple.Create("\'", 29910)
, Tuple.Create(Tuple.Create("", 29849), Tuple.Create("IQLabel103245", 29849), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 29862), Tuple.Create<System.Object, System.Int32>(!Model.SDValue2.LabelVisible ? " hide " : ""
, 29863), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29911), Tuple.Create("\'", 30119)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 29920), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDValue2.BackHEXColor) ? "" : "color:" + Model.SDValue2.BackHEXColor + ";"
, 29920), false)
, Tuple.Create(Tuple.Create("", 30024), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:378px;", 30024), true)
);
WriteLiteral(">Value (2)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDValue2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDValue2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SDValue2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDValue2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDValue2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDValue2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.SDValue2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:378px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 30716), Tuple.Create("\'", 30787)
, Tuple.Create(Tuple.Create("", 30724), Tuple.Create("IQLabel103247", 30724), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 30737), Tuple.Create<System.Object, System.Int32>(!Model.SDCompAuth.LabelVisible ? " hide " : ""
, 30738), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 30788), Tuple.Create("\'", 31000)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 30797), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCompAuth.BackHEXColor) ? "" : "color:" + Model.SDCompAuth.BackHEXColor + ";"
, 30797), false)
, Tuple.Create(Tuple.Create("", 30905), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:428px;", 30905), true)
);
WriteLiteral(">Competent Auth</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:71px;width:160px;top:428px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Competent Auth\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCompAuth\'");
WriteLiteral(" ");
                                                                                                                                                                                                                             Write(Model.RecordLocked || !Model.SDCompAuth.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCompAuth/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCompAuth/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.SDCompAuth.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDCompAuth\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.PopulateSDCompAuth);
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
WriteLiteral(" data-target=\"*[name=PopulateSDCompAuth]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 32204), Tuple.Create("\'", 32271)
, Tuple.Create(Tuple.Create("", 32212), Tuple.Create("IQLabel103248", 32212), true)
, Tuple.Create(Tuple.Create(" ", 32225), Tuple.Create<System.Object, System.Int32>(!Model.SDCurr.LabelVisible ? " hide " : ""
, 32226), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 32272), Tuple.Create("\'", 32474)
                           , Tuple.Create(Tuple.Create("", 32281), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCurr.BackHEXColor) ? "" : "color:" + Model.SDCurr.BackHEXColor + ";"
, 32281), false)
, Tuple.Create(Tuple.Create("", 32381), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 32381), true)
);
WriteLiteral(">Currency</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCurr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDCurr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                     Write(!Model.SDCurr.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCurr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCurr/',$(this));\""));
WriteLiteral("   name=\'PopulateSDCurr\'  style=\'position: absolute; left:420px;height:21px;width" +
":160px;top:3px;\'>\r\n");
             foreach(var itm in Model.SDCurr.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 33062), Tuple.Create("\'", 33083)
, Tuple.Create(Tuple.Create("", 33070), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 33070), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateSDCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                       Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 33213), Tuple.Create("\'", 33281)
, Tuple.Create(Tuple.Create("", 33221), Tuple.Create("IQLabel103251", 33221), true)
, Tuple.Create(Tuple.Create(" ", 33234), Tuple.Create<System.Object, System.Int32>(!Model.SDDesc3.LabelVisible ? " hide " : ""
, 33235), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 33282), Tuple.Create("\'", 33487)
                     , Tuple.Create(Tuple.Create("", 33291), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDesc3.BackHEXColor) ? "" : "color:" + Model.SDDesc3.BackHEXColor + ";"
, 33291), false)
, Tuple.Create(Tuple.Create("", 33393), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:28px;", 33393), true)
);
WriteLiteral(">Description (3)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:710px;height:46px;width:160px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description (3)\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDesc3\'");
WriteLiteral(" ");
                                                                                                                                                                                                                       Write(Model.RecordLocked || !Model.SDDesc3.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDesc3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDesc3/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(!Model.SDDesc3.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDDesc3\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.PopulateSDDesc3);
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
WriteLiteral(" data-target=\"*[name=PopulateSDDesc3]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 34668), Tuple.Create("\'", 34740)
, Tuple.Create(Tuple.Create("", 34676), Tuple.Create("IQLabel103253", 34676), true)
, Tuple.Create(Tuple.Create(" ", 34689), Tuple.Create<System.Object, System.Int32>(!Model.SDCommCode3.LabelVisible ? " hide " : ""
, 34690), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 34741), Tuple.Create("\'", 34954)
                                , Tuple.Create(Tuple.Create("", 34750), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCommCode3.BackHEXColor) ? "" : "color:" + Model.SDCommCode3.BackHEXColor + ";"
, 34750), false)
, Tuple.Create(Tuple.Create("", 34860), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:78px;", 34860), true)
);
WriteLiteral(">Comm Code (3)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCommCode3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDCommCode3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SDCommCode3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCommCode3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCommCode3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDCommCode3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.SDCommCode3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:100px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 35575), Tuple.Create("\'", 35642)
, Tuple.Create(Tuple.Create("", 35583), Tuple.Create("IQLabel103254", 35583), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 35596), Tuple.Create<System.Object, System.Int32>(!Model.SDQty3.LabelVisible ? " hide " : ""
, 35597), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 35643), Tuple.Create("\'", 35847)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 35652), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDQty3.BackHEXColor) ? "" : "color:" + Model.SDQty3.BackHEXColor + ";"
, 35652), false)
, Tuple.Create(Tuple.Create("", 35752), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:103px;", 35752), true)
);
WriteLiteral(">Quantity (3)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDQty3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDQty3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.SDQty3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDQty3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDQty3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDQty3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.SDQty3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 36432), Tuple.Create("\'", 36503)
, Tuple.Create(Tuple.Create("", 36440), Tuple.Create("IQLabel103255", 36440), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 36453), Tuple.Create<System.Object, System.Int32>(!Model.SDGWeight3.LabelVisible ? " hide " : ""
, 36454), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36504), Tuple.Create("\'", 36716)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 36513), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDGWeight3.BackHEXColor) ? "" : "color:" + Model.SDGWeight3.BackHEXColor + ";"
, 36513), false)
, Tuple.Create(Tuple.Create("", 36621), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:128px;", 36621), true)
);
WriteLiteral(">Gross weight (3)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDGWeight3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDGWeight3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDGWeight3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDGWeight3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDGWeight3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDGWeight3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDGWeight3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 37333), Tuple.Create("\'", 37404)
, Tuple.Create(Tuple.Create("", 37341), Tuple.Create("IQLabel103256", 37341), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 37354), Tuple.Create<System.Object, System.Int32>(!Model.SDNWeight3.LabelVisible ? " hide " : ""
, 37355), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 37405), Tuple.Create("\'", 37617)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 37414), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDNWeight3.BackHEXColor) ? "" : "color:" + Model.SDNWeight3.BackHEXColor + ";"
, 37414), false)
, Tuple.Create(Tuple.Create("", 37522), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:153px;", 37522), true)
);
WriteLiteral(">Net weight (3)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDNWeight3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDNWeight3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDNWeight3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDNWeight3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDNWeight3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDNWeight3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:153px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 38232), Tuple.Create("\'", 38301)
, Tuple.Create(Tuple.Create("", 38240), Tuple.Create("IQLabel103257", 38240), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 38253), Tuple.Create<System.Object, System.Int32>(!Model.SDValue3.LabelVisible ? " hide " : ""
, 38254), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 38302), Tuple.Create("\'", 38510)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 38311), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDValue3.BackHEXColor) ? "" : "color:" + Model.SDValue3.BackHEXColor + ";"
, 38311), false)
, Tuple.Create(Tuple.Create("", 38415), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:178px;", 38415), true)
);
WriteLiteral(">Value (3)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDValue3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDValue3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SDValue3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDValue3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDValue3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDValue3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.SDValue3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:100px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 39107), Tuple.Create("\'", 39175)
, Tuple.Create(Tuple.Create("", 39115), Tuple.Create("IQLabel103259", 39115), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 39128), Tuple.Create<System.Object, System.Int32>(!Model.SDDesc4.LabelVisible ? " hide " : ""
, 39129), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 39176), Tuple.Create("\'", 39382)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 39185), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDDesc4.BackHEXColor) ? "" : "color:" + Model.SDDesc4.BackHEXColor + ";"
, 39185), false)
, Tuple.Create(Tuple.Create("", 39287), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:228px;", 39287), true)
);
WriteLiteral(">Description (4)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:710px;height:46px;width:160px;top:228px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description (4)\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDDesc4\'");
WriteLiteral(" ");
                                                                                                                                                                                                                           Write(Model.RecordLocked || !Model.SDDesc4.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDesc4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDDesc4/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(!Model.SDDesc4.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDDesc4\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateSDDesc4);
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
WriteLiteral(" data-target=\"*[name=PopulateSDDesc4]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 40564), Tuple.Create("\'", 40636)
, Tuple.Create(Tuple.Create("", 40572), Tuple.Create("IQLabel103261", 40572), true)
, Tuple.Create(Tuple.Create(" ", 40585), Tuple.Create<System.Object, System.Int32>(!Model.SDCommCode4.LabelVisible ? " hide " : ""
, 40586), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 40637), Tuple.Create("\'", 40851)
                                , Tuple.Create(Tuple.Create("", 40646), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDCommCode4.BackHEXColor) ? "" : "color:" + Model.SDCommCode4.BackHEXColor + ";"
, 40646), false)
, Tuple.Create(Tuple.Create("", 40756), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:278px;", 40756), true)
);
WriteLiteral(">Comm Code (4)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDCommCode4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDCommCode4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.SDCommCode4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCommCode4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDCommCode4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDCommCode4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.SDCommCode4.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:100px;top:278px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 41473), Tuple.Create("\'", 41540)
, Tuple.Create(Tuple.Create("", 41481), Tuple.Create("IQLabel103262", 41481), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 41494), Tuple.Create<System.Object, System.Int32>(!Model.SDQty4.LabelVisible ? " hide " : ""
, 41495), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 41541), Tuple.Create("\'", 41745)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 41550), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDQty4.BackHEXColor) ? "" : "color:" + Model.SDQty4.BackHEXColor + ";"
, 41550), false)
, Tuple.Create(Tuple.Create("", 41650), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:303px;", 41650), true)
);
WriteLiteral(">Quantity (4)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDQty4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDQty4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.SDQty4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDQty4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDQty4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDQty4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.SDQty4.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:303px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 42330), Tuple.Create("\'", 42401)
, Tuple.Create(Tuple.Create("", 42338), Tuple.Create("IQLabel103263", 42338), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 42351), Tuple.Create<System.Object, System.Int32>(!Model.SDGWeight4.LabelVisible ? " hide " : ""
, 42352), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 42402), Tuple.Create("\'", 42614)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 42411), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDGWeight4.BackHEXColor) ? "" : "color:" + Model.SDGWeight4.BackHEXColor + ";"
, 42411), false)
, Tuple.Create(Tuple.Create("", 42519), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:328px;", 42519), true)
);
WriteLiteral(">Gross weight (4)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDGWeight4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDGWeight4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDGWeight4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDGWeight4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDGWeight4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDGWeight4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDGWeight4.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:328px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 43231), Tuple.Create("\'", 43302)
, Tuple.Create(Tuple.Create("", 43239), Tuple.Create("IQLabel103264", 43239), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 43252), Tuple.Create<System.Object, System.Int32>(!Model.SDNWeight4.LabelVisible ? " hide " : ""
, 43253), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 43303), Tuple.Create("\'", 43515)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 43312), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDNWeight4.BackHEXColor) ? "" : "color:" + Model.SDNWeight4.BackHEXColor + ";"
, 43312), false)
, Tuple.Create(Tuple.Create("", 43420), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:353px;", 43420), true)
);
WriteLiteral(">Net weight (4)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDNWeight4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDNWeight4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.SDNWeight4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDNWeight4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDNWeight4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.SDNWeight4.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:353px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 44130), Tuple.Create("\'", 44199)
, Tuple.Create(Tuple.Create("", 44138), Tuple.Create("IQLabel103265", 44138), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 44151), Tuple.Create<System.Object, System.Int32>(!Model.SDValue4.LabelVisible ? " hide " : ""
, 44152), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 44200), Tuple.Create("\'", 44408)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 44209), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDValue4.BackHEXColor) ? "" : "color:" + Model.SDValue4.BackHEXColor + ";"
, 44209), false)
, Tuple.Create(Tuple.Create("", 44313), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:378px;", 44313), true)
);
WriteLiteral(">Value (4)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDValue4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.SDValue4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.SDValue4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDValue4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDValue4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateSDValue4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.SDValue4.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:100px;top:378px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 45005), Tuple.Create("\'", 45081)
, Tuple.Create(Tuple.Create("", 45013), Tuple.Create("IQLabel103267", 45013), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 45026), Tuple.Create<System.Object, System.Int32>(!Model.SDRecordControl.LabelVisible ? " hide " : ""
, 45027), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 45082), Tuple.Create("\'", 45304)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 45091), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDRecordControl.BackHEXColor) ? "" : "color:" + Model.SDRecordControl.BackHEXColor + ";"
, 45091), false)
, Tuple.Create(Tuple.Create("", 45209), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:428px;", 45209), true)
);
WriteLiteral(">Record of Control</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:710px;height:71px;width:160px;top:428px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Record of Control\'");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDRecordControl\'");
WriteLiteral(" ");
                                                                                                                                                                                                                                     Write(Model.RecordLocked || !Model.SDRecordControl.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecordControl/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDRecordControl/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(!Model.SDRecordControl.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateSDRecordControl\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.PopulateSDRecordControl);
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
WriteLiteral(" data-target=\"*[name=PopulateSDRecordControl]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 46554), Tuple.Create("\'", 46625)
, Tuple.Create(Tuple.Create("", 46562), Tuple.Create("IQLabel103268", 46562), true)
, Tuple.Create(Tuple.Create(" ", 46575), Tuple.Create<System.Object, System.Int32>(!Model.SDHMRCDets.LabelVisible ? " hide " : ""
, 46576), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 46626), Tuple.Create("\'", 46836)
                               , Tuple.Create(Tuple.Create("", 46635), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.SDHMRCDets.BackHEXColor) ? "" : "color:" + Model.SDHMRCDets.BackHEXColor + ";"
, 46635), false)
, Tuple.Create(Tuple.Create("", 46743), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:3px;", 46743), true)
);
WriteLiteral(">Show HMRC details</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ShippingDocuments_SDHMRCDets\'");
WriteAttribute("class", Tuple.Create(" class=\'", 46927), Tuple.Create("\'", 46981)
, Tuple.Create(Tuple.Create("  ", 46935), Tuple.Create<System.Object, System.Int32>(!Model.SDHMRCDets.Visible ? " hide " : ""
, 46937), false)
);
WriteLiteral(" ");
                                                                                                                 Write(Model.RecordLocked || !Model.SDHMRCDets.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDHMRCDets/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ShipDoc/CallbackSDHMRCDets/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:710px;height:16px;width:16px;top:3px;\' name=\'Po" +
"pulateSDHMRCDets\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.PopulateSDHMRCDets ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateSDHMRCDets\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                 Write(!Model.PopulateSDHMRCDets ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Edit_1.cshtml")]
    public partial class Views_ShipDoc_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Edit_1_cshtml()
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
WriteLiteral(" href=\"/ShipDoc/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Shipping Documents</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 476)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/ShipDoc/Delete/?RecId=", 425), true)
        , Tuple.Create(Tuple.Create("", 458), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 458), false)
, Tuple.Create(Tuple.Create("", 473), Tuple.Create("\");", 473), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ShipDo" +
"c/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ShipDoc", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1370), Tuple.Create("\'", 1392)
, Tuple.Create(Tuple.Create("", 1378), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1378), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1438), Tuple.Create("\'", 1462)
, Tuple.Create(Tuple.Create("", 1446), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1446), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ShipDoc\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1563), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1571), Tuple.Create<System.Object, System.Int32>(Model.SDIdValue
, 1571), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ShipDoc/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2120)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/ShipDoc/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create("&dt=", 2069), true)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2073), false)
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
WriteLiteral(" id=\"ShippingDocuments\"");
WriteLiteral(" style=\'position:relative;height:529px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ShipDoc_ShippingDocuments.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2921), Tuple.Create("\"", 2936)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create("#", 2928), true)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2929), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3152), Tuple.Create("\"", 3164)
, Tuple.Create(Tuple.Create("", 3157), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3157), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Add_1.cshtml")]
    public partial class Views_ShipDoc_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Shipping Documents";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Shipping Documents\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ShipDoc/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ShippingDocuments\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ShipDoc_ShippingDocuments.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_List_1.cshtml")]
    public partial class Views_ShipDoc_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ShipDoc>>
    {
        public Views_ShipDoc_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Shipping Documents List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Shipping Documents List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Shipping Documents</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 598)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/ShipDoc/ListFromQuery/?Clause=", 535), true)
                                                                   , Tuple.Create(Tuple.Create("", 566), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 566), false)
, Tuple.Create(Tuple.Create("", 581), Tuple.Create("&Ord=", 581), true)
                                                                                       , Tuple.Create(Tuple.Create("", 586), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 586), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Document ID</th><th>Supplier Name</th><th>Recipient Name</th><th" +
">Currency</th><th>Show HMRC details</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 969), Tuple.Create("\"", 1010)
, Tuple.Create(Tuple.Create("", 976), Tuple.Create("/ShipDoc/Load/?RecId=", 976), true)
                , Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 997), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.SDId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1358), Tuple.Create("\"", 1443)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDSupp/?RecId=", 1369), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 1419), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1419), false)
, Tuple.Create(Tuple.Create("", 1432), Tuple.Create("\',$(this));", 1432), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.SDSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDRecip.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDRecip/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1778), Tuple.Create("\"", 1864)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDRecip/?RecId=", 1789), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1840), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1840), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("\',$(this));", 1853), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDRecip\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.SDRecip.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDCurr.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2153), Tuple.Create("\"", 2238)
, Tuple.Create(Tuple.Create("", 2164), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDCurr/?RecId=", 2164), true)
                                                                 , Tuple.Create(Tuple.Create("", 2214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2214), false)
, Tuple.Create(Tuple.Create("", 2227), Tuple.Create("\',$(this));", 2227), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SDCurr\'");
WriteLiteral("  >");
                                                                                                                                                                                                                     Write(Html.Raw(itm.SDCurr.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDHMRCDets.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2494), Tuple.Create("\"", 2582)
, Tuple.Create(Tuple.Create("", 2504), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDHMRCDets/?RecId=", 2504), true)
                                                    , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2558), false)
, Tuple.Create(Tuple.Create("", 2571), Tuple.Create("\',$(this));", 2571), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'SDHMRCDets\'");
WriteLiteral(" ");
                                                                                                                                                                                                   Write(Html.Raw(itm.SDHMRCDets.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'SDHMRCDets\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Edit_2.cshtml")]
    public partial class Views_ShipDoc_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Edit_2_cshtml()
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
WriteLiteral(" href=\"/ShipDoc/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Shipping Documents</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 476)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/ShipDoc/Delete/?RecId=", 425), true)
        , Tuple.Create(Tuple.Create("", 458), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 458), false)
, Tuple.Create(Tuple.Create("", 473), Tuple.Create("\");", 473), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ShipDo" +
"c/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ShipDoc", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1370), Tuple.Create("\'", 1392)
, Tuple.Create(Tuple.Create("", 1378), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1378), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1438), Tuple.Create("\'", 1462)
, Tuple.Create(Tuple.Create("", 1446), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1446), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ShipDoc\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1563), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1571), Tuple.Create<System.Object, System.Int32>(Model.SDIdValue
, 1571), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ShipDoc/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2120)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/ShipDoc/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create("&dt=", 2069), true)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2073), false)
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
WriteLiteral(" id=\"ShippingDocuments\"");
WriteLiteral(" style=\'position:relative;height:529px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ShipDoc_ShippingDocuments.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2921), Tuple.Create("\"", 2936)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create("#", 2928), true)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2929), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3152), Tuple.Create("\"", 3164)
, Tuple.Create(Tuple.Create("", 3157), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3157), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Add_2.cshtml")]
    public partial class Views_ShipDoc_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Shipping Documents";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Shipping Documents\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ShipDoc/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ShippingDocuments\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ShipDoc_ShippingDocuments.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_List_2.cshtml")]
    public partial class Views_ShipDoc_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ShipDoc>>
    {
        public Views_ShipDoc_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Shipping Documents List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Shipping Documents List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Shipping Documents</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 598)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/ShipDoc/ListFromQuery/?Clause=", 535), true)
                                                                   , Tuple.Create(Tuple.Create("", 566), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 566), false)
, Tuple.Create(Tuple.Create("", 581), Tuple.Create("&Ord=", 581), true)
                                                                                       , Tuple.Create(Tuple.Create("", 586), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 586), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Document ID</th><th>Supplier Name</th><th>Recipient Name</th><th" +
">Currency</th><th>Show HMRC details</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 969), Tuple.Create("\"", 1010)
, Tuple.Create(Tuple.Create("", 976), Tuple.Create("/ShipDoc/Load/?RecId=", 976), true)
                , Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 997), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.SDId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1358), Tuple.Create("\"", 1443)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDSupp/?RecId=", 1369), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 1419), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1419), false)
, Tuple.Create(Tuple.Create("", 1432), Tuple.Create("\',$(this));", 1432), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.SDSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDRecip.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDRecip/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1778), Tuple.Create("\"", 1864)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDRecip/?RecId=", 1789), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1840), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1840), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("\',$(this));", 1853), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDRecip\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.SDRecip.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDCurr.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2153), Tuple.Create("\"", 2238)
, Tuple.Create(Tuple.Create("", 2164), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDCurr/?RecId=", 2164), true)
                                                                 , Tuple.Create(Tuple.Create("", 2214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2214), false)
, Tuple.Create(Tuple.Create("", 2227), Tuple.Create("\',$(this));", 2227), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SDCurr\'");
WriteLiteral("  >");
                                                                                                                                                                                                                     Write(Html.Raw(itm.SDCurr.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDHMRCDets.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2494), Tuple.Create("\"", 2582)
, Tuple.Create(Tuple.Create("", 2504), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDHMRCDets/?RecId=", 2504), true)
                                                    , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2558), false)
, Tuple.Create(Tuple.Create("", 2571), Tuple.Create("\',$(this));", 2571), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'SDHMRCDets\'");
WriteLiteral(" ");
                                                                                                                                                                                                   Write(Html.Raw(itm.SDHMRCDets.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'SDHMRCDets\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Edit_3.cshtml")]
    public partial class Views_ShipDoc_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Edit_3_cshtml()
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
WriteLiteral(" href=\"/ShipDoc/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Shipping Documents</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 415), Tuple.Create("\'", 476)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("IQJSCall(\"/ShipDoc/Delete/?RecId=", 425), true)
        , Tuple.Create(Tuple.Create("", 458), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 458), false)
, Tuple.Create(Tuple.Create("", 473), Tuple.Create("\");", 473), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/ShipDo" +
"c/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ShipDoc", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1370), Tuple.Create("\'", 1392)
, Tuple.Create(Tuple.Create("", 1378), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1378), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1438), Tuple.Create("\'", 1462)
, Tuple.Create(Tuple.Create("", 1446), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1446), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ShipDoc\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1563), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1571), Tuple.Create<System.Object, System.Int32>(Model.SDIdValue
, 1571), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ShipDoc/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2019), Tuple.Create("\"", 2120)
, Tuple.Create(Tuple.Create("", 2026), Tuple.Create("/ShipDoc/ViewHistory/?RecId=", 2026), true)
, Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create("&dt=", 2069), true)
, Tuple.Create(Tuple.Create("", 2073), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2073), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2712), Tuple.Create("\"", 2727)
, Tuple.Create(Tuple.Create("", 2719), Tuple.Create("#", 2719), true)
, Tuple.Create(Tuple.Create("", 2720), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2720), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2943), Tuple.Create("\"", 2955)
, Tuple.Create(Tuple.Create("", 2948), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2948), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_Add_3.cshtml")]
    public partial class Views_ShipDoc_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ShipDoc>
    {
        public Views_ShipDoc_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Shipping Documents";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Shipping Documents\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ShipDoc/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ShipDoc>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ShipDoc_List_3.cshtml")]
    public partial class Views_ShipDoc_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ShipDoc>>
    {
        public Views_ShipDoc_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Shipping Documents List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Shipping Documents List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Shipping Documents</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ShipDoc/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 598)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/ShipDoc/ListFromQuery/?Clause=", 535), true)
                                                                   , Tuple.Create(Tuple.Create("", 566), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 566), false)
, Tuple.Create(Tuple.Create("", 581), Tuple.Create("&Ord=", 581), true)
                                                                                       , Tuple.Create(Tuple.Create("", 586), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 586), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Document ID</th><th>Supplier Name</th><th>Recipient Name</th><th" +
">Currency</th><th>Show HMRC details</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 969), Tuple.Create("\"", 1010)
, Tuple.Create(Tuple.Create("", 976), Tuple.Create("/ShipDoc/Load/?RecId=", 976), true)
                , Tuple.Create(Tuple.Create("", 997), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 997), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.SDId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1358), Tuple.Create("\"", 1443)
, Tuple.Create(Tuple.Create("", 1369), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDSupp/?RecId=", 1369), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 1419), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1419), false)
, Tuple.Create(Tuple.Create("", 1432), Tuple.Create("\',$(this));", 1432), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.SDSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDRecip.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/ShipDoc/AutoCompleteSDRecip/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1778), Tuple.Create("\"", 1864)
, Tuple.Create(Tuple.Create("", 1789), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDRecip/?RecId=", 1789), true)
                                                                                                                 , Tuple.Create(Tuple.Create("", 1840), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1840), false)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create("\',$(this));", 1853), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'SDRecip\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(itm.SDRecip.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDCurr.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2153), Tuple.Create("\"", 2238)
, Tuple.Create(Tuple.Create("", 2164), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDCurr/?RecId=", 2164), true)
                                                                 , Tuple.Create(Tuple.Create("", 2214), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2214), false)
, Tuple.Create(Tuple.Create("", 2227), Tuple.Create("\',$(this));", 2227), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'SDCurr\'");
WriteLiteral("  >");
                                                                                                                                                                                                                     Write(Html.Raw(itm.SDCurr.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.SDHMRCDets.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 2494), Tuple.Create("\"", 2582)
, Tuple.Create(Tuple.Create("", 2504), Tuple.Create("javascript:IQAutoSave(\'/ShipDoc/SaveSDHMRCDets/?RecId=", 2504), true)
                                                    , Tuple.Create(Tuple.Create("", 2558), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2558), false)
, Tuple.Create(Tuple.Create("", 2571), Tuple.Create("\',$(this));", 2571), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'SDHMRCDets\'");
WriteLiteral(" ");
                                                                                                                                                                                                   Write(Html.Raw(itm.SDHMRCDets.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'SDHMRCDets\' value=\'false\'  /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
