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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_TransportLines.cshtml")]
    public partial class Views_JobLine_TransportLines_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_TransportLines_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel100611", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.JobLJobNo.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 340)
        , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLJobNo.BackHEXColor) ? "" : "color:" + Model.JobLJobNo.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 249), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 249), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'TransportLines_JobLJobNo\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLJobNo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                           Write(!Model.JobLJobNo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/JobLine/AutoCompleteJobLJobNo/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateJobLJobNo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateJobLJobNo.ToString() != "" && Model.PopulateJobLJobNo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.JobLJobNo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateJobLJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 1955), Tuple.Create("\'", 2030)
, Tuple.Create(Tuple.Create("", 1963), Tuple.Create("IQLabel100612", 1963), true)
, Tuple.Create(Tuple.Create(" ", 1976), Tuple.Create<System.Object, System.Int32>(!Model.JobLLineLetter.LabelVisible ? " hide " : ""
, 1977), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2031), Tuple.Create("\'", 2248)
                                , Tuple.Create(Tuple.Create("", 2040), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLLineLetter.BackHEXColor) ? "" : "color:" + Model.JobLLineLetter.BackHEXColor + ";"
, 2040), false)
, Tuple.Create(Tuple.Create("", 2156), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 2156), true)
);
WriteLiteral(">Line Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLLineLetter\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLLineLetter.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.JobLLineLetter.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLLineLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLLineLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobLLineLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.JobLLineLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2885), Tuple.Create("\'", 2955)
, Tuple.Create(Tuple.Create("", 2893), Tuple.Create("IQLabel100613", 2893), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 2906), Tuple.Create<System.Object, System.Int32>(!Model.JobLOrder.LabelVisible ? " hide " : ""
, 2907), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2956), Tuple.Create("\'", 3163)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2965), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLOrder.BackHEXColor) ? "" : "color:" + Model.JobLOrder.BackHEXColor + ";"
, 2965), false)
, Tuple.Create(Tuple.Create("", 3071), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 3071), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLOrder\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLOrder.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                                Write(!Model.JobLOrder.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobLOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.JobLOrder.ValueFormatted);
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
WriteLiteral(">\r\n\t\t\t\r\n\t\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'if($($(this).attr(\"data-target\")).val() != \"0\") { IQTargetButton(this) " +
"} else { alert(\"No record selected\"); }\'");
WriteLiteral(" data-target=\"*[name=PopulateJobLOrder]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 4587), Tuple.Create("\'", 4656)
, Tuple.Create(Tuple.Create("", 4595), Tuple.Create("IQLabel100614", 4595), true)
, Tuple.Create(Tuple.Create(" ", 4608), Tuple.Create<System.Object, System.Int32>(!Model.JobLCust.LabelVisible ? " hide " : ""
, 4609), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4657), Tuple.Create("\'", 4862)
                          , Tuple.Create(Tuple.Create("", 4666), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLCust.BackHEXColor) ? "" : "color:" + Model.JobLCust.BackHEXColor + ";"
, 4666), false)
, Tuple.Create(Tuple.Create("", 4770), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 4770), true)
);
WriteLiteral(">Customer</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLCust\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLCust.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.JobLCust.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLCust/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobLCust\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.JobLCust.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5454), Tuple.Create("\'", 5527)
, Tuple.Create(Tuple.Create("", 5462), Tuple.Create("IQLabel100615", 5462), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 5475), Tuple.Create<System.Object, System.Int32>(!Model.JobLCollDate.LabelVisible ? " hide " : ""
, 5476), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5528), Tuple.Create("\'", 5742)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 5537), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLCollDate.BackHEXColor) ? "" : "color:" + Model.JobLCollDate.BackHEXColor + ";"
, 5537), false)
, Tuple.Create(Tuple.Create("", 5649), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 5649), true)
);
WriteLiteral(">Collection Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'105\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:105px;top:103px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLCollDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLCollDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                     Write(!Model.JobLCollDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCollDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLCollDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateJobLCollDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.JobLCollDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateJobLCollDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6727), Tuple.Create("\'", 6801)
, Tuple.Create(Tuple.Create("", 6735), Tuple.Create("IQLabel100616", 6735), true)
, Tuple.Create(Tuple.Create(" ", 6748), Tuple.Create<System.Object, System.Int32>(!Model.JobLCollDate2.LabelVisible ? " hide " : ""
, 6749), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6802), Tuple.Create("\'", 7018)
                                   , Tuple.Create(Tuple.Create("", 6811), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLCollDate2.BackHEXColor) ? "" : "color:" + Model.JobLCollDate2.BackHEXColor + ";"
, 6811), false)
, Tuple.Create(Tuple.Create("", 6925), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 6925), true)
);
WriteLiteral(">Collection Date 2</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'105\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:105px;top:128px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLCollDate2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLCollDate2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                      Write(!Model.JobLCollDate2.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCollDate2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLCollDate2/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateJobLCollDate2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.JobLCollDate2.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateJobLCollDate2]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 8013), Tuple.Create("\'", 8086)
, Tuple.Create(Tuple.Create("", 8021), Tuple.Create("IQLabel100631", 8021), true)
, Tuple.Create(Tuple.Create(" ", 8034), Tuple.Create<System.Object, System.Int32>(!Model.JobLDelPoint.LabelVisible ? " hide " : ""
, 8035), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8087), Tuple.Create("\'", 8301)
                                  , Tuple.Create(Tuple.Create("", 8096), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLDelPoint.BackHEXColor) ? "" : "color:" + Model.JobLDelPoint.BackHEXColor + ";"
, 8096), false)
, Tuple.Create(Tuple.Create("", 8208), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:12" +
"0px;top:3px;", 8208), true)
);
WriteLiteral(">Delivery Point</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLDelPoint\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLDelPoint.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                           Write(!Model.JobLDelPoint.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelPoint/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLDelPoint/',$(this));\""));
WriteLiteral("   name=\'PopulateJobLDelPoint\'  style=\'position: absolute; left:440px;height:21px" +
";width:160px;top:3px;\'>\r\n");
             foreach(var itm in Model.JobLDelPoint.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 8934), Tuple.Create("\'", 8955)
