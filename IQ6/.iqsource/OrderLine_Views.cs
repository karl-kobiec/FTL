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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_OrderLines.cshtml")]
    public partial class Views_OrderLine_OrderLines_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_OrderLines_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 65), Tuple.Create("\'", 135)
, Tuple.Create(Tuple.Create("", 73), Tuple.Create("IQLabel100411", 73), true)
, Tuple.Create(Tuple.Create(" ", 86), Tuple.Create<System.Object, System.Int32>(!Model.OrdLOrder.LabelVisible ? " hide " : ""
, 87), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 136), Tuple.Create("\'", 342)
        , Tuple.Create(Tuple.Create("", 145), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLOrder.BackHEXColor) ? "" : "color:" + Model.OrdLOrder.BackHEXColor + ";"
, 145), false)
, Tuple.Create(Tuple.Create("", 251), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 251), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLOrder\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 435), Tuple.Create("\'", 501)
, Tuple.Create(Tuple.Create("", 443), Tuple.Create("form-control", 443), true)
, Tuple.Create(Tuple.Create("   ", 455), Tuple.Create<System.Object, System.Int32>(!Model.OrdLOrder.Visible ? " hide " : ""
, 458), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.OrdLOrder.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 884), Tuple.Create("\'", 955)
, Tuple.Create(Tuple.Create("", 892), Tuple.Create("IQLabel100412", 892), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 905), Tuple.Create<System.Object, System.Int32>(!Model.OrdLLineNo.LabelVisible ? " hide " : ""
, 906), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 956), Tuple.Create("\'", 1165)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 965), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLLineNo.BackHEXColor) ? "" : "color:" + Model.OrdLLineNo.BackHEXColor + ";"
, 965), false)
, Tuple.Create(Tuple.Create("", 1073), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1073), true)
);
WriteLiteral(">Line Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLLineNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLLineNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdLLineNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLLineNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLLineNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLLineNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.OrdLLineNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:50px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1773), Tuple.Create("\'", 1845)
, Tuple.Create(Tuple.Create("", 1781), Tuple.Create("IQLabel100413", 1781), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 1794), Tuple.Create<System.Object, System.Int32>(!Model.OrdLCustOrd.LabelVisible ? " hide " : ""
, 1795), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1846), Tuple.Create("\'", 2057)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1855), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLCustOrd.BackHEXColor) ? "" : "color:" + Model.OrdLCustOrd.BackHEXColor + ";"
, 1855), false)
, Tuple.Create(Tuple.Create("", 1965), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1965), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.OrdLCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.OrdLCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2677), Tuple.Create("\'", 2745)
, Tuple.Create(Tuple.Create("", 2685), Tuple.Create("IQLabel100414", 2685), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 2698), Tuple.Create<System.Object, System.Int32>(!Model.OrdLQty.LabelVisible ? " hide " : ""
, 2699), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2746), Tuple.Create("\'", 2949)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2755), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLQty.BackHEXColor) ? "" : "color:" + Model.OrdLQty.BackHEXColor + ";"
, 2755), false)
, Tuple.Create(Tuple.Create("", 2857), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2857), true)
);
WriteLiteral(">Quantity</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLQty\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLQty.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.OrdLQty.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLQty/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLQty/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLQty\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.OrdLQty.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3533), Tuple.Create("\'", 3609)
, Tuple.Create(Tuple.Create("", 3541), Tuple.Create("IQLabel100415", 3541), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 3554), Tuple.Create<System.Object, System.Int32>(!Model.OrdLPackageType.LabelVisible ? " hide " : ""
, 3555), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3610), Tuple.Create("\'", 3830)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 3619), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLPackageType.BackHEXColor) ? "" : "color:" + Model.OrdLPackageType.BackHEXColor + ";"
, 3619), false)
, Tuple.Create(Tuple.Create("", 3737), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3737), true)
);
WriteLiteral(">Package Type</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:103px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLPackageType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLPackageType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                              Write(!Model.OrdLPackageType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLPackageType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLPackageType/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdLPackageType\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.OrdLPackageType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4554), Tuple.Create("\'", 4575)
, Tuple.Create(Tuple.Create("", 4562), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4562), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdLPackageType.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateOrdLPackageType]\"");
WriteLiteral(" data-url=\"/PackageType/Load/?PackId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/PackageType/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Package Types</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5482), Tuple.Create("\'", 5551)
, Tuple.Create(Tuple.Create("", 5490), Tuple.Create("IQLabel100416", 5490), true)
, Tuple.Create(Tuple.Create(" ", 5503), Tuple.Create<System.Object, System.Int32>(!Model.OrdLSize.LabelVisible ? " hide " : ""
, 5504), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5552), Tuple.Create("\'", 5758)
                          , Tuple.Create(Tuple.Create("", 5561), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLSize.BackHEXColor) ? "" : "color:" + Model.OrdLSize.BackHEXColor + ";"
, 5561), false)
, Tuple.Create(Tuple.Create("", 5665), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 5665), true)
);
WriteLiteral(">Size</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLSize\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLSize.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.OrdLSize.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLSize/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLSize/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdLSize\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.OrdLSize.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 6425), Tuple.Create("\'", 6446)
, Tuple.Create(Tuple.Create("", 6433), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 6433), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdLSize.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateOrdLSize]\"");
WriteLiteral(" data-url=\"/BottleSize/Load/?BSzId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/BottleSize/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Bottle Sizes</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7335), Tuple.Create("\'", 7404)
, Tuple.Create(Tuple.Create("", 7343), Tuple.Create("IQLabel100417", 7343), true)
, Tuple.Create(Tuple.Create(" ", 7356), Tuple.Create<System.Object, System.Int32>(!Model.OrdLDesc.LabelVisible ? " hide " : ""
, 7357), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7405), Tuple.Create("\'", 7611)
                          , Tuple.Create(Tuple.Create("", 7414), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLDesc.BackHEXColor) ? "" : "color:" + Model.OrdLDesc.BackHEXColor + ";"
, 7414), false)
, Tuple.Create(Tuple.Create("", 7518), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 7518), true)
);
WriteLiteral(">Description</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLDesc\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.OrdLDesc.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLDesc/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLDesc\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdLDesc.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:280px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 8207), Tuple.Create("\'", 8278)
, Tuple.Create(Tuple.Create("", 8215), Tuple.Create("IQLabel100418", 8215), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 8228), Tuple.Create<System.Object, System.Int32>(!Model.OrdLWeight.LabelVisible ? " hide " : ""
, 8229), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8279), Tuple.Create("\'", 8489)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 8288), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLWeight.BackHEXColor) ? "" : "color:" + Model.OrdLWeight.BackHEXColor + ";"
, 8288), false)
, Tuple.Create(Tuple.Create("", 8396), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 8396), true)
);
WriteLiteral(">Weight</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLWeight\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLWeight.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdLWeight.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLWeight/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLWeight/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLWeight\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.OrdLWeight.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 9093), Tuple.Create("\'", 9167)
, Tuple.Create(Tuple.Create("", 9101), Tuple.Create("IQLabel100419", 9101), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 9114), Tuple.Create<System.Object, System.Int32>(!Model.OrdLNumPallet.LabelVisible ? " hide " : ""
, 9115), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9168), Tuple.Create("\'", 9384)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 9177), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLNumPallet.BackHEXColor) ? "" : "color:" + Model.OrdLNumPallet.BackHEXColor + ";"
, 9177), false)
, Tuple.Create(Tuple.Create("", 9291), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 9291), true)
);
WriteLiteral(">Number of Pallets</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLNumPallet\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLNumPallet.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.OrdLNumPallet.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLNumPallet/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLNumPallet/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdLNumPallet\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.OrdLNumPallet.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:50px;top:203px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 10020), Tuple.Create("\'", 10095)
, Tuple.Create(Tuple.Create("", 10028), Tuple.Create("IQLabel100420", 10028), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 10041), Tuple.Create<System.Object, System.Int32>(!Model.OrdLPalletType.LabelVisible ? " hide " : ""
, 10042), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10096), Tuple.Create("\'", 10314)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 10105), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdLPalletType.BackHEXColor) ? "" : "color:" + Model.OrdLPalletType.BackHEXColor + ";"
, 10105), false)
, Tuple.Create(Tuple.Create("", 10221), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 10221), true)
);
WriteLiteral(">Pallet Type</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:228px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'OrderLines_OrdLPalletType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdLPalletType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                             Write(!Model.OrdLPalletType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLPalletType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/OrderLine/CallbackOrdLPalletType/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdLPalletType\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.OrdLPalletType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 11030), Tuple.Create("\'", 11051)
, Tuple.Create(Tuple.Create("", 11038), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 11038), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdLPalletType.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateOrdLPalletType]\"");
WriteLiteral(" data-url=\"/PalletType/Load/?PallId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/PalletType/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Pallet Types</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Edit_1.cshtml")]
    public partial class Views_OrderLine_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/OrderLine/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/OrderL" +
