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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_REDSOrderHeader.cshtml")]
    public partial class Views_REDSOrder_REDSOrderHeader_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_REDSOrderHeader_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 65), Tuple.Create("\'", 133)
, Tuple.Create(Tuple.Create("", 73), Tuple.Create("IQLabel103611", 73), true)
, Tuple.Create(Tuple.Create(" ", 86), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdId.LabelVisible ? " hide " : ""
, 87), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 134), Tuple.Create("\'", 336)
      , Tuple.Create(Tuple.Create("", 143), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdId.BackHEXColor) ? "" : "color:" + Model.RDOrdId.BackHEXColor + ";"
, 143), false)
, Tuple.Create(Tuple.Create("", 245), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 245), true)
);
WriteLiteral(">REDS ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 427), Tuple.Create("\'", 491)
, Tuple.Create(Tuple.Create("", 435), Tuple.Create("form-control", 435), true)
, Tuple.Create(Tuple.Create("   ", 447), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdId.Visible ? " hide " : ""
, 450), false)
);
WriteLiteral(" ");
                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                              Write(Model.RDOrdId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 866), Tuple.Create("\'", 937)
, Tuple.Create(Tuple.Create("", 874), Tuple.Create("IQLabel103612", 874), true)
                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 887), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdOrder.LabelVisible ? " hide " : ""
, 888), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 938), Tuple.Create("\'", 1147)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 947), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdOrder.BackHEXColor) ? "" : "color:" + Model.RDOrdOrder.BackHEXColor + ";"
, 947), false)
, Tuple.Create(Tuple.Create("", 1055), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1055), true)
);
WriteLiteral(">Order Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdOrder\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdOrder.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.RDOrdOrder.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdOrder/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdOrder/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdOrder\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.RDOrdOrder.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1761), Tuple.Create("\'", 1834)
, Tuple.Create(Tuple.Create("", 1769), Tuple.Create("IQLabel103613", 1769), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 1782), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdArrDate.LabelVisible ? " hide " : ""
, 1783), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1835), Tuple.Create("\'", 2048)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 1844), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdArrDate.BackHEXColor) ? "" : "color:" + Model.RDOrdArrDate.BackHEXColor + ";"
, 1844), false)
, Tuple.Create(Tuple.Create("", 1956), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1956), true)
);
WriteLiteral(">Arrival Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdArrDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdArrDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-mmm-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                 Write(!Model.RDOrdArrDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdArrDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdArrDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateRDOrdArrDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOrdArrDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateRDOrdArrDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3028), Tuple.Create("\'", 3101)
, Tuple.Create(Tuple.Create("", 3036), Tuple.Create("IQLabel103614", 3036), true)
, Tuple.Create(Tuple.Create(" ", 3049), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDelDate.LabelVisible ? " hide " : ""
, 3050), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3102), Tuple.Create("\'", 3315)
                                  , Tuple.Create(Tuple.Create("", 3111), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdDelDate.BackHEXColor) ? "" : "color:" + Model.RDOrdDelDate.BackHEXColor + ";"
, 3111), false)
, Tuple.Create(Tuple.Create("", 3223), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3223), true)
);
WriteLiteral(">Delivery Date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdDelDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdDelDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-mmm-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                 Write(!Model.RDOrdDelDate.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDelDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdDelDate/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateRDOrdDelDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOrdDelDate.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateRDOrdDelDate]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4296), Tuple.Create("\'", 4366)
, Tuple.Create(Tuple.Create("", 4304), Tuple.Create("IQLabel103615", 4304), true)
, Tuple.Create(Tuple.Create(" ", 4317), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDesc.LabelVisible ? " hide " : ""
, 4318), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4367), Tuple.Create("\'", 4575)
                               , Tuple.Create(Tuple.Create("", 4376), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdDesc.BackHEXColor) ? "" : "color:" + Model.RDOrdDesc.BackHEXColor + ";"
