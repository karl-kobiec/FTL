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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Customers.cshtml")]
    public partial class Views_Customer_Customers_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Customers_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 131)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel100111", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.CustId.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 132), Tuple.Create("\'", 332)
     , Tuple.Create(Tuple.Create("", 141), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustId.BackHEXColor) ? "" : "color:" + Model.CustId.BackHEXColor + ";"
, 141), false)
, Tuple.Create(Tuple.Create("", 241), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 241), true)
);
WriteLiteral(">Company ID</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustId\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 419), Tuple.Create("\'", 482)
, Tuple.Create(Tuple.Create("", 427), Tuple.Create("form-control", 427), true)
, Tuple.Create(Tuple.Create("   ", 439), Tuple.Create<System.Object, System.Int32>(!Model.CustId.Visible ? " hide " : ""
, 442), false)
);
WriteLiteral(" ");
                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustId/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustId/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustId\' value=\'");
                                                                                                                                                                                                                                                                                                                                                        Write(Model.CustId.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:80px;top:3px;\'/><label");
WriteAttribute("class", Tuple.Create(" class=\'", 851), Tuple.Create("\'", 920)
, Tuple.Create(Tuple.Create("", 859), Tuple.Create("IQLabel100112", 859), true)
                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create(" ", 872), Tuple.Create<System.Object, System.Int32>(!Model.CustName.LabelVisible ? " hide " : ""
, 873), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 921), Tuple.Create("\'", 1126)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 930), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustName.BackHEXColor) ? "" : "color:" + Model.CustName.BackHEXColor + ";"
, 930), false)
, Tuple.Create(Tuple.Create("", 1034), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:28px;", 1034), true)
);
WriteLiteral(">Company Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                               Write(!Model.CustName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CustName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:28px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 1728), Tuple.Create("\'", 1797)
, Tuple.Create(Tuple.Create("", 1736), Tuple.Create("IQLabel100113", 1736), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              , Tuple.Create(Tuple.Create(" ", 1749), Tuple.Create<System.Object, System.Int32>(!Model.CustType.LabelVisible ? " hide " : ""
, 1750), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1798), Tuple.Create("\'", 2003)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 1807), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustType.BackHEXColor) ? "" : "color:" + Model.CustType.BackHEXColor + ";"
, 1807), false)
, Tuple.Create(Tuple.Create("", 1911), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:53px;", 1911), true)
);
WriteLiteral(">Client Type</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustType\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.CustType.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustType/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustType/',$(this));\""));
WriteLiteral("   name=\'PopulateCustType\'  style=\'position: absolute; left:130px;height:21px;wid" +
"th:180px;top:53px;\'>\r\n");
             foreach(var itm in Model.CustType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2603), Tuple.Create("\'", 2624)
, Tuple.Create(Tuple.Create("", 2611), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2611), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustType.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 2756), Tuple.Create("\'", 2825)
, Tuple.Create(Tuple.Create("", 2764), Tuple.Create("IQLabel100114", 2764), true)
, Tuple.Create(Tuple.Create(" ", 2777), Tuple.Create<System.Object, System.Int32>(!Model.CustAddr.LabelVisible ? " hide " : ""
, 2778), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2826), Tuple.Create("\'", 3031)
                       , Tuple.Create(Tuple.Create("", 2835), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAddr.BackHEXColor) ? "" : "color:" + Model.CustAddr.BackHEXColor + ";"
, 2835), false)
, Tuple.Create(Tuple.Create("", 2939), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:78px;", 2939), true)
);
WriteLiteral(">Address1</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustAddr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CustAddr.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustAddr/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustAddr\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.CustAddr.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:78px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 3620), Tuple.Create("\'", 3690)
, Tuple.Create(Tuple.Create("", 3628), Tuple.Create("IQLabel100115", 3628), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 3641), Tuple.Create<System.Object, System.Int32>(!Model.CustAddr2.LabelVisible ? " hide " : ""
, 3642), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3691), Tuple.Create("\'", 3899)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                , Tuple.Create(Tuple.Create("", 3700), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAddr2.BackHEXColor) ? "" : "color:" + Model.CustAddr2.BackHEXColor + ";"
, 3700), false)
, Tuple.Create(Tuple.Create("", 3806), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:103px;", 3806), true)
);
WriteLiteral(">Address2</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustAddr2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustAddr2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CustAddr2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustAddr2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustAddr2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CustAddr2.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:103px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 4496), Tuple.Create("\'", 4566)
, Tuple.Create(Tuple.Create("", 4504), Tuple.Create("IQLabel100116", 4504), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 4517), Tuple.Create<System.Object, System.Int32>(!Model.CustAddr3.LabelVisible ? " hide " : ""
, 4518), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 4567), Tuple.Create("\'", 4775)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       , Tuple.Create(Tuple.Create("", 4576), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAddr3.BackHEXColor) ? "" : "color:" + Model.CustAddr3.BackHEXColor + ";"
, 4576), false)
, Tuple.Create(Tuple.Create("", 4682), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:128px;", 4682), true)
);
WriteLiteral(">Address3</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustAddr3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustAddr3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CustAddr3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustAddr3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustAddr3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CustAddr3.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 5372), Tuple.Create("\'", 5441)
, Tuple.Create(Tuple.Create("", 5380), Tuple.Create("IQLabel100117", 5380), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            , Tuple.Create(Tuple.Create(" ", 5393), Tuple.Create<System.Object, System.Int32>(!Model.CustTown.LabelVisible ? " hide " : ""
, 5394), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 5442), Tuple.Create("\'", 5648)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 5451), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustTown.BackHEXColor) ? "" : "color:" + Model.CustTown.BackHEXColor + ";"
, 5451), false)
, Tuple.Create(Tuple.Create("", 5555), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:153px;", 5555), true)
);
WriteLiteral(">Town</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustTown\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustTown.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CustTown.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustTown/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustTown/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustTown\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.CustTown.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 6234), Tuple.Create("\'", 6305)
, Tuple.Create(Tuple.Create("", 6242), Tuple.Create("IQLabel100118", 6242), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create(" ", 6255), Tuple.Create<System.Object, System.Int32>(!Model.CustCounty.LabelVisible ? " hide " : ""
, 6256), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 6306), Tuple.Create("\'", 6516)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 6315), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCounty.BackHEXColor) ? "" : "color:" + Model.CustCounty.BackHEXColor + ";"
, 6315), false)
, Tuple.Create(Tuple.Create("", 6423), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:178px;", 6423), true)
);
WriteLiteral(">County</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCounty\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustCounty.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                        Write(!Model.CustCounty.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCounty/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCounty/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustCounty\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.CustCounty.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:180px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7118), Tuple.Create("\'", 7185)
, Tuple.Create(Tuple.Create("", 7126), Tuple.Create("IQLabel100119", 7126), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 7139), Tuple.Create<System.Object, System.Int32>(!Model.CustPC.LabelVisible ? " hide " : ""
, 7140), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 7186), Tuple.Create("\'", 7388)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create("", 7195), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustPC.BackHEXColor) ? "" : "color:" + Model.CustPC.BackHEXColor + ";"
, 7195), false)
, Tuple.Create(Tuple.Create("", 7295), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:203px;", 7295), true)
);
WriteLiteral(">Postcode</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustPC\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustPC.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CustPC.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustPC/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustPC/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustPC\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.CustPC.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:100px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 7964), Tuple.Create("\'", 8033)
, Tuple.Create(Tuple.Create("", 7972), Tuple.Create("IQLabel100120", 7972), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 7985), Tuple.Create<System.Object, System.Int32>(!Model.CustCtry.LabelVisible ? " hide " : ""
, 7986), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 8034), Tuple.Create("\'", 8240)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 8043), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCtry.BackHEXColor) ? "" : "color:" + Model.CustCtry.BackHEXColor + ";"
, 8043), false)
, Tuple.Create(Tuple.Create("", 8147), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:228px;", 8147), true)
);
WriteLiteral(">Country</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:130px;height:21px;width:160px;top:228px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCtry\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustCtry.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.CustCtry.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCtry/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCtry/',$(this));\""));
WriteLiteral("   name=\'PopulateCustCtry\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CustCtry.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 8907), Tuple.Create("\'", 8928)
, Tuple.Create(Tuple.Create("", 8915), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 8915), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustCtry.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCustCtry]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 9809), Tuple.Create("\'", 9883)
, Tuple.Create(Tuple.Create("", 9817), Tuple.Create("IQLabel100122", 9817), true)
, Tuple.Create(Tuple.Create(" ", 9830), Tuple.Create<System.Object, System.Int32>(!Model.CustRecDueDil.LabelVisible ? " hide " : ""
, 9831), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 9884), Tuple.Create("\'", 10100)
                               , Tuple.Create(Tuple.Create("", 9893), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustRecDueDil.BackHEXColor) ? "" : "color:" + Model.CustRecDueDil.BackHEXColor + ";"
, 9893), false)
, Tuple.Create(Tuple.Create("", 10007), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:160p" +
"x;top:278px;", 10007), true)
);
WriteLiteral(">Received Due Diligence</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustRecDueDil\'");
WriteAttribute("class", Tuple.Create(" class=\'", 10191), Tuple.Create("\'", 10248)
, Tuple.Create(Tuple.Create("  ", 10199), Tuple.Create<System.Object, System.Int32>(!Model.CustRecDueDil.Visible ? " hide " : ""
, 10201), false)
);
WriteLiteral(" ");
                                                                                                               Write(Model.RecordLocked || !Model.CustRecDueDil.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustRecDueDil/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustRecDueDil/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:170px;height:16px;width:16px;top:278px;\' name=\'" +
"PopulateCustRecDueDil\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PopulateCustRecDueDil ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustRecDueDil\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                    Write(!Model.PopulateCustRecDueDil ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 10899), Tuple.Create("\'", 10974)
, Tuple.Create(Tuple.Create("", 10907), Tuple.Create("IQLabel100123", 10907), true)
, Tuple.Create(Tuple.Create(" ", 10920), Tuple.Create<System.Object, System.Int32>(!Model.CustCrdChecked.LabelVisible ? " hide " : ""
, 10921), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 10975), Tuple.Create("\'", 11193)
                   , Tuple.Create(Tuple.Create("", 10984), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCrdChecked.BackHEXColor) ? "" : "color:" + Model.CustCrdChecked.BackHEXColor + ";"
, 10984), false)
, Tuple.Create(Tuple.Create("", 11100), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:160p" +
"x;top:303px;", 11100), true)
);
WriteLiteral(">Credit Score Checked</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCrdChecked\'");
WriteAttribute("class", Tuple.Create(" class=\'", 11283), Tuple.Create("\'", 11341)
, Tuple.Create(Tuple.Create("  ", 11291), Tuple.Create<System.Object, System.Int32>(!Model.CustCrdChecked.Visible ? " hide " : ""
, 11293), false)
);
WriteLiteral(" ");
                                                                                                                 Write(Model.RecordLocked || !Model.CustCrdChecked.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCrdChecked/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCrdChecked/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:170px;height:16px;width:16px;top:303px;\' name=\'" +
"PopulateCustCrdChecked\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.PopulateCustCrdChecked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustCrdChecked\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                     Write(!Model.PopulateCustCrdChecked ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 11999), Tuple.Create("\'", 12079)
, Tuple.Create(Tuple.Create("", 12007), Tuple.Create("IQLabel100124", 12007), true)
, Tuple.Create(Tuple.Create(" ", 12020), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScoreReview.LabelVisible ? " hide " : ""
, 12021), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 12080), Tuple.Create("\'", 12308)
                        , Tuple.Create(Tuple.Create("", 12089), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCredScoreReview.BackHEXColor) ? "" : "color:" + Model.CustCredScoreReview.BackHEXColor + ";"