"ine/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("OrderLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"OrderLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1523)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.OrdLOrderValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1592)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1634), Tuple.Create("\"", 1657)
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1642), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/OrderLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1957), Tuple.Create("\"", 2060)
, Tuple.Create(Tuple.Create("", 1964), Tuple.Create("/OrderLine/ViewHistory/?RecId=", 1964), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1994), false)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create("&dt=", 2009), true)
, Tuple.Create(Tuple.Create("", 2013), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2013), false)
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
WriteLiteral(" id=\"OrderLines\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/OrderLine_OrderLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2849), Tuple.Create("\"", 2864)
, Tuple.Create(Tuple.Create("", 2856), Tuple.Create("#", 2856), true)
, Tuple.Create(Tuple.Create("", 2857), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2857), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3080), Tuple.Create("\"", 3092)
, Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3085), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Add_1.cshtml")]
    public partial class Views_OrderLine_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/OrderLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"OrderLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/OrderLine_OrderLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_List_1.cshtml")]
    public partial class Views_OrderLine_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.OrderLine>>
    {
        public Views_OrderLine_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 585)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/OrderLine/ListFromQuery/?Clause=", 520), true)
                                                                     , Tuple.Create(Tuple.Create("", 553), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 553), false)
, Tuple.Create(Tuple.Create("", 568), Tuple.Create("&Ord=", 568), true)
                                                                                         , Tuple.Create(Tuple.Create("", 573), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 573), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Line Number</th><th>Quantity</th><th>Packag" +