, 4376), false)
, Tuple.Create(Tuple.Create("", 4482), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4482), true)
);
WriteLiteral(">Description</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdDesc\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdDesc.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.RDOrdDesc.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDesc/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdDesc/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdDesc\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.RDOrdDesc.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:400px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5183), Tuple.Create("\'", 5255)
, Tuple.Create(Tuple.Create("", 5191), Tuple.Create("IQLabel103631", 5191), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 5204), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdCustId.LabelVisible ? " hide " : ""
, 5205), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5256), Tuple.Create("\'", 5468)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 5265), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdCustId.BackHEXColor) ? "" : "color:" + Model.RDOrdCustId.BackHEXColor + ";"
, 5265), false)
, Tuple.Create(Tuple.Create("", 5375), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:215px;height:21px;width:12" +
"0px;top:3px;", 5375), true)
);
WriteLiteral(">Client ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdCustId\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdCustId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.RDOrdCustId.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdCustId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdCustId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdCustId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.RDOrdCustId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:340px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6085), Tuple.Create("\'", 6155)
, Tuple.Create(Tuple.Create("", 6093), Tuple.Create("IQLabel103632", 6093), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 6106), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdCust.LabelVisible ? " hide " : ""
, 6107), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6156), Tuple.Create("\'", 6365)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 6165), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdCust.BackHEXColor) ? "" : "color:" + Model.RDOrdCust.BackHEXColor + ";"
, 6165), false)
, Tuple.Create(Tuple.Create("", 6271), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:215px;height:21px;width:12" +
"0px;top:28px;", 6271), true)
);
WriteLiteral(">Client Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdCust\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 6462), Tuple.Create("\'", 6528)
, Tuple.Create(Tuple.Create("", 6470), Tuple.Create("form-control", 6470), true)
, Tuple.Create(Tuple.Create("   ", 6482), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdCust.Visible ? " hide " : ""
, 6485), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdCust/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdCust\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.RDOrdCust.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:340px;height:21px;width:200px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6913), Tuple.Create("\'", 6984)
, Tuple.Create(Tuple.Create("", 6921), Tuple.Create("IQLabel103633", 6921), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 6934), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDANNo.LabelVisible ? " hide " : ""
, 6935), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6985), Tuple.Create("\'", 7196)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 6994), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdDANNo.BackHEXColor) ? "" : "color:" + Model.RDOrdDANNo.BackHEXColor + ";"
, 6994), false)
, Tuple.Create(Tuple.Create("", 7102), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:215px;height:21px;width:12" +
"0px;top:53px;", 7102), true)
);
WriteLiteral(">DAN Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdDANNo\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 7293), Tuple.Create("\'", 7360)
, Tuple.Create(Tuple.Create("", 7301), Tuple.Create("form-control", 7301), true)
, Tuple.Create(Tuple.Create("   ", 7313), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDANNo.Visible ? " hide " : ""
, 7316), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDANNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdDANNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdDANNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOrdDANNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:340px;height:21px;width:100px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 7749), Tuple.Create("\'", 7825)
, Tuple.Create(Tuple.Create("", 7757), Tuple.Create("IQLabel103634", 7757), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create(" ", 7770), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdInvCreated.LabelVisible ? " hide " : ""
, 7771), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7826), Tuple.Create("\'", 8047)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 7835), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdInvCreated.BackHEXColor) ? "" : "color:" + Model.RDOrdInvCreated.BackHEXColor + ";"
, 7835), false)
, Tuple.Create(Tuple.Create("", 7953), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:215px;height:21px;width:12" +
"0px;top:78px;", 7953), true)
);
WriteLiteral(">Invoice Created</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdInvCreated\'");
WriteAttribute("class", Tuple.Create(" class=\'", 8139), Tuple.Create("\'", 8198)
, Tuple.Create(Tuple.Create("  ", 8147), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdInvCreated.Visible ? " hide " : ""
, 8149), false)
);
WriteLiteral(" ");
                                                                                                                         Write(Model.RecordLocked || !Model.RDOrdInvCreated.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdInvCreated/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdInvCreated/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:340px;height:16px;width:16px;top:78px;\' name=\'P" +
"opulateRDOrdInvCreated\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.PopulateRDOrdInvCreated ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateRDOrdInvCreated\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                      Write(!Model.PopulateRDOrdInvCreated ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 8864), Tuple.Create("\'", 8937)
, Tuple.Create(Tuple.Create("", 8872), Tuple.Create("IQLabel103651", 8872), true)
, Tuple.Create(Tuple.Create(" ", 8885), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdCustOrd.LabelVisible ? " hide " : ""
, 8886), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8938), Tuple.Create("\'", 9152)
                  , Tuple.Create(Tuple.Create("", 8947), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdCustOrd.BackHEXColor) ? "" : "color:" + Model.RDOrdCustOrd.BackHEXColor + ";"
