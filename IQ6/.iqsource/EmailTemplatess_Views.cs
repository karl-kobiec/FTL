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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_EmailTemplates.cshtml")]
    public partial class Views_EmailTemplatess_EmailTemplates_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_EmailTemplates_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 71), Tuple.Create("\'", 139)
, Tuple.Create(Tuple.Create("", 79), Tuple.Create("IQLabel105311", 79), true)
, Tuple.Create(Tuple.Create(" ", 92), Tuple.Create<System.Object, System.Int32>(!Model.EMTName.LabelVisible ? " hide " : ""
, 93), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 140), Tuple.Create("\'", 342)
      , Tuple.Create(Tuple.Create("", 149), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTName.BackHEXColor) ? "" : "color:" + Model.EMTName.BackHEXColor + ";"
, 149), false)
, Tuple.Create(Tuple.Create("", 251), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 251), true)
);
WriteLiteral(">Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                              Write(!Model.EMTName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.EMTName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 947), Tuple.Create("\'", 1016)
, Tuple.Create(Tuple.Create("", 955), Tuple.Create("IQLabel105312", 955), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 968), Tuple.Create<System.Object, System.Int32>(!Model.EMTQuery.LabelVisible ? " hide " : ""
, 969), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1017), Tuple.Create("\'", 1222)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1026), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTQuery.BackHEXColor) ? "" : "color:" + Model.EMTQuery.BackHEXColor + ";"
, 1026), false)
, Tuple.Create(Tuple.Create("", 1130), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1130), true)
);
WriteLiteral(">Query</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTQuery\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTQuery.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                Write(!Model.EMTQuery.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTQuery/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTQuery/',$(this));\""));
WriteLiteral("   name=\'PopulateEMTQuery\'  style=\'position: absolute; left:130px;height:21px;wid" +
"th:160px;top:28px;\'>\r\n");
             foreach(var itm in Model.EMTQuery.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1844), Tuple.Create("\'", 1865)
, Tuple.Create(Tuple.Create("", 1852), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1852), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateEMTQuery.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1997), Tuple.Create("\'", 2069)
, Tuple.Create(Tuple.Create("", 2005), Tuple.Create("IQLabel105313", 2005), true)
, Tuple.Create(Tuple.Create(" ", 2018), Tuple.Create<System.Object, System.Int32>(!Model.EMTFromAddr.LabelVisible ? " hide " : ""
, 2019), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2070), Tuple.Create("\'", 2281)
                          , Tuple.Create(Tuple.Create("", 2079), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTFromAddr.BackHEXColor) ? "" : "color:" + Model.EMTFromAddr.BackHEXColor + ";"
, 2079), false)
, Tuple.Create(Tuple.Create("", 2189), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2189), true)
);
WriteLiteral(">From Address</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTFromAddr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTFromAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.EMTFromAddr.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTFromAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTFromAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTFromAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.EMTFromAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2914), Tuple.Create("\'", 2985)
, Tuple.Create(Tuple.Create("", 2922), Tuple.Create("IQLabel105314", 2922), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 2935), Tuple.Create<System.Object, System.Int32>(!Model.EMTSubject.LabelVisible ? " hide " : ""
, 2936), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2986), Tuple.Create("\'", 3195)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2995), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTSubject.BackHEXColor) ? "" : "color:" + Model.EMTSubject.BackHEXColor + ";"
, 2995), false)
, Tuple.Create(Tuple.Create("", 3103), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3103), true)
);
WriteLiteral(">Subject</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTSubject\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTSubject.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.EMTSubject.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTSubject/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTSubject/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTSubject\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.EMTSubject.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:400px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 3816), Tuple.Create("\'", 3884)
, Tuple.Create(Tuple.Create("", 3824), Tuple.Create("IQLabel105315", 3824), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 3837), Tuple.Create<System.Object, System.Int32>(!Model.EMTBody.LabelVisible ? " hide " : ""
, 3838), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3885), Tuple.Create("\'", 4089)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 3894), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTBody.BackHEXColor) ? "" : "color:" + Model.EMTBody.BackHEXColor + ";"
, 3894), false)
, Tuple.Create(Tuple.Create("", 3996), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3996), true)
);
WriteLiteral(">Body</label>\r\n\t\t\t\t<div");
WriteLiteral(" id=\"RichEditor-PopulateEMTBody\"");
WriteLiteral(" ");
                                                 Write(Model.RecordLocked ? "data-disabled='true'" :"");
