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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_ChangeRequests.cshtml")]
    public partial class Views_ChangeReq_ChangeRequests_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_ChangeRequests_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 65), Tuple.Create("\'", 130)
, Tuple.Create(Tuple.Create("", 73), Tuple.Create("IQLabel105911", 73), true)
, Tuple.Create(Tuple.Create(" ", 86), Tuple.Create<System.Object, System.Int32>(!Model.CRId.LabelVisible ? " hide " : ""
, 87), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 131), Tuple.Create("\'", 327)
   , Tuple.Create(Tuple.Create("", 140), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRId.BackHEXColor) ? "" : "color:" + Model.CRId.BackHEXColor + ";"
, 140), false)
, Tuple.Create(Tuple.Create("", 236), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 236), true)
);
WriteLiteral(">Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 409), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 417), Tuple.Create("form-control", 417), true)
, Tuple.Create(Tuple.Create("   ", 429), Tuple.Create<System.Object, System.Int32>(!Model.CRId.Visible ? " hide " : ""
, 432), false)
);
WriteLiteral(" ");
                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCRId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                  Write(Model.CRId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 833), Tuple.Create("\'", 900)
, Tuple.Create(Tuple.Create("", 841), Tuple.Create("IQLabel105912", 841), true)
                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create(" ", 854), Tuple.Create<System.Object, System.Int32>(!Model.CRDate.LabelVisible ? " hide " : ""
, 855), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 901), Tuple.Create("\'", 1102)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 910), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRDate.BackHEXColor) ? "" : "color:" + Model.CRDate.BackHEXColor + ";"
, 910), false)
, Tuple.Create(Tuple.Create("", 1010), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1010), true)
);
WriteLiteral(">Date Added</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRDate\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRDate.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CRDate.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRDate/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRDate/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCRDate\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.CRDate.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:28px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 1685), Tuple.Create("\'", 1754)
, Tuple.Create(Tuple.Create("", 1693), Tuple.Create("IQLabel105913", 1693), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 1706), Tuple.Create<System.Object, System.Int32>(!Model.CRClosed.LabelVisible ? " hide " : ""
, 1707), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1755), Tuple.Create("\'", 1960)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1764), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRClosed.BackHEXColor) ? "" : "color:" + Model.CRClosed.BackHEXColor + ";"
, 1764), false)
, Tuple.Create(Tuple.Create("", 1868), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1868), true)
);
WriteLiteral(">Date Closed</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRClosed\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRClosed.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CRClosed.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRClosed/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRClosed/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCRClosed\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.CRClosed.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2558), Tuple.Create("\'", 2625)
, Tuple.Create(Tuple.Create("", 2566), Tuple.Create("IQLabel105915", 2566), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 2579), Tuple.Create<System.Object, System.Int32>(!Model.CRType.LabelVisible ? " hide " : ""
, 2580), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2626), Tuple.Create("\'", 2827)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 2635), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRType.BackHEXColor) ? "" : "color:" + Model.CRType.BackHEXColor + ";"
, 2635), false)
, Tuple.Create(Tuple.Create("", 2735), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:60" +
"px;top:3px;", 2735), true)
);
WriteLiteral(">Type</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                     Write(!Model.CRType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRType/',$(this));\""));
WriteLiteral("   name=\'PopulateCRType\'  style=\'position: absolute; left:300px;height:21px;width" +
":160px;top:3px;\'>\r\n");
             foreach(var itm in Model.CRType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 3412), Tuple.Create("\'", 3433)
, Tuple.Create(Tuple.Create("", 3420), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 3420), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCRType.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                       Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3563), Tuple.Create("\'", 3634)
, Tuple.Create(Tuple.Create("", 3571), Tuple.Create("IQLabel105916", 3571), true)
, Tuple.Create(Tuple.Create(" ", 3584), Tuple.Create<System.Object, System.Int32>(!Model.CRPriority.LabelVisible ? " hide " : ""
, 3585), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3635), Tuple.Create("\'", 3845)
                         , Tuple.Create(Tuple.Create("", 3644), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRPriority.BackHEXColor) ? "" : "color:" + Model.CRPriority.BackHEXColor + ";"