, 8947), false)
, Tuple.Create(Tuple.Create("", 9059), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:515px;height:21px;width:12" +
"0px;top:3px;", 9059), true)
);
WriteLiteral(">Client Order No</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdCustOrd\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.RDOrdCustOrd.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdCustOrd/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdCustOrd/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdCustOrd\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.RDOrdCustOrd.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:640px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 9783), Tuple.Create("\'", 9854)
, Tuple.Create(Tuple.Create("", 9791), Tuple.Create("IQLabel103652", 9791), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 9804), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdJobNo.LabelVisible ? " hide " : ""
, 9805), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9855), Tuple.Create("\'", 10065)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 9864), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdJobNo.BackHEXColor) ? "" : "color:" + Model.RDOrdJobNo.BackHEXColor + ";"
, 9864), false)
, Tuple.Create(Tuple.Create("", 9972), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:555px;height:21px;width:80" +
"px;top:28px;", 9972), true)
);
WriteLiteral(">Job Number</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:640px;height:21px;width:160px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'REDSOrderHeader_RDOrdJobNo\'");
                                             Write(Model.RecordLocked || !Model.RDOrdJobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdJobNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdJobNo/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                                               Write(!Model.RDOrdJobNo.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/REDSOrder/AutoCompleteRDOrdJobNo/");
                                                   Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateRDOrdJobNo\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateRDOrdJobNo.ToString() != "" && Model.PopulateRDOrdJobNo.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.RDOrdJobNo.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateRDOrdJobNo]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 11760), Tuple.Create("\'", 11835)
, Tuple.Create(Tuple.Create("", 11768), Tuple.Create("IQLabel103653", 11768), true)
, Tuple.Create(Tuple.Create(" ", 11781), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdJobLetter.LabelVisible ? " hide " : ""
, 11782), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 11836), Tuple.Create("\'", 12055)
                               , Tuple.Create(Tuple.Create("", 11845), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdJobLetter.BackHEXColor) ? "" : "color:" + Model.RDOrdJobLetter.BackHEXColor + ";"
, 11845), false)
, Tuple.Create(Tuple.Create("", 11961), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:515px;height:21px;width:12" +
"0px;top:53px;", 11961), true)
);
WriteLiteral(">Job Letter</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdJobLetter\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdJobLetter.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.RDOrdJobLetter.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdJobLetter/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdJobLetter/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdJobLetter\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.RDOrdJobLetter.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:640px;height:21px;width:40px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 12695), Tuple.Create("\'", 12767)
, Tuple.Create(Tuple.Create("", 12703), Tuple.Create("IQLabel103654", 12703), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 12716), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdLocked.LabelVisible ? " hide " : ""
, 12717), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12768), Tuple.Create("\'", 12981)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 12777), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdLocked.BackHEXColor) ? "" : "color:" + Model.RDOrdLocked.BackHEXColor + ";"
, 12777), false)
, Tuple.Create(Tuple.Create("", 12887), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:515px;height:21px;width:12" +
"0px;top:78px;", 12887), true)
);
WriteLiteral(">Locked</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdLocked\'");
WriteAttribute("class", Tuple.Create(" class=\'", 13060), Tuple.Create("\'", 13115)
, Tuple.Create(Tuple.Create("  ", 13068), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdLocked.Visible ? " hide " : ""
, 13070), false)
);
WriteLiteral(" ");
                                                                                                                 Write(Model.RecordLocked || !Model.RDOrdLocked.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdLocked/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdLocked/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:640px;height:16px;width:16px;top:78px;\' name=\'P" +
"opulateRDOrdLocked\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.PopulateRDOrdLocked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateRDOrdLocked\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                  Write(!Model.PopulateRDOrdLocked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 13753), Tuple.Create("\'", 13823)
, Tuple.Create(Tuple.Create("", 13761), Tuple.Create("IQLabel103655", 13761), true)
, Tuple.Create(Tuple.Create(" ", 13774), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdHM10.LabelVisible ? " hide " : ""
, 13775), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13824), Tuple.Create("\'", 14033)
              , Tuple.Create(Tuple.Create("", 13833), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdHM10.BackHEXColor) ? "" : "color:" + Model.RDOrdHM10.BackHEXColor + ";"
