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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_InvoiceComments.cshtml")]
    public partial class Views_InvComment_InvoiceComments_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_InvoiceComments_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 66), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 74), Tuple.Create("IQLabel101311", 74), true)
, Tuple.Create(Tuple.Create(" ", 87), Tuple.Create<System.Object, System.Int32>(!Model.InvCId.LabelVisible ? " hide " : ""
, 88), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 334)
     , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvCId.BackHEXColor) ? "" : "color:" + Model.InvCId.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 243), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 243), true)
);
WriteLiteral(">Inv Comment ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'InvoiceComments_InvCId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 431), Tuple.Create("\'", 494)
, Tuple.Create(Tuple.Create("", 439), Tuple.Create("form-control", 439), true)
, Tuple.Create(Tuple.Create("   ", 451), Tuple.Create<System.Object, System.Int32>(!Model.InvCId.Visible ? " hide " : ""
, 454), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvComment/SaveInvCId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvComment/CallbackInvCId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateInvCId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.InvCId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 867), Tuple.Create("\'", 936)
, Tuple.Create(Tuple.Create("", 875), Tuple.Create("IQLabel101312", 875), true)
                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 888), Tuple.Create<System.Object, System.Int32>(!Model.InvCName.LabelVisible ? " hide " : ""
, 889), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 937), Tuple.Create("\'", 1142)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 946), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.InvCName.BackHEXColor) ? "" : "color:" + Model.InvCName.BackHEXColor + ";"
, 946), false)
, Tuple.Create(Tuple.Create("", 1050), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1050), true)
);
WriteLiteral(">Inv Comment</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:71px;width:400px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Inv Comment\'");
WriteLiteral(" data-ScreenInfo=\'InvoiceComments_InvCName\'");
WriteLiteral(" ");
                                                                                                                                                                                                                  Write(Model.RecordLocked || !Model.InvCName.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/InvComment/SaveInvCName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/InvComment/CallbackInvCName/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(!Model.InvCName.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateInvCName\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.PopulateInvCName);
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
WriteLiteral(" data-target=\"*[name=PopulateInvCName]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Edit_1.cshtml")]
    public partial class Views_InvComment_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Edit_1_cshtml()
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
WriteLiteral(" href=\"/InvComment/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoice Comments</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 419), Tuple.Create("\'", 483)
, Tuple.Create(Tuple.Create("", 429), Tuple.Create("IQJSCall(\"/InvComment/Delete/?RecId=", 429), true)
           , Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 465), false)
, Tuple.Create(Tuple.Create("", 480), Tuple.Create("\");", 480), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvCom" +
"ment/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvComment", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1386), Tuple.Create("\'", 1408)
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1394), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1454), Tuple.Create("\'", 1478)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1462), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvComment\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1582), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1590), Tuple.Create<System.Object, System.Int32>(Model.InvCIdValue
, 1590), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1654), Tuple.Create("\"", 1677)
, Tuple.Create(Tuple.Create("", 1662), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1662), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1719), Tuple.Create("\"", 1742)
, Tuple.Create(Tuple.Create("", 1727), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1727), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvComment/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2043), Tuple.Create("\"", 2147)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("/InvComment/ViewHistory/?RecId=", 2050), true)
, Tuple.Create(Tuple.Create("", 2081), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2081), false)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create("&dt=", 2096), true)
, Tuple.Create(Tuple.Create("", 2100), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2100), false)
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
WriteLiteral(" id=\"InvoiceComments\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvComment_InvoiceComments.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2947), Tuple.Create("\"", 2962)
, Tuple.Create(Tuple.Create("", 2954), Tuple.Create("#", 2954), true)
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2955), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3178), Tuple.Create("\"", 3190)
, Tuple.Create(Tuple.Create("", 3183), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3183), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Add_1.cshtml")]
    public partial class Views_InvComment_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Comments";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Comments\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvComment/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceComments\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvComment_InvoiceComments.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_List_1.cshtml")]
    public partial class Views_InvComment_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvComment>>
    {
        public Views_InvComment_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Comments List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Comments List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Comments</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 604)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/InvComment/ListFromQuery/?Clause=", 538), true)
                                                                      , Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 572), false)
, Tuple.Create(Tuple.Create("", 587), Tuple.Create("&Ord=", 587), true)
                                                                                          , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 592), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Inv Comment ID</th><th>Inv Comment</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/InvComment/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvCId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvCName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:83%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1262), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1273), Tuple.Create("javascript:IQAutoSave(\'/InvComment/SaveInvCName/?RecId=", 1273), true)
                                                                        , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvCName\'");
