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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_TransportDetails.cshtml")]
    public partial class Views_Job_TransportDetails_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_TransportDetails_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 59), Tuple.Create("\'", 125)
, Tuple.Create(Tuple.Create("", 67), Tuple.Create("IQLabel100511", 67), true)
, Tuple.Create(Tuple.Create(" ", 80), Tuple.Create<System.Object, System.Int32>(!Model.JobNo.LabelVisible ? " hide " : ""
, 81), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 126), Tuple.Create("\'", 325)
    , Tuple.Create(Tuple.Create("", 135), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobNo.BackHEXColor) ? "" : "color:" + Model.JobNo.BackHEXColor + ";"
, 135), false)
, Tuple.Create(Tuple.Create("", 233), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 233), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                            Write(!Model.JobNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.JobNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 901), Tuple.Create("\'", 971)
, Tuple.Create(Tuple.Create("", 909), Tuple.Create("IQLabel100513", 909), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 922), Tuple.Create<System.Object, System.Int32>(!Model.JobTransp.LabelVisible ? " hide " : ""
, 923), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 972), Tuple.Create("\'", 1179)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 981), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobTransp.BackHEXColor) ? "" : "color:" + Model.JobTransp.BackHEXColor + ";"
, 981), false)
, Tuple.Create(Tuple.Create("", 1087), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 1087), true)
);
WriteLiteral(">Transporter</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:200px;top:78px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'TransportDetails_JobTransp\'");
                                             Write(Model.RecordLocked || !Model.JobTransp.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobTransp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobTransp/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                Write(!Model.JobTransp.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Job/AutoCompleteJobTransp/");
                                            Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateJobTransp\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateJobTransp.ToString() != "" && Model.PopulateJobTransp.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.JobTransp.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateJobTransp]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 2863), Tuple.Create("\'", 2937)
, Tuple.Create(Tuple.Create("", 2871), Tuple.Create("IQLabel100514", 2871), true)
, Tuple.Create(Tuple.Create(" ", 2884), Tuple.Create<System.Object, System.Int32>(!Model.JobTranspRate.LabelVisible ? " hide " : ""
, 2885), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2938), Tuple.Create("\'", 3154)
                               , Tuple.Create(Tuple.Create("", 2947), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobTranspRate.BackHEXColor) ? "" : "color:" + Model.JobTranspRate.BackHEXColor + ";"
, 2947), false)
, Tuple.Create(Tuple.Create("", 3061), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3061), true)
);
WriteLiteral(">Transporter Rate</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobTranspRate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobTranspRate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.JobTranspRate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobTranspRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobTranspRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobTranspRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.JobTranspRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 3784), Tuple.Create("\'", 3857)
, Tuple.Create(Tuple.Create("", 3792), Tuple.Create("IQLabel100515", 3792), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 3805), Tuple.Create<System.Object, System.Int32>(!Model.JobCreatedBy.LabelVisible ? " hide " : ""
, 3806), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3858), Tuple.Create("\'", 4072)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3867), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCreatedBy.BackHEXColor) ? "" : "color:" + Model.JobCreatedBy.BackHEXColor + ";"
, 3867), false)
, Tuple.Create(Tuple.Create("", 3979), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 3979), true)
);
WriteLiteral(">Created By</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:120px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobCreatedBy\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 4297), Tuple.Create("\'", 4367)
, Tuple.Create(Tuple.Create("", 4305), Tuple.Create("form-control", 4305), true)
, Tuple.Create(Tuple.Create("    ", 4317), Tuple.Create<System.Object, System.Int32>(!Model.JobCreatedBy.Visible ? " hide " : ""
, 4321), false)
);
WriteLiteral("  ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobCreatedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobCreatedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateJobCreatedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.JobCreatedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4705), Tuple.Create("\'", 4726)
, Tuple.Create(Tuple.Create("", 4713), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4713), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobCreatedBy.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateJobCreatedBy]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 5606), Tuple.Create("\'", 5672)
, Tuple.Create(Tuple.Create("", 5614), Tuple.Create("IQLabel100516", 5614), true)
, Tuple.Create(Tuple.Create(" ", 5627), Tuple.Create<System.Object, System.Int32>(!Model.JobId.LabelVisible ? " hide " : ""
, 5628), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5673), Tuple.Create("\'", 5871)
                       , Tuple.Create(Tuple.Create("", 5682), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobId.BackHEXColor) ? "" : "color:" + Model.JobId.BackHEXColor + ";"