, 13833), false)
, Tuple.Create(Tuple.Create("", 13939), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:575px;height:21px;width:60" +
"px;top:103px;", 13939), true)
);
WriteLiteral(">HM10</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdHM10\'");
WriteAttribute("class", Tuple.Create(" class=\'", 14108), Tuple.Create("\'", 14161)
, Tuple.Create(Tuple.Create("  ", 14116), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdHM10.Visible ? " hide " : ""
, 14118), false)
);
WriteLiteral(" ");
                                                                                                             Write(Model.RecordLocked || !Model.RDOrdHM10.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdHM10/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdHM10/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:640px;height:16px;width:16px;top:103px;\' name=\'" +
"PopulateRDOrdHM10\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PopulateRDOrdHM10 ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateRDOrdHM10\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                Write(!Model.PopulateRDOrdHM10 ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 14786), Tuple.Create("\'", 14857)
, Tuple.Create(Tuple.Create("", 14794), Tuple.Create("IQLabel103673", 14794), true)
, Tuple.Create(Tuple.Create(" ", 14807), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdARCNo.LabelVisible ? " hide " : ""
, 14808), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14858), Tuple.Create("\'", 15068)
               , Tuple.Create(Tuple.Create("", 14867), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdARCNo.BackHEXColor) ? "" : "color:" + Model.RDOrdARCNo.BackHEXColor + ";"
, 14867), false)
, Tuple.Create(Tuple.Create("", 14975), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:695px;height:21px;width:80" +
"px;top:53px;", 14975), true)
);
WriteLiteral(">ARC Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdARCNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.RDOrdARCNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.RDOrdARCNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdARCNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdARCNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateRDOrdARCNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.RDOrdARCNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:780px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 15681), Tuple.Create("\'", 15755)
, Tuple.Create(Tuple.Create("", 15689), Tuple.Create("IQLabel103674", 15689), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 15702), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDutyPaid.LabelVisible ? " hide " : ""
, 15703), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 15756), Tuple.Create("\'", 15972)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 15765), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.RDOrdDutyPaid.BackHEXColor) ? "" : "color:" + Model.RDOrdDutyPaid.BackHEXColor + ";"
, 15765), false)
, Tuple.Create(Tuple.Create("", 15879), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:695px;height:21px;width:80" +
"px;top:78px;", 15879), true)
);
WriteLiteral(">Duty Paid</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'REDSOrderHeader_RDOrdDutyPaid\'");
WriteAttribute("class", Tuple.Create(" class=\'", 16056), Tuple.Create("\'", 16113)
, Tuple.Create(Tuple.Create("  ", 16064), Tuple.Create<System.Object, System.Int32>(!Model.RDOrdDutyPaid.Visible ? " hide " : ""
, 16066), false)
);
WriteLiteral(" ");
                                                                                                                     Write(Model.RecordLocked || !Model.RDOrdDutyPaid.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDutyPaid/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/REDSOrder/CallbackRDOrdDutyPaid/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:780px;height:16px;width:16px;top:78px;\' name=\'P" +
"opulateRDOrdDutyPaid\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.PopulateRDOrdDutyPaid ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateRDOrdDutyPaid\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                    Write(!Model.PopulateRDOrdDutyPaid ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Edit_1.cshtml")]
    public partial class Views_REDSOrder_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Edit_1_cshtml()
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
WriteLiteral(" href=\"/REDSOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Order Header</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 418), Tuple.Create("\'", 481)
, Tuple.Create(Tuple.Create("", 428), Tuple.Create("IQJSCall(\"/REDSOrder/Delete/?RecId=", 428), true)
          , Tuple.Create(Tuple.Create("", 463), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 463), false)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("\");", 478), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"der/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1381), Tuple.Create("\'", 1403)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1449), Tuple.Create("\'", 1473)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.RDOrdIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2140)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/REDSOrder/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2074), false)