WriteLiteral("  data-target=\"textarea[name=PopulateEMTBody]\" class=\'RichEditor\' style=\'position" +
": absolute; left:130px;height:296px;width:800px;top:103px;\'>");
                                                                                                                                                                                                                                               Write(Html.Raw(Model.PopulateEMTBody));
WriteLiteral("</div>\r\n\t\t<textarea");
WriteLiteral("  data-ScreenInfo=\'EmailTemplates_EMTBody\'");
                                                       Write(Model.RecordLocked || !Model.EMTBody.Enabled ? "disabled=disabled" : "");
WriteLiteral(" ");
                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTBody/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTBody/',$(this));\""));
WriteLiteral("  class=\' ");
                                                                                                                                                                                                                                                                                                                                                                                     Write(!Model.EMTBody.Visible ? " hide " : "");
WriteLiteral(" form-control \' name=\'PopulateEMTBody\' style=\'display:none\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Html.Raw(Model.PopulateEMTBody));
WriteLiteral("</textarea>\r\n\t\t\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 4906), Tuple.Create("\'", 4976)
, Tuple.Create(Tuple.Create("", 4914), Tuple.Create("IQLabel105331", 4914), true)
, Tuple.Create(Tuple.Create(" ", 4927), Tuple.Create<System.Object, System.Int32>(!Model.EMTToAddr.LabelVisible ? " hide " : ""
, 4928), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4977), Tuple.Create("\'", 5185)
               , Tuple.Create(Tuple.Create("", 4986), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTToAddr.BackHEXColor) ? "" : "color:" + Model.EMTToAddr.BackHEXColor + ";"
, 4986), false)
, Tuple.Create(Tuple.Create("", 5092), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 5092), true)
);
WriteLiteral(">To Address</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTToAddr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTToAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.EMTToAddr.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTToAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTToAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTToAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.EMTToAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:400px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 5801), Tuple.Create("\'", 5871)
, Tuple.Create(Tuple.Create("", 5809), Tuple.Create("IQLabel105332", 5809), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 5822), Tuple.Create<System.Object, System.Int32>(!Model.EMTCCAddr.LabelVisible ? " hide " : ""
, 5823), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5872), Tuple.Create("\'", 6081)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 5881), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTCCAddr.BackHEXColor) ? "" : "color:" + Model.EMTCCAddr.BackHEXColor + ";"
, 5881), false)
, Tuple.Create(Tuple.Create("", 5987), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 5987), true)
);
WriteLiteral(">CC Address</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTCCAddr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTCCAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.EMTCCAddr.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTCCAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTCCAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTCCAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.EMTCCAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:400px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6698), Tuple.Create("\'", 6769)
, Tuple.Create(Tuple.Create("", 6706), Tuple.Create("IQLabel105333", 6706), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 6719), Tuple.Create<System.Object, System.Int32>(!Model.EMTBCCAddr.LabelVisible ? " hide " : ""
, 6720), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6770), Tuple.Create("\'", 6981)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 6779), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EMTBCCAddr.BackHEXColor) ? "" : "color:" + Model.EMTBCCAddr.BackHEXColor + ";"
, 6779), false)
, Tuple.Create(Tuple.Create("", 6887), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 6887), true)
);
WriteLiteral(">BCC Address</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'EmailTemplates_EMTBCCAddr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EMTBCCAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.EMTBCCAddr.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTBCCAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EmailTemplatess/CallbackEMTBCCAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEMTBCCAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.EMTBCCAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:400px;top:53px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Edit_1.cshtml")]
    public partial class Views_EmailTemplatess_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EmailT" +
"emplatess/ViewHistory/?RecId=");
                                                                                                            Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EmailTemplatess", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1177), Tuple.Create("\'", 1199)