, Tuple.Create(Tuple.Create("", 8942), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 8942), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobLDelPoint.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                             Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9091), Tuple.Create("\'", 9163)
, Tuple.Create(Tuple.Create("", 9099), Tuple.Create("IQLabel100632", 9099), true)
, Tuple.Create(Tuple.Create(" ", 9112), Tuple.Create<System.Object, System.Int32>(!Model.JobLDelDate.LabelVisible ? " hide " : ""
, 9113), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9164), Tuple.Create("\'", 9377)
                          , Tuple.Create(Tuple.Create("", 9173), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLDelDate.BackHEXColor) ? "" : "color:" + Model.JobLDelDate.BackHEXColor + ";"
, 9173), false)
, Tuple.Create(Tuple.Create("", 9283), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:12" +
"0px;top:28px;", 9283), true)
);
WriteLiteral(">Delivery Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'105\'");
WriteLiteral(" style=\'position: absolute; left:440px;height:21px;width:105px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLDelDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLDelDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                    Write(!Model.JobLDelDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLDelDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateJobLDelDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.JobLDelDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateJobLDelDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10351), Tuple.Create("\'", 10423)
, Tuple.Create(Tuple.Create("", 10359), Tuple.Create("IQLabel100633", 10359), true)
, Tuple.Create(Tuple.Create(" ", 10372), Tuple.Create<System.Object, System.Int32>(!Model.JobLDelTime.LabelVisible ? " hide " : ""
, 10373), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10424), Tuple.Create("\'", 10637)
                                , Tuple.Create(Tuple.Create("", 10433), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLDelTime.BackHEXColor) ? "" : "color:" + Model.JobLDelTime.BackHEXColor + ";"
, 10433), false)
, Tuple.Create(Tuple.Create("", 10543), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:12" +
"0px;top:53px;", 10543), true)
);
WriteLiteral(">Delivery Time</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLDelTime\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLDelTime.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.JobLDelTime.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelTime/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLDelTime/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobLDelTime\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.JobLDelTime.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:440px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 11254), Tuple.Create("\'", 11325)
, Tuple.Create(Tuple.Create("", 11262), Tuple.Create("IQLabel100634", 11262), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 11275), Tuple.Create<System.Object, System.Int32>(!Model.JobLDelRef.LabelVisible ? " hide " : ""
, 11276), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11326), Tuple.Create("\'", 11537)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 11335), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobLDelRef.BackHEXColor) ? "" : "color:" + Model.JobLDelRef.BackHEXColor + ";"
, 11335), false)
, Tuple.Create(Tuple.Create("", 11443), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:10" +
"0px;top:78px;", 11443), true)
);
WriteLiteral(">Delivery Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportLines_JobLDelRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobLDelRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.JobLDelRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobLine/CallbackJobLDelRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobLDelRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.JobLDelRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:440px;height:21px;width:100px;top:78px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Edit_1.cshtml")]
    public partial class Views_JobLine_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Edit_1_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"JobLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1367)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.JobLJobNoValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1413), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1421), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1478), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1486), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1486), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1799), Tuple.Create("\"", 1900)
