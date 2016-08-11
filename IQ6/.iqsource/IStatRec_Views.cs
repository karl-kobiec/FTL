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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_IntrastatRecords.cshtml")]
    public partial class Views_IStatRec_IntrastatRecords_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_IntrastatRecords_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel104111", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.IStId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 329)
    , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStId.BackHEXColor) ? "" : "color:" + Model.IStId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 238), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 238), true)
);
WriteLiteral(">Intrastat ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                   Write(!Model.IStId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.IStId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 906), Tuple.Create("\'", 975)
, Tuple.Create(Tuple.Create("", 914), Tuple.Create("IQLabel104112", 914), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 927), Tuple.Create<System.Object, System.Int32>(!Model.IStOrder.LabelVisible ? " hide " : ""
, 928), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 976), Tuple.Create("\'", 1181)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 985), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStOrder.BackHEXColor) ? "" : "color:" + Model.IStOrder.BackHEXColor + ";"
, 985), false)
, Tuple.Create(Tuple.Create("", 1089), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1089), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStOrder\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStOrder.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.IStOrder.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.IStOrder.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/><div");
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
WriteLiteral(" data-target=\"*[name=PopulateIStOrder]\"");
WriteLiteral(" data-url=\"/Orders/Load/?OrdId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Orders/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Orders</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2592), Tuple.Create("\'", 2662)
, Tuple.Create(Tuple.Create("", 2600), Tuple.Create("IQLabel104113", 2600), true)
, Tuple.Create(Tuple.Create(" ", 2613), Tuple.Create<System.Object, System.Int32>(!Model.IStCustId.LabelVisible ? " hide " : ""
, 2614), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2663), Tuple.Create("\'", 2870)
                           , Tuple.Create(Tuple.Create("", 2672), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStCustId.BackHEXColor) ? "" : "color:" + Model.IStCustId.BackHEXColor + ";"
, 2672), false)
, Tuple.Create(Tuple.Create("", 2778), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 2778), true)
);
WriteLiteral(">Client ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStCustId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStCustId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.IStCustId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStCustId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStCustId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStCustId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.IStCustId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 3473), Tuple.Create("\'", 3541)
, Tuple.Create(Tuple.Create("", 3481), Tuple.Create("IQLabel104114", 3481), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 3494), Tuple.Create<System.Object, System.Int32>(!Model.IStCust.LabelVisible ? " hide " : ""
, 3495), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3542), Tuple.Create("\'", 3745)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 3551), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStCust.BackHEXColor) ? "" : "color:" + Model.IStCust.BackHEXColor + ";"
, 3551), false)
, Tuple.Create(Tuple.Create("", 3653), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3653), true)
);
WriteLiteral(">Client Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStCust\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 3841), Tuple.Create("\'", 3905)
, Tuple.Create(Tuple.Create("", 3849), Tuple.Create("form-control", 3849), true)
, Tuple.Create(Tuple.Create("   ", 3861), Tuple.Create<System.Object, System.Int32>(!Model.IStCust.Visible ? " hide " : ""
, 3864), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStCust/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStCust\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.IStCust.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 4280), Tuple.Create("\'", 4350)
, Tuple.Create(Tuple.Create("", 4288), Tuple.Create("IQLabel104115", 4288), true)
                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 4301), Tuple.Create<System.Object, System.Int32>(!Model.IStSuppId.LabelVisible ? " hide " : ""
, 4302), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4351), Tuple.Create("\'", 4559)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 4360), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStSuppId.BackHEXColor) ? "" : "color:" + Model.IStSuppId.BackHEXColor + ";"
, 4360), false)
, Tuple.Create(Tuple.Create("", 4466), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4466), true)
);
WriteLiteral(">Supplier ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStSuppId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStSuppId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.IStSuppId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSuppId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStSuppId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStSuppId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.IStSuppId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:103px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5165), Tuple.Create("\'", 5233)
, Tuple.Create(Tuple.Create("", 5173), Tuple.Create("IQLabel104116", 5173), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 5186), Tuple.Create<System.Object, System.Int32>(!Model.IStSupp.LabelVisible ? " hide " : ""
, 5187), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5234), Tuple.Create("\'", 5438)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 5243), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStSupp.BackHEXColor) ? "" : "color:" + Model.IStSupp.BackHEXColor + ";"
, 5243), false)
, Tuple.Create(Tuple.Create("", 5345), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 5345), true)
);
WriteLiteral(">Supplier Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStSupp\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 5536), Tuple.Create("\'", 5600)
, Tuple.Create(Tuple.Create("", 5544), Tuple.Create("form-control", 5544), true)
, Tuple.Create(Tuple.Create("   ", 5556), Tuple.Create<System.Object, System.Int32>(!Model.IStSupp.Visible ? " hide " : ""
, 5559), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSupp/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStSupp/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStSupp\' value=\'");
                                                                                                                                                                                                                                                                                                                                                            Write(Model.IStSupp.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5976), Tuple.Create("\'", 6047)
, Tuple.Create(Tuple.Create("", 5984), Tuple.Create("IQLabel104117", 5984), true)
                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 5997), Tuple.Create<System.Object, System.Int32>(!Model.IStCustOrd.LabelVisible ? " hide " : ""
, 5998), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6048), Tuple.Create("\'", 6258)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 6057), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStCustOrd.BackHEXColor) ? "" : "color:" + Model.IStCustOrd.BackHEXColor + ";"
, 6057), false)
, Tuple.Create(Tuple.Create("", 6165), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 6165), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.IStCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.IStCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6876), Tuple.Create("\'", 6945)
, Tuple.Create(Tuple.Create("", 6884), Tuple.Create("IQLabel104118", 6884), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 6897), Tuple.Create<System.Object, System.Int32>(!Model.IStJobNo.LabelVisible ? " hide " : ""
, 6898), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6946), Tuple.Create("\'", 7152)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 6955), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStJobNo.BackHEXColor) ? "" : "color:" + Model.IStJobNo.BackHEXColor + ";"
, 6955), false)
, Tuple.Create(Tuple.Create("", 7059), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 7059), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStJobNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.IStJobNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStJobNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStJobNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.IStJobNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7751), Tuple.Create("\'", 7819)
, Tuple.Create(Tuple.Create("", 7759), Tuple.Create("IQLabel104131", 7759), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 7772), Tuple.Create<System.Object, System.Int32>(!Model.IStDate.LabelVisible ? " hide " : ""
, 7773), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7820), Tuple.Create("\'", 8024)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 7829), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStDate.BackHEXColor) ? "" : "color:" + Model.IStDate.BackHEXColor + ";"
, 7829), false)
, Tuple.Create(Tuple.Create("", 7931), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:3px;", 7931), true)
);
WriteLiteral(">Intrastat Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:80px;top:3px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-mmm-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                            Write(!Model.IStDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateIStDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.IStDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateIStDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 8964), Tuple.Create("\'", 9033)
, Tuple.Create(Tuple.Create("", 8972), Tuple.Create("IQLabel104132", 8972), true)
, Tuple.Create(Tuple.Create(" ", 8985), Tuple.Create<System.Object, System.Int32>(!Model.IStMonth.LabelVisible ? " hide " : ""
, 8986), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9034), Tuple.Create("\'", 9241)
                              , Tuple.Create(Tuple.Create("", 9043), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStMonth.BackHEXColor) ? "" : "color:" + Model.IStMonth.BackHEXColor + ";"
, 9043), false)
, Tuple.Create(Tuple.Create("", 9147), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:28px;", 9147), true)
);
WriteLiteral(">Month</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:160px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'IntrastatRecords_IStMonth\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStMonth/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStMonth/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                            Write(!Model.IStMonth.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/IStatRec/AutoCompleteIStMonth/");
                                                Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateIStMonth\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateIStMonth.ToString() != "" && Model.PopulateIStMonth.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.IStMonth.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateIStMonth]\"");
