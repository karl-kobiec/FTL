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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_InvoiceLines.cshtml")]
    public partial class Views_InvLine_InvoiceLines_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_InvoiceLines_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel100811", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.InvLInvNo.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 340)
        , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLInvNo.BackHEXColor) ? "" : "color:" + Model.InvLInvNo.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 249), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 249), true)
);
WriteLiteral(">Invoice Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLInvNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLInvNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.InvLInvNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLInvNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLInvNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLInvNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.InvLInvNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 941), Tuple.Create("\'", 1012)
, Tuple.Create(Tuple.Create("", 949), Tuple.Create("IQLabel100812", 949), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 962), Tuple.Create<System.Object, System.Int32>(!Model.InvLLineNo.LabelVisible ? " hide " : ""
, 963), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1013), Tuple.Create("\'", 1222)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1022), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLLineNo.BackHEXColor) ? "" : "color:" + Model.InvLLineNo.BackHEXColor + ";"
, 1022), false)
, Tuple.Create(Tuple.Create("", 1130), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1130), true)
);
WriteLiteral(">Line Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLLineNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLLineNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.InvLLineNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLLineNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLLineNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLLineNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.InvLLineNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1828), Tuple.Create("\'", 1903)
, Tuple.Create(Tuple.Create("", 1836), Tuple.Create("IQLabel100813", 1836), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 1849), Tuple.Create<System.Object, System.Int32>(!Model.InvLChargeType.LabelVisible ? " hide " : ""
, 1850), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1904), Tuple.Create("\'", 2121)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLChargeType.BackHEXColor) ? "" : "color:" + Model.InvLChargeType.BackHEXColor + ";"
, 1913), false)
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2029), true)
);
WriteLiteral(">Charge Type</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLChargeType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLChargeType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                             Write(!Model.InvLChargeType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLChargeType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLChargeType/',$(this));\""));
WriteLiteral("   name=\'PopulateInvLChargeType\'  style=\'position: absolute; left:130px;height:21" +
"px;width:160px;top:53px;\'>\r\n");
             foreach(var itm in Model.InvLChargeType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2764), Tuple.Create("\'", 2785)
, Tuple.Create(Tuple.Create("", 2772), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2772), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvLChargeType.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                               Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2923), Tuple.Create("\'", 2992)
, Tuple.Create(Tuple.Create("", 2931), Tuple.Create("IQLabel100814", 2931), true)
, Tuple.Create(Tuple.Create(" ", 2944), Tuple.Create<System.Object, System.Int32>(!Model.InvLDesc.LabelVisible ? " hide " : ""
, 2945), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2993), Tuple.Create("\'", 3198)
                       , Tuple.Create(Tuple.Create("", 3002), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLDesc.BackHEXColor) ? "" : "color:" + Model.InvLDesc.BackHEXColor + ";"
