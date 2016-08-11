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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_REDSOrderLines.cshtml")]
    public partial class Views_REDSOrdLine_REDSOrderLines_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_REDSOrderLines_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 67), Tuple.Create("\'", 136)
, Tuple.Create(Tuple.Create("", 75), Tuple.Create("IQLabel103711", 75), true)
, Tuple.Create(Tuple.Create(" ", 88), Tuple.Create<System.Object, System.Int32>(!Model.RDOLRDId.LabelVisible ? " hide " : ""
, 89), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 137), Tuple.Create("\'", 341)
       , Tuple.Create(Tuple.Create("", 146), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLRDId.BackHEXColor) ? "" : "color:" + Model.RDOLRDId.BackHEXColor + ";"
, 146), false)
, Tuple.Create(Tuple.Create("", 250), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 250), true)
);
WriteLiteral(">REDS ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLRDId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 432), Tuple.Create("\'", 497)
, Tuple.Create(Tuple.Create("", 440), Tuple.Create("form-control", 440), true)
, Tuple.Create(Tuple.Create("   ", 452), Tuple.Create<System.Object, System.Int32>(!Model.RDOLRDId.Visible ? " hide " : ""
, 455), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLRDId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLRDId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLRDId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.RDOLRDId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 880), Tuple.Create("\'", 951)
, Tuple.Create(Tuple.Create("", 888), Tuple.Create("IQLabel103712", 888), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 901), Tuple.Create<System.Object, System.Int32>(!Model.RDOLLineNo.LabelVisible ? " hide " : ""
, 902), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 952), Tuple.Create("\'", 1161)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 961), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLLineNo.BackHEXColor) ? "" : "color:" + Model.RDOLLineNo.BackHEXColor + ";"
, 961), false)
, Tuple.Create(Tuple.Create("", 1069), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1069), true)
);
WriteLiteral(">Line Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLLineNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLLineNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.RDOLLineNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLineNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLLineNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLLineNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOLLineNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1777), Tuple.Create("\'", 1847)
, Tuple.Create(Tuple.Create("", 1785), Tuple.Create("IQLabel103713", 1785), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 1798), Tuple.Create<System.Object, System.Int32>(!Model.RDOLCases.LabelVisible ? " hide " : ""
, 1799), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1848), Tuple.Create("\'", 2055)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLCases.BackHEXColor) ? "" : "color:" + Model.RDOLCases.BackHEXColor + ";"
, 1857), false)
, Tuple.Create(Tuple.Create("", 1963), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1963), true)
);
WriteLiteral(">Cases</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLCases\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLCases.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.RDOLCases.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLCases/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLCases/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLCases\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.RDOLCases.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2658), Tuple.Create("\'", 2733)
, Tuple.Create(Tuple.Create("", 2666), Tuple.Create("IQLabel103714", 2666), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 2679), Tuple.Create<System.Object, System.Int32>(!Model.RDOLBottleCase.LabelVisible ? " hide " : ""
, 2680), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2734), Tuple.Create("\'", 2951)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2743), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLBottleCase.BackHEXColor) ? "" : "color:" + Model.RDOLBottleCase.BackHEXColor + ";"
, 2743), false)
, Tuple.Create(Tuple.Create("", 2859), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2859), true)
);
WriteLiteral(">Bottles per Case</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLBottleCase\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLBottleCase.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.RDOLBottleCase.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLBottleCase/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLBottleCase/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLBottleCase\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.RDOLBottleCase.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:50px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3600), Tuple.Create("\'", 3675)
, Tuple.Create(Tuple.Create("", 3608), Tuple.Create("IQLabel103715", 3608), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 3621), Tuple.Create<System.Object, System.Int32>(!Model.RDOLBottleSize.LabelVisible ? " hide " : ""
, 3622), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3676), Tuple.Create("\'", 3894)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 3685), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLBottleSize.BackHEXColor) ? "" : "color:" + Model.RDOLBottleSize.BackHEXColor + ";"
, 3685), false)
, Tuple.Create(Tuple.Create("", 3801), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3801), true)
);
WriteLiteral(">Bottle Size (cl)</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLBottleSize\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLBottleSize.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.RDOLBottleSize.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLBottleSize/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLBottleSize/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLBottleSize\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.RDOLBottleSize.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 4544), Tuple.Create("\'", 4615)
, Tuple.Create(Tuple.Create("", 4552), Tuple.Create("IQLabel103716", 4552), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 4565), Tuple.Create<System.Object, System.Int32>(!Model.RDOLAlcPct.LabelVisible ? " hide " : ""
, 4566), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4616), Tuple.Create("\'", 4826)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 4625), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLAlcPct.BackHEXColor) ? "" : "color:" + Model.RDOLAlcPct.BackHEXColor + ";"
, 4625), false)
, Tuple.Create(Tuple.Create("", 4733), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 4733), true)
);
WriteLiteral(">Alcohol Percentage</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLAlcPct\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLAlcPct.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.RDOLAlcPct.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLAlcPct/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLAlcPct/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLAlcPct\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOLAlcPct.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:153px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5450), Tuple.Create("\'", 5521)
, Tuple.Create(Tuple.Create("", 5458), Tuple.Create("IQLabel103717", 5458), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 5471), Tuple.Create<System.Object, System.Int32>(!Model.RDOLLitres.LabelVisible ? " hide " : ""
, 5472), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5522), Tuple.Create("\'", 5732)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 5531), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLLitres.BackHEXColor) ? "" : "color:" + Model.RDOLLitres.BackHEXColor + ";"
, 5531), false)
, Tuple.Create(Tuple.Create("", 5639), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 5639), true)
);
WriteLiteral(">Litres</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLLitres\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLLitres.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.RDOLLitres.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLitres/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLLitres/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLLitres\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOLLitres.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6344), Tuple.Create("\'", 6416)
, Tuple.Create(Tuple.Create("", 6352), Tuple.Create("IQLabel103718", 6352), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 6365), Tuple.Create<System.Object, System.Int32>(!Model.RDOLDutyDue.LabelVisible ? " hide " : ""
, 6366), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6417), Tuple.Create("\'", 6629)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 6426), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLDutyDue.BackHEXColor) ? "" : "color:" + Model.RDOLDutyDue.BackHEXColor + ";"
, 6426), false)
, Tuple.Create(Tuple.Create("", 6536), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 6536), true)
);
WriteLiteral(">Duty Due</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLDutyDue\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 6724), Tuple.Create("\'", 6792)
, Tuple.Create(Tuple.Create("", 6732), Tuple.Create("form-control", 6732), true)
, Tuple.Create(Tuple.Create("   ", 6744), Tuple.Create<System.Object, System.Int32>(!Model.RDOLDutyDue.Visible ? " hide " : ""
, 6747), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLDutyDue/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLDutyDue/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOLDutyDue\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.RDOLDutyDue.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:203px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 7189), Tuple.Create("\'", 7260)
, Tuple.Create(Tuple.Create("", 7197), Tuple.Create("IQLabel103719", 7197), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 7210), Tuple.Create<System.Object, System.Int32>(!Model.RDOLLocked.LabelVisible ? " hide " : ""
, 7211), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7261), Tuple.Create("\'", 7471)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 7270), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLLocked.BackHEXColor) ? "" : "color:" + Model.RDOLLocked.BackHEXColor + ";"
, 7270), false)
, Tuple.Create(Tuple.Create("", 7378), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 7378), true)
);
WriteLiteral(">Locked</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLLocked\'");
WriteAttribute("class", Tuple.Create(" class=\'", 7548), Tuple.Create("\'", 7602)
, Tuple.Create(Tuple.Create("  ", 7556), Tuple.Create<System.Object, System.Int32>(!Model.RDOLLocked.Visible ? " hide " : ""
, 7558), false)
);
WriteLiteral(" ");
                                                                                                              Write(Model.RecordLocked || !Model.RDOLLocked.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLocked/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLLocked/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:228px;\' name=\'" +
"PopulateRDOLLocked\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.PopulateRDOLLocked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateRDOLLocked\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                 Write(!Model.PopulateRDOLLocked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 8238), Tuple.Create("\'", 8310)
, Tuple.Create(Tuple.Create("", 8246), Tuple.Create("IQLabel103720", 8246), true)
, Tuple.Create(Tuple.Create(" ", 8259), Tuple.Create<System.Object, System.Int32>(!Model.RDOLTaxCode.LabelVisible ? " hide " : ""
, 8260), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8311), Tuple.Create("\'", 8523)
                 , Tuple.Create(Tuple.Create("", 8320), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOLTaxCode.BackHEXColor) ? "" : "color:" + Model.RDOLTaxCode.BackHEXColor + ";"
, 8320), false)
, Tuple.Create(Tuple.Create("", 8430), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 8430), true)
);
WriteLiteral(">Tax Code</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'REDSOrderLines_RDOLTaxCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOLTaxCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                   Write(!Model.RDOLTaxCode.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLTaxCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrdLine/CallbackRDOLTaxCode/',$(this));\""));
WriteLiteral("   name=\'PopulateRDOLTaxCode\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.RDOLTaxCode.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 9232), Tuple.Create("\'", 9253)
, Tuple.Create(Tuple.Create("", 9240), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 9240), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateRDOLTaxCode.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateRDOLTaxCode]\"");
WriteLiteral(" data-url=\"/REDSTax/Load/?RDTaxId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/REDSTax/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All REDS Tax Codes</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Edit_1.cshtml")]
    public partial class Views_REDSOrdLine_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Edit_1_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 338), Tuple.Create("\'", 403)