WriteLiteral(" data-url=\"/Months/Load/?MthId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Months/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Months</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10857), Tuple.Create("\'", 10931)
, Tuple.Create(Tuple.Create("", 10865), Tuple.Create("IQLabel104133", 10865), true)
, Tuple.Create(Tuple.Create(" ", 10878), Tuple.Create<System.Object, System.Int32>(!Model.IStRatePeriod.LabelVisible ? " hide " : ""
, 10879), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10932), Tuple.Create("\'", 11149)
                              , Tuple.Create(Tuple.Create("", 10941), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStRatePeriod.BackHEXColor) ? "" : "color:" + Model.IStRatePeriod.BackHEXColor + ";"
, 10941), false)
, Tuple.Create(Tuple.Create("", 11055), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:53px;", 11055), true)
);
WriteLiteral(">Exch Rate Period</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:160px;top:53px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'IntrastatRecords_IStRatePeriod\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStRatePeriod/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStRatePeriod/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                           Write(!Model.IStRatePeriod.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/IStatRec/AutoCompleteIStRatePeriod/");
                                                     Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateIStRatePeriod\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateIStRatePeriod.ToString() != "" && Model.PopulateIStRatePeriod.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.IStRatePeriod.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateIStRatePeriod]\"");
WriteLiteral(" data-url=\"/ExchRate/Load/?ExRId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/ExchRate/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Exchange Rates</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 12838), Tuple.Create("\'", 12910)
, Tuple.Create(Tuple.Create("", 12846), Tuple.Create("IQLabel104134", 12846), true)
, Tuple.Create(Tuple.Create(" ", 12859), Tuple.Create<System.Object, System.Int32>(!Model.IStCommCode.LabelVisible ? " hide " : ""
, 12860), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12911), Tuple.Create("\'", 13124)
                            , Tuple.Create(Tuple.Create("", 12920), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStCommCode.BackHEXColor) ? "" : "color:" + Model.IStCommCode.BackHEXColor + ";"
, 12920), false)
, Tuple.Create(Tuple.Create("", 13030), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:78px;", 13030), true)
);
WriteLiteral(">Commodity Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStCommCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStCommCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.IStCommCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStCommCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStCommCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStCommCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.IStCommCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 13746), Tuple.Create("\'", 13815)
, Tuple.Create(Tuple.Create("", 13754), Tuple.Create("IQLabel104135", 13754), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 13767), Tuple.Create<System.Object, System.Int32>(!Model.IStInvNo.LabelVisible ? " hide " : ""
, 13768), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13816), Tuple.Create("\'", 14024)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 13825), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStInvNo.BackHEXColor) ? "" : "color:" + Model.IStInvNo.BackHEXColor + ";"
, 13825), false)
, Tuple.Create(Tuple.Create("", 13929), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:103px;", 13929), true)
);
WriteLiteral(">Invoice Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStInvNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStInvNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.IStInvNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStInvNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStInvNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStInvNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.IStInvNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:100px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 14627), Tuple.Create("\'", 14697)
, Tuple.Create(Tuple.Create("", 14635), Tuple.Create("IQLabel104136", 14635), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 14648), Tuple.Create<System.Object, System.Int32>(!Model.IStInvVal.LabelVisible ? " hide " : ""
, 14649), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14698), Tuple.Create("\'", 14908)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 14707), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStInvVal.BackHEXColor) ? "" : "color:" + Model.IStInvVal.BackHEXColor + ";"
, 14707), false)
, Tuple.Create(Tuple.Create("", 14813), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:128px;", 14813), true)
);
WriteLiteral(">Invoice Value</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStInvVal\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStInvVal.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.IStInvVal.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStInvVal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStInvVal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStInvVal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.IStInvVal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:128px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 15516), Tuple.Create("\'", 15587)
, Tuple.Create(Tuple.Create("", 15524), Tuple.Create("IQLabel104137", 15524), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 15537), Tuple.Create<System.Object, System.Int32>(!Model.IStInvCurr.LabelVisible ? " hide " : ""
, 15538), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15588), Tuple.Create("\'", 15800)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 15597), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStInvCurr.BackHEXColor) ? "" : "color:" + Model.IStInvCurr.BackHEXColor + ";"
, 15597), false)
, Tuple.Create(Tuple.Create("", 15705), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:153px;", 15705), true)
);
WriteLiteral(">Invoice Currency</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStInvCurr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStInvCurr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.IStInvCurr.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStInvCurr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStInvCurr/',$(this));\""));
WriteLiteral("   name=\'PopulateIStInvCurr\'  style=\'position: absolute; left:420px;height:21px;w" +
"idth:160px;top:153px;\'>\r\n");
             foreach(var itm in Model.IStInvCurr.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 16427), Tuple.Create("\'", 16448)