, 3002), false)
, Tuple.Create(Tuple.Create("", 3106), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3106), true)
);
WriteLiteral(">Description</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:160px;top:78px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description\'");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                               Write(Model.RecordLocked || !Model.InvLDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(!Model.InvLDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateInvLDesc\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.PopulateInvLDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateInvLDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4374), Tuple.Create("\'", 4442)
, Tuple.Create(Tuple.Create("", 4382), Tuple.Create("IQLabel100831", 4382), true)
, Tuple.Create(Tuple.Create(" ", 4395), Tuple.Create<System.Object, System.Int32>(!Model.InvLAmt.LabelVisible ? " hide " : ""
, 4396), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4443), Tuple.Create("\'", 4647)
                             , Tuple.Create(Tuple.Create("", 4452), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLAmt.BackHEXColor) ? "" : "color:" + Model.InvLAmt.BackHEXColor + ";"
, 4452), false)
, Tuple.Create(Tuple.Create("", 4554), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 4554), true)
);
WriteLiteral(">Line Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLAmt\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLAmt.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.InvLAmt.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLAmt/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLAmt/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLAmt\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.InvLAmt.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5231), Tuple.Create("\'", 5303)
, Tuple.Create(Tuple.Create("", 5239), Tuple.Create("IQLabel100832", 5239), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 5252), Tuple.Create<System.Object, System.Int32>(!Model.InvLVATCode.LabelVisible ? " hide " : ""
, 5253), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5304), Tuple.Create("\'", 5517)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 5313), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLVATCode.BackHEXColor) ? "" : "color:" + Model.InvLVATCode.BackHEXColor + ";"
, 5313), false)
, Tuple.Create(Tuple.Create("", 5423), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 5423), true)
);
WriteLiteral(">VAT Code</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:140px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLVATCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLVATCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                   Write(!Model.InvLVATCode.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLVATCode/',$(this));\""));
WriteLiteral("   name=\'PopulateInvLVATCode\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvLVATCode.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 6215), Tuple.Create("\'", 6236)
, Tuple.Create(Tuple.Create("", 6223), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 6223), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvLVATCode.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvLVATCode]\"");
WriteLiteral(" data-url=\"/VATCodes/Load/?VATId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/VATCodes/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All VAT Codes</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7124), Tuple.Create("\'", 7196)
, Tuple.Create(Tuple.Create("", 7132), Tuple.Create("IQLabel100833", 7132), true)
, Tuple.Create(Tuple.Create(" ", 7145), Tuple.Create<System.Object, System.Int32>(!Model.InvLVATRate.LabelVisible ? " hide " : ""
, 7146), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7197), Tuple.Create("\'", 7410)
                             , Tuple.Create(Tuple.Create("", 7206), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLVATRate.BackHEXColor) ? "" : "color:" + Model.InvLVATRate.BackHEXColor + ";"
, 7206), false)
, Tuple.Create(Tuple.Create("", 7316), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 7316), true)
);
WriteLiteral(">VAT Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLVATRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvLVATRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.InvLVATRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLVATRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLVATRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.InvLVATRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 8020), Tuple.Create("\'", 8091)
, Tuple.Create(Tuple.Create("", 8028), Tuple.Create("IQLabel100834", 8028), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 8041), Tuple.Create<System.Object, System.Int32>(!Model.InvLVATAmt.LabelVisible ? " hide " : ""
, 8042), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8092), Tuple.Create("\'", 8303)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 8101), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLVATAmt.BackHEXColor) ? "" : "color:" + Model.InvLVATAmt.BackHEXColor + ";"
, 8101), false)
, Tuple.Create(Tuple.Create("", 8209), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 8209), true)
);
WriteLiteral(">VAT Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLVATAmt\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 8397), Tuple.Create("\'", 8464)
, Tuple.Create(Tuple.Create("", 8405), Tuple.Create("form-control", 8405), true)
, Tuple.Create(Tuple.Create("   ", 8417), Tuple.Create<System.Object, System.Int32>(!Model.InvLVATAmt.Visible ? " hide " : ""
, 8420), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATAmt/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLVATAmt/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLVATAmt\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.InvLVATAmt.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 8848), Tuple.Create("\'", 8918)
, Tuple.Create(Tuple.Create("", 8856), Tuple.Create("IQLabel100835", 8856), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 8869), Tuple.Create<System.Object, System.Int32>(!Model.InvLTotal.LabelVisible ? " hide " : ""
, 8870), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8919), Tuple.Create("\'", 9129)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 8928), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvLTotal.BackHEXColor) ? "" : "color:" + Model.InvLTotal.BackHEXColor + ";"
, 8928), false)
, Tuple.Create(Tuple.Create("", 9034), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:103px;", 9034), true)
);
WriteLiteral(">Line Total</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceLines_InvLTotal\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 9222), Tuple.Create("\'", 9288)
, Tuple.Create(Tuple.Create("", 9230), Tuple.Create("form-control", 9230), true)
, Tuple.Create(Tuple.Create("   ", 9242), Tuple.Create<System.Object, System.Int32>(!Model.InvLTotal.Visible ? " hide " : ""
, 9245), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLTotal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvLine/CallbackInvLTotal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvLTotal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                  Write(Model.InvLTotal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:103px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Edit_1.cshtml")]
    public partial class Views_InvLine_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Edit_1_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/InvLine/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.InvLInvNoValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/InvLine/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteLiteral(" id=\"InvoiceLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvLine_InvoiceLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2835), Tuple.Create("\"", 2850)
, Tuple.Create(Tuple.Create("", 2842), Tuple.Create("#", 2842), true)
, Tuple.Create(Tuple.Create("", 2843), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2843), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3066), Tuple.Create("\"", 3078)
, Tuple.Create(Tuple.Create("", 3071), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3071), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Add_1.cshtml")]
    public partial class Views_InvLine_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvLine_InvoiceLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_List_1.cshtml")]
    public partial class Views_InvLine_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvLine>>
    {
        public Views_InvLine_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 583)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/InvLine/ListFromQuery/?Clause=", 520), true)
                                                                   , Tuple.Create(Tuple.Create("", 551), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 551), false)
, Tuple.Create(Tuple.Create("", 566), Tuple.Create("&Ord=", 566), true)
                                                                                       , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 571), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Line Number</th><th>Description</th><th>V" +