WriteLiteral(">");
                                                                                                                                                                                                                             Write(Html.Raw(itm.InvCName.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Edit_2.cshtml")]
    public partial class Views_InvComment_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Edit_2_cshtml()
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
WriteLiteral(" href=\"/InvComment/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoice Comments</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 419), Tuple.Create("\'", 483)
, Tuple.Create(Tuple.Create("", 429), Tuple.Create("IQJSCall(\"/InvComment/Delete/?RecId=", 429), true)
           , Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 465), false)
, Tuple.Create(Tuple.Create("", 480), Tuple.Create("\");", 480), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvCom" +
"ment/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvComment", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1386), Tuple.Create("\'", 1408)
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1394), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1454), Tuple.Create("\'", 1478)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1462), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvComment\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1582), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1590), Tuple.Create<System.Object, System.Int32>(Model.InvCIdValue
, 1590), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1654), Tuple.Create("\"", 1677)
, Tuple.Create(Tuple.Create("", 1662), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1662), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1719), Tuple.Create("\"", 1742)
, Tuple.Create(Tuple.Create("", 1727), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1727), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvComment/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2043), Tuple.Create("\"", 2147)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("/InvComment/ViewHistory/?RecId=", 2050), true)
, Tuple.Create(Tuple.Create("", 2081), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2081), false)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create("&dt=", 2096), true)
, Tuple.Create(Tuple.Create("", 2100), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2100), false)
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
WriteLiteral(" id=\"InvoiceComments\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvComment_InvoiceComments.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2947), Tuple.Create("\"", 2962)
, Tuple.Create(Tuple.Create("", 2954), Tuple.Create("#", 2954), true)
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2955), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3178), Tuple.Create("\"", 3190)
, Tuple.Create(Tuple.Create("", 3183), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3183), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Add_2.cshtml")]
    public partial class Views_InvComment_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Comments";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Comments\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvComment/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"InvoiceComments\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/InvComment_InvoiceComments.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_List_2.cshtml")]
    public partial class Views_InvComment_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvComment>>
    {
        public Views_InvComment_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Comments List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Comments List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Comments</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 604)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/InvComment/ListFromQuery/?Clause=", 538), true)
                                                                      , Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 572), false)
, Tuple.Create(Tuple.Create("", 587), Tuple.Create("&Ord=", 587), true)
                                                                                          , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 592), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Inv Comment ID</th><th>Inv Comment</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/InvComment/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvCId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvCName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:83%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1262), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1273), Tuple.Create("javascript:IQAutoSave(\'/InvComment/SaveInvCName/?RecId=", 1273), true)
                                                                        , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvCName\'");
WriteLiteral(">");
                                                                                                                                                                                                                             Write(Html.Raw(itm.InvCName.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Edit_3.cshtml")]
    public partial class Views_InvComment_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Edit_3_cshtml()
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
WriteLiteral(" href=\"/InvComment/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Invoice Comments</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 419), Tuple.Create("\'", 483)
, Tuple.Create(Tuple.Create("", 429), Tuple.Create("IQJSCall(\"/InvComment/Delete/?RecId=", 429), true)
           , Tuple.Create(Tuple.Create("", 465), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 465), false)
, Tuple.Create(Tuple.Create("", 480), Tuple.Create("\");", 480), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/InvCom" +
"ment/ViewHistory/?RecId=");
                                                                                                       Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("InvComment", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1386), Tuple.Create("\'", 1408)
, Tuple.Create(Tuple.Create("", 1394), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1394), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1454), Tuple.Create("\'", 1478)
, Tuple.Create(Tuple.Create("", 1462), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1462), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"InvComment\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1582), Tuple.Create("\"", 1608)
, Tuple.Create(Tuple.Create("", 1590), Tuple.Create<System.Object, System.Int32>(Model.InvCIdValue
, 1590), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1654), Tuple.Create("\"", 1677)
, Tuple.Create(Tuple.Create("", 1662), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1662), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1719), Tuple.Create("\"", 1742)
, Tuple.Create(Tuple.Create("", 1727), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1727), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/InvComment/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2043), Tuple.Create("\"", 2147)
, Tuple.Create(Tuple.Create("", 2050), Tuple.Create("/InvComment/ViewHistory/?RecId=", 2050), true)
, Tuple.Create(Tuple.Create("", 2081), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2081), false)
, Tuple.Create(Tuple.Create("", 2096), Tuple.Create("&dt=", 2096), true)
, Tuple.Create(Tuple.Create("", 2100), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2100), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2739), Tuple.Create("\"", 2754)
, Tuple.Create(Tuple.Create("", 2746), Tuple.Create("#", 2746), true)
, Tuple.Create(Tuple.Create("", 2747), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2747), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2970), Tuple.Create("\"", 2982)
, Tuple.Create(Tuple.Create("", 2975), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2975), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_Add_3.cshtml")]
    public partial class Views_InvComment_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.InvComment>
    {
        public Views_InvComment_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Invoice Comments";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Invoice Comments\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/InvComment/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<InvComment>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/InvComment_List_3.cshtml")]
    public partial class Views_InvComment_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.InvComment>>
    {
        public Views_InvComment_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Invoice Comments List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Invoice Comments List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Invoice Comments</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/InvComment/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 604)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/InvComment/ListFromQuery/?Clause=", 538), true)
                                                                      , Tuple.Create(Tuple.Create("", 572), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 572), false)
, Tuple.Create(Tuple.Create("", 587), Tuple.Create("&Ord=", 587), true)
                                                                                          , Tuple.Create(Tuple.Create("", 592), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 592), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                           Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Inv Comment ID</th><th>Inv Comment</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 910), Tuple.Create("\"", 954)
, Tuple.Create(Tuple.Create("", 917), Tuple.Create("/InvComment/Load/?RecId=", 917), true)
                   , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 941), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.InvCId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.InvCName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:83%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1262), Tuple.Create("\"", 1352)
, Tuple.Create(Tuple.Create("", 1273), Tuple.Create("javascript:IQAutoSave(\'/InvComment/SaveInvCName/?RecId=", 1273), true)
                                                                        , Tuple.Create(Tuple.Create("", 1328), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1328), false)
, Tuple.Create(Tuple.Create("", 1341), Tuple.Create("\',$(this));", 1341), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'InvCName\'");
WriteLiteral(">");
                                                                                                                                                                                                                             Write(Html.Raw(itm.InvCName.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
