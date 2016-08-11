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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_WordDocument.cshtml")]
    public partial class Views_WordDocument_WordDocument_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_WordDocument_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 68), Tuple.Create("\'", 136)
, Tuple.Create(Tuple.Create("", 76), Tuple.Create("IQLabel104711", 76), true)
, Tuple.Create(Tuple.Create(" ", 89), Tuple.Create<System.Object, System.Int32>(!Model.WrDocId.LabelVisible ? " hide " : ""
, 90), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 137), Tuple.Create("\'", 339)
      , Tuple.Create(Tuple.Create("", 146), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WrDocId.BackHEXColor) ? "" : "color:" + Model.WrDocId.BackHEXColor + ";"
, 146), false)
, Tuple.Create(Tuple.Create("", 248), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 248), true)
);
WriteLiteral(">Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'WordDocument_WrDocId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 422), Tuple.Create("\'", 486)
, Tuple.Create(Tuple.Create("", 430), Tuple.Create("form-control", 430), true)
, Tuple.Create(Tuple.Create("   ", 442), Tuple.Create<System.Object, System.Int32>(!Model.WrDocId.Visible ? " hide " : ""
, 445), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/WordDocument/CallbackWrDocId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWrDocId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.WrDocId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 867), Tuple.Create("\'", 941)
, Tuple.Create(Tuple.Create("", 875), Tuple.Create("IQLabel104712", 875), true)
                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 888), Tuple.Create<System.Object, System.Int32>(!Model.WrDocCategory.LabelVisible ? " hide " : ""
, 889), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 942), Tuple.Create("\'", 1157)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 951), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WrDocCategory.BackHEXColor) ? "" : "color:" + Model.WrDocCategory.BackHEXColor + ";"
, 951), false)
, Tuple.Create(Tuple.Create("", 1065), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1065), true)
);
WriteLiteral(">Category</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'WordDocument_WrDocCategory\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.WrDocCategory.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.WrDocCategory.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocCategory/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/WordDocument/CallbackWrDocCategory/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateWrDocCategory\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.WrDocCategory.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1792), Tuple.Create("\'", 1863)
, Tuple.Create(Tuple.Create("", 1800), Tuple.Create("IQLabel104713", 1800), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 1813), Tuple.Create<System.Object, System.Int32>(!Model.WrDocTitle.LabelVisible ? " hide " : ""
, 1814), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1864), Tuple.Create("\'", 2073)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 1873), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WrDocTitle.BackHEXColor) ? "" : "color:" + Model.WrDocTitle.BackHEXColor + ";"
, 1873), false)
, Tuple.Create(Tuple.Create("", 1981), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1981), true)
);
WriteLiteral(">Title</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Title\'");
WriteLiteral(" data-ScreenInfo=\'WordDocument_WrDocTitle\'");
WriteLiteral(" ");
                                                                                                                                                                                                           Write(Model.RecordLocked || !Model.WrDocTitle.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocTitle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/WordDocument/CallbackWrDocTitle/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(!Model.WrDocTitle.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateWrDocTitle\' style=\'height:21px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.PopulateWrDocTitle);
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
WriteLiteral(" data-target=\"*[name=PopulateWrDocTitle]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3263), Tuple.Create("\'", 3334)
, Tuple.Create(Tuple.Create("", 3271), Tuple.Create("IQLabel104714", 3271), true)
, Tuple.Create(Tuple.Create(" ", 3284), Tuple.Create<System.Object, System.Int32>(!Model.WrDocQuery.LabelVisible ? " hide " : ""
, 3285), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3335), Tuple.Create("\'", 3544)
                                , Tuple.Create(Tuple.Create("", 3344), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.WrDocQuery.BackHEXColor) ? "" : "color:" + Model.WrDocQuery.BackHEXColor + ";"
, 3344), false)
, Tuple.Create(Tuple.Create("", 3452), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3452), true)
);
WriteLiteral(">Query</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:78px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'WordDocument_WrDocQuery\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.WrDocQuery.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.WrDocQuery.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocQuery/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/WordDocument/CallbackWrDocQuery/',$(this));\""));
WriteLiteral("   name=\'PopulateWrDocQuery\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.WrDocQuery.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4233), Tuple.Create("\'", 4254)
, Tuple.Create(Tuple.Create("", 4241), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4241), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateWrDocQuery.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateWrDocQuery]\"");
WriteLiteral(" data-url=\"/Query/Load/?QryId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Query/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Query</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Edit_1.cshtml")]
    public partial class Views_WordDocument_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Edit_1_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/WordDocument/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Word Document</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 594), Tuple.Create("\'", 660)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("IQJSCall(\"/WordDocument/Delete/?RecId=", 604), true)
             , Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 642), false)