, Tuple.Create(Tuple.Create("", 16435), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 16435), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStInvCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                           Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 16582), Tuple.Create("\'", 16657)
, Tuple.Create(Tuple.Create("", 16590), Tuple.Create("IQLabel104138", 16590), true)
, Tuple.Create(Tuple.Create(" ", 16603), Tuple.Create<System.Object, System.Int32>(!Model.IStSterlingVal.LabelVisible ? " hide " : ""
, 16604), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16658), Tuple.Create("\'", 16878)
                            , Tuple.Create(Tuple.Create("", 16667), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStSterlingVal.BackHEXColor) ? "" : "color:" + Model.IStSterlingVal.BackHEXColor + ";"
, 16667), false)
, Tuple.Create(Tuple.Create("", 16783), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:178px;", 16783), true)
);
WriteLiteral(">Sterling Value</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStSterlingVal\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 16984), Tuple.Create("\'", 17055)
, Tuple.Create(Tuple.Create("", 16992), Tuple.Create("form-control", 16992), true)
, Tuple.Create(Tuple.Create("   ", 17004), Tuple.Create<System.Object, System.Int32>(!Model.IStSterlingVal.Visible ? " hide " : ""
, 17007), false)
);
WriteLiteral(" ");
                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSterlingVal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStSterlingVal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStSterlingVal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.IStSterlingVal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:80px;top:178px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 17458), Tuple.Create("\'", 17530)