, Tuple.Create(Tuple.Create("", 348), Tuple.Create("IQJSCall(\"/REDSOrdLine/Delete/?RecId=", 348), true)
            , Tuple.Create(Tuple.Create("", 385), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 385), false)
, Tuple.Create(Tuple.Create("", 400), Tuple.Create("\");", 400), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"dLine/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrdLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1309), Tuple.Create("\'", 1331)
, Tuple.Create(Tuple.Create("", 1317), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1317), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1377), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1385), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrdLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1506), Tuple.Create("\"", 1534)
, Tuple.Create(Tuple.Create("", 1514), Tuple.Create<System.Object, System.Int32>(Model.RDOLRDIdValue
, 1514), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1580), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1588), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1645), Tuple.Create("\"", 1668)
, Tuple.Create(Tuple.Create("", 1653), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1653), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrdLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1970), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1977), Tuple.Create("/REDSOrdLine/ViewHistory/?RecId=", 1977), true)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2009), false)
, Tuple.Create(Tuple.Create("", 2024), Tuple.Create("&dt=", 2024), true)
, Tuple.Create(Tuple.Create("", 2028), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2028), false)
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
WriteLiteral(" id=\"REDSOrderLines\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrdLine_REDSOrderLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2874), Tuple.Create("\"", 2889)
, Tuple.Create(Tuple.Create("", 2881), Tuple.Create("#", 2881), true)
, Tuple.Create(Tuple.Create("", 2882), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2882), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3105), Tuple.Create("\"", 3117)
, Tuple.Create(Tuple.Create("", 3110), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3110), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Add_1.cshtml")]
    public partial class Views_REDSOrdLine_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrdLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSOrderLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrdLine_REDSOrderLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_List_1.cshtml")]
    public partial class Views_REDSOrdLine_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrdLine>>
    {
        public Views_REDSOrdLine_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 534), Tuple.Create("\"", 608)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("/REDSOrdLine/ListFromQuery/?Clause=", 541), true)
                                                                       , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 576), false)