, Tuple.Create(Tuple.Create("", 2089), Tuple.Create("&dt=", 2089), true)
, Tuple.Create(Tuple.Create("", 2093), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2093), false)
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
WriteLiteral(" id=\"REDSOrderHeader\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrder_REDSOrderHeader.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2930), Tuple.Create("\'", 3036)
, Tuple.Create(Tuple.Create("", 2938), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrdLine" ? "active" :  "") : "" )
, 2938), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSOrdLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS Order Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3239), Tuple.Create("\'", 3341)
, Tuple.Create(Tuple.Create("", 3247), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSEAD" ? "active" :  "") : "" )
, 3247), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSEAD\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS eAD Numbers</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3549), Tuple.Create("\"", 3564)
, Tuple.Create(Tuple.Create("", 3556), Tuple.Create("#", 3556), true)
, Tuple.Create(Tuple.Create("", 3557), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3557), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSOrdLine" ? "data-loadTarget='#d1880cb0c43b43be815a646b21e85834' data-dynamicContent='/REDSOrdLine/ListFromQuery?Limit=50&Ord=RDOLLineNo&Clause=RDOLRDId=" + Model.RDOrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                                Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrdLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSOrdLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/REDSOrdLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSOrdLine") {
                      Html.RenderPartial("~/Views/REDSOrdLine_List_1.cshtml", Model.REDSOrdLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"d1880cb0c43b43be815a646b21e85834\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "REDS eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSEAD" ? "data-loadTarget='#49f0993ac39746638b2cb3590cea25e0' data-dynamicContent='/REDSEAD/ListFromQuery?Limit=50&Ord=RDEADId&Clause=RDEADRDId=" + Model.RDOrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                      Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSEAD" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSEAD\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/REDSEAD/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS eAD Numbers</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSEAD") {
                      Html.RenderPartial("~/Views/REDSEAD_List_1.cshtml", Model.REDSEADs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"49f0993ac39746638b2cb3590cea25e0\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 5806), Tuple.Create("\"", 5818)
, Tuple.Create(Tuple.Create("", 5811), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5811), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Add_1.cshtml")]
    public partial class Views_REDSOrder_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Header";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Header\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSOrderHeader\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrder_REDSOrderHeader.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_List_1.cshtml")]
    public partial class Views_REDSOrder_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrder>>
    {
        public Views_REDSOrder_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Header List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Header List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Header</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 603)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/REDSOrder/ListFromQuery/?Clause=", 538), true)
                                                                     , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 571), false)
, Tuple.Create(Tuple.Create("", 586), Tuple.Create("&Ord=", 586), true)
                                                                                         , Tuple.Create(Tuple.Create("", 591), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 591), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client ID</th><th>Job Number</th><th>Job Le" +
"tter</th><th>REDS ID</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 959), Tuple.Create("\"", 1002)
, Tuple.Create(Tuple.Create("", 966), Tuple.Create("/REDSOrder/Load/?RecId=", 966), true)
                  , Tuple.Create(Tuple.Create("", 989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 989), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1346)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdOrder/?RecId=", 1266), true)
                                                                         , Tuple.Create(Tuple.Create("", 1322), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1322), false)
