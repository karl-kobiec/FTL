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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_CreditNotes.cshtml")]
    public partial class Views_CN_CreditNotes_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_CreditNotes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 58), Tuple.Create("\'", 123)
, Tuple.Create(Tuple.Create("", 66), Tuple.Create("IQLabel100911", 66), true)
, Tuple.Create(Tuple.Create(" ", 79), Tuple.Create<System.Object, System.Int32>(!Model.CNId.LabelVisible ? " hide " : ""
, 80), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 124), Tuple.Create("\'", 320)
   , Tuple.Create(Tuple.Create("", 133), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNId.BackHEXColor) ? "" : "color:" + Model.CNId.BackHEXColor + ";"
, 133), false)
, Tuple.Create(Tuple.Create("", 229), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 229), true)
);
WriteLiteral(">Credit Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 410), Tuple.Create("\'", 471)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("form-control", 418), true)
, Tuple.Create(Tuple.Create("   ", 430), Tuple.Create<System.Object, System.Int32>(!Model.CNId.Visible ? " hide " : ""
, 433), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNId\' value=\'");
                                                                                                                                                                                                                                                                                                                                    Write(Model.CNId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 820), Tuple.Create("\'", 889)
, Tuple.Create(Tuple.Create("", 828), Tuple.Create("IQLabel100912", 828), true)
                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 841), Tuple.Create<System.Object, System.Int32>(!Model.CNImpExp.LabelVisible ? " hide " : ""
, 842), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 890), Tuple.Create("\'", 1095)
                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNImpExp.BackHEXColor) ? "" : "color:" + Model.CNImpExp.BackHEXColor + ";"
, 899), false)
, Tuple.Create(Tuple.Create("", 1003), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1003), true)
);
WriteLiteral(">Import or Export</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNImpExp\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNImpExp.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                Write(!Model.CNImpExp.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNImpExp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNImpExp/',$(this));\""));
WriteLiteral("   name=\'PopulateCNImpExp\'  style=\'position: absolute; left:130px;height:21px;wid" +
"th:100px;top:28px;\'>\r\n");
             foreach(var itm in Model.CNImpExp.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1699), Tuple.Create("\'", 1720)
, Tuple.Create(Tuple.Create("", 1707), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1707), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNImpExp.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1852), Tuple.Create("\'", 1919)
, Tuple.Create(Tuple.Create("", 1860), Tuple.Create("IQLabel100913", 1860), true)
, Tuple.Create(Tuple.Create(" ", 1873), Tuple.Create<System.Object, System.Int32>(!Model.CNDate.LabelVisible ? " hide " : ""
, 1874), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1920), Tuple.Create("\'", 2121)
                     , Tuple.Create(Tuple.Create("", 1929), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNDate.BackHEXColor) ? "" : "color:" + Model.CNDate.BackHEXColor + ";"
, 1929), false)
, Tuple.Create(Tuple.Create("", 2029), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2029), true)
);
WriteLiteral(">Credit Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'100\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:100px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                           Write(!Model.CNDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateCNDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CNDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateCNDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3036), Tuple.Create("\'", 3104)
, Tuple.Create(Tuple.Create("", 3044), Tuple.Create("IQLabel100914", 3044), true)
, Tuple.Create(Tuple.Create(" ", 3057), Tuple.Create<System.Object, System.Int32>(!Model.CNJobNo.LabelVisible ? " hide " : ""
, 3058), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3105), Tuple.Create("\'", 3308)
                             , Tuple.Create(Tuple.Create("", 3114), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNJobNo.BackHEXColor) ? "" : "color:" + Model.CNJobNo.BackHEXColor + ";"
, 3114), false)
, Tuple.Create(Tuple.Create("", 3216), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3216), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:78px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CreditNotes_CNJobNo\'");
                                      Write(Model.RecordLocked || !Model.CNJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNJobNo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                 Write(!Model.CNJobNo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CN/AutoCompleteCNJobNo/");
                                         Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCNJobNo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCNJobNo.ToString() != "" && Model.PopulateCNJobNo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CNJobNo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCNJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 4945), Tuple.Create("\'", 5017)
, Tuple.Create(Tuple.Create("", 4953), Tuple.Create("IQLabel100915", 4953), true)
, Tuple.Create(Tuple.Create(" ", 4966), Tuple.Create<System.Object, System.Int32>(!Model.CNJobLetter.LabelVisible ? " hide " : ""
, 4967), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5018), Tuple.Create("\'", 5230)
                             , Tuple.Create(Tuple.Create("", 5027), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNJobLetter.BackHEXColor) ? "" : "color:" + Model.CNJobLetter.BackHEXColor + ";"
, 5027), false)
, Tuple.Create(Tuple.Create("", 5137), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 5137), true)
);
WriteLiteral(">Job Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNJobLetter\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNJobLetter.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.CNJobLetter.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNJobLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNJobLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNJobLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.CNJobLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:60px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5832), Tuple.Create("\'", 5900)
, Tuple.Create(Tuple.Create("", 5840), Tuple.Create("IQLabel100916", 5840), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 5853), Tuple.Create<System.Object, System.Int32>(!Model.CNOrder.LabelVisible ? " hide " : ""
, 5854), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5901), Tuple.Create("\'", 6105)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 5910), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNOrder.BackHEXColor) ? "" : "color:" + Model.CNOrder.BackHEXColor + ";"
, 5910), false)
, Tuple.Create(Tuple.Create("", 6012), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 6012), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CreditNotes_CNOrder\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNOrder/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                        Write(!Model.CNOrder.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CN/AutoCompleteCNOrder/");
                                         Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCNOrder\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCNOrder.ToString() != "" && Model.PopulateCNOrder.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CNOrder.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCNOrder]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 7696), Tuple.Create("\'", 7769)
