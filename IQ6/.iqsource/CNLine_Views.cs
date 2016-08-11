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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_CreditNoteLines.cshtml")]
    public partial class Views_CNLine_CreditNoteLines_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_CreditNoteLines_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 62), Tuple.Create("\'", 128)
, Tuple.Create(Tuple.Create("", 70), Tuple.Create("IQLabel101811", 70), true)
, Tuple.Create(Tuple.Create(" ", 83), Tuple.Create<System.Object, System.Int32>(!Model.CNLNo.LabelVisible ? " hide " : ""
, 84), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 129), Tuple.Create("\'", 327)
    , Tuple.Create(Tuple.Create("", 138), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLNo.BackHEXColor) ? "" : "color:" + Model.CNLNo.BackHEXColor + ";"
, 138), false)
, Tuple.Create(Tuple.Create("", 236), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 236), true)
);
WriteLiteral(">Credit Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 422), Tuple.Create("\'", 484)
, Tuple.Create(Tuple.Create("", 430), Tuple.Create("form-control", 430), true)
, Tuple.Create(Tuple.Create("   ", 442), Tuple.Create<System.Object, System.Int32>(!Model.CNLNo.Visible ? " hide " : ""
, 445), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                Write(Model.CNLNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 845), Tuple.Create("\'", 915)
, Tuple.Create(Tuple.Create("", 853), Tuple.Create("IQLabel101812", 853), true)
                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 866), Tuple.Create<System.Object, System.Int32>(!Model.CNLLineNo.LabelVisible ? " hide " : ""
, 867), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 916), Tuple.Create("\'", 1123)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLLineNo.BackHEXColor) ? "" : "color:" + Model.CNLLineNo.BackHEXColor + ";"
, 925), false)
, Tuple.Create(Tuple.Create("", 1031), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1031), true)
);
WriteLiteral(">Line Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLLineNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNLLineNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CNLLineNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLLineNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLLineNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLLineNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.CNLLineNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1723), Tuple.Create("\'", 1797)
, Tuple.Create(Tuple.Create("", 1731), Tuple.Create("IQLabel101813", 1731), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 1744), Tuple.Create<System.Object, System.Int32>(!Model.CNLChargeType.LabelVisible ? " hide " : ""
, 1745), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1798), Tuple.Create("\'", 2013)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1807), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLChargeType.BackHEXColor) ? "" : "color:" + Model.CNLChargeType.BackHEXColor + ";"
, 1807), false)
, Tuple.Create(Tuple.Create("", 1921), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1921), true)
);
WriteLiteral(">Charge Type</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLChargeType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNLChargeType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                            Write(!Model.CNLChargeType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLChargeType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLChargeType/',$(this));\""));
WriteLiteral("   name=\'PopulateCNLChargeType\'  style=\'position: absolute; left:130px;height:21p" +
"x;width:160px;top:53px;\'>\r\n");
             foreach(var itm in Model.CNLChargeType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2650), Tuple.Create("\'", 2671)
, Tuple.Create(Tuple.Create("", 2658), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2658), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNLChargeType.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                              Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2808), Tuple.Create("\'", 2876)
, Tuple.Create(Tuple.Create("", 2816), Tuple.Create("IQLabel101814", 2816), true)
, Tuple.Create(Tuple.Create(" ", 2829), Tuple.Create<System.Object, System.Int32>(!Model.CNLDesc.LabelVisible ? " hide " : ""
, 2830), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2877), Tuple.Create("\'", 3080)
                      , Tuple.Create(Tuple.Create("", 2886), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLDesc.BackHEXColor) ? "" : "color:" + Model.CNLDesc.BackHEXColor + ";"
, 2886), false)
, Tuple.Create(Tuple.Create("", 2988), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2988), true)
);
WriteLiteral(">Description</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:160px;top:78px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description\'");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                                 Write(Model.RecordLocked || !Model.CNLDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.CNLDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCNLDesc\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.PopulateCNLDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateCNLDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4249), Tuple.Create("\'", 4316)
, Tuple.Create(Tuple.Create("", 4257), Tuple.Create("IQLabel101831", 4257), true)
, Tuple.Create(Tuple.Create(" ", 4270), Tuple.Create<System.Object, System.Int32>(!Model.CNLAmt.LabelVisible ? " hide " : ""
, 4271), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4317), Tuple.Create("\'", 4519)
                            , Tuple.Create(Tuple.Create("", 4326), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLAmt.BackHEXColor) ? "" : "color:" + Model.CNLAmt.BackHEXColor + ";"