, 12089), false)
, Tuple.Create(Tuple.Create("", 12215), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:160p" +
"x;top:328px;", 12215), true)
);
WriteLiteral(">Credit Score Review date</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'100\'");
WriteLiteral(" style=\'position: absolute; left:170px;height:21px;width:100px;top:328px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCredScoreReview\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustCredScoreReview.Enabled ? "disabled=disabled" : "");
WriteLiteral(" data-date-format=\'DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                                                                                                        Write(!Model.CustCredScoreReview.Visible ? " hide " : "");
WriteLiteral(" \'  ");
                                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScoreReview/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCredScoreReview/',$(this));\""));
WriteLiteral("  type=\'text\' name=\'PopulateCustCredScoreReview\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           Write(Model.CustCredScoreReview.ValueFormatted);
WriteLiteral("\' style=\'height:21px\'/>\r\n\t\t\r\n\t\t<div");
WriteLiteral(" class=\"input-group-btn\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" type=\"button\"");
WriteLiteral(" class=\"btn btn-default btn-xs\"");
WriteLiteral(" onclick=\"ShowDatePicker(\'input[name=PopulateCustCredScoreReview]\');\"");
WriteLiteral("><img");
WriteLiteral(" src=\'/IQ6/date.png\'");
WriteLiteral(" \r\n\t\t\t\tstyle=\'max-height:10px;\'");
WriteLiteral(" /></button>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 13351), Tuple.Create("\'", 13421)
, Tuple.Create(Tuple.Create("", 13359), Tuple.Create("IQLabel100126", 13359), true)
, Tuple.Create(Tuple.Create(" ", 13372), Tuple.Create<System.Object, System.Int32>(!Model.CustRates.LabelVisible ? " hide " : ""
, 13373), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 13422), Tuple.Create("\'", 13629)
                              , Tuple.Create(Tuple.Create("", 13431), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustRates.BackHEXColor) ? "" : "color:" + Model.CustRates.BackHEXColor + ";"
, 13431), false)
, Tuple.Create(Tuple.Create("", 13537), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:5px;height:21px;width:120px" +
";top:353px;", 13537), true)
);
WriteLiteral(">Rates</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:5px;height:146px;width:400px;top:393px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Rates\'");
WriteLiteral(" data-ScreenInfo=\'Customers_CustRates\'");
WriteLiteral(" ");
                                                                                                                                                                                                       Write(Model.RecordLocked || !Model.CustRates.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                    Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustRates/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustRates/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             Write(!Model.CustRates.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustRates\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.PopulateCustRates);
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
WriteLiteral(" data-target=\"*[name=PopulateCustRates]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 14801), Tuple.Create("\'", 14871)
, Tuple.Create(Tuple.Create("", 14809), Tuple.Create("IQLabel100131", 14809), true)
, Tuple.Create(Tuple.Create(" ", 14822), Tuple.Create<System.Object, System.Int32>(!Model.CustPhone.LabelVisible ? " hide " : ""
, 14823), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14872), Tuple.Create("\'", 15080)
                              , Tuple.Create(Tuple.Create("", 14881), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustPhone.BackHEXColor) ? "" : "color:" + Model.CustPhone.BackHEXColor + ";"
, 14881), false)
, Tuple.Create(Tuple.Create("", 14987), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:3px;", 14987), true)
);
WriteLiteral(">Telephone</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:200px;top:3px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustPhone\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustPhone.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CustPhone.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustPhone/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustPhone/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustPhone\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CustPhone.ValueFormatted);
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
WriteLiteral(">\r\n\t\t\t\r\n");
                     foreach (var itm in DS.GlobalManager.CustomFieldElements.Where(f => f.KeyValue == DSFieldContentType.Phone))
            {
WriteLiteral("                ");
                 Write(itm.Description(Model.CustPhone, Customer.CustPhoneField, Model));
WriteLiteral(";");
WriteLiteral("\r\n");
            }
WriteLiteral("\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 16293), Tuple.Create("\'", 16361)
, Tuple.Create(Tuple.Create("", 16301), Tuple.Create("IQLabel100132", 16301), true)
, Tuple.Create(Tuple.Create(" ", 16314), Tuple.Create<System.Object, System.Int32>(!Model.CustFax.LabelVisible ? " hide " : ""
, 16315), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16362), Tuple.Create("\'", 16567)
                        , Tuple.Create(Tuple.Create("", 16371), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFax.BackHEXColor) ? "" : "color:" + Model.CustFax.BackHEXColor + ";"
, 16371), false)
, Tuple.Create(Tuple.Create("", 16473), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:28px;", 16473), true)
);
WriteLiteral(">Fax</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:200px;top:28px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustFax\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustFax.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.CustFax.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustFax/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustFax/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustFax\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.CustFax.ValueFormatted);
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
WriteLiteral(">\r\n\t\t\t\r\n");
                     foreach (var itm in DS.GlobalManager.CustomFieldElements.Where(f => f.KeyValue == DSFieldContentType.Phone))
            {
WriteLiteral("                ");
                 Write(itm.Description(Model.CustFax, Customer.CustFaxField, Model));
WriteLiteral(";");
WriteLiteral("\r\n");
            }
WriteLiteral("\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 17757), Tuple.Create("\'", 17824)
, Tuple.Create(Tuple.Create("", 17765), Tuple.Create("IQLabel100133", 17765), true)
, Tuple.Create(Tuple.Create(" ", 17778), Tuple.Create<System.Object, System.Int32>(!Model.CustEM.LabelVisible ? " hide " : ""
, 17779), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17825), Tuple.Create("\'", 18028)
                       , Tuple.Create(Tuple.Create("", 17834), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM.BackHEXColor) ? "" : "color:" + Model.CustEM.BackHEXColor + ";"
, 17834), false)
, Tuple.Create(Tuple.Create("", 17934), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:53px;", 17934), true)
);
WriteLiteral(">EMail</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:53px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustEM\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustEM.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                    Write(!Model.CustEM.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustEM/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustEM\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                Write(Model.CustEM.ValueFormatted);
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
WriteLiteral(" data-target=\"*[name=PopulateCustEM]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 19193), Tuple.Create("\'", 19261)
, Tuple.Create(Tuple.Create("", 19201), Tuple.Create("IQLabel100134", 19201), true)
, Tuple.Create(Tuple.Create(" ", 19214), Tuple.Create<System.Object, System.Int32>(!Model.CustEM2.LabelVisible ? " hide " : ""
, 19215), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 19262), Tuple.Create("\'", 19467)
                        , Tuple.Create(Tuple.Create("", 19271), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM2.BackHEXColor) ? "" : "color:" + Model.CustEM2.BackHEXColor + ";"
, 19271), false)
, Tuple.Create(Tuple.Create("", 19373), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:78px;", 19373), true)
);
WriteLiteral(">E-Mail 2</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:78px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustEM2\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustEM2.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.CustEM2.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM2/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustEM2/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustEM2\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.CustEM2.ValueFormatted);
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
WriteLiteral(" data-target=\"*[name=PopulateCustEM2]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 20643), Tuple.Create("\'", 20711)
, Tuple.Create(Tuple.Create("", 20651), Tuple.Create("IQLabel100135", 20651), true)
, Tuple.Create(Tuple.Create(" ", 20664), Tuple.Create<System.Object, System.Int32>(!Model.CustEM3.LabelVisible ? " hide " : ""
, 20665), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20712), Tuple.Create("\'", 20918)
                        , Tuple.Create(Tuple.Create("", 20721), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM3.BackHEXColor) ? "" : "color:" + Model.CustEM3.BackHEXColor + ";"
, 20721), false)
, Tuple.Create(Tuple.Create("", 20823), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:103px;", 20823), true)
);
WriteLiteral(">E-Mail 3</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:103px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustEM3\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustEM3.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.CustEM3.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM3/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustEM3/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustEM3\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.CustEM3.ValueFormatted);
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
WriteLiteral(" data-target=\"*[name=PopulateCustEM3]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 22095), Tuple.Create("\'", 22163)
, Tuple.Create(Tuple.Create("", 22103), Tuple.Create("IQLabel100136", 22103), true)
, Tuple.Create(Tuple.Create(" ", 22116), Tuple.Create<System.Object, System.Int32>(!Model.CustEM4.LabelVisible ? " hide " : ""
, 22117), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 22164), Tuple.Create("\'", 22370)
                        , Tuple.Create(Tuple.Create("", 22173), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM4.BackHEXColor) ? "" : "color:" + Model.CustEM4.BackHEXColor + ";"
, 22173), false)
, Tuple.Create(Tuple.Create("", 22275), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:128px;", 22275), true)
);
WriteLiteral(">E-Mail 4</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'240\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:21px;width:240px;top:128px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustEM4\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustEM4.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                     Write(!Model.CustEM4.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM4/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustEM4/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustEM4\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                     Write(Model.CustEM4.ValueFormatted);
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
WriteLiteral(" data-target=\"*[name=PopulateCustEM4]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 23547), Tuple.Create("\'", 23617)
, Tuple.Create(Tuple.Create("", 23555), Tuple.Create("IQLabel100137", 23555), true)
, Tuple.Create(Tuple.Create(" ", 23568), Tuple.Create<System.Object, System.Int32>(!Model.CustVATNo.LabelVisible ? " hide " : ""
, 23569), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23618), Tuple.Create("\'", 23828)
                          , Tuple.Create(Tuple.Create("", 23627), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustVATNo.BackHEXColor) ? "" : "color:" + Model.CustVATNo.BackHEXColor + ";"
, 23627), false)
, Tuple.Create(Tuple.Create("", 23733), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:153px;", 23733), true)
);
WriteLiteral(">VAT Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustVATNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustVATNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CustVATNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustVATNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustVATNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustVATNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CustVATNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:160px;top:153px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 24427), Tuple.Create("\'", 24497)
, Tuple.Create(Tuple.Create("", 24435), Tuple.Create("IQLabel100138", 24435), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 24448), Tuple.Create<System.Object, System.Int32>(!Model.CustDANNo.LabelVisible ? " hide " : ""
, 24449), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24498), Tuple.Create("\'", 24708)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 24507), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDANNo.BackHEXColor) ? "" : "color:" + Model.CustDANNo.BackHEXColor + ";"
, 24507), false)
, Tuple.Create(Tuple.Create("", 24613), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:178px;", 24613), true)
);
WriteLiteral(">DAN Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustDANNo\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustDANNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                       Write(!Model.CustDANNo.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustDANNo/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustDANNo/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustDANNo\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.CustDANNo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:160px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 25307), Tuple.Create("\'", 25376)
, Tuple.Create(Tuple.Create("", 25315), Tuple.Create("IQLabel100139", 25315), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 25328), Tuple.Create<System.Object, System.Int32>(!Model.CustGBWK.LabelVisible ? " hide " : ""
, 25329), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25377), Tuple.Create("\'", 25585)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 25386), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGBWK.BackHEXColor) ? "" : "color:" + Model.CustGBWK.BackHEXColor + ";"
, 25386), false)
, Tuple.Create(Tuple.Create("", 25490), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:203px;", 25490), true)
);
WriteLiteral(">GBWK</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustGBWK\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustGBWK.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                      Write(!Model.CustGBWK.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustGBWK/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustGBWK/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustGBWK\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.CustGBWK.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:160px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 26171), Tuple.Create("\'", 26244)
, Tuple.Create(Tuple.Create("", 26179), Tuple.Create("IQLabel100140", 26179), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 26192), Tuple.Create<System.Object, System.Int32>(!Model.CustBondCode.LabelVisible ? " hide " : ""
, 26193), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 26245), Tuple.Create("\'", 26461)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 26254), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustBondCode.BackHEXColor) ? "" : "color:" + Model.CustBondCode.BackHEXColor + ";"
, 26254), false)
, Tuple.Create(Tuple.Create("", 26366), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:228px;", 26366), true)
);
WriteLiteral(">REDS / Bond Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustBondCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustBondCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CustBondCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustBondCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustBondCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustBondCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CustBondCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:420px;height:21px;width:160px;top:228px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 27087), Tuple.Create("\'", 27158)
, Tuple.Create(Tuple.Create("", 27095), Tuple.Create("IQLabel100142", 27095), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 27108), Tuple.Create<System.Object, System.Int32>(!Model.CustCrdScr.LabelVisible ? " hide " : ""
, 27109), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 27159), Tuple.Create("\'", 27371)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 27168), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCrdScr.BackHEXColor) ? "" : "color:" + Model.CustCrdScr.BackHEXColor + ";"
, 27168), false)
, Tuple.Create(Tuple.Create("", 27276), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:278px;", 27276), true)
);
WriteLiteral(">Credit Score</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:420px;height:71px;width:400px;top:278px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Credit Score\'");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCrdScr\'");
WriteLiteral(" ");
                                                                                                                                                                                                                   Write(Model.RecordLocked || !Model.CustCrdScr.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                 Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCrdScr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCrdScr/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            Write(!Model.CustCrdScr.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustCrdScr\' style=\'height:71px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.PopulateCustCrdScr);
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
WriteLiteral(" data-target=\"*[name=PopulateCustCrdScr]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 28565), Tuple.Create("\'", 28638)
, Tuple.Create(Tuple.Create("", 28573), Tuple.Create("IQLabel100144", 28573), true)
, Tuple.Create(Tuple.Create(" ", 28586), Tuple.Create<System.Object, System.Int32>(!Model.CustGenNotes.LabelVisible ? " hide " : ""
, 28587), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 28639), Tuple.Create("\'", 28854)
                                 , Tuple.Create(Tuple.Create("", 28648), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGenNotes.BackHEXColor) ? "" : "color:" + Model.CustGenNotes.BackHEXColor + ";"
, 28648), false)
, Tuple.Create(Tuple.Create("", 28760), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:410px;height:21px;width:120" +
"px;top:353px;", 28760), true)
);
WriteLiteral(">General Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:410px;height:146px;width:400px;top:378px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'General Notes\'");
WriteLiteral(" data-ScreenInfo=\'Customers_CustGenNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                                      Write(Model.RecordLocked || !Model.CustGenNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                      Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustGenNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustGenNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     Write(!Model.CustGenNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustGenNotes\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(Model.PopulateCustGenNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateCustGenNotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 30068), Tuple.Create("\'", 30137)
, Tuple.Create(Tuple.Create("", 30076), Tuple.Create("IQLabel100151", 30076), true)
, Tuple.Create(Tuple.Create(" ", 30089), Tuple.Create<System.Object, System.Int32>(!Model.CustLang.LabelVisible ? " hide " : ""
, 30090), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 30138), Tuple.Create("\'", 30345)
                             , Tuple.Create(Tuple.Create("", 30147), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustLang.BackHEXColor) ? "" : "color:" + Model.CustLang.BackHEXColor + ";"
, 30147), false)
, Tuple.Create(Tuple.Create("", 30251), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:28px;", 30251), true)
);
WriteLiteral(">Language</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustLang\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustLang.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.CustLang.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustLang/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustLang/',$(this));\""));
WriteLiteral("   name=\'PopulateCustLang\'  style=\'position: absolute; left:780px;height:21px;wid" +
"th:160px;top:28px;\'>\r\n");
             foreach(var itm in Model.CustLang.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 30942), Tuple.Create("\'", 30963)
