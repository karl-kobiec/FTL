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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_CustomerContacts.cshtml")]
    public partial class Views_Contact_CustomerContacts_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_CustomerContacts_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel100211", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.ContFN.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 332)
     , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContFN.BackHEXColor) ? "" : "color:" + Model.ContFN.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 240), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 240), true)
);
WriteLiteral(">Forename</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContFN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContFN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                             Write(!Model.ContFN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContFN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContFN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContFN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.ContFN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 921), Tuple.Create("\'", 991)
, Tuple.Create(Tuple.Create("", 929), Tuple.Create("IQLabel100212", 929), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 942), Tuple.Create<System.Object, System.Int32>(!Model.ContPhone.LabelVisible ? " hide " : ""
, 943), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 992), Tuple.Create("\'", 1200)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1001), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContPhone.BackHEXColor) ? "" : "color:" + Model.ContPhone.BackHEXColor + ";"
, 1001), false)
, Tuple.Create(Tuple.Create("", 1107), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 1107), true)
);
WriteLiteral(">Phone</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContPhone\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContPhone.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.ContPhone.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContPhone/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContPhone/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContPhone\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.ContPhone.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:240px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 1799), Tuple.Create("\'", 1867)
, Tuple.Create(Tuple.Create("", 1807), Tuple.Create("IQLabel100213", 1807), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 1820), Tuple.Create<System.Object, System.Int32>(!Model.ContFax.LabelVisible ? " hide " : ""
, 1821), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1868), Tuple.Create("\'", 2072)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 1877), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContFax.BackHEXColor) ? "" : "color:" + Model.ContFax.BackHEXColor + ";"
, 1877), false)
, Tuple.Create(Tuple.Create("", 1979), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 1979), true)
);
WriteLiteral(">Fax</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContFax\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContFax.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.ContFax.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContFax/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContFax/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContFax\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.ContFax.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:240px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 2655), Tuple.Create("\'", 2722)
, Tuple.Create(Tuple.Create("", 2663), Tuple.Create("IQLabel100214", 2663), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 2676), Tuple.Create<System.Object, System.Int32>(!Model.ContEM.LabelVisible ? " hide " : ""
, 2677), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2723), Tuple.Create("\'", 2925)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 2732), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContEM.BackHEXColor) ? "" : "color:" + Model.ContEM.BackHEXColor + ";"
, 2732), false)
, Tuple.Create(Tuple.Create("", 2832), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 2832), true)
);
WriteLiteral(">E-Mail</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:240px;top:203px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContEM\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContEM.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.ContEM.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContEM/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContEM/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContEM\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.ContEM.ValueFormatted);
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
WriteLiteral(">\r\n\t\t\t\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:IQTargetButton(this)\'");
WriteLiteral(" data-target=\"*[name=PopulateContEM]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4097), Tuple.Create("\'", 4170)
, Tuple.Create(Tuple.Create("", 4105), Tuple.Create("IQLabel100215", 4105), true)
, Tuple.Create(Tuple.Create(" ", 4118), Tuple.Create<System.Object, System.Int32>(!Model.ContJobTitle.LabelVisible ? " hide " : ""
, 4119), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4171), Tuple.Create("\'", 4385)
                              , Tuple.Create(Tuple.Create("", 4180), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContJobTitle.BackHEXColor) ? "" : "color:" + Model.ContJobTitle.BackHEXColor + ";"
, 4180), false)
, Tuple.Create(Tuple.Create("", 4292), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 4292), true)
);
WriteLiteral(">Job Title</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContJobTitle\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContJobTitle.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.ContJobTitle.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContJobTitle/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContJobTitle/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContJobTitle\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.ContJobTitle.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5009), Tuple.Create("\'", 5076)
, Tuple.Create(Tuple.Create("", 5017), Tuple.Create("IQLabel100216", 5017), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 5030), Tuple.Create<System.Object, System.Int32>(!Model.ContSN.LabelVisible ? " hide " : ""
, 5031), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5077), Tuple.Create("\'", 5278)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 5086), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContSN.BackHEXColor) ? "" : "color:" + Model.ContSN.BackHEXColor + ";"
, 5086), false)
, Tuple.Create(Tuple.Create("", 5186), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 5186), true)
);
WriteLiteral(">Surname</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContSN\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContSN.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                             Write(!Model.ContSN.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContSN/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContSN/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContSN\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.ContSN.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 5866), Tuple.Create("\'", 5935)
, Tuple.Create(Tuple.Create("", 5874), Tuple.Create("IQLabel100217", 5874), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 5887), Tuple.Create<System.Object, System.Int32>(!Model.ContName.LabelVisible ? " hide " : ""
, 5888), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5936), Tuple.Create("\'", 6142)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 5945), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContName.BackHEXColor) ? "" : "color:" + Model.ContName.BackHEXColor + ";"
, 5945), false)
, Tuple.Create(Tuple.Create("", 6049), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 6049), true)
);
WriteLiteral(">Full Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContName\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 6237), Tuple.Create("\'", 6302)
, Tuple.Create(Tuple.Create("", 6245), Tuple.Create("form-control", 6245), true)
, Tuple.Create(Tuple.Create("   ", 6257), Tuple.Create<System.Object, System.Int32>(!Model.ContName.Visible ? " hide " : ""
, 6260), false)
);
WriteLiteral(" ");
                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                              Write(Model.ContName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:160px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6680), Tuple.Create("\'", 6747)