, 4326), false)
, Tuple.Create(Tuple.Create("", 4426), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 4426), true)
);
WriteLiteral(">Line Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLAmt\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNLAmt.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CNLAmt.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLAmt/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLAmt/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLAmt\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.CNLAmt.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5097), Tuple.Create("\'", 5168)
, Tuple.Create(Tuple.Create("", 5105), Tuple.Create("IQLabel101832", 5105), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 5118), Tuple.Create<System.Object, System.Int32>(!Model.CNLVATCode.LabelVisible ? " hide " : ""
, 5119), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5169), Tuple.Create("\'", 5380)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 5178), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLVATCode.BackHEXColor) ? "" : "color:" + Model.CNLVATCode.BackHEXColor + ";"
, 5178), false)
, Tuple.Create(Tuple.Create("", 5286), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 5286), true)
);
WriteLiteral(">VAT Code</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:140px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLVATCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNLVATCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.CNLVATCode.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLVATCode/',$(this));\""));
WriteLiteral("   name=\'PopulateCNLVATCode\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CNLVATCode.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 6063), Tuple.Create("\'", 6084)
, Tuple.Create(Tuple.Create("", 6071), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 6071), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNLVATCode.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCNLVATCode]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 6970), Tuple.Create("\'", 7041)
, Tuple.Create(Tuple.Create("", 6978), Tuple.Create("IQLabel101833", 6978), true)
, Tuple.Create(Tuple.Create(" ", 6991), Tuple.Create<System.Object, System.Int32>(!Model.CNLVATRate.LabelVisible ? " hide " : ""
, 6992), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7042), Tuple.Create("\'", 7253)
                            , Tuple.Create(Tuple.Create("", 7051), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLVATRate.BackHEXColor) ? "" : "color:" + Model.CNLVATRate.BackHEXColor + ";"
, 7051), false)
, Tuple.Create(Tuple.Create("", 7159), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 7159), true)
);
WriteLiteral(">VAT Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLVATRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNLVATRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.CNLVATRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLVATRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLVATRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.CNLVATRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 7857), Tuple.Create("\'", 7927)
, Tuple.Create(Tuple.Create("", 7865), Tuple.Create("IQLabel101834", 7865), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 7878), Tuple.Create<System.Object, System.Int32>(!Model.CNLVATAmt.LabelVisible ? " hide " : ""
, 7879), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7928), Tuple.Create("\'", 8137)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 7937), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLVATAmt.BackHEXColor) ? "" : "color:" + Model.CNLVATAmt.BackHEXColor + ";"
, 7937), false)
, Tuple.Create(Tuple.Create("", 8043), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 8043), true)
);
WriteLiteral(">VAT Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLVATAmt\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 8233), Tuple.Create("\'", 8299)
, Tuple.Create(Tuple.Create("", 8241), Tuple.Create("form-control", 8241), true)
, Tuple.Create(Tuple.Create("   ", 8253), Tuple.Create<System.Object, System.Int32>(!Model.CNLVATAmt.Visible ? " hide " : ""
, 8256), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATAmt/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLVATAmt/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLVATAmt\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                Write(Model.CNLVATAmt.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 8677), Tuple.Create("\'", 8746)
, Tuple.Create(Tuple.Create("", 8685), Tuple.Create("IQLabel101835", 8685), true)
                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 8698), Tuple.Create<System.Object, System.Int32>(!Model.CNLTotal.LabelVisible ? " hide " : ""
, 8699), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8747), Tuple.Create("\'", 8955)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 8756), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNLTotal.BackHEXColor) ? "" : "color:" + Model.CNLTotal.BackHEXColor + ";"
, 8756), false)
, Tuple.Create(Tuple.Create("", 8860), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:103px;", 8860), true)
);
WriteLiteral(">Line Total</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNoteLines_CNLTotal\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 9050), Tuple.Create("\'", 9115)
, Tuple.Create(Tuple.Create("", 9058), Tuple.Create("form-control", 9058), true)
, Tuple.Create(Tuple.Create("   ", 9070), Tuple.Create<System.Object, System.Int32>(!Model.CNLTotal.Visible ? " hide " : ""
, 9073), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLTotal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CNLine/CallbackCNLTotal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNLTotal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.CNLTotal.ValueFormatted);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Edit_1.cshtml")]
    public partial class Views_CNLine_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Edit_1_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 333), Tuple.Create("\'", 393)
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/CNLine/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CNLine" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CNLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1284), Tuple.Create("\'", 1306)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1292), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1376)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CNLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.CNLNoValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1547), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1555), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1555), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1612), Tuple.Create("\"", 1635)
, Tuple.Create(Tuple.Create("", 1620), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1620), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CNLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1932), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1939), Tuple.Create("/CNLine/ViewHistory/?RecId=", 1939), true)
, Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1966), false)
, Tuple.Create(Tuple.Create("", 1981), Tuple.Create("&dt=", 1981), true)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1985), false)
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
WriteLiteral(" id=\"CreditNoteLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CNLine_CreditNoteLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2828), Tuple.Create("\"", 2843)
, Tuple.Create(Tuple.Create("", 2835), Tuple.Create("#", 2835), true)
, Tuple.Create(Tuple.Create("", 2836), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2836), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3059), Tuple.Create("\"", 3071)
, Tuple.Create(Tuple.Create("", 3064), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3064), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Add_1.cshtml")]
    public partial class Views_CNLine_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Note Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Note Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CNLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CreditNoteLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CNLine_CreditNoteLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_List_1.cshtml")]
    public partial class Views_CNLine_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CNLine>>
    {
        public Views_CNLine_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Note Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Note Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Note Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 591)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/CNLine/ListFromQuery/?Clause=", 529), true)
                                                                  , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 559), false)
