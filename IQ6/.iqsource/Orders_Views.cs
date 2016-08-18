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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Orders.cshtml")]
    public partial class Views_Orders_Orders_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Orders_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 62), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 70), Tuple.Create("IQLabel100311", 70), true)
, Tuple.Create(Tuple.Create(" ", 83), Tuple.Create<System.Object, System.Int32>(!Model.OrdReqDate.LabelVisible ? " hide " : ""
, 84), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 342)
         , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdReqDate.BackHEXColor) ? "" : "color:" + Model.OrdReqDate.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 251), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 251), true)
);
WriteLiteral(">Required Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'105\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:105px;top:3px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdReqDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdReqDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                   Write(!Model.OrdReqDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdReqDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdReqDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateOrdReqDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.OrdReqDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateOrdReqDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1297), Tuple.Create("\'", 1367)
, Tuple.Create(Tuple.Create("", 1305), Tuple.Create("IQLabel100312", 1305), true)
, Tuple.Create(Tuple.Create(" ", 1318), Tuple.Create<System.Object, System.Int32>(!Model.OrdExpImp.LabelVisible ? " hide " : ""
, 1319), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1368), Tuple.Create("\'", 1575)
                               , Tuple.Create(Tuple.Create("", 1377), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdExpImp.BackHEXColor) ? "" : "color:" + Model.OrdExpImp.BackHEXColor + ";"
, 1377), false)
, Tuple.Create(Tuple.Create("", 1483), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1483), true)
);
WriteLiteral(">Export or Import</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdExpImp\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdExpImp.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control  mandatory  ");
                                                                                                                 Write(!Model.OrdExpImp.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdExpImp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdExpImp/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdExpImp\'  style=\'position: absolute; left:130px;height:21px;wi" +
"dth:120px;top:28px;\'>\r\n");
             foreach(var itm in Model.OrdExpImp.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2189), Tuple.Create("\'", 2210)
, Tuple.Create(Tuple.Create("", 2197), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2197), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdExpImp.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2343), Tuple.Create("\'", 2409)
, Tuple.Create(Tuple.Create("", 2351), Tuple.Create("IQLabel100313", 2351), true)
, Tuple.Create(Tuple.Create(" ", 2364), Tuple.Create<System.Object, System.Int32>(!Model.OrdId.LabelVisible ? " hide " : ""
, 2365), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2410), Tuple.Create("\'", 2609)
                    , Tuple.Create(Tuple.Create("", 2419), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdId.BackHEXColor) ? "" : "color:" + Model.OrdId.BackHEXColor + ";"
, 2419), false)
, Tuple.Create(Tuple.Create("", 2517), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2517), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 2694), Tuple.Create("\'", 2756)
, Tuple.Create(Tuple.Create("", 2702), Tuple.Create("form-control", 2702), true)
, Tuple.Create(Tuple.Create("   ", 2714), Tuple.Create<System.Object, System.Int32>(!Model.OrdId.Visible ? " hide " : ""
, 2717), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3118), Tuple.Create("\'", 3186)
, Tuple.Create(Tuple.Create("", 3126), Tuple.Create("IQLabel100314", 3126), true)
                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 3139), Tuple.Create<System.Object, System.Int32>(!Model.OrdDate.LabelVisible ? " hide " : ""
, 3140), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3187), Tuple.Create("\'", 3390)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 3196), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDate.BackHEXColor) ? "" : "color:" + Model.OrdDate.BackHEXColor + ";"
, 3196), false)
, Tuple.Create(Tuple.Create("", 3298), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3298), true)
);
WriteLiteral(">Order Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                            Write(!Model.OrdDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateOrdDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.OrdDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateOrdDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4313), Tuple.Create("\'", 4383)
, Tuple.Create(Tuple.Create("", 4321), Tuple.Create("IQLabel100315", 4321), true)
, Tuple.Create(Tuple.Create(" ", 4334), Tuple.Create<System.Object, System.Int32>(!Model.OrdStatus.LabelVisible ? " hide " : ""
, 4335), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4384), Tuple.Create("\'", 4592)
                               , Tuple.Create(Tuple.Create("", 4393), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdStatus.BackHEXColor) ? "" : "color:" + Model.OrdStatus.BackHEXColor + ";"
, 4393), false)
, Tuple.Create(Tuple.Create("", 4499), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4499), true)
);
WriteLiteral(">Status</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdStatus\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdStatus.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                        Write(!Model.OrdStatus.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdStatus/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdStatus\'  style=\'position: absolute; left:130px;height:21px;wi" +
"dth:160px;top:103px;\'>\r\n");
             foreach(var itm in Model.OrdStatus.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 5188), Tuple.Create("\'", 5209)
, Tuple.Create(Tuple.Create("", 5196), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 5196), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdStatus.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5342), Tuple.Create("\'", 5410)
, Tuple.Create(Tuple.Create("", 5350), Tuple.Create("IQLabel100317", 5350), true)
, Tuple.Create(Tuple.Create(" ", 5363), Tuple.Create<System.Object, System.Int32>(!Model.OrdCust.LabelVisible ? " hide " : ""
, 5364), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5411), Tuple.Create("\'", 5615)
                      , Tuple.Create(Tuple.Create("", 5420), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCust.BackHEXColor) ? "" : "color:" + Model.OrdCust.BackHEXColor + ";"
, 5420), false)
, Tuple.Create(Tuple.Create("", 5522), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 5522), true)
);
WriteLiteral(">Client Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:200px;top:153px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdCust\'");
                                 Write(Model.RecordLocked || !Model.OrdCust.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCust/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.OrdCust.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdCust/");
                                             Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdCust\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdCust.ToString() != "" && Model.PopulateOrdCust.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdCust.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdCust]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 7277), Tuple.Create("\'", 7347)
, Tuple.Create(Tuple.Create("", 7285), Tuple.Create("IQLabel100318", 7285), true)
, Tuple.Create(Tuple.Create(" ", 7298), Tuple.Create<System.Object, System.Int32>(!Model.OrdCustPC.LabelVisible ? " hide " : ""
, 7299), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7348), Tuple.Create("\'", 7556)
                           , Tuple.Create(Tuple.Create("", 7357), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCustPC.BackHEXColor) ? "" : "color:" + Model.OrdCustPC.BackHEXColor + ";"
, 7357), false)
, Tuple.Create(Tuple.Create("", 7463), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 7463), true)
);
WriteLiteral(">Client Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCustPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 7648), Tuple.Create("\'", 7714)
, Tuple.Create(Tuple.Create("", 7656), Tuple.Create("form-control", 7656), true)
, Tuple.Create(Tuple.Create("   ", 7668), Tuple.Create<System.Object, System.Int32>(!Model.OrdCustPC.Visible ? " hide " : ""
, 7671), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCustPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCustPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCustPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdCustPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 8094), Tuple.Create("\'", 8165)
, Tuple.Create(Tuple.Create("", 8102), Tuple.Create("IQLabel100319", 8102), true)
                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 8115), Tuple.Create<System.Object, System.Int32>(!Model.OrdCustOrd.LabelVisible ? " hide " : ""
, 8116), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8166), Tuple.Create("\'", 8376)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 8175), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCustOrd.BackHEXColor) ? "" : "color:" + Model.OrdCustOrd.BackHEXColor + ";"
, 8175), false)
, Tuple.Create(Tuple.Create("", 8283), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 8283), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 8980), Tuple.Create("\'", 9051)
, Tuple.Create(Tuple.Create("", 8988), Tuple.Create("IQLabel100321", 8988), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 9001), Tuple.Create<System.Object, System.Int32>(!Model.OrdConsign.LabelVisible ? " hide " : ""
, 9002), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9052), Tuple.Create("\'", 9262)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 9061), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdConsign.BackHEXColor) ? "" : "color:" + Model.OrdConsign.BackHEXColor + ";"
, 9061), false)
, Tuple.Create(Tuple.Create("", 9169), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:253px;", 9169), true)
);
WriteLiteral(">Consignee Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:200px;top:253px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdConsign\'");
                                    Write(Model.RecordLocked || !Model.OrdConsign.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdConsign/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdConsign/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                Write(!Model.OrdConsign.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdConsign/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdConsign\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdConsign.ToString() != "" && Model.PopulateOrdConsign.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdConsign.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdConsign]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 10960), Tuple.Create("\'", 11033)