, 3644), false)
, Tuple.Create(Tuple.Create("", 3752), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:60" +
"px;top:28px;", 3752), true)
);
WriteLiteral(">Priority</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRPriority\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRPriority.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                         Write(!Model.CRPriority.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRPriority/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRPriority/',$(this));\""));
WriteLiteral("   name=\'PopulateCRPriority\'  style=\'position: absolute; left:300px;height:21px;w" +
"idth:160px;top:28px;\'>\r\n");
             foreach(var itm in Model.CRPriority.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 4463), Tuple.Create("\'", 4484)
, Tuple.Create(Tuple.Create("", 4471), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 4471), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCRPriority.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                           Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4618), Tuple.Create("\'", 4687)
, Tuple.Create(Tuple.Create("", 4626), Tuple.Create("IQLabel105917", 4626), true)
, Tuple.Create(Tuple.Create(" ", 4639), Tuple.Create<System.Object, System.Int32>(!Model.CRStatus.LabelVisible ? " hide " : ""
, 4640), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4688), Tuple.Create("\'", 4894)
                       , Tuple.Create(Tuple.Create("", 4697), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRStatus.BackHEXColor) ? "" : "color:" + Model.CRStatus.BackHEXColor + ";"
, 4697), false)
, Tuple.Create(Tuple.Create("", 4801), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:60" +
"px;top:53px;", 4801), true)
);
WriteLiteral(">Status</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRStatus\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRStatus.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.CRStatus.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRStatus/',$(this));\""));
WriteLiteral("   name=\'PopulateCRStatus\'  style=\'position: absolute; left:300px;height:21px;wid" +
"th:160px;top:53px;\'>\r\n");
             foreach(var itm in Model.CRStatus.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 5496), Tuple.Create("\'", 5517)
, Tuple.Create(Tuple.Create("", 5504), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 5504), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCRStatus.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5649), Tuple.Create("\'", 5716)
, Tuple.Create(Tuple.Create("", 5657), Tuple.Create("IQLabel105919", 5657), true)
, Tuple.Create(Tuple.Create(" ", 5670), Tuple.Create<System.Object, System.Int32>(!Model.CRName.LabelVisible ? " hide " : ""
, 5671), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5717), Tuple.Create("\'", 5918)
                     , Tuple.Create(Tuple.Create("", 5726), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRName.BackHEXColor) ? "" : "color:" + Model.CRName.BackHEXColor + ";"
, 5726), false)
, Tuple.Create(Tuple.Create("", 5826), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 5826), true)
);
WriteLiteral(">Title</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CRName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                             Write(!Model.CRName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCRName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.CRName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:400px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 6506), Tuple.Create("\'", 6575)
, Tuple.Create(Tuple.Create("", 6514), Tuple.Create("IQLabel105921", 6514), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create(" ", 6527), Tuple.Create<System.Object, System.Int32>(!Model.CRIssues.LabelVisible ? " hide " : ""
, 6528), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6576), Tuple.Create("\'", 6781)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 6585), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRIssues.BackHEXColor) ? "" : "color:" + Model.CRIssues.BackHEXColor + ";"
, 6585), false)
, Tuple.Create(Tuple.Create("", 6689), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:5px;height:21px;width:120px" +
";top:103px;", 6689), true)
);
WriteLiteral(">Description</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:5px;height:146px;width:400px;top:128px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Description\'");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRIssues\'");
WriteLiteral(" ");
                                                                                                                                                                                                                 Write(Model.RecordLocked || !Model.CRIssues.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIssues/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRIssues/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.CRIssues.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCRIssues\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateCRIssues);
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
WriteLiteral(" data-target=\"*[name=PopulateCRIssues]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 7964), Tuple.Create("\'", 8034)
, Tuple.Create(Tuple.Create("", 7972), Tuple.Create("IQLabel105923", 7972), true)
, Tuple.Create(Tuple.Create(" ", 7985), Tuple.Create<System.Object, System.Int32>(!Model.CRIqNotes.LabelVisible ? " hide " : ""
, 7986), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8035), Tuple.Create("\'", 8242)
                               , Tuple.Create(Tuple.Create("", 8044), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRIqNotes.BackHEXColor) ? "" : "color:" + Model.CRIqNotes.BackHEXColor + ";"
, 8044), false)
, Tuple.Create(Tuple.Create("", 8150), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:5px;height:21px;width:120px" +
";top:278px;", 8150), true)
);
WriteLiteral(">Intrinsiq Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:5px;height:146px;width:400px;top:303px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Intrinsiq Notes\'");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRIqNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.CRIqNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIqNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRIqNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(!Model.CRIqNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCRIqNotes\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.PopulateCRIqNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateCRIqNotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 9441), Tuple.Create("\'", 9512)
, Tuple.Create(Tuple.Create("", 9449), Tuple.Create("IQLabel105925", 9449), true)
, Tuple.Create(Tuple.Create(" ", 9462), Tuple.Create<System.Object, System.Int32>(!Model.CRResolved.LabelVisible ? " hide " : ""
, 9463), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9513), Tuple.Create("\'", 9724)
                                , Tuple.Create(Tuple.Create("", 9522), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRResolved.BackHEXColor) ? "" : "color:" + Model.CRResolved.BackHEXColor + ";"