, Tuple.Create(Tuple.Create("", 591), Tuple.Create("&Ord=", 591), true)
                                                                                           , Tuple.Create(Tuple.Create("", 596), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 596), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Line Number</th><th>Cases</th><th>Bottles per Case</th><th>Bottl" +
"e Size (cl)</th><th>Tax Code</th><th>Alcohol Percentage</th><th>Duty Due</th><th" +
">Locked</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1031), Tuple.Create("\"", 1076)
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create("/REDSOrdLine/Load/?RecId=", 1038), true)
                   , Tuple.Create(Tuple.Create("", 1063), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1063), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1329), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1340), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLineNo/?RecId=", 1340), true)
                                                                           , Tuple.Create(Tuple.Create("", 1398), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1398), false)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("\',$(this));", 1411), true)
);
WriteLiteral(" data-bound-name=\'RDOLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1483), Tuple.Create("\'", 1526)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1491), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLLineNo.HTMLValue)
, 1491), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLCases.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1714), Tuple.Create("\"", 1806)
, Tuple.Create(Tuple.Create("", 1725), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLCases/?RecId=", 1725), true)
                                                                          , Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1782), false)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("\',$(this));", 1795), true)
);
WriteLiteral(" data-bound-name=\'RDOLCases\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1866), Tuple.Create("\'", 1908)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1874), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLCases.HTMLValue)
, 1874), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleCase.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2100), Tuple.Create("\"", 2197)
, Tuple.Create(Tuple.Create("", 2111), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleCase/?RecId=", 2111), true)
                                                                              , Tuple.Create(Tuple.Create("", 2173), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2173), false)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("\',$(this));", 2186), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleCase\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2262), Tuple.Create("\'", 2309)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2270), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleCase.HTMLValue)