, Tuple.Create(Tuple.Create("", 10968), Tuple.Create("IQLabel100322", 10968), true)
, Tuple.Create(Tuple.Create(" ", 10981), Tuple.Create<System.Object, System.Int32>(!Model.OrdConsignPC.LabelVisible ? " hide " : ""
, 10982), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11034), Tuple.Create("\'", 11248)
                             , Tuple.Create(Tuple.Create("", 11043), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdConsignPC.BackHEXColor) ? "" : "color:" + Model.OrdConsignPC.BackHEXColor + ";"
, 11043), false)
, Tuple.Create(Tuple.Create("", 11155), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:278px;", 11155), true)
);
WriteLiteral(">Consign Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdConsignPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 11344), Tuple.Create("\'", 11413)
, Tuple.Create(Tuple.Create("", 11352), Tuple.Create("form-control", 11352), true)
, Tuple.Create(Tuple.Create("   ", 11364), Tuple.Create<System.Object, System.Int32>(!Model.OrdConsignPC.Visible ? " hide " : ""
, 11367), false)
);
WriteLiteral(" ");
                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdConsignPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdConsignPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdConsignPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdConsignPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:278px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 11805), Tuple.Create("\'", 11876)
, Tuple.Create(Tuple.Create("", 11813), Tuple.Create("IQLabel100323", 11813), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 11826), Tuple.Create<System.Object, System.Int32>(!Model.OrdConsOrd.LabelVisible ? " hide " : ""
, 11827), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11877), Tuple.Create("\'", 12087)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 11886), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdConsOrd.BackHEXColor) ? "" : "color:" + Model.OrdConsOrd.BackHEXColor + ";"
, 11886), false)
, Tuple.Create(Tuple.Create("", 11994), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:303px;", 11994), true)
);
WriteLiteral(">Consign Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdConsOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdConsOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdConsOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdConsOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdConsOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdConsOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdConsOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:303px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 12692), Tuple.Create("\'", 12764)
, Tuple.Create(Tuple.Create("", 12700), Tuple.Create("IQLabel100324", 12700), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 12713), Tuple.Create<System.Object, System.Int32>(!Model.OrdTescoRef.LabelVisible ? " hide " : ""
, 12714), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12765), Tuple.Create("\'", 12977)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 12774), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdTescoRef.BackHEXColor) ? "" : "color:" + Model.OrdTescoRef.BackHEXColor + ";"
, 12774), false)
, Tuple.Create(Tuple.Create("", 12884), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:328px;", 12884), true)
);
WriteLiteral(">Tesco Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdTescoRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdTescoRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.OrdTescoRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdTescoRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdTescoRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdTescoRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.OrdTescoRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:328px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 13582), Tuple.Create("\'", 13652)
, Tuple.Create(Tuple.Create("", 13590), Tuple.Create("IQLabel100325", 13590), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 13603), Tuple.Create<System.Object, System.Int32>(!Model.OrdDelRef.LabelVisible ? " hide " : ""
, 13604), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13653), Tuple.Create("\'", 13861)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 13662), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDelRef.BackHEXColor) ? "" : "color:" + Model.OrdDelRef.BackHEXColor + ";"
, 13662), false)
, Tuple.Create(Tuple.Create("", 13768), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:353px;", 13768), true)
);
WriteLiteral(">Delivery Reference</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDelRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdDelRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.OrdDelRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDelRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdDelRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.OrdDelRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:353px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 14461), Tuple.Create("\'", 14529)
, Tuple.Create(Tuple.Create("", 14469), Tuple.Create("IQLabel100332", 14469), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 14482), Tuple.Create<System.Object, System.Int32>(!Model.OrdSupp.LabelVisible ? " hide " : ""
, 14483), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14530), Tuple.Create("\'", 14735)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 14539), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdSupp.BackHEXColor) ? "" : "color:" + Model.OrdSupp.BackHEXColor + ";"
, 14539), false)
, Tuple.Create(Tuple.Create("", 14641), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:28px;", 14641), true)
);
WriteLiteral(">Supplier Name</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:460px;height:21px;width:200px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdSupp\'");
                                 Write(Model.RecordLocked || !Model.OrdSupp.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSupp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdSupp/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.OrdSupp.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdSupp/");
                                             Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdSupp\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdSupp.ToString() != "" && Model.PopulateOrdSupp.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdSupp.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdSupp]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 16398), Tuple.Create("\'", 16467)
, Tuple.Create(Tuple.Create("", 16406), Tuple.Create("IQLabel100333", 16406), true)
, Tuple.Create(Tuple.Create(" ", 16419), Tuple.Create<System.Object, System.Int32>(!Model.OrdSupPC.LabelVisible ? " hide " : ""
, 16420), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16468), Tuple.Create("\'", 16675)
                         , Tuple.Create(Tuple.Create("", 16477), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdSupPC.BackHEXColor) ? "" : "color:" + Model.OrdSupPC.BackHEXColor + ";"
, 16477), false)
, Tuple.Create(Tuple.Create("", 16581), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:53px;", 16581), true)
);
WriteLiteral(">Supplier Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdSupPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 16768), Tuple.Create("\'", 16833)
, Tuple.Create(Tuple.Create("", 16776), Tuple.Create("form-control", 16776), true)
, Tuple.Create(Tuple.Create("   ", 16788), Tuple.Create<System.Object, System.Int32>(!Model.OrdSupPC.Visible ? " hide " : ""
, 16791), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSupPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdSupPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdSupPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdSupPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:100px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 17208), Tuple.Create("\'", 17279)
, Tuple.Create(Tuple.Create("", 17216), Tuple.Create("IQLabel100334", 17216), true)
                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 17229), Tuple.Create<System.Object, System.Int32>(!Model.OrdSuppRef.LabelVisible ? " hide " : ""
, 17230), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17280), Tuple.Create("\'", 17491)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 17289), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdSuppRef.BackHEXColor) ? "" : "color:" + Model.OrdSuppRef.BackHEXColor + ";"
, 17289), false)
, Tuple.Create(Tuple.Create("", 17397), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:78px;", 17397), true)
);
WriteLiteral(">Supplier Reference</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdSuppRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdSuppRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdSuppRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSuppRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdSuppRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdSuppRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdSuppRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 18097), Tuple.Create("\'", 18170)
, Tuple.Create(Tuple.Create("", 18105), Tuple.Create("IQLabel100336", 18105), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 18118), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollPoint.LabelVisible ? " hide " : ""
, 18119), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 18171), Tuple.Create("\'", 18387)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 18180), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCollPoint.BackHEXColor) ? "" : "color:" + Model.OrdCollPoint.BackHEXColor + ";"
, 18180), false)
, Tuple.Create(Tuple.Create("", 18292), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:128px;", 18292), true)
);
WriteLiteral(">Collection Point</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:460px;height:21px;width:200px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdCollPoint\'");
                                      Write(Model.RecordLocked || !Model.OrdCollPoint.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollPoint/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCollPoint/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                        Write(!Model.OrdCollPoint.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdCollPoint/");
                                                  Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdCollPoint\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdCollPoint.ToString() != "" && Model.PopulateOrdCollPoint.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdCollPoint.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdCollPoint]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 20109), Tuple.Create("\'", 20184)
