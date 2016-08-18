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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Trailers.cshtml")]
    public partial class Views_Trailer_Trailers_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Trailers_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 63), Tuple.Create("\'", 129)
, Tuple.Create(Tuple.Create("", 71), Tuple.Create("IQLabel102111", 71), true)
, Tuple.Create(Tuple.Create(" ", 84), Tuple.Create<System.Object, System.Int32>(!Model.TrlId.LabelVisible ? " hide " : ""
, 85), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 130), Tuple.Create("\'", 328)
    , Tuple.Create(Tuple.Create("", 139), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlId.BackHEXColor) ? "" : "color:" + Model.TrlId.BackHEXColor + ";"
, 139), false)
, Tuple.Create(Tuple.Create("", 237), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 237), true)
);
WriteLiteral(">Trailer Id</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 413), Tuple.Create("\'", 475)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("form-control", 421), true)
, Tuple.Create(Tuple.Create("   ", 433), Tuple.Create<System.Object, System.Int32>(!Model.TrlId.Visible ? " hide " : ""
, 436), false)
);
WriteLiteral(" ");
                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrlId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                  Write(Model.TrlId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 838), Tuple.Create("\'", 909)
, Tuple.Create(Tuple.Create("", 846), Tuple.Create("IQLabel102112", 846), true)
                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 859), Tuple.Create<System.Object, System.Int32>(!Model.TrlFleetNo.LabelVisible ? " hide " : ""
, 860), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 910), Tuple.Create("\'", 1119)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 919), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlFleetNo.BackHEXColor) ? "" : "color:" + Model.TrlFleetNo.BackHEXColor + ";"
, 919), false)
, Tuple.Create(Tuple.Create("", 1027), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1027), true)
);
WriteLiteral(">Fleet Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlFleetNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrlFleetNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.TrlFleetNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlFleetNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlFleetNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrlFleetNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.TrlFleetNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1723), Tuple.Create("\'", 1794)
, Tuple.Create(Tuple.Create("", 1731), Tuple.Create("IQLabel102113", 1731), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create(" ", 1744), Tuple.Create<System.Object, System.Int32>(!Model.TrlLastMOT.LabelVisible ? " hide " : ""
, 1745), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1795), Tuple.Create("\'", 2004)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1804), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlLastMOT.BackHEXColor) ? "" : "color:" + Model.TrlLastMOT.BackHEXColor + ";"
, 1804), false)
, Tuple.Create(Tuple.Create("", 1912), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1912), true)
);
WriteLiteral(">Last MOT</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlLastMOT\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrlLastMOT.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                               Write(!Model.TrlLastMOT.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlLastMOT/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlLastMOT/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrlLastMOT\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(Model.TrlLastMOT.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrlLastMOT]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2953), Tuple.Create("\'", 3027)
, Tuple.Create(Tuple.Create("", 2961), Tuple.Create("IQLabel102114", 2961), true)
, Tuple.Create(Tuple.Create(" ", 2974), Tuple.Create<System.Object, System.Int32>(!Model.TrlNextMOTDue.LabelVisible ? " hide " : ""
, 2975), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3028), Tuple.Create("\'", 3243)
                                   , Tuple.Create(Tuple.Create("", 3037), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlNextMOTDue.BackHEXColor) ? "" : "color:" + Model.TrlNextMOTDue.BackHEXColor + ";"
, 3037), false)
, Tuple.Create(Tuple.Create("", 3151), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 3151), true)
);
WriteLiteral(">Next MOT Due</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlNextMOTDue\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrlNextMOTDue.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                  Write(!Model.TrlNextMOTDue.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNextMOTDue/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlNextMOTDue/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrlNextMOTDue\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.TrlNextMOTDue.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrlNextMOTDue]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 4220), Tuple.Create("\'", 4292)
, Tuple.Create(Tuple.Create("", 4228), Tuple.Create("IQLabel102115", 4228), true)
, Tuple.Create(Tuple.Create(" ", 4241), Tuple.Create<System.Object, System.Int32>(!Model.TrlLastServ.LabelVisible ? " hide " : ""
, 4242), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4293), Tuple.Create("\'", 4505)
                                 , Tuple.Create(Tuple.Create("", 4302), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlLastServ.BackHEXColor) ? "" : "color:" + Model.TrlLastServ.BackHEXColor + ";"
, 4302), false)
, Tuple.Create(Tuple.Create("", 4412), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 4412), true)
);
WriteLiteral(">Last Service</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:103px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlLastServ\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrlLastServ.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                Write(!Model.TrlLastServ.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlLastServ/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlLastServ/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrlLastServ\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.TrlLastServ.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrlLastServ]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 5467), Tuple.Create("\'", 5542)
, Tuple.Create(Tuple.Create("", 5475), Tuple.Create("IQLabel102116", 5475), true)
, Tuple.Create(Tuple.Create(" ", 5488), Tuple.Create<System.Object, System.Int32>(!Model.TrlNextServDue.LabelVisible ? " hide " : ""
, 5489), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5543), Tuple.Create("\'", 5761)
                                    , Tuple.Create(Tuple.Create("", 5552), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlNextServDue.BackHEXColor) ? "" : "color:" + Model.TrlNextServDue.BackHEXColor + ";"
, 5552), false)
, Tuple.Create(Tuple.Create("", 5668), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 5668), true)
);
WriteLiteral(">Next Service Due</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'80\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:80px;top:128px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlNextServDue\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.TrlNextServDue.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                   Write(!Model.TrlNextServDue.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNextServDue/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlNextServDue/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateTrlNextServDue\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.TrlNextServDue.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateTrlNextServDue]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 6751), Tuple.Create("\'", 6822)
, Tuple.Create(Tuple.Create("", 6759), Tuple.Create("IQLabel102117", 6759), true)
, Tuple.Create(Tuple.Create(" ", 6772), Tuple.Create<System.Object, System.Int32>(!Model.TrlDaysRem.LabelVisible ? " hide " : ""
, 6773), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6823), Tuple.Create("\'", 7033)
                                , Tuple.Create(Tuple.Create("", 6832), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlDaysRem.BackHEXColor) ? "" : "color:" + Model.TrlDaysRem.BackHEXColor + ";"
, 6832), false)
, Tuple.Create(Tuple.Create("", 6940), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 6940), true)
);
WriteLiteral(">Days Remaining</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlDaysRem\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 7127), Tuple.Create("\'", 7194)
, Tuple.Create(Tuple.Create("", 7135), Tuple.Create("form-control", 7135), true)
, Tuple.Create(Tuple.Create("   ", 7147), Tuple.Create<System.Object, System.Int32>(!Model.TrlDaysRem.Visible ? " hide " : ""
, 7150), false)
);
WriteLiteral(" ");
                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlDaysRem/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlDaysRem/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrlDaysRem\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                      Write(Model.TrlDaysRem.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:153px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 7579), Tuple.Create("\'", 7649)