, Tuple.Create(Tuple.Create("", 17466), Tuple.Create("IQLabel104139", 17466), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 17479), Tuple.Create<System.Object, System.Int32>(!Model.IStMonthDec.LabelVisible ? " hide " : ""
, 17480), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17531), Tuple.Create("\'", 17745)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 17540), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStMonthDec.BackHEXColor) ? "" : "color:" + Model.IStMonthDec.BackHEXColor + ";"
, 17540), false)
, Tuple.Create(Tuple.Create("", 17650), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:203px;", 17650), true)
);
WriteLiteral(">Month Declared</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:160px;top:203px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStMonthDec\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStMonthDec.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.IStMonthDec.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStMonthDec/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStMonthDec/',$(this));\""));
WriteLiteral("   name=\'PopulateIStMonthDec\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.IStMonthDec.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 18447), Tuple.Create("\'", 18468)
, Tuple.Create(Tuple.Create("", 18455), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 18455), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStMonthDec.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateIStMonthDec]\"");
WriteLiteral(" data-url=\"/Months/Load/?MthId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Months/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Months</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 19349), Tuple.Create("\'", 19421)
, Tuple.Create(Tuple.Create("", 19357), Tuple.Create("IQLabel104151", 19357), true)
, Tuple.Create(Tuple.Create(" ", 19370), Tuple.Create<System.Object, System.Int32>(!Model.IStDelTerms.LabelVisible ? " hide " : ""
, 19371), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19422), Tuple.Create("\'", 19634)
                            , Tuple.Create(Tuple.Create("", 19431), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStDelTerms.BackHEXColor) ? "" : "color:" + Model.IStDelTerms.BackHEXColor + ";"
, 19431), false)
, Tuple.Create(Tuple.Create("", 19541), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:3px;", 19541), true)
);
WriteLiteral(">Delivery Terms</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStDelTerms\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStDelTerms.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.IStDelTerms.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStDelTerms/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStDelTerms/',$(this));\""));
WriteLiteral("   name=\'PopulateIStDelTerms\'  style=\'position: absolute; left:710px;height:21px;" +
"width:160px;top:3px;\'>\r\n");
             foreach(var itm in Model.IStDelTerms.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 20264), Tuple.Create("\'", 20285)
, Tuple.Create(Tuple.Create("", 20272), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 20272), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStDelTerms.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                            Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 20420), Tuple.Create("\'", 20488)
, Tuple.Create(Tuple.Create("", 20428), Tuple.Create("IQLabel104152", 20428), true)
, Tuple.Create(Tuple.Create(" ", 20441), Tuple.Create<System.Object, System.Int32>(!Model.IStNAT1.LabelVisible ? " hide " : ""
, 20442), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20489), Tuple.Create("\'", 20694)
                     , Tuple.Create(Tuple.Create("", 20498), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStNAT1.BackHEXColor) ? "" : "color:" + Model.IStNAT1.BackHEXColor + ";"
, 20498), false)
, Tuple.Create(Tuple.Create("", 20600), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:28px;", 20600), true)
);
WriteLiteral(">NAT 1</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStNAT1\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStNAT1.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                      Write(!Model.IStNAT1.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStNAT1/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStNAT1/',$(this));\""));
WriteLiteral("   name=\'PopulateIStNAT1\'  style=\'position: absolute; left:710px;height:21px;widt" +
"h:160px;top:28px;\'>\r\n");
             foreach(var itm in Model.IStNAT1.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 21288), Tuple.Create("\'", 21309)
, Tuple.Create(Tuple.Create("", 21296), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 21296), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStNAT1.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 21440), Tuple.Create("\'", 21508)
, Tuple.Create(Tuple.Create("", 21448), Tuple.Create("IQLabel104153", 21448), true)
, Tuple.Create(Tuple.Create(" ", 21461), Tuple.Create<System.Object, System.Int32>(!Model.IStNAT2.LabelVisible ? " hide " : ""
, 21462), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21509), Tuple.Create("\'", 21714)
                     , Tuple.Create(Tuple.Create("", 21518), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStNAT2.BackHEXColor) ? "" : "color:" + Model.IStNAT2.BackHEXColor + ";"
, 21518), false)
, Tuple.Create(Tuple.Create("", 21620), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:53px;", 21620), true)
);
WriteLiteral(">NAT 2</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStNAT2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStNAT2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                      Write(!Model.IStNAT2.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStNAT2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStNAT2/',$(this));\""));
WriteLiteral("   name=\'PopulateIStNAT2\'  style=\'position: absolute; left:710px;height:21px;widt" +
"h:160px;top:53px;\'>\r\n");
             foreach(var itm in Model.IStNAT2.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 22308), Tuple.Create("\'", 22329)
, Tuple.Create(Tuple.Create("", 22316), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 22316), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStNAT2.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 22460), Tuple.Create("\'", 22535)
, Tuple.Create(Tuple.Create("", 22468), Tuple.Create("IQLabel104154", 22468), true)
, Tuple.Create(Tuple.Create(" ", 22481), Tuple.Create<System.Object, System.Int32>(!Model.IStSuppUnitVal.LabelVisible ? " hide " : ""
, 22482), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 22536), Tuple.Create("\'", 22755)
                            , Tuple.Create(Tuple.Create("", 22545), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStSuppUnitVal.BackHEXColor) ? "" : "color:" + Model.IStSuppUnitVal.BackHEXColor + ";"