, Tuple.Create(Tuple.Create("", 7704), Tuple.Create("IQLabel100917", 7704), true)
, Tuple.Create(Tuple.Create(" ", 7717), Tuple.Create<System.Object, System.Int32>(!Model.CNPrintBatch.LabelVisible ? " hide " : ""
, 7718), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7770), Tuple.Create("\'", 7984)
                              , Tuple.Create(Tuple.Create("", 7779), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNPrintBatch.BackHEXColor) ? "" : "color:" + Model.CNPrintBatch.BackHEXColor + ";"
, 7779), false)
, Tuple.Create(Tuple.Create("", 7891), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 7891), true)
);
WriteLiteral(">Print Batch No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNPrintBatch\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNPrintBatch.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CNPrintBatch.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNPrintBatch/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNPrintBatch/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNPrintBatch\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.CNPrintBatch.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:40px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 8597), Tuple.Create("\'", 8668)
, Tuple.Create(Tuple.Create("", 8605), Tuple.Create("IQLabel100918", 8605), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 8618), Tuple.Create<System.Object, System.Int32>(!Model.CNExported.LabelVisible ? " hide " : ""
, 8619), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8669), Tuple.Create("\'", 8879)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 8678), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNExported.BackHEXColor) ? "" : "color:" + Model.CNExported.BackHEXColor + ";"
, 8678), false)
, Tuple.Create(Tuple.Create("", 8786), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 8786), true)
);
WriteLiteral(">Sent to Dover</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNExported\'");
WriteAttribute("class", Tuple.Create(" class=\'", 8960), Tuple.Create("\'", 9014)
, Tuple.Create(Tuple.Create("  ", 8968), Tuple.Create<System.Object, System.Int32>(!Model.CNExported.Visible ? " hide " : ""
, 8970), false)
);
WriteLiteral(" ");
                                                                                                           Write(Model.RecordLocked || !Model.CNExported.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNExported/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNExported/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:203px;\' name=\'" +
"PopulateCNExported\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateCNExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCNExported\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                 Write(!Model.PopulateCNExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 9632), Tuple.Create("\'", 9701)
, Tuple.Create(Tuple.Create("", 9640), Tuple.Create("IQLabel100919", 9640), true)
, Tuple.Create(Tuple.Create(" ", 9653), Tuple.Create<System.Object, System.Int32>(!Model.CNDutyCN.LabelVisible ? " hide " : ""
, 9654), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9702), Tuple.Create("\'", 9908)
              , Tuple.Create(Tuple.Create("", 9711), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNDutyCN.BackHEXColor) ? "" : "color:" + Model.CNDutyCN.BackHEXColor + ";"
, 9711), false)
, Tuple.Create(Tuple.Create("", 9815), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 9815), true)
);
WriteLiteral(">Duty CN</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNDutyCN\'");
WriteAttribute("class", Tuple.Create(" class=\'", 9981), Tuple.Create("\'", 10033)
, Tuple.Create(Tuple.Create("  ", 9989), Tuple.Create<System.Object, System.Int32>(!Model.CNDutyCN.Visible ? " hide " : ""
, 9991), false)
);
WriteLiteral(" ");
                                                                                                       Write(Model.RecordLocked || !Model.CNDutyCN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNDutyCN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNDutyCN/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:228px;\' name=\'" +
"PopulateCNDutyCN\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.PopulateCNDutyCN ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCNDutyCN\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                               Write(!Model.PopulateCNDutyCN ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 10637), Tuple.Create("\'", 10707)
, Tuple.Create(Tuple.Create("", 10645), Tuple.Create("IQLabel100920", 10645), true)
, Tuple.Create(Tuple.Create(" ", 10658), Tuple.Create<System.Object, System.Int32>(!Model.CNCustOrd.LabelVisible ? " hide " : ""
, 10659), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10708), Tuple.Create("\'", 10916)
              , Tuple.Create(Tuple.Create("", 10717), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNCustOrd.BackHEXColor) ? "" : "color:" + Model.CNCustOrd.BackHEXColor + ";"
, 10717), false)
, Tuple.Create(Tuple.Create("", 10823), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 10823), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CNCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CNCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 11510), Tuple.Create("\'", 11577)
, Tuple.Create(Tuple.Create("", 11518), Tuple.Create("IQLabel100931", 11518), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 11531), Tuple.Create<System.Object, System.Int32>(!Model.CNToId.LabelVisible ? " hide " : ""
, 11532), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11578), Tuple.Create("\'", 11780)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 11587), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNToId.BackHEXColor) ? "" : "color:" + Model.CNToId.BackHEXColor + ";"
, 11587), false)
, Tuple.Create(Tuple.Create("", 11687), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:3px;", 11687), true)
);
WriteLiteral(">Credit To ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNToId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNToId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CNToId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNToId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNToId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNToId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.CNToId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 12347), Tuple.Create("\'", 12412)
, Tuple.Create(Tuple.Create("", 12355), Tuple.Create("IQLabel100932", 12355), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 12368), Tuple.Create<System.Object, System.Int32>(!Model.CNTo.LabelVisible ? " hide " : ""
, 12369), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12413), Tuple.Create("\'", 12612)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 12422), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNTo.BackHEXColor) ? "" : "color:" + Model.CNTo.BackHEXColor + ";"
, 12422), false)
, Tuple.Create(Tuple.Create("", 12518), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:28px;", 12518), true)
);
WriteLiteral(">Credit To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:400px;height:21px;width:200px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CreditNotes_CNTo\'");
                                   Write(Model.RecordLocked || !Model.CNTo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNTo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                     Write(!Model.CNTo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/CN/AutoCompleteCNTo/");
                                      Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateCNTo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateCNTo.ToString() != "" && Model.PopulateCNTo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.CNTo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateCNTo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 14231), Tuple.Create("\'", 14298)
, Tuple.Create(Tuple.Create("", 14239), Tuple.Create("IQLabel100933", 14239), true)
, Tuple.Create(Tuple.Create(" ", 14252), Tuple.Create<System.Object, System.Int32>(!Model.CNDesc.LabelVisible ? " hide " : ""
, 14253), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14299), Tuple.Create("\'", 14502)
                       , Tuple.Create(Tuple.Create("", 14308), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNDesc.BackHEXColor) ? "" : "color:" + Model.CNDesc.BackHEXColor + ";"
, 14308), false)
, Tuple.Create(Tuple.Create("", 14408), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:53px;", 14408), true)
);
WriteLiteral(">Credit Description</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:400px;height:46px;width:200px;top:53px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Credit Description\'");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                                   Write(Model.RecordLocked || !Model.CNDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.CNDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCNDesc\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.PopulateCNDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateCNDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 15665), Tuple.Create("\'", 15732)
, Tuple.Create(Tuple.Create("", 15673), Tuple.Create("IQLabel100935", 15673), true)
, Tuple.Create(Tuple.Create(" ", 15686), Tuple.Create<System.Object, System.Int32>(!Model.CNCurr.LabelVisible ? " hide " : ""
, 15687), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15733), Tuple.Create("\'", 15937)
                           , Tuple.Create(Tuple.Create("", 15742), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNCurr.BackHEXColor) ? "" : "color:" + Model.CNCurr.BackHEXColor + ";"