, Tuple.Create(Tuple.Create("", 7587), Tuple.Create("IQLabel102131", 7587), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create(" ", 7600), Tuple.Create<System.Object, System.Int32>(!Model.TrlStatus.LabelVisible ? " hide " : ""
, 7601), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7650), Tuple.Create("\'", 7858)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 7659), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlStatus.BackHEXColor) ? "" : "color:" + Model.TrlStatus.BackHEXColor + ";"
, 7659), false)
, Tuple.Create(Tuple.Create("", 7765), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:12" +
"0px;top:3px;", 7765), true)
);
WriteLiteral(">Status</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlStatus\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 7943), Tuple.Create("\'", 8009)
, Tuple.Create(Tuple.Create("", 7951), Tuple.Create("form-control", 7951), true)
, Tuple.Create(Tuple.Create("   ", 7963), Tuple.Create<System.Object, System.Int32>(!Model.TrlStatus.Visible ? " hide " : ""
, 7966), false)
);
WriteLiteral(" ");
                                                                                        Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlStatus/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateTrlStatus\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                  Write(Model.TrlStatus.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:360px;height:21px;width:100px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 8389), Tuple.Create("\'", 8458)
, Tuple.Create(Tuple.Create("", 8397), Tuple.Create("IQLabel102132", 8397), true)
                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 8410), Tuple.Create<System.Object, System.Int32>(!Model.TrlNotes.LabelVisible ? " hide " : ""
, 8411), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8459), Tuple.Create("\'", 8666)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 8468), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.TrlNotes.BackHEXColor) ? "" : "color:" + Model.TrlNotes.BackHEXColor + ";"
, 8468), false)
, Tuple.Create(Tuple.Create("", 8572), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:235px;height:21px;width:12" +
"0px;top:28px;", 8572), true)
);
WriteLiteral(">Comments</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:360px;height:71px;width:400px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Comments\'");
WriteLiteral(" data-ScreenInfo=\'Trailers_TrlNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                        Write(Model.RecordLocked || !Model.TrlNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Trailer/CallbackTrlNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(!Model.TrlNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateTrlNotes\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(Model.PopulateTrlNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateTrlNotes]\"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Edit_1.cshtml")]
    public partial class Views_Trailer_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Trailer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trailers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 405), Tuple.Create("\'", 466)