, 5682), false)
, Tuple.Create(Tuple.Create("", 5780), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 5780), true)
);
WriteLiteral(">Job Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 5960), Tuple.Create("\'", 6022)
, Tuple.Create(Tuple.Create("", 5968), Tuple.Create("form-control", 5968), true)
, Tuple.Create(Tuple.Create("   ", 5980), Tuple.Create<System.Object, System.Int32>(!Model.JobId.Visible ? " hide " : ""
, 5983), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobId\' value=\'");
                                                                                                                                                                                                                                                                                                                                          Write(Model.JobId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6377), Tuple.Create("\'", 6450)
, Tuple.Create(Tuple.Create("", 6385), Tuple.Create("IQLabel100531", 6385), true)
                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 6398), Tuple.Create<System.Object, System.Int32>(!Model.JobRouteFrom.LabelVisible ? " hide " : ""
, 6399), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6451), Tuple.Create("\'", 6665)
                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 6460), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobRouteFrom.BackHEXColor) ? "" : "color:" + Model.JobRouteFrom.BackHEXColor + ";"
, 6460), false)
, Tuple.Create(Tuple.Create("", 6572), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:345px;height:21px;width:12" +
"0px;top:3px;", 6572), true)
);
WriteLiteral(">Route From</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:470px;height:21px;width:140px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobRouteFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobRouteFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                           Write(!Model.JobRouteFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobRouteFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobRouteFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateJobRouteFrom\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.JobRouteFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 7358), Tuple.Create("\'", 7379)
, Tuple.Create(Tuple.Create("", 7366), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 7366), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobRouteFrom.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateJobRouteFrom]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 8275), Tuple.Create("\'", 8346)
, Tuple.Create(Tuple.Create("", 8283), Tuple.Create("IQLabel100532", 8283), true)
, Tuple.Create(Tuple.Create(" ", 8296), Tuple.Create<System.Object, System.Int32>(!Model.JobRouteTo.LabelVisible ? " hide " : ""
, 8297), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8347), Tuple.Create("\'", 8558)
                            , Tuple.Create(Tuple.Create("", 8356), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobRouteTo.BackHEXColor) ? "" : "color:" + Model.JobRouteTo.BackHEXColor + ";"
, 8356), false)
, Tuple.Create(Tuple.Create("", 8464), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:345px;height:21px;width:12" +
"0px;top:28px;", 8464), true)
);
WriteLiteral(">Route To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'140\'");
WriteLiteral(" style=\'position: absolute; left:470px;height:21px;width:140px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobRouteTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobRouteTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.JobRouteTo.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobRouteTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobRouteTo/',$(this));\""));
WriteLiteral("   name=\'PopulateJobRouteTo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.JobRouteTo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 9236), Tuple.Create("\'", 9257)
, Tuple.Create(Tuple.Create("", 9244), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 9244), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobRouteTo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateJobRouteTo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 10149), Tuple.Create("\'", 10218)
, Tuple.Create(Tuple.Create("", 10157), Tuple.Create("IQLabel100533", 10157), true)
, Tuple.Create(Tuple.Create(" ", 10170), Tuple.Create<System.Object, System.Int32>(!Model.JobVehNo.LabelVisible ? " hide " : ""
, 10171), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10219), Tuple.Create("\'", 10426)
                         , Tuple.Create(Tuple.Create("", 10228), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobVehNo.BackHEXColor) ? "" : "color:" + Model.JobVehNo.BackHEXColor + ";"
