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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_TransportCosts.cshtml")]
    public partial class Views_JobCost_TransportCosts_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_TransportCosts_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel101611", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.JobCJobNo.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 340)
        , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCJobNo.BackHEXColor) ? "" : "color:" + Model.JobCJobNo.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 249), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 249), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCJobNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 556), Tuple.Create("\'", 623)
, Tuple.Create(Tuple.Create("", 564), Tuple.Create("form-control", 564), true)
, Tuple.Create(Tuple.Create("    ", 576), Tuple.Create<System.Object, System.Int32>(!Model.JobCJobNo.Visible ? " hide " : ""
, 580), false)
);
WriteLiteral("  ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCJobNo/',$(this));\""));
WriteLiteral("   name=\'PopulateJobCJobNo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.JobCJobNo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 957), Tuple.Create("\'", 978)
, Tuple.Create(Tuple.Create("", 965), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 965), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateJobCJobNo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateJobCJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 1847), Tuple.Create("\'", 1922)
, Tuple.Create(Tuple.Create("", 1855), Tuple.Create("IQLabel101612", 1855), true)
, Tuple.Create(Tuple.Create(" ", 1868), Tuple.Create<System.Object, System.Int32>(!Model.JobCServProvId.LabelVisible ? " hide " : ""
, 1869), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1923), Tuple.Create("\'", 2140)
                                , Tuple.Create(Tuple.Create("", 1932), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCServProvId.BackHEXColor) ? "" : "color:" + Model.JobCServProvId.BackHEXColor + ";"
, 1932), false)
, Tuple.Create(Tuple.Create("", 2048), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 2048), true)
);
WriteLiteral(">Service Provider Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCServProvId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobCServProvId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.JobCServProvId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCServProvId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCServProvId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobCServProvId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.JobCServProvId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2784), Tuple.Create("\'", 2857)
, Tuple.Create(Tuple.Create("", 2792), Tuple.Create("IQLabel101613", 2792), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 2805), Tuple.Create<System.Object, System.Int32>(!Model.JobCServProv.LabelVisible ? " hide " : ""
, 2806), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2858), Tuple.Create("\'", 3071)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2867), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCServProv.BackHEXColor) ? "" : "color:" + Model.JobCServProv.BackHEXColor + ";"
, 2867), false)
, Tuple.Create(Tuple.Create("", 2979), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2979), true)
);
WriteLiteral(">Service Provider</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'TransportCosts_JobCServProv\'");
                                              Write(Model.RecordLocked || !Model.JobCServProv.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCServProv/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCServProv/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                                  Write(!Model.JobCServProv.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/JobCost/AutoCompleteJobCServProv/");
                                                   Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateJobCServProv\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateJobCServProv.ToString() != "" && Model.PopulateJobCServProv.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.JobCServProv.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateJobCServProv]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 4803), Tuple.Create("\'", 4872)
, Tuple.Create(Tuple.Create("", 4811), Tuple.Create("IQLabel101614", 4811), true)
, Tuple.Create(Tuple.Create(" ", 4824), Tuple.Create<System.Object, System.Int32>(!Model.JobCDesc.LabelVisible ? " hide " : ""
, 4825), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4873), Tuple.Create("\'", 5078)
                          , Tuple.Create(Tuple.Create("", 4882), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCDesc.BackHEXColor) ? "" : "color:" + Model.JobCDesc.BackHEXColor + ";"