, Tuple.Create(Tuple.Create("", 415), Tuple.Create("IQJSCall(\"/Trailer/Delete/?RecId=", 415), true)
        , Tuple.Create(Tuple.Create("", 448), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 448), false)
, Tuple.Create(Tuple.Create("", 463), Tuple.Create("\");", 463), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Traile" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Trailer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1360), Tuple.Create("\'", 1382)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1368), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1428), Tuple.Create("\'", 1452)
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1436), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Trailer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1553), Tuple.Create("\"", 1578)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Model.TrlIdValue
, 1561), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1624), Tuple.Create("\"", 1647)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1632), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1689), Tuple.Create("\"", 1712)
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1697), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Trailer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2010), Tuple.Create("\"", 2111)
, Tuple.Create(Tuple.Create("", 2017), Tuple.Create("/Trailer/ViewHistory/?RecId=", 2017), true)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2045), false)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create("&dt=", 2060), true)
, Tuple.Create(Tuple.Create("", 2064), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2064), false)
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
WriteLiteral(" id=\"Trailers\"");
WriteLiteral(" style=\'position:relative;height:349px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Trailer_Trailers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2894), Tuple.Create("\"", 2909)
, Tuple.Create(Tuple.Create("", 2901), Tuple.Create("#", 2901), true)
, Tuple.Create(Tuple.Create("", 2902), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2902), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3125), Tuple.Create("\"", 3137)
, Tuple.Create(Tuple.Create("", 3130), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3130), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Add_1.cshtml")]
    public partial class Views_Trailer_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trailers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trailers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Trailer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Trailers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Trailer_Trailers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_List_1.cshtml")]
    public partial class Views_Trailer_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Trailer>>
    {
        public Views_Trailer_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trailers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trailers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trailers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 498), Tuple.Create("\"", 568)
, Tuple.Create(Tuple.Create("", 505), Tuple.Create("/Trailer/ListFromQuery/?Clause=", 505), true)
                                                                   , Tuple.Create(Tuple.Create("", 536), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 536), false)
, Tuple.Create(Tuple.Create("", 551), Tuple.Create("&Ord=", 551), true)
                                                                                       , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 556), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Fleet Number</th><th>Last Service</th><th>Next Service Due</th><" +
"th>Days Remaining</th><th>Last MOT</th><th>Next MOT Due</th><th>Status</th>\t\t</t" +
"r>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 974), Tuple.Create("\"", 1015)
, Tuple.Create(Tuple.Create("", 981), Tuple.Create("/Trailer/Load/?RecId=", 981), true)
               , Tuple.Create(Tuple.Create("", 1002), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1002), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlFleetNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1268), Tuple.Create("\"", 1357)
, Tuple.Create(Tuple.Create("", 1279), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlFleetNo/?RecId=", 1279), true)
                                                                       , Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1333), false)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create("\',$(this));", 1346), true)
);
WriteLiteral(" data-bound-name=\'TrlFleetNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1418), Tuple.Create("\'", 1461)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlFleetNo.HTMLValue)
, 1426), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastServ.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1679), Tuple.Create("\"", 1769)
, Tuple.Create(Tuple.Create("", 1690), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastServ/?RecId=", 1690), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 1745), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1745), false)
, Tuple.Create(Tuple.Create("", 1758), Tuple.Create("\',$(this));", 1758), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastServ\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1840), Tuple.Create("\'", 1884)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastServ.HTMLValue)
, 1848), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextServDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2105), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2116), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextServDue/?RecId=", 2116), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextServDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2272), Tuple.Create("\'", 2319)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2280), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextServDue.HTMLValue)
, 2280), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlDaysRem.DisplayValue);
WriteLiteral("</td>");
                                                                                      if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastMOT.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2597), Tuple.Create("\"", 2686)