, 10228), false)
, Tuple.Create(Tuple.Create("", 10332), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:345px;height:21px;width:12" +
"0px;top:53px;", 10332), true)
);
WriteLiteral(">Vehicle Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobVehNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobVehNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.JobVehNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobVehNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobVehNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobVehNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.JobVehNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:470px;height:21px;width:140px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 11018), Tuple.Create("\'", 11091)
, Tuple.Create(Tuple.Create("", 11026), Tuple.Create("IQLabel100534", 11026), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 11039), Tuple.Create<System.Object, System.Int32>(!Model.JobTrailerNo.LabelVisible ? " hide " : ""
, 11040), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11092), Tuple.Create("\'", 11307)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 11101), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobTrailerNo.BackHEXColor) ? "" : "color:" + Model.JobTrailerNo.BackHEXColor + ";"
, 11101), false)
, Tuple.Create(Tuple.Create("", 11213), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:345px;height:21px;width:12" +
"0px;top:78px;", 11213), true)
);
WriteLiteral(">Trailer Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobTrailerNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobTrailerNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.JobTrailerNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobTrailerNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobTrailerNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobTrailerNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.JobTrailerNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:470px;height:21px;width:140px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 11927), Tuple.Create("\'", 12000)
, Tuple.Create(Tuple.Create("", 11935), Tuple.Create("IQLabel100571", 11935), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 11948), Tuple.Create<System.Object, System.Int32>(!Model.JobFerryName.LabelVisible ? " hide " : ""
, 11949), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12001), Tuple.Create("\'", 12215)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 12010), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobFerryName.BackHEXColor) ? "" : "color:" + Model.JobFerryName.BackHEXColor + ";"
, 12010), false)
, Tuple.Create(Tuple.Create("", 12122), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:12" +
"0px;top:3px;", 12122), true)
);
WriteLiteral(">Ferry Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobFerryName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobFerryName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.JobFerryName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobFerryName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobFerryName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.JobFerryName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:760px;height:21px;width:120px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 12830), Tuple.Create("\'", 12903)
, Tuple.Create(Tuple.Create("", 12838), Tuple.Create("IQLabel100572", 12838), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 12851), Tuple.Create<System.Object, System.Int32>(!Model.JobFerryDate.LabelVisible ? " hide " : ""
, 12852), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12904), Tuple.Create("\'", 13119)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 12913), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobFerryDate.BackHEXColor) ? "" : "color:" + Model.JobFerryDate.BackHEXColor + ";"
, 12913), false)
, Tuple.Create(Tuple.Create("", 13025), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:12" +
"0px;top:28px;", 13025), true)
);
WriteLiteral(">Ferry Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:760px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobFerryDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobFerryDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                     Write(!Model.JobFerryDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobFerryDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateJobFerryDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.JobFerryDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateJobFerryDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 14090), Tuple.Create("\'", 14163)
, Tuple.Create(Tuple.Create("", 14098), Tuple.Create("IQLabel100573", 14098), true)
, Tuple.Create(Tuple.Create(" ", 14111), Tuple.Create<System.Object, System.Int32>(!Model.JobFerryTime.LabelVisible ? " hide " : ""
, 14112), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14164), Tuple.Create("\'", 14379)
                                 , Tuple.Create(Tuple.Create("", 14173), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobFerryTime.BackHEXColor) ? "" : "color:" + Model.JobFerryTime.BackHEXColor + ";"
, 14173), false)
, Tuple.Create(Tuple.Create("", 14285), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:12" +
"0px;top:53px;", 14285), true)
);
WriteLiteral(">Ferry Time</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobFerryTime\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobFerryTime.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.JobFerryTime.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryTime/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobFerryTime/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobFerryTime\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.JobFerryTime.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:760px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 14994), Tuple.Create("\'", 15066)
, Tuple.Create(Tuple.Create("", 15002), Tuple.Create("IQLabel100574", 15002), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 15015), Tuple.Create<System.Object, System.Int32>(!Model.JobAccMonth.LabelVisible ? " hide " : ""
, 15016), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15067), Tuple.Create("\'", 15280)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 15076), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobAccMonth.BackHEXColor) ? "" : "color:" + Model.JobAccMonth.BackHEXColor + ";"
, 15076), false)
, Tuple.Create(Tuple.Create("", 15186), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:12" +
"0px;top:78px;", 15186), true)
);
WriteLiteral(">Accounting Month</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobAccMonth\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobAccMonth.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                   Write(!Model.JobAccMonth.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobAccMonth/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobAccMonth/',$(this));\""));
WriteLiteral("   name=\'PopulateJobAccMonth\'  style=\'position: absolute; left:760px;height:21px;" +
"width:120px;top:78px;\'>\r\n");
             foreach(var itm in Model.JobAccMonth.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 15912), Tuple.Create("\'", 15933)
, Tuple.Create(Tuple.Create("", 15920), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 15920), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobAccMonth.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                            Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 16068), Tuple.Create("\'", 16139)
, Tuple.Create(Tuple.Create("", 16076), Tuple.Create("IQLabel100575", 16076), true)
, Tuple.Create(Tuple.Create(" ", 16089), Tuple.Create<System.Object, System.Int32>(!Model.JobChecked.LabelVisible ? " hide " : ""
, 16090), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16140), Tuple.Create("\'", 16352)
                        , Tuple.Create(Tuple.Create("", 16149), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobChecked.BackHEXColor) ? "" : "color:" + Model.JobChecked.BackHEXColor + ";"
, 16149), false)
, Tuple.Create(Tuple.Create("", 16257), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:635px;height:21px;width:12" +
"0px;top:103px;", 16257), true)
);
WriteLiteral(">Checked</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportDetails_JobChecked\'");
WriteAttribute("class", Tuple.Create(" class=\'", 16432), Tuple.Create("\'", 16486)
, Tuple.Create(Tuple.Create("  ", 16440), Tuple.Create<System.Object, System.Int32>(!Model.JobChecked.Visible ? " hide " : ""
, 16442), false)
);
WriteLiteral(" ");
                                                                                                                Write(Model.RecordLocked || !Model.JobChecked.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Job/SaveJobChecked/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Job/CallbackJobChecked/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:760px;height:16px;width:16px;top:103px;\' name=\'" +
"PopulateJobChecked\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.PopulateJobChecked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateJobChecked\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                 Write(!Model.PopulateJobChecked ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Edit_1.cshtml")]
    public partial class Views_Job_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Job/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Jobs</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Job/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Job", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1192), Tuple.Create("\'", 1214)