, Tuple.Create(Tuple.Create("", 657), Tuple.Create("\");", 657), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/WordDo" +
"cument/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("WordDocument", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1569), Tuple.Create("\'", 1591)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1637), Tuple.Create("\'", 1661)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"WordDocument\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1767), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create<System.Object, System.Int32>(Model.WrDocIdValue
, 1775), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1840), Tuple.Create("\"", 1863)
, Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1848), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1905), Tuple.Create("\"", 1928)
, Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1913), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/WordDocument/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2231), Tuple.Create("\"", 2337)
, Tuple.Create(Tuple.Create("", 2238), Tuple.Create("/WordDocument/ViewHistory/?RecId=", 2238), true)
, Tuple.Create(Tuple.Create("", 2271), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2271), false)
, Tuple.Create(Tuple.Create("", 2286), Tuple.Create("&dt=", 2286), true)
, Tuple.Create(Tuple.Create("", 2290), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2290), false)
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
WriteLiteral(" id=\"WordDocument\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/WordDocument_WordDocument.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 3133), Tuple.Create("\"", 3148)
, Tuple.Create(Tuple.Create("", 3140), Tuple.Create("#", 3140), true)
, Tuple.Create(Tuple.Create("", 3141), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3141), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3364), Tuple.Create("\"", 3376)
, Tuple.Create(Tuple.Create("", 3369), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3369), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Add_1.cshtml")]
    public partial class Views_WordDocument_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Word Document";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Word Document\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/WordDocument/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"WordDocument\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/WordDocument_WordDocument.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_List_1.cshtml")]
    public partial class Views_WordDocument_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.WordDocument>>
    {
        public Views_WordDocument_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Word Document List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Word Document List\"");
WriteLiteral("></noscript> \r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Word Document</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 702), Tuple.Create("\"", 777)
, Tuple.Create(Tuple.Create("", 709), Tuple.Create("/WordDocument/ListFromQuery/?Clause=", 709), true)
                                                                        , Tuple.Create(Tuple.Create("", 745), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 745), false)
, Tuple.Create(Tuple.Create("", 760), Tuple.Create("&Ord=", 760), true)
                                                                                            , Tuple.Create(Tuple.Create("", 765), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 765), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th><th>Category</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1085), Tuple.Create("\"", 1131)
, Tuple.Create(Tuple.Create("", 1092), Tuple.Create("/WordDocument/Load/?RecId=", 1092), true)
                    , Tuple.Create(Tuple.Create("", 1118), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1118), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:25%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1384), Tuple.Create("\"", 1478)
, Tuple.Create(Tuple.Create("", 1395), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocTitle/?RecId=", 1395), true)
                                                                            , Tuple.Create(Tuple.Create("", 1454), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1454), false)
, Tuple.Create(Tuple.Create("", 1467), Tuple.Create("\',$(this));", 1467), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocTitle\'");
WriteLiteral(">");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.WrDocTitle.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocCategory.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1764), Tuple.Create("\"", 1861)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocCategory/?RecId=", 1775), true)
                                                                               , Tuple.Create(Tuple.Create("", 1837), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1837), false)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("\',$(this));", 1850), true)
);
WriteLiteral(" data-bound-name=\'WrDocCategory\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1925), Tuple.Create("\'", 1971)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1933), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WrDocCategory.HTMLValue)
, 1933), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2158), Tuple.Create("\"", 2252)
, Tuple.Create(Tuple.Create("", 2169), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocQuery/?RecId=", 2169), true)
                                                                          , Tuple.Create(Tuple.Create("", 2228), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2228), false)