, 15742), false)
, Tuple.Create(Tuple.Create("", 15842), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:178px;", 15842), true)
);
WriteLiteral(">Currency</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNCurr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNCurr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                     Write(!Model.CNCurr.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNCurr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNCurr/',$(this));\""));
WriteLiteral("   name=\'PopulateCNCurr\'  style=\'position: absolute; left:400px;height:21px;width" +
":100px;top:178px;\'>\r\n");
             foreach(var itm in Model.CNCurr.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 16511), Tuple.Create("\'", 16532)
, Tuple.Create(Tuple.Create("", 16519), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 16519), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                       Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 16662), Tuple.Create("\'", 16728)
, Tuple.Create(Tuple.Create("", 16670), Tuple.Create("IQLabel100936", 16670), true)
, Tuple.Create(Tuple.Create(" ", 16683), Tuple.Create<System.Object, System.Int32>(!Model.CNNet.LabelVisible ? " hide " : ""
, 16684), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16729), Tuple.Create("\'", 16931)
                   , Tuple.Create(Tuple.Create("", 16738), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNNet.BackHEXColor) ? "" : "color:" + Model.CNNet.BackHEXColor + ";"
, 16738), false)
, Tuple.Create(Tuple.Create("", 16836), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:103px;", 16836), true)
);
WriteLiteral(">Net Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNNet\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 17019), Tuple.Create("\'", 17081)
, Tuple.Create(Tuple.Create("", 17027), Tuple.Create("form-control", 17027), true)
, Tuple.Create(Tuple.Create("   ", 17039), Tuple.Create<System.Object, System.Int32>(!Model.CNNet.Visible ? " hide " : ""
, 17042), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNNet/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNNet/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNNet\' value=\'");
                                                                                                                                                                                                                                                                                                                                        Write(Model.CNNet.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 17436), Tuple.Create("\'", 17502)
, Tuple.Create(Tuple.Create("", 17444), Tuple.Create("IQLabel100937", 17444), true)
                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 17457), Tuple.Create<System.Object, System.Int32>(!Model.CNVAT.LabelVisible ? " hide " : ""
, 17458), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17503), Tuple.Create("\'", 17705)
                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 17512), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNVAT.BackHEXColor) ? "" : "color:" + Model.CNVAT.BackHEXColor + ";"
