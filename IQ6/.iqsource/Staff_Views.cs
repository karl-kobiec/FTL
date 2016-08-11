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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Staff.cshtml")]
    public partial class Views_Staff_Staff_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Staff_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 61), Tuple.Create("\'", 127)
, Tuple.Create(Tuple.Create("", 69), Tuple.Create("IQLabel105914", 69), true)
, Tuple.Create(Tuple.Create(" ", 82), Tuple.Create<System.Object, System.Int32>(!Model.StfFN.LabelVisible ? " hide " : ""
, 83), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 128), Tuple.Create("\'", 326)
    , Tuple.Create(Tuple.Create("", 137), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfFN.BackHEXColor) ? "" : "color:" + Model.StfFN.BackHEXColor + ";"
, 137), false)
, Tuple.Create(Tuple.Create("", 235), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 235), true)
);
WriteLiteral(">Forename</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Staff_StfFN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfFN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                   Write(!Model.StfFN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfFN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfFN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateStfFN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.StfFN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 883), Tuple.Create("\'", 949)
, Tuple.Create(Tuple.Create("", 891), Tuple.Create("IQLabel105918", 891), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 904), Tuple.Create<System.Object, System.Int32>(!Model.StfSN.LabelVisible ? " hide " : ""
, 905), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 950), Tuple.Create("\'", 1149)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 959), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfSN.BackHEXColor) ? "" : "color:" + Model.StfSN.BackHEXColor + ";"
, 959), false)
, Tuple.Create(Tuple.Create("", 1057), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1057), true)
);
WriteLiteral(">Surname</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Staff_StfSN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfSN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                   Write(!Model.StfSN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfSN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfSN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateStfSN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.StfSN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1706), Tuple.Create("\'", 1772)
, Tuple.Create(Tuple.Create("", 1714), Tuple.Create("IQLabel105920", 1714), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 1727), Tuple.Create<System.Object, System.Int32>(!Model.StfEM.LabelVisible ? " hide " : ""
, 1728), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1773), Tuple.Create("\'", 1972)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1782), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfEM.BackHEXColor) ? "" : "color:" + Model.StfEM.BackHEXColor + ";"
, 1782), false)
, Tuple.Create(Tuple.Create("", 1880), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1880), true)
);
WriteLiteral(">Email</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Staff_StfEM\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfEM.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                   Write(!Model.StfEM.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfEM/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfEM/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateStfEM\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.StfEM.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 2527), Tuple.Create("\'", 2593)
, Tuple.Create(Tuple.Create("", 2535), Tuple.Create("IQLabel105922", 2535), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 2548), Tuple.Create<System.Object, System.Int32>(!Model.StfSG.LabelVisible ? " hide " : ""
, 2549), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2594), Tuple.Create("\'", 2793)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 2603), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfSG.BackHEXColor) ? "" : "color:" + Model.StfSG.BackHEXColor + ";"
, 2603), false)
, Tuple.Create(Tuple.Create("", 2701), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2701), true)
);
WriteLiteral(">Security Groups</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Staff_StfSG\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfSG.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                    Write(!Model.StfSG.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfSG/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfSG/',$(this));\""));
WriteLiteral("   name=\'PopulateStfSG\'  style=\'position: absolute; left:130px;height:21px;width:" +
"160px;top:78px;\'>\r\n");
             foreach(var itm in Model.StfSG.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 3366), Tuple.Create("\'", 3387)
, Tuple.Create(Tuple.Create("", 3374), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 3374), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateStfSG.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                      Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3516), Tuple.Create("\'", 3588)
, Tuple.Create(Tuple.Create("", 3524), Tuple.Create("IQLabel105926", 3524), true)
, Tuple.Create(Tuple.Create(" ", 3537), Tuple.Create<System.Object, System.Int32>(!Model.StfUsername.LabelVisible ? " hide " : ""
, 3538), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3589), Tuple.Create("\'", 3801)
                          , Tuple.Create(Tuple.Create("", 3598), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfUsername.BackHEXColor) ? "" : "color:" + Model.StfUsername.BackHEXColor + ";"