, 9522), false)
, Tuple.Create(Tuple.Create("", 9630), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:420px;height:21px;width:120" +
"px;top:103px;", 9630), true)
);
WriteLiteral(">Resolved</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:146px;width:400px;top:128px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Resolved\'");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRResolved\'");
WriteLiteral(" ");
                                                                                                                                                                                                                    Write(Model.RecordLocked || !Model.CRResolved.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRResolved/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRResolved/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(!Model.CRResolved.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCRResolved\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.PopulateCRResolved);
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
WriteLiteral(" data-target=\"*[name=PopulateCRResolved]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 10919), Tuple.Create("\'", 10993)
, Tuple.Create(Tuple.Create("", 10927), Tuple.Create("IQLabel105927", 10927), true)
, Tuple.Create(Tuple.Create(" ", 10940), Tuple.Create<System.Object, System.Int32>(!Model.CRIqNotesArch.LabelVisible ? " hide " : ""
, 10941), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10994), Tuple.Create("\'", 11211)
                                  , Tuple.Create(Tuple.Create("", 11003), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CRIqNotesArch.BackHEXColor) ? "" : "color:" + Model.CRIqNotesArch.BackHEXColor + ";"
, 11003), false)
, Tuple.Create(Tuple.Create("", 11117), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:420px;height:21px;width:180" +
"px;top:278px;", 11117), true)
);
WriteLiteral(">Intrinsiq Notes Archive</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:146px;width:400px;top:303px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Intrinsiq Notes Archive\'");
WriteLiteral(" data-ScreenInfo=\'ChangeRequests_CRIqNotesArch\'");
WriteLiteral(" ");
                                                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.CRIqNotesArch.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIqNotesArch/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/ChangeReq/CallbackCRIqNotesArch/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(!Model.CRIqNotesArch.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCRIqNotesArch\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(Model.PopulateCRIqNotesArch);
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
WriteLiteral(" data-target=\"*[name=PopulateCRIqNotesArch]\"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Edit_1.cshtml")]
    public partial class Views_ChangeReq_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Edit_1_cshtml()
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
WriteLiteral(" href=\"/ChangeReq/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Change Requests</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/ChangeReq/Delete/?RecId=", 426), true)
          , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Change" +
"Req/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ChangeReq", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1379), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1387), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1387), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1447), Tuple.Create("\'", 1471)
, Tuple.Create(Tuple.Create("", 1455), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1455), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ChangeReq\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1574), Tuple.Create("\"", 1598)
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create<System.Object, System.Int32>(Model.CRIdValue
, 1582), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1644), Tuple.Create("\"", 1667)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1652), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1709), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1717), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1717), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ChangeReq/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2032), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2039), Tuple.Create("/ChangeReq/ViewHistory/?RecId=", 2039), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteLiteral(" id=\"ChangeRequests\"");
WriteLiteral(" style=\'position:relative;height:479px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ChangeReq_ChangeRequests.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2932), Tuple.Create("\"", 2947)
, Tuple.Create(Tuple.Create("", 2939), Tuple.Create("#", 2939), true)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2940), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3163), Tuple.Create("\"", 3175)
, Tuple.Create(Tuple.Create("", 3168), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3168), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Add_1.cshtml")]
    public partial class Views_ChangeReq_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Change Requests";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Change Requests\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ChangeReq/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ChangeRequests\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ChangeReq_ChangeRequests.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_List_1.cshtml")]
    public partial class Views_ChangeReq_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ChangeReq>>
    {
        public Views_ChangeReq_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Change Requests List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Change Requests List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Change Requests</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 597)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/ChangeReq/ListFromQuery/?Clause=", 532), true)
                                                                     , Tuple.Create(Tuple.Create("", 565), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 565), false)