, 17512), false)
, Tuple.Create(Tuple.Create("", 17610), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:10" +
"0px;top:128px;", 17610), true)
);
WriteLiteral(">VAT Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNVAT\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 17793), Tuple.Create("\'", 17855)
, Tuple.Create(Tuple.Create("", 17801), Tuple.Create("form-control", 17801), true)
, Tuple.Create(Tuple.Create("   ", 17813), Tuple.Create<System.Object, System.Int32>(!Model.CNVAT.Visible ? " hide " : ""
, 17816), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNVAT/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNVAT/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNVAT\' value=\'");
                                                                                                                                                                                                                                                                                                                                        Write(Model.CNVAT.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 18210), Tuple.Create("\'", 18278)
, Tuple.Create(Tuple.Create("", 18218), Tuple.Create("IQLabel100938", 18218), true)
                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 18231), Tuple.Create<System.Object, System.Int32>(!Model.CNTotal.LabelVisible ? " hide " : ""
, 18232), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 18279), Tuple.Create("\'", 18485)
                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 18288), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNTotal.BackHEXColor) ? "" : "color:" + Model.CNTotal.BackHEXColor + ";"
, 18288), false)
, Tuple.Create(Tuple.Create("", 18390), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:10" +
"0px;top:153px;", 18390), true)
);
WriteLiteral(">Credit Total</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNTotal\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 18577), Tuple.Create("\'", 18641)
, Tuple.Create(Tuple.Create("", 18585), Tuple.Create("form-control", 18585), true)
, Tuple.Create(Tuple.Create("   ", 18597), Tuple.Create<System.Object, System.Int32>(!Model.CNTotal.Visible ? " hide " : ""
, 18600), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNTotal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNTotal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNTotal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                Write(Model.CNTotal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:153px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 19004), Tuple.Create("\'", 19075)
, Tuple.Create(Tuple.Create("", 19012), Tuple.Create("IQLabel100939", 19012), true)
                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 19025), Tuple.Create<System.Object, System.Int32>(!Model.CNExchRate.LabelVisible ? " hide " : ""
, 19026), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19076), Tuple.Create("\'", 19288)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 19085), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNExchRate.BackHEXColor) ? "" : "color:" + Model.CNExchRate.BackHEXColor + ";"
, 19085), false)
, Tuple.Create(Tuple.Create("", 19193), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:203px;", 19193), true)
);
WriteLiteral(">Exchange Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNExchRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNExchRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.CNExchRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNExchRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNExchRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNExchRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.CNExchRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:203px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 19886), Tuple.Create("\'", 19958)
, Tuple.Create(Tuple.Create("", 19894), Tuple.Create("IQLabel100951", 19894), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 19907), Tuple.Create<System.Object, System.Int32>(!Model.CNRouteFrom.LabelVisible ? " hide " : ""
, 19908), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19959), Tuple.Create("\'", 20171)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 19968), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNRouteFrom.BackHEXColor) ? "" : "color:" + Model.CNRouteFrom.BackHEXColor + ";"
, 19968), false)
, Tuple.Create(Tuple.Create("", 20078), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:615px;height:21px;width:12" +
"0px;top:3px;", 20078), true)
);
WriteLiteral(">Route From</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:740px;height:21px;width:120px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNRouteFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNRouteFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.CNRouteFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNRouteFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNRouteFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateCNRouteFrom\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CNRouteFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 20850), Tuple.Create("\'", 20871)
, Tuple.Create(Tuple.Create("", 20858), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 20858), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNRouteFrom.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCNRouteFrom]\"");
WriteLiteral(" data-url=\"/FerryRoute/Load/?FRId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/FerryRoute/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Ferry Routes</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 21765), Tuple.Create("\'", 21835)
, Tuple.Create(Tuple.Create("", 21773), Tuple.Create("IQLabel100952", 21773), true)
, Tuple.Create(Tuple.Create(" ", 21786), Tuple.Create<System.Object, System.Int32>(!Model.CNRouteTo.LabelVisible ? " hide " : ""
, 21787), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21836), Tuple.Create("\'", 22044)
                          , Tuple.Create(Tuple.Create("", 21845), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNRouteTo.BackHEXColor) ? "" : "color:" + Model.CNRouteTo.BackHEXColor + ";"
, 21845), false)
, Tuple.Create(Tuple.Create("", 21951), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:90" +
"px;top:28px;", 21951), true)
);
WriteLiteral(">Route To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:740px;height:21px;width:120px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNRouteTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNRouteTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                        Write(!Model.CNRouteTo.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNRouteTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNRouteTo/',$(this));\""));
WriteLiteral("   name=\'PopulateCNRouteTo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CNRouteTo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 22708), Tuple.Create("\'", 22729)
, Tuple.Create(Tuple.Create("", 22716), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 22716), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNRouteTo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCNRouteTo]\"");
WriteLiteral(" data-url=\"/FerryRoute/Load/?FRId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/FerryRoute/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Ferry Routes</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 23619), Tuple.Create("\'", 23689)
, Tuple.Create(Tuple.Create("", 23627), Tuple.Create("IQLabel100953", 23627), true)
, Tuple.Create(Tuple.Create(" ", 23640), Tuple.Create<System.Object, System.Int32>(!Model.CNVehicle.LabelVisible ? " hide " : ""
, 23641), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23690), Tuple.Create("\'", 23898)
                          , Tuple.Create(Tuple.Create("", 23699), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNVehicle.BackHEXColor) ? "" : "color:" + Model.CNVehicle.BackHEXColor + ";"
, 23699), false)
, Tuple.Create(Tuple.Create("", 23805), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:90" +
"px;top:53px;", 23805), true)
);
WriteLiteral(">Vehicle</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNVehicle\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNVehicle.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CNVehicle.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNVehicle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNVehicle/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNVehicle\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CNVehicle.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:740px;height:21px;width:120px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 24483), Tuple.Create("\'", 24553)
, Tuple.Create(Tuple.Create("", 24491), Tuple.Create("IQLabel100954", 24491), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 24504), Tuple.Create<System.Object, System.Int32>(!Model.CNTrailer.LabelVisible ? " hide " : ""
, 24505), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24554), Tuple.Create("\'", 24762)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 24563), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNTrailer.BackHEXColor) ? "" : "color:" + Model.CNTrailer.BackHEXColor + ";"
, 24563), false)
, Tuple.Create(Tuple.Create("", 24669), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:90" +
"px;top:78px;", 24669), true)
);
WriteLiteral(">Trailer</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNTrailer\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNTrailer.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CNTrailer.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNTrailer/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNTrailer/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCNTrailer\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CNTrailer.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:740px;height:21px;width:120px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 25347), Tuple.Create("\'", 25415)
, Tuple.Create(Tuple.Create("", 25355), Tuple.Create("IQLabel100955", 25355), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 25368), Tuple.Create<System.Object, System.Int32>(!Model.CNNote1.LabelVisible ? " hide " : ""
, 25369), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25416), Tuple.Create("\'", 25622)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 25425), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNNote1.BackHEXColor) ? "" : "color:" + Model.CNNote1.BackHEXColor + ";"
, 25425), false)
, Tuple.Create(Tuple.Create("", 25527), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:10" +
"0px;top:103px;", 25527), true)
);
WriteLiteral(">Comment 1</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:740px;height:21px;width:200px;top:103px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNNote1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNNote1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                      Write(!Model.CNNote1.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNNote1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNNote1/',$(this));\""));
WriteLiteral("   name=\'PopulateCNNote1\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CNNote1.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 26274), Tuple.Create("\'", 26295)
, Tuple.Create(Tuple.Create("", 26282), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 26282), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNNote1.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCNNote1]\"");
WriteLiteral(" data-url=\"/InvComment/Load/?InvCId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/InvComment/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Invoice Comments</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 27187), Tuple.Create("\'", 27255)
, Tuple.Create(Tuple.Create("", 27195), Tuple.Create("IQLabel100956", 27195), true)
, Tuple.Create(Tuple.Create(" ", 27208), Tuple.Create<System.Object, System.Int32>(!Model.CNNote2.LabelVisible ? " hide " : ""
, 27209), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27256), Tuple.Create("\'", 27462)
                        , Tuple.Create(Tuple.Create("", 27265), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CNNote2.BackHEXColor) ? "" : "color:" + Model.CNNote2.BackHEXColor + ";"
, 27265), false)
, Tuple.Create(Tuple.Create("", 27367), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:10" +
"0px;top:128px;", 27367), true)
);
WriteLiteral(">Comment 2</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:740px;height:21px;width:200px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'CreditNotes_CNNote2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CNNote2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                      Write(!Model.CNNote2.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/CN/SaveCNNote2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/CN/CallbackCNNote2/',$(this));\""));
WriteLiteral("   name=\'PopulateCNNote2\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CNNote2.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 28114), Tuple.Create("\'", 28135)
, Tuple.Create(Tuple.Create("", 28122), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 28122), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCNNote2.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCNNote2]\"");
WriteLiteral(" data-url=\"/InvComment/Load/?InvCId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/InvComment/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Invoice Comments</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Edit_1.cshtml")]
    public partial class Views_CN_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Edit_1_cshtml()
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
WriteLiteral(" href=\"/CN/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Credit Notes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 455)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/CN/Delete/?RecId=", 409), true)
   , Tuple.Create(Tuple.Create("", 437), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 437), false)