"e Type</th><th>Size</th><th>Description</th><th>Weight</th><th>Number of Pallets" +
"</th><th>Pallet Type</th><th>Client Order No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1045), Tuple.Create("\"", 1088)
, Tuple.Create(Tuple.Create("", 1052), Tuple.Create("/OrderLine/Load/?RecId=", 1052), true)
                 , Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1075), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdLOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1400), Tuple.Create("\"", 1491)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLLineNo/?RecId=", 1411), true)
                                                                        , Tuple.Create(Tuple.Create("", 1467), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1467), false)
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create("\',$(this));", 1480), true)
);
WriteLiteral(" data-bound-name=\'OrdLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1552), Tuple.Create("\'", 1595)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1560), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLLineNo.HTMLValue)
, 1560), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLQty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1780), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1791), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLQty/?RecId=", 1791), true)
                                                                     , Tuple.Create(Tuple.Create("", 1844), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1844), false)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create("\',$(this));", 1857), true)
);
WriteLiteral(" data-bound-name=\'OrdLQty\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1926), Tuple.Create("\'", 1966)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1934), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLQty.HTMLValue)
, 1934), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPackageType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2157), Tuple.Create("\"", 2253)
, Tuple.Create(Tuple.Create("", 2168), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPackageType/?RecId=", 2168), true)
                                                                           , Tuple.Create(Tuple.Create("", 2229), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2229), false)