"AT Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tot" +
"al</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1021), Tuple.Create("\"", 1062)
, Tuple.Create(Tuple.Create("", 1028), Tuple.Create("/InvLine/Load/?RecId=", 1028), true)
               , Tuple.Create(Tuple.Create("", 1049), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1049), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1313), Tuple.Create("\"", 1401)
, Tuple.Create(Tuple.Create("", 1324), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLInvNo/?RecId=", 1324), true)
                                                                     , Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1377), false)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create("\',$(this));", 1390), true)
);
WriteLiteral(" data-bound-name=\'InvLInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1461), Tuple.Create("\'", 1503)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1469), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLInvNo.HTMLValue)
, 1469), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1691), Tuple.Create("\"", 1780)
, Tuple.Create(Tuple.Create("", 1702), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLLineNo/?RecId=", 1702), true)
                                                                      , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1756), false)
, Tuple.Create(Tuple.Create("", 1769), Tuple.Create("\',$(this));", 1769), true)
);
WriteLiteral(" data-bound-name=\'InvLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1841), Tuple.Create("\'", 1884)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1849), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLLineNo.HTMLValue)
, 1849), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2071), Tuple.Create("\"", 2158)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLDesc/?RecId=", 2082), true)
                                                                     , Tuple.Create(Tuple.Create("", 2134), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2134), false)
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create("\',$(this));", 2147), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.InvLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2436), Tuple.Create("\"", 2526)
, Tuple.Create(Tuple.Create("", 2447), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATCode/?RecId=", 2447), true)
                                                                      , Tuple.Create(Tuple.Create("", 2502), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2502), false)
, Tuple.Create(Tuple.Create("", 2515), Tuple.Create("\',$(this));", 2515), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                               Write(Html.Raw(itm.InvLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2810), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2821), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATRate/?RecId=", 2821), true)
                                                                       , Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2876), false)
, Tuple.Create(Tuple.Create("", 2889), Tuple.Create("\',$(this));", 2889), true)
);
WriteLiteral(" data-bound-name=\'InvLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2962), Tuple.Create("\'", 3006)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLVATRate.HTMLValue)
, 2970), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3191), Tuple.Create("\"", 3277)
, Tuple.Create(Tuple.Create("", 3202), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLAmt/?RecId=", 3202), true)
                                                                   , Tuple.Create(Tuple.Create("", 3253), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3253), false)
, Tuple.Create(Tuple.Create("", 3266), Tuple.Create("\',$(this));", 3266), true)
);
WriteLiteral(" data-bound-name=\'InvLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3335), Tuple.Create("\'", 3375)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 3343), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLAmt.HTMLValue)
, 3343), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                            Write(itm.InvLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                  if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3687), Tuple.Create("\"", 3780)
, Tuple.Create(Tuple.Create("", 3698), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLChargeType/?RecId=", 3698), true)
                                                                         , Tuple.Create(Tuple.Create("", 3756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3756), false)
, Tuple.Create(Tuple.Create("", 3769), Tuple.Create("\',$(this));", 3769), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                     Write(Html.Raw(itm.InvLChargeType.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Edit_2.cshtml")]
    public partial class Views_InvLine_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Edit_2_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/InvLine/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.InvLInvNoValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/InvLine/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteLiteral(" id=\"InvoiceLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvLine_InvoiceLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2835), Tuple.Create("\"", 2850)
, Tuple.Create(Tuple.Create("", 2842), Tuple.Create("#", 2842), true)
, Tuple.Create(Tuple.Create("", 2843), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2843), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3066), Tuple.Create("\"", 3078)
, Tuple.Create(Tuple.Create("", 3071), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3071), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Add_2.cshtml")]
    public partial class Views_InvLine_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvLine_InvoiceLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_List_2.cshtml")]
    public partial class Views_InvLine_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvLine>>
    {
        public Views_InvLine_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 583)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/InvLine/ListFromQuery/?Clause=", 520), true)
                                                                   , Tuple.Create(Tuple.Create("", 551), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 551), false)
, Tuple.Create(Tuple.Create("", 566), Tuple.Create("&Ord=", 566), true)
                                                                                       , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 571), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Line Number</th><th>Description</th><th>V" +
"AT Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tot" +
"al</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1021), Tuple.Create("\"", 1062)
, Tuple.Create(Tuple.Create("", 1028), Tuple.Create("/InvLine/Load/?RecId=", 1028), true)
               , Tuple.Create(Tuple.Create("", 1049), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1049), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1313), Tuple.Create("\"", 1401)