, Tuple.Create(Tuple.Create("", 1806), Tuple.Create("/JobLine/ViewHistory/?RecId=", 1806), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1834), false)
, Tuple.Create(Tuple.Create("", 1849), Tuple.Create("&dt=", 1849), true)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1853), false)
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
WriteLiteral(" id=\"TransportLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobLine_TransportLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2695), Tuple.Create("\"", 2710)
, Tuple.Create(Tuple.Create("", 2702), Tuple.Create("#", 2702), true)
, Tuple.Create(Tuple.Create("", 2703), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2703), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2926), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2931), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2931), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Add_1.cshtml")]
    public partial class Views_JobLine_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobLine_TransportLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_List_1.cshtml")]
    public partial class Views_JobLine_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobLine>>
    {
        public Views_JobLine_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobLine/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Line Letter</th><th>Order Number</th><th>Cust" +
"omer</th><th>Collection Date</th><th>Collection Date 2</th><th>Delivery Point</t" +
"h><th>Delivery Date</th><th>Delivery Time</th><th>Delivery Ref</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1049), Tuple.Create("\"", 1090)
, Tuple.Create(Tuple.Create("", 1056), Tuple.Create("/JobLine/Load/?RecId=", 1056), true)
               , Tuple.Create(Tuple.Create("", 1077), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1077), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobLJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLLineLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:4%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1406), Tuple.Create("\"", 1499)
, Tuple.Create(Tuple.Create("", 1417), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLLineLetter/?RecId=", 1417), true)
                                                                          , Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1475), false)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create("\',$(this));", 1488), true)
);
WriteLiteral(" data-bound-name=\'JobLLineLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1564), Tuple.Create("\'", 1611)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1572), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLLineLetter.HTMLValue)
, 1572), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1798), Tuple.Create("\"", 1886)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLOrder/?RecId=", 1809), true)
                                                                     , Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1862), false)
, Tuple.Create(Tuple.Create("", 1875), Tuple.Create("\',$(this));", 1875), true)
);
WriteLiteral(" data-bound-name=\'JobLOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1946), Tuple.Create("\'", 1988)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1954), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLOrder.HTMLValue)
, 1954), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2262)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCust/?RecId=", 2186), true)
                                                                     , Tuple.Create(Tuple.Create("", 2238), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2238), false)
, Tuple.Create(Tuple.Create("", 2251), Tuple.Create("\',$(this));", 2251), true)
);
WriteLiteral(" data-bound-name=\'JobLCust\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2321), Tuple.Create("\'", 2362)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2329), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCust.HTMLValue)
, 2329), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2585), Tuple.Create("\"", 2676)
, Tuple.Create(Tuple.Create("", 2596), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate/?RecId=", 2596), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 2652), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2652), false)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create("\',$(this));", 2665), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2748), Tuple.Create("\'", 2793)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate.HTMLValue)
, 2756), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate2.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3017), Tuple.Create("\"", 3109)
, Tuple.Create(Tuple.Create("", 3028), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate2/?RecId=", 3028), true)
                                                                                                          , Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3085), false)
, Tuple.Create(Tuple.Create("", 3098), Tuple.Create("\',$(this));", 3098), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate2\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3182), Tuple.Create("\'", 3228)
                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 3190), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate2.HTMLValue)
, 3190), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelPoint.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3416), Tuple.Create("\"", 3507)
, Tuple.Create(Tuple.Create("", 3427), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelPoint/?RecId=", 3427), true)
                                                                      , Tuple.Create(Tuple.Create("", 3483), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3483), false)
, Tuple.Create(Tuple.Create("", 3496), Tuple.Create("\',$(this));", 3496), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobLDelPoint\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.JobLDelPoint.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3826), Tuple.Create("\"", 3916)
, Tuple.Create(Tuple.Create("", 3837), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelDate/?RecId=", 3837), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 3892), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3892), false)
, Tuple.Create(Tuple.Create("", 3905), Tuple.Create("\',$(this));", 3905), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLDelDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3987), Tuple.Create("\'", 4031)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3995), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelDate.HTMLValue)
, 3995), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelTime.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4220), Tuple.Create("\"", 4310)
, Tuple.Create(Tuple.Create("", 4231), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelTime/?RecId=", 4231), true)
                                                                       , Tuple.Create(Tuple.Create("", 4286), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4286), false)
