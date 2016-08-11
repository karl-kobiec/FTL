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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_IntrastatMonths.cshtml")]
    public partial class Views_Months_IntrastatMonths_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_IntrastatMonths_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 62), Tuple.Create("\'", 128)
, Tuple.Create(Tuple.Create("", 70), Tuple.Create("IQLabel104311", 70), true)
, Tuple.Create(Tuple.Create(" ", 83), Tuple.Create<System.Object, System.Int32>(!Model.MthId.LabelVisible ? " hide " : ""
, 84), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 129), Tuple.Create("\'", 327)
    , Tuple.Create(Tuple.Create("", 138), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.MthId.BackHEXColor) ? "" : "color:" + Model.MthId.BackHEXColor + ";"
, 138), false)
, Tuple.Create(Tuple.Create("", 236), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 236), true)
);
WriteLiteral(">Month ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatMonths_MthId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 417), Tuple.Create("\'", 488)
, Tuple.Create(Tuple.Create("", 425), Tuple.Create("form-control", 425), true)
, Tuple.Create(Tuple.Create(" ", 437), Tuple.Create("mandatory", 438), true)
, Tuple.Create(Tuple.Create("  ", 447), Tuple.Create<System.Object, System.Int32>(!Model.MthId.Visible ? " hide " : ""
, 449), false)
);
WriteLiteral(" ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Months/SaveMthId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Months/CallbackMthId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateMthId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                         Write(Model.MthId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 849), Tuple.Create("\'", 917)
, Tuple.Create(Tuple.Create("", 857), Tuple.Create("IQLabel104312", 857), true)
                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 870), Tuple.Create<System.Object, System.Int32>(!Model.MthName.LabelVisible ? " hide " : ""
, 871), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 918), Tuple.Create("\'", 1121)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 927), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.MthName.BackHEXColor) ? "" : "color:" + Model.MthName.BackHEXColor + ";"
, 927), false)
, Tuple.Create(Tuple.Create("", 1029), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1029), true)
);
WriteLiteral(">Month Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatMonths_MthName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.MthName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.MthName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Months/SaveMthName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Months/CallbackMthName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateMthName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.MthName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1707), Tuple.Create("\'", 1776)
, Tuple.Create(Tuple.Create("", 1715), Tuple.Create("IQLabel104313", 1715), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 1728), Tuple.Create<System.Object, System.Int32>(!Model.MthSDate.LabelVisible ? " hide " : ""
, 1729), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1777), Tuple.Create("\'", 1982)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1786), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.MthSDate.BackHEXColor) ? "" : "color:" + Model.MthSDate.BackHEXColor + ";"
, 1786), false)
, Tuple.Create(Tuple.Create("", 1890), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1890), true)
);
WriteLiteral(">From</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'IntrastatMonths_MthSDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.MthSDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                             Write(!Model.MthSDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Months/SaveMthSDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Months/CallbackMthSDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateMthSDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.MthSDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateMthSDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2916), Tuple.Create("\'", 2985)
, Tuple.Create(Tuple.Create("", 2924), Tuple.Create("IQLabel104314", 2924), true)
, Tuple.Create(Tuple.Create(" ", 2937), Tuple.Create<System.Object, System.Int32>(!Model.MthEDate.LabelVisible ? " hide " : ""
, 2938), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2986), Tuple.Create("\'", 3191)
                              , Tuple.Create(Tuple.Create("", 2995), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.MthEDate.BackHEXColor) ? "" : "color:" + Model.MthEDate.BackHEXColor + ";"
, 2995), false)
, Tuple.Create(Tuple.Create("", 3099), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3099), true)
);
WriteLiteral(">To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'IntrastatMonths_MthEDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.MthEDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                             Write(!Model.MthEDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Months/SaveMthEDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Months/CallbackMthEDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateMthEDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.MthEDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateMthEDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Edit_1.cshtml")]
    public partial class Views_Months_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Months/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Months</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Months/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Months" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Months", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1374)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1420), Tuple.Create("\'", 1444)
, Tuple.Create(Tuple.Create("", 1428), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1428), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Months\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.MthIdValue
, 1552), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1680), Tuple.Create("\"", 1703)
, Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1688), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Months/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Months/ViewHistory/?RecId=", 2007), true)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2034), false)
, Tuple.Create(Tuple.Create("", 2049), Tuple.Create("&dt=", 2049), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2053), false)
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
WriteLiteral(" id=\"IntrastatMonths\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Months_IntrastatMonths.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2896), Tuple.Create("\"", 2911)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create("#", 2903), true)
, Tuple.Create(Tuple.Create("", 2904), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2904), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3127), Tuple.Create("\"", 3139)
, Tuple.Create(Tuple.Create("", 3132), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3132), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Add_1.cshtml")]
    public partial class Views_Months_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Months";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Months\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Months/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"IntrastatMonths\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Months_IntrastatMonths.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_List_1.cshtml")]
    public partial class Views_Months_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Months>>
    {
        public Views_Months_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Months List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Months List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Months</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 558)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Months/ListFromQuery/?Clause=", 496), true)
                                                                  , Tuple.Create(Tuple.Create("", 526), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 526), false)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("&Ord=", 541), true)
                                                                                      , Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 546), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Month Name</th><th>From</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 853), Tuple.Create("\"", 893)
, Tuple.Create(Tuple.Create("", 860), Tuple.Create("/Months/Load/?RecId=", 860), true)
               , Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 880), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1143), Tuple.Create("\"", 1228)
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthName/?RecId=", 1154), true)
                                                                   , Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1204), false)