, Tuple.Create(Tuple.Create("", 1324), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLInvNo/?RecId=", 1324), true)
                                                                     , Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1377), false)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create("\',$(this));", 1390), true)
);
WriteLiteral(" data-bound-name=\'InvLInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1461), Tuple.Create("\'", 1503)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1469), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLInvNo.HTMLValue)
, 1469), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1691), Tuple.Create("\"", 1780)
, Tuple.Create(Tuple.Create("", 1702), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLLineNo/?RecId=", 1702), true)
                                                                      , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1756), false)
, Tuple.Create(Tuple.Create("", 1769), Tuple.Create("\',$(this));", 1769), true)
);
WriteLiteral(" data-bound-name=\'InvLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1841), Tuple.Create("\'", 1884)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1849), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLLineNo.HTMLValue)
, 1849), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2071), Tuple.Create("\"", 2158)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLDesc/?RecId=", 2082), true)
                                                                     , Tuple.Create(Tuple.Create("", 2134), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2134), false)
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create("\',$(this));", 2147), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.InvLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2436), Tuple.Create("\"", 2526)
, Tuple.Create(Tuple.Create("", 2447), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATCode/?RecId=", 2447), true)
                                                                      , Tuple.Create(Tuple.Create("", 2502), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2502), false)
, Tuple.Create(Tuple.Create("", 2515), Tuple.Create("\',$(this));", 2515), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                               Write(Html.Raw(itm.InvLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2810), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2821), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATRate/?RecId=", 2821), true)
                                                                       , Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2876), false)
, Tuple.Create(Tuple.Create("", 2889), Tuple.Create("\',$(this));", 2889), true)
);
WriteLiteral(" data-bound-name=\'InvLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2962), Tuple.Create("\'", 3006)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLVATRate.HTMLValue)
, 2970), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3191), Tuple.Create("\"", 3277)
, Tuple.Create(Tuple.Create("", 3202), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLAmt/?RecId=", 3202), true)
                                                                   , Tuple.Create(Tuple.Create("", 3253), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3253), false)
, Tuple.Create(Tuple.Create("", 3266), Tuple.Create("\',$(this));", 3266), true)
);
WriteLiteral(" data-bound-name=\'InvLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3335), Tuple.Create("\'", 3375)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 3343), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLAmt.HTMLValue)
, 3343), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                            Write(itm.InvLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                  if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3687), Tuple.Create("\"", 3780)
, Tuple.Create(Tuple.Create("", 3698), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLChargeType/?RecId=", 3698), true)
                                                                         , Tuple.Create(Tuple.Create("", 3756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3756), false)
, Tuple.Create(Tuple.Create("", 3769), Tuple.Create("\',$(this));", 3769), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                     Write(Html.Raw(itm.InvLChargeType.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Edit_3.cshtml")]
    public partial class Views_InvLine_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Edit_3_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/InvLine/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.InvLInvNoValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1557), Tuple.Create("\"", 1580)
, Tuple.Create(Tuple.Create("", 1565), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1565), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1622), Tuple.Create("\"", 1645)
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1630), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/InvLine/ViewHistory/?RecId=", 1950), true)
, Tuple.Create(Tuple.Create("", 1978), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1978), false)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("&dt=", 1993), true)
, Tuple.Create(Tuple.Create("", 1997), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1997), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2636), Tuple.Create("\"", 2651)
, Tuple.Create(Tuple.Create("", 2643), Tuple.Create("#", 2643), true)
, Tuple.Create(Tuple.Create("", 2644), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2644), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2867), Tuple.Create("\"", 2879)
, Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2872), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_Add_3.cshtml")]
    public partial class Views_InvLine_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvLine>
    {
        public Views_InvLine_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvLine>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvLine_List_3.cshtml")]
    public partial class Views_InvLine_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvLine>>
    {
        public Views_InvLine_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 513), Tuple.Create("\"", 583)
, Tuple.Create(Tuple.Create("", 520), Tuple.Create("/InvLine/ListFromQuery/?Clause=", 520), true)
                                                                   , Tuple.Create(Tuple.Create("", 551), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 551), false)