, Tuple.Create(Tuple.Create("", 30950), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 30950), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustLang.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 31095), Tuple.Create("\'", 31164)
, Tuple.Create(Tuple.Create("", 31103), Tuple.Create("IQLabel100152", 31103), true)
, Tuple.Create(Tuple.Create(" ", 31116), Tuple.Create<System.Object, System.Int32>(!Model.CustCurr.LabelVisible ? " hide " : ""
, 31117), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 31165), Tuple.Create("\'", 31372)
                      , Tuple.Create(Tuple.Create("", 31174), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCurr.BackHEXColor) ? "" : "color:" + Model.CustCurr.BackHEXColor + ";"
, 31174), false)
, Tuple.Create(Tuple.Create("", 31278), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:53px;", 31278), true)
);
WriteLiteral(">Currency</label>\r\n\t\t<select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCurr\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustCurr.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                       Write(!Model.CustCurr.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCurr/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCurr/',$(this));\""));
WriteLiteral("   name=\'PopulateCustCurr\'  style=\'position: absolute; left:780px;height:21px;wid" +
"th:160px;top:53px;\'>\r\n");
             foreach(var itm in Model.CustCurr.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 31969), Tuple.Create("\'", 31990)
, Tuple.Create(Tuple.Create("", 31977), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 31977), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 32122), Tuple.Create("\'", 32194)
, Tuple.Create(Tuple.Create("", 32130), Tuple.Create("IQLabel100153", 32130), true)
, Tuple.Create(Tuple.Create(" ", 32143), Tuple.Create<System.Object, System.Int32>(!Model.CustDelZone.LabelVisible ? " hide " : ""
, 32144), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 32195), Tuple.Create("\'", 32408)
                         , Tuple.Create(Tuple.Create("", 32204), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDelZone.BackHEXColor) ? "" : "color:" + Model.CustDelZone.BackHEXColor + ";"
, 32204), false)
, Tuple.Create(Tuple.Create("", 32314), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:78px;", 32314), true)
);
WriteLiteral(">Delivery Zone</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:780px;height:21px;width:160px;top:78px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustDelZone\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustDelZone.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control    ");
                                                                                                          Write(!Model.CustDelZone.Visible ? " hide " : "");