, Tuple.Create(Tuple.Create("", 1200), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1200), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1260), Tuple.Create("\'", 1284)
, Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1268), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Job\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1381), Tuple.Create("\"", 1406)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1452), Tuple.Create("\"", 1475)
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1460), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1517), Tuple.Create("\"", 1540)
, Tuple.Create(Tuple.Create("", 1525), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1525), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Job/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1834), Tuple.Create("\"", 1931)
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create("/Job/ViewHistory/?RecId=", 1841), true)
, Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1865), false)
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create("&dt=", 1880), true)
, Tuple.Create(Tuple.Create("", 1884), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1884), false)
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
WriteLiteral(" id=\"TransportDetails\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Job_TransportDetails.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Job Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2710), Tuple.Create("\'", 2812)
, Tuple.Create(Tuple.Create("", 2718), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobLine" ? "active" :  "") : "" )
, 2718), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#JobLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Job Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Job Costs").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2997), Tuple.Create("\'", 3099)
, Tuple.Create(Tuple.Create("", 3005), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobCost" ? "active" :  "") : "" )
, 3005), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#JobCost\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Job Costs</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3299), Tuple.Create("\'", 3402)
, Tuple.Create(Tuple.Create("", 3307), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3307), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CertShip\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Certificates of Shipment</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3606), Tuple.Create("\'", 3703)
, Tuple.Create(Tuple.Create("", 3614), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3614), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CN\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Credit Notes</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3885), Tuple.Create("\'", 3983)
, Tuple.Create(Tuple.Create("", 3893), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 3893), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4160), Tuple.Create("\'", 4261)
, Tuple.Create(Tuple.Create("", 4168), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "") : "" )
, 4168), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Orders\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Header").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4450), Tuple.Create("\'", 4554)
, Tuple.Create(Tuple.Create("", 4458), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrder" ? "active" :  "") : "" )
, 4458), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSOrder\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS Order Header</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 4765), Tuple.Create("\"", 4780)
, Tuple.Create(Tuple.Create("", 4772), Tuple.Create("#", 4772), true)
, Tuple.Create(Tuple.Create("", 4773), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4773), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Job Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "JobLine" ? "data-loadTarget='#d0b4043e8d4145d8b08a9c2c1950fb27' data-dynamicContent='/JobLine/ListFromQuery?Limit=50&Ord=JobLLineLetter&Clause=JobLJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"JobLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/JobLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "JobLine") {
                      Html.RenderPartial("~/Views/JobLine_List_1.cshtml", Model.JobLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"d0b4043e8d4145d8b08a9c2c1950fb27\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Job Costs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "JobCost" ? "data-loadTarget='#080343ea51b8484388b36d0b069d4e9e' data-dynamicContent='/JobCost/ListFromQuery?Limit=50&Ord=JobCInvNo&Clause=JobCJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                      Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobCost" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"JobCost\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/JobCost/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Costs</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "JobCost") {
                      Html.RenderPartial("~/Views/JobCost_List_1.cshtml", Model.JobCosts);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"080343ea51b8484388b36d0b069d4e9e\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#ea2c81c357de4480975fefd616f72b1f' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7447), Tuple.Create("\'", 7494)
, Tuple.Create(Tuple.Create("", 7455), Tuple.Create("/CertShip/Add?CSJobNo=", 7455), true)
        , Tuple.Create(Tuple.Create("", 7477), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 7477), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_1.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"ea2c81c357de4480975fefd616f72b1f\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#cea267de17bb46daa0c6158a1936cb1b' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                     Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8407), Tuple.Create("\'", 8448)
, Tuple.Create(Tuple.Create("", 8415), Tuple.Create("/CN/Add?CNJobNo=", 8415), true)
  , Tuple.Create(Tuple.Create("", 8431), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 8431), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_1.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"cea267de17bb46daa0c6158a1936cb1b\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#ff927af269df4c0aa3c6fefb4df3bb2f' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 9333), Tuple.Create("\'", 9376)
, Tuple.Create(Tuple.Create("", 9341), Tuple.Create("/Inv/Add?InvJobNo=", 9341), true)
    , Tuple.Create(Tuple.Create("", 9359), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 9359), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_1.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"ff927af269df4c0aa3c6fefb4df3bb2f\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#f70cde284d8f4aa2a08fe297adb449fe' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Orders\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 10270), Tuple.Create("\'", 10316)
, Tuple.Create(Tuple.Create("", 10278), Tuple.Create("/Orders/Add?OrdJobNo=", 10278), true)
      , Tuple.Create(Tuple.Create("", 10299), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 10299), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Orders") {
                      Html.RenderPartial("~/Views/Orders_List_1.cshtml", Model.Orderss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"f70cde284d8f4aa2a08fe297adb449fe\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Header").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSOrder" ? "data-loadTarget='#8c8d24f6498e41489d31e9cdf061c773' data-dynamicContent='/REDSOrder/ListFromQuery?Limit=50&Ord=RDOrdId&Clause=RDOrdJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrder" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSOrder\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 11244), Tuple.Create("\'", 11295)
, Tuple.Create(Tuple.Create("", 11252), Tuple.Create("/REDSOrder/Add?RDOrdJobNo=", 11252), true)
           , Tuple.Create(Tuple.Create("", 11278), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 11278), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add REDS Order Header</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSOrder") {
                      Html.RenderPartial("~/Views/REDSOrder_List_1.cshtml", Model.REDSOrders);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"8c8d24f6498e41489d31e9cdf061c773\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 11758), Tuple.Create("\"", 11770)
, Tuple.Create(Tuple.Create("", 11763), Tuple.Create<System.Object, System.Int32>(itm.Id
, 11763), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Add_1.cshtml")]
    public partial class Views_Job_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Jobs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Jobs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Job/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportDetails\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Job_TransportDetails.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_List_1.cshtml")]
    public partial class Views_Job_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Job>>
    {
        public Views_Job_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Jobs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Jobs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Jobs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 474), Tuple.Create("\"", 540)
, Tuple.Create(Tuple.Create("", 481), Tuple.Create("/Job/ListFromQuery/?Clause=", 481), true)
                                                               , Tuple.Create(Tuple.Create("", 508), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 508), false)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("&Ord=", 523), true)
                                                                                   , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 528), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Transporter</th><th>Vehicle Number</th><th>Tr" +