, Tuple.Create(Tuple.Create("", 2241), Tuple.Create("\',$(this));", 2241), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.WrDocQuery.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/DFPartial_WrDocTemplate.cshtml")]
    public partial class Views_DFPartial_WrDocTemplate_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_DFPartial_WrDocTemplate_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("\r\n\r\n");
     if(!string.IsNullOrEmpty(Model.WrDocTemplateValue)) {
         if(Model.WrDocTemplate.IsImage) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" data-toggle=\"modal\"");
WriteLiteral(" data-target=\"#ViewFilesFor-WrDocTemplateValue\"");
WriteLiteral(" class=\'btn btn-info btn-xs\'");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/file.png\"");
WriteLiteral(" style=\'max-height:15px;float:left;\'");
WriteLiteral(" />View Image</button>\r\n\t\t\r\n\t\t\t<div");
WriteLiteral(" class=\"modal fade\"");
WriteLiteral(" id=\'ViewFilesFor-WrDocTemplateValue\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\"modal-dialog\"");
WriteLiteral(" style=\'width:860px;\'");
WriteLiteral(">\r\n\t\t\t\t<div");
WriteLiteral(" class=\"modal-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-header\"");
WriteLiteral(">\r\n\t\t\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"close\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(" aria-label=\"Close\"");
WriteLiteral("><span");
WriteLiteral(" aria-hidden=\"true\"");
WriteLiteral(">&times;</span></button>\r\n\t\t\t\t\t<h4");
WriteLiteral(" class=\"modal-title\"");
WriteLiteral(">Template</h4>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-body\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<img");
WriteAttribute("src", Tuple.Create(" src=\"", 795), Tuple.Create("\"", 850)
, Tuple.Create(Tuple.Create("", 801), Tuple.Create<System.Object, System.Int32>(IQApp.Files.GetFileUrl(Model.WrDocTemplateValue)
, 801), false)
);
WriteLiteral(" style=\'max-width:800px;max-height:600px;\'");
WriteLiteral(" />\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"modal-footer\"");
WriteLiteral(">\r\n\t\t\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default\"");
WriteLiteral(" data-dismiss=\"modal\"");
WriteLiteral(">Close</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div><!-- /.modal-content -->\r\n\t\t\t\t</div><!-- " +
"/.modal-dialog -->\r\n\t\t\t</div><!-- /.modal -->\r\n\t\t\t");
WriteLiteral("\r\n");
			}else {
WriteLiteral("\t\t\t\t");
WriteLiteral("<a");
WriteAttribute("href", Tuple.Create(" href=\'", 1179), Tuple.Create("\'", 1235)
, Tuple.Create(Tuple.Create("", 1186), Tuple.Create<System.Object, System.Int32>(IQApp.Files.GetFileUrl(Model.WrDocTemplateValue)
, 1186), false)
);
WriteLiteral(" target=\'_blank\'");
WriteLiteral(" class=\'btn btn-info btn-xs\'");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/file.png\"");
WriteLiteral(" style=\'max-height:15px;float:left;\'");
WriteLiteral(" />View File</a>");
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t\t");
         if(!Model.RecordLocked) {
WriteLiteral("\t\t\t");
WriteLiteral("<button");
WriteLiteral(" onclick=\'ShowFilePicker(\"*[name=WrDocTemplateValue]\", false);\'");
WriteLiteral(" type=\'button\'");
WriteLiteral(" class=\'btn btn-primary btn-xs\'");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/file.png\"");
WriteLiteral(" style=\'max-height:15px;float:left;\'");
WriteLiteral(" />");
                                                                                                                                                                                                 Write(string.IsNullOrEmpty(Model.WrDocTemplateValue) ? "Add " : "Change ");
WriteLiteral(" File</a>");
WriteLiteral("</text>\r\n");
		}
WriteLiteral("\t\r\n");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Edit_2.cshtml")]
    public partial class Views_WordDocument_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Edit_2_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/WordDocument/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Word Document</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 594), Tuple.Create("\'", 660)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("IQJSCall(\"/WordDocument/Delete/?RecId=", 604), true)
             , Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 642), false)