WriteLiteral("\'  ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustDelZone/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustDelZone/',$(this));\""));
WriteLiteral("   name=\'PopulateCustDelZone\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CustDelZone.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 33101), Tuple.Create("\'", 33122)
, Tuple.Create(Tuple.Create("", 33109), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 33109), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustDelZone.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCustDelZone]\"");
WriteLiteral(" data-url=\"/DelZone/Load/?DelZId=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />View Record</a></li>\r\n\t\t\t<li><a");
WriteLiteral(" class=\'pjax\'");
WriteLiteral(" href=\"/DelZone/ListOrSearch\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:14px;\'");
WriteLiteral(" />View All Delivery Zones</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 34014), Tuple.Create("\'", 34089)
, Tuple.Create(Tuple.Create("", 34022), Tuple.Create("IQLabel100154", 34022), true)
, Tuple.Create(Tuple.Create(" ", 34035), Tuple.Create<System.Object, System.Int32>(!Model.CustSendStatus.LabelVisible ? " hide " : ""
, 34036), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 34090), Tuple.Create("\'", 34310)
                               , Tuple.Create(Tuple.Create("", 34099), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustSendStatus.BackHEXColor) ? "" : "color:" + Model.CustSendStatus.BackHEXColor + ";"
, 34099), false)
, Tuple.Create(Tuple.Create("", 34215), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:103px;", 34215), true)
);
WriteLiteral(">Send Status</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustSendStatus\'");
WriteAttribute("class", Tuple.Create(" class=\'", 34391), Tuple.Create("\'", 34449)
, Tuple.Create(Tuple.Create("  ", 34399), Tuple.Create<System.Object, System.Int32>(!Model.CustSendStatus.Visible ? " hide " : ""
, 34401), false)
);
WriteLiteral(" ");
                                                                                                                 Write(Model.RecordLocked || !Model.CustSendStatus.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                               Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustSendStatus/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustSendStatus/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:780px;height:16px;width:16px;top:103px;\' name=\'" +
"PopulateCustSendStatus\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.PopulateCustSendStatus ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustSendStatus\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                     Write(!Model.PopulateCustSendStatus ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 35107), Tuple.Create("\'", 35180)
, Tuple.Create(Tuple.Create("", 35115), Tuple.Create("IQLabel100155", 35115), true)
, Tuple.Create(Tuple.Create(" ", 35128), Tuple.Create<System.Object, System.Int32>(!Model.CustSortCode.LabelVisible ? " hide " : ""
, 35129), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 35181), Tuple.Create("\'", 35397)
                 , Tuple.Create(Tuple.Create("", 35190), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustSortCode.BackHEXColor) ? "" : "color:" + Model.CustSortCode.BackHEXColor + ";"
, 35190), false)
, Tuple.Create(Tuple.Create("", 35302), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:128px;", 35302), true)
);
WriteLiteral(">Sort Code</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustSortCode\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustSortCode.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CustSortCode.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustSortCode/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustSortCode/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustSortCode\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CustSortCode.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:780px;height:21px;width:100px;top:128px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 36016), Tuple.Create("\'", 36089)
, Tuple.Create(Tuple.Create("", 36024), Tuple.Create("IQLabel100156", 36024), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 36037), Tuple.Create<System.Object, System.Int32>(!Model.CustOnFTrack.LabelVisible ? " hide " : ""
, 36038), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36090), Tuple.Create("\'", 36306)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 36099), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustOnFTrack.BackHEXColor) ? "" : "color:" + Model.CustOnFTrack.BackHEXColor + ";"
, 36099), false)
, Tuple.Create(Tuple.Create("", 36211), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:153px;", 36211), true)
);
WriteLiteral(">On FreightTrack</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustOnFTrack\'");
WriteAttribute("class", Tuple.Create(" class=\'", 36389), Tuple.Create("\'", 36445)
, Tuple.Create(Tuple.Create("  ", 36397), Tuple.Create<System.Object, System.Int32>(!Model.CustOnFTrack.Visible ? " hide " : ""
, 36399), false)
);
WriteLiteral(" disabled=disabled");
WriteLiteral(" type=\'checkbox\'");
WriteLiteral(" value=\'true\'");
WriteLiteral(" ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustOnFTrack/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustOnFTrack/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:780px;height:16px;width:16px;top:153px;\' name=\'" +
"PopulateCustOnFTrack\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          Write(Model.PopulateCustOnFTrack ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustOnFTrack\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                   Write(!Model.PopulateCustOnFTrack ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 37027), Tuple.Create("\'", 37101)
, Tuple.Create(Tuple.Create("", 37035), Tuple.Create("IQLabel100157", 37035), true)
, Tuple.Create(Tuple.Create(" ", 37048), Tuple.Create<System.Object, System.Int32>(!Model.CustIntrastat.LabelVisible ? " hide " : ""
, 37049), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 37102), Tuple.Create("\'", 37319)
                  , Tuple.Create(Tuple.Create("", 37111), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustIntrastat.BackHEXColor) ? "" : "color:" + Model.CustIntrastat.BackHEXColor + ";"
, 37111), false)
, Tuple.Create(Tuple.Create("", 37225), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:815px;height:21px;width:90" +
"px;top:153px;", 37225), true)
);
WriteLiteral(">Intrastat</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustIntrastat\'");
WriteAttribute("class", Tuple.Create(" class=\'", 37397), Tuple.Create("\'", 37454)
, Tuple.Create(Tuple.Create("  ", 37405), Tuple.Create<System.Object, System.Int32>(!Model.CustIntrastat.Visible ? " hide " : ""
, 37407), false)
);
WriteLiteral(" ");
                                                                                                               Write(Model.RecordLocked || !Model.CustIntrastat.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustIntrastat/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustIntrastat/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:910px;height:16px;width:16px;top:153px;\' name=\'" +
"PopulateCustIntrastat\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.PopulateCustIntrastat ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustIntrastat\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                    Write(!Model.PopulateCustIntrastat ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 38105), Tuple.Create("\'", 38177)
, Tuple.Create(Tuple.Create("", 38113), Tuple.Create("IQLabel100158", 38113), true)
, Tuple.Create(Tuple.Create(" ", 38126), Tuple.Create<System.Object, System.Int32>(!Model.CustWebsite.LabelVisible ? " hide " : ""
, 38127), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 38178), Tuple.Create("\'", 38390)
                , Tuple.Create(Tuple.Create("", 38187), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustWebsite.BackHEXColor) ? "" : "color:" + Model.CustWebsite.BackHEXColor + ";"
, 38187), false)
, Tuple.Create(Tuple.Create("", 38297), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:3px;", 38297), true)
);
WriteLiteral(">Website</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustWebsite\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustWebsite.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                         Write(!Model.CustWebsite.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustWebsite/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustWebsite/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustWebsite\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(Model.CustWebsite.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:780px;height:21px;width:160px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 38998), Tuple.Create("\'", 39072)
, Tuple.Create(Tuple.Create("", 39006), Tuple.Create("IQLabel100159", 39006), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 39019), Tuple.Create<System.Object, System.Int32>(!Model.CustCreatedBy.LabelVisible ? " hide " : ""
, 39020), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 39073), Tuple.Create("\'", 39291)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 39082), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCreatedBy.BackHEXColor) ? "" : "color:" + Model.CustCreatedBy.BackHEXColor + ";"
, 39082), false)
, Tuple.Create(Tuple.Create("", 39196), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:228px;", 39196), true)
);
WriteLiteral(">Created By</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:780px;height:21px;width:160px;top:228px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCreatedBy\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 39510), Tuple.Create("\'", 39581)
, Tuple.Create(Tuple.Create("", 39518), Tuple.Create("form-control", 39518), true)
, Tuple.Create(Tuple.Create("    ", 39530), Tuple.Create<System.Object, System.Int32>(!Model.CustCreatedBy.Visible ? " hide " : ""
, 39534), false)
);
WriteLiteral("  ");
                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCreatedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCreatedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateCustCreatedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CustCreatedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 39933), Tuple.Create("\'", 39954)
, Tuple.Create(Tuple.Create("", 39941), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 39941), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustCreatedBy.ToString() ? "selected=selected" : "");
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
WriteLiteral(" data-target=\"*[name=PopulateCustCreatedBy]\"");
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
WriteAttribute("class", Tuple.Create(" class=\'", 40836), Tuple.Create("\'", 40909)
, Tuple.Create(Tuple.Create("", 40844), Tuple.Create("IQLabel100160", 40844), true)
, Tuple.Create(Tuple.Create(" ", 40857), Tuple.Create<System.Object, System.Int32>(!Model.CustUserName.LabelVisible ? " hide " : ""
, 40858), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 40910), Tuple.Create("\'", 41126)
                             , Tuple.Create(Tuple.Create("", 40919), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustUserName.BackHEXColor) ? "" : "color:" + Model.CustUserName.BackHEXColor + ";"
, 40919), false)
, Tuple.Create(Tuple.Create("", 41031), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:178px;", 41031), true)
);
WriteLiteral(">Portal UserName</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustUserName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustUserName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CustUserName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustUserName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustUserName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustUserName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CustUserName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:780px;height:21px;width:160px;top:178px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 41751), Tuple.Create("\'", 41824)
, Tuple.Create(Tuple.Create("", 41759), Tuple.Create("IQLabel100161", 41759), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 41772), Tuple.Create<System.Object, System.Int32>(!Model.CustPassword.LabelVisible ? " hide " : ""
, 41773), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 41825), Tuple.Create("\'", 42041)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 41834), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustPassword.BackHEXColor) ? "" : "color:" + Model.CustPassword.BackHEXColor + ";"
, 41834), false)
, Tuple.Create(Tuple.Create("", 41946), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:203px;", 41946), true)
);
WriteLiteral(">Portal Password</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustPassword\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustPassword.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CustPassword.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustPassword/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustPassword/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustPassword\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CustPassword.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:780px;height:21px;width:160px;top:203px;\'/><lab" +
"el");
WriteAttribute("class", Tuple.Create(" class=\'", 42666), Tuple.Create("\'", 42743)
, Tuple.Create(Tuple.Create("", 42674), Tuple.Create("IQLabel100171", 42674), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 42687), Tuple.Create<System.Object, System.Int32>(!Model.CustDueDiligence.LabelVisible ? " hide " : ""
, 42688), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 42744), Tuple.Create("\'", 42966)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 42753), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDueDiligence.BackHEXColor) ? "" : "color:" + Model.CustDueDiligence.BackHEXColor + ";"
, 42753), false)
, Tuple.Create(Tuple.Create("", 42873), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:3px;", 42873), true)
);
WriteLiteral(">Due Diligence Received</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustDueDiligence\'");
WriteAttribute("class", Tuple.Create(" class=\'", 43060), Tuple.Create("\'", 43120)
, Tuple.Create(Tuple.Create("  ", 43068), Tuple.Create<System.Object, System.Int32>(!Model.CustDueDiligence.Visible ? " hide " : ""
, 43070), false)
);
WriteLiteral(" ");
                                                                                                                     Write(Model.RecordLocked || !Model.CustDueDiligence.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                     Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustDueDiligence/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustDueDiligence/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:1100px;height:16px;width:16px;top:3px;\' name=\'P" +
"opulateCustDueDiligence\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               Write(Model.PopulateCustDueDiligence ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustDueDiligence\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                       Write(!Model.PopulateCustDueDiligence ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43791), Tuple.Create("\'", 43871)
, Tuple.Create(Tuple.Create("", 43799), Tuple.Create("IQLabel100172", 43799), true)
, Tuple.Create(Tuple.Create(" ", 43812), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScoreSearch.LabelVisible ? " hide " : ""
, 43813), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 43872), Tuple.Create("\'", 44101)
                        , Tuple.Create(Tuple.Create("", 43881), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCredScoreSearch.BackHEXColor) ? "" : "color:" + Model.CustCredScoreSearch.BackHEXColor + ";"
, 43881), false)
, Tuple.Create(Tuple.Create("", 44007), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:28px;", 44007), true)
);
WriteLiteral(">Credit Score Searched</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCredScoreSearch\'");
WriteAttribute("class", Tuple.Create(" class=\'", 44197), Tuple.Create("\'", 44260)
, Tuple.Create(Tuple.Create("  ", 44205), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScoreSearch.Visible ? " hide " : ""
, 44207), false)
);
WriteLiteral(" ");
                                                                                                                           Write(Model.RecordLocked || !Model.CustCredScoreSearch.Enabled ? "disabled=disabled" : "");