, Tuple.Create(Tuple.Create("", 20117), Tuple.Create("IQLabel100337", 20117), true)
, Tuple.Create(Tuple.Create(" ", 20130), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollPointPC.LabelVisible ? " hide " : ""
, 20131), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20185), Tuple.Create("\'", 20405)
                               , Tuple.Create(Tuple.Create("", 20194), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCollPointPC.BackHEXColor) ? "" : "color:" + Model.OrdCollPointPC.BackHEXColor + ";"
, 20194), false)
, Tuple.Create(Tuple.Create("", 20310), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:153px;", 20310), true)
);
WriteLiteral(">Collection Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCollPointPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 20506), Tuple.Create("\'", 20577)
, Tuple.Create(Tuple.Create("", 20514), Tuple.Create("form-control", 20514), true)
, Tuple.Create(Tuple.Create("   ", 20526), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollPointPC.Visible ? " hide " : ""
, 20529), false)
);
WriteLiteral(" ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollPointPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCollPointPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCollPointPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.OrdCollPointPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:100px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 20977), Tuple.Create("\'", 21049)
, Tuple.Create(Tuple.Create("", 20985), Tuple.Create("IQLabel100339", 20985), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 20998), Tuple.Create<System.Object, System.Int32>(!Model.OrdDelPoint.LabelVisible ? " hide " : ""
, 20999), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21050), Tuple.Create("\'", 21264)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 21059), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDelPoint.BackHEXColor) ? "" : "color:" + Model.OrdDelPoint.BackHEXColor + ";"
, 21059), false)
, Tuple.Create(Tuple.Create("", 21169), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:203px;", 21169), true)
);
WriteLiteral(">Delivery Point</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:460px;height:21px;width:200px;top:203px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdDelPoint\'");
                                     Write(Model.RecordLocked || !Model.OrdDelPoint.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelPoint/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDelPoint/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                    Write(!Model.OrdDelPoint.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdDelPoint/");
                                                 Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdDelPoint\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdDelPoint.ToString() != "" && Model.PopulateOrdDelPoint.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdDelPoint.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdDelPoint]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 22973), Tuple.Create("\'", 23047)
, Tuple.Create(Tuple.Create("", 22981), Tuple.Create("IQLabel100340", 22981), true)
, Tuple.Create(Tuple.Create(" ", 22994), Tuple.Create<System.Object, System.Int32>(!Model.OrdDelPointPC.LabelVisible ? " hide " : ""
, 22995), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23048), Tuple.Create("\'", 23266)
                              , Tuple.Create(Tuple.Create("", 23057), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDelPointPC.BackHEXColor) ? "" : "color:" + Model.OrdDelPointPC.BackHEXColor + ";"
, 23057), false)
, Tuple.Create(Tuple.Create("", 23171), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:228px;", 23171), true)
);
WriteLiteral(">Delivery Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDelPointPC\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 23364), Tuple.Create("\'", 23434)
, Tuple.Create(Tuple.Create("", 23372), Tuple.Create("form-control", 23372), true)
, Tuple.Create(Tuple.Create("   ", 23384), Tuple.Create<System.Object, System.Int32>(!Model.OrdDelPointPC.Visible ? " hide " : ""
, 23387), false)
);
WriteLiteral(" ");
                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelPointPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDelPointPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdDelPointPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdDelPointPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:100px;top:228px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 23830), Tuple.Create("\'", 23899)
, Tuple.Create(Tuple.Create("", 23838), Tuple.Create("IQLabel100341", 23838), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 23851), Tuple.Create<System.Object, System.Int32>(!Model.OrdJobNo.LabelVisible ? " hide " : ""
, 23852), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23900), Tuple.Create("\'", 24108)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 23909), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdJobNo.BackHEXColor) ? "" : "color:" + Model.OrdJobNo.BackHEXColor + ";"
, 23909), false)
, Tuple.Create(Tuple.Create("", 24013), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:278px;", 24013), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:460px;height:21px;width:160px;top:278px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdJobNo\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdJobNo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                              Write(!Model.OrdJobNo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdJobNo/");
                                              Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdJobNo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdJobNo.ToString() != "" && Model.PopulateOrdJobNo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdJobNo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 25706), Tuple.Create("\'", 25779)
, Tuple.Create(Tuple.Create("", 25714), Tuple.Create("IQLabel100342", 25714), true)
, Tuple.Create(Tuple.Create(" ", 25727), Tuple.Create<System.Object, System.Int32>(!Model.OrdDateAvail.LabelVisible ? " hide " : ""
, 25728), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25780), Tuple.Create("\'", 25996)
                             , Tuple.Create(Tuple.Create("", 25789), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDateAvail.BackHEXColor) ? "" : "color:" + Model.OrdDateAvail.BackHEXColor + ";"
, 25789), false)
, Tuple.Create(Tuple.Create("", 25901), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:328px;", 25901), true)
);
WriteLiteral(">Date Available</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'110\'");
WriteLiteral(" style=\'position: absolute; left:460px;height:21px;width:110px;top:328px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDateAvail\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdDateAvail.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                     Write(!Model.OrdDateAvail.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDateAvail/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDateAvail/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateOrdDateAvail\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.OrdDateAvail.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateOrdDateAvail]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 26970), Tuple.Create("\'", 27043)
, Tuple.Create(Tuple.Create("", 26978), Tuple.Create("IQLabel100343", 26978), true)
, Tuple.Create(Tuple.Create(" ", 26991), Tuple.Create<System.Object, System.Int32>(!Model.OrdJobLetter.LabelVisible ? " hide " : ""
, 26992), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27044), Tuple.Create("\'", 27260)
                                 , Tuple.Create(Tuple.Create("", 27053), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdJobLetter.BackHEXColor) ? "" : "color:" + Model.OrdJobLetter.BackHEXColor + ";"
, 27053), false)
, Tuple.Create(Tuple.Create("", 27165), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:303px;", 27165), true)
);
WriteLiteral(">Job Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdJobLetter\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 27350), Tuple.Create("\'", 27419)
, Tuple.Create(Tuple.Create("", 27358), Tuple.Create("form-control", 27358), true)
, Tuple.Create(Tuple.Create("   ", 27370), Tuple.Create<System.Object, System.Int32>(!Model.OrdJobLetter.Visible ? " hide " : ""
, 27373), false)
);
WriteLiteral(" ");
                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdJobLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdJobLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdJobLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdJobLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:100px;top:303px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 27811), Tuple.Create("\'", 27884)
