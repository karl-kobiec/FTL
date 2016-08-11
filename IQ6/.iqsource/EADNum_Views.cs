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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_eADNumbers.cshtml")]
    public partial class Views_EADNum_eADNumbers_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_eADNumbers_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 62), Tuple.Create("\'", 131)
, Tuple.Create(Tuple.Create("", 70), Tuple.Create("IQLabel103111", 70), true)
, Tuple.Create(Tuple.Create(" ", 83), Tuple.Create<System.Object, System.Int32>(!Model.EADOrder.LabelVisible ? " hide " : ""
, 84), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 132), Tuple.Create("\'", 336)
       , Tuple.Create(Tuple.Create("", 141), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EADOrder.BackHEXColor) ? "" : "color:" + Model.EADOrder.BackHEXColor + ";"
, 141), false)
, Tuple.Create(Tuple.Create("", 245), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 245), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'eADNumbers_EADOrder\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 428), Tuple.Create("\'", 493)
, Tuple.Create(Tuple.Create("", 436), Tuple.Create("form-control", 436), true)
, Tuple.Create(Tuple.Create("   ", 448), Tuple.Create<System.Object, System.Int32>(!Model.EADOrder.Visible ? " hide " : ""
, 451), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EADNum/SaveEADOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EADNum/CallbackEADOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEADOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.EADOrder.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 866), Tuple.Create("\'", 932)
, Tuple.Create(Tuple.Create("", 874), Tuple.Create("IQLabel103112", 874), true)
                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 887), Tuple.Create<System.Object, System.Int32>(!Model.EADNo.LabelVisible ? " hide " : ""
, 888), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 933), Tuple.Create("\'", 1132)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 942), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.EADNo.BackHEXColor) ? "" : "color:" + Model.EADNo.BackHEXColor + ";"
, 942), false)
, Tuple.Create(Tuple.Create("", 1040), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1040), true)
);
WriteLiteral(">eAD Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'eADNumbers_EADNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.EADNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                            Write(!Model.EADNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/EADNum/SaveEADNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/EADNum/CallbackEADNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateEADNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.EADNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:28px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Edit_1.cshtml")]
    public partial class Views_EADNum_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Edit_1_cshtml()
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
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/EADNum/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EADNum" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EADNum", Model.RecordID.Value))
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
WriteLiteral(" value=\"EADNum\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1504)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.EADOrderValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1550), Tuple.Create("\"", 1573)
, Tuple.Create(Tuple.Create("", 1558), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1558), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EADNum/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1935), Tuple.Create("\"", 2035)
, Tuple.Create(Tuple.Create("", 1942), Tuple.Create("/EADNum/ViewHistory/?RecId=", 1942), true)
, Tuple.Create(Tuple.Create("", 1969), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1969), false)
, Tuple.Create(Tuple.Create("", 1984), Tuple.Create("&dt=", 1984), true)
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1988), false)
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
WriteLiteral(" id=\"eADNumbers\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EADNum_eADNumbers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2820), Tuple.Create("\"", 2835)
, Tuple.Create(Tuple.Create("", 2827), Tuple.Create("#", 2827), true)
, Tuple.Create(Tuple.Create("", 2828), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2828), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3051), Tuple.Create("\"", 3063)
, Tuple.Create(Tuple.Create("", 3056), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3056), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Add_1.cshtml")]
    public partial class Views_EADNum_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EADNum/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"eADNumbers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EADNum_eADNumbers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_List_1.cshtml")]
    public partial class Views_EADNum_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EADNum>>
    {
        public Views_EADNum_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 573)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/EADNum/ListFromQuery/?Clause=", 511), true)
                                                                  , Tuple.Create(Tuple.Create("", 541), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 541), false)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("&Ord=", 556), true)
                                                                                      , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 561), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>eAD Number</th><th>Order Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 876), Tuple.Create("\"", 916)
, Tuple.Create(Tuple.Create("", 883), Tuple.Create("/EADNum/Load/?RecId=", 883), true)
               , Tuple.Create(Tuple.Create("", 903), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 903), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EADNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1164), Tuple.Create("\"", 1247)
, Tuple.Create(Tuple.Create("", 1175), Tuple.Create("javascript:IQAutoSave(\'/EADNum/SaveEADNo/?RecId=", 1175), true)
                                                                 , Tuple.Create(Tuple.Create("", 1223), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1223), false)
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create("\',$(this));", 1236), true)
);
WriteLiteral(" data-bound-name=\'EADNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1303), Tuple.Create("\'", 1341)
                                                                                                                                                         , Tuple.Create(Tuple.Create("", 1311), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EADNo.HTMLValue)
, 1311), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EADOrder.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Edit_2.cshtml")]
    public partial class Views_EADNum_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Edit_2_cshtml()
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
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/EADNum/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EADNum" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EADNum", Model.RecordID.Value))
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
WriteLiteral(" value=\"EADNum\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1504)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.EADOrderValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1550), Tuple.Create("\"", 1573)
, Tuple.Create(Tuple.Create("", 1558), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1558), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EADNum/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1935), Tuple.Create("\"", 2035)
, Tuple.Create(Tuple.Create("", 1942), Tuple.Create("/EADNum/ViewHistory/?RecId=", 1942), true)
, Tuple.Create(Tuple.Create("", 1969), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1969), false)
, Tuple.Create(Tuple.Create("", 1984), Tuple.Create("&dt=", 1984), true)
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1988), false)
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
WriteLiteral(" id=\"eADNumbers\"");
WriteLiteral(" style=\'position:relative;height:79px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EADNum_eADNumbers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2820), Tuple.Create("\"", 2835)
, Tuple.Create(Tuple.Create("", 2827), Tuple.Create("#", 2827), true)
, Tuple.Create(Tuple.Create("", 2828), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2828), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3051), Tuple.Create("\"", 3063)
, Tuple.Create(Tuple.Create("", 3056), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3056), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Add_2.cshtml")]
    public partial class Views_EADNum_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EADNum/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"eADNumbers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/EADNum_eADNumbers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_List_2.cshtml")]
    public partial class Views_EADNum_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EADNum>>
    {
        public Views_EADNum_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 573)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/EADNum/ListFromQuery/?Clause=", 511), true)
                                                                  , Tuple.Create(Tuple.Create("", 541), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 541), false)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("&Ord=", 556), true)
                                                                                      , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 561), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>eAD Number</th><th>Order Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 876), Tuple.Create("\"", 916)