WriteLiteral(" type=\'checkbox\' value=\'true\' ");
                                                                                                                                                                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScoreSearch/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCredScoreSearch/',$(this));\""));
WriteLiteral("  style=\'position: absolute; left:1100px;height:16px;width:16px;top:28px;\' name=\'" +
"PopulateCustCredScoreSearch\'   ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateCustCredScoreSearch ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'PopulateCustCredScoreSearch\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                                          Write(!Model.PopulateCustCredScoreSearch ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 44953), Tuple.Create("\'", 45027)
, Tuple.Create(Tuple.Create("", 44961), Tuple.Create("IQLabel100173", 44961), true)
, Tuple.Create(Tuple.Create(" ", 44974), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScore.LabelVisible ? " hide " : ""
, 44975), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 45028), Tuple.Create("\'", 45245)
                  , Tuple.Create(Tuple.Create("", 45037), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCredScore.BackHEXColor) ? "" : "color:" + Model.CustCredScore.BackHEXColor + ";"
, 45037), false)
, Tuple.Create(Tuple.Create("", 45151), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:53px;", 45151), true)
);
WriteLiteral(">Credit Score Number</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCredScore\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustCredScore.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                           Write(!Model.CustCredScore.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                           Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScore/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCredScore/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustCredScore\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CustCredScore.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1100px;height:21px;width:80px;top:53px;\'/><labe" +
"l");
WriteAttribute("class", Tuple.Create(" class=\'", 45880), Tuple.Create("\'", 45955)
, Tuple.Create(Tuple.Create("", 45888), Tuple.Create("IQLabel100175", 45888), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 45901), Tuple.Create<System.Object, System.Int32>(!Model.CustAccContact.LabelVisible ? " hide " : ""
, 45902), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 45956), Tuple.Create("\'", 46176)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 45965), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAccContact.BackHEXColor) ? "" : "color:" + Model.CustAccContact.BackHEXColor + ";"
, 45965), false)
, Tuple.Create(Tuple.Create("", 46081), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:975px;height:21px;width:12" +
"0px;top:103px;", 46081), true)
);
WriteLiteral(">Accounts Contact</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustAccContact\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustAccContact.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                            Write(!Model.CustAccContact.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                             Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustAccContact/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustAccContact/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustAccContact\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                                        Write(Model.CustAccContact.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:1100px;height:21px;width:200px;top:103px;\'/><la" +
"bel");
WriteAttribute("class", Tuple.Create(" class=\'", 46817), Tuple.Create("\'", 46890)
, Tuple.Create(Tuple.Create("", 46825), Tuple.Create("IQLabel100176", 46825), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 46838), Tuple.Create<System.Object, System.Int32>(!Model.CustAccEmail.LabelVisible ? " hide " : ""
, 46839), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 46891), Tuple.Create("\'", 47107)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 46900), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAccEmail.BackHEXColor) ? "" : "color:" + Model.CustAccEmail.BackHEXColor + ";"
, 46900), false)
, Tuple.Create(Tuple.Create("", 47012), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:975px;height:21px;width:12" +
"0px;top:128px;", 47012), true)
);
WriteLiteral(">Accounts Email</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'200\'");
WriteLiteral(" style=\'position: absolute; left:1100px;height:21px;width:200px;top:128px;\'");
WriteLiteral("><input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustAccEmail\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustAccEmail.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control   ");
                                                                                                          Write(!Model.CustAccEmail.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                         Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustAccEmail/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustAccEmail/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustAccEmail\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Model.CustAccEmail.ValueFormatted);
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
WriteLiteral(" data-target=\"*[name=PopulateCustAccEmail]\"");
WriteLiteral(" data-url=\"/EMail/CreateEmail/?to=\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/email.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Send Email</a></li>\r\n\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 48331), Tuple.Create("\'", 48404)
, Tuple.Create(Tuple.Create("", 48339), Tuple.Create("IQLabel100188", 48339), true)
, Tuple.Create(Tuple.Create(" ", 48352), Tuple.Create<System.Object, System.Int32>(!Model.CustFTLNotes.LabelVisible ? " hide " : ""
, 48353), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 48405), Tuple.Create("\'", 48620)
                             , Tuple.Create(Tuple.Create("", 48414), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFTLNotes.BackHEXColor) ? "" : "color:" + Model.CustFTLNotes.BackHEXColor + ";"
, 48414), false)
, Tuple.Create(Tuple.Create("", 48526), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:820px;height:21px;width:120" +
"px;top:353px;", 48526), true)
);
WriteLiteral(">In House Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'400\'");
WriteLiteral(" style=\'position: absolute; left:820px;height:146px;width:400px;top:378px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'In House Notes\'");
WriteLiteral(" data-ScreenInfo=\'Customers_CustFTLNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                                       Write(Model.RecordLocked || !Model.CustFTLNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                       Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustFTLNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustFTLNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.CustFTLNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustFTLNotes\' style=\'height:146px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       Write(Model.PopulateCustFTLNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateCustFTLNotes]\"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Notes.cshtml")]
    public partial class Views_Customer_Notes_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Notes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n");
WriteLiteral("<label");
WriteAttribute("class", Tuple.Create(" class=\'", 64), Tuple.Create("\'", 134)
, Tuple.Create(Tuple.Create("", 72), Tuple.Create("IQLabel101211", 72), true)
, Tuple.Create(Tuple.Create(" ", 85), Tuple.Create<System.Object, System.Int32>(!Model.CustRates.LabelVisible ? " hide " : ""
, 86), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 135), Tuple.Create("\'", 341)
        , Tuple.Create(Tuple.Create("", 144), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustRates.BackHEXColor) ? "" : "color:" + Model.CustRates.BackHEXColor + ";"
, 144), false)
, Tuple.Create(Tuple.Create("", 250), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:5px;height:21px;width:120px" +
";top:28px;", 250), true)
);
WriteLiteral(">Rates</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'475\'");
WriteLiteral(" style=\'position: absolute; left:5px;height:396px;width:475px;top:53px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'Rates\'");
WriteLiteral(" data-ScreenInfo=\'Notes_CustRates\'");
WriteLiteral(" ");
                                                                                                                                                                                                   Write(Model.RecordLocked || !Model.CustRates.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustRates/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustRates/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         Write(!Model.CustRates.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustRates\' style=\'height:396px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    Write(Model.PopulateCustRates);
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
WriteLiteral(" data-target=\"*[name=PopulateCustRates]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 1508), Tuple.Create("\'", 1577)
, Tuple.Create(Tuple.Create("", 1516), Tuple.Create("IQLabel101212", 1516), true)
, Tuple.Create(Tuple.Create(" ", 1529), Tuple.Create<System.Object, System.Int32>(!Model.CustName.LabelVisible ? " hide " : ""
, 1530), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1578), Tuple.Create("\'", 1782)
                              , Tuple.Create(Tuple.Create("", 1587), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustName.BackHEXColor) ? "" : "color:" + Model.CustName.BackHEXColor + ";"
, 1587), false)
, Tuple.Create(Tuple.Create("", 1691), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 1691), true)
);
WriteLiteral(">Company Name</label>\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Notes_CustName\'");
WriteLiteral(" \r\n\t\t");
    Write(Model.RecordLocked || !Model.CustName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" class=\'form-control mandatory  ");
                                                                                                               Write(!Model.CustName.Visible ? " hide " : "");
WriteLiteral("\' ");
                                                                                                                                                          Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustName/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustName/',$(this));\""));
WriteLiteral(" type=\'text\' name=\'PopulateCustName\' value=\'");
                                                                                                                                                                                                                                                                                                                                                                                                                                   Write(Model.CustName.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:130px;height:21px;width:200px;top:3px;\'/><label" +
"");
WriteAttribute("class", Tuple.Create(" class=\'", 2379), Tuple.Create("\'", 2452)
, Tuple.Create(Tuple.Create("", 2387), Tuple.Create("IQLabel101231", 2387), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 2400), Tuple.Create<System.Object, System.Int32>(!Model.CustGenNotes.LabelVisible ? " hide " : ""
, 2401), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2453), Tuple.Create("\'", 2666)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 2462), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGenNotes.BackHEXColor) ? "" : "color:" + Model.CustGenNotes.BackHEXColor + ";"
, 2462), false)
, Tuple.Create(Tuple.Create("", 2574), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:500px;height:21px;width:120" +
"px;top:3px;", 2574), true)
);
WriteLiteral(">General Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'325\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:121px;width:325px;top:28px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'General Notes\'");
WriteLiteral(" data-ScreenInfo=\'Notes_CustGenNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                                  Write(Model.RecordLocked || !Model.CustGenNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                  Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustGenNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustGenNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 Write(!Model.CustGenNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustGenNotes\' style=\'height:121px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateCustGenNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateCustGenNotes]\"");
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/fullscreen.png\"");
WriteLiteral(" style=\'max-height:14px;float:left;\'");
WriteLiteral(" />Full Screen Editor</a></li>\r\n\t\t\t</div></div><label");
WriteAttribute("class", Tuple.Create(" class=\'", 3875), Tuple.Create("\'", 3948)
, Tuple.Create(Tuple.Create("", 3883), Tuple.Create("IQLabel101234", 3883), true)
, Tuple.Create(Tuple.Create(" ", 3896), Tuple.Create<System.Object, System.Int32>(!Model.CustFTLNotes.LabelVisible ? " hide " : ""
, 3897), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3949), Tuple.Create("\'", 4164)
                                  , Tuple.Create(Tuple.Create("", 3958), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFTLNotes.BackHEXColor) ? "" : "color:" + Model.CustFTLNotes.BackHEXColor + ";"
, 3958), false)
, Tuple.Create(Tuple.Create("", 4070), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:500px;height:21px;width:120" +
"px;top:153px;", 4070), true)
);
WriteLiteral(">In House Notes</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'320\'");
WriteLiteral(" style=\'position: absolute; left:500px;height:96px;width:320px;top:178px;\'");
WriteLiteral(">\t\t<textarea");
WriteLiteral(" data-Label=\'In House Notes\'");
WriteLiteral(" data-ScreenInfo=\'Notes_CustFTLNotes\'");
WriteLiteral(" ");
                                                                                                                                                                                                                   Write(Model.RecordLocked || !Model.CustFTLNotes.Enabled ? "disabled=disabled" : "");
