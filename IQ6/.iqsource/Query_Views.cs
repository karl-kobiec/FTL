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

namespace FTL
{

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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Query.cshtml")]
        public partial class Views_Query_Query_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Query_cshtml()
            {
            }
            public override void Execute()
            {
                WriteLiteral("\r\n");
                WriteLiteral("<label");
                WriteAttribute("class", Tuple.Create(" class=\'", 61), Tuple.Create("\'", 127)
                , Tuple.Create(Tuple.Create("", 69), Tuple.Create("IQLabel104811", 69), true)
                , Tuple.Create(Tuple.Create(" ", 82), Tuple.Create<System.Object, System.Int32>(!Model.QryId.LabelVisible ? " hide " : ""
                , 83), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 128), Tuple.Create("\'", 326)
                    , Tuple.Create(Tuple.Create("", 137), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryId.BackHEXColor) ? "" : "color:" + Model.QryId.BackHEXColor + ";"
                , 137), false)
                , Tuple.Create(Tuple.Create("", 235), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
                "x;top:3px;", 235), true)
                );
                WriteLiteral(">Id</label>\r\n\t\t<input");
                WriteLiteral(" data-ScreenInfo=\'Query_QryId\'");
                WriteLiteral(" \r\n\t\tdisabled=disabled");
                WriteAttribute("class", Tuple.Create(" class=\'", 400), Tuple.Create("\'", 462)
                , Tuple.Create(Tuple.Create("", 408), Tuple.Create("form-control", 408), true)
                , Tuple.Create(Tuple.Create("   ", 420), Tuple.Create<System.Object, System.Int32>(!Model.QryId.Visible ? " hide " : ""
                , 423), false)
                );
                WriteLiteral(" ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryId/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryId/',$(this));\""));
                WriteLiteral(" type=\'text\' name=\'PopulateQryId\' value=\'");
                Write(Model.QryId.ValueFormatted);
                WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
                WriteAttribute("class", Tuple.Create(" class=\'", 821), Tuple.Create("\'", 889)
                , Tuple.Create(Tuple.Create("", 829), Tuple.Create("IQLabel104812", 829), true)
                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 842), Tuple.Create<System.Object, System.Int32>(!Model.QryName.LabelVisible ? " hide " : ""
                , 843), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 890), Tuple.Create("\'", 1093)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create("", 899), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryName.BackHEXColor) ? "" : "color:" + Model.QryName.BackHEXColor + ";"
                , 899), false)
                , Tuple.Create(Tuple.Create("", 1001), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
                "x;top:28px;", 1001), true)
                );
                WriteLiteral(">Name</label>\r\n\t\t<input");
                WriteLiteral(" data-ScreenInfo=\'Query_QryName\'");
                WriteLiteral(" \r\n\t\t");
                Write(Model.RecordLocked || !Model.QryName.Enabled ? "disabled=disabled" : "");
                WriteLiteral(" class=\'form-control   ");
                Write(!Model.QryName.Visible ? " hide " : "");
                WriteLiteral("\' ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryName/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryName/',$(this));\""));
                WriteLiteral(" type=\'text\' name=\'PopulateQryName\' value=\'");
                Write(Model.QryName.ValueFormatted);
                WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:28px;\'/><labe" +
                "l");
                WriteAttribute("class", Tuple.Create(" class=\'", 1661), Tuple.Create("\'", 1732)
                , Tuple.Create(Tuple.Create("", 1669), Tuple.Create("IQLabel104813", 1669), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create(" ", 1682), Tuple.Create<System.Object, System.Int32>(!Model.QryContent.LabelVisible ? " hide " : ""
                , 1683), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 1733), Tuple.Create("\'", 1943)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 1742), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryContent.BackHEXColor) ? "" : "color:" + Model.QryContent.BackHEXColor + ";"
                , 1742), false)
                , Tuple.Create(Tuple.Create("", 1850), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
                "x;top:103px;", 1850), true)
                );
                WriteLiteral(">Content</label>\r\n\t\t<div");
                WriteLiteral(" class=\'input-group\'");
                WriteLiteral(" data-OriginalWidth=\'1000\'");
                WriteLiteral(" style=\'position: absolute; left:130px;height:446px;width:1000px;top:103px;\'");
                WriteLiteral(">\t\t<textarea");
                WriteLiteral(" data-Label=\'Content\'");
                WriteLiteral(" data-ScreenInfo=\'Query_QryContent\'");
                WriteLiteral(" ");
                Write(Model.RecordLocked || !Model.QryContent.Enabled ? "disabled=disabled" : "");
                WriteLiteral("  ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryContent/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryContent/',$(this));\""));
                WriteLiteral("  class=\'form-control    ");
                Write(!Model.QryContent.Visible ? " hide " : "");
                WriteLiteral(" \' name=\'PopulateQryContent\' style=\'height:446px\'>");
                Write(Model.PopulateQryContent);
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
                WriteLiteral(" data-target=\"*[name=PopulateQryContent]\"");
                WriteLiteral("><img");
                WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
                WriteLiteral(" style=\'max-height:14px;float:left;\'");
                WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
                WriteAttribute("class", Tuple.Create(" class=\'", 3121), Tuple.Create("\'", 3189)
                , Tuple.Create(Tuple.Create("", 3129), Tuple.Create("IQLabel104814", 3129), true)
                , Tuple.Create(Tuple.Create(" ", 3142), Tuple.Create<System.Object, System.Int32>(!Model.QryType.LabelVisible ? " hide " : ""
                , 3143), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 3190), Tuple.Create("\'", 3393)
                                             , Tuple.Create(Tuple.Create("", 3199), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryType.BackHEXColor) ? "" : "color:" + Model.QryType.BackHEXColor + ";"
                , 3199), false)
                , Tuple.Create(Tuple.Create("", 3301), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
                "x;top:53px;", 3301), true)
                );
                WriteLiteral(">Type</label>\r\n\t\t<select");
                WriteLiteral(" data-ScreenInfo=\'Query_QryType\'");
                WriteLiteral(" \r\n\t\t");
                Write(Model.RecordLocked || !Model.QryType.Enabled ? "disabled=disabled" : "");
                WriteLiteral(" class=\'form-control    ");
                Write(!Model.QryType.Visible ? " hide " : "");
                WriteLiteral("\'  ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryType/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryType/',$(this));\""));
                WriteLiteral("   name=\'PopulateQryType\'  style=\'position: absolute; left:130px;height:21px;widt" +
                "h:160px;top:53px;\'>\r\n");
                foreach (var itm in Model.QryType.Data)
                {
                    WriteLiteral("\t\t\t\t<option");
                    WriteAttribute("value", Tuple.Create(" value=\'", 3969), Tuple.Create("\'", 3990)
                    , Tuple.Create(Tuple.Create("", 3977), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
                    , 3977), false)
                    );
                    WriteLiteral(" ");
                    Write(itm.KeyValue == Model.PopulateQryType.ToString() ? "selected=selected" : "");
                    WriteLiteral(">");
                    Write(itm.Description);
                    WriteLiteral("</option>\r\n");
                }
                WriteLiteral("\t\t</select><label");
                WriteAttribute("class", Tuple.Create(" class=\'", 4121), Tuple.Create("\'", 4191)
                , Tuple.Create(Tuple.Create("", 4129), Tuple.Create("IQLabel104831", 4129), true)
                , Tuple.Create(Tuple.Create(" ", 4142), Tuple.Create<System.Object, System.Int32>(!Model.QryScreen.LabelVisible ? " hide " : ""
                , 4143), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 4192), Tuple.Create("\'", 4400)
                                        , Tuple.Create(Tuple.Create("", 4201), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryScreen.BackHEXColor) ? "" : "color:" + Model.QryScreen.BackHEXColor + ";"
                , 4201), false)
                , Tuple.Create(Tuple.Create("", 4307), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
                "0px;top:3px;", 4307), true)
                );
                WriteLiteral(">Screen</label>\r\n\t\t<select");
                WriteLiteral(" data-ScreenInfo=\'Query_QryScreen\'");
                WriteLiteral(" \r\n\t\t");
                Write(Model.RecordLocked || !Model.QryScreen.Enabled ? "disabled=disabled" : "");
                WriteLiteral(" class=\'form-control    ");
                Write(!Model.QryScreen.Visible ? " hide " : "");
                WriteLiteral("\'  ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryScreen/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryScreen/',$(this));\""));
                WriteLiteral("   name=\'PopulateQryScreen\'  style=\'position: absolute; left:500px;height:21px;wi" +
                "dth:175px;top:3px;\'>\r\n");
                foreach (var itm in Model.QryScreen.Data)
                {
                    WriteLiteral("\t\t\t\t<option");
                    WriteAttribute("value", Tuple.Create(" value=\'", 4991), Tuple.Create("\'", 5012)
                    , Tuple.Create(Tuple.Create("", 4999), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
                    , 4999), false)
                    );
                    WriteLiteral(" ");
                    Write(itm.KeyValue == Model.PopulateQryScreen.ToString() ? "selected=selected" : "");
                    WriteLiteral(">");
                    Write(itm.Description);
                    WriteLiteral("</option>\r\n");
                }
                WriteLiteral("\t\t</select><label");
                WriteAttribute("class", Tuple.Create(" class=\'", 5145), Tuple.Create("\'", 5218)
                , Tuple.Create(Tuple.Create("", 5153), Tuple.Create("IQLabel104832", 5153), true)
                , Tuple.Create(Tuple.Create(" ", 5166), Tuple.Create<System.Object, System.Int32>(!Model.QryPrimaryDS.LabelVisible ? " hide " : ""
                , 5167), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 5219), Tuple.Create("\'", 5434)
                                           , Tuple.Create(Tuple.Create("", 5228), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryPrimaryDS.BackHEXColor) ? "" : "color:" + Model.QryPrimaryDS.BackHEXColor + ";"
                , 5228), false)
                , Tuple.Create(Tuple.Create("", 5340), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:355px;height:21px;width:14" +
                "0px;top:28px;", 5340), true)
                );
                WriteLiteral(">Primary Data Source</label>\r\n\t\t<select");
                WriteLiteral(" data-ScreenInfo=\'Query_QryPrimaryDS\'");
                WriteLiteral(" \r\n\t\t");
                Write(Model.RecordLocked || !Model.QryPrimaryDS.Enabled ? "disabled=disabled" : "");
                WriteLiteral(" class=\'form-control    ");
                Write(!Model.QryPrimaryDS.Visible ? " hide " : "");
                WriteLiteral("\'  ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryPrimaryDS/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryPrimaryDS/',$(this));\""));
                WriteLiteral("   name=\'PopulateQryPrimaryDS\'  style=\'position: absolute; left:500px;height:21px" +
                ";width:160px;top:28px;\'>\r\n");
                foreach (var itm in Model.QryPrimaryDS.Data)
                {
                    WriteLiteral("\t\t\t\t<option");
                    WriteAttribute("value", Tuple.Create(" value=\'", 6060), Tuple.Create("\'", 6081)
                    , Tuple.Create(Tuple.Create("", 6068), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
                    , 6068), false)
                    );
                    WriteLiteral(" ");
                    Write(itm.KeyValue == Model.PopulateQryPrimaryDS.ToString() ? "selected=selected" : "");
                    WriteLiteral(">");
                    Write(itm.Description);
                    WriteLiteral("</option>\r\n");
                }
                WriteLiteral("\t\t</select><label");
                WriteAttribute("class", Tuple.Create(" class=\'", 6217), Tuple.Create("\'", 6289)
                , Tuple.Create(Tuple.Create("", 6225), Tuple.Create("IQLabel104833", 6225), true)
                , Tuple.Create(Tuple.Create(" ", 6238), Tuple.Create<System.Object, System.Int32>(!Model.QryCategory.LabelVisible ? " hide " : ""
                , 6239), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 6290), Tuple.Create("\'", 6503)
                                          , Tuple.Create(Tuple.Create("", 6299), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryCategory.BackHEXColor) ? "" : "color:" + Model.QryCategory.BackHEXColor + ";"
                , 6299), false)
                , Tuple.Create(Tuple.Create("", 6409), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:375px;height:21px;width:12" +
                "0px;top:53px;", 6409), true)
                );
                WriteLiteral(">Category</label>\r\n\t\t<input");
                WriteLiteral(" data-ScreenInfo=\'Query_QryCategory\'");
                WriteLiteral(" \r\n\t\t");
                Write(Model.RecordLocked || !Model.QryCategory.Enabled ? "disabled=disabled" : "");
                WriteLiteral(" class=\'form-control   ");
                Write(!Model.QryCategory.Visible ? " hide " : "");
                WriteLiteral("\' ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryCategory/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryCategory/',$(this));\""));
                WriteLiteral(" type=\'text\' name=\'PopulateQryCategory\' value=\'");
                Write(Model.QryCategory.ValueFormatted);
                WriteLiteral("\' style=\'position: absolute; left:500px;height:21px;width:200px;top:53px;\'/><labe" +
                "l");
                WriteAttribute("class", Tuple.Create(" class=\'", 7103), Tuple.Create("\'", 7180)
                , Tuple.Create(Tuple.Create("", 7111), Tuple.Create("IQLabel104851", 7111), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 , Tuple.Create(Tuple.Create(" ", 7124), Tuple.Create<System.Object, System.Int32>(!Model.QryRelationships.LabelVisible ? " hide " : ""
                , 7125), false)
                );
                WriteAttribute("style", Tuple.Create("  style=\'", 7181), Tuple.Create("\'", 7403)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 7190), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.QryRelationships.BackHEXColor) ? "" : "color:" + Model.QryRelationships.BackHEXColor + ";"
                , 7190), false)
                , Tuple.Create(Tuple.Create("", 7310), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:675px;height:21px;width:12" +
                "0px;top:3px;", 7310), true)
                );
                WriteLiteral(">Relationships</label>\r\n\t\t<div");
                WriteLiteral(" class=\'input-group\'");
                WriteLiteral(" data-OriginalWidth=\'400\'");
                WriteLiteral(" style=\'position: absolute; left:800px;height:71px;width:400px;top:3px;\'");
                WriteLiteral(">\t\t<textarea");
                WriteLiteral(" data-Label=\'Relationships\'");
                WriteLiteral(" data-ScreenInfo=\'Query_QryRelationships\'");
                WriteLiteral(" ");
                Write(Model.RecordLocked || !Model.QryRelationships.Enabled ? "disabled=disabled" : "");
                WriteLiteral("  ");
                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Query/SaveQryRelationships/?RecId=" + Model.RecordID + "',$(this));\"" : "onchange=\"javascript:IQDirtyCallback('/Query/CallbackQryRelationships/',$(this));\""));
                WriteLiteral("  class=\'form-control    ");
                Write(!Model.QryRelationships.Visible ? " hide " : "");
                WriteLiteral(" \' name=\'PopulateQryRelationships\' style=\'height:71px\'>");
                Write(Model.PopulateQryRelationships);
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
                WriteLiteral(" data-target=\"*[name=PopulateQryRelationships]\"");
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Edit_1.cshtml")]
        public partial class Views_Query_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Edit_1_cshtml()
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
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"btn-toolbar\"");
                    WriteLiteral(" role=\"toolbar\"");
                    WriteLiteral(" >\r\n\t\t<div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
                    WriteLiteral(" href=\"/Query/Add\"");
                    WriteLiteral(" class=\"btn btn-primary\"");
                    WriteLiteral(">Add Query</a>\r\n\t\t\t\r\n");
                    if (!Model.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t<input");
                        WriteLiteral(" type=\"button\"");
                        WriteAttribute("onclick", Tuple.Create(" onclick=\'", 398), Tuple.Create("\'", 457)
                        , Tuple.Create(Tuple.Create("", 408), Tuple.Create("IQJSCall(\"/Query/Delete/?RecId=", 408), true)
                              , Tuple.Create(Tuple.Create("", 439), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 439), false)
                        , Tuple.Create(Tuple.Create("", 454), Tuple.Create("\");", 454), true)
                        );
                        WriteLiteral(" class=\"btn btn-danger btn-animated\"");
                        WriteLiteral(" value=\"Delete\"");
                        WriteLiteral(" />\r\n");
                    }
                    WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Query/" +
                    "ViewHistory/?RecId=");
                    Write(Model.RecordID.Value);
                    WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
                    "eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
                    "div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                    {
                        foreach (var elm in itm(Model))
                        {
                            WriteLiteral("\t\t\t\t\t");
                            Write(Html.Raw(elm.HTML));
                            WriteLiteral("\r\n");
                        }
                    }
                    WriteLiteral("\t\t\t");
                    foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
                    {
                        foreach (var elem in itm.Invoke("Query", Model.RecordID.Value))
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
                WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1367)
                , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
                , 1353), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentTitle\'");
                WriteAttribute("value", Tuple.Create(" value=\'", 1413), Tuple.Create("\'", 1437)
                , Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
                , 1421), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentDS\'");
                WriteLiteral(" value=\"Query\"");
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1536), Tuple.Create("\"", 1561)
                , Tuple.Create(Tuple.Create("", 1544), Tuple.Create<System.Object, System.Int32>(Model.QryIdValue
                , 1544), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentRecId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1607), Tuple.Create("\"", 1630)
                , Tuple.Create(Tuple.Create("", 1615), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1615), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'RecordID\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1672), Tuple.Create("\"", 1695)
                , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1680), false)
                );
                WriteLiteral(" />\r\n\r\n");
                if (ViewBag.HistoryView == true)
                {
                    WriteLiteral("\t");
                    Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Query/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
                    WriteLiteral("\r\n");
                    foreach (AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems)
                    {
                        WriteLiteral("\t\t<tr><td><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 1991), Tuple.Create("\"", 2090)
                        , Tuple.Create(Tuple.Create("", 1998), Tuple.Create("/Query/ViewHistory/?RecId=", 1998), true)
                        , Tuple.Create(Tuple.Create("", 2024), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 2024), false)
                        , Tuple.Create(Tuple.Create("", 2039), Tuple.Create("&dt=", 2039), true)
                        , Tuple.Create(Tuple.Create("", 2043), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
                        , 2043), false)
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
                WriteLiteral(" id=\"Query\"");
                WriteLiteral(" style=\'position:relative;height:579px\'");
                WriteLiteral(">\r\n");
                Html.RenderPartial("~/Views/Query_Query.cshtml", Model);
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n</div>\r\n\r\n");
                if (ViewBag.HistoryView == true)
                {
                    Write(Html.Raw("</div></div>"));
                    ;
                }
                WriteLiteral("\r\n");
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<ul");
                    WriteLiteral(" class=\"nav nav-tabs\"");
                    WriteLiteral(" role=\"tablist\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t");
                        WriteLiteral("<li");
                        WriteLiteral(" role=\"presentation\"");
                        WriteLiteral(" class=\'\'");
                        WriteLiteral("><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 2865), Tuple.Create("\"", 2880)
                        , Tuple.Create(Tuple.Create("", 2872), Tuple.Create("#", 2872), true)
                        , Tuple.Create(Tuple.Create("", 2873), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 2873), false)
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
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t<div");
                        WriteLiteral(" role=\"tabpanel\"");
                        WriteLiteral(" class=\"tab-pane\"");
                        WriteAttribute("id", Tuple.Create(" id=\"", 3096), Tuple.Create("\"", 3108)
                        , Tuple.Create(Tuple.Create("", 3101), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 3101), false)
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Add_1.cshtml")]
        public partial class Views_Query_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Add_1_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Add Query";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Add Query\"");
                WriteLiteral("></noscript>\r\n<div");
                WriteLiteral(" class=\"btn-toolbar\"");
                WriteLiteral(" role=\"toolbar\"");
                WriteLiteral(">\r\n\t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(" >\r\n\t\t<input");
                WriteLiteral(" type=\"button\"");
                WriteLiteral(" onclick=\'IQSaveRecord(\"/Query/AddRecord\")\'");
                WriteLiteral(" class=\"btn btn-primary\"");
                WriteLiteral(" value=\"Save Record\"");
                WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(">\r\n");
                foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                {
                    foreach (var elm in itm(Model))
                    {
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
                WriteLiteral(" id=\"Query\"");
                WriteLiteral(" style=\'position:relative\'");
                WriteLiteral(">\r\n");
                Html.RenderPartial("~/Views/Query_Query.cshtml", Model);
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_List_1.cshtml")]
        public partial class Views_Query_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Query>>
        {
            public Views_Query_List_1_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Query List";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Query List\"");
                WriteLiteral("></noscript> \r\n\r\n");
                if (ViewBag.ListView == true)
                {
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/Add\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Add Query</a>\r\n");
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/ExportAll\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Export List</a>\r\n");
                }
                if (ViewBag.MoreResults == true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"alert alert-warning\"");
                    WriteLiteral(">There are ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral(" results, only showing ");
                    Write(ViewBag.Limit);
                    WriteLiteral(", <a");
                    WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
                    , Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Query/ListFromQuery/?Clause=", 490), true)
                                                                                     , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
                    , 519), false)
                    , Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
                    , 539), false)
                    );
                    WriteLiteral(">View all ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral("</a></div>\r\n");
                }
                WriteLiteral("\r\n<table");
                WriteLiteral(" class=\'table table-striped\'");
                WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
                WriteLiteral(" style=\'width:100px;\'");
                WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>System Name</th><th>Content</th>\t\t</tr>\r\n\t</thead>\r" +
                "\n");
                foreach (var itm in Model)
                {
                    WriteLiteral("\t\t");
                    WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
                    WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
                    WriteAttribute("href", Tuple.Create(" href=\"", 863), Tuple.Create("\"", 902)
                    , Tuple.Create(Tuple.Create("", 870), Tuple.Create("/Query/Load/?RecId=", 870), true)
                                  , Tuple.Create(Tuple.Create("", 889), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                    , 889), false)
                    );
                    WriteLiteral("><img");
                    WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
                    WriteLiteral(" style=\'max-height:21px;\'");
                    WriteLiteral(" />View Record</a></td>\r\n");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1152), Tuple.Create("\"", 1236)
                        , Tuple.Create(Tuple.Create("", 1163), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryName/?RecId=", 1163), true)
                                                                                          , Tuple.Create(Tuple.Create("", 1212), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1212), false)
                        , Tuple.Create(Tuple.Create("", 1225), Tuple.Create("\',$(this));", 1225), true)
                        );
                        WriteLiteral(" data-bound-name=\'QryName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1294), Tuple.Create("\'", 1334)
                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QryName.HTMLValue)
                        , 1302), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QrySysName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1523), Tuple.Create("\"", 1610)
                        , Tuple.Create(Tuple.Create("", 1534), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQrySysName/?RecId=", 1534), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1586), false)
                        , Tuple.Create(Tuple.Create("", 1599), Tuple.Create("\',$(this));", 1599), true)
                        );
                        WriteLiteral(" data-bound-name=\'QrySysName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1671), Tuple.Create("\'", 1714)
                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1679), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QrySysName.HTMLValue)
                        , 1679), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryContent.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:50%\'");
                        WriteLiteral("><textarea");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1903), Tuple.Create("\"", 1990)
                        , Tuple.Create(Tuple.Create("", 1914), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryContent/?RecId=", 1914), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1966), false)
                        , Tuple.Create(Tuple.Create("", 1979), Tuple.Create("\',$(this));", 1979), true)
                        );
                        WriteLiteral(" class=\'form-control\'");
                        WriteLiteral(" data-bound-name=\'QryContent\'");
                        WriteLiteral(">");
                        Write(Html.Raw(itm.QryContent.HTMLValue));
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Edit_2.cshtml")]
        public partial class Views_Query_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Edit_2_cshtml()
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
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"btn-toolbar\"");
                    WriteLiteral(" role=\"toolbar\"");
                    WriteLiteral(" >\r\n\t\t<div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
                    WriteLiteral(" href=\"/Query/Add\"");
                    WriteLiteral(" class=\"btn btn-primary\"");
                    WriteLiteral(">Add Query</a>\r\n\t\t\t\r\n");
                    if (!Model.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t<input");
                        WriteLiteral(" type=\"button\"");
                        WriteAttribute("onclick", Tuple.Create(" onclick=\'", 398), Tuple.Create("\'", 457)
                        , Tuple.Create(Tuple.Create("", 408), Tuple.Create("IQJSCall(\"/Query/Delete/?RecId=", 408), true)
                              , Tuple.Create(Tuple.Create("", 439), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 439), false)
                        , Tuple.Create(Tuple.Create("", 454), Tuple.Create("\");", 454), true)
                        );
                        WriteLiteral(" class=\"btn btn-danger btn-animated\"");
                        WriteLiteral(" value=\"Delete\"");
                        WriteLiteral(" />\r\n");
                    }
                    WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Query/" +
                    "ViewHistory/?RecId=");
                    Write(Model.RecordID.Value);
                    WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
                    "eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
                    "div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                    {
                        foreach (var elm in itm(Model))
                        {
                            WriteLiteral("\t\t\t\t\t");
                            Write(Html.Raw(elm.HTML));
                            WriteLiteral("\r\n");
                        }
                    }
                    WriteLiteral("\t\t\t");
                    foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
                    {
                        foreach (var elem in itm.Invoke("Query", Model.RecordID.Value))
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
                WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1367)
                , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
                , 1353), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentTitle\'");
                WriteAttribute("value", Tuple.Create(" value=\'", 1413), Tuple.Create("\'", 1437)
                , Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
                , 1421), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentDS\'");
                WriteLiteral(" value=\"Query\"");
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1536), Tuple.Create("\"", 1561)
                , Tuple.Create(Tuple.Create("", 1544), Tuple.Create<System.Object, System.Int32>(Model.QryIdValue
                , 1544), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentRecId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1607), Tuple.Create("\"", 1630)
                , Tuple.Create(Tuple.Create("", 1615), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1615), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'RecordID\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1672), Tuple.Create("\"", 1695)
                , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1680), false)
                );
                WriteLiteral(" />\r\n\r\n");
                if (ViewBag.HistoryView == true)
                {
                    WriteLiteral("\t");
                    Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Query/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
                    WriteLiteral("\r\n");
                    foreach (AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems)
                    {
                        WriteLiteral("\t\t<tr><td><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 1991), Tuple.Create("\"", 2090)
                        , Tuple.Create(Tuple.Create("", 1998), Tuple.Create("/Query/ViewHistory/?RecId=", 1998), true)
                        , Tuple.Create(Tuple.Create("", 2024), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 2024), false)
                        , Tuple.Create(Tuple.Create("", 2039), Tuple.Create("&dt=", 2039), true)
                        , Tuple.Create(Tuple.Create("", 2043), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
                        , 2043), false)
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
                WriteLiteral(" id=\"Query\"");
                WriteLiteral(" style=\'position:relative;height:579px\'");
                WriteLiteral(">\r\n");
                Html.RenderPartial("~/Views/Query_Query.cshtml", Model);
                WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n</div>\r\n\r\n");
                if (ViewBag.HistoryView == true)
                {
                    Write(Html.Raw("</div></div>"));
                    ;
                }
                WriteLiteral("\r\n");
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<ul");
                    WriteLiteral(" class=\"nav nav-tabs\"");
                    WriteLiteral(" role=\"tablist\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t");
                        WriteLiteral("<li");
                        WriteLiteral(" role=\"presentation\"");
                        WriteLiteral(" class=\'\'");
                        WriteLiteral("><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 2865), Tuple.Create("\"", 2880)
                        , Tuple.Create(Tuple.Create("", 2872), Tuple.Create("#", 2872), true)
                        , Tuple.Create(Tuple.Create("", 2873), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 2873), false)
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
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t<div");
                        WriteLiteral(" role=\"tabpanel\"");
                        WriteLiteral(" class=\"tab-pane\"");
                        WriteAttribute("id", Tuple.Create(" id=\"", 3096), Tuple.Create("\"", 3108)
                        , Tuple.Create(Tuple.Create("", 3101), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 3101), false)
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Add_2.cshtml")]
        public partial class Views_Query_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Add_2_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Add Query";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Add Query\"");
                WriteLiteral("></noscript>\r\n<div");
                WriteLiteral(" class=\"btn-toolbar\"");
                WriteLiteral(" role=\"toolbar\"");
                WriteLiteral(">\r\n\t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(" >\r\n\t\t<input");
                WriteLiteral(" type=\"button\"");
                WriteLiteral(" onclick=\'IQSaveRecord(\"/Query/AddRecord\")\'");
                WriteLiteral(" class=\"btn btn-primary\"");
                WriteLiteral(" value=\"Save Record\"");
                WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(">\r\n");
                foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                {
                    foreach (var elm in itm(Model))
                    {
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
                WriteLiteral(" id=\"Query\"");
                WriteLiteral(" style=\'position:relative\'");
                WriteLiteral(">\r\n");
                Html.RenderPartial("~/Views/Query_Query.cshtml", Model);
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_List_2.cshtml")]
        public partial class Views_Query_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Query>>
        {
            public Views_Query_List_2_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Query List";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Query List\"");
                WriteLiteral("></noscript> \r\n\r\n");
                if (ViewBag.ListView == true)
                {
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/Add\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Add Query</a>\r\n");
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/ExportAll\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Export List</a>\r\n");
                }
                if (ViewBag.MoreResults == true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"alert alert-warning\"");
                    WriteLiteral(">There are ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral(" results, only showing ");
                    Write(ViewBag.Limit);
                    WriteLiteral(", <a");
                    WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
                    , Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Query/ListFromQuery/?Clause=", 490), true)
                                                                                     , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
                    , 519), false)
                    , Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
                    , 539), false)
                    );
                    WriteLiteral(">View all ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral("</a></div>\r\n");
                }
                WriteLiteral("\r\n<table");
                WriteLiteral(" class=\'table table-striped\'");
                WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
                WriteLiteral(" style=\'width:100px;\'");
                WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>System Name</th><th>Content</th>\t\t</tr>\r\n\t</thead>\r" +
                "\n");
                foreach (var itm in Model)
                {
                    WriteLiteral("\t\t");
                    WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
                    WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
                    WriteAttribute("href", Tuple.Create(" href=\"", 863), Tuple.Create("\"", 902)
                    , Tuple.Create(Tuple.Create("", 870), Tuple.Create("/Query/Load/?RecId=", 870), true)
                                  , Tuple.Create(Tuple.Create("", 889), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                    , 889), false)
                    );
                    WriteLiteral("><img");
                    WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
                    WriteLiteral(" style=\'max-height:21px;\'");
                    WriteLiteral(" />View Record</a></td>\r\n");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1152), Tuple.Create("\"", 1236)
                        , Tuple.Create(Tuple.Create("", 1163), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryName/?RecId=", 1163), true)
                                                                                          , Tuple.Create(Tuple.Create("", 1212), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1212), false)
                        , Tuple.Create(Tuple.Create("", 1225), Tuple.Create("\',$(this));", 1225), true)
                        );
                        WriteLiteral(" data-bound-name=\'QryName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1294), Tuple.Create("\'", 1334)
                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QryName.HTMLValue)
                        , 1302), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QrySysName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1523), Tuple.Create("\"", 1610)
                        , Tuple.Create(Tuple.Create("", 1534), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQrySysName/?RecId=", 1534), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1586), false)
                        , Tuple.Create(Tuple.Create("", 1599), Tuple.Create("\',$(this));", 1599), true)
                        );
                        WriteLiteral(" data-bound-name=\'QrySysName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1671), Tuple.Create("\'", 1714)
                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1679), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QrySysName.HTMLValue)
                        , 1679), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryContent.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:50%\'");
                        WriteLiteral("><textarea");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1903), Tuple.Create("\"", 1990)
                        , Tuple.Create(Tuple.Create("", 1914), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryContent/?RecId=", 1914), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1966), false)
                        , Tuple.Create(Tuple.Create("", 1979), Tuple.Create("\',$(this));", 1979), true)
                        );
                        WriteLiteral(" class=\'form-control\'");
                        WriteLiteral(" data-bound-name=\'QryContent\'");
                        WriteLiteral(">");
                        Write(Html.Raw(itm.QryContent.HTMLValue));
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Edit_3.cshtml")]
        public partial class Views_Query_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Edit_3_cshtml()
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
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"btn-toolbar\"");
                    WriteLiteral(" role=\"toolbar\"");
                    WriteLiteral(" >\r\n\t\t<div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(" >\r\n\t\t\t\t\t\t<a");
                    WriteLiteral(" href=\"/Query/Add\"");
                    WriteLiteral(" class=\"btn btn-primary\"");
                    WriteLiteral(">Add Query</a>\r\n\t\t\t\r\n");
                    if (!Model.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t<input");
                        WriteLiteral(" type=\"button\"");
                        WriteAttribute("onclick", Tuple.Create(" onclick=\'", 398), Tuple.Create("\'", 457)
                        , Tuple.Create(Tuple.Create("", 408), Tuple.Create("IQJSCall(\"/Query/Delete/?RecId=", 408), true)
                              , Tuple.Create(Tuple.Create("", 439), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 439), false)
                        , Tuple.Create(Tuple.Create("", 454), Tuple.Create("\");", 454), true)
                        );
                        WriteLiteral(" class=\"btn btn-danger btn-animated\"");
                        WriteLiteral(" value=\"Delete\"");
                        WriteLiteral(" />\r\n");
                    }
                    WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Query/" +
                    "ViewHistory/?RecId=");
                    Write(Model.RecordID.Value);
                    WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
                    "eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
                    "div");
                    WriteLiteral(" class=\"btn-group\"");
                    WriteLiteral(" role=\"group\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                    {
                        foreach (var elm in itm(Model))
                        {
                            WriteLiteral("\t\t\t\t\t");
                            Write(Html.Raw(elm.HTML));
                            WriteLiteral("\r\n");
                        }
                    }
                    WriteLiteral("\t\t\t");
                    foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
                    {
                        foreach (var elem in itm.Invoke("Query", Model.RecordID.Value))
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
                WriteAttribute("value", Tuple.Create(" value=\'", 1345), Tuple.Create("\'", 1367)
                , Tuple.Create(Tuple.Create("", 1353), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
                , 1353), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentTitle\'");
                WriteAttribute("value", Tuple.Create(" value=\'", 1413), Tuple.Create("\'", 1437)
                , Tuple.Create(Tuple.Create("", 1421), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
                , 1421), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentDS\'");
                WriteLiteral(" value=\"Query\"");
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1536), Tuple.Create("\"", 1561)
                , Tuple.Create(Tuple.Create("", 1544), Tuple.Create<System.Object, System.Int32>(Model.QryIdValue
                , 1544), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'CurrentRecId\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1607), Tuple.Create("\"", 1630)
                , Tuple.Create(Tuple.Create("", 1615), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1615), false)
                );
                WriteLiteral(" />\r\n<input");
                WriteLiteral(" type=\'hidden\'");
                WriteLiteral(" name=\'RecordID\'");
                WriteAttribute("value", Tuple.Create(" value=\"", 1672), Tuple.Create("\"", 1695)
                , Tuple.Create(Tuple.Create("", 1680), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                , 1680), false)
                );
                WriteLiteral(" />\r\n\r\n");
                if (ViewBag.HistoryView == true)
                {
                    WriteLiteral("\t");
                    Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Query/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
                    WriteLiteral("\r\n");
                    foreach (AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems)
                    {
                        WriteLiteral("\t\t<tr><td><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 1991), Tuple.Create("\"", 2090)
                        , Tuple.Create(Tuple.Create("", 1998), Tuple.Create("/Query/ViewHistory/?RecId=", 1998), true)
                        , Tuple.Create(Tuple.Create("", 2024), Tuple.Create<System.Object, System.Int32>(Model.RecordID
                        , 2024), false)
                        , Tuple.Create(Tuple.Create("", 2039), Tuple.Create("&dt=", 2039), true)
                        , Tuple.Create(Tuple.Create("", 2043), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
                        , 2043), false)
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
                if (ViewBag.HistoryView == true)
                {
                    Write(Html.Raw("</div></div>"));
                    ;
                }
                WriteLiteral("\r\n");
                if (ViewBag.HistoryView != true)
                {
                    WriteLiteral("\t<ul");
                    WriteLiteral(" class=\"nav nav-tabs\"");
                    WriteLiteral(" role=\"tablist\"");
                    WriteLiteral(">\r\n");
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t");
                        WriteLiteral("<li");
                        WriteLiteral(" role=\"presentation\"");
                        WriteLiteral(" class=\'\'");
                        WriteLiteral("><a");
                        WriteAttribute("href", Tuple.Create(" href=\"", 2682), Tuple.Create("\"", 2697)
                        , Tuple.Create(Tuple.Create("", 2689), Tuple.Create("#", 2689), true)
                        , Tuple.Create(Tuple.Create("", 2690), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 2690), false)
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
                    foreach (var itm in Model.CachedSubForms.Where(f => f.CustomScreen))
                    {
                        WriteLiteral("\t\t\t<div");
                        WriteLiteral(" role=\"tabpanel\"");
                        WriteLiteral(" class=\"tab-pane\"");
                        WriteAttribute("id", Tuple.Create(" id=\"", 2913), Tuple.Create("\"", 2925)
                        , Tuple.Create(Tuple.Create("", 2918), Tuple.Create<System.Object, System.Int32>(itm.Id
                        , 2918), false)
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_Add_3.cshtml")]
        public partial class Views_Query_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Query>
        {
            public Views_Query_Add_3_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Add Query";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Add Query\"");
                WriteLiteral("></noscript>\r\n<div");
                WriteLiteral(" class=\"btn-toolbar\"");
                WriteLiteral(" role=\"toolbar\"");
                WriteLiteral(">\r\n\t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(" >\r\n\t\t<input");
                WriteLiteral(" type=\"button\"");
                WriteLiteral(" onclick=\'IQSaveRecord(\"/Query/AddRecord\")\'");
                WriteLiteral(" class=\"btn btn-primary\"");
                WriteLiteral(" value=\"Save Record\"");
                WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
                WriteLiteral(" class=\"btn-group\"");
                WriteLiteral(" role=\"group\"");
                WriteLiteral(">\r\n");
                foreach (var itm in DS.GetManager<Query>().OnDrawSingleToolbar)
                {
                    foreach (var elm in itm(Model))
                    {
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
        [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Query_List_3.cshtml")]
        public partial class Views_Query_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Query>>
        {
            public Views_Query_List_3_cshtml()
            {
            }
            public override void Execute()
            {
                ViewBag.Title = "Query List";
                WriteLiteral("\r\n<noscript");
                WriteLiteral(" data-title=\"Query List\"");
                WriteLiteral("></noscript> \r\n\r\n");
                if (ViewBag.ListView == true)
                {
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/Add\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Add Query</a>\r\n");
                    WriteLiteral("\t<a");
                    WriteLiteral(" href=\'/Query/ExportAll\'");
                    WriteLiteral(" class=\'btn btn-primary\'");
                    WriteLiteral(">Export List</a>\r\n");
                }
                if (ViewBag.MoreResults == true)
                {
                    WriteLiteral("\t<div");
                    WriteLiteral(" class=\"alert alert-warning\"");
                    WriteLiteral(">There are ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral(" results, only showing ");
                    Write(ViewBag.Limit);
                    WriteLiteral(", <a");
                    WriteAttribute("href", Tuple.Create(" href=\"", 483), Tuple.Create("\"", 551)
                    , Tuple.Create(Tuple.Create("", 490), Tuple.Create("/Query/ListFromQuery/?Clause=", 490), true)
                                                                                     , Tuple.Create(Tuple.Create("", 519), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
                    , 519), false)
                    , Tuple.Create(Tuple.Create("", 534), Tuple.Create("&Ord=", 534), true)
                                                                                                         , Tuple.Create(Tuple.Create("", 539), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
                    , 539), false)
                    );
                    WriteLiteral(">View all ");
                    Write(ViewBag.ResultCount);
                    WriteLiteral("</a></div>\r\n");
                }
                WriteLiteral("\r\n<table");
                WriteLiteral(" class=\'table table-striped\'");
                WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
                WriteLiteral(" style=\'width:100px;\'");
                WriteLiteral("></th>\r\n\t\t\t\t\t<th>Name</th><th>System Name</th><th>Content</th>\t\t</tr>\r\n\t</thead>\r" +
                "\n");
                foreach (var itm in Model)
                {
                    WriteLiteral("\t\t");
                    WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
                    WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
                    WriteAttribute("href", Tuple.Create(" href=\"", 863), Tuple.Create("\"", 902)
                    , Tuple.Create(Tuple.Create("", 870), Tuple.Create("/Query/Load/?RecId=", 870), true)
                                  , Tuple.Create(Tuple.Create("", 889), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                    , 889), false)
                    );
                    WriteLiteral("><img");
                    WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
                    WriteLiteral(" style=\'max-height:21px;\'");
                    WriteLiteral(" />View Record</a></td>\r\n");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1152), Tuple.Create("\"", 1236)
                        , Tuple.Create(Tuple.Create("", 1163), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryName/?RecId=", 1163), true)
                                                                                          , Tuple.Create(Tuple.Create("", 1212), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1212), false)
                        , Tuple.Create(Tuple.Create("", 1225), Tuple.Create("\',$(this));", 1225), true)
                        );
                        WriteLiteral(" data-bound-name=\'QryName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1294), Tuple.Create("\'", 1334)
                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 1302), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QryName.HTMLValue)
                        , 1302), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QrySysName.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:25%\'");
                        WriteLiteral("><input");
                        WriteLiteral("  class=\'form-control\'");
                        WriteLiteral(" type=\'text\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1523), Tuple.Create("\"", 1610)
                        , Tuple.Create(Tuple.Create("", 1534), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQrySysName/?RecId=", 1534), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1586), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1586), false)
                        , Tuple.Create(Tuple.Create("", 1599), Tuple.Create("\',$(this));", 1599), true)
                        );
                        WriteLiteral(" data-bound-name=\'QrySysName\'");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("value", Tuple.Create(" value=\'", 1671), Tuple.Create("\'", 1714)
                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 1679), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.QrySysName.HTMLValue)
                        , 1679), false)
                        );
                        WriteLiteral(" /></td>\r\n");
                    }
                    WriteLiteral("\t\t\t\t\t\t");
                    if (itm.RecordLocked)
                    {
                        WriteLiteral("\t\t\t\t\t\t\t<td>");
                        Write(itm.QryContent.DisplayValue);
                        WriteLiteral("</td>\r\n");
                    }
                    else
                    {
                        WriteLiteral("\t\t\t\t\t\t<td");
                        WriteLiteral(" style=\'width:50%\'");
                        WriteLiteral("><textarea");
                        WriteLiteral(" style=\'height:21px;width:100%\'");
                        WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1903), Tuple.Create("\"", 1990)
                        , Tuple.Create(Tuple.Create("", 1914), Tuple.Create("javascript:IQAutoSave(\'/Query/SaveQryContent/?RecId=", 1914), true)
                                                                                             , Tuple.Create(Tuple.Create("", 1966), Tuple.Create<System.Object, System.Int32>(itm.RecordID
                        , 1966), false)
                        , Tuple.Create(Tuple.Create("", 1979), Tuple.Create("\',$(this));", 1979), true)
                        );
                        WriteLiteral(" class=\'form-control\'");
                        WriteLiteral(" data-bound-name=\'QryContent\'");
                        WriteLiteral(">");
                        Write(Html.Raw(itm.QryContent.HTMLValue));
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