, 2270), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2502), Tuple.Create("\"", 2599)
, Tuple.Create(Tuple.Create("", 2513), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleSize/?RecId=", 2513), true)
                                                                               , Tuple.Create(Tuple.Create("", 2575), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2575), false)
, Tuple.Create(Tuple.Create("", 2588), Tuple.Create("\',$(this));", 2588), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2664), Tuple.Create("\'", 2711)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2672), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleSize.HTMLValue)
, 2672), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2899), Tuple.Create("\"", 2993)
, Tuple.Create(Tuple.Create("", 2910), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLTaxCode/?RecId=", 2910), true)
                                                                          , Tuple.Create(Tuple.Create("", 2969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2969), false)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("\',$(this));", 2982), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'RDOLTaxCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.RDOLTaxCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLAlcPct.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3277), Tuple.Create("\"", 3370)
, Tuple.Create(Tuple.Create("", 3288), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLAlcPct/?RecId=", 3288), true)
                                                                           , Tuple.Create(Tuple.Create("", 3346), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3346), false)
, Tuple.Create(Tuple.Create("", 3359), Tuple.Create("\',$(this));", 3359), true)
);
WriteLiteral(" data-bound-name=\'RDOLAlcPct\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3431), Tuple.Create("\'", 3474)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3439), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLAlcPct.HTMLValue)
, 3439), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOLDutyDue.DisplayValue);
WriteLiteral("</td>");
                                                                                       if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLocked.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3706), Tuple.Create("\"", 3798)
, Tuple.Create(Tuple.Create("", 3716), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLocked/?RecId=", 3716), true)
                                                       , Tuple.Create(Tuple.Create("", 3774), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3774), false)