, 3598), false)
, Tuple.Create(Tuple.Create("", 3708), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 3708), true)
);
WriteLiteral(">Username</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Staff_StfUsername\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfUsername.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.StfUsername.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfUsername/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfUsername/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateStfUsername\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.StfUsername.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 4402), Tuple.Create("\'", 4474)
, Tuple.Create(Tuple.Create("", 4410), Tuple.Create("IQLabel105928", 4410), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 4423), Tuple.Create<System.Object, System.Int32>(!Model.StfPassword.LabelVisible ? " hide " : ""
, 4424), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4475), Tuple.Create("\'", 4687)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 4484), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.StfPassword.BackHEXColor) ? "" : "color:" + Model.StfPassword.BackHEXColor + ";"
, 4484), false)
, Tuple.Create(Tuple.Create("", 4594), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 4594), true)
);
WriteLiteral(">Password</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Staff_StfPassword\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.StfPassword.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.StfPassword.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Staff/SaveStfPassword/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Staff/CallbackStfPassword/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateStfPassword\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.StfPassword.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:153px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Edit_1.cshtml")]
    public partial class Views_Staff_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Edit_1_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Staff/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Staff", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Staff\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1353)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.StfIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1399), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1464), Tuple.Create("\"", 1487)
, Tuple.Create(Tuple.Create("", 1472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1472), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Staff/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1783), Tuple.Create("\"", 1882)
, Tuple.Create(Tuple.Create("", 1790), Tuple.Create("/Staff/ViewHistory/?RecId=", 1790), true)
, Tuple.Create(Tuple.Create("", 1816), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1816), false)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create("&dt=", 1831), true)
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1835), false)
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2657), Tuple.Create("\"", 2672)
, Tuple.Create(Tuple.Create("", 2664), Tuple.Create("#", 2664), true)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2665), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2888), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2893), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2893), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Add_1.cshtml")]
    public partial class Views_Staff_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Staff";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Staff\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Staff/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_List_1.cshtml")]
    public partial class Views_Staff_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Staff>>
    {
        public Views_Staff_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Staff List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Staff List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Staff</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Staff/ListFromQuery/?Clause=", 490), true)
                                                                 , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 519), false)
, Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                     , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 539), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Username</th><th>Password</th><th>Email</th><th>Sec" +
"urity Groups</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create("/Staff/Load/?RecId=", 906), true)
              , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.StfName.DisplayValue);
WriteLiteral("</td>");
                                                                                           if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfUsername.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1338)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfUsername/?RecId=", 1261), true)
                                                                      , Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1314), false)
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create("\',$(this));", 1327), true)
);
WriteLiteral(" data-bound-name=\'StfUsername\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1400), Tuple.Create("\'", 1444)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1408), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfUsername.HTMLValue)
, 1408), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfPassword.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1722)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfPassword/?RecId=", 1645), true)
                                                                      , Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1698), false)
, Tuple.Create(Tuple.Create("", 1711), Tuple.Create("\',$(this));", 1711), true)
);
WriteLiteral(" data-bound-name=\'StfPassword\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1784), Tuple.Create("\'", 1828)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1792), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfPassword.HTMLValue)
, 1792), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2012), Tuple.Create("\"", 2094)
, Tuple.Create(Tuple.Create("", 2023), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfEM/?RecId=", 2023), true)
                                                                , Tuple.Create(Tuple.Create("", 2070), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2070), false)
, Tuple.Create(Tuple.Create("", 2083), Tuple.Create("\',$(this));", 2083), true)
);
WriteLiteral(" data-bound-name=\'StfEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2150), Tuple.Create("\'", 2188)
                                                                                                                                                        , Tuple.Create(Tuple.Create("", 2158), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfEM.HTMLValue)
, 2158), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfSG.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2370), Tuple.Create("\"", 2452)
, Tuple.Create(Tuple.Create("", 2381), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfSG/?RecId=", 2381), true)
                                                              , Tuple.Create(Tuple.Create("", 2428), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2428), false)