, 4882), false)
, Tuple.Create(Tuple.Create("", 4986), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 4986), true)
);
WriteLiteral(">Description</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCDesc\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobCDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.JobCDesc.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCDesc/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobCDesc\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.JobCDesc.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5673), Tuple.Create("\'", 5743)
, Tuple.Create(Tuple.Create("", 5681), Tuple.Create("IQLabel101631", 5681), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 5694), Tuple.Create<System.Object, System.Int32>(!Model.JobCInvNo.LabelVisible ? " hide " : ""
, 5695), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5744), Tuple.Create("\'", 5952)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 5753), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCInvNo.BackHEXColor) ? "" : "color:" + Model.JobCInvNo.BackHEXColor + ";"
, 5753), false)
, Tuple.Create(Tuple.Create("", 5859), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 5859), true)
);
WriteLiteral(">Invoice Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCInvNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobCInvNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.JobCInvNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCInvNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobCInvNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.JobCInvNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 6556), Tuple.Create("\'", 6628)
, Tuple.Create(Tuple.Create("", 6564), Tuple.Create("IQLabel101632", 6564), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 6577), Tuple.Create<System.Object, System.Int32>(!Model.JobCInvDate.LabelVisible ? " hide " : ""
, 6578), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6629), Tuple.Create("\'", 6842)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 6638), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCInvDate.BackHEXColor) ? "" : "color:" + Model.JobCInvDate.BackHEXColor + ";"
, 6638), false)
, Tuple.Create(Tuple.Create("", 6748), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 6748), true)
);
WriteLiteral(">Invoice Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCInvDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobCInvDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                Write(!Model.JobCInvDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCInvDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateJobCInvDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.JobCInvDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateJobCInvDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7809), Tuple.Create("\'", 7880)
, Tuple.Create(Tuple.Create("", 7817), Tuple.Create("IQLabel101633", 7817), true)
, Tuple.Create(Tuple.Create(" ", 7830), Tuple.Create<System.Object, System.Int32>(!Model.JobCInvAmt.LabelVisible ? " hide " : ""
, 7831), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7881), Tuple.Create("\'", 8092)
                                , Tuple.Create(Tuple.Create("", 7890), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.JobCInvAmt.BackHEXColor) ? "" : "color:" + Model.JobCInvAmt.BackHEXColor + ";"
, 7890), false)
, Tuple.Create(Tuple.Create("", 7998), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 7998), true)
);
WriteLiteral(">Invoice Amount</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'TransportCosts_JobCInvAmt\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.JobCInvAmt.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.JobCInvAmt.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvAmt/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/JobCost/CallbackJobCInvAmt/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateJobCInvAmt\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.JobCInvAmt.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:53px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Edit_1.cshtml")]
    public partial class Views_JobCost_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Edit_1_cshtml()
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
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/JobCost/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobCos" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobCost", Model.RecordID.Value))
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
WriteLiteral(" value=\"JobCost\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.JobCJobNoValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobCost/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/JobCost/ViewHistory/?RecId=", 1950), true)
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
WriteLiteral(" id=\"TransportCosts\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobCost_TransportCosts.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2839), Tuple.Create("\"", 2854)
, Tuple.Create(Tuple.Create("", 2846), Tuple.Create("#", 2846), true)
, Tuple.Create(Tuple.Create("", 2847), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2847), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3070), Tuple.Create("\"", 3082)
, Tuple.Create(Tuple.Create("", 3075), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3075), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Add_1.cshtml")]
    public partial class Views_JobCost_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Costs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Costs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobCost/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportCosts\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobCost_TransportCosts.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_List_1.cshtml")]
    public partial class Views_JobCost_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobCost>>
    {
        public Views_JobCost_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Costs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Costs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Costs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobCost/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Service Provider Id</th><th>Service Provider<" +
"/th><th>Description</th><th>Invoice Amount</th><th>Invoice Number</th><th>Invoic" +
"e Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 993), Tuple.Create("\"", 1034)
, Tuple.Create(Tuple.Create("", 1000), Tuple.Create("/JobCost/Load/?RecId=", 1000), true)
               , Tuple.Create(Tuple.Create("", 1021), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1021), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobCJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProvId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1444)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProvId/?RecId=", 1362), true)
                                                                           , Tuple.Create(Tuple.Create("", 1420), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1420), false)
, Tuple.Create(Tuple.Create("", 1433), Tuple.Create("\',$(this));", 1433), true)
);
WriteLiteral(" data-bound-name=\'JobCServProvId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1556)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCServProvId.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProv.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/JobCost/AutoCompleteJobCServProv/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1797), Tuple.Create("\"", 1888)
, Tuple.Create(Tuple.Create("", 1808), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProv/?RecId=", 1808), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 1864), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1864), false)
, Tuple.Create(Tuple.Create("", 1877), Tuple.Create("\',$(this));", 1877), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobCServProv\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.JobCServProv.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2191), Tuple.Create("\"", 2278)
, Tuple.Create(Tuple.Create("", 2202), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCDesc/?RecId=", 2202), true)
                                                                     , Tuple.Create(Tuple.Create("", 2254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2254), false)
, Tuple.Create(Tuple.Create("", 2267), Tuple.Create("\',$(this));", 2267), true)
);
WriteLiteral(" data-bound-name=\'JobCDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2337), Tuple.Create("\'", 2378)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCDesc.HTMLValue)
, 2345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2567), Tuple.Create("\"", 2656)
, Tuple.Create(Tuple.Create("", 2578), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvAmt/?RecId=", 2578), true)
                                                                       , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2632), false)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create("\',$(this));", 2645), true)
);
WriteLiteral(" data-bound-name=\'JobCInvAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2717), Tuple.Create("\'", 2760)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvAmt.HTMLValue)
, 2725), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2948), Tuple.Create("\"", 3036)
, Tuple.Create(Tuple.Create("", 2959), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvNo/?RecId=", 2959), true)
                                                                      , Tuple.Create(Tuple.Create("", 3012), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3012), false)