, Tuple.Create(Tuple.Create("", 2242), Tuple.Create("\',$(this));", 2242), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPackageType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                        Write(Html.Raw(itm.OrdLPackageType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2540), Tuple.Create("\"", 2629)
, Tuple.Create(Tuple.Create("", 2551), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLSize/?RecId=", 2551), true)
                                                                    , Tuple.Create(Tuple.Create("", 2605), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2605), false)
, Tuple.Create(Tuple.Create("", 2618), Tuple.Create("\',$(this));", 2618), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLSize\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdLSize.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2905), Tuple.Create("\"", 2994)
, Tuple.Create(Tuple.Create("", 2916), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLDesc/?RecId=", 2916), true)
                                                                       , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2970), false)
, Tuple.Create(Tuple.Create("", 2983), Tuple.Create("\',$(this));", 2983), true)
);
WriteLiteral(" data-bound-name=\'OrdLDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3053), Tuple.Create("\'", 3094)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3061), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLDesc.HTMLValue)
, 3061), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLWeight.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3282), Tuple.Create("\"", 3373)
, Tuple.Create(Tuple.Create("", 3293), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLWeight/?RecId=", 3293), true)
                                                                        , Tuple.Create(Tuple.Create("", 3349), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3349), false)
, Tuple.Create(Tuple.Create("", 3362), Tuple.Create("\',$(this));", 3362), true)
);
WriteLiteral(" data-bound-name=\'OrdLWeight\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3434), Tuple.Create("\'", 3477)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 3442), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLWeight.HTMLValue)
, 3442), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLNumPallet.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3668), Tuple.Create("\"", 3762)
, Tuple.Create(Tuple.Create("", 3679), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLNumPallet/?RecId=", 3679), true)
                                                                           , Tuple.Create(Tuple.Create("", 3738), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3738), false)
, Tuple.Create(Tuple.Create("", 3751), Tuple.Create("\',$(this));", 3751), true)
);
WriteLiteral(" data-bound-name=\'OrdLNumPallet\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3826), Tuple.Create("\'", 3872)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3834), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLNumPallet.HTMLValue)
, 3834), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPalletType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4062), Tuple.Create("\"", 4157)
, Tuple.Create(Tuple.Create("", 4073), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPalletType/?RecId=", 4073), true)
                                                                          , Tuple.Create(Tuple.Create("", 4133), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4133), false)
, Tuple.Create(Tuple.Create("", 4146), Tuple.Create("\',$(this));", 4146), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPalletType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.OrdLPalletType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4447), Tuple.Create("\"", 4539)
, Tuple.Create(Tuple.Create("", 4458), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLCustOrd/?RecId=", 4458), true)
                                                                         , Tuple.Create(Tuple.Create("", 4515), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4515), false)
, Tuple.Create(Tuple.Create("", 4528), Tuple.Create("\',$(this));", 4528), true)
);
WriteLiteral(" data-bound-name=\'OrdLCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4601), Tuple.Create("\'", 4645)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 4609), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLCustOrd.HTMLValue)
, 4609), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Edit_2.cshtml")]
    public partial class Views_OrderLine_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/OrderLine/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/OrderL" +
"ine/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("OrderLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"OrderLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1523)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.OrdLOrderValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1592)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1634), Tuple.Create("\"", 1657)
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1642), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/OrderLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1957), Tuple.Create("\"", 2060)
, Tuple.Create(Tuple.Create("", 1964), Tuple.Create("/OrderLine/ViewHistory/?RecId=", 1964), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1994), false)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create("&dt=", 2009), true)
, Tuple.Create(Tuple.Create("", 2013), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2013), false)
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
WriteLiteral(" id=\"OrderLines\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/OrderLine_OrderLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2849), Tuple.Create("\"", 2864)
, Tuple.Create(Tuple.Create("", 2856), Tuple.Create("#", 2856), true)
, Tuple.Create(Tuple.Create("", 2857), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2857), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3080), Tuple.Create("\"", 3092)
, Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3085), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Add_2.cshtml")]
    public partial class Views_OrderLine_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/OrderLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"OrderLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/OrderLine_OrderLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_List_2.cshtml")]
    public partial class Views_OrderLine_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.OrderLine>>
    {
        public Views_OrderLine_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 585)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/OrderLine/ListFromQuery/?Clause=", 520), true)
                                                                     , Tuple.Create(Tuple.Create("", 553), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 553), false)