, Tuple.Create(Tuple.Create("", 27819), Tuple.Create("IQLabel100344", 27819), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 27832), Tuple.Create<System.Object, System.Int32>(!Model.OrdTimeAvail.LabelVisible ? " hide " : ""
, 27833), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27885), Tuple.Create("\'", 28101)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 27894), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdTimeAvail.BackHEXColor) ? "" : "color:" + Model.OrdTimeAvail.BackHEXColor + ";"
, 27894), false)
, Tuple.Create(Tuple.Create("", 28006), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:335px;height:21px;width:12" +
"0px;top:353px;", 28006), true)
);
WriteLiteral(">Time Available</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdTimeAvail\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdTimeAvail.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.OrdTimeAvail.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdTimeAvail/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdTimeAvail/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdTimeAvail\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.OrdTimeAvail.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:460px;height:21px;width:80px;top:353px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 28717), Tuple.Create("\'", 28789)
, Tuple.Create(Tuple.Create("", 28725), Tuple.Create("IQLabel100351", 28725), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 28738), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollDate.LabelVisible ? " hide " : ""
, 28739), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 28790), Tuple.Create("\'", 29003)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 28799), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCollDate.BackHEXColor) ? "" : "color:" + Model.OrdCollDate.BackHEXColor + ";"
, 28799), false)
, Tuple.Create(Tuple.Create("", 28909), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:28px;", 28909), true)
);
WriteLiteral(">Collection Date</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCollDate\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 29097), Tuple.Create("\'", 29165)
, Tuple.Create(Tuple.Create("", 29105), Tuple.Create("form-control", 29105), true)
, Tuple.Create(Tuple.Create("   ", 29117), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollDate.Visible ? " hide " : ""
, 29120), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCollDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCollDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                        Write(Model.OrdCollDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:105px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 29552), Tuple.Create("\'", 29625)
, Tuple.Create(Tuple.Create("", 29560), Tuple.Create("IQLabel100352", 29560), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 29573), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollDate2.LabelVisible ? " hide " : ""
, 29574), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29626), Tuple.Create("\'", 29841)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 29635), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCollDate2.BackHEXColor) ? "" : "color:" + Model.OrdCollDate2.BackHEXColor + ";"
, 29635), false)
, Tuple.Create(Tuple.Create("", 29747), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:53px;", 29747), true)
);
WriteLiteral(">Collection Date 2</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCollDate2\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 29938), Tuple.Create("\'", 30007)
, Tuple.Create(Tuple.Create("", 29946), Tuple.Create("form-control", 29946), true)
, Tuple.Create(Tuple.Create("   ", 29958), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollDate2.Visible ? " hide " : ""
, 29961), false)
);
WriteLiteral(" ");
                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollDate2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCollDate2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCollDate2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdCollDate2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:105px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 30398), Tuple.Create("\'", 30469)
, Tuple.Create(Tuple.Create("", 30406), Tuple.Create("IQLabel100353", 30406), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 30419), Tuple.Create<System.Object, System.Int32>(!Model.OrdDateDel.LabelVisible ? " hide " : ""
, 30420), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 30470), Tuple.Create("\'", 30681)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 30479), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDateDel.BackHEXColor) ? "" : "color:" + Model.OrdDateDel.BackHEXColor + ";"
, 30479), false)
, Tuple.Create(Tuple.Create("", 30587), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:78px;", 30587), true)
);
WriteLiteral(">Date Delivered</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDateDel\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 30773), Tuple.Create("\'", 30840)
, Tuple.Create(Tuple.Create("", 30781), Tuple.Create("form-control", 30781), true)
, Tuple.Create(Tuple.Create("   ", 30793), Tuple.Create<System.Object, System.Int32>(!Model.OrdDateDel.Visible ? " hide " : ""
, 30796), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDateDel/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDateDel/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdDateDel\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.OrdDateDel.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:105px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 31223), Tuple.Create("\'", 31296)
, Tuple.Create(Tuple.Create("", 31231), Tuple.Create("IQLabel100354", 31231), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 31244), Tuple.Create<System.Object, System.Int32>(!Model.OrdDANNoFrom.LabelVisible ? " hide " : ""
, 31245), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 31297), Tuple.Create("\'", 31513)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 31306), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDANNoFrom.BackHEXColor) ? "" : "color:" + Model.OrdDANNoFrom.BackHEXColor + ";"
, 31306), false)
, Tuple.Create(Tuple.Create("", 31418), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:103px;", 31418), true)
);
WriteLiteral(">DAN Number From</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDANNoFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdDANNoFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                           Write(!Model.OrdDANNoFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDANNoFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDANNoFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdDANNoFrom\'  style=\'position: absolute; left:800px;height:21px" +
";width:120px;top:103px;\'>\r\n");
             foreach(var itm in Model.OrdDANNoFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 32139), Tuple.Create("\'", 32160)
, Tuple.Create(Tuple.Create("", 32147), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 32147), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdDANNoFrom.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                             Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 32296), Tuple.Create("\'", 32365)
, Tuple.Create(Tuple.Create("", 32304), Tuple.Create("IQLabel100355", 32304), true)
, Tuple.Create(Tuple.Create(" ", 32317), Tuple.Create<System.Object, System.Int32>(!Model.OrdDANNo.LabelVisible ? " hide " : ""
, 32318), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 32366), Tuple.Create("\'", 32574)
                      , Tuple.Create(Tuple.Create("", 32375), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDANNo.BackHEXColor) ? "" : "color:" + Model.OrdDANNo.BackHEXColor + ";"
, 32375), false)
, Tuple.Create(Tuple.Create("", 32479), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:128px;", 32479), true)
);
WriteLiteral(">DAN Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDANNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 32660), Tuple.Create("\'", 32725)
, Tuple.Create(Tuple.Create("", 32668), Tuple.Create("form-control", 32668), true)
, Tuple.Create(Tuple.Create("   ", 32680), Tuple.Create<System.Object, System.Int32>(!Model.OrdDANNo.Visible ? " hide " : ""
, 32683), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDANNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDANNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdDANNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdDANNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:120px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 33101), Tuple.Create("\'", 33173)
, Tuple.Create(Tuple.Create("", 33109), Tuple.Create("IQLabel100356", 33109), true)
                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 33122), Tuple.Create<System.Object, System.Int32>(!Model.OrdBondFrom.LabelVisible ? " hide " : ""
, 33123), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 33174), Tuple.Create("\'", 33388)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 33183), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdBondFrom.BackHEXColor) ? "" : "color:" + Model.OrdBondFrom.BackHEXColor + ";"
, 33183), false)
, Tuple.Create(Tuple.Create("", 33293), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:153px;", 33293), true)
);
WriteLiteral(">REDS/Bond From</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdBondFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdBondFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.OrdBondFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdBondFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdBondFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdBondFrom\'  style=\'position: absolute; left:800px;height:21px;" +
"width:120px;top:153px;\'>\r\n");
             foreach(var itm in Model.OrdBondFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 34006), Tuple.Create("\'", 34027)
, Tuple.Create(Tuple.Create("", 34014), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 34014), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdBondFrom.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                            Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 34162), Tuple.Create("\'", 34234)
, Tuple.Create(Tuple.Create("", 34170), Tuple.Create("IQLabel100357", 34170), true)
, Tuple.Create(Tuple.Create(" ", 34183), Tuple.Create<System.Object, System.Int32>(!Model.OrdBondCode.LabelVisible ? " hide " : ""
, 34184), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 34235), Tuple.Create("\'", 34449)
                         , Tuple.Create(Tuple.Create("", 34244), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdBondCode.BackHEXColor) ? "" : "color:" + Model.OrdBondCode.BackHEXColor + ";"
, 34244), false)
, Tuple.Create(Tuple.Create("", 34354), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:178px;", 34354), true)
);
WriteLiteral(">REDS/Bond Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdBondCode\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 34542), Tuple.Create("\'", 34610)
, Tuple.Create(Tuple.Create("", 34550), Tuple.Create("form-control", 34550), true)
, Tuple.Create(Tuple.Create("   ", 34562), Tuple.Create<System.Object, System.Int32>(!Model.OrdBondCode.Visible ? " hide " : ""
, 34565), false)
);
WriteLiteral(" ");
                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdBondCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdBondCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdBondCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                        Write(Model.OrdBondCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:120px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 34998), Tuple.Create("\'", 35072)
, Tuple.Create(Tuple.Create("", 35006), Tuple.Create("IQLabel100358", 35006), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 35019), Tuple.Create<System.Object, System.Int32>(!Model.OrdGBWKNoFrom.LabelVisible ? " hide " : ""
, 35020), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 35073), Tuple.Create("\'", 35291)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 35082), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdGBWKNoFrom.BackHEXColor) ? "" : "color:" + Model.OrdGBWKNoFrom.BackHEXColor + ";"
, 35082), false)
, Tuple.Create(Tuple.Create("", 35196), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:203px;", 35196), true)
);
WriteLiteral(">GBWK No From</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdGBWKNoFrom\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdGBWKNoFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                            Write(!Model.OrdGBWKNoFrom.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdGBWKNoFrom/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdGBWKNoFrom/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdGBWKNoFrom\'  style=\'position: absolute; left:800px;height:21p" +
"x;width:120px;top:203px;\'>\r\n");
             foreach(var itm in Model.OrdGBWKNoFrom.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 35921), Tuple.Create("\'", 35942)