, Tuple.Create(Tuple.Create("", 6688), Tuple.Create("IQLabel100218", 6688), true)
                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 6701), Tuple.Create<System.Object, System.Int32>(!Model.ContId.LabelVisible ? " hide " : ""
, 6702), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6748), Tuple.Create("\'", 6948)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 6757), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContId.BackHEXColor) ? "" : "color:" + Model.ContId.BackHEXColor + ";"
, 6757), false)
, Tuple.Create(Tuple.Create("", 6857), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 6857), true)
);
WriteLiteral(">Contact ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 7042), Tuple.Create("\'", 7105)
, Tuple.Create(Tuple.Create("", 7050), Tuple.Create("form-control", 7050), true)
, Tuple.Create(Tuple.Create("   ", 7062), Tuple.Create<System.Object, System.Int32>(!Model.ContId.Visible ? " hide " : ""
, 7065), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                      Write(Model.ContId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7472), Tuple.Create("\'", 7541)
, Tuple.Create(Tuple.Create("", 7480), Tuple.Create("IQLabel100219", 7480), true)
                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 7493), Tuple.Create<System.Object, System.Int32>(!Model.ContCust.LabelVisible ? " hide " : ""
, 7494), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7542), Tuple.Create("\'", 7747)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 7551), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContCust.BackHEXColor) ? "" : "color:" + Model.ContCust.BackHEXColor + ";"
, 7551), false)
, Tuple.Create(Tuple.Create("", 7655), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 7655), true)
);
WriteLiteral(">Company</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'CustomerContacts_ContCust\'");
WriteLiteral("disabled=disabled");
WriteLiteral("  ");
                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContCust/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                          Write(!Model.ContCust.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Contact/AutoCompleteContCust/");
                                               Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateContCust\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateContCust.ToString() != "" && Model.PopulateContCust.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.ContCust.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateContCust]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 9368), Tuple.Create("\'", 9438)
, Tuple.Create(Tuple.Create("", 9376), Tuple.Create("IQLabel100231", 9376), true)
, Tuple.Create(Tuple.Create(" ", 9389), Tuple.Create<System.Object, System.Int32>(!Model.ContNotes.LabelVisible ? " hide " : ""
, 9390), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9439), Tuple.Create("\'", 9648)
                           , Tuple.Create(Tuple.Create("", 9448), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContNotes.BackHEXColor) ? "" : "color:" + Model.ContNotes.BackHEXColor + ";"