, Tuple.Create(Tuple.Create("", 566), Tuple.Create("&Ord=", 566), true)
                                                                                       , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 571), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Line Number</th><th>Description</th><th>V" +
"AT Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tot" +
"al</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1021), Tuple.Create("\"", 1062)
, Tuple.Create(Tuple.Create("", 1028), Tuple.Create("/InvLine/Load/?RecId=", 1028), true)
               , Tuple.Create(Tuple.Create("", 1049), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1049), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1313), Tuple.Create("\"", 1401)
, Tuple.Create(Tuple.Create("", 1324), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLInvNo/?RecId=", 1324), true)
                                                                     , Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1377), false)
, Tuple.Create(Tuple.Create("", 1390), Tuple.Create("\',$(this));", 1390), true)
);
WriteLiteral(" data-bound-name=\'InvLInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1461), Tuple.Create("\'", 1503)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1469), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLInvNo.HTMLValue)
, 1469), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1691), Tuple.Create("\"", 1780)
, Tuple.Create(Tuple.Create("", 1702), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLLineNo/?RecId=", 1702), true)
                                                                      , Tuple.Create(Tuple.Create("", 1756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1756), false)
, Tuple.Create(Tuple.Create("", 1769), Tuple.Create("\',$(this));", 1769), true)
);
WriteLiteral(" data-bound-name=\'InvLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1841), Tuple.Create("\'", 1884)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1849), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLLineNo.HTMLValue)
, 1849), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2071), Tuple.Create("\"", 2158)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLDesc/?RecId=", 2082), true)
                                                                     , Tuple.Create(Tuple.Create("", 2134), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2134), false)
, Tuple.Create(Tuple.Create("", 2147), Tuple.Create("\',$(this));", 2147), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                          Write(Html.Raw(itm.InvLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2436), Tuple.Create("\"", 2526)
, Tuple.Create(Tuple.Create("", 2447), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATCode/?RecId=", 2447), true)
                                                                      , Tuple.Create(Tuple.Create("", 2502), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2502), false)
, Tuple.Create(Tuple.Create("", 2515), Tuple.Create("\',$(this));", 2515), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                               Write(Html.Raw(itm.InvLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2810), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2821), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLVATRate/?RecId=", 2821), true)
                                                                       , Tuple.Create(Tuple.Create("", 2876), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2876), false)
, Tuple.Create(Tuple.Create("", 2889), Tuple.Create("\',$(this));", 2889), true)
);
WriteLiteral(" data-bound-name=\'InvLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2962), Tuple.Create("\'", 3006)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2970), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLVATRate.HTMLValue)
, 2970), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3191), Tuple.Create("\"", 3277)
, Tuple.Create(Tuple.Create("", 3202), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLAmt/?RecId=", 3202), true)
                                                                   , Tuple.Create(Tuple.Create("", 3253), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3253), false)
, Tuple.Create(Tuple.Create("", 3266), Tuple.Create("\',$(this));", 3266), true)
);
WriteLiteral(" data-bound-name=\'InvLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3335), Tuple.Create("\'", 3375)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 3343), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvLAmt.HTMLValue)
, 3343), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                            Write(itm.InvLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                  if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:15%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3687), Tuple.Create("\"", 3780)
, Tuple.Create(Tuple.Create("", 3698), Tuple.Create("javascript:IQAutoSave(\'/InvLine/SaveInvLChargeType/?RecId=", 3698), true)
                                                                         , Tuple.Create(Tuple.Create("", 3756), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3756), false)
, Tuple.Create(Tuple.Create("", 3769), Tuple.Create("\',$(this));", 3769), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                     Write(Html.Raw(itm.InvLChargeType.HTMLValue));
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