, Tuple.Create(Tuple.Create("", 35929), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 35929), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdGBWKNoFrom.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                              Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 36079), Tuple.Create("\'", 36149)
, Tuple.Create(Tuple.Create("", 36087), Tuple.Create("IQLabel100359", 36087), true)
, Tuple.Create(Tuple.Create(" ", 36100), Tuple.Create<System.Object, System.Int32>(!Model.OrdGBWKNo.LabelVisible ? " hide " : ""
, 36101), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36150), Tuple.Create("\'", 36360)
                       , Tuple.Create(Tuple.Create("", 36159), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdGBWKNo.BackHEXColor) ? "" : "color:" + Model.OrdGBWKNo.BackHEXColor + ";"
, 36159), false)
, Tuple.Create(Tuple.Create("", 36265), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:228px;", 36265), true)
);
WriteLiteral(">GBWK Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdGBWKNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 36448), Tuple.Create("\'", 36514)
, Tuple.Create(Tuple.Create("", 36456), Tuple.Create("form-control", 36456), true)
, Tuple.Create(Tuple.Create("   ", 36468), Tuple.Create<System.Object, System.Int32>(!Model.OrdGBWKNo.Visible ? " hide " : ""
, 36471), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdGBWKNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdGBWKNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdGBWKNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdGBWKNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:120px;top:228px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 36894), Tuple.Create("\'", 36967)
, Tuple.Create(Tuple.Create("", 36902), Tuple.Create("IQLabel100360", 36902), true)
                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 36915), Tuple.Create<System.Object, System.Int32>(!Model.OrdVATPaidBy.LabelVisible ? " hide " : ""
, 36916), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36968), Tuple.Create("\'", 37184)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 36977), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdVATPaidBy.BackHEXColor) ? "" : "color:" + Model.OrdVATPaidBy.BackHEXColor + ";"
, 36977), false)
, Tuple.Create(Tuple.Create("", 37089), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:253px;", 37089), true)
);
WriteLiteral(">VAT Paid By</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdVATPaidBy\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdVATPaidBy.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                           Write(!Model.OrdVATPaidBy.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdVATPaidBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdVATPaidBy/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdVATPaidBy\'  style=\'position: absolute; left:800px;height:21px" +
";width:120px;top:253px;\'>\r\n");
             foreach(var itm in Model.OrdVATPaidBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 37806), Tuple.Create("\'", 37827)
, Tuple.Create(Tuple.Create("", 37814), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 37814), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdVATPaidBy.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                             Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 37963), Tuple.Create("\'", 38032)
, Tuple.Create(Tuple.Create("", 37971), Tuple.Create("IQLabel100361", 37971), true)
, Tuple.Create(Tuple.Create(" ", 37984), Tuple.Create<System.Object, System.Int32>(!Model.OrdVATNo.LabelVisible ? " hide " : ""
, 37985), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 38033), Tuple.Create("\'", 38241)
                      , Tuple.Create(Tuple.Create("", 38042), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdVATNo.BackHEXColor) ? "" : "color:" + Model.OrdVATNo.BackHEXColor + ";"
, 38042), false)
, Tuple.Create(Tuple.Create("", 38146), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
"0px;top:278px;", 38146), true)
);
WriteLiteral(">VAT Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdVATNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 38327), Tuple.Create("\'", 38392)
, Tuple.Create(Tuple.Create("", 38335), Tuple.Create("form-control", 38335), true)
, Tuple.Create(Tuple.Create("   ", 38347), Tuple.Create<System.Object, System.Int32>(!Model.OrdVATNo.Visible ? " hide " : ""
, 38350), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdVATNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdVATNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdVATNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.OrdVATNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:800px;height:21px;width:120px;top:278px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 38768), Tuple.Create("\'", 38839)
, Tuple.Create(Tuple.Create("", 38776), Tuple.Create("IQLabel100371", 38776), true)
                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 38789), Tuple.Create<System.Object, System.Int32>(!Model.OrdAgentId.LabelVisible ? " hide " : ""
, 38790), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 38840), Tuple.Create("\'", 39049)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 38849), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdAgentId.BackHEXColor) ? "" : "color:" + Model.OrdAgentId.BackHEXColor + ";"
, 38849), false)
, Tuple.Create(Tuple.Create("", 38957), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:995px;height:21px;width:60" +
"px;top:3px;", 38957), true)
);
WriteLiteral(">Agent ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdAgentId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdAgentId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.OrdAgentId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAgentId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdAgentId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdAgentId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.OrdAgentId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1060px;height:21px;width:50px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 39644), Tuple.Create("\'", 39713)
, Tuple.Create(Tuple.Create("", 39652), Tuple.Create("IQLabel100372", 39652), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 39665), Tuple.Create<System.Object, System.Int32>(!Model.OrdAgent.LabelVisible ? " hide " : ""
, 39666), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 39714), Tuple.Create("\'", 39921)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 39723), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdAgent.BackHEXColor) ? "" : "color:" + Model.OrdAgent.BackHEXColor + ";"
, 39723), false)
, Tuple.Create(Tuple.Create("", 39827), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:1005px;height:21px;width:5" +
"0px;top:28px;", 39827), true)
);
WriteLiteral(">Agent</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:1060px;height:21px;width:160px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Orders_OrdAgent\'");
                                  Write(Model.RecordLocked || !Model.OrdAgent.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAgent/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdAgent/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                        Write(!Model.OrdAgent.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Orders/AutoCompleteOrdAgent/");
                                              Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateOrdAgent\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateOrdAgent.ToString() != "" && Model.PopulateOrdAgent.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.OrdAgent.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateOrdAgent]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 41588), Tuple.Create("\'", 41662)
, Tuple.Create(Tuple.Create("", 41596), Tuple.Create("IQLabel100377", 41596), true)
, Tuple.Create(Tuple.Create(" ", 41609), Tuple.Create<System.Object, System.Int32>(!Model.OrdFreightInv.LabelVisible ? " hide " : ""
, 41610), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 41663), Tuple.Create("\'", 41881)
                              , Tuple.Create(Tuple.Create("", 41672), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdFreightInv.BackHEXColor) ? "" : "color:" + Model.OrdFreightInv.BackHEXColor + ";"