, 9448), false)
, Tuple.Create(Tuple.Create("", 9554), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:10" +
"0px;top:28px;", 9554), true)
);
WriteLiteral(">Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'360\'");
WriteLiteral(" style=\'position: absolute; left:400px;height:71px;width:360px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Notes\'");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                              Write(Model.RecordLocked || !Model.ContNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(!Model.ContNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateContNotes\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.PopulateContNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateContNotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10824), Tuple.Create("\'", 10900)
, Tuple.Create(Tuple.Create("", 10832), Tuple.Create("IQLabel100232", 10832), true)
, Tuple.Create(Tuple.Create(" ", 10845), Tuple.Create<System.Object, System.Int32>(!Model.ContMainContact.LabelVisible ? " hide " : ""
, 10846), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10901), Tuple.Create("\'", 11121)
                                    , Tuple.Create(Tuple.Create("", 10910), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContMainContact.BackHEXColor) ? "" : "color:" + Model.ContMainContact.BackHEXColor + ";"
, 10910), false)
, Tuple.Create(Tuple.Create("", 11028), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:275px;height:21px;width:12" +
"0px;top:3px;", 11028), true)
);
WriteLiteral(">Main Contact</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'CustomerContacts_ContMainContact\'");
WriteAttribute("class", Tuple.Create(" class=\'", 11211), Tuple.Create("\'", 11270)
, Tuple.Create(Tuple.Create("  ", 11219), Tuple.Create<System.Object, System.Int32>(!Model.ContMainContact.Visible ? " hide " : ""
, 11221), false)
);
WriteLiteral(" ");
                                                                                                                          Write(Model.RecordLocked || !Model.ContMainContact.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContMainContact/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContMainContact/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:400px;height:16px;width:16px;top:3px;\' name=\'Po" +
"pulateContMainContact\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.PopulateContMainContact ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateContMainContact\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                      Write(!Model.PopulateContMainContact ? "checked=checked" : "");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Contacts.cshtml")]
    public partial class Views_Contact_Contacts_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Contacts_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 132)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel107801", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.ContName.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 133), Tuple.Create("\'", 337)
       , Tuple.Create(Tuple.Create("", 142), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContName.BackHEXColor) ? "" : "color:" + Model.ContName.BackHEXColor + ";"
, 142), false)
, Tuple.Create(Tuple.Create("", 246), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 246), true)
);
WriteLiteral(">Full Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Contacts_ContName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.ContName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.ContName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateContName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.ContName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:120px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 923), Tuple.Create("\'", 992)
, Tuple.Create(Tuple.Create("", 931), Tuple.Create("IQLabel107802", 931), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 944), Tuple.Create<System.Object, System.Int32>(!Model.ContCust.LabelVisible ? " hide " : ""
, 945), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 993), Tuple.Create("\'", 1199)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1002), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.ContCust.BackHEXColor) ? "" : "color:" + Model.ContCust.BackHEXColor + ";"
, 1002), false)
, Tuple.Create(Tuple.Create("", 1106), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:220px;height:21px;width:12" +
"0px;top:3px;", 1106), true)
);
WriteLiteral(">Company</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'120\'");
WriteLiteral(" style=\'position: absolute; left:345px;height:21px;width:120px;top:3px;\'");
WriteLiteral("><select");
WriteLiteral(" \r\n\t data-ScreenInfo=\'Contacts_ContCust\'");
                                    Write(Model.RecordLocked || !Model.ContCust.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Contact/SaveContCust/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Contact/CallbackContCust/',$(this));\""));
WriteLiteral("  class=\'form-control popover   ");
                                                                                                                                                                                                                                                                                                                                                                            Write(!Model.ContCust.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete \' \r\n\t data-ajax--url=\'/Contact/AutoCompleteContCust/");
                                               Write(Model.RecordID.HasValue ? Model.RecordID.Value.ToString() : "");
WriteLiteral("\'  name=\'PopulateContCust\'  style=\'height:21px\'>\r\n");
                 if(Model.PopulateContCust.ToString() != "" && Model.PopulateContCust.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.ContCust.HTMLValue));
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
WriteLiteral(" data-target=\"*[name=PopulateContCust]\"");
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
WriteLiteral(" />View All Customers</a></li>\r\n\t\t</div></div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Edit_1.cshtml")]
    public partial class Views_Contact_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Edit_1_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/Contact/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Contac" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Contact", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Contact\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1508)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.ContIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1577)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1619), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1627), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Contact/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1940), Tuple.Create("\"", 2041)
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create("/Contact/ViewHistory/?RecId=", 1947), true)
, Tuple.Create(Tuple.Create("", 1975), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1975), false)
, Tuple.Create(Tuple.Create("", 1990), Tuple.Create("&dt=", 1990), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1994), false)
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
WriteLiteral(" id=\"CustomerContacts\"");
WriteLiteral(" style=\'position:relative;height:589px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Contact_CustomerContacts.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2840), Tuple.Create("\"", 2855)
, Tuple.Create(Tuple.Create("", 2847), Tuple.Create("#", 2847), true)
, Tuple.Create(Tuple.Create("", 2848), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2848), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3071), Tuple.Create("\"", 3083)
, Tuple.Create(Tuple.Create("", 3076), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3076), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Add_1.cshtml")]
    public partial class Views_Contact_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customer Contacts";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customer Contacts\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Contact/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CustomerContacts\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Contact_CustomerContacts.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_List_1.cshtml")]
    public partial class Views_Contact_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Contact>>
    {
        public Views_Contact_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customer Contacts List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customer Contacts List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customer Contacts</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 595)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/Contact/ListFromQuery/?Clause=", 532), true)
                                                                   , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 563), false)