, Tuple.Create(Tuple.Create("", 452), Tuple.Create("\");", 452), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CN/Vie" +
"wHistory/?RecId=");
                                                                                               Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CN", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1334), Tuple.Create("\'", 1356)
, Tuple.Create(Tuple.Create("", 1342), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1342), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1426)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CN\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1522), Tuple.Create("\"", 1546)
, Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Model.CNIdValue
, 1530), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1592), Tuple.Create("\"", 1615)
, Tuple.Create(Tuple.Create("", 1600), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1600), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1657), Tuple.Create("\"", 1680)
, Tuple.Create(Tuple.Create("", 1665), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1665), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CN/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1973), Tuple.Create("\"", 2069)
, Tuple.Create(Tuple.Create("", 1980), Tuple.Create("/CN/ViewHistory/?RecId=", 1980), true)
, Tuple.Create(Tuple.Create("", 2003), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2003), false)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("&dt=", 2018), true)
, Tuple.Create(Tuple.Create("", 2022), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2022), false)
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
WriteLiteral(" id=\"CreditNotes\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CN_CreditNotes.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Credit Note Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2845), Tuple.Create("\'", 2946)
, Tuple.Create(Tuple.Create("", 2853), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CNLine" ? "active" :  "") : "" )
, 2853), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CNLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Credit Note Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3154), Tuple.Create("\"", 3169)
, Tuple.Create(Tuple.Create("", 3161), Tuple.Create("#", 3161), true)
, Tuple.Create(Tuple.Create("", 3162), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3162), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Credit Note Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CNLine" ? "data-loadTarget='#413855151e7743fc8944299aab78796b' data-dynamicContent='/CNLine/ListFromQuery?Limit=50&Ord=CNLLineNo&Clause=CNLNo=" + Model.CNIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CNLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CNLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/CNLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Note Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CNLine") {
                      Html.RenderPartial("~/Views/CNLine_List_1.cshtml", Model.CNLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"413855151e7743fc8944299aab78796b\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 4370), Tuple.Create("\"", 4382)
