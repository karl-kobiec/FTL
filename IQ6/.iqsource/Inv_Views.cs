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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Invoices.cshtml")]
    public partial class Views_Inv_Invoices_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Invoices_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 59), Tuple.Create("\'", 125)
, Tuple.Create(Tuple.Create("", 67), Tuple.Create("IQLabel100711", 67), true)
, Tuple.Create(Tuple.Create(" ", 80), Tuple.Create<System.Object, System.Int32>(!Model.InvId.LabelVisible ? " hide " : ""
, 81), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 126), Tuple.Create("\'", 324)
    , Tuple.Create(Tuple.Create("", 135), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvId.BackHEXColor) ? "" : "color:" + Model.InvId.BackHEXColor + ";"
, 135), false)
, Tuple.Create(Tuple.Create("", 233), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 233), true)
);
WriteLiteral(">Invoice Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 413), Tuple.Create("\'", 475)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("form-control", 421), true)
, Tuple.Create(Tuple.Create("   ", 433), Tuple.Create<System.Object, System.Int32>(!Model.InvId.Visible ? " hide " : ""
, 436), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvId\' value=\'");
                                                                                                                                                                                                                                                                                                                                          Write(Model.InvId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 830), Tuple.Create("\'", 905)
, Tuple.Create(Tuple.Create("", 838), Tuple.Create("IQLabel100712", 838), true)
                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 851), Tuple.Create<System.Object, System.Int32>(!Model.InvFreightDuty.LabelVisible ? " hide " : ""
, 852), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 906), Tuple.Create("\'", 1123)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 915), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvFreightDuty.BackHEXColor) ? "" : "color:" + Model.InvFreightDuty.BackHEXColor + ";"
, 915), false)
, Tuple.Create(Tuple.Create("", 1031), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1031), true)
);
WriteLiteral(">Freight or Duty</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvFreightDuty\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvFreightDuty.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                      Write(!Model.InvFreightDuty.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvFreightDuty/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvFreightDuty/',$(this));\""));
WriteLiteral("   name=\'PopulateInvFreightDuty\'  style=\'position: absolute; left:130px;height:21" +
"px;width:100px;top:28px;\'>\r\n");
             foreach(var itm in Model.InvFreightDuty.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1767), Tuple.Create("\'", 1788)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1775), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvFreightDuty.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                               Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1926), Tuple.Create("\'", 1996)
, Tuple.Create(Tuple.Create("", 1934), Tuple.Create("IQLabel100713", 1934), true)
, Tuple.Create(Tuple.Create(" ", 1947), Tuple.Create<System.Object, System.Int32>(!Model.InvImpExp.LabelVisible ? " hide " : ""
, 1948), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1997), Tuple.Create("\'", 2204)
                        , Tuple.Create(Tuple.Create("", 2006), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvImpExp.BackHEXColor) ? "" : "color:" + Model.InvImpExp.BackHEXColor + ";"
, 2006), false)
, Tuple.Create(Tuple.Create("", 2112), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2112), true)
);
WriteLiteral(">Import or Export</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvImpExp\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvImpExp.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                 Write(!Model.InvImpExp.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvImpExp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvImpExp/',$(this));\""));
WriteLiteral("   name=\'PopulateInvImpExp\'  style=\'position: absolute; left:130px;height:21px;wi" +
"dth:100px;top:53px;\'>\r\n");
             foreach(var itm in Model.InvImpExp.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2814), Tuple.Create("\'", 2835)
, Tuple.Create(Tuple.Create("", 2822), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2822), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvImpExp.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2968), Tuple.Create("\'", 3036)
, Tuple.Create(Tuple.Create("", 2976), Tuple.Create("IQLabel100714", 2976), true)
, Tuple.Create(Tuple.Create(" ", 2989), Tuple.Create<System.Object, System.Int32>(!Model.InvDate.LabelVisible ? " hide " : ""
, 2990), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3037), Tuple.Create("\'", 3240)
                      , Tuple.Create(Tuple.Create("", 3046), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvDate.BackHEXColor) ? "" : "color:" + Model.InvDate.BackHEXColor + ";"
, 3046), false)
, Tuple.Create(Tuple.Create("", 3148), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3148), true)
);
WriteLiteral(">Invoice Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                            Write(!Model.InvDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateInvDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.InvDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateInvDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4161), Tuple.Create("\'", 4230)
, Tuple.Create(Tuple.Create("", 4169), Tuple.Create("IQLabel100715", 4169), true)
, Tuple.Create(Tuple.Create(" ", 4182), Tuple.Create<System.Object, System.Int32>(!Model.InvJobNo.LabelVisible ? " hide " : ""
, 4183), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4231), Tuple.Create("\'", 4437)
                              , Tuple.Create(Tuple.Create("", 4240), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvJobNo.BackHEXColor) ? "" : "color:" + Model.InvJobNo.BackHEXColor + ";"
, 4240), false)
, Tuple.Create(Tuple.Create("", 4344), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4344), true)
);
WriteLiteral(">Job No</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:103px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvJobNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                Write(!Model.InvJobNo.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvJobNo/',$(this));\""));
WriteLiteral("   name=\'PopulateInvJobNo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvJobNo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 5101), Tuple.Create("\'", 5122)
, Tuple.Create(Tuple.Create("", 5109), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 5109), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvJobNo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 5989), Tuple.Create("\'", 6062)
, Tuple.Create(Tuple.Create("", 5997), Tuple.Create("IQLabel100716", 5997), true)
, Tuple.Create(Tuple.Create(" ", 6010), Tuple.Create<System.Object, System.Int32>(!Model.InvJobLetter.LabelVisible ? " hide " : ""
, 6011), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6063), Tuple.Create("\'", 6277)
                              , Tuple.Create(Tuple.Create("", 6072), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvJobLetter.BackHEXColor) ? "" : "color:" + Model.InvJobLetter.BackHEXColor + ";"