"ailer Number</th><th>Route From</th><th>Route To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 924), Tuple.Create("\"", 961)
, Tuple.Create(Tuple.Create("", 931), Tuple.Create("/Job/Load/?RecId=", 931), true)
            , Tuple.Create(Tuple.Create("", 948), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 948), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1209), Tuple.Create("\"", 1289)
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobNo/?RecId=", 1220), true)
                                                              , Tuple.Create(Tuple.Create("", 1265), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1265), false)
, Tuple.Create(Tuple.Create("", 1278), Tuple.Create("\',$(this));", 1278), true)
);
WriteLiteral(" data-bound-name=\'JobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1383)
                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobNo.HTMLValue)
, 1353), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Job/AutoCompleteJobTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1614), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1625), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTransp/?RecId=", 1625), true)
                                                                                                             , Tuple.Create(Tuple.Create("", 1674), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1674), false)
, Tuple.Create(Tuple.Create("", 1687), Tuple.Create("\',$(this));", 1687), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.JobTransp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobVehNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1995), Tuple.Create("\"", 2078)
, Tuple.Create(Tuple.Create("", 2006), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobVehNo/?RecId=", 2006), true)
                                                                 , Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2067), Tuple.Create("\',$(this));", 2067), true)
);
WriteLiteral(" data-bound-name=\'JobVehNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2137), Tuple.Create("\'", 2178)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2145), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobVehNo.HTMLValue)
, 2145), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTrailerNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2369), Tuple.Create("\"", 2456)
, Tuple.Create(Tuple.Create("", 2380), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTrailerNo/?RecId=", 2380), true)
                                                                     , Tuple.Create(Tuple.Create("", 2432), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2432), false)
, Tuple.Create(Tuple.Create("", 2445), Tuple.Create("\',$(this));", 2445), true)
);
WriteLiteral(" data-bound-name=\'JobTrailerNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2519), Tuple.Create("\'", 2564)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2527), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobTrailerNo.HTMLValue)
, 2527), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2753), Tuple.Create("\"", 2840)
, Tuple.Create(Tuple.Create("", 2764), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteFrom/?RecId=", 2764), true)
                                                                   , Tuple.Create(Tuple.Create("", 2816), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2816), false)