, Tuple.Create(Tuple.Create("", 4375), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4375), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Add_1.cshtml")]
    public partial class Views_CN_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Notes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Notes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CN/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CreditNotes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CN_CreditNotes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_List_1.cshtml")]
    public partial class Views_CN_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CN>>
    {
        public Views_CN_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Notes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Notes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Notes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 495), Tuple.Create("\"", 560)
, Tuple.Create(Tuple.Create("", 502), Tuple.Create("/CN/ListFromQuery/?Clause=", 502), true)
                                                              , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 528), false)
, Tuple.Create(Tuple.Create("", 543), Tuple.Create("&Ord=", 543), true)
                                                                                  , Tuple.Create(Tuple.Create("", 548), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 548), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                   Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Import or Export</th><th>Job Number</th><t" +
"h>Order Number</th><th>Credit Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 930), Tuple.Create("\"", 966)
, Tuple.Create(Tuple.Create("", 937), Tuple.Create("/CN/Load/?RecId=", 937), true)
           , Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 953), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:26%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1270), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNImpExp/?RecId=", 1281), true)
                                                              , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                    Write(Html.Raw(itm.CNImpExp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CN/AutoCompleteCNJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1667), Tuple.Create("\"", 1748)
, Tuple.Create(Tuple.Create("", 1678), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNJobNo/?RecId=", 1678), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 1724), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1724), false)
, Tuple.Create(Tuple.Create("", 1737), Tuple.Create("\',$(this));", 1737), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CNJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.CNJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2125), Tuple.Create("\"", 2205)
, Tuple.Create(Tuple.Create("", 2136), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNDate/?RecId=", 2136), true)
                                                                                          , Tuple.Create(Tuple.Create("", 2181), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2181), false)
, Tuple.Create(Tuple.Create("", 2194), Tuple.Create("\',$(this));", 2194), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'CNDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2271), Tuple.Create("\'", 2310)
                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2279), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNDate.HTMLValue)
, 2279), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Edit_2.cshtml")]
    public partial class Views_CN_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Edit_2_cshtml()
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
WriteLiteral(" href=\"/CN/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Credit Notes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 455)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/CN/Delete/?RecId=", 409), true)
   , Tuple.Create(Tuple.Create("", 437), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 437), false)