, Tuple.Create(Tuple.Create("", 1217), Tuple.Create("\',$(this));", 1217), true)
);
WriteLiteral(" data-bound-name=\'MthName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1286), Tuple.Create("\'", 1326)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1294), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthName.HTMLValue)
, 1294), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1541), Tuple.Create("\"", 1627)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthSDate/?RecId=", 1552), true)
                                                                                                , Tuple.Create(Tuple.Create("", 1603), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1603), false)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create("\',$(this));", 1616), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'MthSDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1736)
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthSDate.HTMLValue)
, 1703), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Edit_2.cshtml")]
    public partial class Views_Months_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Months/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Months</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Months/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Months" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Months", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1374)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1420), Tuple.Create("\'", 1444)
, Tuple.Create(Tuple.Create("", 1428), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1428), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Months\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.MthIdValue
, 1552), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1680), Tuple.Create("\"", 1703)
, Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1688), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Months/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Months/ViewHistory/?RecId=", 2007), true)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2034), false)
, Tuple.Create(Tuple.Create("", 2049), Tuple.Create("&dt=", 2049), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2053), false)
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
WriteLiteral(" id=\"IntrastatMonths\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Months_IntrastatMonths.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2896), Tuple.Create("\"", 2911)
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create("#", 2903), true)
, Tuple.Create(Tuple.Create("", 2904), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2904), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3127), Tuple.Create("\"", 3139)
, Tuple.Create(Tuple.Create("", 3132), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3132), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Add_2.cshtml")]
    public partial class Views_Months_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Months";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Months\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Months/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"IntrastatMonths\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Months_IntrastatMonths.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_List_2.cshtml")]
    public partial class Views_Months_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Months>>
    {
        public Views_Months_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Months List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Months List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Months</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 558)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Months/ListFromQuery/?Clause=", 496), true)
                                                                  , Tuple.Create(Tuple.Create("", 526), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 526), false)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("&Ord=", 541), true)
                                                                                      , Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 546), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Month Name</th><th>From</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 853), Tuple.Create("\"", 893)
, Tuple.Create(Tuple.Create("", 860), Tuple.Create("/Months/Load/?RecId=", 860), true)
               , Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 880), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1143), Tuple.Create("\"", 1228)
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthName/?RecId=", 1154), true)
                                                                   , Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1204), false)
, Tuple.Create(Tuple.Create("", 1217), Tuple.Create("\',$(this));", 1217), true)
);
WriteLiteral(" data-bound-name=\'MthName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1286), Tuple.Create("\'", 1326)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1294), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthName.HTMLValue)
, 1294), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1541), Tuple.Create("\"", 1627)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthSDate/?RecId=", 1552), true)
                                                                                                , Tuple.Create(Tuple.Create("", 1603), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1603), false)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create("\',$(this));", 1616), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'MthSDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1736)
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthSDate.HTMLValue)
, 1703), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Edit_3.cshtml")]
    public partial class Views_Months_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Months/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Months</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Months/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Months" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Months", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1352), Tuple.Create("\'", 1374)
, Tuple.Create(Tuple.Create("", 1360), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1360), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1420), Tuple.Create("\'", 1444)
, Tuple.Create(Tuple.Create("", 1428), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1428), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Months\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.MthIdValue
, 1552), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1680), Tuple.Create("\"", 1703)
, Tuple.Create(Tuple.Create("", 1688), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1688), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Months/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Months/ViewHistory/?RecId=", 2007), true)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2034), false)
, Tuple.Create(Tuple.Create("", 2049), Tuple.Create("&dt=", 2049), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2053), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2692), Tuple.Create("\"", 2707)
, Tuple.Create(Tuple.Create("", 2699), Tuple.Create("#", 2699), true)
, Tuple.Create(Tuple.Create("", 2700), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2700), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2923), Tuple.Create("\"", 2935)
, Tuple.Create(Tuple.Create("", 2928), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2928), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_Add_3.cshtml")]
    public partial class Views_Months_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Months>
    {
        public Views_Months_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Months";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Months\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Months/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Months>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Months_List_3.cshtml")]
    public partial class Views_Months_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Months>>
    {
        public Views_Months_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Months List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Months List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Months</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Months/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 489), Tuple.Create("\"", 558)
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Months/ListFromQuery/?Clause=", 496), true)
                                                                  , Tuple.Create(Tuple.Create("", 526), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 526), false)
, Tuple.Create(Tuple.Create("", 541), Tuple.Create("&Ord=", 541), true)
                                                                                      , Tuple.Create(Tuple.Create("", 546), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 546), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Month Name</th><th>From</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 853), Tuple.Create("\"", 893)
, Tuple.Create(Tuple.Create("", 860), Tuple.Create("/Months/Load/?RecId=", 860), true)
               , Tuple.Create(Tuple.Create("", 880), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 880), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:67%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1143), Tuple.Create("\"", 1228)
, Tuple.Create(Tuple.Create("", 1154), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthName/?RecId=", 1154), true)
                                                                   , Tuple.Create(Tuple.Create("", 1204), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1204), false)
, Tuple.Create(Tuple.Create("", 1217), Tuple.Create("\',$(this));", 1217), true)
);
WriteLiteral(" data-bound-name=\'MthName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1286), Tuple.Create("\'", 1326)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1294), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthName.HTMLValue)
, 1294), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.MthSDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1541), Tuple.Create("\"", 1627)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create("javascript:IQAutoSave(\'/Months/SaveMthSDate/?RecId=", 1552), true)
                                                                                                , Tuple.Create(Tuple.Create("", 1603), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1603), false)
, Tuple.Create(Tuple.Create("", 1616), Tuple.Create("\',$(this));", 1616), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'MthSDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1695), Tuple.Create("\'", 1736)
                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1703), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.MthSDate.HTMLValue)
, 1703), false)
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