WriteLiteral("  ");
                                                                                                                                                                                                                                                                                                   Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustFTLNotes/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustFTLNotes/',$(this));\""));
WriteLiteral("  class=\'form-control    ");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(!Model.CustFTLNotes.Visible ? " hide " : "");
WriteLiteral(" \' name=\'PopulateCustFTLNotes\' style=\'height:96px\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Model.PopulateCustFTLNotes);
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
WriteLiteral(" data-target=\"*[name=PopulateCustFTLNotes]\"");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Edit_1.cshtml")]
    public partial class Views_Customer_Edit_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Edit_1_cshtml()
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
WriteLiteral(" href=\"/Customer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Customers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/Customer/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Custom" +
"er/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Customer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Customer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Customer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2020), Tuple.Create("\"", 2122)
, Tuple.Create(Tuple.Create("", 2027), Tuple.Create("/Customer/ViewHistory/?RecId=", 2027), true)
, Tuple.Create(Tuple.Create("", 2056), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2056), false)
, Tuple.Create(Tuple.Create("", 2071), Tuple.Create("&dt=", 2071), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2075), false)
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
WriteLiteral(">\r\n\t\t\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'active\'");
WriteLiteral("><a");
WriteLiteral(" href=\"#Customers\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customers</a></li><li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" ><a");
WriteLiteral(" href=\"#Notes\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Notes</a></li>\t\t</ul>\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Customers\"");
WriteLiteral(" style=\'position:relative;height:554px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Customers.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane \"");
WriteLiteral(" id=\"Notes\"");
WriteLiteral(" style=\'position:relative;height:479px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Notes.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Customer Contacts").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3331), Tuple.Create("\'", 3433)
, Tuple.Create(Tuple.Create("", 3339), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Contact" ? "active" :  "") : "" )
, 3339), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Contact\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customer Contacts</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3641), Tuple.Create("\'", 3744)
, Tuple.Create(Tuple.Create("", 3649), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3649), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 3948), Tuple.Create("\'", 4045)
, Tuple.Create(Tuple.Create("", 3956), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3956), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 4227), Tuple.Create("\'", 4325)
, Tuple.Create(Tuple.Create("", 4235), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 4235), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4500), Tuple.Create("\'", 4598)
, Tuple.Create(Tuple.Create("", 4508), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Job" ? "active" :  "") : "" )
, 4508), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Job\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Jobs</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4771), Tuple.Create("\'", 4872)
, Tuple.Create(Tuple.Create("", 4779), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "") : "" )
, 4779), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Orders\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 5062), Tuple.Create("\'", 5164)
, Tuple.Create(Tuple.Create("", 5070), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "ShipDoc" ? "active" :  "") : "" )
, 5070), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#ShipDoc\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Shipping Documents</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 5358), Tuple.Create("\'", 5460)
, Tuple.Create(Tuple.Create("", 5366), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "UKOrder" ? "active" :  "") : "" )
, 5366), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#UKOrder\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">UK Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 5661), Tuple.Create("\"", 5676)
, Tuple.Create(Tuple.Create("", 5668), Tuple.Create("#", 5668), true)
, Tuple.Create(Tuple.Create("", 5669), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5669), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Customer Contacts").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Contact" ? "data-loadTarget='#27caf6e5db944f62b813e10eb4a6e50d' data-dynamicContent='/Contact/ListFromQuery?Limit=50&Ord=ContFN&Clause=ContCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                   Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Contact" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Contact\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/Contact/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customer Contacts</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Contact") {
                      Html.RenderPartial("~/Views/Contact_List_1.cshtml", Model.Contacts);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"27caf6e5db944f62b813e10eb4a6e50d\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#8b6e6b094ef44e43a5e7ea72d3f2727d' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7369), Tuple.Create("\'", 7416)
, Tuple.Create(Tuple.Create("", 7377), Tuple.Create("/CertShip/Add?CSCust=", 7377), true)
       , Tuple.Create(Tuple.Create("", 7398), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 7398), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_1.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"8b6e6b094ef44e43a5e7ea72d3f2727d\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#a839accfdbfb4a959a60d9a9197778f8' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNTo=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                   Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8327), Tuple.Create("\'", 8366)
, Tuple.Create(Tuple.Create("", 8335), Tuple.Create("/CN/Add?CNTo=", 8335), true)
, Tuple.Create(Tuple.Create("", 8348), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 8348), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_1.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"a839accfdbfb4a959a60d9a9197778f8\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#9a65040313b7490b8cb57cbcc9988056' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvTo=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                       Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 9249), Tuple.Create("\'", 9290)
, Tuple.Create(Tuple.Create("", 9257), Tuple.Create("/Inv/Add?InvTo=", 9257), true)
 , Tuple.Create(Tuple.Create("", 9272), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 9272), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_1.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"9a65040313b7490b8cb57cbcc9988056\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Job" ? "data-loadTarget='#22f6ceb9ae2a438f9e1d40eb222571e9' data-dynamicContent='/Job/ListFromQuery?Limit=50&Ord=JobNo&Clause=JobTransp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Job" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Job\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 10172), Tuple.Create("\'", 10217)
, Tuple.Create(Tuple.Create("", 10180), Tuple.Create("/Job/Add?JobTransp=", 10180), true)
    , Tuple.Create(Tuple.Create("", 10199), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 10199), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Jobs</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Job") {
                      Html.RenderPartial("~/Views/Job_List_1.cshtml", Model.Jobs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"22f6ceb9ae2a438f9e1d40eb222571e9\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#5de4ed62d8504e198986b26eaa60ed43' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Orders\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 11107), Tuple.Create("\'", 11153)
, Tuple.Create(Tuple.Create("", 11115), Tuple.Create("/Orders/Add?OrdSupp=", 11115), true)
     , Tuple.Create(Tuple.Create("", 11135), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 11135), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Orders") {
                      Html.RenderPartial("~/Views/Orders_List_1.cshtml", Model.Orderss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"5de4ed62d8504e198986b26eaa60ed43\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "ShipDoc" ? "data-loadTarget='#7c17e3c285744a00aa4053838edaecae' data-dynamicContent='/ShipDoc/ListFromQuery?Limit=50&Ord=SDId&Clause=SDSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "ShipDoc" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"ShipDoc\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 12068), Tuple.Create("\'", 12114)
, Tuple.Create(Tuple.Create("", 12076), Tuple.Create("/ShipDoc/Add?SDSupp=", 12076), true)
     , Tuple.Create(Tuple.Create("", 12096), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 12096), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Shipping Documents</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "ShipDoc") {
                      Html.RenderPartial("~/Views/ShipDoc_List_1.cshtml", Model.ShipDocs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"7c17e3c285744a00aa4053838edaecae\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "UKOrder" ? "data-loadTarget='#dcdc08b9166741e5bc6a739459ed0668' data-dynamicContent='/UKOrder/ListFromQuery?Limit=50&Ord=UKOId&Clause=UKOCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "UKOrder" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"UKOrder\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 13037), Tuple.Create("\'", 13084)
, Tuple.Create(Tuple.Create("", 13045), Tuple.Create("/UKOrder/Add?UKOCust=", 13045), true)
      , Tuple.Create(Tuple.Create("", 13066), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 13066), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add UK Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "UKOrder") {
                      Html.RenderPartial("~/Views/UKOrder_List_1.cshtml", Model.UKOrders);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"dcdc08b9166741e5bc6a739459ed0668\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 13533), Tuple.Create("\"", 13545)
, Tuple.Create(Tuple.Create("", 13538), Tuple.Create<System.Object, System.Int32>(itm.Id
, 13538), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Add_1.cshtml")]
    public partial class Views_Customer_Add_1_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Add_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Customer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n</div>\r\n<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'active\'");
WriteLiteral("><a");
WriteLiteral(" href=\"#Customers\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customers</a></li><li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" ><a");
WriteLiteral(" href=\"#Notes\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Notes</a></li>\t\t</ul>\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Customers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Customers.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane \"");
WriteLiteral(" id=\"Notes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Notes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_List_1.cshtml")]
    public partial class Views_Customer_List_1_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Customer>>
    {
        public Views_Customer_List_1_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/Customer/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Company Name</th><th>Postcode</th><th>Country</th><th>Company ID" +
"</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 911), Tuple.Create("\"", 953)
, Tuple.Create(Tuple.Create("", 918), Tuple.Create("/Customer/Load/?RecId=", 918), true)
                 , Tuple.Create(Tuple.Create("", 940), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 940), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1204), Tuple.Create("\"", 1292)
, Tuple.Create(Tuple.Create("", 1215), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustName/?RecId=", 1215), true)
                                                                      , Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1268), false)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("\',$(this));", 1281), true)
);
WriteLiteral(" data-bound-name=\'CustName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1351), Tuple.Create("\'", 1392)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1359), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustName.HTMLValue)
, 1359), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustPC.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1577), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustPC/?RecId=", 1588), true)
                                                                    , Tuple.Create(Tuple.Create("", 1639), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1639), false)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create("\',$(this));", 1652), true)
);
WriteLiteral(" data-bound-name=\'CustPC\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1720), Tuple.Create("\'", 1759)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1728), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustPC.HTMLValue)
, 1728), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustCtry.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1944), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1955), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustCtry/?RecId=", 1955), true)
                                                                    , Tuple.Create(Tuple.Create("", 2008), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2008), false)