, Tuple.Create(Tuple.Create("", 4299), Tuple.Create("\',$(this));", 4299), true)
);
WriteLiteral(" data-bound-name=\'JobLDelTime\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4372), Tuple.Create("\'", 4416)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 4380), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelTime.HTMLValue)
, 4380), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelRef.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4605), Tuple.Create("\"", 4694)
, Tuple.Create(Tuple.Create("", 4616), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelRef/?RecId=", 4616), true)
                                                                       , Tuple.Create(Tuple.Create("", 4670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4670), false)
, Tuple.Create(Tuple.Create("", 4683), Tuple.Create("\',$(this));", 4683), true)
);
WriteLiteral(" data-bound-name=\'JobLDelRef\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4755), Tuple.Create("\'", 4798)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 4763), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelRef.HTMLValue)
, 4763), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Edit_2.cshtml")]
    public partial class Views_JobLine_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Edit_2_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"JobLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1367)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.JobLJobNoValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1413), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1421), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1478), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1486), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1486), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1799), Tuple.Create("\"", 1900)
, Tuple.Create(Tuple.Create("", 1806), Tuple.Create("/JobLine/ViewHistory/?RecId=", 1806), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1834), false)
, Tuple.Create(Tuple.Create("", 1849), Tuple.Create("&dt=", 1849), true)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1853), false)
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
WriteLiteral(" id=\"TransportLines\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobLine_TransportLines.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2695), Tuple.Create("\"", 2710)
, Tuple.Create(Tuple.Create("", 2702), Tuple.Create("#", 2702), true)
, Tuple.Create(Tuple.Create("", 2703), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2703), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2926), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2931), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2931), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Add_2.cshtml")]
    public partial class Views_JobLine_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportLines\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobLine_TransportLines.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_List_2.cshtml")]
    public partial class Views_JobLine_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobLine>>
    {
        public Views_JobLine_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobLine/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Line Letter</th><th>Order Number</th><th>Cust" +
"omer</th><th>Collection Date</th><th>Collection Date 2</th><th>Delivery Point</t" +
"h><th>Delivery Date</th><th>Delivery Time</th><th>Delivery Ref</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1049), Tuple.Create("\"", 1090)
, Tuple.Create(Tuple.Create("", 1056), Tuple.Create("/JobLine/Load/?RecId=", 1056), true)
               , Tuple.Create(Tuple.Create("", 1077), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1077), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobLJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLLineLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:4%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1406), Tuple.Create("\"", 1499)
, Tuple.Create(Tuple.Create("", 1417), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLLineLetter/?RecId=", 1417), true)
                                                                          , Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1475), false)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create("\',$(this));", 1488), true)
);
WriteLiteral(" data-bound-name=\'JobLLineLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1564), Tuple.Create("\'", 1611)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1572), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLLineLetter.HTMLValue)
, 1572), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1798), Tuple.Create("\"", 1886)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLOrder/?RecId=", 1809), true)
                                                                     , Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1862), false)
, Tuple.Create(Tuple.Create("", 1875), Tuple.Create("\',$(this));", 1875), true)
);
WriteLiteral(" data-bound-name=\'JobLOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1946), Tuple.Create("\'", 1988)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1954), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLOrder.HTMLValue)
, 1954), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2262)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCust/?RecId=", 2186), true)
                                                                     , Tuple.Create(Tuple.Create("", 2238), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2238), false)
, Tuple.Create(Tuple.Create("", 2251), Tuple.Create("\',$(this));", 2251), true)
);
WriteLiteral(" data-bound-name=\'JobLCust\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2321), Tuple.Create("\'", 2362)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2329), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCust.HTMLValue)
, 2329), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2585), Tuple.Create("\"", 2676)
, Tuple.Create(Tuple.Create("", 2596), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate/?RecId=", 2596), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 2652), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2652), false)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create("\',$(this));", 2665), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2748), Tuple.Create("\'", 2793)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate.HTMLValue)
, 2756), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate2.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3017), Tuple.Create("\"", 3109)
, Tuple.Create(Tuple.Create("", 3028), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate2/?RecId=", 3028), true)
                                                                                                          , Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3085), false)