, 41672), false)
, Tuple.Create(Tuple.Create("", 41786), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:178px;", 41786), true)
);
WriteLiteral(">Freight Inv</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:1060px;height:46px;width:160px;top:178px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Freight Inv\'");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdFreightInv\'");
WriteLiteral(" disabled=disabled");
WriteLiteral("  ");
                                                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdFreightInv/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdFreightInv/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(!Model.OrdFreightInv.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateOrdFreightInv\' style=\'height:46px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.PopulateOrdFreightInv);
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
WriteLiteral(" data-target=\"*[name=PopulateOrdFreightInv]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 43028), Tuple.Create("\'", 43099)
, Tuple.Create(Tuple.Create("", 43036), Tuple.Create("IQLabel100379", 43036), true)
, Tuple.Create(Tuple.Create(" ", 43049), Tuple.Create<System.Object, System.Int32>(!Model.OrdDutyInv.LabelVisible ? " hide " : ""
, 43050), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 43100), Tuple.Create("\'", 43312)
                               , Tuple.Create(Tuple.Create("", 43109), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdDutyInv.BackHEXColor) ? "" : "color:" + Model.OrdDutyInv.BackHEXColor + ";"
, 43109), false)
, Tuple.Create(Tuple.Create("", 43217), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:228px;", 43217), true)
);
WriteLiteral(">Duty Inv</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdDutyInv\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 43398), Tuple.Create("\'", 43465)
, Tuple.Create(Tuple.Create("", 43406), Tuple.Create("form-control", 43406), true)
, Tuple.Create(Tuple.Create("   ", 43418), Tuple.Create<System.Object, System.Int32>(!Model.OrdDutyInv.Visible ? " hide " : ""
, 43421), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDutyInv/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdDutyInv/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdDutyInv\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                    Write(Model.OrdDutyInv.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1060px;height:21px;width:160px;top:228px;\'/><la" +
"bel");
WriteAttribute("class", Tuple.Create(" class=\'", 43850), Tuple.Create("\'", 43923)
, Tuple.Create(Tuple.Create("", 43858), Tuple.Create("IQLabel100380", 43858), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 43871), Tuple.Create<System.Object, System.Int32>(!Model.OrdCreatedBy.LabelVisible ? " hide " : ""
, 43872), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 43924), Tuple.Create("\'", 44140)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 43933), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCreatedBy.BackHEXColor) ? "" : "color:" + Model.OrdCreatedBy.BackHEXColor + ";"
, 43933), false)
, Tuple.Create(Tuple.Create("", 44045), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:253px;", 44045), true)
);
WriteLiteral(">Created By</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:1060px;height:21px;width:120px;top:253px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCreatedBy\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 44356), Tuple.Create("\'", 44426)
, Tuple.Create(Tuple.Create("", 44364), Tuple.Create("form-control", 44364), true)
, Tuple.Create(Tuple.Create("    ", 44376), Tuple.Create<System.Object, System.Int32>(!Model.OrdCreatedBy.Visible ? " hide " : ""
, 44380), false)
);
WriteLiteral("  ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCreatedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCreatedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdCreatedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.OrdCreatedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 44770), Tuple.Create("\'", 44791)
, Tuple.Create(Tuple.Create("", 44778), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 44778), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdCreatedBy.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateOrdCreatedBy]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 45671), Tuple.Create("\'", 45741)
, Tuple.Create(Tuple.Create("", 45679), Tuple.Create("IQLabel100381", 45679), true)
, Tuple.Create(Tuple.Create(" ", 45692), Tuple.Create<System.Object, System.Int32>(!Model.OrdAADSys.LabelVisible ? " hide " : ""
, 45693), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 45742), Tuple.Create("\'", 45952)
                          , Tuple.Create(Tuple.Create("", 45751), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdAADSys.BackHEXColor) ? "" : "color:" + Model.OrdAADSys.BackHEXColor + ";"
, 45751), false)
, Tuple.Create(Tuple.Create("", 45857), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:278px;", 45857), true)
);
WriteLiteral(">AAD System</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdAADSys\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdAADSys.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                        Write(!Model.OrdAADSys.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAADSys/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdAADSys/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdAADSys\'  style=\'position: absolute; left:1060px;height:21px;w" +
"idth:120px;top:278px;\'>\r\n");
             foreach(var itm in Model.OrdAADSys.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 46553), Tuple.Create("\'", 46574)
, Tuple.Create(Tuple.Create("", 46561), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 46561), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdAADSys.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 46707), Tuple.Create("\'", 46777)
, Tuple.Create(Tuple.Create("", 46715), Tuple.Create("IQLabel100382", 46715), true)
, Tuple.Create(Tuple.Create(" ", 46728), Tuple.Create<System.Object, System.Int32>(!Model.OrdARCRef.LabelVisible ? " hide " : ""
, 46729), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 46778), Tuple.Create("\'", 46988)
                       , Tuple.Create(Tuple.Create("", 46787), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdARCRef.BackHEXColor) ? "" : "color:" + Model.OrdARCRef.BackHEXColor + ";"
, 46787), false)
, Tuple.Create(Tuple.Create("", 46893), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:303px;", 46893), true)
);
WriteLiteral(">eAD ARC Ref</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdARCRef\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdARCRef.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.OrdARCRef.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdARCRef/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdARCRef/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdARCRef\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.OrdARCRef.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1060px;height:21px;width:160px;top:303px;\'/><la" +
"bel");
WriteAttribute("class", Tuple.Create(" class=\'", 47582), Tuple.Create("\'", 47657)
, Tuple.Create(Tuple.Create("", 47590), Tuple.Create("IQLabel100383", 47590), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 47603), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollectCtry.LabelVisible ? " hide " : ""
, 47604), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 47658), Tuple.Create("\'", 47878)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 47667), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdCollectCtry.BackHEXColor) ? "" : "color:" + Model.OrdCollectCtry.BackHEXColor + ";"
, 47667), false)
, Tuple.Create(Tuple.Create("", 47783), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:328px;", 47783), true)
);
WriteLiteral(">Collect Country</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdCollectCtry\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 47975), Tuple.Create("\'", 48046)
, Tuple.Create(Tuple.Create("", 47983), Tuple.Create("form-control", 47983), true)
, Tuple.Create(Tuple.Create("   ", 47995), Tuple.Create<System.Object, System.Int32>(!Model.OrdCollectCtry.Visible ? " hide " : ""
, 47998), false)
);
WriteLiteral(" ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollectCtry/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdCollectCtry/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateOrdCollectCtry\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.OrdCollectCtry.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1060px;height:21px;width:160px;top:328px;\'/><la" +
"bel");
WriteAttribute("class", Tuple.Create(" class=\'", 48447), Tuple.Create("\'", 48519)
, Tuple.Create(Tuple.Create("", 48455), Tuple.Create("IQLabel100385", 48455), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 48468), Tuple.Create<System.Object, System.Int32>(!Model.OrdSelFaxTo.LabelVisible ? " hide " : ""
, 48469), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 48520), Tuple.Create("\'", 48734)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 48529), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdSelFaxTo.BackHEXColor) ? "" : "color:" + Model.OrdSelFaxTo.BackHEXColor + ";"
, 48529), false)
, Tuple.Create(Tuple.Create("", 48639), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:955px;height:21px;width:10" +
"0px;top:103px;", 48639), true)
);
WriteLiteral(">Select Fax To</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:1060px;height:21px;width:160px;top:103px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdSelFaxTo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.OrdSelFaxTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.OrdSelFaxTo.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSelFaxTo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdSelFaxTo/',$(this));\""));
WriteLiteral("   name=\'PopulateOrdSelFaxTo\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.OrdSelFaxTo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 49422), Tuple.Create("\'", 49443)
, Tuple.Create(Tuple.Create("", 49430), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 49430), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateOrdSelFaxTo.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateOrdSelFaxTo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 50332), Tuple.Create("\'", 50404)
, Tuple.Create(Tuple.Create("", 50340), Tuple.Create("IQLabel100386", 50340), true)
, Tuple.Create(Tuple.Create(" ", 50353), Tuple.Create<System.Object, System.Int32>(!Model.OrdInvoiced.LabelVisible ? " hide " : ""
, 50354), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 50405), Tuple.Create("\'", 50618)
                            , Tuple.Create(Tuple.Create("", 50414), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.OrdInvoiced.BackHEXColor) ? "" : "color:" + Model.OrdInvoiced.BackHEXColor + ";"
, 50414), false)
, Tuple.Create(Tuple.Create("", 50524), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:985px;height:21px;width:70" +
"px;top:153px;", 50524), true)
);
WriteLiteral(">Invoiced</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Orders_OrdInvoiced\'");
WriteAttribute("class", Tuple.Create(" class=\'", 50690), Tuple.Create("\'", 50745)
, Tuple.Create(Tuple.Create("  ", 50698), Tuple.Create<System.Object, System.Int32>(!Model.OrdInvoiced.Visible ? " hide " : ""
, 50700), false)
);
WriteLiteral(" disabled=disabled");
WriteLiteral(" type=\'checkbox\'");
WriteLiteral(" value=\'true\'");
WriteLiteral(" ");
                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Orders/SaveOrdInvoiced/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Orders/CallbackOrdInvoiced/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:1060px;height:16px;width:16px;top:153px;\' name=" +