, Tuple.Create(Tuple.Create("", 1335), Tuple.Create("\',$(this));", 1335), true)
);
WriteLiteral(" data-bound-name=\'RDOrdOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1450)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdOrder.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1640), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1651), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdCustId/?RecId=", 1651), true)
                                                                          , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1708), false)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create("\',$(this));", 1721), true)
);
WriteLiteral(" data-bound-name=\'RDOrdCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1794), Tuple.Create("\'", 1838)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdCustId.HTMLValue)
, 1802), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/REDSOrder/AutoCompleteRDOrdJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2077), Tuple.Create("\"", 2168)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobNo/?RecId=", 2088), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 2144), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2144), false)
, Tuple.Create(Tuple.Create("", 2157), Tuple.Create("\',$(this));", 2157), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'RDOrdJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.RDOrdJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2473), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2484), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobLetter/?RecId=", 2484), true)
                                                                             , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral(" data-bound-name=\'RDOrdJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2633), Tuple.Create("\'", 2680)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 2641), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdJobLetter.HTMLValue)
, 2641), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOrdId.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Edit_2.cshtml")]
    public partial class Views_REDSOrder_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Edit_2_cshtml()
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
WriteLiteral(" href=\"/REDSOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Order Header</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 418), Tuple.Create("\'", 481)
, Tuple.Create(Tuple.Create("", 428), Tuple.Create("IQJSCall(\"/REDSOrder/Delete/?RecId=", 428), true)
          , Tuple.Create(Tuple.Create("", 463), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 463), false)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("\");", 478), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"der/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1381), Tuple.Create("\'", 1403)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1449), Tuple.Create("\'", 1473)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.RDOrdIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2140)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/REDSOrder/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2074), false)
, Tuple.Create(Tuple.Create("", 2089), Tuple.Create("&dt=", 2089), true)
, Tuple.Create(Tuple.Create("", 2093), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2093), false)
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
WriteLiteral(" id=\"REDSOrderHeader\"");
WriteLiteral(" style=\'position:relative;height:154px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrder_REDSOrderHeader.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Lines").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 2930), Tuple.Create("\'", 3036)
, Tuple.Create(Tuple.Create("", 2938), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrdLine" ? "active" :  "") : "" )
, 2938), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSOrdLine\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS Order Lines</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3239), Tuple.Create("\'", 3341)
, Tuple.Create(Tuple.Create("", 3247), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSEAD" ? "active" :  "") : "" )
, 3247), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#REDSEAD\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">REDS eAD Numbers</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 3549), Tuple.Create("\"", 3564)
, Tuple.Create(Tuple.Create("", 3556), Tuple.Create("#", 3556), true)
, Tuple.Create(Tuple.Create("", 3557), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3557), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "REDS Order Lines").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSOrdLine" ? "data-loadTarget='#1c5f634b82334627aa30dce16420f136' data-dynamicContent='/REDSOrdLine/ListFromQuery?Limit=50&Ord=RDOLLineNo&Clause=RDOLRDId=" + Model.RDOrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                                Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSOrdLine" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSOrdLine\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/REDSOrdLine/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Lines</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSOrdLine") {
                      Html.RenderPartial("~/Views/REDSOrdLine_List_2.cshtml", Model.REDSOrdLines);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"1c5f634b82334627aa30dce16420f136\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "REDS eAD Numbers").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "REDSEAD" ? "data-loadTarget='#c2e6f135ac7043deab2ab29bdda028a8' data-dynamicContent='/REDSEAD/ListFromQuery?Limit=50&Ord=RDEADId&Clause=RDEADRDId=" + Model.RDOrdIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                      Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "REDSEAD" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"REDSEAD\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/REDSEAD/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS eAD Numbers</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "REDSEAD") {
                      Html.RenderPartial("~/Views/REDSEAD_List_2.cshtml", Model.REDSEADs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"c2e6f135ac7043deab2ab29bdda028a8\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 5806), Tuple.Create("\"", 5818)