, Tuple.Create(Tuple.Create("", 574), Tuple.Create("&Ord=", 574), true)
                                                                                      , Tuple.Create(Tuple.Create("", 579), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 579), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Line Number</th><th>Description</th><th>VA" +
"T Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tota" +
"l</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1028), Tuple.Create("\"", 1068)
, Tuple.Create(Tuple.Create("", 1035), Tuple.Create("/CNLine/Load/?RecId=", 1035), true)
              , Tuple.Create(Tuple.Create("", 1055), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1055), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNLNo.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1375), Tuple.Create("\"", 1462)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLLineNo/?RecId=", 1386), true)
                                                                    , Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1438), false)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create("\',$(this));", 1451), true)
);
WriteLiteral(" data-bound-name=\'CNLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1522), Tuple.Create("\'", 1564)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLLineNo.HTMLValue)
, 1530), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1750), Tuple.Create("\"", 1835)
, Tuple.Create(Tuple.Create("", 1761), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLDesc/?RecId=", 1761), true)
                                                                   , Tuple.Create(Tuple.Create("", 1811), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1811), false)
, Tuple.Create(Tuple.Create("", 1824), Tuple.Create("\',$(this));", 1824), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                       Write(Html.Raw(itm.CNLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2110), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATCode/?RecId=", 2121), true)
                                                                    , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                            Write(Html.Raw(itm.CNLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2479), Tuple.Create("\"", 2567)
, Tuple.Create(Tuple.Create("", 2490), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATRate/?RecId=", 2490), true)
                                                                     , Tuple.Create(Tuple.Create("", 2543), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2543), false)
, Tuple.Create(Tuple.Create("", 2556), Tuple.Create("\',$(this));", 2556), true)
);
WriteLiteral(" data-bound-name=\'CNLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2628), Tuple.Create("\'", 2671)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2636), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLVATRate.HTMLValue)
, 2636), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2856), Tuple.Create("\"", 2940)
, Tuple.Create(Tuple.Create("", 2867), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLAmt/?RecId=", 2867), true)
                                                                  , Tuple.Create(Tuple.Create("", 2916), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2916), false)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create("\',$(this));", 2929), true)
);
WriteLiteral(" data-bound-name=\'CNLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2997), Tuple.Create("\'", 3036)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3005), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLAmt.HTMLValue)
, 3005), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                           Write(itm.CNLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3345), Tuple.Create("\"", 3436)
, Tuple.Create(Tuple.Create("", 3356), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLChargeType/?RecId=", 3356), true)
                                                                       , Tuple.Create(Tuple.Create("", 3412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3412), false)
, Tuple.Create(Tuple.Create("", 3425), Tuple.Create("\',$(this));", 3425), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.CNLChargeType.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Edit_2.cshtml")]
    public partial class Views_CNLine_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Edit_2_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 333), Tuple.Create("\'", 393)
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/CNLine/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CNLine" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CNLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1284), Tuple.Create("\'", 1306)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1292), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1376)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CNLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.CNLNoValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1547), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1555), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1555), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1612), Tuple.Create("\"", 1635)
, Tuple.Create(Tuple.Create("", 1620), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1620), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CNLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1932), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1939), Tuple.Create("/CNLine/ViewHistory/?RecId=", 1939), true)
, Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1966), false)
, Tuple.Create(Tuple.Create("", 1981), Tuple.Create("&dt=", 1981), true)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1985), false)
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
WriteLiteral(" id=\"CreditNoteLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CNLine_CreditNoteLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2828), Tuple.Create("\"", 2843)
, Tuple.Create(Tuple.Create("", 2835), Tuple.Create("#", 2835), true)
, Tuple.Create(Tuple.Create("", 2836), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2836), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3059), Tuple.Create("\"", 3071)
, Tuple.Create(Tuple.Create("", 3064), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3064), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Add_2.cshtml")]
    public partial class Views_CNLine_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Note Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Note Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CNLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CreditNoteLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CNLine_CreditNoteLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_List_2.cshtml")]
    public partial class Views_CNLine_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CNLine>>
    {
        public Views_CNLine_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Note Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Note Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Note Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 591)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/CNLine/ListFromQuery/?Clause=", 529), true)
                                                                  , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 559), false)