, 22545), false)
, Tuple.Create(Tuple.Create("", 22661), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:78px;", 22661), true)
);
WriteLiteral(">Supp Unit Value</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStSuppUnitVal\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStSuppUnitVal.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.IStSuppUnitVal.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSuppUnitVal/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStSuppUnitVal/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStSuppUnitVal\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.IStSuppUnitVal.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:80px;top:78px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 23399), Tuple.Create("\'", 23475)
, Tuple.Create(Tuple.Create("", 23407), Tuple.Create("IQLabel104155", 23407), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 23420), Tuple.Create<System.Object, System.Int32>(!Model.IStSuppUnitType.LabelVisible ? " hide " : ""
, 23421), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23476), Tuple.Create("\'", 23698)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 23485), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStSuppUnitType.BackHEXColor) ? "" : "color:" + Model.IStSuppUnitType.BackHEXColor + ";"
, 23485), false)
, Tuple.Create(Tuple.Create("", 23603), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:103px;", 23603), true)
);
WriteLiteral(">Supp Unit Type</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStSuppUnitType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStSuppUnitType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                             Write(!Model.IStSuppUnitType.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSuppUnitType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStSuppUnitType/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateIStSuppUnitType\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.IStSuppUnitType.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:710px;height:21px;width:100px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 24350), Tuple.Create("\'", 24425)
, Tuple.Create(Tuple.Create("", 24358), Tuple.Create("IQLabel104156", 24358), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 24371), Tuple.Create<System.Object, System.Int32>(!Model.IStConsignCtry.LabelVisible ? " hide " : ""
, 24372), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24426), Tuple.Create("\'", 24646)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 24435), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStConsignCtry.BackHEXColor) ? "" : "color:" + Model.IStConsignCtry.BackHEXColor + ";"
, 24435), false)
, Tuple.Create(Tuple.Create("", 24551), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:128px;", 24551), true)
);
WriteLiteral(">Country (Consign)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:710px;height:21px;width:160px;top:128px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStConsignCtry\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStConsignCtry.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                             Write(!Model.IStConsignCtry.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStConsignCtry/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStConsignCtry/',$(this));\""));
WriteLiteral("   name=\'PopulateIStConsignCtry\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.IStConsignCtry.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 25372), Tuple.Create("\'", 25393)
, Tuple.Create(Tuple.Create("", 25380), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 25380), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStConsignCtry.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateIStConsignCtry]\"");
WriteLiteral(" data-url=\"/Country/Load/?CtryId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Country/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Countries</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 26286), Tuple.Create("\'", 26360)
, Tuple.Create(Tuple.Create("", 26294), Tuple.Create("IQLabel104157", 26294), true)
, Tuple.Create(Tuple.Create(" ", 26307), Tuple.Create<System.Object, System.Int32>(!Model.IStTranspMode.LabelVisible ? " hide " : ""
, 26308), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 26361), Tuple.Create("\'", 26579)
                              , Tuple.Create(Tuple.Create("", 26370), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStTranspMode.BackHEXColor) ? "" : "color:" + Model.IStTranspMode.BackHEXColor + ";"
, 26370), false)
, Tuple.Create(Tuple.Create("", 26484), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:153px;", 26484), true)
);
WriteLiteral(">Mode of Transport</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStTranspMode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStTranspMode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                            Write(!Model.IStTranspMode.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStTranspMode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStTranspMode/',$(this));\""));
WriteLiteral("   name=\'PopulateIStTranspMode\'  style=\'position: absolute; left:710px;height:21p" +
"x;width:160px;top:153px;\'>\r\n");
             foreach(var itm in Model.IStTranspMode.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 27228), Tuple.Create("\'", 27249)
, Tuple.Create(Tuple.Create("", 27236), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 27236), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStTranspMode.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                              Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 27386), Tuple.Create("\'", 27460)
, Tuple.Create(Tuple.Create("", 27394), Tuple.Create("IQLabel104158", 27394), true)
, Tuple.Create(Tuple.Create(" ", 27407), Tuple.Create<System.Object, System.Int32>(!Model.IStOriginCtry.LabelVisible ? " hide " : ""
, 27408), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27461), Tuple.Create("\'", 27679)
                           , Tuple.Create(Tuple.Create("", 27470), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStOriginCtry.BackHEXColor) ? "" : "color:" + Model.IStOriginCtry.BackHEXColor + ";"