, 6072), false)
, Tuple.Create(Tuple.Create("", 6184), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 6184), true)
);
WriteLiteral(">Job Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvJobLetter\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvJobLetter.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.InvJobLetter.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvJobLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvJobLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvJobLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.InvJobLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6885), Tuple.Create("\'", 6954)
, Tuple.Create(Tuple.Create("", 6893), Tuple.Create("IQLabel100717", 6893), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 6906), Tuple.Create<System.Object, System.Int32>(!Model.InvOrder.LabelVisible ? " hide " : ""
, 6907), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6955), Tuple.Create("\'", 7161)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 6964), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvOrder.BackHEXColor) ? "" : "color:" + Model.InvOrder.BackHEXColor + ";"
, 6964), false)
, Tuple.Create(Tuple.Create("", 7068), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 7068), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:153px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Invoices_InvOrder\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvOrder/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                          Write(!Model.InvOrder.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Inv/AutoCompleteInvOrder/");
                                           Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateInvOrder\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateInvOrder.ToString() != "" && Model.PopulateInvOrder.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.InvOrder.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateInvOrder]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 8762), Tuple.Create("\'", 8836)
, Tuple.Create(Tuple.Create("", 8770), Tuple.Create("IQLabel100718", 8770), true)
, Tuple.Create(Tuple.Create(" ", 8783), Tuple.Create<System.Object, System.Int32>(!Model.InvPrintBatch.LabelVisible ? " hide " : ""
, 8784), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8837), Tuple.Create("\'", 9053)
                               , Tuple.Create(Tuple.Create("", 8846), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvPrintBatch.BackHEXColor) ? "" : "color:" + Model.InvPrintBatch.BackHEXColor + ";"
, 8846), false)
, Tuple.Create(Tuple.Create("", 8960), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 8960), true)
);
WriteLiteral(">Print Batch No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvPrintBatch\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvPrintBatch.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.InvPrintBatch.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvPrintBatch/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvPrintBatch/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvPrintBatch\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.InvPrintBatch.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:40px;top:203px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 9672), Tuple.Create("\'", 9744)
, Tuple.Create(Tuple.Create("", 9680), Tuple.Create("IQLabel100719", 9680), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 9693), Tuple.Create<System.Object, System.Int32>(!Model.InvExported.LabelVisible ? " hide " : ""
, 9694), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9745), Tuple.Create("\'", 9957)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 9754), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvExported.BackHEXColor) ? "" : "color:" + Model.InvExported.BackHEXColor + ";"
, 9754), false)
, Tuple.Create(Tuple.Create("", 9864), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 9864), true)
);
WriteLiteral(">Sent to Dover</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvExported\'");
WriteAttribute("class", Tuple.Create(" class=\'", 10036), Tuple.Create("\'", 10091)
, Tuple.Create(Tuple.Create("  ", 10044), Tuple.Create<System.Object, System.Int32>(!Model.InvExported.Visible ? " hide " : ""
, 10046), false)
);
WriteLiteral(" disabled=disabled");
WriteLiteral(" type=\'checkbox\'");
WriteLiteral(" value=\'true\'");
WriteLiteral(" ");
                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvExported/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvExported/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:228px;\' name=\'" +
"PopulateInvExported\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.PopulateInvExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateInvExported\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateInvExported ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 10657), Tuple.Create("\'", 10729)
, Tuple.Create(Tuple.Create("", 10665), Tuple.Create("IQLabel100720", 10665), true)
, Tuple.Create(Tuple.Create(" ", 10678), Tuple.Create<System.Object, System.Int32>(!Model.InvTescoRef.LabelVisible ? " hide " : ""
, 10679), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10730), Tuple.Create("\'", 10942)
                , Tuple.Create(Tuple.Create("", 10739), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvTescoRef.BackHEXColor) ? "" : "color:" + Model.InvTescoRef.BackHEXColor + ";"