, Tuple.Create(Tuple.Create("", 452), Tuple.Create("\");", 452), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CN/Vie" +
"wHistory/?RecId=");
                                                                                               Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CN", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1334), Tuple.Create("\'", 1356)
, Tuple.Create(Tuple.Create("", 1342), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1342), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1426)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CN\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1522), Tuple.Create("\"", 1546)
, Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Model.CNIdValue
, 1530), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1592), Tuple.Create("\"", 1615)
, Tuple.Create(Tuple.Create("", 1600), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1600), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1657), Tuple.Create("\"", 1680)
, Tuple.Create(Tuple.Create("", 1665), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1665), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CN/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1973), Tuple.Create("\"", 2069)
, Tuple.Create(Tuple.Create("", 1980), Tuple.Create("/CN/ViewHistory/?RecId=", 1980), true)
, Tuple.Create(Tuple.Create("", 2003), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2003), false)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("&dt=", 2018), true)
, Tuple.Create(Tuple.Create("", 2022), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2022), false)
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
WriteLiteral(" id=\"CreditNotes\"");
WriteLiteral(" style=\'position:relative;height:279px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CN_CreditNotes.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Credit Note Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2845), Tuple.Create("\'", 2946)
, Tuple.Create(Tuple.Create("", 2853), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CNLine" ? "active" :  "") : "" )
, 2853), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CNLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Credit Note Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3154), Tuple.Create("\"", 3169)
, Tuple.Create(Tuple.Create("", 3161), Tuple.Create("#", 3161), true)
, Tuple.Create(Tuple.Create("", 3162), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3162), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Credit Note Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CNLine" ? "data-loadTarget='#7fd85eecd85b4642baa6076df15436e3' data-dynamicContent='/CNLine/ListFromQuery?Limit=50&Ord=CNLLineNo&Clause=CNLNo=" + Model.CNIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CNLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CNLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/CNLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Note Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CNLine") {
                      Html.RenderPartial("~/Views/CNLine_List_2.cshtml", Model.CNLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"7fd85eecd85b4642baa6076df15436e3\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 4370), Tuple.Create("\"", 4382)
, Tuple.Create(Tuple.Create("", 4375), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4375), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Add_2.cshtml")]
    public partial class Views_CN_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Notes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Notes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CN/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CreditNotes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/CN_CreditNotes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_List_2.cshtml")]
    public partial class Views_CN_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CN>>
    {
        public Views_CN_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Notes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Notes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Notes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 495), Tuple.Create("\"", 560)
, Tuple.Create(Tuple.Create("", 502), Tuple.Create("/CN/ListFromQuery/?Clause=", 502), true)
                                                              , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 528), false)
, Tuple.Create(Tuple.Create("", 543), Tuple.Create("&Ord=", 543), true)
                                                                                  , Tuple.Create(Tuple.Create("", 548), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 548), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                   Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Import or Export</th><th>Job Number</th><t" +