, Tuple.Create(Tuple.Create("", 2829), Tuple.Create("\',$(this));", 2829), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteFrom\'");
WriteLiteral("  >");
                                                                                                                                                                                                                             Write(Html.Raw(itm.JobRouteFrom.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3124), Tuple.Create("\"", 3209)
, Tuple.Create(Tuple.Create("", 3135), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteTo/?RecId=", 3135), true)
                                                                 , Tuple.Create(Tuple.Create("", 3185), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3185), false)
, Tuple.Create(Tuple.Create("", 3198), Tuple.Create("\',$(this));", 3198), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteTo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                         Write(Html.Raw(itm.JobRouteTo.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Edit_2.cshtml")]
    public partial class Views_Job_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Job/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Jobs</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Job/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Job", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1192), Tuple.Create("\'", 1214)
, Tuple.Create(Tuple.Create("", 1200), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1200), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1260), Tuple.Create("\'", 1284)
, Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1268), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Job\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1381), Tuple.Create("\"", 1406)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1452), Tuple.Create("\"", 1475)
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1460), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1517), Tuple.Create("\"", 1540)
, Tuple.Create(Tuple.Create("", 1525), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1525), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Job/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1834), Tuple.Create("\"", 1931)
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create("/Job/ViewHistory/?RecId=", 1841), true)
, Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1865), false)
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create("&dt=", 1880), true)
, Tuple.Create(Tuple.Create("", 1884), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1884), false)
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
WriteLiteral(" id=\"TransportDetails\"");
WriteLiteral(" style=\'position:relative;height:179px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Job_TransportDetails.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Job Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2710), Tuple.Create("\'", 2812)
, Tuple.Create(Tuple.Create("", 2718), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobLine" ? "active" :  "") : "" )
, 2718), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#JobLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Job Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Job Costs").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2997), Tuple.Create("\'", 3099)
, Tuple.Create(Tuple.Create("", 3005), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobCost" ? "active" :  "") : "" )
, 3005), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#JobCost\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Job Costs</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3299), Tuple.Create("\'", 3402)
, Tuple.Create(Tuple.Create("", 3307), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3307), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CertShip\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Certificates of Shipment</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3606), Tuple.Create("\'", 3703)
, Tuple.Create(Tuple.Create("", 3614), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3614), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#CN\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Credit Notes</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3885), Tuple.Create("\'", 3983)
, Tuple.Create(Tuple.Create("", 3893), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 3893), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4160), Tuple.Create("\'", 4261)
, Tuple.Create(Tuple.Create("", 4168), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "") : "" )
, 4168), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Orders\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Header").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4450), Tuple.Create("\'", 4554)
, Tuple.Create(Tuple.Create("", 4458), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrder" ? "active" :  "") : "" )
, 4458), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSOrder\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS Order Header</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 4765), Tuple.Create("\"", 4780)
, Tuple.Create(Tuple.Create("", 4772), Tuple.Create("#", 4772), true)
, Tuple.Create(Tuple.Create("", 4773), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4773), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Job Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "JobLine" ? "data-loadTarget='#11bbd626be334135924a8976fb845728' data-dynamicContent='/JobLine/ListFromQuery?Limit=50&Ord=JobLLineLetter&Clause=JobLJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"JobLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/JobLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "JobLine") {
                      Html.RenderPartial("~/Views/JobLine_List_2.cshtml", Model.JobLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"11bbd626be334135924a8976fb845728\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Job Costs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "JobCost" ? "data-loadTarget='#0cf8f5a4ea484313a38bca7e1d64d411' data-dynamicContent='/JobCost/ListFromQuery?Limit=50&Ord=JobCInvNo&Clause=JobCJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                      Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "JobCost" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"JobCost\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/JobCost/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Costs</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "JobCost") {
                      Html.RenderPartial("~/Views/JobCost_List_2.cshtml", Model.JobCosts);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"0cf8f5a4ea484313a38bca7e1d64d411\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#fb2a7a38de1e42a6964bf62afc4c9ba0' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7447), Tuple.Create("\'", 7494)
, Tuple.Create(Tuple.Create("", 7455), Tuple.Create("/CertShip/Add?CSJobNo=", 7455), true)
        , Tuple.Create(Tuple.Create("", 7477), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 7477), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_2.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"fb2a7a38de1e42a6964bf62afc4c9ba0\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#88b3948a5134425cafc52f4e71cde173' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                     Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8407), Tuple.Create("\'", 8448)
, Tuple.Create(Tuple.Create("", 8415), Tuple.Create("/CN/Add?CNJobNo=", 8415), true)
  , Tuple.Create(Tuple.Create("", 8431), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 8431), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_2.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"88b3948a5134425cafc52f4e71cde173\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#50067ce0e23c4e3691907d5717232122' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 9333), Tuple.Create("\'", 9376)
, Tuple.Create(Tuple.Create("", 9341), Tuple.Create("/Inv/Add?InvJobNo=", 9341), true)
    , Tuple.Create(Tuple.Create("", 9359), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 9359), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_2.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"50067ce0e23c4e3691907d5717232122\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#47d12008e43a4878b1546ac6229ea6c7' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Orders\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 10270), Tuple.Create("\'", 10316)
, Tuple.Create(Tuple.Create("", 10278), Tuple.Create("/Orders/Add?OrdJobNo=", 10278), true)
      , Tuple.Create(Tuple.Create("", 10299), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 10299), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Orders") {
                      Html.RenderPartial("~/Views/Orders_List_2.cshtml", Model.Orderss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"47d12008e43a4878b1546ac6229ea6c7\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Header").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSOrder" ? "data-loadTarget='#e0c5650f2453485d8f6ef10c6ba92c53' data-dynamicContent='/REDSOrder/ListFromQuery?Limit=50&Ord=RDOrdId&Clause=RDOrdJobNo=" + Model.JobIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrder" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSOrder\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 11244), Tuple.Create("\'", 11295)
, Tuple.Create(Tuple.Create("", 11252), Tuple.Create("/REDSOrder/Add?RDOrdJobNo=", 11252), true)
           , Tuple.Create(Tuple.Create("", 11278), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 11278), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add REDS Order Header</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSOrder") {
                      Html.RenderPartial("~/Views/REDSOrder_List_2.cshtml", Model.REDSOrders);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"e0c5650f2453485d8f6ef10c6ba92c53\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 11758), Tuple.Create("\"", 11770)
, Tuple.Create(Tuple.Create("", 11763), Tuple.Create<System.Object, System.Int32>(itm.Id
, 11763), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Add_2.cshtml")]
    public partial class Views_Job_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Jobs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Jobs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Job/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportDetails\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Job_TransportDetails.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_List_2.cshtml")]
    public partial class Views_Job_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Job>>
    {
        public Views_Job_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Jobs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Jobs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Jobs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 474), Tuple.Create("\"", 540)
, Tuple.Create(Tuple.Create("", 481), Tuple.Create("/Job/ListFromQuery/?Clause=", 481), true)
                                                               , Tuple.Create(Tuple.Create("", 508), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 508), false)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("&Ord=", 523), true)
                                                                                   , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 528), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Transporter</th><th>Vehicle Number</th><th>Tr" +