, Tuple.Create(Tuple.Create("", 578), Tuple.Create("&Ord=", 578), true)
                                                                                       , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 583), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Contact ID</th><th>Forename</th><th>Job Title</th><th>Surname</t" +
"h><th>Phone</th><th>Fax</th><th>E-Mail</th><th>Main Contact</th><th>Notes</th>\t\t" +
"</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1004), Tuple.Create("\"", 1045)
, Tuple.Create(Tuple.Create("", 1011), Tuple.Create("/Contact/Load/?RecId=", 1011), true)
               , Tuple.Create(Tuple.Create("", 1032), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1032), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ContId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFN/?RecId=", 1362), true)
                                                                   , Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1412), false)
, Tuple.Create(Tuple.Create("", 1425), Tuple.Create("\',$(this));", 1425), true)
);
WriteLiteral(" data-bound-name=\'ContFN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1493), Tuple.Create("\'", 1532)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1501), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFN.HTMLValue)
, 1501), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContJobTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1723), Tuple.Create("\"", 1814)
, Tuple.Create(Tuple.Create("", 1734), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContJobTitle/?RecId=", 1734), true)
                                                                         , Tuple.Create(Tuple.Create("", 1790), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1790), false)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("\',$(this));", 1803), true)
);
WriteLiteral(" data-bound-name=\'ContJobTitle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1877), Tuple.Create("\'", 1922)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContJobTitle.HTMLValue)
, 1885), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContSN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2107), Tuple.Create("\"", 2192)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContSN/?RecId=", 2118), true)
                                                                   , Tuple.Create(Tuple.Create("", 2168), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2168), false)
, Tuple.Create(Tuple.Create("", 2181), Tuple.Create("\',$(this));", 2181), true)
);
WriteLiteral(" data-bound-name=\'ContSN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2249), Tuple.Create("\'", 2288)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2257), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContSN.HTMLValue)
, 2257), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContPhone.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2476), Tuple.Create("\"", 2564)
, Tuple.Create(Tuple.Create("", 2487), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContPhone/?RecId=", 2487), true)
                                                                      , Tuple.Create(Tuple.Create("", 2540), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2540), false)