, Tuple.Create(Tuple.Create("", 2021), Tuple.Create("\',$(this));", 2021), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CustCtry\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.CustCtry.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CustId.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Edit_2.cshtml")]
    public partial class Views_Customer_Edit_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Edit_2_cshtml()
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
WriteLiteral(" href=\"/Customer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Customers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/Customer/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Custom" +
"er/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Customer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Customer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Customer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2020), Tuple.Create("\"", 2122)
, Tuple.Create(Tuple.Create("", 2027), Tuple.Create("/Customer/ViewHistory/?RecId=", 2027), true)
, Tuple.Create(Tuple.Create("", 2056), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2056), false)
, Tuple.Create(Tuple.Create("", 2071), Tuple.Create("&dt=", 2071), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2075), false)
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
WriteLiteral(">\r\n\t\t\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'active\'");
WriteLiteral("><a");
WriteLiteral(" href=\"#Customers\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customers</a></li><li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" ><a");
WriteLiteral(" href=\"#Notes\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Notes</a></li>\t\t</ul>\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Customers\"");
WriteLiteral(" style=\'position:relative;height:554px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Customers.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane \"");
WriteLiteral(" id=\"Notes\"");
WriteLiteral(" style=\'position:relative;height:479px\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Notes.cshtml", Model);
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
                         if(Model.CachedSubForms.Where(f=> f.Title == "Customer Contacts").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3331), Tuple.Create("\'", 3433)
, Tuple.Create(Tuple.Create("", 3339), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Contact" ? "active" :  "") : "" )
, 3339), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Contact\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customer Contacts</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 3641), Tuple.Create("\'", 3744)
, Tuple.Create(Tuple.Create("", 3649), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "") : "" )
, 3649), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 3948), Tuple.Create("\'", 4045)
, Tuple.Create(Tuple.Create("", 3956), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "") : "" )
, 3956), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 4227), Tuple.Create("\'", 4325)
, Tuple.Create(Tuple.Create("", 4235), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "") : "" )
, 4235), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Inv\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Invoices</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4500), Tuple.Create("\'", 4598)
, Tuple.Create(Tuple.Create("", 4508), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Job" ? "active" :  "") : "" )
, 4508), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Job\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Jobs</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 4771), Tuple.Create("\'", 4872)
, Tuple.Create(Tuple.Create("", 4779), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "") : "" )
, 4779), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#Orders\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 5062), Tuple.Create("\'", 5164)
, Tuple.Create(Tuple.Create("", 5070), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "ShipDoc" ? "active" :  "") : "" )
, 5070), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#ShipDoc\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Shipping Documents</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t\t\t");
                                     if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteAttribute("class", Tuple.Create(" class=\'", 5358), Tuple.Create("\'", 5460)
, Tuple.Create(Tuple.Create("", 5366), Tuple.Create<System.Object, System.Int32>((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "UKOrder" ? "active" :  "") : "" )
, 5366), false)
);
WriteLiteral("><a");
WriteLiteral(" href=\"#UKOrder\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">UK Orders</a></li>\r\n");
					}
WriteLiteral("\t\t\t\t\t\t\t");
                             foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t");
WriteLiteral("<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'\'");
WriteLiteral("><a");
WriteAttribute("href", Tuple.Create(" href=\"", 5661), Tuple.Create("\"", 5676)
, Tuple.Create(Tuple.Create("", 5668), Tuple.Create("#", 5668), true)
, Tuple.Create(Tuple.Create("", 5669), Tuple.Create<System.Object, System.Int32>(itm.Id
, 5669), false)
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
                     if(Model.CachedSubForms.Where(f=> f.Title == "Customer Contacts").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Contact" ? "data-loadTarget='#352def3a4eb949bb9bd1bd95ab8d752d' data-dynamicContent='/Contact/ListFromQuery?Limit=50&Ord=ContFN&Clause=ContCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                   Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Contact" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Contact\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" onclick=\'IQRealSubmit(\"/Contact/Add\");\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customer Contacts</button>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Contact") {
                      Html.RenderPartial("~/Views/Contact_List_2.cshtml", Model.Contacts);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"352def3a4eb949bb9bd1bd95ab8d752d\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#8950a56f6bb4496b864ed7d40b02d070' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CertShip" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CertShip\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 7369), Tuple.Create("\'", 7416)
, Tuple.Create(Tuple.Create("", 7377), Tuple.Create("/CertShip/Add?CSCust=", 7377), true)
       , Tuple.Create(Tuple.Create("", 7398), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 7398), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Certificates of Shipment</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CertShip") {
                      Html.RenderPartial("~/Views/CertShip_List_2.cshtml", Model.CertShips);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"8950a56f6bb4496b864ed7d40b02d070\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#2d0c94f46c3e4512b5fd1f08fa83ca65' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNTo=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                   Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "CN" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"CN\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 8327), Tuple.Create("\'", 8366)
, Tuple.Create(Tuple.Create("", 8335), Tuple.Create("/CN/Add?CNTo=", 8335), true)
, Tuple.Create(Tuple.Create("", 8348), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 8348), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Credit Notes</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "CN") {
                      Html.RenderPartial("~/Views/CN_List_2.cshtml", Model.CNs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"2d0c94f46c3e4512b5fd1f08fa83ca65\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#063c18a8ab3747ddac1e7e89b02d7867' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvTo=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                       Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Inv" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Inv\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 9249), Tuple.Create("\'", 9290)
, Tuple.Create(Tuple.Create("", 9257), Tuple.Create("/Inv/Add?InvTo=", 9257), true)
 , Tuple.Create(Tuple.Create("", 9272), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 9272), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Invoices</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Inv") {
                      Html.RenderPartial("~/Views/Inv_List_2.cshtml", Model.Invs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"063c18a8ab3747ddac1e7e89b02d7867\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Job" ? "data-loadTarget='#73aaaf65066644f9910387efc0d7bb80' data-dynamicContent='/Job/ListFromQuery?Limit=50&Ord=JobNo&Clause=JobTransp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                           Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Job" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Job\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 10172), Tuple.Create("\'", 10217)
, Tuple.Create(Tuple.Create("", 10180), Tuple.Create("/Job/Add?JobTransp=", 10180), true)
    , Tuple.Create(Tuple.Create("", 10199), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 10199), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Jobs</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Job") {
                      Html.RenderPartial("~/Views/Job_List_2.cshtml", Model.Jobs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"73aaaf65066644f9910387efc0d7bb80\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#d0d06be2f3dd4b548eb351080e3e7b0a' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "Orders" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"Orders\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 11107), Tuple.Create("\'", 11153)
, Tuple.Create(Tuple.Create("", 11115), Tuple.Create("/Orders/Add?OrdSupp=", 11115), true)
     , Tuple.Create(Tuple.Create("", 11135), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 11135), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "Orders") {
                      Html.RenderPartial("~/Views/Orders_List_2.cshtml", Model.Orderss);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"d0d06be2f3dd4b548eb351080e3e7b0a\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "ShipDoc" ? "data-loadTarget='#2c3759ca51f044ac82637b5c07e2d578' data-dynamicContent='/ShipDoc/ListFromQuery?Limit=50&Ord=SDId&Clause=SDSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                               Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "ShipDoc" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"ShipDoc\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 12068), Tuple.Create("\'", 12114)
, Tuple.Create(Tuple.Create("", 12076), Tuple.Create("/ShipDoc/Add?SDSupp=", 12076), true)
     , Tuple.Create(Tuple.Create("", 12096), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 12096), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add Shipping Documents</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "ShipDoc") {
                      Html.RenderPartial("~/Views/ShipDoc_List_2.cshtml", Model.ShipDocs);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"2c3759ca51f044ac82637b5c07e2d578\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "UKOrder" ? "data-loadTarget='#95cdcb04571e4f8699f9d4748105536a' data-dynamicContent='/UKOrder/ListFromQuery?Limit=50&Ord=UKOId&Clause=UKOCust=" + Model.CustIdValue + "&Partial=true'" : ""));
WriteLiteral(" class=\"tab-pane ");
                                                                                                                                                                                                                                                                                 Write((Request["ActiveTab"] != null ? (Request["ActiveTab"] == "UKOrder" ? "active" :  "DynamicTab ") : "DynamicTab " ));
WriteLiteral("\" id=\"UKOrder\">\r\n\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t\t\t\t\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t<a");
WriteAttribute("href", Tuple.Create("  href=\'", 13037), Tuple.Create("\'", 13084)
, Tuple.Create(Tuple.Create("", 13045), Tuple.Create("/UKOrder/Add?UKOCust=", 13045), true)
      , Tuple.Create(Tuple.Create("", 13066), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 13066), false)
);
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" >Add UK Orders</a>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
                     if(Request["ActiveTab"] == "UKOrder") {
                      Html.RenderPartial("~/Views/UKOrder_List_2.cshtml", Model.UKOrders);
					} else {
WriteLiteral("\t\t\t\t\t<div");
WriteLiteral(" id=\"95cdcb04571e4f8699f9d4748105536a\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t");
                         foreach(var itm in Model.CachedSubForms.Where(f=> f.CustomScreen)) {
WriteLiteral("\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane\"");
WriteAttribute("id", Tuple.Create(" id=\"", 13533), Tuple.Create("\"", 13545)
, Tuple.Create(Tuple.Create("", 13538), Tuple.Create<System.Object, System.Int32>(itm.Id
, 13538), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Add_2.cshtml")]
    public partial class Views_Customer_Add_2_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Add_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Customer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n</div>\r\n<div");
WriteLiteral(" class=\"DatasetScreen\"");
WriteLiteral(">\r\n\t\t\t<ul");
WriteLiteral(" class=\"nav nav-tabs\"");
WriteLiteral(" role=\"tablist\"");
WriteLiteral(">\r\n\t\t\t<li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" class=\'active\'");
WriteLiteral("><a");
WriteLiteral(" href=\"#Customers\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Customers</a></li><li");
WriteLiteral(" role=\"presentation\"");
WriteLiteral(" ><a");
WriteLiteral(" href=\"#Notes\"");
WriteLiteral("  role=\"tab\"");
WriteLiteral(" data-toggle=\"tab\"");
WriteLiteral(">Notes</a></li>\t\t</ul>\r\n\t\t<div");
WriteLiteral(" class=\"tab-content\"");
WriteLiteral(">\r\n\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane active\"");
WriteLiteral(" id=\"Customers\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Customers.cshtml", Model);
WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" class=\"tab-pane \"");
WriteLiteral(" id=\"Notes\"");
WriteLiteral(" style=\'position:relative\'");
WriteLiteral(">\r\n");
                      Html.RenderPartial("~/Views/Customer_Notes.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_List_2.cshtml")]
    public partial class Views_Customer_List_2_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Customer>>
    {
        public Views_Customer_List_2_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/Customer/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Company Name</th><th>Postcode</th><th>Country</th><th>Company ID" +
"</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 911), Tuple.Create("\"", 953)
, Tuple.Create(Tuple.Create("", 918), Tuple.Create("/Customer/Load/?RecId=", 918), true)
                 , Tuple.Create(Tuple.Create("", 940), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 940), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1204), Tuple.Create("\"", 1292)
, Tuple.Create(Tuple.Create("", 1215), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustName/?RecId=", 1215), true)
                                                                      , Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1268), false)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("\',$(this));", 1281), true)
);
WriteLiteral(" data-bound-name=\'CustName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1351), Tuple.Create("\'", 1392)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1359), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustName.HTMLValue)
, 1359), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustPC.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1577), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustPC/?RecId=", 1588), true)
                                                                    , Tuple.Create(Tuple.Create("", 1639), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1639), false)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create("\',$(this));", 1652), true)
);
WriteLiteral(" data-bound-name=\'CustPC\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1720), Tuple.Create("\'", 1759)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1728), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustPC.HTMLValue)
, 1728), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustCtry.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1944), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1955), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustCtry/?RecId=", 1955), true)
                                                                    , Tuple.Create(Tuple.Create("", 2008), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2008), false)
