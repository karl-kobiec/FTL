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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_REDSTaxCodes.cshtml")]
    public partial class Views_REDSTax_REDSTaxCodes_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_REDSTaxCodes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 131)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel103811", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 132), Tuple.Create("\'", 334)
      , Tuple.Create(Tuple.Create("", 141), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDTaxId.BackHEXColor) ? "" : "color:" + Model.RDTaxId.BackHEXColor + ";"
, 141), false)
, Tuple.Create(Tuple.Create("", 243), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:140p" +
"x;top:3px;", 243), true)
);
WriteLiteral(">Tax Code Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSTaxCodes_RDTaxId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 426), Tuple.Create("\'", 490)
, Tuple.Create(Tuple.Create("", 434), Tuple.Create("form-control", 434), true)
, Tuple.Create(Tuple.Create("   ", 446), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxId.Visible ? " hide " : ""
, 449), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSTax/CallbackRDTaxId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDTaxId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDTaxId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:150px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 861), Tuple.Create("\'", 931)
, Tuple.Create(Tuple.Create("", 869), Tuple.Create("IQLabel103812", 869), true)
                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 882), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxCode.LabelVisible ? " hide " : ""
, 883), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 932), Tuple.Create("\'", 1139)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 941), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDTaxCode.BackHEXColor) ? "" : "color:" + Model.RDTaxCode.BackHEXColor + ";"
, 941), false)
, Tuple.Create(Tuple.Create("", 1047), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:140p" +
"x;top:28px;", 1047), true)
);
WriteLiteral(">Tax Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSTaxCodes_RDTaxCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDTaxCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                                Write(!Model.RDTaxCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSTax/CallbackRDTaxCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDTaxCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.RDTaxCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:150px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1745), Tuple.Create("\'", 1815)
, Tuple.Create(Tuple.Create("", 1753), Tuple.Create("IQLabel103813", 1753), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 1766), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxType.LabelVisible ? " hide " : ""
, 1767), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1816), Tuple.Create("\'", 2023)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1825), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDTaxType.BackHEXColor) ? "" : "color:" + Model.RDTaxType.BackHEXColor + ";"
, 1825), false)
, Tuple.Create(Tuple.Create("", 1931), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:140p" +
"x;top:53px;", 1931), true)
);
WriteLiteral(">Type</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSTaxCodes_RDTaxType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDTaxType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.RDTaxType.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSTax/CallbackRDTaxType/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDTaxType\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.RDTaxType.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:150px;height:21px;width:50px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2615), Tuple.Create("\'", 2687)
, Tuple.Create(Tuple.Create("", 2623), Tuple.Create("IQLabel103814", 2623), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 2636), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxAlcPct.LabelVisible ? " hide " : ""
, 2637), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2688), Tuple.Create("\'", 2899)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2697), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDTaxAlcPct.BackHEXColor) ? "" : "color:" + Model.RDTaxAlcPct.BackHEXColor + ";"
, 2697), false)
, Tuple.Create(Tuple.Create("", 2807), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:140p" +
"x;top:78px;", 2807), true)
);
WriteLiteral(">Alcohol Percentage</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSTaxCodes_RDTaxAlcPct\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3002), Tuple.Create("\'", 3070)
, Tuple.Create(Tuple.Create("", 3010), Tuple.Create("form-control", 3010), true)
, Tuple.Create(Tuple.Create("   ", 3022), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxAlcPct.Visible ? " hide " : ""
, 3025), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxAlcPct/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSTax/CallbackRDTaxAlcPct/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDTaxAlcPct\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDTaxAlcPct.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:150px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3458), Tuple.Create("\'", 3532)
, Tuple.Create(Tuple.Create("", 3466), Tuple.Create("IQLabel103815", 3466), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 3479), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxDutyRate.LabelVisible ? " hide " : ""
, 3480), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3533), Tuple.Create("\'", 3749)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 3542), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDTaxDutyRate.BackHEXColor) ? "" : "color:" + Model.RDTaxDutyRate.BackHEXColor + ";"
, 3542), false)
, Tuple.Create(Tuple.Create("", 3656), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:140p" +
"x;top:103px;", 3656), true)
);
WriteLiteral(">Duty Rate Â£ per ltr</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSTaxCodes_RDTaxDutyRate\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3856), Tuple.Create("\'", 3926)
, Tuple.Create(Tuple.Create("", 3864), Tuple.Create("form-control", 3864), true)
, Tuple.Create(Tuple.Create("   ", 3876), Tuple.Create<System.Object, System.Int32>(!Model.RDTaxDutyRate.Visible ? " hide " : ""
, 3879), false)
);
WriteLiteral(" ");
                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxDutyRate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSTax/CallbackRDTaxDutyRate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDTaxDutyRate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.RDTaxDutyRate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:150px;height:21px;width:80px;top:103px;\'/>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Edit_1.cshtml")]
    public partial class Views_REDSTax_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Edit_1_cshtml()
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
WriteLiteral(" href=\"/REDSTax/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Tax Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 411), Tuple.Create("\'", 472)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("IQJSCall(\"/REDSTax/Delete/?RecId=", 421), true)
        , Tuple.Create(Tuple.Create("", 454), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 454), false)