, Tuple.Create(Tuple.Create("", 2553), Tuple.Create("\',$(this));", 2553), true)
);
WriteLiteral(" data-bound-name=\'ContPhone\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2624), Tuple.Create("\'", 2666)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContPhone.HTMLValue)
, 2632), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFax.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2852), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2863), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFax/?RecId=", 2863), true)
                                                                    , Tuple.Create(Tuple.Create("", 2914), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2914), false)
, Tuple.Create(Tuple.Create("", 2927), Tuple.Create("\',$(this));", 2927), true)
);
WriteLiteral(" data-bound-name=\'ContFax\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2996), Tuple.Create("\'", 3036)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 3004), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFax.HTMLValue)
, 3004), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3221), Tuple.Create("\"", 3306)
, Tuple.Create(Tuple.Create("", 3232), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContEM/?RecId=", 3232), true)
                                                                   , Tuple.Create(Tuple.Create("", 3282), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3282), false)
, Tuple.Create(Tuple.Create("", 3295), Tuple.Create("\',$(this));", 3295), true)
);
WriteLiteral(" data-bound-name=\'ContEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3363), Tuple.Create("\'", 3402)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 3371), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContEM.HTMLValue)
, 3371), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContMainContact.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3577), Tuple.Create("\"", 3670)
, Tuple.Create(Tuple.Create("", 3587), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContMainContact/?RecId=", 3587), true)
                                                        , Tuple.Create(Tuple.Create("", 3646), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3646), false)
, Tuple.Create(Tuple.Create("", 3659), Tuple.Create("\',$(this));", 3659), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'ContMainContact\'");
WriteLiteral(" ");
                                                                                                                                                                                                            Write(Html.Raw(itm.ContMainContact.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'ContMainContact\' value=\'false\'  /></td" +
">\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4020), Tuple.Create("\"", 4108)
, Tuple.Create(Tuple.Create("", 4031), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContNotes/?RecId=", 4031), true)
                                                                      , Tuple.Create(Tuple.Create("", 4084), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4084), false)
, Tuple.Create(Tuple.Create("", 4097), Tuple.Create("\',$(this));", 4097), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'ContNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                            Write(Html.Raw(itm.ContNotes.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Edit_2.cshtml")]
    public partial class Views_Contact_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Edit_2_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/Contact/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Contac" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Contact", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Contact\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1508)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.ContIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1577)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1619), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1627), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Contact/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1940), Tuple.Create("\"", 2041)
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create("/Contact/ViewHistory/?RecId=", 1947), true)
, Tuple.Create(Tuple.Create("", 1975), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1975), false)
, Tuple.Create(Tuple.Create("", 1990), Tuple.Create("&dt=", 1990), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1994), false)
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
WriteLiteral(" id=\"CustomerContacts\"");
WriteLiteral(" style=\'position:relative;height:589px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Contact_CustomerContacts.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2840), Tuple.Create("\"", 2855)
, Tuple.Create(Tuple.Create("", 2847), Tuple.Create("#", 2847), true)
, Tuple.Create(Tuple.Create("", 2848), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2848), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3071), Tuple.Create("\"", 3083)
, Tuple.Create(Tuple.Create("", 3076), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3076), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Add_2.cshtml")]
    public partial class Views_Contact_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customer Contacts";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customer Contacts\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Contact/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"CustomerContacts\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Contact_CustomerContacts.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_List_2.cshtml")]
    public partial class Views_Contact_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Contact>>
    {
        public Views_Contact_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customer Contacts List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customer Contacts List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customer Contacts</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 595)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/Contact/ListFromQuery/?Clause=", 532), true)
                                                                   , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 563), false)
, Tuple.Create(Tuple.Create("", 578), Tuple.Create("&Ord=", 578), true)
                                                                                       , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 583), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Contact ID</th><th>Forename</th><th>Job Title</th><th>Surname</t" +
"h><th>Phone</th><th>Fax</th><th>E-Mail</th><th>Main Contact</th><th>Notes</th>\t\t" +
"</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1004), Tuple.Create("\"", 1045)
, Tuple.Create(Tuple.Create("", 1011), Tuple.Create("/Contact/Load/?RecId=", 1011), true)
               , Tuple.Create(Tuple.Create("", 1032), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1032), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ContId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFN/?RecId=", 1362), true)
                                                                   , Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1412), false)