, 27470), false)
, Tuple.Create(Tuple.Create("", 27584), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:178px;", 27584), true)
);
WriteLiteral(">Country (Origin)</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:710px;height:21px;width:160px;top:178px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStOriginCtry\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.IStOriginCtry.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                            Write(!Model.IStOriginCtry.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStOriginCtry/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStOriginCtry/',$(this));\""));
WriteLiteral("   name=\'PopulateIStOriginCtry\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.IStOriginCtry.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 28397), Tuple.Create("\'", 28418)
, Tuple.Create(Tuple.Create("", 28405), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 28405), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateIStOriginCtry.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateIStOriginCtry]\"");
WriteLiteral(" data-url=\"/Country/Load/?CtryId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/Country/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Countries</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 29309), Tuple.Create("\'", 29382)
, Tuple.Create(Tuple.Create("", 29317), Tuple.Create("IQLabel104159", 29317), true)
, Tuple.Create(Tuple.Create(" ", 29330), Tuple.Create<System.Object, System.Int32>(!Model.IStProcessed.LabelVisible ? " hide " : ""
, 29331), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29383), Tuple.Create("\'", 29599)
                             , Tuple.Create(Tuple.Create("", 29392), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.IStProcessed.BackHEXColor) ? "" : "color:" + Model.IStProcessed.BackHEXColor + ";"
, 29392), false)
, Tuple.Create(Tuple.Create("", 29504), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:585px;height:21px;width:12" +
"0px;top:203px;", 29504), true)
);
WriteLiteral(">Processed</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'IntrastatRecords_IStProcessed\'");
WriteAttribute("class", Tuple.Create(" class=\'", 29683), Tuple.Create("\'", 29739)
, Tuple.Create(Tuple.Create("  ", 29691), Tuple.Create<System.Object, System.Int32>(!Model.IStProcessed.Visible ? " hide " : ""
, 29693), false)
);
WriteLiteral(" disabled=disabled");
WriteLiteral(" type=\'checkbox\'");
WriteLiteral(" value=\'true\'");
WriteLiteral(" ");
                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStProcessed/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/IStatRec/CallbackIStProcessed/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:710px;height:16px;width:16px;top:203px;\' name=\'" +
"PopulateIStProcessed\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.PopulateIStProcessed ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateIStProcessed\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                   Write(!Model.PopulateIStProcessed ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Edit_1.cshtml")]
    public partial class Views_IStatRec_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Edit_1_cshtml()
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
WriteLiteral(" href=\"/IStatRec/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Intrastat Records</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 478)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/IStatRec/Delete/?RecId=", 426), true)
         , Tuple.Create(Tuple.Create("", 460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 460), false)
, Tuple.Create(Tuple.Create("", 475), Tuple.Create("\");", 475), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/IStatR" +
"ec/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("IStatRec", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1375), Tuple.Create("\'", 1397)
, Tuple.Create(Tuple.Create("", 1383), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1383), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1443), Tuple.Create("\'", 1467)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1451), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"IStatRec\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1594)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.IStIdValue
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1640), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1648), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1648), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1705), Tuple.Create("\"", 1728)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1713), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/IStatRec/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2027), Tuple.Create("\"", 2129)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("/IStatRec/ViewHistory/?RecId=", 2034), true)
, Tuple.Create(Tuple.Create("", 2063), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2063), false)
, Tuple.Create(Tuple.Create("", 2078), Tuple.Create("&dt=", 2078), true)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2082), false)
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
WriteLiteral(" id=\"IntrastatRecords\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/IStatRec_IntrastatRecords.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Add_1.cshtml")]
    public partial class Views_IStatRec_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Intrastat Records";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Intrastat Records\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/IStatRec/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"IntrastatRecords\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/IStatRec_IntrastatRecords.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_List_1.cshtml")]
    public partial class Views_IStatRec_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.IStatRec>>
    {
        public Views_IStatRec_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Intrastat Records List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Intrastat Records List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Intrastat Records</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 599)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/IStatRec/ListFromQuery/?Clause=", 535), true)
                                                                    , Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 567), false)
, Tuple.Create(Tuple.Create("", 582), Tuple.Create("&Ord=", 582), true)
                                                                                        , Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 587), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Intrastat ID</th><th>Order Number</th><th>Client ID</th><th>Clie" +
"nt Order No</th><th>Job Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1007)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/IStatRec/Load/?RecId=", 972), true)
                 , Tuple.Create(Tuple.Create("", 994), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 994), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStId/?RecId=", 1266), true)
                                                                   , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'IStId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1396), Tuple.Create("\'", 1434)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1404), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStId.HTMLValue)
, 1404), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1621), Tuple.Create("\"", 1709)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStOrder/?RecId=", 1632), true)
                                                                      , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1685), false)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create("\',$(this));", 1698), true)
);
WriteLiteral(" data-bound-name=\'IStOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1768), Tuple.Create("\'", 1809)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1776), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStOrder.HTMLValue)
, 1776), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1997), Tuple.Create("\"", 2086)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustId/?RecId=", 2008), true)
                                                                       , Tuple.Create(Tuple.Create("", 2062), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2062), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("\',$(this));", 2075), true)
);
WriteLiteral(" data-bound-name=\'IStCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2146), Tuple.Create("\'", 2188)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2154), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustId.HTMLValue)
, 2154), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2377), Tuple.Create("\"", 2467)
, Tuple.Create(Tuple.Create("", 2388), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustOrd/?RecId=", 2388), true)
                                                                        , Tuple.Create(Tuple.Create("", 2443), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2443), false)
, Tuple.Create(Tuple.Create("", 2456), Tuple.Create("\',$(this));", 2456), true)
);
WriteLiteral(" data-bound-name=\'IStCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2528), Tuple.Create("\'", 2571)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2536), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustOrd.HTMLValue)
, 2536), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2758), Tuple.Create("\"", 2846)
, Tuple.Create(Tuple.Create("", 2769), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStJobNo/?RecId=", 2769), true)
                                                                      , Tuple.Create(Tuple.Create("", 2822), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2822), false)