, Tuple.Create(Tuple.Create("", 469), Tuple.Create("\");", 469), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSTa" +
"x/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSTax", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1366), Tuple.Create("\'", 1388)
, Tuple.Create(Tuple.Create("", 1374), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1374), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1434), Tuple.Create("\'", 1458)
, Tuple.Create(Tuple.Create("", 1442), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1442), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSTax\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1559), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1567), Tuple.Create<System.Object, System.Int32>(Model.RDTaxIdValue
, 1567), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSTax/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2018), Tuple.Create("\"", 2119)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create("/REDSTax/ViewHistory/?RecId=", 2025), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2068), Tuple.Create("&dt=", 2068), true)
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2072), false)
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
WriteLiteral(" id=\"REDSTaxCodes\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSTax_REDSTaxCodes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2910), Tuple.Create("\"", 2925)
, Tuple.Create(Tuple.Create("", 2917), Tuple.Create("#", 2917), true)
, Tuple.Create(Tuple.Create("", 2918), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2918), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3141), Tuple.Create("\"", 3153)
, Tuple.Create(Tuple.Create("", 3146), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3146), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Add_1.cshtml")]
    public partial class Views_REDSTax_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Tax Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Tax Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSTax/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSTaxCodes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSTax_REDSTaxCodes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_List_1.cshtml")]
    public partial class Views_REDSTax_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSTax>>
    {
        public Views_REDSTax_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Tax Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Tax Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Tax Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/REDSTax/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Tax Code</th><th>Type</th><th>Alcohol Percentage</th><th>Duty Ra" +
"te Â£ per ltr</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 935), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 942), Tuple.Create("/REDSTax/Load/?RecId=", 942), true)
                , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:32%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1228), Tuple.Create("\"", 1316)
, Tuple.Create(Tuple.Create("", 1239), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxCode/?RecId=", 1239), true)
                                                                      , Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1292), false)
, Tuple.Create(Tuple.Create("", 1305), Tuple.Create("\',$(this));", 1305), true)
);
WriteLiteral(" data-bound-name=\'RDTaxCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1376), Tuple.Create("\'", 1418)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1384), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxCode.HTMLValue)
, 1384), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1606), Tuple.Create("\"", 1694)
, Tuple.Create(Tuple.Create("", 1617), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxType/?RecId=", 1617), true)
                                                                      , Tuple.Create(Tuple.Create("", 1670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1670), false)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create("\',$(this));", 1683), true)
);
WriteLiteral(" data-bound-name=\'RDTaxType\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1754), Tuple.Create("\'", 1796)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1762), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxType.HTMLValue)
, 1762), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDTaxAlcPct.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                             Write(itm.RDTaxDutyRate.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Edit_2.cshtml")]
    public partial class Views_REDSTax_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Edit_2_cshtml()
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
WriteLiteral(" href=\"/REDSTax/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Tax Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 411), Tuple.Create("\'", 472)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("IQJSCall(\"/REDSTax/Delete/?RecId=", 421), true)
        , Tuple.Create(Tuple.Create("", 454), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 454), false)
, Tuple.Create(Tuple.Create("", 469), Tuple.Create("\");", 469), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSTa" +
"x/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSTax", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1366), Tuple.Create("\'", 1388)
, Tuple.Create(Tuple.Create("", 1374), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1374), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1434), Tuple.Create("\'", 1458)
, Tuple.Create(Tuple.Create("", 1442), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1442), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSTax\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1559), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1567), Tuple.Create<System.Object, System.Int32>(Model.RDTaxIdValue
, 1567), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSTax/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2018), Tuple.Create("\"", 2119)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create("/REDSTax/ViewHistory/?RecId=", 2025), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2068), Tuple.Create("&dt=", 2068), true)
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2072), false)
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
WriteLiteral(" id=\"REDSTaxCodes\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSTax_REDSTaxCodes.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2910), Tuple.Create("\"", 2925)
, Tuple.Create(Tuple.Create("", 2917), Tuple.Create("#", 2917), true)
, Tuple.Create(Tuple.Create("", 2918), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2918), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3141), Tuple.Create("\"", 3153)
, Tuple.Create(Tuple.Create("", 3146), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3146), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Add_2.cshtml")]
    public partial class Views_REDSTax_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Tax Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Tax Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSTax/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSTaxCodes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSTax_REDSTaxCodes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_List_2.cshtml")]
    public partial class Views_REDSTax_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSTax>>
    {
        public Views_REDSTax_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Tax Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Tax Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Tax Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/REDSTax/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Tax Code</th><th>Type</th><th>Alcohol Percentage</th><th>Duty Ra" +
"te Â£ per ltr</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 935), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 942), Tuple.Create("/REDSTax/Load/?RecId=", 942), true)
                , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:32%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1228), Tuple.Create("\"", 1316)
, Tuple.Create(Tuple.Create("", 1239), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxCode/?RecId=", 1239), true)
                                                                      , Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1292), false)