, Tuple.Create(Tuple.Create("", 1425), Tuple.Create("\',$(this));", 1425), true)
);
WriteLiteral(" data-bound-name=\'ContFN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1493), Tuple.Create("\'", 1532)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1501), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFN.HTMLValue)
, 1501), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContJobTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1723), Tuple.Create("\"", 1814)
, Tuple.Create(Tuple.Create("", 1734), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContJobTitle/?RecId=", 1734), true)
                                                                         , Tuple.Create(Tuple.Create("", 1790), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1790), false)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("\',$(this));", 1803), true)
);
WriteLiteral(" data-bound-name=\'ContJobTitle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1877), Tuple.Create("\'", 1922)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContJobTitle.HTMLValue)
, 1885), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContSN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2107), Tuple.Create("\"", 2192)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContSN/?RecId=", 2118), true)
                                                                   , Tuple.Create(Tuple.Create("", 2168), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2168), false)
, Tuple.Create(Tuple.Create("", 2181), Tuple.Create("\',$(this));", 2181), true)
);
WriteLiteral(" data-bound-name=\'ContSN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2249), Tuple.Create("\'", 2288)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2257), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContSN.HTMLValue)
, 2257), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContPhone.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2476), Tuple.Create("\"", 2564)
, Tuple.Create(Tuple.Create("", 2487), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContPhone/?RecId=", 2487), true)
                                                                      , Tuple.Create(Tuple.Create("", 2540), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2540), false)
, Tuple.Create(Tuple.Create("", 2553), Tuple.Create("\',$(this));", 2553), true)
);
WriteLiteral(" data-bound-name=\'ContPhone\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2624), Tuple.Create("\'", 2666)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContPhone.HTMLValue)
, 2632), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFax.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2852), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2863), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFax/?RecId=", 2863), true)
                                                                    , Tuple.Create(Tuple.Create("", 2914), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2914), false)
, Tuple.Create(Tuple.Create("", 2927), Tuple.Create("\',$(this));", 2927), true)
);
WriteLiteral(" data-bound-name=\'ContFax\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2996), Tuple.Create("\'", 3036)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 3004), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFax.HTMLValue)
, 3004), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3221), Tuple.Create("\"", 3306)
, Tuple.Create(Tuple.Create("", 3232), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContEM/?RecId=", 3232), true)
                                                                   , Tuple.Create(Tuple.Create("", 3282), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3282), false)
, Tuple.Create(Tuple.Create("", 3295), Tuple.Create("\',$(this));", 3295), true)
);
WriteLiteral(" data-bound-name=\'ContEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3363), Tuple.Create("\'", 3402)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 3371), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContEM.HTMLValue)
, 3371), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContMainContact.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3577), Tuple.Create("\"", 3670)
, Tuple.Create(Tuple.Create("", 3587), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContMainContact/?RecId=", 3587), true)
                                                        , Tuple.Create(Tuple.Create("", 3646), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3646), false)