, Tuple.Create(Tuple.Create("", 3025), Tuple.Create("\',$(this));", 3025), true)
);
WriteLiteral(" data-bound-name=\'JobCInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3096), Tuple.Create("\'", 3138)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvNo.HTMLValue)
, 3104), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3356), Tuple.Create("\"", 3446)
, Tuple.Create(Tuple.Create("", 3367), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvDate/?RecId=", 3367), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 3422), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3422), false)
, Tuple.Create(Tuple.Create("", 3435), Tuple.Create("\',$(this));", 3435), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobCInvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3517), Tuple.Create("\'", 3561)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3525), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvDate.HTMLValue)
, 3525), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Edit_2.cshtml")]
    public partial class Views_JobCost_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Edit_2_cshtml()
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
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/JobCost/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobCos" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobCost", Model.RecordID.Value))
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
WriteLiteral(" value=\"JobCost\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.JobCJobNoValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobCost/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/JobCost/ViewHistory/?RecId=", 1950), true)
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
WriteLiteral(" id=\"TransportCosts\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobCost_TransportCosts.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2839), Tuple.Create("\"", 2854)
, Tuple.Create(Tuple.Create("", 2846), Tuple.Create("#", 2846), true)
, Tuple.Create(Tuple.Create("", 2847), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2847), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3070), Tuple.Create("\"", 3082)
, Tuple.Create(Tuple.Create("", 3075), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3075), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Add_2.cshtml")]
    public partial class Views_JobCost_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Costs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Costs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobCost/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"TransportCosts\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/JobCost_TransportCosts.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_List_2.cshtml")]
    public partial class Views_JobCost_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobCost>>
    {
        public Views_JobCost_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Costs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Costs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Costs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobCost/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Service Provider Id</th><th>Service Provider<" +
"/th><th>Description</th><th>Invoice Amount</th><th>Invoice Number</th><th>Invoic" +
"e Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 993), Tuple.Create("\"", 1034)
, Tuple.Create(Tuple.Create("", 1000), Tuple.Create("/JobCost/Load/?RecId=", 1000), true)
               , Tuple.Create(Tuple.Create("", 1021), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1021), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobCJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProvId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1444)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProvId/?RecId=", 1362), true)
                                                                           , Tuple.Create(Tuple.Create("", 1420), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1420), false)
, Tuple.Create(Tuple.Create("", 1433), Tuple.Create("\',$(this));", 1433), true)
);
WriteLiteral(" data-bound-name=\'JobCServProvId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1556)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCServProvId.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProv.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/JobCost/AutoCompleteJobCServProv/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1797), Tuple.Create("\"", 1888)
, Tuple.Create(Tuple.Create("", 1808), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProv/?RecId=", 1808), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 1864), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1864), false)
, Tuple.Create(Tuple.Create("", 1877), Tuple.Create("\',$(this));", 1877), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobCServProv\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.JobCServProv.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2191), Tuple.Create("\"", 2278)
, Tuple.Create(Tuple.Create("", 2202), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCDesc/?RecId=", 2202), true)
                                                                     , Tuple.Create(Tuple.Create("", 2254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2254), false)
, Tuple.Create(Tuple.Create("", 2267), Tuple.Create("\',$(this));", 2267), true)
);
WriteLiteral(" data-bound-name=\'JobCDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2337), Tuple.Create("\'", 2378)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCDesc.HTMLValue)
, 2345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2567), Tuple.Create("\"", 2656)
, Tuple.Create(Tuple.Create("", 2578), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvAmt/?RecId=", 2578), true)
                                                                       , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2632), false)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create("\',$(this));", 2645), true)
);
WriteLiteral(" data-bound-name=\'JobCInvAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2717), Tuple.Create("\'", 2760)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvAmt.HTMLValue)
, 2725), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2948), Tuple.Create("\"", 3036)
, Tuple.Create(Tuple.Create("", 2959), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvNo/?RecId=", 2959), true)
                                                                      , Tuple.Create(Tuple.Create("", 3012), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3012), false)