, Tuple.Create(Tuple.Create("", 574), Tuple.Create("&Ord=", 574), true)
                                                                                      , Tuple.Create(Tuple.Create("", 579), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 579), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Line Number</th><th>Description</th><th>VA" +
"T Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tota" +
"l</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1028), Tuple.Create("\"", 1068)
, Tuple.Create(Tuple.Create("", 1035), Tuple.Create("/CNLine/Load/?RecId=", 1035), true)
              , Tuple.Create(Tuple.Create("", 1055), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1055), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNLNo.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1375), Tuple.Create("\"", 1462)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLLineNo/?RecId=", 1386), true)
                                                                    , Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1438), false)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create("\',$(this));", 1451), true)
);
WriteLiteral(" data-bound-name=\'CNLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1522), Tuple.Create("\'", 1564)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLLineNo.HTMLValue)
, 1530), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1750), Tuple.Create("\"", 1835)
, Tuple.Create(Tuple.Create("", 1761), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLDesc/?RecId=", 1761), true)
                                                                   , Tuple.Create(Tuple.Create("", 1811), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1811), false)
, Tuple.Create(Tuple.Create("", 1824), Tuple.Create("\',$(this));", 1824), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                       Write(Html.Raw(itm.CNLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2110), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATCode/?RecId=", 2121), true)
                                                                    , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                            Write(Html.Raw(itm.CNLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2479), Tuple.Create("\"", 2567)
, Tuple.Create(Tuple.Create("", 2490), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATRate/?RecId=", 2490), true)
                                                                     , Tuple.Create(Tuple.Create("", 2543), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2543), false)
, Tuple.Create(Tuple.Create("", 2556), Tuple.Create("\',$(this));", 2556), true)
);
WriteLiteral(" data-bound-name=\'CNLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2628), Tuple.Create("\'", 2671)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2636), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLVATRate.HTMLValue)
, 2636), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2856), Tuple.Create("\"", 2940)
, Tuple.Create(Tuple.Create("", 2867), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLAmt/?RecId=", 2867), true)
                                                                  , Tuple.Create(Tuple.Create("", 2916), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2916), false)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create("\',$(this));", 2929), true)
);
WriteLiteral(" data-bound-name=\'CNLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2997), Tuple.Create("\'", 3036)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3005), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLAmt.HTMLValue)
, 3005), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                           Write(itm.CNLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3345), Tuple.Create("\"", 3436)
, Tuple.Create(Tuple.Create("", 3356), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLChargeType/?RecId=", 3356), true)
                                                                       , Tuple.Create(Tuple.Create("", 3412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3412), false)
, Tuple.Create(Tuple.Create("", 3425), Tuple.Create("\',$(this));", 3425), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.CNLChargeType.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Edit_3.cshtml")]
    public partial class Views_CNLine_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Edit_3_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 333), Tuple.Create("\'", 393)
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/CNLine/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CNLine" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CNLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1284), Tuple.Create("\'", 1306)
, Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1292), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1376)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CNLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.CNLNoValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1547), Tuple.Create("\"", 1570)
, Tuple.Create(Tuple.Create("", 1555), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1555), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1612), Tuple.Create("\"", 1635)
, Tuple.Create(Tuple.Create("", 1620), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1620), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CNLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1932), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1939), Tuple.Create("/CNLine/ViewHistory/?RecId=", 1939), true)
, Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1966), false)
, Tuple.Create(Tuple.Create("", 1981), Tuple.Create("&dt=", 1981), true)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1985), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2624), Tuple.Create("\"", 2639)
, Tuple.Create(Tuple.Create("", 2631), Tuple.Create("#", 2631), true)
, Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2632), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2855), Tuple.Create("\"", 2867)
, Tuple.Create(Tuple.Create("", 2860), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2860), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_Add_3.cshtml")]
    public partial class Views_CNLine_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CNLine>
    {
        public Views_CNLine_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Note Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Note Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CNLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CNLine>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CNLine_List_3.cshtml")]
    public partial class Views_CNLine_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CNLine>>
    {
        public Views_CNLine_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Note Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Note Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Note Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CNLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 522), Tuple.Create("\"", 591)
, Tuple.Create(Tuple.Create("", 529), Tuple.Create("/CNLine/ListFromQuery/?Clause=", 529), true)
                                                                  , Tuple.Create(Tuple.Create("", 559), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 559), false)