, Tuple.Create(Tuple.Create("", 3659), Tuple.Create("\',$(this));", 3659), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'ContMainContact\'");
WriteLiteral(" ");
                                                                                                                                                                                                            Write(Html.Raw(itm.ContMainContact.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'ContMainContact\' value=\'false\'  /></td" +
">\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4020), Tuple.Create("\"", 4108)
, Tuple.Create(Tuple.Create("", 4031), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContNotes/?RecId=", 4031), true)
                                                                      , Tuple.Create(Tuple.Create("", 4084), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4084), false)
, Tuple.Create(Tuple.Create("", 4097), Tuple.Create("\',$(this));", 4097), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'ContNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                            Write(Html.Raw(itm.ContNotes.HTMLValue));
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Edit_3.cshtml")]
    public partial class Views_Contact_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Edit_3_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 334), Tuple.Create("\'", 395)
, Tuple.Create(Tuple.Create("", 344), Tuple.Create("IQJSCall(\"/Contact/Delete/?RecId=", 344), true)
        , Tuple.Create(Tuple.Create("", 377), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 377), false)
, Tuple.Create(Tuple.Create("", 392), Tuple.Create("\");", 392), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Contac" +
"t/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Contact", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1289), Tuple.Create("\'", 1311)
, Tuple.Create(Tuple.Create("", 1297), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1297), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1357), Tuple.Create("\'", 1381)
, Tuple.Create(Tuple.Create("", 1365), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1365), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Contact\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1482), Tuple.Create("\"", 1508)
, Tuple.Create(Tuple.Create("", 1490), Tuple.Create<System.Object, System.Int32>(Model.ContIdValue
, 1490), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1554), Tuple.Create("\"", 1577)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1562), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1619), Tuple.Create("\"", 1642)
, Tuple.Create(Tuple.Create("", 1627), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1627), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Contact/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 1940), Tuple.Create("\"", 2041)
, Tuple.Create(Tuple.Create("", 1947), Tuple.Create("/Contact/ViewHistory/?RecId=", 1947), true)
, Tuple.Create(Tuple.Create("", 1975), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1975), false)
, Tuple.Create(Tuple.Create("", 1990), Tuple.Create("&dt=", 1990), true)
, Tuple.Create(Tuple.Create("", 1994), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 1994), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2633), Tuple.Create("\"", 2648)
, Tuple.Create(Tuple.Create("", 2640), Tuple.Create("#", 2640), true)
, Tuple.Create(Tuple.Create("", 2641), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2641), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2864), Tuple.Create("\"", 2876)
, Tuple.Create(Tuple.Create("", 2869), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2869), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_Add_3.cshtml")]
    public partial class Views_Contact_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Contact>
    {
        public Views_Contact_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customer Contacts";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customer Contacts\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Contact/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Contact>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Contact_List_3.cshtml")]
    public partial class Views_Contact_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Contact>>
    {
        public Views_Contact_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customer Contacts List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customer Contacts List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customer Contacts</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Contact/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 595)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/Contact/ListFromQuery/?Clause=", 532), true)
                                                                   , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 563), false)
, Tuple.Create(Tuple.Create("", 578), Tuple.Create("&Ord=", 578), true)
                                                                                       , Tuple.Create(Tuple.Create("", 583), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 583), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Contact ID</th><th>Forename</th><th>Job Title</th><th>Surname</t" +
"h><th>Phone</th><th>Fax</th><th>E-Mail</th><th>Main Contact</th><th>Notes</th>\t\t" +
"</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1004), Tuple.Create("\"", 1045)
, Tuple.Create(Tuple.Create("", 1011), Tuple.Create("/Contact/Load/?RecId=", 1011), true)
               , Tuple.Create(Tuple.Create("", 1032), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1032), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                                       Write(itm.ContId.DisplayValue);
WriteLiteral("</td>");
                                                                                          if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1351), Tuple.Create("\"", 1436)
, Tuple.Create(Tuple.Create("", 1362), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFN/?RecId=", 1362), true)
                                                                   , Tuple.Create(Tuple.Create("", 1412), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1412), false)
, Tuple.Create(Tuple.Create("", 1425), Tuple.Create("\',$(this));", 1425), true)
);
WriteLiteral(" data-bound-name=\'ContFN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1493), Tuple.Create("\'", 1532)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 1501), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFN.HTMLValue)
, 1501), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContJobTitle.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1723), Tuple.Create("\"", 1814)
, Tuple.Create(Tuple.Create("", 1734), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContJobTitle/?RecId=", 1734), true)
                                                                         , Tuple.Create(Tuple.Create("", 1790), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1790), false)
, Tuple.Create(Tuple.Create("", 1803), Tuple.Create("\',$(this));", 1803), true)
);
WriteLiteral(" data-bound-name=\'ContJobTitle\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1877), Tuple.Create("\'", 1922)
                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1885), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContJobTitle.HTMLValue)