, 10739), false)
, Tuple.Create(Tuple.Create("", 10849), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:253px;", 10849), true)
);
WriteLiteral(">Tesco Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvTescoRef\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 11032), Tuple.Create("\'", 11100)
, Tuple.Create(Tuple.Create("", 11040), Tuple.Create("form-control", 11040), true)
, Tuple.Create(Tuple.Create("   ", 11052), Tuple.Create<System.Object, System.Int32>(!Model.InvTescoRef.Visible ? " hide " : ""
, 11055), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvTescoRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvTescoRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvTescoRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                  Write(Model.InvTescoRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:253px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 11482), Tuple.Create("\'", 11554)
, Tuple.Create(Tuple.Create("", 11490), Tuple.Create("IQLabel100721", 11490), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 11503), Tuple.Create<System.Object, System.Int32>(!Model.InvProforma.LabelVisible ? " hide " : ""
, 11504), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11555), Tuple.Create("\'", 11767)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 11564), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvProforma.BackHEXColor) ? "" : "color:" + Model.InvProforma.BackHEXColor + ";"
, 11564), false)
, Tuple.Create(Tuple.Create("", 11674), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:278px;", 11674), true)
);
WriteLiteral(">Proforma</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvProforma\'");
WriteAttribute("class", Tuple.Create(" class=\'", 11841), Tuple.Create("\'", 11896)
, Tuple.Create(Tuple.Create("  ", 11849), Tuple.Create<System.Object, System.Int32>(!Model.InvProforma.Visible ? " hide " : ""
, 11851), false)
);
WriteLiteral(" ");
                                                                                                          Write(Model.RecordLocked || !Model.InvProforma.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvProforma/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvProforma/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:130px;height:16px;width:16px;top:278px;\' name=\'" +
"PopulateInvProforma\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.PopulateInvProforma ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateInvProforma\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateInvProforma ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.InvCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.InvCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 13088), Tuple.Create("\'", 13156)
, Tuple.Create(Tuple.Create("", 13096), Tuple.Create("IQLabel100731", 13096), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 13109), Tuple.Create<System.Object, System.Int32>(!Model.InvToId.LabelVisible ? " hide " : ""
, 13110), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13157), Tuple.Create("\'", 13361)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 13166), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvToId.BackHEXColor) ? "" : "color:" + Model.InvToId.BackHEXColor + ";"
, 13166), false)
, Tuple.Create(Tuple.Create("", 13268), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:3px;", 13268), true)
);
WriteLiteral(">Invoice To ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvToId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvToId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.InvToId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvToId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvToId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvToId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.InvToId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 13935), Tuple.Create("\'", 14001)
, Tuple.Create(Tuple.Create("", 13943), Tuple.Create("IQLabel100732", 13943), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 13956), Tuple.Create<System.Object, System.Int32>(!Model.InvTo.LabelVisible ? " hide " : ""
, 13957), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14002), Tuple.Create("\'", 14203)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 14011), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvTo.BackHEXColor) ? "" : "color:" + Model.InvTo.BackHEXColor + ";"
, 14011), false)
, Tuple.Create(Tuple.Create("", 14109), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:28px;", 14109), true)
);
WriteLiteral(">Invoice To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:400px;height:21px;width:200px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Invoices_InvTo\'");
                                 Write(Model.RecordLocked || !Model.InvTo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvTo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                        Write(!Model.InvTo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Inv/AutoCompleteInvTo/");
                                        Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateInvTo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateInvTo.ToString() != "" && Model.PopulateInvTo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.InvTo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateInvTo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 15834), Tuple.Create("\'", 15902)
, Tuple.Create(Tuple.Create("", 15842), Tuple.Create("IQLabel100733", 15842), true)
, Tuple.Create(Tuple.Create(" ", 15855), Tuple.Create<System.Object, System.Int32>(!Model.InvAddr.LabelVisible ? " hide " : ""
, 15856), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15903), Tuple.Create("\'", 16108)
                        , Tuple.Create(Tuple.Create("", 15912), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvAddr.BackHEXColor) ? "" : "color:" + Model.InvAddr.BackHEXColor + ";"
, 15912), false)
, Tuple.Create(Tuple.Create("", 16014), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:53px;", 16014), true)
);
WriteLiteral(">Inv Co Address1</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvAddr\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 16200), Tuple.Create("\'", 16264)
, Tuple.Create(Tuple.Create("", 16208), Tuple.Create("form-control", 16208), true)
, Tuple.Create(Tuple.Create("   ", 16220), Tuple.Create<System.Object, System.Int32>(!Model.InvAddr.Visible ? " hide " : ""
, 16223), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                  Write(Model.InvAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:200px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 16629), Tuple.Create("\'", 16697)
, Tuple.Create(Tuple.Create("", 16637), Tuple.Create("IQLabel100734", 16637), true)
                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 16650), Tuple.Create<System.Object, System.Int32>(!Model.InvTown.LabelVisible ? " hide " : ""
, 16651), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16698), Tuple.Create("\'", 16903)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 16707), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvTown.BackHEXColor) ? "" : "color:" + Model.InvTown.BackHEXColor + ";"
, 16707), false)
, Tuple.Create(Tuple.Create("", 16809), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:78px;", 16809), true)
);
WriteLiteral(">Inv Co Town</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvTown\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 16991), Tuple.Create("\'", 17055)
, Tuple.Create(Tuple.Create("", 16999), Tuple.Create("form-control", 16999), true)
, Tuple.Create(Tuple.Create("   ", 17011), Tuple.Create<System.Object, System.Int32>(!Model.InvTown.Visible ? " hide " : ""
, 17014), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvTown/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvTown/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvTown\' value=\'");
                                                                                                                                                                                                                                                                                                                                                  Write(Model.InvTown.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 17420), Tuple.Create("\'", 17486)
, Tuple.Create(Tuple.Create("", 17428), Tuple.Create("IQLabel100735", 17428), true)
                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 17441), Tuple.Create<System.Object, System.Int32>(!Model.InvPC.LabelVisible ? " hide " : ""
, 17442), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17487), Tuple.Create("\'", 17689)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 17496), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvPC.BackHEXColor) ? "" : "color:" + Model.InvPC.BackHEXColor + ";"
, 17496), false)
, Tuple.Create(Tuple.Create("", 17594), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:103px;", 17594), true)
);
WriteLiteral(">Inv Co Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 17779), Tuple.Create("\'", 17841)
, Tuple.Create(Tuple.Create("", 17787), Tuple.Create("form-control", 17787), true)
, Tuple.Create(Tuple.Create("   ", 17799), Tuple.Create<System.Object, System.Int32>(!Model.InvPC.Visible ? " hide " : ""
, 17802), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                          Write(Model.InvPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:100px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 18199), Tuple.Create("\'", 18267)
, Tuple.Create(Tuple.Create("", 18207), Tuple.Create("IQLabel100736", 18207), true)
                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 18220), Tuple.Create<System.Object, System.Int32>(!Model.InvDesc.LabelVisible ? " hide " : ""
, 18221), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 18268), Tuple.Create("\'", 18474)
                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 18277), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvDesc.BackHEXColor) ? "" : "color:" + Model.InvDesc.BackHEXColor + ";"
, 18277), false)
, Tuple.Create(Tuple.Create("", 18379), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:128px;", 18379), true)
);
WriteLiteral(">Invoice Description</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:400px;height:46px;width:200px;top:128px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Invoice Description\'");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvDesc\'");
WriteLiteral(" ");
                                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.InvDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvDesc/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(!Model.InvDesc.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateInvDesc\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateInvDesc);
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
WriteLiteral(" data-target=\"*[name=PopulateInvDesc]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 19647), Tuple.Create("\'", 19714)
, Tuple.Create(Tuple.Create("", 19655), Tuple.Create("IQLabel100739", 19655), true)
, Tuple.Create(Tuple.Create(" ", 19668), Tuple.Create<System.Object, System.Int32>(!Model.InvNet.LabelVisible ? " hide " : ""
, 19669), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19715), Tuple.Create("\'", 19919)
                           , Tuple.Create(Tuple.Create("", 19724), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvNet.BackHEXColor) ? "" : "color:" + Model.InvNet.BackHEXColor + ";"
, 19724), false)
, Tuple.Create(Tuple.Create("", 19824), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:178px;", 19824), true)
);
WriteLiteral(">Net Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvNet\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 20005), Tuple.Create("\'", 20068)
, Tuple.Create(Tuple.Create("", 20013), Tuple.Create("form-control", 20013), true)
, Tuple.Create(Tuple.Create("   ", 20025), Tuple.Create<System.Object, System.Int32>(!Model.InvNet.Visible ? " hide " : ""
, 20028), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvNet/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvNet/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvNet\' value=\'");
                                                                                                                                                                                                                                                                                                                                              Write(Model.InvNet.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 20429), Tuple.Create("\'", 20496)
, Tuple.Create(Tuple.Create("", 20437), Tuple.Create("IQLabel100740", 20437), true)
                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 20450), Tuple.Create<System.Object, System.Int32>(!Model.InvVAT.LabelVisible ? " hide " : ""
, 20451), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20497), Tuple.Create("\'", 20701)
                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 20506), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvVAT.BackHEXColor) ? "" : "color:" + Model.InvVAT.BackHEXColor + ";"