, Tuple.Create(Tuple.Create("", 2441), Tuple.Create("\',$(this));", 2441), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'StfSG\'");
WriteLiteral("  >");
                                                                                                                                                                                                                 Write(Html.Raw(itm.StfSG.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Edit_2.cshtml")]
    public partial class Views_Staff_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Edit_2_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Staff/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Staff", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Staff\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1353)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.StfIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1399), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1464), Tuple.Create("\"", 1487)
, Tuple.Create(Tuple.Create("", 1472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1472), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Staff/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1783), Tuple.Create("\"", 1882)
, Tuple.Create(Tuple.Create("", 1790), Tuple.Create("/Staff/ViewHistory/?RecId=", 1790), true)
, Tuple.Create(Tuple.Create("", 1816), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1816), false)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create("&dt=", 1831), true)
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1835), false)
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2657), Tuple.Create("\"", 2672)
, Tuple.Create(Tuple.Create("", 2664), Tuple.Create("#", 2664), true)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2665), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2888), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2893), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2893), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Add_2.cshtml")]
    public partial class Views_Staff_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Staff";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Staff\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Staff/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_List_2.cshtml")]
    public partial class Views_Staff_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Staff>>
    {
        public Views_Staff_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Staff List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Staff List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Staff</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Staff/ListFromQuery/?Clause=", 490), true)
                                                                 , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 519), false)
, Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                     , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 539), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Username</th><th>Password</th><th>Email</th><th>Sec" +
"urity Groups</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create("/Staff/Load/?RecId=", 906), true)
              , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.StfName.DisplayValue);
WriteLiteral("</td>");
                                                                                           if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfUsername.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1338)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfUsername/?RecId=", 1261), true)
                                                                      , Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1314), false)
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create("\',$(this));", 1327), true)
);
WriteLiteral(" data-bound-name=\'StfUsername\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1400), Tuple.Create("\'", 1444)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1408), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfUsername.HTMLValue)
, 1408), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfPassword.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1722)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfPassword/?RecId=", 1645), true)
                                                                      , Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1698), false)
, Tuple.Create(Tuple.Create("", 1711), Tuple.Create("\',$(this));", 1711), true)
);
WriteLiteral(" data-bound-name=\'StfPassword\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1784), Tuple.Create("\'", 1828)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1792), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfPassword.HTMLValue)
, 1792), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2012), Tuple.Create("\"", 2094)
, Tuple.Create(Tuple.Create("", 2023), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfEM/?RecId=", 2023), true)
                                                                , Tuple.Create(Tuple.Create("", 2070), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2070), false)
, Tuple.Create(Tuple.Create("", 2083), Tuple.Create("\',$(this));", 2083), true)
);
WriteLiteral(" data-bound-name=\'StfEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2150), Tuple.Create("\'", 2188)
                                                                                                                                                        , Tuple.Create(Tuple.Create("", 2158), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfEM.HTMLValue)
, 2158), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfSG.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2370), Tuple.Create("\"", 2452)
, Tuple.Create(Tuple.Create("", 2381), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfSG/?RecId=", 2381), true)
                                                              , Tuple.Create(Tuple.Create("", 2428), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2428), false)