"ailer Number</th><th>Route From</th><th>Route To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 924), Tuple.Create("\"", 961)
, Tuple.Create(Tuple.Create("", 931), Tuple.Create("/Job/Load/?RecId=", 931), true)
            , Tuple.Create(Tuple.Create("", 948), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 948), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1209), Tuple.Create("\"", 1289)
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobNo/?RecId=", 1220), true)
                                                              , Tuple.Create(Tuple.Create("", 1265), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1265), false)
, Tuple.Create(Tuple.Create("", 1278), Tuple.Create("\',$(this));", 1278), true)
);
WriteLiteral(" data-bound-name=\'JobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1383)
                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobNo.HTMLValue)
, 1353), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Job/AutoCompleteJobTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1614), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1625), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTransp/?RecId=", 1625), true)
                                                                                                             , Tuple.Create(Tuple.Create("", 1674), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1674), false)
, Tuple.Create(Tuple.Create("", 1687), Tuple.Create("\',$(this));", 1687), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.JobTransp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobVehNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1995), Tuple.Create("\"", 2078)
, Tuple.Create(Tuple.Create("", 2006), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobVehNo/?RecId=", 2006), true)
                                                                 , Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2067), Tuple.Create("\',$(this));", 2067), true)
);
WriteLiteral(" data-bound-name=\'JobVehNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2137), Tuple.Create("\'", 2178)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2145), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobVehNo.HTMLValue)
, 2145), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTrailerNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2369), Tuple.Create("\"", 2456)
, Tuple.Create(Tuple.Create("", 2380), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTrailerNo/?RecId=", 2380), true)
                                                                     , Tuple.Create(Tuple.Create("", 2432), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2432), false)
, Tuple.Create(Tuple.Create("", 2445), Tuple.Create("\',$(this));", 2445), true)
);
WriteLiteral(" data-bound-name=\'JobTrailerNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2519), Tuple.Create("\'", 2564)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2527), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobTrailerNo.HTMLValue)
, 2527), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2753), Tuple.Create("\"", 2840)
, Tuple.Create(Tuple.Create("", 2764), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteFrom/?RecId=", 2764), true)
                                                                   , Tuple.Create(Tuple.Create("", 2816), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2816), false)