, Tuple.Create(Tuple.Create("", 568), Tuple.Create("&Ord=", 568), true)
                                                                                         , Tuple.Create(Tuple.Create("", 573), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 573), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Line Number</th><th>Quantity</th><th>Packag" +
"e Type</th><th>Size</th><th>Description</th><th>Weight</th><th>Number of Pallets" +
"</th><th>Pallet Type</th><th>Client Order No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1045), Tuple.Create("\"", 1088)
, Tuple.Create(Tuple.Create("", 1052), Tuple.Create("/OrderLine/Load/?RecId=", 1052), true)
                 , Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1075), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdLOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1400), Tuple.Create("\"", 1491)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLLineNo/?RecId=", 1411), true)
                                                                        , Tuple.Create(Tuple.Create("", 1467), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1467), false)
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create("\',$(this));", 1480), true)
);
WriteLiteral(" data-bound-name=\'OrdLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1552), Tuple.Create("\'", 1595)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1560), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLLineNo.HTMLValue)
, 1560), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLQty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1780), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1791), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLQty/?RecId=", 1791), true)
                                                                     , Tuple.Create(Tuple.Create("", 1844), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1844), false)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create("\',$(this));", 1857), true)
);
WriteLiteral(" data-bound-name=\'OrdLQty\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1926), Tuple.Create("\'", 1966)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1934), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLQty.HTMLValue)
, 1934), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPackageType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2157), Tuple.Create("\"", 2253)
, Tuple.Create(Tuple.Create("", 2168), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPackageType/?RecId=", 2168), true)
                                                                           , Tuple.Create(Tuple.Create("", 2229), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2229), false)
, Tuple.Create(Tuple.Create("", 2242), Tuple.Create("\',$(this));", 2242), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPackageType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                        Write(Html.Raw(itm.OrdLPackageType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2540), Tuple.Create("\"", 2629)
, Tuple.Create(Tuple.Create("", 2551), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLSize/?RecId=", 2551), true)
                                                                    , Tuple.Create(Tuple.Create("", 2605), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2605), false)
, Tuple.Create(Tuple.Create("", 2618), Tuple.Create("\',$(this));", 2618), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLSize\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdLSize.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2905), Tuple.Create("\"", 2994)
, Tuple.Create(Tuple.Create("", 2916), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLDesc/?RecId=", 2916), true)
                                                                       , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2970), false)
, Tuple.Create(Tuple.Create("", 2983), Tuple.Create("\',$(this));", 2983), true)
);
WriteLiteral(" data-bound-name=\'OrdLDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3053), Tuple.Create("\'", 3094)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3061), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLDesc.HTMLValue)
, 3061), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLWeight.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3282), Tuple.Create("\"", 3373)
, Tuple.Create(Tuple.Create("", 3293), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLWeight/?RecId=", 3293), true)
                                                                        , Tuple.Create(Tuple.Create("", 3349), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3349), false)
, Tuple.Create(Tuple.Create("", 3362), Tuple.Create("\',$(this));", 3362), true)
);
WriteLiteral(" data-bound-name=\'OrdLWeight\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3434), Tuple.Create("\'", 3477)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 3442), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLWeight.HTMLValue)
, 3442), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLNumPallet.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3668), Tuple.Create("\"", 3762)
, Tuple.Create(Tuple.Create("", 3679), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLNumPallet/?RecId=", 3679), true)
                                                                           , Tuple.Create(Tuple.Create("", 3738), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3738), false)