, Tuple.Create(Tuple.Create("", 1185), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1185), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1245), Tuple.Create("\'", 1269)
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1253), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EmailTemplatess\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1378), Tuple.Create("\"", 1403)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Model.EMTIdValue
, 1386), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1449), Tuple.Create("\"", 1472)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1514), Tuple.Create("\"", 1537)
, Tuple.Create(Tuple.Create("", 1522), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1522), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EmailTemplatess/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1843), Tuple.Create("\"", 1952)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("/EmailTemplatess/ViewHistory/?RecId=", 1850), true)
, Tuple.Create(Tuple.Create("", 1886), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1886), false)
, Tuple.Create(Tuple.Create("", 1901), Tuple.Create("&dt=", 1901), true)
, Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1905), false)
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
WriteLiteral(" id=\"EmailTemplates\"");
WriteLiteral(" style=\'position:relative;height:429px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EmailTemplatess_EmailTemplates.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2755), Tuple.Create("\"", 2770)
, Tuple.Create(Tuple.Create("", 2762), Tuple.Create("#", 2762), true)
, Tuple.Create(Tuple.Create("", 2763), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2763), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2986), Tuple.Create("\"", 2998)
, Tuple.Create(Tuple.Create("", 2991), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2991), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Add_1.cshtml")]
    public partial class Views_EmailTemplatess_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Email Templates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Email Templates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EmailTemplatess/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"EmailTemplates\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EmailTemplatess_EmailTemplates.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_List_1.cshtml")]
    public partial class Views_EmailTemplatess_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EmailTemplatess>>
    {
        public Views_EmailTemplatess_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Email Templates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Email Templates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Email Templates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 543), Tuple.Create("\"", 621)
, Tuple.Create(Tuple.Create("", 550), Tuple.Create("/EmailTemplatess/ListFromQuery/?Clause=", 550), true)
                                                                           , Tuple.Create(Tuple.Create("", 589), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 589), false)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("&Ord=", 604), true)
                                                                                               , Tuple.Create(Tuple.Create("", 609), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 609), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                                Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Subject</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 927), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 934), Tuple.Create("/EmailTemplatess/Load/?RecId=", 934), true)
                        , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1226), Tuple.Create("\"", 1320)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTName/?RecId=", 1237), true)
                                                                            , Tuple.Create(Tuple.Create("", 1296), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1296), false)
, Tuple.Create(Tuple.Create("", 1309), Tuple.Create("\',$(this));", 1309), true)
);
WriteLiteral(" data-bound-name=\'EMTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1378), Tuple.Create("\'", 1418)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMTName.HTMLValue)
, 1386), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1607), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1618), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTSubject/?RecId=", 1618), true)
                                                                               , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1680), false)
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create("\',$(this));", 1693), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.EMTSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:0%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1982), Tuple.Create("\"", 2077)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTQuery/?RecId=", 1993), true)
                                                                          , Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("\',$(this));", 2066), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.EMTQuery.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Edit_2.cshtml")]
    public partial class Views_EmailTemplatess_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EmailT" +
"emplatess/ViewHistory/?RecId=");
                                                                                                            Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EmailTemplatess", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1177), Tuple.Create("\'", 1199)
, Tuple.Create(Tuple.Create("", 1185), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1185), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1245), Tuple.Create("\'", 1269)
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1253), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EmailTemplatess\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1378), Tuple.Create("\"", 1403)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Model.EMTIdValue
, 1386), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1449), Tuple.Create("\"", 1472)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1514), Tuple.Create("\"", 1537)
, Tuple.Create(Tuple.Create("", 1522), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1522), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EmailTemplatess/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1843), Tuple.Create("\"", 1952)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("/EmailTemplatess/ViewHistory/?RecId=", 1850), true)
, Tuple.Create(Tuple.Create("", 1886), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1886), false)
, Tuple.Create(Tuple.Create("", 1901), Tuple.Create("&dt=", 1901), true)
, Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1905), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2544), Tuple.Create("\"", 2559)
, Tuple.Create(Tuple.Create("", 2551), Tuple.Create("#", 2551), true)
, Tuple.Create(Tuple.Create("", 2552), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2552), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2775), Tuple.Create("\"", 2787)
, Tuple.Create(Tuple.Create("", 2780), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2780), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Add_2.cshtml")]
    public partial class Views_EmailTemplatess_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Email Templates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Email Templates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EmailTemplatess/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_List_2.cshtml")]
    public partial class Views_EmailTemplatess_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EmailTemplatess>>
    {
        public Views_EmailTemplatess_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Email Templates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Email Templates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Email Templates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 543), Tuple.Create("\"", 621)
, Tuple.Create(Tuple.Create("", 550), Tuple.Create("/EmailTemplatess/ListFromQuery/?Clause=", 550), true)
                                                                           , Tuple.Create(Tuple.Create("", 589), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 589), false)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("&Ord=", 604), true)
                                                                                               , Tuple.Create(Tuple.Create("", 609), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 609), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                                Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Subject</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 927), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 934), Tuple.Create("/EmailTemplatess/Load/?RecId=", 934), true)
                        , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1226), Tuple.Create("\"", 1320)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTName/?RecId=", 1237), true)
                                                                            , Tuple.Create(Tuple.Create("", 1296), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1296), false)