, Tuple.Create(Tuple.Create("", 574), Tuple.Create("&Ord=", 574), true)
                                                                                      , Tuple.Create(Tuple.Create("", 579), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 579), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Line Number</th><th>Description</th><th>VA" +
"T Code</th><th>VAT Rate</th><th>Line Amount</th><th>VAT Amount</th><th>Line Tota" +
"l</th><th>Charge Type</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1028), Tuple.Create("\"", 1068)
, Tuple.Create(Tuple.Create("", 1035), Tuple.Create("/CNLine/Load/?RecId=", 1035), true)
              , Tuple.Create(Tuple.Create("", 1055), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1055), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNLNo.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1375), Tuple.Create("\"", 1462)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLLineNo/?RecId=", 1386), true)
                                                                    , Tuple.Create(Tuple.Create("", 1438), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1438), false)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create("\',$(this));", 1451), true)
);
WriteLiteral(" data-bound-name=\'CNLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1522), Tuple.Create("\'", 1564)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLLineNo.HTMLValue)
, 1530), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1750), Tuple.Create("\"", 1835)
, Tuple.Create(Tuple.Create("", 1761), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLDesc/?RecId=", 1761), true)
                                                                   , Tuple.Create(Tuple.Create("", 1811), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1811), false)
, Tuple.Create(Tuple.Create("", 1824), Tuple.Create("\',$(this));", 1824), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLDesc\'");
WriteLiteral(">");
                                                                                                                                                                                                                       Write(Html.Raw(itm.CNLDesc.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2110), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2121), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATCode/?RecId=", 2121), true)
                                                                    , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLVATCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                            Write(Html.Raw(itm.CNLVATCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLVATRate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2479), Tuple.Create("\"", 2567)
, Tuple.Create(Tuple.Create("", 2490), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLVATRate/?RecId=", 2490), true)
                                                                     , Tuple.Create(Tuple.Create("", 2543), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2543), false)
, Tuple.Create(Tuple.Create("", 2556), Tuple.Create("\',$(this));", 2556), true)
);
WriteLiteral(" data-bound-name=\'CNLVATRate\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2628), Tuple.Create("\'", 2671)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2636), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLVATRate.HTMLValue)
, 2636), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2856), Tuple.Create("\"", 2940)
, Tuple.Create(Tuple.Create("", 2867), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLAmt/?RecId=", 2867), true)
                                                                  , Tuple.Create(Tuple.Create("", 2916), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2916), false)
, Tuple.Create(Tuple.Create("", 2929), Tuple.Create("\',$(this));", 2929), true)
);
WriteLiteral(" data-bound-name=\'CNLAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2997), Tuple.Create("\'", 3036)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3005), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNLAmt.HTMLValue)
, 3005), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNLVATAmt.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                           Write(itm.CNLTotal.DisplayValue);
WriteLiteral("</td>");
                                                                                                                                                if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNLChargeType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3345), Tuple.Create("\"", 3436)
, Tuple.Create(Tuple.Create("", 3356), Tuple.Create("javascript:IQAutoSave(\'/CNLine/SaveCNLChargeType/?RecId=", 3356), true)
                                                                       , Tuple.Create(Tuple.Create("", 3412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3412), false)
, Tuple.Create(Tuple.Create("", 3425), Tuple.Create("\',$(this));", 3425), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNLChargeType\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.CNLChargeType.HTMLValue));
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