, Tuple.Create(Tuple.Create("", 3787), Tuple.Create("\',$(this));", 3787), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'RDOLLocked\'");
WriteLiteral(" ");
                                                                                                                                                                                                      Write(Html.Raw(itm.RDOLLocked.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'RDOLLocked\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Edit_2.cshtml")]
    public partial class Views_REDSOrdLine_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Edit_2_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 338), Tuple.Create("\'", 403)
, Tuple.Create(Tuple.Create("", 348), Tuple.Create("IQJSCall(\"/REDSOrdLine/Delete/?RecId=", 348), true)
            , Tuple.Create(Tuple.Create("", 385), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 385), false)
, Tuple.Create(Tuple.Create("", 400), Tuple.Create("\");", 400), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"dLine/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrdLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1309), Tuple.Create("\'", 1331)
, Tuple.Create(Tuple.Create("", 1317), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1317), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1377), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1385), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrdLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1506), Tuple.Create("\"", 1534)
, Tuple.Create(Tuple.Create("", 1514), Tuple.Create<System.Object, System.Int32>(Model.RDOLRDIdValue
, 1514), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1580), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1588), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1645), Tuple.Create("\"", 1668)
, Tuple.Create(Tuple.Create("", 1653), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1653), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrdLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1970), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1977), Tuple.Create("/REDSOrdLine/ViewHistory/?RecId=", 1977), true)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2009), false)
, Tuple.Create(Tuple.Create("", 2024), Tuple.Create("&dt=", 2024), true)
, Tuple.Create(Tuple.Create("", 2028), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2028), false)
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
WriteLiteral(" id=\"REDSOrderLines\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrdLine_REDSOrderLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2874), Tuple.Create("\"", 2889)
, Tuple.Create(Tuple.Create("", 2881), Tuple.Create("#", 2881), true)
, Tuple.Create(Tuple.Create("", 2882), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2882), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3105), Tuple.Create("\"", 3117)
, Tuple.Create(Tuple.Create("", 3110), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3110), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Add_2.cshtml")]
    public partial class Views_REDSOrdLine_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrdLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSOrderLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrdLine_REDSOrderLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_List_2.cshtml")]
    public partial class Views_REDSOrdLine_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrdLine>>
    {
        public Views_REDSOrdLine_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 534), Tuple.Create("\"", 608)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("/REDSOrdLine/ListFromQuery/?Clause=", 541), true)
                                                                       , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 576), false)
, Tuple.Create(Tuple.Create("", 591), Tuple.Create("&Ord=", 591), true)
                                                                                           , Tuple.Create(Tuple.Create("", 596), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 596), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Line Number</th><th>Cases</th><th>Bottles per Case</th><th>Bottl" +
"e Size (cl)</th><th>Tax Code</th><th>Alcohol Percentage</th><th>Duty Due</th><th" +
">Locked</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1031), Tuple.Create("\"", 1076)
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create("/REDSOrdLine/Load/?RecId=", 1038), true)
                   , Tuple.Create(Tuple.Create("", 1063), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1063), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1329), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1340), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLineNo/?RecId=", 1340), true)
                                                                           , Tuple.Create(Tuple.Create("", 1398), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1398), false)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("\',$(this));", 1411), true)
);
WriteLiteral(" data-bound-name=\'RDOLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1483), Tuple.Create("\'", 1526)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1491), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLLineNo.HTMLValue)
, 1491), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLCases.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1714), Tuple.Create("\"", 1806)
, Tuple.Create(Tuple.Create("", 1725), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLCases/?RecId=", 1725), true)
                                                                          , Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1782), false)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("\',$(this));", 1795), true)
);
WriteLiteral(" data-bound-name=\'RDOLCases\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1866), Tuple.Create("\'", 1908)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1874), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLCases.HTMLValue)
, 1874), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleCase.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2100), Tuple.Create("\"", 2197)
, Tuple.Create(Tuple.Create("", 2111), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleCase/?RecId=", 2111), true)
                                                                              , Tuple.Create(Tuple.Create("", 2173), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2173), false)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("\',$(this));", 2186), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleCase\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2262), Tuple.Create("\'", 2309)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2270), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleCase.HTMLValue)
, 2270), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2502), Tuple.Create("\"", 2599)
, Tuple.Create(Tuple.Create("", 2513), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleSize/?RecId=", 2513), true)
                                                                               , Tuple.Create(Tuple.Create("", 2575), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2575), false)