, Tuple.Create(Tuple.Create("", 5811), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5811), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Add_2.cshtml")]
    public partial class Views_REDSOrder_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Header";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Header\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"REDSOrderHeader\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/REDSOrder_REDSOrderHeader.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_List_2.cshtml")]
    public partial class Views_REDSOrder_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrder>>
    {
        public Views_REDSOrder_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Header List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Header List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Header</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 603)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/REDSOrder/ListFromQuery/?Clause=", 538), true)
                                                                     , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 571), false)
, Tuple.Create(Tuple.Create("", 586), Tuple.Create("&Ord=", 586), true)
                                                                                         , Tuple.Create(Tuple.Create("", 591), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 591), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client ID</th><th>Job Number</th><th>Job Le" +
"tter</th><th>REDS ID</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 959), Tuple.Create("\"", 1002)
, Tuple.Create(Tuple.Create("", 966), Tuple.Create("/REDSOrder/Load/?RecId=", 966), true)
                  , Tuple.Create(Tuple.Create("", 989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 989), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1346)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdOrder/?RecId=", 1266), true)
                                                                         , Tuple.Create(Tuple.Create("", 1322), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1322), false)
, Tuple.Create(Tuple.Create("", 1335), Tuple.Create("\',$(this));", 1335), true)
);
WriteLiteral(" data-bound-name=\'RDOrdOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1450)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdOrder.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1640), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1651), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdCustId/?RecId=", 1651), true)
                                                                          , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1708), false)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create("\',$(this));", 1721), true)
);
WriteLiteral(" data-bound-name=\'RDOrdCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1794), Tuple.Create("\'", 1838)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdCustId.HTMLValue)
, 1802), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/REDSOrder/AutoCompleteRDOrdJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2077), Tuple.Create("\"", 2168)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobNo/?RecId=", 2088), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 2144), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2144), false)
, Tuple.Create(Tuple.Create("", 2157), Tuple.Create("\',$(this));", 2157), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'RDOrdJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.RDOrdJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2473), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2484), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobLetter/?RecId=", 2484), true)
                                                                             , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral(" data-bound-name=\'RDOrdJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2633), Tuple.Create("\'", 2680)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 2641), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdJobLetter.HTMLValue)
, 2641), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOrdId.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Edit_3.cshtml")]
    public partial class Views_REDSOrder_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Edit_3_cshtml()
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
WriteLiteral(" href=\"/REDSOrder/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add REDS Order Header</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 418), Tuple.Create("\'", 481)
, Tuple.Create(Tuple.Create("", 428), Tuple.Create("IQJSCall(\"/REDSOrder/Delete/?RecId=", 428), true)
          , Tuple.Create(Tuple.Create("", 463), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 463), false)
, Tuple.Create(Tuple.Create("", 478), Tuple.Create("\");", 478), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/REDSOr" +
"der/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("REDSOrder", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1381), Tuple.Create("\'", 1403)
, Tuple.Create(Tuple.Create("", 1389), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1389), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1449), Tuple.Create("\'", 1473)
, Tuple.Create(Tuple.Create("", 1457), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1457), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"REDSOrder\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1576), Tuple.Create("\"", 1603)
, Tuple.Create(Tuple.Create("", 1584), Tuple.Create<System.Object, System.Int32>(Model.RDOrdIdValue
, 1584), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1649), Tuple.Create("\"", 1672)
, Tuple.Create(Tuple.Create("", 1657), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1657), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1714), Tuple.Create("\"", 1737)
, Tuple.Create(Tuple.Create("", 1722), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1722), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/REDSOrder/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2037), Tuple.Create("\"", 2140)
, Tuple.Create(Tuple.Create("", 2044), Tuple.Create("/REDSOrder/ViewHistory/?RecId=", 2044), true)
, Tuple.Create(Tuple.Create("", 2074), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2074), false)
, Tuple.Create(Tuple.Create("", 2089), Tuple.Create("&dt=", 2089), true)
, Tuple.Create(Tuple.Create("", 2093), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2093), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2732), Tuple.Create("\"", 2747)
, Tuple.Create(Tuple.Create("", 2739), Tuple.Create("#", 2739), true)
, Tuple.Create(Tuple.Create("", 2740), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2740), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2963), Tuple.Create("\"", 2975)
, Tuple.Create(Tuple.Create("", 2968), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2968), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_Add_3.cshtml")]
    public partial class Views_REDSOrder_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.REDSOrder>
    {
        public Views_REDSOrder_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add REDS Order Header";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add REDS Order Header\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/REDSOrder/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<REDSOrder>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/REDSOrder_List_3.cshtml")]
    public partial class Views_REDSOrder_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.REDSOrder>>
    {
        public Views_REDSOrder_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "REDS Order Header List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"REDS Order Header List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add REDS Order Header</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/REDSOrder/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 531), Tuple.Create("\"", 603)