, Tuple.Create(Tuple.Create("", 2835), Tuple.Create("\',$(this));", 2835), true)
);
WriteLiteral(" data-bound-name=\'IStJobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2905), Tuple.Create("\'", 2946)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStJobNo.HTMLValue)
, 2913), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Edit_2.cshtml")]
    public partial class Views_IStatRec_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Edit_2_cshtml()
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
WriteLiteral(" href=\"/IStatRec/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Intrastat Records</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 478)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/IStatRec/Delete/?RecId=", 426), true)
         , Tuple.Create(Tuple.Create("", 460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 460), false)
, Tuple.Create(Tuple.Create("", 475), Tuple.Create("\");", 475), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/IStatR" +
"ec/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("IStatRec", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1375), Tuple.Create("\'", 1397)
, Tuple.Create(Tuple.Create("", 1383), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1383), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1443), Tuple.Create("\'", 1467)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1451), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"IStatRec\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1594)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.IStIdValue
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1640), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1648), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1648), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1705), Tuple.Create("\"", 1728)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1713), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/IStatRec/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2027), Tuple.Create("\"", 2129)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("/IStatRec/ViewHistory/?RecId=", 2034), true)
, Tuple.Create(Tuple.Create("", 2063), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2063), false)
, Tuple.Create(Tuple.Create("", 2078), Tuple.Create("&dt=", 2078), true)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2082), false)
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
WriteLiteral(" id=\"IntrastatRecords\"");
WriteLiteral(" style=\'position:relative;height:254px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/IStatRec_IntrastatRecords.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Add_2.cshtml")]
    public partial class Views_IStatRec_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Intrastat Records";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Intrastat Records\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/IStatRec/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"IntrastatRecords\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/IStatRec_IntrastatRecords.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_List_2.cshtml")]
    public partial class Views_IStatRec_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.IStatRec>>
    {
        public Views_IStatRec_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Intrastat Records List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Intrastat Records List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Intrastat Records</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 599)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/IStatRec/ListFromQuery/?Clause=", 535), true)
                                                                    , Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 567), false)
, Tuple.Create(Tuple.Create("", 582), Tuple.Create("&Ord=", 582), true)
                                                                                        , Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 587), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Intrastat ID</th><th>Order Number</th><th>Client ID</th><th>Clie" +
"nt Order No</th><th>Job Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1007)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/IStatRec/Load/?RecId=", 972), true)
                 , Tuple.Create(Tuple.Create("", 994), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 994), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStId/?RecId=", 1266), true)
                                                                   , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'IStId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1396), Tuple.Create("\'", 1434)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1404), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStId.HTMLValue)
, 1404), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1621), Tuple.Create("\"", 1709)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStOrder/?RecId=", 1632), true)
                                                                      , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1685), false)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create("\',$(this));", 1698), true)
);
WriteLiteral(" data-bound-name=\'IStOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1768), Tuple.Create("\'", 1809)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1776), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStOrder.HTMLValue)
, 1776), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1997), Tuple.Create("\"", 2086)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustId/?RecId=", 2008), true)
                                                                       , Tuple.Create(Tuple.Create("", 2062), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2062), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("\',$(this));", 2075), true)
);
WriteLiteral(" data-bound-name=\'IStCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2146), Tuple.Create("\'", 2188)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2154), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustId.HTMLValue)
, 2154), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2377), Tuple.Create("\"", 2467)
, Tuple.Create(Tuple.Create("", 2388), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustOrd/?RecId=", 2388), true)
                                                                        , Tuple.Create(Tuple.Create("", 2443), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2443), false)
, Tuple.Create(Tuple.Create("", 2456), Tuple.Create("\',$(this));", 2456), true)
);
WriteLiteral(" data-bound-name=\'IStCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2528), Tuple.Create("\'", 2571)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2536), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustOrd.HTMLValue)
, 2536), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2758), Tuple.Create("\"", 2846)
, Tuple.Create(Tuple.Create("", 2769), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStJobNo/?RecId=", 2769), true)
                                                                      , Tuple.Create(Tuple.Create("", 2822), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2822), false)
, Tuple.Create(Tuple.Create("", 2835), Tuple.Create("\',$(this));", 2835), true)
);
WriteLiteral(" data-bound-name=\'IStJobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2905), Tuple.Create("\'", 2946)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStJobNo.HTMLValue)
, 2913), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Edit_3.cshtml")]
    public partial class Views_IStatRec_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Edit_3_cshtml()
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
WriteLiteral(" href=\"/IStatRec/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Intrastat Records</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 478)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/IStatRec/Delete/?RecId=", 426), true)
         , Tuple.Create(Tuple.Create("", 460), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 460), false)