, Tuple.Create(Tuple.Create("", 2588), Tuple.Create("\',$(this));", 2588), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2664), Tuple.Create("\'", 2711)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2672), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleSize.HTMLValue)
, 2672), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2899), Tuple.Create("\"", 2993)
, Tuple.Create(Tuple.Create("", 2910), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLTaxCode/?RecId=", 2910), true)
                                                                          , Tuple.Create(Tuple.Create("", 2969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2969), false)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("\',$(this));", 2982), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'RDOLTaxCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.RDOLTaxCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLAlcPct.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3277), Tuple.Create("\"", 3370)
, Tuple.Create(Tuple.Create("", 3288), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLAlcPct/?RecId=", 3288), true)
                                                                           , Tuple.Create(Tuple.Create("", 3346), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3346), false)
, Tuple.Create(Tuple.Create("", 3359), Tuple.Create("\',$(this));", 3359), true)
);
WriteLiteral(" data-bound-name=\'RDOLAlcPct\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3431), Tuple.Create("\'", 3474)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3439), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLAlcPct.HTMLValue)
, 3439), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOLDutyDue.DisplayValue);
WriteLiteral("</td>");
                                                                                       if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLocked.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3706), Tuple.Create("\"", 3798)
, Tuple.Create(Tuple.Create("", 3716), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLocked/?RecId=", 3716), true)
                                                       , Tuple.Create(Tuple.Create("", 3774), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3774), false)
, Tuple.Create(Tuple.Create("", 3787), Tuple.Create("\',$(this));", 3787), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'RDOLLocked\'");
WriteLiteral(" ");
                                                                                                                                                                                                      Write(Html.Raw(itm.RDOLLocked.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'RDOLLocked\' value=\'false\'  /></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Edit_3.cshtml")]
    public partial class Views_REDSOrdLine_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Edit_3_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 338), Tuple.Create("\'", 403)
, Tuple.Create(Tuple.Create("", 348), Tuple.Create("IQJSCall(\"/REDSOrdLine/Delete/?RecId=", 348), true)
            , Tuple.Create(Tuple.Create("", 385), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 385), false)
, Tuple.Create(Tuple.Create("", 400), Tuple.Create("\");", 400), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"dLine/ViewHistory/?RecId=");
                                                                                                        Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrdLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1309), Tuple.Create("\'", 1331)
, Tuple.Create(Tuple.Create("", 1317), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1317), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1377), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1385), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1385), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrdLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1506), Tuple.Create("\"", 1534)
, Tuple.Create(Tuple.Create("", 1514), Tuple.Create<System.Object, System.Int32>(Model.RDOLRDIdValue
, 1514), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1580), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1588), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1645), Tuple.Create("\"", 1668)
, Tuple.Create(Tuple.Create("", 1653), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1653), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrdLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1970), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1977), Tuple.Create("/REDSOrdLine/ViewHistory/?RecId=", 1977), true)
, Tuple.Create(Tuple.Create("", 2009), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2009), false)
, Tuple.Create(Tuple.Create("", 2024), Tuple.Create("&dt=", 2024), true)
, Tuple.Create(Tuple.Create("", 2028), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2028), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2667), Tuple.Create("\"", 2682)
, Tuple.Create(Tuple.Create("", 2674), Tuple.Create("#", 2674), true)
, Tuple.Create(Tuple.Create("", 2675), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2675), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2898), Tuple.Create("\"", 2910)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2903), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_Add_3.cshtml")]
    public partial class Views_REDSOrdLine_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrdLine>
    {
        public Views_REDSOrdLine_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrdLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrdLine>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrdLine_List_3.cshtml")]
    public partial class Views_REDSOrdLine_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrdLine>>
    {
        public Views_REDSOrdLine_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrdLine/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 534), Tuple.Create("\"", 608)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("/REDSOrdLine/ListFromQuery/?Clause=", 541), true)
                                                                       , Tuple.Create(Tuple.Create("", 576), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 576), false)
, Tuple.Create(Tuple.Create("", 591), Tuple.Create("&Ord=", 591), true)
                                                                                           , Tuple.Create(Tuple.Create("", 596), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 596), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                            Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Line Number</th><th>Cases</th><th>Bottles per Case</th><th>Bottl" +