, 20506), false)
, Tuple.Create(Tuple.Create("", 20606), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:203px;", 20606), true)
);
WriteLiteral(">VAT Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvVAT\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 20787), Tuple.Create("\'", 20850)
, Tuple.Create(Tuple.Create("", 20795), Tuple.Create("form-control", 20795), true)
, Tuple.Create(Tuple.Create("   ", 20807), Tuple.Create<System.Object, System.Int32>(!Model.InvVAT.Visible ? " hide " : ""
, 20810), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvVAT/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvVAT/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvVAT\' value=\'");
                                                                                                                                                                                                                                                                                                                                              Write(Model.InvVAT.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:203px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 21211), Tuple.Create("\'", 21280)
, Tuple.Create(Tuple.Create("", 21219), Tuple.Create("IQLabel100741", 21219), true)
                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 21232), Tuple.Create<System.Object, System.Int32>(!Model.InvTotal.LabelVisible ? " hide " : ""
, 21233), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21281), Tuple.Create("\'", 21489)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 21290), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvTotal.BackHEXColor) ? "" : "color:" + Model.InvTotal.BackHEXColor + ";"
, 21290), false)
, Tuple.Create(Tuple.Create("", 21394), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:228px;", 21394), true)
);
WriteLiteral(">Invoice Total</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvTotal\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 21580), Tuple.Create("\'", 21645)
, Tuple.Create(Tuple.Create("", 21588), Tuple.Create("form-control", 21588), true)
, Tuple.Create(Tuple.Create("   ", 21600), Tuple.Create<System.Object, System.Int32>(!Model.InvTotal.Visible ? " hide " : ""
, 21603), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvTotal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvTotal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvTotal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                      Write(Model.InvTotal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:80px;top:228px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 22014), Tuple.Create("\'", 22082)
, Tuple.Create(Tuple.Create("", 22022), Tuple.Create("IQLabel100742", 22022), true)
                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 22035), Tuple.Create<System.Object, System.Int32>(!Model.InvCurr.LabelVisible ? " hide " : ""
, 22036), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 22083), Tuple.Create("\'", 22288)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 22092), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvCurr.BackHEXColor) ? "" : "color:" + Model.InvCurr.BackHEXColor + ";"
, 22092), false)
, Tuple.Create(Tuple.Create("", 22194), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:325px;height:21px;width:70" +
"px;top:253px;", 22194), true)
);
WriteLiteral(">Currency</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvCurr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvCurr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                      Write(!Model.InvCurr.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvCurr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvCurr/',$(this));\""));
WriteLiteral("   name=\'PopulateInvCurr\'  style=\'position: absolute; left:400px;height:21px;widt" +
"h:100px;top:253px;\'>\r\n");
             foreach(var itm in Model.InvCurr.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 22868), Tuple.Create("\'", 22889)
, Tuple.Create(Tuple.Create("", 22876), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 22876), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 23020), Tuple.Create("\'", 23092)
, Tuple.Create(Tuple.Create("", 23028), Tuple.Create("IQLabel100743", 23028), true)
, Tuple.Create(Tuple.Create(" ", 23041), Tuple.Create<System.Object, System.Int32>(!Model.InvExchRate.LabelVisible ? " hide " : ""
, 23042), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23093), Tuple.Create("\'", 23307)
                         , Tuple.Create(Tuple.Create("", 23102), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvExchRate.BackHEXColor) ? "" : "color:" + Model.InvExchRate.BackHEXColor + ";"
, 23102), false)
, Tuple.Create(Tuple.Create("", 23212), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:10" +
"0px;top:278px;", 23212), true)
);
WriteLiteral(">Exchange Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvExchRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvExchRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.InvExchRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvExchRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvExchRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvExchRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.InvExchRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:400px;height:21px;width:60px;top:278px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 23911), Tuple.Create("\'", 23984)
, Tuple.Create(Tuple.Create("", 23919), Tuple.Create("IQLabel100751", 23919), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 23932), Tuple.Create<System.Object, System.Int32>(!Model.InvRouteFrom.LabelVisible ? " hide " : ""
, 23933), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23985), Tuple.Create("\'", 24199)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 23994), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvRouteFrom.BackHEXColor) ? "" : "color:" + Model.InvRouteFrom.BackHEXColor + ";"
, 23994), false)
, Tuple.Create(Tuple.Create("", 24106), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:3px;", 24106), true)
);
WriteLiteral(">Route From</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:120px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvRouteFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvRouteFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                           Write(!Model.InvRouteFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvRouteFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvRouteFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateInvRouteFrom\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvRouteFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 24884), Tuple.Create("\'", 24905)
, Tuple.Create(Tuple.Create("", 24892), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 24892), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvRouteFrom.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvRouteFrom]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 25801), Tuple.Create("\'", 25872)
, Tuple.Create(Tuple.Create("", 25809), Tuple.Create("IQLabel100752", 25809), true)
, Tuple.Create(Tuple.Create(" ", 25822), Tuple.Create<System.Object, System.Int32>(!Model.InvRouteTo.LabelVisible ? " hide " : ""
, 25823), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25873), Tuple.Create("\'", 26084)
                           , Tuple.Create(Tuple.Create("", 25882), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvRouteTo.BackHEXColor) ? "" : "color:" + Model.InvRouteTo.BackHEXColor + ";"