, Tuple.Create(Tuple.Create("", 2829), Tuple.Create("\',$(this));", 2829), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteFrom\'");
WriteLiteral("  >");
                                                                                                                                                                                                                             Write(Html.Raw(itm.JobRouteFrom.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3124), Tuple.Create("\"", 3209)
, Tuple.Create(Tuple.Create("", 3135), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteTo/?RecId=", 3135), true)
                                                                 , Tuple.Create(Tuple.Create("", 3185), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3185), false)
, Tuple.Create(Tuple.Create("", 3198), Tuple.Create("\',$(this));", 3198), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteTo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                         Write(Html.Raw(itm.JobRouteTo.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Edit_3.cshtml")]
    public partial class Views_Job_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Job/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Jobs</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Job/Vi" +
"ewHistory/?RecId=");
                                                                                                Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Job", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1192), Tuple.Create("\'", 1214)
, Tuple.Create(Tuple.Create("", 1200), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1200), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1260), Tuple.Create("\'", 1284)
, Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1268), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Job\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1381), Tuple.Create("\"", 1406)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.JobIdValue
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1452), Tuple.Create("\"", 1475)
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1460), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1517), Tuple.Create("\"", 1540)
, Tuple.Create(Tuple.Create("", 1525), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1525), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Job/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1834), Tuple.Create("\"", 1931)
, Tuple.Create(Tuple.Create("", 1841), Tuple.Create("/Job/ViewHistory/?RecId=", 1841), true)
, Tuple.Create(Tuple.Create("", 1865), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1865), false)
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create("&dt=", 1880), true)
, Tuple.Create(Tuple.Create("", 1884), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1884), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2523), Tuple.Create("\"", 2538)
, Tuple.Create(Tuple.Create("", 2530), Tuple.Create("#", 2530), true)
, Tuple.Create(Tuple.Create("", 2531), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2531), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2754), Tuple.Create("\"", 2766)
, Tuple.Create(Tuple.Create("", 2759), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2759), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_Add_3.cshtml")]
    public partial class Views_Job_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Job>
    {
        public Views_Job_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Jobs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Jobs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Job/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Job>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Job_List_3.cshtml")]
    public partial class Views_Job_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Job>>
    {
        public Views_Job_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Jobs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Jobs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Jobs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Job/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 474), Tuple.Create("\"", 540)
, Tuple.Create(Tuple.Create("", 481), Tuple.Create("/Job/ListFromQuery/?Clause=", 481), true)
                                                               , Tuple.Create(Tuple.Create("", 508), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 508), false)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("&Ord=", 523), true)
                                                                                   , Tuple.Create(Tuple.Create("", 528), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 528), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                    Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Transporter</th><th>Vehicle Number</th><th>Tr" +
"ailer Number</th><th>Route From</th><th>Route To</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 924), Tuple.Create("\"", 961)
, Tuple.Create(Tuple.Create("", 931), Tuple.Create("/Job/Load/?RecId=", 931), true)
            , Tuple.Create(Tuple.Create("", 948), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 948), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1209), Tuple.Create("\"", 1289)
, Tuple.Create(Tuple.Create("", 1220), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobNo/?RecId=", 1220), true)
                                                              , Tuple.Create(Tuple.Create("", 1265), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1265), false)
, Tuple.Create(Tuple.Create("", 1278), Tuple.Create("\',$(this));", 1278), true)
);
WriteLiteral(" data-bound-name=\'JobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1383)
                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobNo.HTMLValue)
, 1353), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTransp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Job/AutoCompleteJobTransp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1614), Tuple.Create("\"", 1698)
, Tuple.Create(Tuple.Create("", 1625), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTransp/?RecId=", 1625), true)
                                                                                                             , Tuple.Create(Tuple.Create("", 1674), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1674), false)
, Tuple.Create(Tuple.Create("", 1687), Tuple.Create("\',$(this));", 1687), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobTransp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.JobTransp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobVehNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1995), Tuple.Create("\"", 2078)
, Tuple.Create(Tuple.Create("", 2006), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobVehNo/?RecId=", 2006), true)
                                                                 , Tuple.Create(Tuple.Create("", 2054), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2054), false)
, Tuple.Create(Tuple.Create("", 2067), Tuple.Create("\',$(this));", 2067), true)
);
WriteLiteral(" data-bound-name=\'JobVehNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2137), Tuple.Create("\'", 2178)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2145), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobVehNo.HTMLValue)
, 2145), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobTrailerNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2369), Tuple.Create("\"", 2456)
, Tuple.Create(Tuple.Create("", 2380), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobTrailerNo/?RecId=", 2380), true)
                                                                     , Tuple.Create(Tuple.Create("", 2432), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2432), false)
, Tuple.Create(Tuple.Create("", 2445), Tuple.Create("\',$(this));", 2445), true)
);
WriteLiteral(" data-bound-name=\'JobTrailerNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2519), Tuple.Create("\'", 2564)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2527), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobTrailerNo.HTMLValue)
, 2527), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteFrom.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2753), Tuple.Create("\"", 2840)
, Tuple.Create(Tuple.Create("", 2764), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteFrom/?RecId=", 2764), true)
                                                                   , Tuple.Create(Tuple.Create("", 2816), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2816), false)
, Tuple.Create(Tuple.Create("", 2829), Tuple.Create("\',$(this));", 2829), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteFrom\'");
WriteLiteral("  >");
                                                                                                                                                                                                                             Write(Html.Raw(itm.JobRouteFrom.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobRouteTo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3124), Tuple.Create("\"", 3209)
, Tuple.Create(Tuple.Create("", 3135), Tuple.Create("javascript:IQAutoSave(\'/Job/SaveJobRouteTo/?RecId=", 3135), true)
                                                                 , Tuple.Create(Tuple.Create("", 3185), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3185), false)
, Tuple.Create(Tuple.Create("", 3198), Tuple.Create("\',$(this));", 3198), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'JobRouteTo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                         Write(Html.Raw(itm.JobRouteTo.HTMLValue));
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