, Tuple.Create(Tuple.Create("", 3751), Tuple.Create("\',$(this));", 3751), true)
);
WriteLiteral(" data-bound-name=\'OrdLNumPallet\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3826), Tuple.Create("\'", 3872)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3834), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLNumPallet.HTMLValue)
, 3834), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPalletType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4062), Tuple.Create("\"", 4157)
, Tuple.Create(Tuple.Create("", 4073), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPalletType/?RecId=", 4073), true)
                                                                          , Tuple.Create(Tuple.Create("", 4133), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4133), false)
, Tuple.Create(Tuple.Create("", 4146), Tuple.Create("\',$(this));", 4146), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPalletType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.OrdLPalletType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4447), Tuple.Create("\"", 4539)
, Tuple.Create(Tuple.Create("", 4458), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLCustOrd/?RecId=", 4458), true)
                                                                         , Tuple.Create(Tuple.Create("", 4515), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4515), false)
, Tuple.Create(Tuple.Create("", 4528), Tuple.Create("\',$(this));", 4528), true)
);
WriteLiteral(" data-bound-name=\'OrdLCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4601), Tuple.Create("\'", 4645)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 4609), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLCustOrd.HTMLValue)
, 4609), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Edit_3.cshtml")]
    public partial class Views_OrderLine_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 336), Tuple.Create("\'", 399)
, Tuple.Create(Tuple.Create("", 346), Tuple.Create("IQJSCall(\"/OrderLine/Delete/?RecId=", 346), true)
          , Tuple.Create(Tuple.Create("", 381), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 381), false)
, Tuple.Create(Tuple.Create("", 396), Tuple.Create("\");", 396), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/OrderL" +
"ine/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("OrderLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1299), Tuple.Create("\'", 1321)
, Tuple.Create(Tuple.Create("", 1307), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1307), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1391)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"OrderLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1494), Tuple.Create("\"", 1523)
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(Model.OrdLOrderValue
, 1502), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1592)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1634), Tuple.Create("\"", 1657)
, Tuple.Create(Tuple.Create("", 1642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1642), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/OrderLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1957), Tuple.Create("\"", 2060)
, Tuple.Create(Tuple.Create("", 1964), Tuple.Create("/OrderLine/ViewHistory/?RecId=", 1964), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1994), false)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create("&dt=", 2009), true)
, Tuple.Create(Tuple.Create("", 2013), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2013), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2652), Tuple.Create("\"", 2667)
, Tuple.Create(Tuple.Create("", 2659), Tuple.Create("#", 2659), true)
, Tuple.Create(Tuple.Create("", 2660), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2660), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2883), Tuple.Create("\"", 2895)
, Tuple.Create(Tuple.Create("", 2888), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2888), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_Add_3.cshtml")]
    public partial class Views_OrderLine_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderLine>
    {
        public Views_OrderLine_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/OrderLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<OrderLine>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/OrderLine_List_3.cshtml")]
    public partial class Views_OrderLine_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.OrderLine>>
    {
        public Views_OrderLine_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/OrderLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 585)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/OrderLine/ListFromQuery/?Clause=", 520), true)
                                                                     , Tuple.Create(Tuple.Create("", 553), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 553), false)
, Tuple.Create(Tuple.Create("", 568), Tuple.Create("&Ord=", 568), true)
                                                                                         , Tuple.Create(Tuple.Create("", 573), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 573), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Line Number</th><th>Quantity</th><th>Packag" +
"e Type</th><th>Size</th><th>Description</th><th>Weight</th><th>Number of Pallets" +
"</th><th>Pallet Type</th><th>Client Order No</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1045), Tuple.Create("\"", 1088)
, Tuple.Create(Tuple.Create("", 1052), Tuple.Create("/OrderLine/Load/?RecId=", 1052), true)
                 , Tuple.Create(Tuple.Create("", 1075), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1075), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdLOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1400), Tuple.Create("\"", 1491)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLLineNo/?RecId=", 1411), true)
                                                                        , Tuple.Create(Tuple.Create("", 1467), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1467), false)