, Tuple.Create(Tuple.Create("", 3098), Tuple.Create("\',$(this));", 3098), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate2\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3182), Tuple.Create("\'", 3228)
                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 3190), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate2.HTMLValue)
, 3190), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelPoint.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3416), Tuple.Create("\"", 3507)
, Tuple.Create(Tuple.Create("", 3427), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelPoint/?RecId=", 3427), true)
                                                                      , Tuple.Create(Tuple.Create("", 3483), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3483), false)
, Tuple.Create(Tuple.Create("", 3496), Tuple.Create("\',$(this));", 3496), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobLDelPoint\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.JobLDelPoint.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3826), Tuple.Create("\"", 3916)
, Tuple.Create(Tuple.Create("", 3837), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelDate/?RecId=", 3837), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 3892), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3892), false)
, Tuple.Create(Tuple.Create("", 3905), Tuple.Create("\',$(this));", 3905), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLDelDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3987), Tuple.Create("\'", 4031)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3995), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelDate.HTMLValue)
, 3995), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelTime.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4220), Tuple.Create("\"", 4310)
, Tuple.Create(Tuple.Create("", 4231), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelTime/?RecId=", 4231), true)
                                                                       , Tuple.Create(Tuple.Create("", 4286), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4286), false)
, Tuple.Create(Tuple.Create("", 4299), Tuple.Create("\',$(this));", 4299), true)
);
WriteLiteral(" data-bound-name=\'JobLDelTime\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4372), Tuple.Create("\'", 4416)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 4380), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelTime.HTMLValue)
, 4380), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelRef.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4605), Tuple.Create("\"", 4694)
, Tuple.Create(Tuple.Create("", 4616), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelRef/?RecId=", 4616), true)
                                                                       , Tuple.Create(Tuple.Create("", 4670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4670), false)
, Tuple.Create(Tuple.Create("", 4683), Tuple.Create("\',$(this));", 4683), true)
);
WriteLiteral(" data-bound-name=\'JobLDelRef\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4755), Tuple.Create("\'", 4798)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 4763), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelRef.HTMLValue)
, 4763), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Edit_3.cshtml")]
    public partial class Views_JobLine_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Edit_3_cshtml()
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
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobLin" +
"e/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobLine", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1145), Tuple.Create("\'", 1167)
, Tuple.Create(Tuple.Create("", 1153), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1153), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1213), Tuple.Create("\'", 1237)
, Tuple.Create(Tuple.Create("", 1221), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1221), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"JobLine\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1338), Tuple.Create("\"", 1367)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create<System.Object, System.Int32>(Model.JobLJobNoValue
, 1346), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1413), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1421), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1478), Tuple.Create("\"", 1501)
, Tuple.Create(Tuple.Create("", 1486), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1486), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobLine/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1799), Tuple.Create("\"", 1900)
, Tuple.Create(Tuple.Create("", 1806), Tuple.Create("/JobLine/ViewHistory/?RecId=", 1806), true)
, Tuple.Create(Tuple.Create("", 1834), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1834), false)
, Tuple.Create(Tuple.Create("", 1849), Tuple.Create("&dt=", 1849), true)
, Tuple.Create(Tuple.Create("", 1853), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1853), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2492), Tuple.Create("\"", 2507)
, Tuple.Create(Tuple.Create("", 2499), Tuple.Create("#", 2499), true)
, Tuple.Create(Tuple.Create("", 2500), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2500), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2723), Tuple.Create("\"", 2735)
, Tuple.Create(Tuple.Create("", 2728), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2728), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_Add_3.cshtml")]
    public partial class Views_JobLine_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.JobLine>
    {
        public Views_JobLine_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Lines";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Lines\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobLine/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobLine>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobLine_List_3.cshtml")]
    public partial class Views_JobLine_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobLine>>
    {
        public Views_JobLine_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Lines List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Lines List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Lines</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobLine/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobLine/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Line Letter</th><th>Order Number</th><th>Cust" +
"omer</th><th>Collection Date</th><th>Collection Date 2</th><th>Delivery Point</t" +
"h><th>Delivery Date</th><th>Delivery Time</th><th>Delivery Ref</th>\t\t</tr>\r\n\t</t" +
"head>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1049), Tuple.Create("\"", 1090)
, Tuple.Create(Tuple.Create("", 1056), Tuple.Create("/JobLine/Load/?RecId=", 1056), true)
               , Tuple.Create(Tuple.Create("", 1077), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1077), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobLJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLLineLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:4%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1406), Tuple.Create("\"", 1499)