, 25882), false)
, Tuple.Create(Tuple.Create("", 25990), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:28px;", 25990), true)
);
WriteLiteral(">Route To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:120px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvRouteTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvRouteTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.InvRouteTo.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvRouteTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvRouteTo/',$(this));\""));
WriteLiteral("   name=\'PopulateInvRouteTo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvRouteTo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 26754), Tuple.Create("\'", 26775)
, Tuple.Create(Tuple.Create("", 26762), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 26762), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvRouteTo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvRouteTo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 27667), Tuple.Create("\'", 27740)
, Tuple.Create(Tuple.Create("", 27675), Tuple.Create("IQLabel100753", 27675), true)
, Tuple.Create(Tuple.Create(" ", 27688), Tuple.Create<System.Object, System.Int32>(!Model.InvFerryName.LabelVisible ? " hide " : ""
, 27689), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27741), Tuple.Create("\'", 27956)
                             , Tuple.Create(Tuple.Create("", 27750), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvFerryName.BackHEXColor) ? "" : "color:" + Model.InvFerryName.BackHEXColor + ";"
, 27750), false)
, Tuple.Create(Tuple.Create("", 27862), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:53px;", 27862), true)
);
WriteLiteral(">Ferry Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvFerryName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvFerryName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.InvFerryName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvFerryName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvFerryName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.InvFerryName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:750px;height:21px;width:120px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 28564), Tuple.Create("\'", 28637)
, Tuple.Create(Tuple.Create("", 28572), Tuple.Create("IQLabel100754", 28572), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 28585), Tuple.Create<System.Object, System.Int32>(!Model.InvFerryDate.LabelVisible ? " hide " : ""
, 28586), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 28638), Tuple.Create("\'", 28853)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 28647), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvFerryDate.BackHEXColor) ? "" : "color:" + Model.InvFerryDate.BackHEXColor + ";"
, 28647), false)
, Tuple.Create(Tuple.Create("", 28759), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:78px;", 28759), true)
);
WriteLiteral(">Ferry Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvFerryDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvFerryDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                 Write(!Model.InvFerryDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvFerryDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateInvFerryDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.InvFerryDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateInvFerryDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 29812), Tuple.Create("\'", 29885)
, Tuple.Create(Tuple.Create("", 29820), Tuple.Create("IQLabel100755", 29820), true)
, Tuple.Create(Tuple.Create(" ", 29833), Tuple.Create<System.Object, System.Int32>(!Model.InvFerryTime.LabelVisible ? " hide " : ""
, 29834), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29886), Tuple.Create("\'", 30102)
                                 , Tuple.Create(Tuple.Create("", 29895), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvFerryTime.BackHEXColor) ? "" : "color:" + Model.InvFerryTime.BackHEXColor + ";"
, 29895), false)
, Tuple.Create(Tuple.Create("", 30007), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:103px;", 30007), true)
);
WriteLiteral(">Ferry Time</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvFerryTime\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvFerryTime.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.InvFerryTime.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryTime/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvFerryTime/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvFerryTime\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.InvFerryTime.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:750px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 30710), Tuple.Create("\'", 30781)
, Tuple.Create(Tuple.Create("", 30718), Tuple.Create("IQLabel100756", 30718), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 30731), Tuple.Create<System.Object, System.Int32>(!Model.InvVehicle.LabelVisible ? " hide " : ""
, 30732), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 30782), Tuple.Create("\'", 30994)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 30791), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvVehicle.BackHEXColor) ? "" : "color:" + Model.InvVehicle.BackHEXColor + ";"
, 30791), false)
, Tuple.Create(Tuple.Create("", 30899), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:128px;", 30899), true)
);
WriteLiteral(">Vehicle</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvVehicle\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 31081), Tuple.Create("\'", 31148)
, Tuple.Create(Tuple.Create("", 31089), Tuple.Create("form-control", 31089), true)
, Tuple.Create(Tuple.Create("   ", 31101), Tuple.Create<System.Object, System.Int32>(!Model.InvVehicle.Visible ? " hide " : ""
, 31104), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvVehicle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvVehicle/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvVehicle\' value=\'");
                                                                                                                                                                                                                                                                                                                                                              Write(Model.InvVehicle.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:750px;height:21px;width:120px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 31526), Tuple.Create("\'", 31597)
, Tuple.Create(Tuple.Create("", 31534), Tuple.Create("IQLabel100757", 31534), true)
                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 31547), Tuple.Create<System.Object, System.Int32>(!Model.InvTrailer.LabelVisible ? " hide " : ""
, 31548), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 31598), Tuple.Create("\'", 31810)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 31607), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvTrailer.BackHEXColor) ? "" : "color:" + Model.InvTrailer.BackHEXColor + ";"
, 31607), false)
, Tuple.Create(Tuple.Create("", 31715), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:153px;", 31715), true)
);
WriteLiteral(">Trailer</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvTrailer\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 31897), Tuple.Create("\'", 31964)
, Tuple.Create(Tuple.Create("", 31905), Tuple.Create("form-control", 31905), true)
, Tuple.Create(Tuple.Create("   ", 31917), Tuple.Create<System.Object, System.Int32>(!Model.InvTrailer.Visible ? " hide " : ""
, 31920), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvTrailer/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvTrailer/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvTrailer\' value=\'");
                                                                                                                                                                                                                                                                                                                                                              Write(Model.InvTrailer.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:750px;height:21px;width:120px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 32342), Tuple.Create("\'", 32411)
, Tuple.Create(Tuple.Create("", 32350), Tuple.Create("IQLabel100759", 32350), true)
                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 32363), Tuple.Create<System.Object, System.Int32>(!Model.InvNote1.LabelVisible ? " hide " : ""
, 32364), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 32412), Tuple.Create("\'", 32620)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 32421), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvNote1.BackHEXColor) ? "" : "color:" + Model.InvNote1.BackHEXColor + ";"
, 32421), false)
, Tuple.Create(Tuple.Create("", 32525), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:10" +
"0px;top:178px;", 32525), true)
);
WriteLiteral(">Comment 1</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:240px;top:178px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvNote1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvNote1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.InvNote1.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvNote1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvNote1/',$(this));\""));
WriteLiteral("   name=\'PopulateInvNote1\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvNote1.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 33278), Tuple.Create("\'", 33299)
, Tuple.Create(Tuple.Create("", 33286), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 33286), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvNote1.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvNote1]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 34193), Tuple.Create("\'", 34262)
, Tuple.Create(Tuple.Create("", 34201), Tuple.Create("IQLabel100760", 34201), true)
, Tuple.Create(Tuple.Create(" ", 34214), Tuple.Create<System.Object, System.Int32>(!Model.InvNote2.LabelVisible ? " hide " : ""
, 34215), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 34263), Tuple.Create("\'", 34471)
                         , Tuple.Create(Tuple.Create("", 34272), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvNote2.BackHEXColor) ? "" : "color:" + Model.InvNote2.BackHEXColor + ";"