, Tuple.Create(Tuple.Create("", 580), Tuple.Create("&Ord=", 580), true)
                                                                                         , Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 585), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 874), Tuple.Create("\"", 917)
, Tuple.Create(Tuple.Create("", 881), Tuple.Create("/ChangeReq/Load/?RecId=", 881), true)
                  , Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 904), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:100%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1167), Tuple.Create("\"", 1254)
, Tuple.Create(Tuple.Create("", 1178), Tuple.Create("javascript:IQAutoSave(\'/ChangeReq/SaveCRName/?RecId=", 1178), true)
                                                                      , Tuple.Create(Tuple.Create("", 1230), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1230), false)
, Tuple.Create(Tuple.Create("", 1243), Tuple.Create("\',$(this));", 1243), true)
);
WriteLiteral(" data-bound-name=\'CRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1311), Tuple.Create("\'", 1350)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1319), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CRName.HTMLValue)
, 1319), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Edit_2.cshtml")]
    public partial class Views_ChangeReq_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Edit_2_cshtml()
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
WriteLiteral(" href=\"/ChangeReq/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Change Requests</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/ChangeReq/Delete/?RecId=", 426), true)
          , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Change" +
"Req/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ChangeReq", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1379), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1387), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1387), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1447), Tuple.Create("\'", 1471)
, Tuple.Create(Tuple.Create("", 1455), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1455), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ChangeReq\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1574), Tuple.Create("\"", 1598)
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create<System.Object, System.Int32>(Model.CRIdValue
, 1582), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1644), Tuple.Create("\"", 1667)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1652), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1709), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1717), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1717), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ChangeReq/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2032), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2039), Tuple.Create("/ChangeReq/ViewHistory/?RecId=", 2039), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteLiteral(" id=\"ChangeRequests\"");
WriteLiteral(" style=\'position:relative;height:479px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ChangeReq_ChangeRequests.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2932), Tuple.Create("\"", 2947)
, Tuple.Create(Tuple.Create("", 2939), Tuple.Create("#", 2939), true)
, Tuple.Create(Tuple.Create("", 2940), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2940), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3163), Tuple.Create("\"", 3175)
, Tuple.Create(Tuple.Create("", 3168), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3168), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Add_2.cshtml")]
    public partial class Views_ChangeReq_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Change Requests";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Change Requests\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ChangeReq/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"ChangeRequests\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/ChangeReq_ChangeRequests.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_List_2.cshtml")]
    public partial class Views_ChangeReq_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ChangeReq>>
    {
        public Views_ChangeReq_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Change Requests List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Change Requests List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Change Requests</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 597)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/ChangeReq/ListFromQuery/?Clause=", 532), true)
                                                                     , Tuple.Create(Tuple.Create("", 565), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 565), false)
, Tuple.Create(Tuple.Create("", 580), Tuple.Create("&Ord=", 580), true)
                                                                                         , Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 585), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 874), Tuple.Create("\"", 917)
, Tuple.Create(Tuple.Create("", 881), Tuple.Create("/ChangeReq/Load/?RecId=", 881), true)
                  , Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 904), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:100%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1167), Tuple.Create("\"", 1254)
, Tuple.Create(Tuple.Create("", 1178), Tuple.Create("javascript:IQAutoSave(\'/ChangeReq/SaveCRName/?RecId=", 1178), true)
                                                                      , Tuple.Create(Tuple.Create("", 1230), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1230), false)