, Tuple.Create(Tuple.Create("", 475), Tuple.Create("\");", 475), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/IStatR" +
"ec/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("IStatRec", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1375), Tuple.Create("\'", 1397)
, Tuple.Create(Tuple.Create("", 1383), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1383), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1443), Tuple.Create("\'", 1467)
, Tuple.Create(Tuple.Create("", 1451), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1451), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"IStatRec\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1569), Tuple.Create("\"", 1594)
, Tuple.Create(Tuple.Create("", 1577), Tuple.Create<System.Object, System.Int32>(Model.IStIdValue
, 1577), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1640), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1648), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1648), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1705), Tuple.Create("\"", 1728)
, Tuple.Create(Tuple.Create("", 1713), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1713), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/IStatRec/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2027), Tuple.Create("\"", 2129)
, Tuple.Create(Tuple.Create("", 2034), Tuple.Create("/IStatRec/ViewHistory/?RecId=", 2034), true)
, Tuple.Create(Tuple.Create("", 2063), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2063), false)
, Tuple.Create(Tuple.Create("", 2078), Tuple.Create("&dt=", 2078), true)
, Tuple.Create(Tuple.Create("", 2082), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2082), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2721), Tuple.Create("\"", 2736)
, Tuple.Create(Tuple.Create("", 2728), Tuple.Create("#", 2728), true)
, Tuple.Create(Tuple.Create("", 2729), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2729), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2952), Tuple.Create("\"", 2964)
, Tuple.Create(Tuple.Create("", 2957), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2957), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_Add_3.cshtml")]
    public partial class Views_IStatRec_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.IStatRec>
    {
        public Views_IStatRec_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Intrastat Records";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Intrastat Records\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/IStatRec/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<IStatRec>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/IStatRec_List_3.cshtml")]
    public partial class Views_IStatRec_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.IStatRec>>
    {
        public Views_IStatRec_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Intrastat Records List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Intrastat Records List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Intrastat Records</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/IStatRec/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 528), Tuple.Create("\"", 599)
, Tuple.Create(Tuple.Create("", 535), Tuple.Create("/IStatRec/ListFromQuery/?Clause=", 535), true)
                                                                    , Tuple.Create(Tuple.Create("", 567), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 567), false)
, Tuple.Create(Tuple.Create("", 582), Tuple.Create("&Ord=", 582), true)
                                                                                        , Tuple.Create(Tuple.Create("", 587), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 587), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Intrastat ID</th><th>Order Number</th><th>Client ID</th><th>Clie" +
"nt Order No</th><th>Job Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 965), Tuple.Create("\"", 1007)
, Tuple.Create(Tuple.Create("", 972), Tuple.Create("/IStatRec/Load/?RecId=", 972), true)
                 , Tuple.Create(Tuple.Create("", 994), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 994), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1340)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStId/?RecId=", 1266), true)
                                                                   , Tuple.Create(Tuple.Create("", 1316), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1316), false)
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create("\',$(this));", 1329), true)
);
WriteLiteral(" data-bound-name=\'IStId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1396), Tuple.Create("\'", 1434)
                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1404), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStId.HTMLValue)
, 1404), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1621), Tuple.Create("\"", 1709)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStOrder/?RecId=", 1632), true)
                                                                      , Tuple.Create(Tuple.Create("", 1685), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1685), false)
, Tuple.Create(Tuple.Create("", 1698), Tuple.Create("\',$(this));", 1698), true)
);
WriteLiteral(" data-bound-name=\'IStOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1768), Tuple.Create("\'", 1809)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1776), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStOrder.HTMLValue)
, 1776), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1997), Tuple.Create("\"", 2086)
, Tuple.Create(Tuple.Create("", 2008), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustId/?RecId=", 2008), true)
                                                                       , Tuple.Create(Tuple.Create("", 2062), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2062), false)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create("\',$(this));", 2075), true)
);
WriteLiteral(" data-bound-name=\'IStCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2146), Tuple.Create("\'", 2188)
                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 2154), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustId.HTMLValue)
, 2154), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStCustOrd.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:33%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2377), Tuple.Create("\"", 2467)
, Tuple.Create(Tuple.Create("", 2388), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStCustOrd/?RecId=", 2388), true)
                                                                        , Tuple.Create(Tuple.Create("", 2443), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2443), false)
, Tuple.Create(Tuple.Create("", 2456), Tuple.Create("\',$(this));", 2456), true)
);
WriteLiteral(" data-bound-name=\'IStCustOrd\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2528), Tuple.Create("\'", 2571)
                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 2536), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStCustOrd.HTMLValue)
, 2536), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.IStJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:17%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2758), Tuple.Create("\"", 2846)
, Tuple.Create(Tuple.Create("", 2769), Tuple.Create("javascript:IQAutoSave(\'/IStatRec/SaveIStJobNo/?RecId=", 2769), true)
                                                                      , Tuple.Create(Tuple.Create("", 2822), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2822), false)
, Tuple.Create(Tuple.Create("", 2835), Tuple.Create("\',$(this));", 2835), true)
);
WriteLiteral(" data-bound-name=\'IStJobNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2905), Tuple.Create("\'", 2946)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2913), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.IStJobNo.HTMLValue)
, 2913), false)
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