, Tuple.Create(Tuple.Create("", 2608), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastMOT/?RecId=", 2608), true)
                                                                                                   , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2662), false)
, Tuple.Create(Tuple.Create("", 2675), Tuple.Create("\',$(this));", 2675), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastMOT\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2756), Tuple.Create("\'", 2799)
                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 2764), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastMOT.HTMLValue)
, 2764), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextMOTDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3019), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3030), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextMOTDue/?RecId=", 3030), true)
                                                                                                      , Tuple.Create(Tuple.Create("", 3087), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3087), false)
, Tuple.Create(Tuple.Create("", 3100), Tuple.Create("\',$(this));", 3100), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextMOTDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3184), Tuple.Create("\'", 3230)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3192), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextMOTDue.HTMLValue)
, 3192), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlStatus.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Edit_2.cshtml")]
    public partial class Views_Trailer_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Trailer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trailers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 405), Tuple.Create("\'", 466)
, Tuple.Create(Tuple.Create("", 415), Tuple.Create("IQJSCall(\"/Trailer/Delete/?RecId=", 415), true)
        , Tuple.Create(Tuple.Create("", 448), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 448), false)
, Tuple.Create(Tuple.Create("", 463), Tuple.Create("\");", 463), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Traile" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Trailer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1360), Tuple.Create("\'", 1382)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1368), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1428), Tuple.Create("\'", 1452)
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1436), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Trailer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1553), Tuple.Create("\"", 1578)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Model.TrlIdValue
, 1561), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1624), Tuple.Create("\"", 1647)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1632), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1689), Tuple.Create("\"", 1712)
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1697), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Trailer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2010), Tuple.Create("\"", 2111)
, Tuple.Create(Tuple.Create("", 2017), Tuple.Create("/Trailer/ViewHistory/?RecId=", 2017), true)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2045), false)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create("&dt=", 2060), true)
, Tuple.Create(Tuple.Create("", 2064), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2064), false)
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
WriteLiteral(" id=\"Trailers\"");
WriteLiteral(" style=\'position:relative;height:349px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Trailer_Trailers.cshtml", Model);
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
WriteAttribute("href", Tuple.Create(" href=\"", 2894), Tuple.Create("\"", 2909)
, Tuple.Create(Tuple.Create("", 2901), Tuple.Create("#", 2901), true)
, Tuple.Create(Tuple.Create("", 2902), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2902), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 3125), Tuple.Create("\"", 3137)
, Tuple.Create(Tuple.Create("", 3130), Tuple.Create<System.Object, System.Int32>(itm.Id
, 3130), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Add_2.cshtml")]
    public partial class Views_Trailer_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trailers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trailers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Trailer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
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
WriteLiteral(" id=\"Trailers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Trailer_Trailers.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_List_2.cshtml")]
    public partial class Views_Trailer_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Trailer>>
    {
        public Views_Trailer_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trailers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trailers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trailers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 498), Tuple.Create("\"", 568)
, Tuple.Create(Tuple.Create("", 505), Tuple.Create("/Trailer/ListFromQuery/?Clause=", 505), true)
                                                                   , Tuple.Create(Tuple.Create("", 536), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 536), false)
, Tuple.Create(Tuple.Create("", 551), Tuple.Create("&Ord=", 551), true)
                                                                                       , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 556), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Fleet Number</th><th>Last Service</th><th>Next Service Due</th><" +
"th>Days Remaining</th><th>Last MOT</th><th>Next MOT Due</th><th>Status</th>\t\t</t" +
"r>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 974), Tuple.Create("\"", 1015)
, Tuple.Create(Tuple.Create("", 981), Tuple.Create("/Trailer/Load/?RecId=", 981), true)
               , Tuple.Create(Tuple.Create("", 1002), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1002), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlFleetNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1268), Tuple.Create("\"", 1357)