, Tuple.Create(Tuple.Create("", 1480), Tuple.Create("\',$(this));", 1480), true)
);
WriteLiteral(" data-bound-name=\'OrdLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1552), Tuple.Create("\'", 1595)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1560), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLLineNo.HTMLValue)
, 1560), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLQty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1780), Tuple.Create("\"", 1868)
, Tuple.Create(Tuple.Create("", 1791), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLQty/?RecId=", 1791), true)
                                                                     , Tuple.Create(Tuple.Create("", 1844), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1844), false)
, Tuple.Create(Tuple.Create("", 1857), Tuple.Create("\',$(this));", 1857), true)
);
WriteLiteral(" data-bound-name=\'OrdLQty\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1926), Tuple.Create("\'", 1966)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1934), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLQty.HTMLValue)
, 1934), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPackageType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2157), Tuple.Create("\"", 2253)
, Tuple.Create(Tuple.Create("", 2168), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPackageType/?RecId=", 2168), true)
                                                                           , Tuple.Create(Tuple.Create("", 2229), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2229), false)
, Tuple.Create(Tuple.Create("", 2242), Tuple.Create("\',$(this));", 2242), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPackageType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                        Write(Html.Raw(itm.OrdLPackageType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2540), Tuple.Create("\"", 2629)
, Tuple.Create(Tuple.Create("", 2551), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLSize/?RecId=", 2551), true)
                                                                    , Tuple.Create(Tuple.Create("", 2605), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2605), false)
, Tuple.Create(Tuple.Create("", 2618), Tuple.Create("\',$(this));", 2618), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLSize\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdLSize.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:27%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2905), Tuple.Create("\"", 2994)
, Tuple.Create(Tuple.Create("", 2916), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLDesc/?RecId=", 2916), true)
                                                                       , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2970), false)
, Tuple.Create(Tuple.Create("", 2983), Tuple.Create("\',$(this));", 2983), true)
);
WriteLiteral(" data-bound-name=\'OrdLDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3053), Tuple.Create("\'", 3094)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3061), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLDesc.HTMLValue)
, 3061), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLWeight.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3282), Tuple.Create("\"", 3373)
, Tuple.Create(Tuple.Create("", 3293), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLWeight/?RecId=", 3293), true)
                                                                        , Tuple.Create(Tuple.Create("", 3349), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3349), false)
, Tuple.Create(Tuple.Create("", 3362), Tuple.Create("\',$(this));", 3362), true)
);
WriteLiteral(" data-bound-name=\'OrdLWeight\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3434), Tuple.Create("\'", 3477)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 3442), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLWeight.HTMLValue)
, 3442), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLNumPallet.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3668), Tuple.Create("\"", 3762)
, Tuple.Create(Tuple.Create("", 3679), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLNumPallet/?RecId=", 3679), true)
                                                                           , Tuple.Create(Tuple.Create("", 3738), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3738), false)
, Tuple.Create(Tuple.Create("", 3751), Tuple.Create("\',$(this));", 3751), true)
);
WriteLiteral(" data-bound-name=\'OrdLNumPallet\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3826), Tuple.Create("\'", 3872)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3834), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLNumPallet.HTMLValue)
, 3834), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLPalletType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4062), Tuple.Create("\"", 4157)
, Tuple.Create(Tuple.Create("", 4073), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLPalletType/?RecId=", 4073), true)
                                                                          , Tuple.Create(Tuple.Create("", 4133), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4133), false)
, Tuple.Create(Tuple.Create("", 4146), Tuple.Create("\',$(this));", 4146), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdLPalletType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.OrdLPalletType.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdLCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4447), Tuple.Create("\"", 4539)
, Tuple.Create(Tuple.Create("", 4458), Tuple.Create("javascript:IQAutoSave(\'/OrderLine/SaveOrdLCustOrd/?RecId=", 4458), true)
                                                                         , Tuple.Create(Tuple.Create("", 4515), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4515), false)
, Tuple.Create(Tuple.Create("", 4528), Tuple.Create("\',$(this));", 4528), true)
);
WriteLiteral(" data-bound-name=\'OrdLCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4601), Tuple.Create("\'", 4645)
                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 4609), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdLCustOrd.HTMLValue)
, 4609), false)
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