, Tuple.Create(Tuple.Create("", 3025), Tuple.Create("\',$(this));", 3025), true)
);
WriteLiteral(" data-bound-name=\'JobCInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3096), Tuple.Create("\'", 3138)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvNo.HTMLValue)
, 3104), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3356), Tuple.Create("\"", 3446)
, Tuple.Create(Tuple.Create("", 3367), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvDate/?RecId=", 3367), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 3422), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3422), false)
, Tuple.Create(Tuple.Create("", 3435), Tuple.Create("\',$(this));", 3435), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobCInvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3517), Tuple.Create("\'", 3561)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3525), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvDate.HTMLValue)
, 3525), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Edit_3.cshtml")]
    public partial class Views_JobCost_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Edit_3_cshtml()
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
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/JobCost/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/JobCos" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("JobCost", Model.RecordID.Value))
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
WriteLiteral(" value=\"JobCost\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1511)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.JobCJobNoValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/JobCost/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1943), Tuple.Create("\"", 2044)
, Tuple.Create(Tuple.Create("", 1950), Tuple.Create("/JobCost/ViewHistory/?RecId=", 1950), true)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_Add_3.cshtml")]
    public partial class Views_JobCost_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.JobCost>
    {
        public Views_JobCost_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Job Costs";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Job Costs\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/JobCost/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<JobCost>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/JobCost_List_3.cshtml")]
    public partial class Views_JobCost_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.JobCost>>
    {
        public Views_JobCost_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Costs List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Job Costs List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Job Costs</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/JobCost/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 508), Tuple.Create("/JobCost/ListFromQuery/?Clause=", 508), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Job Number</th><th>Service Provider Id</th><th>Service Provider<" +
"/th><th>Description</th><th>Invoice Amount</th><th>Invoice Number</th><th>Invoic" +
"e Date</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 993), Tuple.Create("\"", 1034)
, Tuple.Create(Tuple.Create("", 1000), Tuple.Create("/JobCost/Load/?RecId=", 1000), true)
               , Tuple.Create(Tuple.Create("", 1021), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1021), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.JobCJobNo.DisplayValue);
WriteLiteral("</td>");
                                                                                             if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProvId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1444)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProvId/?RecId=", 1362), true)
                                                                           , Tuple.Create(Tuple.Create("", 1420), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1420), false)
, Tuple.Create(Tuple.Create("", 1433), Tuple.Create("\',$(this));", 1433), true)
);
WriteLiteral(" data-bound-name=\'JobCServProvId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1509), Tuple.Create("\'", 1556)
                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1517), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCServProvId.HTMLValue)
, 1517), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCServProv.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/JobCost/AutoCompleteJobCServProv/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1797), Tuple.Create("\"", 1888)
, Tuple.Create(Tuple.Create("", 1808), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCServProv/?RecId=", 1808), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 1864), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1864), false)
, Tuple.Create(Tuple.Create("", 1877), Tuple.Create("\',$(this));", 1877), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'JobCServProv\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                        Write(Html.Raw(itm.JobCServProv.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCDesc.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2191), Tuple.Create("\"", 2278)
, Tuple.Create(Tuple.Create("", 2202), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCDesc/?RecId=", 2202), true)
                                                                     , Tuple.Create(Tuple.Create("", 2254), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2254), false)
, Tuple.Create(Tuple.Create("", 2267), Tuple.Create("\',$(this));", 2267), true)
);
WriteLiteral(" data-bound-name=\'JobCDesc\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2337), Tuple.Create("\'", 2378)
                                                                                                                                                                , Tuple.Create(Tuple.Create("", 2345), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCDesc.HTMLValue)
, 2345), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvAmt.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2567), Tuple.Create("\"", 2656)
, Tuple.Create(Tuple.Create("", 2578), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvAmt/?RecId=", 2578), true)
                                                                       , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2632), false)
, Tuple.Create(Tuple.Create("", 2645), Tuple.Create("\',$(this));", 2645), true)
);
WriteLiteral(" data-bound-name=\'JobCInvAmt\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2717), Tuple.Create("\'", 2760)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2725), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvAmt.HTMLValue)
, 2725), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2948), Tuple.Create("\"", 3036)
, Tuple.Create(Tuple.Create("", 2959), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvNo/?RecId=", 2959), true)
                                                                      , Tuple.Create(Tuple.Create("", 3012), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3012), false)
, Tuple.Create(Tuple.Create("", 3025), Tuple.Create("\',$(this));", 3025), true)
);
WriteLiteral(" data-bound-name=\'JobCInvNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3096), Tuple.Create("\'", 3138)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 3104), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvNo.HTMLValue)
, 3104), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.JobCInvDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3356), Tuple.Create("\"", 3446)
, Tuple.Create(Tuple.Create("", 3367), Tuple.Create("javascript:IQAutoSave(\'/JobCost/SaveJobCInvDate/?RecId=", 3367), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 3422), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3422), false)
, Tuple.Create(Tuple.Create("", 3435), Tuple.Create("\',$(this));", 3435), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'JobCInvDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3517), Tuple.Create("\'", 3561)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 3525), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.JobCInvDate.HTMLValue)
, 3525), false)
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