, Tuple.Create(Tuple.Create("", 657), Tuple.Create("\");", 657), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/WordDo" +
"cument/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("WordDocument", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1569), Tuple.Create("\'", 1591)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1637), Tuple.Create("\'", 1661)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"WordDocument\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1767), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create<System.Object, System.Int32>(Model.WrDocIdValue
, 1775), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1840), Tuple.Create("\"", 1863)
, Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1848), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1905), Tuple.Create("\"", 1928)
, Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1913), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/WordDocument/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2231), Tuple.Create("\"", 2337)
, Tuple.Create(Tuple.Create("", 2238), Tuple.Create("/WordDocument/ViewHistory/?RecId=", 2238), true)
, Tuple.Create(Tuple.Create("", 2271), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2271), false)
, Tuple.Create(Tuple.Create("", 2286), Tuple.Create("&dt=", 2286), true)
, Tuple.Create(Tuple.Create("", 2290), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2290), false)
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
WriteLiteral(" id=\"WordDocument\"");
WriteLiteral(" style=\'position:relative;height:129px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/WordDocument_WordDocument.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 3133), Tuple.Create("\"", 3148)
, Tuple.Create(Tuple.Create("", 3140), Tuple.Create("#", 3140), true)
, Tuple.Create(Tuple.Create("", 3141), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3141), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3364), Tuple.Create("\"", 3376)
, Tuple.Create(Tuple.Create("", 3369), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3369), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Add_2.cshtml")]
    public partial class Views_WordDocument_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Word Document";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Word Document\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/WordDocument/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"WordDocument\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/WordDocument_WordDocument.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_List_2.cshtml")]
    public partial class Views_WordDocument_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.WordDocument>>
    {
        public Views_WordDocument_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Word Document List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Word Document List\"");
WriteLiteral("></noscript> \r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Word Document</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 702), Tuple.Create("\"", 777)
, Tuple.Create(Tuple.Create("", 709), Tuple.Create("/WordDocument/ListFromQuery/?Clause=", 709), true)
                                                                        , Tuple.Create(Tuple.Create("", 745), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 745), false)
, Tuple.Create(Tuple.Create("", 760), Tuple.Create("&Ord=", 760), true)
                                                                                            , Tuple.Create(Tuple.Create("", 765), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 765), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th><th>Category</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1085), Tuple.Create("\"", 1131)
, Tuple.Create(Tuple.Create("", 1092), Tuple.Create("/WordDocument/Load/?RecId=", 1092), true)
                    , Tuple.Create(Tuple.Create("", 1118), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1118), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:25%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1384), Tuple.Create("\"", 1478)
, Tuple.Create(Tuple.Create("", 1395), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocTitle/?RecId=", 1395), true)
                                                                            , Tuple.Create(Tuple.Create("", 1454), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1454), false)
, Tuple.Create(Tuple.Create("", 1467), Tuple.Create("\',$(this));", 1467), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocTitle\'");
WriteLiteral(">");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.WrDocTitle.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocCategory.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1764), Tuple.Create("\"", 1861)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocCategory/?RecId=", 1775), true)
                                                                               , Tuple.Create(Tuple.Create("", 1837), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1837), false)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("\',$(this));", 1850), true)
);
WriteLiteral(" data-bound-name=\'WrDocCategory\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1925), Tuple.Create("\'", 1971)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1933), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WrDocCategory.HTMLValue)
, 1933), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2158), Tuple.Create("\"", 2252)
, Tuple.Create(Tuple.Create("", 2169), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocQuery/?RecId=", 2169), true)
                                                                          , Tuple.Create(Tuple.Create("", 2228), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2228), false)
, Tuple.Create(Tuple.Create("", 2241), Tuple.Create("\',$(this));", 2241), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.WrDocQuery.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Edit_3.cshtml")]
    public partial class Views_WordDocument_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Edit_3_cshtml()
        {
        }
        public override void Execute()
        {
ViewBag.Title = @Model.DataTitle;
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"");
                 Write(Model.DataTitle);
WriteLiteral("\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n");
 if(ViewBag.HistoryView != true) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
WriteLiteral(" href=\"/WordDocument/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Word Document</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 594), Tuple.Create("\'", 660)
, Tuple.Create(Tuple.Create("", 604), Tuple.Create("IQJSCall(\"/WordDocument/Delete/?RecId=", 604), true)
             , Tuple.Create(Tuple.Create("", 642), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 642), false)
, Tuple.Create(Tuple.Create("", 657), Tuple.Create("\");", 657), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/WordDo" +
"cument/ViewHistory/?RecId=");
                                                                                                         Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("WordDocument", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1569), Tuple.Create("\'", 1591)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1637), Tuple.Create("\'", 1661)