"\'PopulateOrdInvoiced\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateOrdInvoiced ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateOrdInvoiced\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateOrdInvoiced ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Edit_1.cshtml")]
    public partial class Views_Orders_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Orders/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Orders/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Orders" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Orders", Model.RecordID.Value))
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
WriteLiteral(" value=\"Orders\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Orders/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Orders/ViewHistory/?RecId=", 2007), true)
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
WriteLiteral(" id=\"Orders\"");
WriteLiteral(" style=\'position:relative;height:404px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Orders_Orders.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Order Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2864), Tuple.Create("\'", 2968)
, Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "OrderLine" ? "active" :  "") : "" )
, 2872), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#OrderLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Order Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3159), Tuple.Create("\'", 3260)
, Tuple.Create(Tuple.Create("", 3167), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "EADNum" ? "active" :  "") : "" )
, 3167), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#EADNum\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">eAD Numbers</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3461), Tuple.Create("\'", 3564)
, Tuple.Create(Tuple.Create("", 3469), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3469), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 3768), Tuple.Create("\'", 3865)
, Tuple.Create(Tuple.Create("", 3776), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3776), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 4047), Tuple.Create("\'", 4145)
, Tuple.Create(Tuple.Create("", 4055), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 4055), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 4341), Tuple.Create("\"", 4356)
, Tuple.Create(Tuple.Create("", 4348), Tuple.Create("#", 4348), true)
, Tuple.Create(Tuple.Create("", 4349), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4349), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Order Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "OrderLine" ? "data-loadTarget='#ffb90bec871b4e0c9c926a7d7c681d62' data-dynamicContent='/OrderLine/ListFromQuery?Limit=50&Ord=OrdLLineNo&Clause=OrdLOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "OrderLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"OrderLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/OrderLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Order Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "OrderLine") {
                      Html.RenderPartial("~/Views/OrderLine_List_1.cshtml", Model.OrderLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"ffb90bec871b4e0c9c926a7d7c681d62\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "EADNum" ? "data-loadTarget='#cd7f2d0fc7784c7fb315d0570518ea29' data-dynamicContent='/EADNum/ListFromQuery?Limit=50&Ord=EADNo&Clause=EADOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "EADNum" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"EADNum\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/EADNum/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add eAD Numbers</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "EADNum") {
                      Html.RenderPartial("~/Views/EADNum_List_1.cshtml", Model.EADNums);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"cd7f2d0fc7784c7fb315d0570518ea29\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#5c9f4255551e4ec9b6a93ee8ea1ce1a5' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7030), Tuple.Create("\'", 7077)
, Tuple.Create(Tuple.Create("", 7038), Tuple.Create("/CertShip/Add?CSOrder=", 7038), true)
        , Tuple.Create(Tuple.Create("", 7060), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 7060), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_1.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"5c9f4255551e4ec9b6a93ee8ea1ce1a5\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#b31ca7af9fd948a8bafe46515d07b811' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                     Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7990), Tuple.Create("\'", 8031)
, Tuple.Create(Tuple.Create("", 7998), Tuple.Create("/CN/Add?CNOrder=", 7998), true)
  , Tuple.Create(Tuple.Create("", 8014), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 8014), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_1.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"b31ca7af9fd948a8bafe46515d07b811\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#f3e7905dea7b49018670acebf1dd5ef4' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8916), Tuple.Create("\'", 8959)
, Tuple.Create(Tuple.Create("", 8924), Tuple.Create("/Inv/Add?InvOrder=", 8924), true)
    , Tuple.Create(Tuple.Create("", 8942), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 8942), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_1.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"f3e7905dea7b49018670acebf1dd5ef4\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 9395), Tuple.Create("\"", 9407)
, Tuple.Create(Tuple.Create("", 9400), Tuple.Create<System.Object, System.Int32>(itm.Id
, 9400), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Add_1.cshtml")]
    public partial class Views_Orders_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Orders/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Orders\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Orders_Orders.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_List_1.cshtml")]
    public partial class Views_Orders_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Orders>>
    {
        public Views_Orders_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Orders/ListFromQuery/?Clause=", 496), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client Order No</th><th>Order Date</th><th>" +
"Status</th><th>Supplier Name</th><th>Client Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 942), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 949), Tuple.Create("/Orders/Load/?RecId=", 949), true)
               , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1291), Tuple.Create("\"", 1379)
, Tuple.Create(Tuple.Create("", 1302), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCustOrd/?RecId=", 1302), true)
                                                                      , Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1355), false)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create("\',$(this));", 1368), true)
);
WriteLiteral(" data-bound-name=\'OrdCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1483)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdCustOrd.HTMLValue)
, 1448), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1697), Tuple.Create("\"", 1782)
, Tuple.Create(Tuple.Create("", 1708), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdDate/?RecId=", 1708), true)
                                                                                               , Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1758), false)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("\',$(this));", 1771), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'OrdDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1849), Tuple.Create("\'", 1889)
                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdDate.HTMLValue)
, 1857), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdStatus.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2075), Tuple.Create("\"", 2162)
, Tuple.Create(Tuple.Create("", 2086), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdStatus/?RecId=", 2086), true)
                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2138), false)