, Tuple.Create(Tuple.Create("", 1309), Tuple.Create("\',$(this));", 1309), true)
);
WriteLiteral(" data-bound-name=\'EMTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1378), Tuple.Create("\'", 1418)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMTName.HTMLValue)
, 1386), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1607), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1618), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTSubject/?RecId=", 1618), true)
                                                                               , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1680), false)
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create("\',$(this));", 1693), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.EMTSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:0%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1982), Tuple.Create("\"", 2077)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTQuery/?RecId=", 1993), true)
                                                                          , Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("\',$(this));", 2066), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.EMTQuery.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Edit_3.cshtml")]
    public partial class Views_EmailTemplatess_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EmailT" +
"emplatess/ViewHistory/?RecId=");
                                                                                                            Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EmailTemplatess", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1177), Tuple.Create("\'", 1199)
, Tuple.Create(Tuple.Create("", 1185), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1185), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1245), Tuple.Create("\'", 1269)
, Tuple.Create(Tuple.Create("", 1253), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1253), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"EmailTemplatess\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1378), Tuple.Create("\"", 1403)
, Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Model.EMTIdValue
, 1386), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1449), Tuple.Create("\"", 1472)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1514), Tuple.Create("\"", 1537)
, Tuple.Create(Tuple.Create("", 1522), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1522), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EmailTemplatess/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1843), Tuple.Create("\"", 1952)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("/EmailTemplatess/ViewHistory/?RecId=", 1850), true)
, Tuple.Create(Tuple.Create("", 1886), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1886), false)
, Tuple.Create(Tuple.Create("", 1901), Tuple.Create("&dt=", 1901), true)
, Tuple.Create(Tuple.Create("", 1905), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1905), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2544), Tuple.Create("\"", 2559)
, Tuple.Create(Tuple.Create("", 2551), Tuple.Create("#", 2551), true)
, Tuple.Create(Tuple.Create("", 2552), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2552), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2775), Tuple.Create("\"", 2787)
, Tuple.Create(Tuple.Create("", 2780), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2780), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_Add_3.cshtml")]
    public partial class Views_EmailTemplatess_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EmailTemplatess>
    {
        public Views_EmailTemplatess_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Email Templates";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Email Templates\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EmailTemplatess/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EmailTemplatess>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EmailTemplatess_List_3.cshtml")]
    public partial class Views_EmailTemplatess_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EmailTemplatess>>
    {
        public Views_EmailTemplatess_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Email Templates List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Email Templates List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Email Templates</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EmailTemplatess/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 543), Tuple.Create("\"", 621)
, Tuple.Create(Tuple.Create("", 550), Tuple.Create("/EmailTemplatess/ListFromQuery/?Clause=", 550), true)
                                                                           , Tuple.Create(Tuple.Create("", 589), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 589), false)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("&Ord=", 604), true)
                                                                                               , Tuple.Create(Tuple.Create("", 609), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 609), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                                Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Subject</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 927), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 934), Tuple.Create("/EmailTemplatess/Load/?RecId=", 934), true)
                        , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:29%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1226), Tuple.Create("\"", 1320)
, Tuple.Create(Tuple.Create("", 1237), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTName/?RecId=", 1237), true)
                                                                            , Tuple.Create(Tuple.Create("", 1296), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1296), false)
, Tuple.Create(Tuple.Create("", 1309), Tuple.Create("\',$(this));", 1309), true)
);
WriteLiteral(" data-bound-name=\'EMTName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1378), Tuple.Create("\'", 1418)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1386), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EMTName.HTMLValue)
, 1386), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTSubject.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1607), Tuple.Create("\"", 1704)
, Tuple.Create(Tuple.Create("", 1618), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTSubject/?RecId=", 1618), true)
                                                                               , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1680), false)
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create("\',$(this));", 1693), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTSubject\'");
WriteLiteral(">");
                                                                                                                                                                                                                                      Write(Html.Raw(itm.EMTSubject.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EMTQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:0%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1982), Tuple.Create("\"", 2077)
, Tuple.Create(Tuple.Create("", 1993), Tuple.Create("javascript:IQAutoSave(\'/EmailTemplatess/SaveEMTQuery/?RecId=", 1993), true)
                                                                          , Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2066), Tuple.Create("\',$(this));", 2066), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'EMTQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                Write(Html.Raw(itm.EMTQuery.HTMLValue));
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