, Tuple.Create(Tuple.Create("", 2441), Tuple.Create("\',$(this));", 2441), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'StfSG\'");
WriteLiteral("  >");
                                                                                                                                                                                                                 Write(Html.Raw(itm.StfSG.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Edit_3.cshtml")]
    public partial class Views_Staff_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Edit_3_cshtml()
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
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Staff/" +
"ViewHistory/?RecId=");
                                                                                                  Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Staff", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1137), Tuple.Create("\'", 1159)
, Tuple.Create(Tuple.Create("", 1145), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1145), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1205), Tuple.Create("\'", 1229)
, Tuple.Create(Tuple.Create("", 1213), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1213), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Staff\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1328), Tuple.Create("\"", 1353)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create<System.Object, System.Int32>(Model.StfIdValue
, 1336), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1399), Tuple.Create("\"", 1422)
, Tuple.Create(Tuple.Create("", 1407), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1407), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1464), Tuple.Create("\"", 1487)
, Tuple.Create(Tuple.Create("", 1472), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1472), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Staff/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1783), Tuple.Create("\"", 1882)
, Tuple.Create(Tuple.Create("", 1790), Tuple.Create("/Staff/ViewHistory/?RecId=", 1790), true)
, Tuple.Create(Tuple.Create("", 1816), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1816), false)
, Tuple.Create(Tuple.Create("", 1831), Tuple.Create("&dt=", 1831), true)
, Tuple.Create(Tuple.Create("", 1835), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1835), false)
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative;height:204px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2657), Tuple.Create("\"", 2672)
, Tuple.Create(Tuple.Create("", 2664), Tuple.Create("#", 2664), true)
, Tuple.Create(Tuple.Create("", 2665), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2665), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2888), Tuple.Create("\"", 2900)
, Tuple.Create(Tuple.Create("", 2893), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2893), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_Add_3.cshtml")]
    public partial class Views_Staff_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Staff>
    {
        public Views_Staff_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Staff";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Staff\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Staff/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Staff>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Staff\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Staff_Staff.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Staff_List_3.cshtml")]
    public partial class Views_Staff_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Staff>>
    {
        public Views_Staff_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Staff List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Staff List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Staff</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Staff/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
, Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Staff/ListFromQuery/?Clause=", 490), true)
                                                                 , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 519), false)
, Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                     , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 539), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                      Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>Username</th><th>Password</th><th>Email</th><th>Sec" +
"urity Groups</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 899), Tuple.Create("\"", 938)
, Tuple.Create(Tuple.Create("", 906), Tuple.Create("/Staff/Load/?RecId=", 906), true)
              , Tuple.Create(Tuple.Create("", 925), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 925), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.StfName.DisplayValue);
WriteLiteral("</td>");
                                                                                           if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfUsername.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1250), Tuple.Create("\"", 1338)
, Tuple.Create(Tuple.Create("", 1261), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfUsername/?RecId=", 1261), true)
                                                                      , Tuple.Create(Tuple.Create("", 1314), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1314), false)
, Tuple.Create(Tuple.Create("", 1327), Tuple.Create("\',$(this));", 1327), true)
);
WriteLiteral(" data-bound-name=\'StfUsername\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1400), Tuple.Create("\'", 1444)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1408), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfUsername.HTMLValue)
, 1408), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfPassword.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1634), Tuple.Create("\"", 1722)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfPassword/?RecId=", 1645), true)
                                                                      , Tuple.Create(Tuple.Create("", 1698), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1698), false)
, Tuple.Create(Tuple.Create("", 1711), Tuple.Create("\',$(this));", 1711), true)
);
WriteLiteral(" data-bound-name=\'StfPassword\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1784), Tuple.Create("\'", 1828)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1792), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfPassword.HTMLValue)
, 1792), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:22%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2012), Tuple.Create("\"", 2094)
, Tuple.Create(Tuple.Create("", 2023), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfEM/?RecId=", 2023), true)
                                                                , Tuple.Create(Tuple.Create("", 2070), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2070), false)
, Tuple.Create(Tuple.Create("", 2083), Tuple.Create("\',$(this));", 2083), true)
);
WriteLiteral(" data-bound-name=\'StfEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2150), Tuple.Create("\'", 2188)
                                                                                                                                                        , Tuple.Create(Tuple.Create("", 2158), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.StfEM.HTMLValue)
, 2158), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.StfSG.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:11%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2370), Tuple.Create("\"", 2452)
, Tuple.Create(Tuple.Create("", 2381), Tuple.Create("javascript:IQAutoSave(\'/Staff/SaveStfSG/?RecId=", 2381), true)
                                                              , Tuple.Create(Tuple.Create("", 2428), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2428), false)
, Tuple.Create(Tuple.Create("", 2441), Tuple.Create("\',$(this));", 2441), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'StfSG\'");
WriteLiteral("  >");
                                                                                                                                                                                                                 Write(Html.Raw(itm.StfSG.HTMLValue));
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