, Tuple.Create(Tuple.Create("", 538), Tuple.Create("/REDSOrder/ListFromQuery/?Clause=", 538), true)
                                                                     , Tuple.Create(Tuple.Create("", 571), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 571), false)
, Tuple.Create(Tuple.Create("", 586), Tuple.Create("&Ord=", 586), true)
                                                                                         , Tuple.Create(Tuple.Create("", 591), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 591), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Order Number</th><th>Client ID</th><th>Job Number</th><th>Job Le" +
"tter</th><th>REDS ID</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 959), Tuple.Create("\"", 1002)
, Tuple.Create(Tuple.Create("", 966), Tuple.Create("/REDSOrder/Load/?RecId=", 966), true)
                  , Tuple.Create(Tuple.Create("", 989), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 989), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdOrder.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1255), Tuple.Create("\"", 1346)
, Tuple.Create(Tuple.Create("", 1266), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdOrder/?RecId=", 1266), true)
                                                                         , Tuple.Create(Tuple.Create("", 1322), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1322), false)
, Tuple.Create(Tuple.Create("", 1335), Tuple.Create("\',$(this));", 1335), true)
);
WriteLiteral(" data-bound-name=\'RDOrdOrder\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1407), Tuple.Create("\'", 1450)
                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 1415), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdOrder.HTMLValue)
, 1415), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdCustId.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:18%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1640), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1651), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdCustId/?RecId=", 1651), true)
                                                                          , Tuple.Create(Tuple.Create("", 1708), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1708), false)
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create("\',$(this));", 1721), true)
);
WriteLiteral(" data-bound-name=\'RDOrdCustId\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1794), Tuple.Create("\'", 1838)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1802), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdCustId.HTMLValue)
, 1802), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-ajax--url=\'/REDSOrder/AutoCompleteRDOrdJobNo/\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2077), Tuple.Create("\"", 2168)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobNo/?RecId=", 2088), true)
                                                                                                                           , Tuple.Create(Tuple.Create("", 2144), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2144), false)
, Tuple.Create(Tuple.Create("", 2157), Tuple.Create("\',$(this));", 2157), true)
);
WriteLiteral("class=\'form-control searchautocomplete\'");
WriteLiteral(" data-bound-name=\'RDOrdJobNo\'");
WriteLiteral("  >");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(itm.RDOrdJobNo.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.RDOrdJobLetter.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:23%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2473), Tuple.Create("\"", 2568)
, Tuple.Create(Tuple.Create("", 2484), Tuple.Create("javascript:IQAutoSave(\'/REDSOrder/SaveRDOrdJobLetter/?RecId=", 2484), true)
                                                                             , Tuple.Create(Tuple.Create("", 2544), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2544), false)
, Tuple.Create(Tuple.Create("", 2557), Tuple.Create("\',$(this));", 2557), true)
);
WriteLiteral(" data-bound-name=\'RDOrdJobLetter\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2633), Tuple.Create("\'", 2680)
                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 2641), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.RDOrdJobLetter.HTMLValue)
, 2641), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.RDOrdId.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