"h>Order Number</th><th>Credit Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 930), Tuple.Create("\"", 966)
, Tuple.Create(Tuple.Create("", 937), Tuple.Create("/CN/Load/?RecId=", 937), true)
           , Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 953), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:26%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1270), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNImpExp/?RecId=", 1281), true)
                                                              , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                    Write(Html.Raw(itm.CNImpExp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CN/AutoCompleteCNJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1667), Tuple.Create("\"", 1748)
, Tuple.Create(Tuple.Create("", 1678), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNJobNo/?RecId=", 1678), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 1724), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1724), false)
, Tuple.Create(Tuple.Create("", 1737), Tuple.Create("\',$(this));", 1737), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CNJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.CNJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2125), Tuple.Create("\"", 2205)
, Tuple.Create(Tuple.Create("", 2136), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNDate/?RecId=", 2136), true)
                                                                                          , Tuple.Create(Tuple.Create("", 2181), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2181), false)
, Tuple.Create(Tuple.Create("", 2194), Tuple.Create("\',$(this));", 2194), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'CNDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2271), Tuple.Create("\'", 2310)
                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2279), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNDate.HTMLValue)
, 2279), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Edit_3.cshtml")]
    public partial class Views_CN_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Edit_3_cshtml()
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
WriteLiteral(" href=\"/CN/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Credit Notes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 399), Tuple.Create("\'", 455)
, Tuple.Create(Tuple.Create("", 409), Tuple.Create("IQJSCall(\"/CN/Delete/?RecId=", 409), true)
   , Tuple.Create(Tuple.Create("", 437), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 437), false)
, Tuple.Create(Tuple.Create("", 452), Tuple.Create("\");", 452), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/CN/Vie" +
"wHistory/?RecId=");
                                                                                               Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("CN", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1334), Tuple.Create("\'", 1356)
, Tuple.Create(Tuple.Create("", 1342), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1342), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1402), Tuple.Create("\'", 1426)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1410), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"CN\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1522), Tuple.Create("\"", 1546)
, Tuple.Create(Tuple.Create("", 1530), Tuple.Create<System.Object, System.Int32>(Model.CNIdValue
, 1530), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1592), Tuple.Create("\"", 1615)
, Tuple.Create(Tuple.Create("", 1600), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1600), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1657), Tuple.Create("\"", 1680)
, Tuple.Create(Tuple.Create("", 1665), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1665), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/CN/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1973), Tuple.Create("\"", 2069)
, Tuple.Create(Tuple.Create("", 1980), Tuple.Create("/CN/ViewHistory/?RecId=", 1980), true)
, Tuple.Create(Tuple.Create("", 2003), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2003), false)
, Tuple.Create(Tuple.Create("", 2018), Tuple.Create("&dt=", 2018), true)
, Tuple.Create(Tuple.Create("", 2022), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2022), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2661), Tuple.Create("\"", 2676)
, Tuple.Create(Tuple.Create("", 2668), Tuple.Create("#", 2668), true)
, Tuple.Create(Tuple.Create("", 2669), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2669), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2892), Tuple.Create("\"", 2904)
, Tuple.Create(Tuple.Create("", 2897), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2897), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_Add_3.cshtml")]
    public partial class Views_CN_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.CN>
    {
        public Views_CN_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Credit Notes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Credit Notes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/CN/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<CN>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/CN_List_3.cshtml")]
    public partial class Views_CN_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.CN>>
    {
        public Views_CN_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Credit Notes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Credit Notes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Credit Notes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/CN/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 495), Tuple.Create("\"", 560)
, Tuple.Create(Tuple.Create("", 502), Tuple.Create("/CN/ListFromQuery/?Clause=", 502), true)
                                                              , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 528), false)
, Tuple.Create(Tuple.Create("", 543), Tuple.Create("&Ord=", 543), true)
                                                                                  , Tuple.Create(Tuple.Create("", 548), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 548), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                   Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Credit Number</th><th>Import or Export</th><th>Job Number</th><t" +
"h>Order Number</th><th>Credit Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 930), Tuple.Create("\"", 966)
, Tuple.Create(Tuple.Create("", 937), Tuple.Create("/CN/Load/?RecId=", 937), true)
           , Tuple.Create(Tuple.Create("", 953), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 953), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.CNId.DisplayValue);
WriteLiteral("</td>");
                                                                                        if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:26%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1270), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNImpExp/?RecId=", 1281), true)
                                                              , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CNImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                    Write(Html.Raw(itm.CNImpExp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/CN/AutoCompleteCNJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1667), Tuple.Create("\"", 1748)
, Tuple.Create(Tuple.Create("", 1678), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNJobNo/?RecId=", 1678), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 1724), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1724), false)
, Tuple.Create(Tuple.Create("", 1737), Tuple.Create("\',$(this));", 1737), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'CNJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                               Write(Html.Raw(itm.CNJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CNOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                   if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CNDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2125), Tuple.Create("\"", 2205)
, Tuple.Create(Tuple.Create("", 2136), Tuple.Create("javascript:IQAutoSave(\'/CN/SaveCNDate/?RecId=", 2136), true)
                                                                                          , Tuple.Create(Tuple.Create("", 2181), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2181), false)
, Tuple.Create(Tuple.Create("", 2194), Tuple.Create("\',$(this));", 2194), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'CNDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2271), Tuple.Create("\'", 2310)
                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2279), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CNDate.HTMLValue)
, 2279), false)
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