, Tuple.Create(Tuple.Create("", 2021), Tuple.Create("\',$(this));", 2021), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CustCtry\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.CustCtry.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CustId.DisplayValue);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Edit_3.cshtml")]
    public partial class Views_Customer_Edit_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Edit_3_cshtml()
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
WriteLiteral(" href=\"/Customer/Add\"");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(">Add Customers</a>\r\n\t\t\t\r\n");
             if(!Model.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteAttribute("onclick", Tuple.Create(" onclick=\'", 408), Tuple.Create("\'", 470)
, Tuple.Create(Tuple.Create("", 418), Tuple.Create("IQJSCall(\"/Customer/Delete/?RecId=", 418), true)
         , Tuple.Create(Tuple.Create("", 452), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 452), false)
, Tuple.Create(Tuple.Create("", 467), Tuple.Create("\");", 467), true)
);
WriteLiteral(" class=\"btn btn-danger btn-animated\"");
WriteLiteral(" value=\"Delete\"");
WriteLiteral(" />\r\n");
			}
WriteLiteral("\t\t\t\r\n\t\t\r\n\r\n\t\t\r\n\t\r\n\t\t\t\t\t\t\t<!--<button type=\'button\' onclick=\"IQRealSubmit(\'/Custom" +
"er/ViewHistory/?RecId=");
                                                                                                     Write(Model.RecordID.Value);
WriteLiteral("\')\" class=\'btn btn-warning btn-animated\'><img src=\'/IQ6/history.png\' style=\'max-h" +
"eight:18px;margin-right:5px;\' />View History</button>-->\r\n\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t<" +
"div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
                     foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
				foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t\t");
                     Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
				}
			}
WriteLiteral("\t\t\t");
             foreach (var itm in DS.GlobalManager.OnDrawSingleToolbar)
            {
                foreach (var elem in itm.Invoke("Customer", Model.RecordID.Value))
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
WriteAttribute("value", Tuple.Create(" value=\'", 1367), Tuple.Create("\'", 1389)
, Tuple.Create(Tuple.Create("", 1375), Tuple.Create<System.Object, System.Int32>(Model.DataUrl
, 1375), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentTitle\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1435), Tuple.Create("\'", 1459)
, Tuple.Create(Tuple.Create("", 1443), Tuple.Create<System.Object, System.Int32>(Model.DataTitle
, 1443), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentDS\'");
WriteLiteral(" value=\"Customer\"");
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1561), Tuple.Create("\"", 1587)
, Tuple.Create(Tuple.Create("", 1569), Tuple.Create<System.Object, System.Int32>(Model.CustIdValue
, 1569), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'CurrentRecId\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1633), Tuple.Create("\"", 1656)
, Tuple.Create(Tuple.Create("", 1641), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1641), false)
);
WriteLiteral(" />\r\n<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'RecordID\'");
WriteAttribute("value", Tuple.Create(" value=\"", 1698), Tuple.Create("\"", 1721)
, Tuple.Create(Tuple.Create("", 1706), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 1706), false)
);
WriteLiteral(" />\r\n\r\n");
 if(ViewBag.HistoryView == true) {
WriteLiteral("\t");
     Write(Html.Raw("<div class='row'><div class='col-sm-2'><label>Change Dates</label><br /><a href='/Customer/Load/?RecId=" + Model.RecordID + "'>Current Record</a><table>"));
WriteLiteral("\r\n");
     foreach(AuditDates dt in (List<AuditDates>)ViewBag.HistoryItems){
WriteLiteral("\t\t<tr><td><a");
WriteAttribute("href", Tuple.Create(" href=\"", 2020), Tuple.Create("\"", 2122)
, Tuple.Create(Tuple.Create("", 2027), Tuple.Create("/Customer/ViewHistory/?RecId=", 2027), true)
, Tuple.Create(Tuple.Create("", 2056), Tuple.Create<System.Object, System.Int32>(Model.RecordID
, 2056), false)
, Tuple.Create(Tuple.Create("", 2071), Tuple.Create("&dt=", 2071), true)
, Tuple.Create(Tuple.Create("", 2075), Tuple.Create<System.Object, System.Int32>(dt.UpdateDate.ToString("dd-MMM-yyyy hh:mm:ss")
, 2075), false)
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
WriteAttribute("href", Tuple.Create(" href=\"", 2714), Tuple.Create("\"", 2729)
, Tuple.Create(Tuple.Create("", 2721), Tuple.Create("#", 2721), true)
, Tuple.Create(Tuple.Create("", 2722), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2722), false)
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
WriteAttribute("id", Tuple.Create(" id=\"", 2945), Tuple.Create("\"", 2957)
, Tuple.Create(Tuple.Create("", 2950), Tuple.Create<System.Object, System.Int32>(itm.Id
, 2950), false)
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_Add_3.cshtml")]
    public partial class Views_Customer_Add_3_cshtml : System.Web.Mvc.WebViewPage<FTL.Customer>
    {
        public Views_Customer_Add_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Add Customers";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Add Customers\"");
WriteLiteral("></noscript>\r\n<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'IQSaveRecord(\"/Customer/AddRecord\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Save Record\"");
WriteLiteral(" />\r\n\t</div>\r\n  \t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in DS.GetManager<Customer>().OnDrawSingleToolbar) {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/Views/Customer_List_3.cshtml")]
    public partial class Views_Customer_List_3_cshtml : System.Web.Mvc.WebViewPage<System.Collections.Generic.List<FTL.Customer>>
    {
        public Views_Customer_List_3_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customers List";
WriteLiteral("\r\n<noscript");
WriteLiteral(" data-title=\"Customers List\"");
WriteLiteral("></noscript> \r\n\r\n");
 if(ViewBag.ListView == true) {
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/Add\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral(">Add Customers</a>\r\n");
WriteLiteral("\t<a");
WriteLiteral(" href=\'/Customer/ExportAll\'");
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
WriteAttribute("href", Tuple.Create(" href=\"", 504), Tuple.Create("\"", 575)
, Tuple.Create(Tuple.Create("", 511), Tuple.Create("/Customer/ListFromQuery/?Clause=", 511), true)
                                                                    , Tuple.Create(Tuple.Create("", 543), Tuple.Create<System.Object, System.Int32>(ViewBag.Clause
, 543), false)
, Tuple.Create(Tuple.Create("", 558), Tuple.Create("&Ord=", 558), true)
                                                                                        , Tuple.Create(Tuple.Create("", 563), Tuple.Create<System.Object, System.Int32>(ViewBag.Ord
, 563), false)
);
WriteLiteral(">View all ");
                                                                                                                                                                                         Write(ViewBag.ResultCount);
WriteLiteral("</a></div>\r\n");
}
WriteLiteral("\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t\t<th>Company Name</th><th>Postcode</th><th>Country</th><th>Company ID" +
"</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral("  class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 911), Tuple.Create("\"", 953)
, Tuple.Create(Tuple.Create("", 918), Tuple.Create("/Customer/Load/?RecId=", 918), true)
                 , Tuple.Create(Tuple.Create("", 940), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 940), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n");
                                 if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustName.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:38%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1204), Tuple.Create("\"", 1292)
, Tuple.Create(Tuple.Create("", 1215), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustName/?RecId=", 1215), true)
                                                                      , Tuple.Create(Tuple.Create("", 1268), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1268), false)
, Tuple.Create(Tuple.Create("", 1281), Tuple.Create("\',$(this));", 1281), true)
);
WriteLiteral(" data-bound-name=\'CustName\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1351), Tuple.Create("\'", 1392)
                                                                                                                                                                 , Tuple.Create(Tuple.Create("", 1359), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustName.HTMLValue)
, 1359), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustPC.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:24%\'");
WriteLiteral("><input");
WriteLiteral("  class=\'form-control\'");
WriteLiteral(" type=\'text\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1577), Tuple.Create("\"", 1663)
, Tuple.Create(Tuple.Create("", 1588), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustPC/?RecId=", 1588), true)
                                                                    , Tuple.Create(Tuple.Create("", 1639), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1639), false)
, Tuple.Create(Tuple.Create("", 1652), Tuple.Create("\',$(this));", 1652), true)
);
WriteLiteral(" data-bound-name=\'CustPC\'");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("value", Tuple.Create(" value=\'", 1720), Tuple.Create("\'", 1759)
                                                                                                                                                             , Tuple.Create(Tuple.Create("", 1728), Tuple.Create<System.Object, System.Int32>(Html.Raw(itm.CustPC.HTMLValue)
, 1728), false)
);
WriteLiteral(" /></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t");
                         if(itm.RecordLocked) {
WriteLiteral("\t\t\t\t\t\t\t<td>");
                           Write(itm.CustCtry.DisplayValue);
WriteLiteral("</td>\r\n");
						} else {
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'width:19%\'");
WriteLiteral("><select");
WriteLiteral(" style=\'height:21px;width:100%\'");
WriteAttribute("onchange", Tuple.Create(" onchange=\"", 1944), Tuple.Create("\"", 2032)
, Tuple.Create(Tuple.Create("", 1955), Tuple.Create("javascript:IQAutoSave(\'/Customer/SaveCustCtry/?RecId=", 1955), true)
                                                                    , Tuple.Create(Tuple.Create("", 2008), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 2008), false)
, Tuple.Create(Tuple.Create("", 2021), Tuple.Create("\',$(this));", 2021), true)
);
WriteLiteral("class=\'form-control\'");
WriteLiteral(" data-bound-name=\'CustCtry\'");
WriteLiteral("  >");
                                                                                                                                                                                                                          Write(Html.Raw(itm.CustCtry.HTMLValue));
WriteLiteral("</select></td>\r\n");
						}
WriteLiteral("\t\t\t\t\t\t<td");
WriteLiteral(" style=\'font-size:11px;\'");
WriteLiteral(">");
                                               Write(itm.CustId.DisplayValue);
WriteLiteral("</td>\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}

}