, Tuple.Create(Tuple.Create("", 1645), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1645), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"WordDocument\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1767), Tuple.Create("\"", 1794)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create<System.Object, System.Int32>(Model.WrDocIdValue
, 1775), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1840), Tuple.Create("\"", 1863)
, Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1848), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1905), Tuple.Create("\"", 1928)
, Tuple.Create(Tuple.Create("", 1913), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1913), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/WordDocument/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2231), Tuple.Create("\"", 2337)
, Tuple.Create(Tuple.Create("", 2238), Tuple.Create("/WordDocument/ViewHistory/?RecId=", 2238), true)
, Tuple.Create(Tuple.Create("", 2271), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2271), false)
, Tuple.Create(Tuple.Create("", 2286), Tuple.Create("&dt=", 2286), true)
, Tuple.Create(Tuple.Create("", 2290), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2290), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2929), Tuple.Create("\"", 2944)
, Tuple.Create(Tuple.Create("", 2936), Tuple.Create("#", 2936), true)
, Tuple.Create(Tuple.Create("", 2937), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2937), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3160), Tuple.Create("\"", 3172)
, Tuple.Create(Tuple.Create("", 3165), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3165), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_Add_3.cshtml")]
    public partial class Views_WordDocument_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.WordDocument>
    {
        public Views_WordDocument_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Word Document";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Word Document\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/WordDocument/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<WordDocument>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/WordDocument_List_3.cshtml")]
    public partial class Views_WordDocument_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.WordDocument>>
    {
        public Views_WordDocument_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Word Document List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Word Document List\"");
WriteLiteral("></noscript> \r\n<div");
WriteLiteral(" class=\'alert alert-danger\'");
WriteLiteral(">Word Document is used by the system, changing this data may affect your system, " +
"be sure you know what you are doing before proceeding!</div>\r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Word Document</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/WordDocument/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 702), Tuple.Create("\"", 777)
, Tuple.Create(Tuple.Create("", 709), Tuple.Create("/WordDocument/ListFromQuery/?Clause=", 709), true)
                                                                        , Tuple.Create(Tuple.Create("", 745), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 745), false)
, Tuple.Create(Tuple.Create("", 760), Tuple.Create("&Ord=", 760), true)
                                                                                            , Tuple.Create(Tuple.Create("", 765), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 765), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                             Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th><th>Category</th><th>Query</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1085), Tuple.Create("\"", 1131)
, Tuple.Create(Tuple.Create("", 1092), Tuple.Create("/WordDocument/Load/?RecId=", 1092), true)
                    , Tuple.Create(Tuple.Create("", 1118), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1118), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:25%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1384), Tuple.Create("\"", 1478)
, Tuple.Create(Tuple.Create("", 1395), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocTitle/?RecId=", 1395), true)
                                                                            , Tuple.Create(Tuple.Create("", 1454), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1454), false)
, Tuple.Create(Tuple.Create("", 1467), Tuple.Create("\',$(this));", 1467), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocTitle\'");
WriteLiteral(">");
                                                                                                                                                                                                                                   Write(Html.Raw(itm.WrDocTitle.HTMLValue));
WriteLiteral("</textarea></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocCategory.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1764), Tuple.Create("\"", 1861)
, Tuple.Create(Tuple.Create("", 1775), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocCategory/?RecId=", 1775), true)
                                                                               , Tuple.Create(Tuple.Create("", 1837), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1837), false)
, Tuple.Create(Tuple.Create("", 1850), Tuple.Create("\',$(this));", 1850), true)
);
WriteLiteral(" data-bound-name=\'WrDocCategory\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1925), Tuple.Create("\'", 1971)
                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1933), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.WrDocCategory.HTMLValue)
, 1933), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.WrDocQuery.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:62%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2158), Tuple.Create("\"", 2252)
, Tuple.Create(Tuple.Create("", 2169), Tuple.Create("javascript:IQAutoSave(\'/WordDocument/SaveWrDocQuery/?RecId=", 2169), true)
                                                                          , Tuple.Create(Tuple.Create("", 2228), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2228), false)
, Tuple.Create(Tuple.Create("", 2241), Tuple.Create("\',$(this));", 2241), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'WrDocQuery\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                  Write(Html.Raw(itm.WrDocQuery.HTMLValue));
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