, Tuple.Create(Tuple.Create("", 1279), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlFleetNo/?RecId=", 1279), true)
                                                                       , Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1333), false)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create("\',$(this));", 1346), true)
);
WriteLiteral(" data-bound-name=\'TrlFleetNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1418), Tuple.Create("\'", 1461)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlFleetNo.HTMLValue)
, 1426), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastServ.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1679), Tuple.Create("\"", 1769)
, Tuple.Create(Tuple.Create("", 1690), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastServ/?RecId=", 1690), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 1745), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1745), false)
, Tuple.Create(Tuple.Create("", 1758), Tuple.Create("\',$(this));", 1758), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastServ\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1840), Tuple.Create("\'", 1884)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastServ.HTMLValue)
, 1848), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextServDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2105), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2116), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextServDue/?RecId=", 2116), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextServDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2272), Tuple.Create("\'", 2319)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2280), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextServDue.HTMLValue)
, 2280), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlDaysRem.DisplayValue);
WriteLiteral("</td>");
                                                                                      if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastMOT.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2597), Tuple.Create("\"", 2686)
, Tuple.Create(Tuple.Create("", 2608), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastMOT/?RecId=", 2608), true)
                                                                                                   , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2662), false)
, Tuple.Create(Tuple.Create("", 2675), Tuple.Create("\',$(this));", 2675), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastMOT\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2756), Tuple.Create("\'", 2799)
                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 2764), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastMOT.HTMLValue)
, 2764), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextMOTDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3019), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3030), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextMOTDue/?RecId=", 3030), true)
                                                                                                      , Tuple.Create(Tuple.Create("", 3087), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3087), false)
, Tuple.Create(Tuple.Create("", 3100), Tuple.Create("\',$(this));", 3100), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextMOTDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3184), Tuple.Create("\'", 3230)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3192), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextMOTDue.HTMLValue)
, 3192), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlStatus.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Edit_3.cshtml")]
    public partial class Views_Trailer_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Trailer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Trailers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 405), Tuple.Create("\'", 466)
, Tuple.Create(Tuple.Create("", 415), Tuple.Create("IQJSCall(\"/Trailer/Delete/?RecId=", 415), true)
        , Tuple.Create(Tuple.Create("", 448), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 448), false)
, Tuple.Create(Tuple.Create("", 463), Tuple.Create("\");", 463), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Traile" +
"r/ViewHistory/?RecId=");
                                                                                                    Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Trailer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1360), Tuple.Create("\'", 1382)
, Tuple.Create(Tuple.Create("", 1368), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1368), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1428), Tuple.Create("\'", 1452)
, Tuple.Create(Tuple.Create("", 1436), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1436), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Trailer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1553), Tuple.Create("\"", 1578)
, Tuple.Create(Tuple.Create("", 1561), Tuple.Create<System.Object, System.Int32>(Model.TrlIdValue
, 1561), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1624), Tuple.Create("\"", 1647)
, Tuple.Create(Tuple.Create("", 1632), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1632), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1689), Tuple.Create("\"", 1712)
, Tuple.Create(Tuple.Create("", 1697), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1697), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Trailer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2010), Tuple.Create("\"", 2111)
, Tuple.Create(Tuple.Create("", 2017), Tuple.Create("/Trailer/ViewHistory/?RecId=", 2017), true)
, Tuple.Create(Tuple.Create("", 2045), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2045), false)
, Tuple.Create(Tuple.Create("", 2060), Tuple.Create("&dt=", 2060), true)
, Tuple.Create(Tuple.Create("", 2064), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2064), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2703), Tuple.Create("\"", 2718)
, Tuple.Create(Tuple.Create("", 2710), Tuple.Create("#", 2710), true)
, Tuple.Create(Tuple.Create("", 2711), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2711), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2934), Tuple.Create("\"", 2946)
, Tuple.Create(Tuple.Create("", 2939), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2939), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_Add_3.cshtml")]
    public partial class Views_Trailer_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Trailer>
    {
        public Views_Trailer_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Trailers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Trailers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Trailer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Trailer>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Trailer_List_3.cshtml")]
    public partial class Views_Trailer_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Trailer>>
    {
        public Views_Trailer_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Trailers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Trailers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Trailers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Trailer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 498), Tuple.Create("\"", 568)
, Tuple.Create(Tuple.Create("", 505), Tuple.Create("/Trailer/ListFromQuery/?Clause=", 505), true)
                                                                   , Tuple.Create(Tuple.Create("", 536), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 536), false)