, Tuple.Create(Tuple.Create("", 1305), Tuple.Create("\',$(this));", 1305), true)
);
WriteLiteral(" data-bound-name=\'RDTaxCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1376), Tuple.Create("\'", 1418)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1384), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxCode.HTMLValue)
, 1384), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1606), Tuple.Create("\"", 1694)
, Tuple.Create(Tuple.Create("", 1617), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxType/?RecId=", 1617), true)
                                                                      , Tuple.Create(Tuple.Create("", 1670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1670), false)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create("\',$(this));", 1683), true)
);
WriteLiteral(" data-bound-name=\'RDTaxType\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1754), Tuple.Create("\'", 1796)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1762), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxType.HTMLValue)
, 1762), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDTaxAlcPct.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                             Write(itm.RDTaxDutyRate.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Edit_3.cshtml")]
    public partial class Views_REDSTax_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Edit_3_cshtml()
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
WriteLiteral(" href=\"/REDSTax/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Tax Codes</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 411), Tuple.Create("\'", 472)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("IQJSCall(\"/REDSTax/Delete/?RecId=", 421), true)
        , Tuple.Create(Tuple.Create("", 454), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 454), false)
, Tuple.Create(Tuple.Create("", 469), Tuple.Create("\");", 469), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSTa" +
"x/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSTax", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1366), Tuple.Create("\'", 1388)
, Tuple.Create(Tuple.Create("", 1374), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1374), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1434), Tuple.Create("\'", 1458)
, Tuple.Create(Tuple.Create("", 1442), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1442), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSTax\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1559), Tuple.Create("\"", 1586)
, Tuple.Create(Tuple.Create("", 1567), Tuple.Create<System.Object, System.Int32>(Model.RDTaxIdValue
, 1567), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1632), Tuple.Create("\"", 1655)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1640), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1697), Tuple.Create("\"", 1720)
, Tuple.Create(Tuple.Create("", 1705), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1705), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSTax/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2018), Tuple.Create("\"", 2119)
, Tuple.Create(Tuple.Create("", 2025), Tuple.Create("/REDSTax/ViewHistory/?RecId=", 2025), true)
, Tuple.Create(Tuple.Create("", 2053), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2053), false)
, Tuple.Create(Tuple.Create("", 2068), Tuple.Create("&dt=", 2068), true)
, Tuple.Create(Tuple.Create("", 2072), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2072), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2711), Tuple.Create("\"", 2726)
, Tuple.Create(Tuple.Create("", 2718), Tuple.Create("#", 2718), true)
, Tuple.Create(Tuple.Create("", 2719), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2719), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2942), Tuple.Create("\"", 2954)
, Tuple.Create(Tuple.Create("", 2947), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2947), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_Add_3.cshtml")]
    public partial class Views_REDSTax_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSTax>
    {
        public Views_REDSTax_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Tax Codes";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Tax Codes\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSTax/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSTax>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSTax_List_3.cshtml")]
    public partial class Views_REDSTax_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSTax>>
    {
        public Views_REDSTax_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Tax Codes List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Tax Codes List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Tax Codes</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSTax/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 516), Tuple.Create("\"", 586)
, Tuple.Create(Tuple.Create("", 523), Tuple.Create("/REDSTax/ListFromQuery/?Clause=", 523), true)
                                                                   , Tuple.Create(Tuple.Create("", 554), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 554), false)
, Tuple.Create(Tuple.Create("", 569), Tuple.Create("&Ord=", 569), true)
                                                                                       , Tuple.Create(Tuple.Create("", 574), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 574), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Tax Code</th><th>Type</th><th>Alcohol Percentage</th><th>Duty Ra" +
"te Â£ per ltr</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 935), Tuple.Create("\"", 976)
, Tuple.Create(Tuple.Create("", 942), Tuple.Create("/REDSTax/Load/?RecId=", 942), true)
                , Tuple.Create(Tuple.Create("", 963), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 963), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxCode.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:32%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1228), Tuple.Create("\"", 1316)
, Tuple.Create(Tuple.Create("", 1239), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxCode/?RecId=", 1239), true)
                                                                      , Tuple.Create(Tuple.Create("", 1292), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1292), false)
, Tuple.Create(Tuple.Create("", 1305), Tuple.Create("\',$(this));", 1305), true)
);
WriteLiteral(" data-bound-name=\'RDTaxCode\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1376), Tuple.Create("\'", 1418)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1384), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxCode.HTMLValue)
, 1384), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDTaxType.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:16%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1606), Tuple.Create("\"", 1694)
, Tuple.Create(Tuple.Create("", 1617), Tuple.Create("javascript:IQAutoSave(\'/REDSTax/SaveRDTaxType/?RecId=", 1617), true)
                                                                      , Tuple.Create(Tuple.Create("", 1670), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1670), false)
, Tuple.Create(Tuple.Create("", 1683), Tuple.Create("\',$(this));", 1683), true)
);
WriteLiteral(" data-bound-name=\'RDTaxType\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1754), Tuple.Create("\'", 1796)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1762), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDTaxType.HTMLValue)
, 1762), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDTaxAlcPct.DisplayValue);
WriteLiteral("</td><td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                                                                             Write(itm.RDTaxDutyRate.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