, 34272), false)
, Tuple.Create(Tuple.Create("", 34376), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:10" +
"0px;top:203px;", 34376), true)
);
WriteLiteral(">Comment 2</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:240px;top:203px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvNote2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvNote2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.InvNote2.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvNote2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvNote2/',$(this));\""));
WriteLiteral("   name=\'PopulateInvNote2\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvNote2.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 35129), Tuple.Create("\'", 35150)
, Tuple.Create(Tuple.Create("", 35137), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 35137), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvNote2.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvNote2]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 36044), Tuple.Create("\'", 36113)
, Tuple.Create(Tuple.Create("", 36052), Tuple.Create("IQLabel100761", 36052), true)
, Tuple.Create(Tuple.Create(" ", 36065), Tuple.Create<System.Object, System.Int32>(!Model.InvNote3.LabelVisible ? " hide " : ""
, 36066), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36114), Tuple.Create("\'", 36322)
                         , Tuple.Create(Tuple.Create("", 36123), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvNote3.BackHEXColor) ? "" : "color:" + Model.InvNote3.BackHEXColor + ";"
, 36123), false)
, Tuple.Create(Tuple.Create("", 36227), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:645px;height:21px;width:10" +
"0px;top:228px;", 36227), true)
);
WriteLiteral(">Comment 3</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:750px;height:21px;width:240px;top:228px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvNote3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.InvNote3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.InvNote3.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvNote3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvNote3/',$(this));\""));
WriteLiteral("   name=\'PopulateInvNote3\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.InvNote3.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 36980), Tuple.Create("\'", 37001)
, Tuple.Create(Tuple.Create("", 36988), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 36988), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateInvNote3.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateInvNote3]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 37895), Tuple.Create("\'", 37971)
, Tuple.Create(Tuple.Create("", 37903), Tuple.Create("IQLabel100762", 37903), true)
, Tuple.Create(Tuple.Create(" ", 37916), Tuple.Create<System.Object, System.Int32>(!Model.InvSentToClient.LabelVisible ? " hide " : ""
, 37917), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 37972), Tuple.Create("\'", 38194)
                                , Tuple.Create(Tuple.Create("", 37981), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvSentToClient.BackHEXColor) ? "" : "color:" + Model.InvSentToClient.BackHEXColor + ";"
, 37981), false)
, Tuple.Create(Tuple.Create("", 38099), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:625px;height:21px;width:12" +
"0px;top:253px;", 38099), true)
);
WriteLiteral(">Sent to Client</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Invoices_InvSentToClient\'");
WriteAttribute("class", Tuple.Create(" class=\'", 38278), Tuple.Create("\'", 38337)
, Tuple.Create(Tuple.Create("  ", 38286), Tuple.Create<System.Object, System.Int32>(!Model.InvSentToClient.Visible ? " hide " : ""
, 38288), false)
);
WriteLiteral(" ");
                                                                                                                  Write(Model.RecordLocked || !Model.InvSentToClient.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Inv/SaveInvSentToClient/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Inv/CallbackInvSentToClient/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:750px;height:16px;width:16px;top:253px;\' name=\'" +
"PopulateInvSentToClient\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateInvSentToClient ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateInvSentToClient\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                      Write(!Model.PopulateInvSentToClient ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Edit_1.cshtml")]
    public partial class Views_Inv_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Inv/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoices</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 397), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 407), Tuple.Create("IQJSCall(\"/Inv/Delete/?RecId=", 407), true)
    , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Inv/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Inv", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1336), Tuple.Create("\'", 1358)
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1344), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1404), Tuple.Create("\'", 1428)
, Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1412), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Inv\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1525), Tuple.Create("\"", 1550)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create<System.Object, System.Int32>(Model.InvIdValue
, 1533), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1596), Tuple.Create("\"", 1619)
, Tuple.Create(Tuple.Create("", 1604), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1604), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1661), Tuple.Create("\"", 1684)
, Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1669), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Inv/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1978), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create("/Inv/ViewHistory/?RecId=", 1985), true)
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
WriteLiteral(" id=\"Invoices\"");
WriteLiteral(" style=\'position:relative;height:329px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Inv_Invoices.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Invoice Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2842), Tuple.Create("\'", 2944)
, Tuple.Create(Tuple.Create("", 2850), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "InvLine" ? "active" :  "") : "" )
, 2850), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#InvLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoice Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Period Inv Includes").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3143), Tuple.Create("\'", 3247)
, Tuple.Create(Tuple.Create("", 3151), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "PeriodInv" ? "active" :  "") : "" )
, 3151), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#PeriodInv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Period Inv Includes</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3460), Tuple.Create("\"", 3475)
, Tuple.Create(Tuple.Create("", 3467), Tuple.Create("#", 3467), true)
, Tuple.Create(Tuple.Create("", 3468), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3468), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Invoice Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "InvLine" ? "data-loadTarget='#721d8f9872b14641a3c60720f07b6b3a' data-dynamicContent='/InvLine/ListFromQuery?Limit=50&Ord=InvLLineNo&Clause=InvLInvNo=" + Model.InvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                       Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "InvLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"InvLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/InvLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "InvLine") {
                      Html.RenderPartial("~/Views/InvLine_List_1.cshtml", Model.InvLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"721d8f9872b14641a3c60720f07b6b3a\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Period Inv Includes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "PeriodInv" ? "data-loadTarget='#758a21e1705d4383a0bde318b7f66c04' data-dynamicContent='/PeriodInv/ListFromQuery?Limit=50&Ord=PInvId&Clause=PInvId=" + Model.InvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                    Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "PeriodInv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"PeriodInv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 5164), Tuple.Create("\'", 5211)
, Tuple.Create(Tuple.Create("", 5172), Tuple.Create("/PeriodInv/Add?PInvId=", 5172), true)
        , Tuple.Create(Tuple.Create("", 5194), Tuple.Create<System.Object, System.Int32>(Model.InvIdValue
, 5194), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Period Inv Includes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "PeriodInv") {
                      Html.RenderPartial("~/Views/PeriodInv_List_1.cshtml", Model.PeriodInvs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"758a21e1705d4383a0bde318b7f66c04\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 5676), Tuple.Create("\"", 5688)
, Tuple.Create(Tuple.Create("", 5681), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5681), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Add_1.cshtml")]
    public partial class Views_Inv_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoices";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoices\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Inv/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Invoices\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Inv_Invoices.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_List_1.cshtml")]
    public partial class Views_Inv_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Inv>>
    {
        public Views_Inv_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoices List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoices List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoices</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 552)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Inv/ListFromQuery/?Clause=", 493), true)
                                                               , Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 520), false)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("&Ord=", 535), true)
                                                                                   , Tuple.Create(Tuple.Create("", 540), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 540), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Freight or Duty</th><th>Job No</th><th>Or" +