, Tuple.Create(Tuple.Create("", 551), Tuple.Create("&Ord=", 551), true)
                                                                                       , Tuple.Create(Tuple.Create("", 556), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 556), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                        Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Fleet Number</th><th>Last Service</th><th>Next Service Due</th><" +
"th>Days Remaining</th><th>Last MOT</th><th>Next MOT Due</th><th>Status</th>\t\t</t" +
"r>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 974), Tuple.Create("\"", 1015)
, Tuple.Create(Tuple.Create("", 981), Tuple.Create("/Trailer/Load/?RecId=", 981), true)
               , Tuple.Create(Tuple.Create("", 1002), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1002), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlFleetNo.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:20%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1268), Tuple.Create("\"", 1357)
, Tuple.Create(Tuple.Create("", 1279), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlFleetNo/?RecId=", 1279), true)
                                                                       , Tuple.Create(Tuple.Create("", 1333), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1333), false)
, Tuple.Create(Tuple.Create("", 1346), Tuple.Create("\',$(this));", 1346), true)
);
WriteLiteral(" data-bound-name=\'TrlFleetNo\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1418), Tuple.Create("\'", 1461)
                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1426), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlFleetNo.HTMLValue)
, 1426), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastServ.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1679), Tuple.Create("\"", 1769)
, Tuple.Create(Tuple.Create("", 1690), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastServ/?RecId=", 1690), true)
                                                                                                    , Tuple.Create(Tuple.Create("", 1745), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1745), false)
, Tuple.Create(Tuple.Create("", 1758), Tuple.Create("\',$(this));", 1758), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastServ\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1840), Tuple.Create("\'", 1884)
                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 1848), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastServ.HTMLValue)
, 1848), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextServDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2105), Tuple.Create("\"", 2198)
, Tuple.Create(Tuple.Create("", 2116), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextServDue/?RecId=", 2116), true)
                                                                                                       , Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2174), false)
, Tuple.Create(Tuple.Create("", 2187), Tuple.Create("\',$(this));", 2187), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextServDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2272), Tuple.Create("\'", 2319)
                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 2280), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextServDue.HTMLValue)
, 2280), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlDaysRem.DisplayValue);
WriteLiteral("</td>");
                                                                                      if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlLastMOT.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 2597), Tuple.Create("\"", 2686)
, Tuple.Create(Tuple.Create("", 2608), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlLastMOT/?RecId=", 2608), true)
                                                                                                   , Tuple.Create(Tuple.Create("", 2662), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2662), false)
, Tuple.Create(Tuple.Create("", 2675), Tuple.Create("\',$(this));", 2675), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlLastMOT\'");
WriteAttribute("value", Tuple.Create(" value=\'", 2756), Tuple.Create("\'", 2799)
                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 2764), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlLastMOT.HTMLValue)
, 2764), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.TrlNextMOTDue.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:13%\'");
WriteLiteral("><input");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 3019), Tuple.Create("\"", 3111)
, Tuple.Create(Tuple.Create("", 3030), Tuple.Create("javascript:IQAutoSave(\'/Trailer/SaveTrlNextMOTDue/?RecId=", 3030), true)
                                                                                                      , Tuple.Create(Tuple.Create("", 3087), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 3087), false)
, Tuple.Create(Tuple.Create("", 3100), Tuple.Create("\',$(this));", 3100), true)
);
WriteLiteral("class=\'form-control dateBox\'");
WriteLiteral(" type=\'text\'");
WriteLiteral(" data-bound-name=\'TrlNextMOTDue\'");
WriteAttribute("value", Tuple.Create(" value=\'", 3184), Tuple.Create("\'", 3230)
                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 3192), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.TrlNextMOTDue.HTMLValue)
, 3192), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.TrlStatus.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