, Tuple.Create(Tuple.Create("", 1243), Tuple.Create("\',$(this));", 1243), true)
);
WriteLiteral(" data-bound-name=\'CRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1311), Tuple.Create("\'", 1350)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1319), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CRName.HTMLValue)
, 1319), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Edit_3.cshtml")]
    public partial class Views_ChangeReq_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Edit_3_cshtml()
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
WriteLiteral(" href=\"/ChangeReq/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Change Requests</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 416), Tuple.Create("\'", 479)
, Tuple.Create(Tuple.Create("", 426), Tuple.Create("IQJSCall(\"/ChangeReq/Delete/?RecId=", 426), true)
          , Tuple.Create(Tuple.Create("", 461), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 461), false)
, Tuple.Create(Tuple.Create("", 476), Tuple.Create("\");", 476), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Change" +
"Req/ViewHistory/?RecId=");
                                                                                                      Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("ChangeReq", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1379), Tuple.Create("\'", 1401)
, Tuple.Create(Tuple.Create("", 1387), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1387), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1447), Tuple.Create("\'", 1471)
, Tuple.Create(Tuple.Create("", 1455), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1455), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"ChangeReq\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1574), Tuple.Create("\"", 1598)
, Tuple.Create(Tuple.Create("", 1582), Tuple.Create<System.Object, System.Int32>(Model.CRIdValue
, 1582), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1644), Tuple.Create("\"", 1667)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1652), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1709), Tuple.Create("\"", 1732)
, Tuple.Create(Tuple.Create("", 1717), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1717), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/ChangeReq/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2032), Tuple.Create("\"", 2135)
, Tuple.Create(Tuple.Create("", 2039), Tuple.Create("/ChangeReq/ViewHistory/?RecId=", 2039), true)
, Tuple.Create(Tuple.Create("", 2069), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2069), false)
, Tuple.Create(Tuple.Create("", 2084), Tuple.Create("&dt=", 2084), true)
, Tuple.Create(Tuple.Create("", 2088), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2088), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2727), Tuple.Create("\"", 2742)
, Tuple.Create(Tuple.Create("", 2734), Tuple.Create("#", 2734), true)
, Tuple.Create(Tuple.Create("", 2735), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2735), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2958), Tuple.Create("\"", 2970)
, Tuple.Create(Tuple.Create("", 2963), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2963), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_Add_3.cshtml")]
    public partial class Views_ChangeReq_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.ChangeReq>
    {
        public Views_ChangeReq_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Change Requests";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Change Requests\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/ChangeReq/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<ChangeReq>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/ChangeReq_List_3.cshtml")]
    public partial class Views_ChangeReq_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.ChangeReq>>
    {
        public Views_ChangeReq_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Change Requests List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Change Requests List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Change Requests</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/ChangeReq/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 525), Tuple.Create("\"", 597)
, Tuple.Create(Tuple.Create("", 532), Tuple.Create("/ChangeReq/ListFromQuery/?Clause=", 532), true)
                                                                     , Tuple.Create(Tuple.Create("", 565), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 565), false)
, Tuple.Create(Tuple.Create("", 580), Tuple.Create("&Ord=", 580), true)
                                                                                         , Tuple.Create(Tuple.Create("", 585), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 585), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                          Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Title</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 874), Tuple.Create("\"", 917)
, Tuple.Create(Tuple.Create("", 881), Tuple.Create("/ChangeReq/Load/?RecId=", 881), true)
                  , Tuple.Create(Tuple.Create("", 904), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 904), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CRName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:100%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1167), Tuple.Create("\"", 1254)
, Tuple.Create(Tuple.Create("", 1178), Tuple.Create("javascript:IQAutoSave(\'/ChangeReq/SaveCRName/?RecId=", 1178), true)
                                                                      , Tuple.Create(Tuple.Create("", 1230), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1230), false)
, Tuple.Create(Tuple.Create("", 1243), Tuple.Create("\',$(this));", 1243), true)
);
WriteLiteral(" data-bound-name=\'CRName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1311), Tuple.Create("\'", 1350)
                                                                                                                                                               , Tuple.Create(Tuple.Create("", 1319), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CRName.HTMLValue)
, 1319), false)
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