, Tuple.Create(Tuple.Create("", 883), Tuple.Create("/EADNum/Load/?RecId=", 883), true)
               , Tuple.Create(Tuple.Create("", 903), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 903), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EADNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1164), Tuple.Create("\"", 1247)
, Tuple.Create(Tuple.Create("", 1175), Tuple.Create("javascript:IQAutoSave(\'/EADNum/SaveEADNo/?RecId=", 1175), true)
                                                                 , Tuple.Create(Tuple.Create("", 1223), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1223), false)
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create("\',$(this));", 1236), true)
);
WriteLiteral(" data-bound-name=\'EADNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1303), Tuple.Create("\'", 1341)
                                                                                                                                                         , Tuple.Create(Tuple.Create("", 1311), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EADNo.HTMLValue)
, 1311), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EADOrder.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Edit_3.cshtml")]
    public partial class Views_EADNum_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Edit_3_cshtml()
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
, Tuple.Create(Tuple.Create("", 343), Tuple.Create("IQJSCall(\"/EADNum/Delete/?RecId=", 343), true)
       , Tuple.Create(Tuple.Create("", 375), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 375), false)
, Tuple.Create(Tuple.Create("", 390), Tuple.Create("\");", 390), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/EADNum" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("EADNum", Model.RecordID.Value))
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
WriteLiteral(" value=\"EADNum\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1476), Tuple.Create("\"", 1504)
, Tuple.Create(Tuple.Create("", 1484), Tuple.Create<System.Object, System.Int32>(Model.EADOrderValue
, 1484), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1550), Tuple.Create("\"", 1573)
, Tuple.Create(Tuple.Create("", 1558), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1558), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1615), Tuple.Create("\"", 1638)
, Tuple.Create(Tuple.Create("", 1623), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1623), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/EADNum/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1935), Tuple.Create("\"", 2035)
, Tuple.Create(Tuple.Create("", 1942), Tuple.Create("/EADNum/ViewHistory/?RecId=", 1942), true)
, Tuple.Create(Tuple.Create("", 1969), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1969), false)
, Tuple.Create(Tuple.Create("", 1984), Tuple.Create("&dt=", 1984), true)
, Tuple.Create(Tuple.Create("", 1988), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1988), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2627), Tuple.Create("\"", 2642)
, Tuple.Create(Tuple.Create("", 2634), Tuple.Create("#", 2634), true)
, Tuple.Create(Tuple.Create("", 2635), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2635), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2858), Tuple.Create("\"", 2870)
, Tuple.Create(Tuple.Create("", 2863), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2863), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_Add_3.cshtml")]
    public partial class Views_EADNum_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.EADNum>
    {
        public Views_EADNum_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add eAD Numbers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add eAD Numbers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/EADNum/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<EADNum>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/EADNum_List_3.cshtml")]
    public partial class Views_EADNum_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.EADNum>>
    {
        public Views_EADNum_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "eAD Numbers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"eAD Numbers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add eAD Numbers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/EADNum/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 573)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/EADNum/ListFromQuery/?Clause=", 511), true)
                                                                  , Tuple.Create(Tuple.Create("", 541), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 541), false)
, Tuple.Create(Tuple.Create("", 556), Tuple.Create("&Ord=", 556), true)
                                                                                      , Tuple.Create(Tuple.Create("", 561), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 561), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                       Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>eAD Number</th><th>Order Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 876), Tuple.Create("\"", 916)
, Tuple.Create(Tuple.Create("", 883), Tuple.Create("/EADNum/Load/?RecId=", 883), true)
               , Tuple.Create(Tuple.Create("", 903), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 903), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.EADNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:71%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1164), Tuple.Create("\"", 1247)
, Tuple.Create(Tuple.Create("", 1175), Tuple.Create("javascript:IQAutoSave(\'/EADNum/SaveEADNo/?RecId=", 1175), true)
                                                                 , Tuple.Create(Tuple.Create("", 1223), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1223), false)
, Tuple.Create(Tuple.Create("", 1236), Tuple.Create("\',$(this));", 1236), true)
);
WriteLiteral(" data-bound-name=\'EADNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1303), Tuple.Create("\'", 1341)
                                                                                                                                                         , Tuple.Create(Tuple.Create("", 1311), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.EADNo.HTMLValue)
, 1311), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.EADOrder.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