, 1885), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContSN.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:10%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2107), Tuple.Create("\"", 2192)
, Tuple.Create(Tuple.Create("", 2118), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContSN/?RecId=", 2118), true)
                                                                   , Tuple.Create(Tuple.Create("", 2168), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2168), false)
, Tuple.Create(Tuple.Create("", 2181), Tuple.Create("\',$(this));", 2181), true)
);
WriteLiteral(" data-bound-name=\'ContSN\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2249), Tuple.Create("\'", 2288)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 2257), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContSN.HTMLValue)
, 2257), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContPhone.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2476), Tuple.Create("\"", 2564)
, Tuple.Create(Tuple.Create("", 2487), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContPhone/?RecId=", 2487), true)
                                                                      , Tuple.Create(Tuple.Create("", 2540), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2540), false)
, Tuple.Create(Tuple.Create("", 2553), Tuple.Create("\',$(this));", 2553), true)
);
WriteLiteral(" data-bound-name=\'ContPhone\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2624), Tuple.Create("\'", 2666)
                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 2632), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContPhone.HTMLValue)
, 2632), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContFax.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2852), Tuple.Create("\"", 2938)
, Tuple.Create(Tuple.Create("", 2863), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContFax/?RecId=", 2863), true)
                                                                    , Tuple.Create(Tuple.Create("", 2914), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2914), false)
, Tuple.Create(Tuple.Create("", 2927), Tuple.Create("\',$(this));", 2927), true)
);
WriteLiteral(" data-bound-name=\'ContFax\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2996), Tuple.Create("\'", 3036)
                                                                                                                                                              , Tuple.Create(Tuple.Create("", 3004), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContFax.HTMLValue)
, 3004), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContEM.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:12%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3221), Tuple.Create("\"", 3306)
, Tuple.Create(Tuple.Create("", 3232), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContEM/?RecId=", 3232), true)
                                                                   , Tuple.Create(Tuple.Create("", 3282), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3282), false)
, Tuple.Create(Tuple.Create("", 3295), Tuple.Create("\',$(this));", 3295), true)
);
WriteLiteral(" data-bound-name=\'ContEM\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3363), Tuple.Create("\'", 3402)
                                                                                                                                                            , Tuple.Create(Tuple.Create("", 3371), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.ContEM.HTMLValue)
, 3371), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContMainContact.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:5%\'");
WriteLiteral("><input");
WriteLiteral(" type=\'checkbox\'");
WriteAttribute("onchange", Tuple.Create("onchange=\"", 3577), Tuple.Create("\"", 3670)
, Tuple.Create(Tuple.Create("", 3587), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContMainContact/?RecId=", 3587), true)
                                                        , Tuple.Create(Tuple.Create("", 3646), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3646), false)
, Tuple.Create(Tuple.Create("", 3659), Tuple.Create("\',$(this));", 3659), true)
);
WriteLiteral(" value=\'true\'");
WriteLiteral(" data-bound-name=\'ContMainContact\'");
WriteLiteral(" ");
                                                                                                                                                                                                            Write(Html.Raw(itm.ContMainContact.HTMLValue));
WriteLiteral(" /><input type = \'hidden\' data-bound-name=\'ContMainContact\' value=\'false\'  /></td" +
">\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.ContNotes.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><textarea");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 4020), Tuple.Create("\"", 4108)
, Tuple.Create(Tuple.Create("", 4031), Tuple.Create("javascript:IQAutoSave(\'/Contact/SaveContNotes/?RecId=", 4031), true)
                                                                      , Tuple.Create(Tuple.Create("", 4084), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 4084), false)
, Tuple.Create(Tuple.Create("", 4097), Tuple.Create("\',$(this));", 4097), true)
);
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" data-bound-name=\'ContNotes\'");
WriteLiteral(">");
                                                                                                                                                                                                                            Write(Html.Raw(itm.ContNotes.HTMLValue));
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