"der Number</th><th>Invoice Date</th><th>Import or Export</th>\t\t</tr>\r\n\t</thead>\r" +
"\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 944), Tuple.Create("\"", 981)
, Tuple.Create(Tuple.Create("", 951), Tuple.Create("/Inv/Load/?RecId=", 951), true)
            , Tuple.Create(Tuple.Create("", 968), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 968), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvFreightDuty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1381)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvFreightDuty/?RecId=", 1303), true)
                                                                     , Tuple.Create(Tuple.Create("", 1357), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1357), false)
, Tuple.Create(Tuple.Create("", 1370), Tuple.Create("\',$(this));", 1370), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvFreightDuty\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.InvFreightDuty.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Inv/AutoCompleteInvJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1711), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvJobNo/?RecId=", 1722), true)
                                                                                                           , Tuple.Create(Tuple.Create("", 1770), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1770), false)
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create("\',$(this));", 1783), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'InvJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                    Write(Html.Raw(itm.InvJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                    if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2257)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvDate/?RecId=", 2186), true)
                                                                                            , Tuple.Create(Tuple.Create("", 2233), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2233), false)
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create("\',$(this));", 2246), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'InvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2324), Tuple.Create("\'", 2364)
                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2332), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvDate.HTMLValue)
, 2332), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2550), Tuple.Create("\"", 2634)
, Tuple.Create(Tuple.Create("", 2561), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvImpExp/?RecId=", 2561), true)
                                                                , Tuple.Create(Tuple.Create("", 2610), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2610), false)
, Tuple.Create(Tuple.Create("", 2623), Tuple.Create("\',$(this));", 2623), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.InvImpExp.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Edit_2.cshtml")]
    public partial class Views_Inv_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Inv/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoices</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 397), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 407), Tuple.Create("IQJSCall(\"/Inv/Delete/?RecId=", 407), true)
    , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Inv/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Inv", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1336), Tuple.Create("\'", 1358)
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1344), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1404), Tuple.Create("\'", 1428)
, Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1412), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Inv\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1525), Tuple.Create("\"", 1550)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create<System.Object, System.Int32>(Model.InvIdValue
, 1533), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1596), Tuple.Create("\"", 1619)
, Tuple.Create(Tuple.Create("", 1604), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1604), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1661), Tuple.Create("\"", 1684)
, Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1669), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Inv/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1978), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create("/Inv/ViewHistory/?RecId=", 1985), true)
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
WriteLiteral(" id=\"Invoices\"");
WriteLiteral(" style=\'position:relative;height:329px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Inv_Invoices.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Invoice Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2842), Tuple.Create("\'", 2944)
, Tuple.Create(Tuple.Create("", 2850), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "InvLine" ? "active" :  "") : "" )
, 2850), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#InvLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoice Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Period Inv Includes").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3143), Tuple.Create("\'", 3247)
, Tuple.Create(Tuple.Create("", 3151), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "PeriodInv" ? "active" :  "") : "" )
, 3151), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#PeriodInv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Period Inv Includes</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3460), Tuple.Create("\"", 3475)
, Tuple.Create(Tuple.Create("", 3467), Tuple.Create("#", 3467), true)
, Tuple.Create(Tuple.Create("", 3468), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3468), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Invoice Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "InvLine" ? "data-loadTarget='#ac839e359d984f8087fe0855206dbd97' data-dynamicContent='/InvLine/ListFromQuery?Limit=50&Ord=InvLLineNo&Clause=InvLInvNo=" + Model.InvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                       Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "InvLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"InvLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/InvLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "InvLine") {
                      Html.RenderPartial("~/Views/InvLine_List_2.cshtml", Model.InvLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"ac839e359d984f8087fe0855206dbd97\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Period Inv Includes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "PeriodInv" ? "data-loadTarget='#53ae64968d274627ac66b29287e22705' data-dynamicContent='/PeriodInv/ListFromQuery?Limit=50&Ord=PInvId&Clause=PInvId=" + Model.InvIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                    Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "PeriodInv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"PeriodInv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 5164), Tuple.Create("\'", 5211)
, Tuple.Create(Tuple.Create("", 5172), Tuple.Create("/PeriodInv/Add?PInvId=", 5172), true)
        , Tuple.Create(Tuple.Create("", 5194), Tuple.Create<System.Object, System.Int32>(Model.InvIdValue
, 5194), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Period Inv Includes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "PeriodInv") {
                      Html.RenderPartial("~/Views/PeriodInv_List_2.cshtml", Model.PeriodInvs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"53ae64968d274627ac66b29287e22705\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 5676), Tuple.Create("\"", 5688)
, Tuple.Create(Tuple.Create("", 5681), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5681), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Add_2.cshtml")]
    public partial class Views_Inv_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoices";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoices\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Inv/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Invoices\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Inv_Invoices.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_List_2.cshtml")]
    public partial class Views_Inv_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Inv>>
    {
        public Views_Inv_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoices List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoices List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoices</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 552)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Inv/ListFromQuery/?Clause=", 493), true)
                                                               , Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 520), false)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("&Ord=", 535), true)
                                                                                   , Tuple.Create(Tuple.Create("", 540), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 540), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Freight or Duty</th><th>Job No</th><th>Or" +