"e Size (cl)</th><th>Tax Code</th><th>Alcohol Percentage</th><th>Duty Due</th><th" +
">Locked</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1031), Tuple.Create("\"", 1076)
, Tuple.Create(Tuple.Create("", 1038), Tuple.Create("/REDSOrdLine/Load/?RecId=", 1038), true)
                   , Tuple.Create(Tuple.Create("", 1063), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1063), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLineNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1329), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1340), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLineNo/?RecId=", 1340), true)
                                                                           , Tuple.Create(Tuple.Create("", 1398), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1398), false)
, Tuple.Create(Tuple.Create("", 1411), Tuple.Create("\',$(this));", 1411), true)
);
WriteLiteral(" data-bound-name=\'RDOLLineNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1483), Tuple.Create("\'", 1526)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1491), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLLineNo.HTMLValue)
, 1491), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLCases.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1714), Tuple.Create("\"", 1806)
, Tuple.Create(Tuple.Create("", 1725), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLCases/?RecId=", 1725), true)
                                                                          , Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1782), false)
, Tuple.Create(Tuple.Create("", 1795), Tuple.Create("\',$(this));", 1795), true)
);
WriteLiteral(" data-bound-name=\'RDOLCases\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1866), Tuple.Create("\'", 1908)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1874), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLCases.HTMLValue)
, 1874), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleCase.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2100), Tuple.Create("\"", 2197)
, Tuple.Create(Tuple.Create("", 2111), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleCase/?RecId=", 2111), true)
                                                                              , Tuple.Create(Tuple.Create("", 2173), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2173), false)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("\',$(this));", 2186), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleCase\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2262), Tuple.Create("\'", 2309)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2270), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleCase.HTMLValue)
, 2270), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLBottleSize.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2502), Tuple.Create("\"", 2599)
, Tuple.Create(Tuple.Create("", 2513), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLBottleSize/?RecId=", 2513), true)
                                                                               , Tuple.Create(Tuple.Create("", 2575), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2575), false)
, Tuple.Create(Tuple.Create("", 2588), Tuple.Create("\',$(this));", 2588), true)
);
WriteLiteral(" data-bound-name=\'RDOLBottleSize\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2664), Tuple.Create("\'", 2711)
                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2672), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLBottleSize.HTMLValue)
, 2672), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2899), Tuple.Create("\"", 2993)
, Tuple.Create(Tuple.Create("", 2910), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLTaxCode/?RecId=", 2910), true)
                                                                          , Tuple.Create(Tuple.Create("", 2969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2969), false)
, Tuple.Create(Tuple.Create("", 2982), Tuple.Create("\',$(this));", 2982), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'RDOLTaxCode\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.RDOLTaxCode.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLAlcPct.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3277), Tuple.Create("\"", 3370)
, Tuple.Create(Tuple.Create("", 3288), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLAlcPct/?RecId=", 3288), true)
                                                                           , Tuple.Create(Tuple.Create("", 3346), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3346), false)
, Tuple.Create(Tuple.Create("", 3359), Tuple.Create("\',$(this));", 3359), true)
);
WriteLiteral(" data-bound-name=\'RDOLAlcPct\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3431), Tuple.Create("\'", 3474)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3439), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOLAlcPct.HTMLValue)
, 3439), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOLDutyDue.DisplayValue);
WriteLiteral("</td>");
                                                                                       if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOLLocked.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:8%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3706), Tuple.Create("\"", 3798)
, Tuple.Create(Tuple.Create("", 3716), Tuple.Create("javascript:IQAutoSave(\'/REDSOrdLine/SaveRDOLLocked/?RecId=", 3716), true)
                                                       , Tuple.Create(Tuple.Create("", 3774), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3774), false)
, Tuple.Create(Tuple.Create("", 3787), Tuple.Create("\',$(this));", 3787), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'RDOLLocked\'");
WriteLiteral(" ");
                                                                                                                                                                                                      Write(Html.Raw(itm.RDOLLocked.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'RDOLLocked\' value=\'false\'  /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