, Tuple.Create(Tuple.Create("", 2151), Tuple.Create("\',$(this));", 2151), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdStatus\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdStatus.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2483), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2494), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdSupp/?RecId=", 2494), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2904), Tuple.Create("\"", 2989)
, Tuple.Create(Tuple.Create("", 2915), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCust/?RecId=", 2915), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2965), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2965), false)
, Tuple.Create(Tuple.Create("", 2978), Tuple.Create("\',$(this));", 2978), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdCust.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Edit_2.cshtml")]
    public partial class Views_Orders_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Orders/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Orders/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Orders" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Orders", Model.RecordID.Value))
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
WriteLiteral(" value=\"Orders\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Orders/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Orders/ViewHistory/?RecId=", 2007), true)
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
WriteLiteral(" id=\"Orders\"");
WriteLiteral(" style=\'position:relative;height:404px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Orders_Orders.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Order Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2864), Tuple.Create("\'", 2968)
, Tuple.Create(Tuple.Create("", 2872), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "OrderLine" ? "active" :  "") : "" )
, 2872), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#OrderLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Order Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3159), Tuple.Create("\'", 3260)
, Tuple.Create(Tuple.Create("", 3167), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "EADNum" ? "active" :  "") : "" )
, 3167), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#EADNum\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">eAD Numbers</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3461), Tuple.Create("\'", 3564)
, Tuple.Create(Tuple.Create("", 3469), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3469), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 3768), Tuple.Create("\'", 3865)
, Tuple.Create(Tuple.Create("", 3776), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3776), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 4047), Tuple.Create("\'", 4145)
, Tuple.Create(Tuple.Create("", 4055), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 4055), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 4341), Tuple.Create("\"", 4356)
, Tuple.Create(Tuple.Create("", 4348), Tuple.Create("#", 4348), true)
, Tuple.Create(Tuple.Create("", 4349), Tuple.Create<System.Object, System.Int32>(itm.Id
, 4349), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Order Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "OrderLine" ? "data-loadTarget='#16a35c9be15d472c9ed889d0e407bef7' data-dynamicContent='/OrderLine/ListFromQuery?Limit=50&Ord=OrdLLineNo&Clause=OrdLOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "OrderLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"OrderLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/OrderLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Order Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "OrderLine") {
                      Html.RenderPartial("~/Views/OrderLine_List_2.cshtml", Model.OrderLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"16a35c9be15d472c9ed889d0e407bef7\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "EADNum" ? "data-loadTarget='#e2a361f49deb482c88bf9d4782f1b9b9' data-dynamicContent='/EADNum/ListFromQuery?Limit=50&Ord=EADNo&Clause=EADOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "EADNum" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"EADNum\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/EADNum/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add eAD Numbers</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "EADNum") {
                      Html.RenderPartial("~/Views/EADNum_List_2.cshtml", Model.EADNums);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"e2a361f49deb482c88bf9d4782f1b9b9\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#bf9a68778c90491e808552371122edbe' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7030), Tuple.Create("\'", 7077)
, Tuple.Create(Tuple.Create("", 7038), Tuple.Create("/CertShip/Add?CSOrder=", 7038), true)
        , Tuple.Create(Tuple.Create("", 7060), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 7060), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_2.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"bf9a68778c90491e808552371122edbe\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#41879445d2364d58bdc59b1852b1a017' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                     Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7990), Tuple.Create("\'", 8031)
, Tuple.Create(Tuple.Create("", 7998), Tuple.Create("/CN/Add?CNOrder=", 7998), true)
  , Tuple.Create(Tuple.Create("", 8014), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 8014), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_2.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"41879445d2364d58bdc59b1852b1a017\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#e0bb3ffe7769401b9c01f4fd33fbc4c9' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvOrder=" + Model.OrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                         Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8916), Tuple.Create("\'", 8959)
, Tuple.Create(Tuple.Create("", 8924), Tuple.Create("/Inv/Add?InvOrder=", 8924), true)
    , Tuple.Create(Tuple.Create("", 8942), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
, 8942), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_2.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"e0bb3ffe7769401b9c01f4fd33fbc4c9\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 9395), Tuple.Create("\"", 9407)
, Tuple.Create(Tuple.Create("", 9400), Tuple.Create<System.Object, System.Int32>(itm.Id
, 9400), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Add_2.cshtml")]
    public partial class Views_Orders_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Orders/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Orders\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Orders_Orders.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_List_2.cshtml")]
    public partial class Views_Orders_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Orders>>
    {
        public Views_Orders_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Orders/ListFromQuery/?Clause=", 496), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client Order No</th><th>Order Date</th><th>" +
"Status</th><th>Supplier Name</th><th>Client Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 942), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 949), Tuple.Create("/Orders/Load/?RecId=", 949), true)
               , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1291), Tuple.Create("\"", 1379)
, Tuple.Create(Tuple.Create("", 1302), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCustOrd/?RecId=", 1302), true)
                                                                      , Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1355), false)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create("\',$(this));", 1368), true)
);
WriteLiteral(" data-bound-name=\'OrdCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1483)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdCustOrd.HTMLValue)
, 1448), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1697), Tuple.Create("\"", 1782)
, Tuple.Create(Tuple.Create("", 1708), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdDate/?RecId=", 1708), true)
                                                                                               , Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1758), false)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("\',$(this));", 1771), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'OrdDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1849), Tuple.Create("\'", 1889)
                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdDate.HTMLValue)
, 1857), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdStatus.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2075), Tuple.Create("\"", 2162)
, Tuple.Create(Tuple.Create("", 2086), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdStatus/?RecId=", 2086), true)
                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2138), false)
, Tuple.Create(Tuple.Create("", 2151), Tuple.Create("\',$(this));", 2151), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdStatus\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdStatus.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2483), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2494), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdSupp/?RecId=", 2494), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2904), Tuple.Create("\"", 2989)
, Tuple.Create(Tuple.Create("", 2915), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCust/?RecId=", 2915), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2965), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2965), false)
, Tuple.Create(Tuple.Create("", 2978), Tuple.Create("\',$(this));", 2978), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdCust.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Edit_3.cshtml")]
    public partial class Views_Orders_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Orders/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Orders</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 401), Tuple.Create("\'", 461)
, Tuple.Create(Tuple.Create("", 411), Tuple.Create("IQJSCall(\"/Orders/Delete/?RecId=", 411), true)
       , Tuple.Create(Tuple.Create("", 443), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 443), false)
, Tuple.Create(Tuple.Create("", 458), Tuple.Create("\");", 458), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Orders" +
"/ViewHistory/?RecId=");
                                                                                                   Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Orders", Model.RecordID.Value))
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
WriteLiteral(" value=\"Orders\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1544), Tuple.Create("\"", 1569)
, Tuple.Create(Tuple.Create("", 1552), Tuple.Create<System.Object, System.Int32>(Model.OrdIdValue
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
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Orders/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2000), Tuple.Create("\"", 2100)
, Tuple.Create(Tuple.Create("", 2007), Tuple.Create("/Orders/ViewHistory/?RecId=", 2007), true)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_Add_3.cshtml")]
    public partial class Views_Orders_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Orders>
    {
        public Views_Orders_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Orders";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Orders\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Orders/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Orders>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Orders_List_3.cshtml")]
    public partial class Views_Orders_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Orders>>
    {
        public Views_Orders_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Orders List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Orders List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Orders</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Orders/ExportAll\'");
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
, Tuple.Create(Tuple.Create("", 496), Tuple.Create("/Orders/ListFromQuery/?Clause=", 496), true)
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
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client Order No</th><th>Order Date</th><th>" +
"Status</th><th>Supplier Name</th><th>Client Name</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 942), Tuple.Create("\"", 982)
, Tuple.Create(Tuple.Create("", 949), Tuple.Create("/Orders/Load/?RecId=", 949), true)
               , Tuple.Create(Tuple.Create("", 969), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 969), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.OrdId.DisplayValue);
WriteLiteral("</td>");
                                                                                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1291), Tuple.Create("\"", 1379)
, Tuple.Create(Tuple.Create("", 1302), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCustOrd/?RecId=", 1302), true)
                                                                      , Tuple.Create(Tuple.Create("", 1355), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1355), false)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create("\',$(this));", 1368), true)
);
WriteLiteral(" data-bound-name=\'OrdCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1440), Tuple.Create("\'", 1483)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1448), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdCustOrd.HTMLValue)
, 1448), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdDate.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1697), Tuple.Create("\"", 1782)
, Tuple.Create(Tuple.Create("", 1708), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdDate/?RecId=", 1708), true)
                                                                                               , Tuple.Create(Tuple.Create("", 1758), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1758), false)
, Tuple.Create(Tuple.Create("", 1771), Tuple.Create("\',$(this));", 1771), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'OrdDate\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1849), Tuple.Create("\'", 1889)
                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 1857), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.OrdDate.HTMLValue)
, 1857), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdStatus.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:14%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2075), Tuple.Create("\"", 2162)
, Tuple.Create(Tuple.Create("", 2086), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdStatus/?RecId=", 2086), true)
                                                                   , Tuple.Create(Tuple.Create("", 2138), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2138), false)
, Tuple.Create(Tuple.Create("", 2151), Tuple.Create("\',$(this));", 2151), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'OrdStatus\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.OrdStatus.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdSupp.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdSupp/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2483), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2494), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdSupp/?RecId=", 2494), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdSupp\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdSupp.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.OrdCust.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/Orders/AutoCompleteOrdCust/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2904), Tuple.Create("\"", 2989)
, Tuple.Create(Tuple.Create("", 2915), Tuple.Create("javascript:IQAutoSave(\'/Orders/SaveOrdCust/?RecId=", 2915), true)
                                                                                                               , Tuple.Create(Tuple.Create("", 2965), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2965), false)
, Tuple.Create(Tuple.Create("", 2978), Tuple.Create("\',$(this));", 2978), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'OrdCust\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                       Write(Html.Raw(itm.OrdCust.HTMLValue));
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