, Tuple.Create(Tuple.Create("", 1417), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLLineLetter/?RecId=", 1417), true)
                                                                          , Tuple.Create(Tuple.Create("", 1475), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1475), false)
, Tuple.Create(Tuple.Create("", 1488), Tuple.Create("\',$(this));", 1488), true)
);
WriteLiteral(" data-bound-name=\'JobLLineLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1564), Tuple.Create("\'", 1611)
                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1572), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLLineLetter.HTMLValue)
, 1572), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1798), Tuple.Create("\"", 1886)
, Tuple.Create(Tuple.Create("", 1809), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLOrder/?RecId=", 1809), true)
                                                                     , Tuple.Create(Tuple.Create("", 1862), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1862), false)
, Tuple.Create(Tuple.Create("", 1875), Tuple.Create("\',$(this));", 1875), true)
);
WriteLiteral(" data-bound-name=\'JobLOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1946), Tuple.Create("\'", 1988)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1954), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLOrder.HTMLValue)
, 1954), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2175), Tuple.Create("\"", 2262)
, Tuple.Create(Tuple.Create("", 2186), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCust/?RecId=", 2186), true)
                                                                     , Tuple.Create(Tuple.Create("", 2238), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2238), false)
, Tuple.Create(Tuple.Create("", 2251), Tuple.Create("\',$(this));", 2251), true)
);
WriteLiteral(" data-bound-name=\'JobLCust\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2321), Tuple.Create("\'", 2362)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2329), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCust.HTMLValue)
, 2329), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2585), Tuple.Create("\"", 2676)
, Tuple.Create(Tuple.Create("", 2596), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate/?RecId=", 2596), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 2652), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2652), false)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create("\',$(this));", 2665), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2748), Tuple.Create("\'", 2793)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2756), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate.HTMLValue)
, 2756), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLCollDate2.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3017), Tuple.Create("\"", 3109)
, Tuple.Create(Tuple.Create("", 3028), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLCollDate2/?RecId=", 3028), true)
                                                                                                          , Tuple.Create(Tuple.Create("", 3085), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3085), false)
, Tuple.Create(Tuple.Create("", 3098), Tuple.Create("\',$(this));", 3098), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLCollDate2\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3182), Tuple.Create("\'", 3228)
                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 3190), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLCollDate2.HTMLValue)
, 3190), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelPoint.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:9%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3416), Tuple.Create("\"", 3507)
, Tuple.Create(Tuple.Create("", 3427), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelPoint/?RecId=", 3427), true)
                                                                      , Tuple.Create(Tuple.Create("", 3483), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3483), false)
, Tuple.Create(Tuple.Create("", 3496), Tuple.Create("\',$(this));", 3496), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobLDelPoint\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.JobLDelPoint.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3826), Tuple.Create("\"", 3916)
, Tuple.Create(Tuple.Create("", 3837), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelDate/?RecId=", 3837), true)
                                                                                                        , Tuple.Create(Tuple.Create("", 3892), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3892), false)
, Tuple.Create(Tuple.Create("", 3905), Tuple.Create("\',$(this));", 3905), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobLDelDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3987), Tuple.Create("\'", 4031)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3995), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelDate.HTMLValue)
, 3995), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelTime.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:7%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4220), Tuple.Create("\"", 4310)
, Tuple.Create(Tuple.Create("", 4231), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelTime/?RecId=", 4231), true)
                                                                       , Tuple.Create(Tuple.Create("", 4286), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4286), false)
, Tuple.Create(Tuple.Create("", 4299), Tuple.Create("\',$(this));", 4299), true)
);
WriteLiteral(" data-bound-name=\'JobLDelTime\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4372), Tuple.Create("\'", 4416)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 4380), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelTime.HTMLValue)
, 4380), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobLDelRef.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4605), Tuple.Create("\"", 4694)
, Tuple.Create(Tuple.Create("", 4616), Tuple.Create("javascript:IQAutoSave(\'/JobLine/SaveJobLDelRef/?RecId=", 4616), true)
                                                                       , Tuple.Create(Tuple.Create("", 4670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4670), false)
, Tuple.Create(Tuple.Create("", 4683), Tuple.Create("\',$(this));", 4683), true)
);
WriteLiteral(" data-bound-name=\'JobLDelRef\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 4755), Tuple.Create("\'", 4798)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 4763), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobLDelRef.HTMLValue)
, 4763), false)
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