"der Number</th><th>Invoice Date</th><th>Import or Export</th>\t\t</tr>\r\n\t</thead>\r" +
"\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 944), Tuple.Create("\"", 981)
, Tuple.Create(Tuple.Create("", 951), Tuple.Create("/Inv/Load/?RecId=", 951), true)
            , Tuple.Create(Tuple.Create("", 968), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 968), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvFreightDuty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1381)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvFreightDuty/?RecId=", 1303), true)
                                                                     , Tuple.Create(Tuple.Create("", 1357), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1357), false)
, Tuple.Create(Tuple.Create("", 1370), Tuple.Create("\',$(this));", 1370), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvFreightDuty\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.InvFreightDuty.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Inv/AutoCompleteInvJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1711), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvJobNo/?RecId=", 1722), true)
                                                                                                           , Tuple.Create(Tuple.Create("", 1770), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1770), false)
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create("\',$(this));", 1783), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'InvJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                    Write(Html.Raw(itm.InvJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                    if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2257)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvDate/?RecId=", 2186), true)
                                                                                            , Tuple.Create(Tuple.Create("", 2233), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2233), false)
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create("\',$(this));", 2246), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'InvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2324), Tuple.Create("\'", 2364)
                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2332), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvDate.HTMLValue)
, 2332), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2550), Tuple.Create("\"", 2634)
, Tuple.Create(Tuple.Create("", 2561), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvImpExp/?RecId=", 2561), true)
                                                                , Tuple.Create(Tuple.Create("", 2610), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2610), false)
, Tuple.Create(Tuple.Create("", 2623), Tuple.Create("\',$(this));", 2623), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.InvImpExp.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Edit_3.cshtml")]
    public partial class Views_Inv_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Inv/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoices</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 397), Tuple.Create("\'", 454)
, Tuple.Create(Tuple.Create("", 407), Tuple.Create("IQJSCall(\"/Inv/Delete/?RecId=", 407), true)
    , Tuple.Create(Tuple.Create("", 436), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 436), false)
, Tuple.Create(Tuple.Create("", 451), Tuple.Create("\");", 451), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Inv/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Inv", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1336), Tuple.Create("\'", 1358)
, Tuple.Create(Tuple.Create("", 1344), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1344), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1404), Tuple.Create("\'", 1428)
, Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1412), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Inv\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1525), Tuple.Create("\"", 1550)
, Tuple.Create(Tuple.Create("", 1533), Tuple.Create<System.Object, System.Int32>(Model.InvIdValue
, 1533), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1596), Tuple.Create("\"", 1619)
, Tuple.Create(Tuple.Create("", 1604), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1604), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1661), Tuple.Create("\"", 1684)
, Tuple.Create(Tuple.Create("", 1669), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1669), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Inv/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1978), Tuple.Create("\"", 2075)
, Tuple.Create(Tuple.Create("", 1985), Tuple.Create("/Inv/ViewHistory/?RecId=", 1985), true)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_Add_3.cshtml")]
    public partial class Views_Inv_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Inv>
    {
        public Views_Inv_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoices";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoices\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Inv/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Inv>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Inv_List_3.cshtml")]
    public partial class Views_Inv_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Inv>>
    {
        public Views_Inv_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoices List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoices List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoices</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Inv/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 486), Tuple.Create("\"", 552)
, Tuple.Create(Tuple.Create("", 493), Tuple.Create("/Inv/ListFromQuery/?Clause=", 493), true)
                                                               , Tuple.Create(Tuple.Create("", 520), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 520), false)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("&Ord=", 535), true)
                                                                                   , Tuple.Create(Tuple.Create("", 540), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 540), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Invoice Number</th><th>Freight or Duty</th><th>Job No</th><th>Or" +
"der Number</th><th>Invoice Date</th><th>Import or Export</th>\t\t</tr>\r\n\t</thead>\r" +
"\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 944), Tuple.Create("\"", 981)
, Tuple.Create(Tuple.Create("", 951), Tuple.Create("/Inv/Load/?RecId=", 951), true)
            , Tuple.Create(Tuple.Create("", 968), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 968), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvFreightDuty.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1292), Tuple.Create("\"", 1381)
, Tuple.Create(Tuple.Create("", 1303), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvFreightDuty/?RecId=", 1303), true)
                                                                     , Tuple.Create(Tuple.Create("", 1357), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1357), false)
, Tuple.Create(Tuple.Create("", 1370), Tuple.Create("\',$(this));", 1370), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvFreightDuty\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                 Write(Html.Raw(itm.InvFreightDuty.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Inv/AutoCompleteInvJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1711), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvJobNo/?RecId=", 1722), true)
                                                                                                           , Tuple.Create(Tuple.Create("", 1770), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1770), false)
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create("\',$(this));", 1783), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'InvJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                    Write(Html.Raw(itm.InvJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.InvOrder.DisplayValue);
WriteLiteral("</td>");
                                                                                    if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2257)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvDate/?RecId=", 2186), true)
                                                                                            , Tuple.Create(Tuple.Create("", 2233), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2233), false)
, Tuple.Create(Tuple.Create("", 2246), Tuple.Create("\',$(this));", 2246), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'InvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2324), Tuple.Create("\'", 2364)
                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 2332), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.InvDate.HTMLValue)
, 2332), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvImpExp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2550), Tuple.Create("\"", 2634)
, Tuple.Create(Tuple.Create("", 2561), Tuple.Create("javascript:IQAutoSave(\'/Inv/SaveInvImpExp/?RecId=", 2561), true)
                                                                , Tuple.Create(Tuple.Create("", 2610), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2610), false)
, Tuple.Create(Tuple.Create("", 2623), Tuple.Create("\',$(this));", 2623), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvImpExp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                       Write(Html.Raw(itm.InvImpExp.HTMLValue));
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
