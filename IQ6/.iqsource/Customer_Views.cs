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
WriteLiteral(">Rates</label>\r\n\t\t\t\t<div");
WriteLiteral(" id=\"RichEditor-PopulateCustRates\"");
WriteLiteral(" ");
                                                   Write(Model.RecordLocked ? "data-disabled='true'" :"");
WriteLiteral("  data-target=\"textarea[name=PopulateCustRates]\" class=\'RichEditor\' style=\'positi" +
"on: absolute; left:5px;height:146px;width:400px;top:393px;\'>");
                                                                                                                                                                                                                                                 Write(Html.Raw(Model.PopulateCustRates));
WriteLiteral("</div>\r\n\t\t<textarea");
WriteLiteral("  data-ScreenInfo=\'Customers_CustRates\'");
                                                    Write(Model.RecordLocked || !Model.CustRates.Enabled ? "disabled=disabled" : "");
WriteLiteral(" ");
                                                                                                                                Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustRates/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustRates/',$(this));\""));
WriteLiteral("  class=\' ");
                                                                                                                                                                                                                                                                                                                                                                          Write(!Model.CustRates.Visible ? " hide " : "");
WriteLiteral(" form-control \' name=\'PopulateCustRates\' style=\'display:none\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  Write(Html.Raw(Model.PopulateCustRates));
WriteLiteral("</textarea>\r\n\t\t\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 14446), Tuple.Create("\'", 14516)
, Tuple.Create(Tuple.Create("", 14454), Tuple.Create("IQLabel100131", 14454), true)
, Tuple.Create(Tuple.Create(" ", 14467), Tuple.Create<System.Object, System.Int32>(!Model.CustPhone.LabelVisible ? " hide " : ""
, 14468), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 14517), Tuple.Create("\'", 14725)
              , Tuple.Create(Tuple.Create("", 14526), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustPhone.BackHEXColor) ? "" : "color:" + Model.CustPhone.BackHEXColor + ";"
, 14526), false)
, Tuple.Create(Tuple.Create("", 14632), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:3px;", 14632), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 15938), Tuple.Create("\'", 16006)
, Tuple.Create(Tuple.Create("", 15946), Tuple.Create("IQLabel100132", 15946), true)
, Tuple.Create(Tuple.Create(" ", 15959), Tuple.Create<System.Object, System.Int32>(!Model.CustFax.LabelVisible ? " hide " : ""
, 15960), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 16007), Tuple.Create("\'", 16212)
                        , Tuple.Create(Tuple.Create("", 16016), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFax.BackHEXColor) ? "" : "color:" + Model.CustFax.BackHEXColor + ";"
, 16016), false)
, Tuple.Create(Tuple.Create("", 16118), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:28px;", 16118), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 17402), Tuple.Create("\'", 17469)
, Tuple.Create(Tuple.Create("", 17410), Tuple.Create("IQLabel100133", 17410), true)
, Tuple.Create(Tuple.Create(" ", 17423), Tuple.Create<System.Object, System.Int32>(!Model.CustEM.LabelVisible ? " hide " : ""
, 17424), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 17470), Tuple.Create("\'", 17673)
                       , Tuple.Create(Tuple.Create("", 17479), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM.BackHEXColor) ? "" : "color:" + Model.CustEM.BackHEXColor + ";"
, 17479), false)
, Tuple.Create(Tuple.Create("", 17579), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:53px;", 17579), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 18838), Tuple.Create("\'", 18906)
, Tuple.Create(Tuple.Create("", 18846), Tuple.Create("IQLabel100134", 18846), true)
, Tuple.Create(Tuple.Create(" ", 18859), Tuple.Create<System.Object, System.Int32>(!Model.CustEM2.LabelVisible ? " hide " : ""
, 18860), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 18907), Tuple.Create("\'", 19112)
                        , Tuple.Create(Tuple.Create("", 18916), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM2.BackHEXColor) ? "" : "color:" + Model.CustEM2.BackHEXColor + ";"
, 18916), false)
, Tuple.Create(Tuple.Create("", 19018), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:78px;", 19018), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 20288), Tuple.Create("\'", 20356)
, Tuple.Create(Tuple.Create("", 20296), Tuple.Create("IQLabel100135", 20296), true)
, Tuple.Create(Tuple.Create(" ", 20309), Tuple.Create<System.Object, System.Int32>(!Model.CustEM3.LabelVisible ? " hide " : ""
, 20310), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 20357), Tuple.Create("\'", 20563)
                        , Tuple.Create(Tuple.Create("", 20366), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM3.BackHEXColor) ? "" : "color:" + Model.CustEM3.BackHEXColor + ";"
, 20366), false)
, Tuple.Create(Tuple.Create("", 20468), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:103px;", 20468), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 21740), Tuple.Create("\'", 21808)
, Tuple.Create(Tuple.Create("", 21748), Tuple.Create("IQLabel100136", 21748), true)
, Tuple.Create(Tuple.Create(" ", 21761), Tuple.Create<System.Object, System.Int32>(!Model.CustEM4.LabelVisible ? " hide " : ""
, 21762), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 21809), Tuple.Create("\'", 22015)
                        , Tuple.Create(Tuple.Create("", 21818), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustEM4.BackHEXColor) ? "" : "color:" + Model.CustEM4.BackHEXColor + ";"
, 21818), false)
, Tuple.Create(Tuple.Create("", 21920), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:128px;", 21920), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 23192), Tuple.Create("\'", 23262)
, Tuple.Create(Tuple.Create("", 23200), Tuple.Create("IQLabel100137", 23200), true)
, Tuple.Create(Tuple.Create(" ", 23213), Tuple.Create<System.Object, System.Int32>(!Model.CustVATNo.LabelVisible ? " hide " : ""
, 23214), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 23263), Tuple.Create("\'", 23473)
                          , Tuple.Create(Tuple.Create("", 23272), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustVATNo.BackHEXColor) ? "" : "color:" + Model.CustVATNo.BackHEXColor + ";"
, 23272), false)
, Tuple.Create(Tuple.Create("", 23378), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:153px;", 23378), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 24072), Tuple.Create("\'", 24142)
, Tuple.Create(Tuple.Create("", 24080), Tuple.Create("IQLabel100138", 24080), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 24093), Tuple.Create<System.Object, System.Int32>(!Model.CustDANNo.LabelVisible ? " hide " : ""
, 24094), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 24143), Tuple.Create("\'", 24353)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      , Tuple.Create(Tuple.Create("", 24152), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDANNo.BackHEXColor) ? "" : "color:" + Model.CustDANNo.BackHEXColor + ";"
, 24152), false)
, Tuple.Create(Tuple.Create("", 24258), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:178px;", 24258), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 24952), Tuple.Create("\'", 25021)
, Tuple.Create(Tuple.Create("", 24960), Tuple.Create("IQLabel100139", 24960), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create(" ", 24973), Tuple.Create<System.Object, System.Int32>(!Model.CustGBWK.LabelVisible ? " hide " : ""
, 24974), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25022), Tuple.Create("\'", 25230)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create("", 25031), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGBWK.BackHEXColor) ? "" : "color:" + Model.CustGBWK.BackHEXColor + ";"
, 25031), false)
, Tuple.Create(Tuple.Create("", 25135), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:315px;height:21px;width:10" +
"0px;top:203px;", 25135), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 25816), Tuple.Create("\'", 25889)
, Tuple.Create(Tuple.Create("", 25824), Tuple.Create("IQLabel100140", 25824), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 25837), Tuple.Create<System.Object, System.Int32>(!Model.CustBondCode.LabelVisible ? " hide " : ""
, 25838), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 25890), Tuple.Create("\'", 26106)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   , Tuple.Create(Tuple.Create("", 25899), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustBondCode.BackHEXColor) ? "" : "color:" + Model.CustBondCode.BackHEXColor + ";"
, 25899), false)
, Tuple.Create(Tuple.Create("", 26011), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:228px;", 26011), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 26732), Tuple.Create("\'", 26803)
, Tuple.Create(Tuple.Create("", 26740), Tuple.Create("IQLabel100142", 26740), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 26753), Tuple.Create<System.Object, System.Int32>(!Model.CustCrdScr.LabelVisible ? " hide " : ""
, 26754), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 26804), Tuple.Create("\'", 27016)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         , Tuple.Create(Tuple.Create("", 26813), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCrdScr.BackHEXColor) ? "" : "color:" + Model.CustCrdScr.BackHEXColor + ";"
, 26813), false)
, Tuple.Create(Tuple.Create("", 26921), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:295px;height:21px;width:12" +
"0px;top:278px;", 26921), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 28210), Tuple.Create("\'", 28283)
, Tuple.Create(Tuple.Create("", 28218), Tuple.Create("IQLabel100144", 28218), true)
, Tuple.Create(Tuple.Create(" ", 28231), Tuple.Create<System.Object, System.Int32>(!Model.CustGenNotes.LabelVisible ? " hide " : ""
, 28232), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 28284), Tuple.Create("\'", 28499)
                                 , Tuple.Create(Tuple.Create("", 28293), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGenNotes.BackHEXColor) ? "" : "color:" + Model.CustGenNotes.BackHEXColor + ";"
, 28293), false)
, Tuple.Create(Tuple.Create("", 28405), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:410px;height:21px;width:120" +
"px;top:353px;", 28405), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 29713), Tuple.Create("\'", 29782)
, Tuple.Create(Tuple.Create("", 29721), Tuple.Create("IQLabel100151", 29721), true)
, Tuple.Create(Tuple.Create(" ", 29734), Tuple.Create<System.Object, System.Int32>(!Model.CustLang.LabelVisible ? " hide " : ""
, 29735), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 29783), Tuple.Create("\'", 29990)
                             , Tuple.Create(Tuple.Create("", 29792), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustLang.BackHEXColor) ? "" : "color:" + Model.CustLang.BackHEXColor + ";"
, 29792), false)
, Tuple.Create(Tuple.Create("", 29896), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:28px;", 29896), true)
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
WriteAttribute("value", Tuple.Create(" value=\'", 30587), Tuple.Create("\'", 30608)
, Tuple.Create(Tuple.Create("", 30595), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 30595), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustLang.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 30740), Tuple.Create("\'", 30809)
, Tuple.Create(Tuple.Create("", 30748), Tuple.Create("IQLabel100152", 30748), true)
, Tuple.Create(Tuple.Create(" ", 30761), Tuple.Create<System.Object, System.Int32>(!Model.CustCurr.LabelVisible ? " hide " : ""
, 30762), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 30810), Tuple.Create("\'", 31017)
                      , Tuple.Create(Tuple.Create("", 30819), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCurr.BackHEXColor) ? "" : "color:" + Model.CustCurr.BackHEXColor + ";"
, 30819), false)
, Tuple.Create(Tuple.Create("", 30923), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:53px;", 30923), true)
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
WriteAttribute("value", Tuple.Create(" value=\'", 31614), Tuple.Create("\'", 31635)
, Tuple.Create(Tuple.Create("", 31622), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 31622), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == Model.PopulateCustCurr.ToString() ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                         Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select><label");
WriteAttribute("class", Tuple.Create(" class=\'", 31767), Tuple.Create("\'", 31839)
, Tuple.Create(Tuple.Create("", 31775), Tuple.Create("IQLabel100153", 31775), true)
, Tuple.Create(Tuple.Create(" ", 31788), Tuple.Create<System.Object, System.Int32>(!Model.CustDelZone.LabelVisible ? " hide " : ""
, 31789), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 31840), Tuple.Create("\'", 32053)
                         , Tuple.Create(Tuple.Create("", 31849), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDelZone.BackHEXColor) ? "" : "color:" + Model.CustDelZone.BackHEXColor + ";"
, 31849), false)
, Tuple.Create(Tuple.Create("", 31959), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:78px;", 31959), true)
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
WriteAttribute("value", Tuple.Create(" value=\'", 32746), Tuple.Create("\'", 32767)
, Tuple.Create(Tuple.Create("", 32754), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 32754), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 33659), Tuple.Create("\'", 33734)
, Tuple.Create(Tuple.Create("", 33667), Tuple.Create("IQLabel100154", 33667), true)
, Tuple.Create(Tuple.Create(" ", 33680), Tuple.Create<System.Object, System.Int32>(!Model.CustSendStatus.LabelVisible ? " hide " : ""
, 33681), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 33735), Tuple.Create("\'", 33955)
                               , Tuple.Create(Tuple.Create("", 33744), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustSendStatus.BackHEXColor) ? "" : "color:" + Model.CustSendStatus.BackHEXColor + ";"
, 33744), false)
, Tuple.Create(Tuple.Create("", 33860), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:103px;", 33860), true)
);
WriteLiteral(">Send Status</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustSendStatus\'");
WriteAttribute("class", Tuple.Create(" class=\'", 34036), Tuple.Create("\'", 34094)
, Tuple.Create(Tuple.Create("  ", 34044), Tuple.Create<System.Object, System.Int32>(!Model.CustSendStatus.Visible ? " hide " : ""
, 34046), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 34752), Tuple.Create("\'", 34825)
, Tuple.Create(Tuple.Create("", 34760), Tuple.Create("IQLabel100155", 34760), true)
, Tuple.Create(Tuple.Create(" ", 34773), Tuple.Create<System.Object, System.Int32>(!Model.CustSortCode.LabelVisible ? " hide " : ""
, 34774), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 34826), Tuple.Create("\'", 35042)
                 , Tuple.Create(Tuple.Create("", 34835), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustSortCode.BackHEXColor) ? "" : "color:" + Model.CustSortCode.BackHEXColor + ";"
, 34835), false)
, Tuple.Create(Tuple.Create("", 34947), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:128px;", 34947), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 35661), Tuple.Create("\'", 35734)
, Tuple.Create(Tuple.Create("", 35669), Tuple.Create("IQLabel100156", 35669), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 35682), Tuple.Create<System.Object, System.Int32>(!Model.CustOnFTrack.LabelVisible ? " hide " : ""
, 35683), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 35735), Tuple.Create("\'", 35951)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 35744), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustOnFTrack.BackHEXColor) ? "" : "color:" + Model.CustOnFTrack.BackHEXColor + ";"
, 35744), false)
, Tuple.Create(Tuple.Create("", 35856), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:665px;height:21px;width:11" +
"0px;top:153px;", 35856), true)
);
WriteLiteral(">On FreightTrack</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustOnFTrack\'");
WriteAttribute("class", Tuple.Create(" class=\'", 36034), Tuple.Create("\'", 36090)
, Tuple.Create(Tuple.Create("  ", 36042), Tuple.Create<System.Object, System.Int32>(!Model.CustOnFTrack.Visible ? " hide " : ""
, 36044), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 36672), Tuple.Create("\'", 36746)
, Tuple.Create(Tuple.Create("", 36680), Tuple.Create("IQLabel100157", 36680), true)
, Tuple.Create(Tuple.Create(" ", 36693), Tuple.Create<System.Object, System.Int32>(!Model.CustIntrastat.LabelVisible ? " hide " : ""
, 36694), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 36747), Tuple.Create("\'", 36964)
                  , Tuple.Create(Tuple.Create("", 36756), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustIntrastat.BackHEXColor) ? "" : "color:" + Model.CustIntrastat.BackHEXColor + ";"
, 36756), false)
, Tuple.Create(Tuple.Create("", 36870), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:815px;height:21px;width:90" +
"px;top:153px;", 36870), true)
);
WriteLiteral(">Intrastat</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustIntrastat\'");
WriteAttribute("class", Tuple.Create(" class=\'", 37042), Tuple.Create("\'", 37099)
, Tuple.Create(Tuple.Create("  ", 37050), Tuple.Create<System.Object, System.Int32>(!Model.CustIntrastat.Visible ? " hide " : ""
, 37052), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 37750), Tuple.Create("\'", 37822)
, Tuple.Create(Tuple.Create("", 37758), Tuple.Create("IQLabel100158", 37758), true)
, Tuple.Create(Tuple.Create(" ", 37771), Tuple.Create<System.Object, System.Int32>(!Model.CustWebsite.LabelVisible ? " hide " : ""
, 37772), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 37823), Tuple.Create("\'", 38035)
                , Tuple.Create(Tuple.Create("", 37832), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustWebsite.BackHEXColor) ? "" : "color:" + Model.CustWebsite.BackHEXColor + ";"
, 37832), false)
, Tuple.Create(Tuple.Create("", 37942), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:3px;", 37942), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 38643), Tuple.Create("\'", 38717)
, Tuple.Create(Tuple.Create("", 38651), Tuple.Create("IQLabel100159", 38651), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     , Tuple.Create(Tuple.Create(" ", 38664), Tuple.Create<System.Object, System.Int32>(!Model.CustCreatedBy.LabelVisible ? " hide " : ""
, 38665), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 38718), Tuple.Create("\'", 38936)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    , Tuple.Create(Tuple.Create("", 38727), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCreatedBy.BackHEXColor) ? "" : "color:" + Model.CustCreatedBy.BackHEXColor + ";"
, 38727), false)
, Tuple.Create(Tuple.Create("", 38841), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:228px;", 38841), true)
);
WriteLiteral(">Created By</label>\r\n\t\t<div");
WriteLiteral(" class=\'input-group\'");
WriteLiteral(" data-OriginalWidth=\'160\'");
WriteLiteral(" style=\'position: absolute; left:780px;height:21px;width:160px;top:228px;\'");
WriteLiteral("><select");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCreatedBy\'");
WriteLiteral(" \r\n\t\tdisabled=disabled");
WriteAttribute("class", Tuple.Create(" class=\'", 39155), Tuple.Create("\'", 39226)
, Tuple.Create(Tuple.Create("", 39163), Tuple.Create("form-control", 39163), true)
, Tuple.Create(Tuple.Create("    ", 39175), Tuple.Create<System.Object, System.Int32>(!Model.CustCreatedBy.Visible ? " hide " : ""
, 39179), false)
);
WriteLiteral("  ");
                                                                                              Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustCreatedBy/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustCreatedBy/',$(this));\""));
WriteLiteral("   name=\'PopulateCustCreatedBy\'  style=\'height:21px\'>\r\n");
             foreach(var itm in Model.CustCreatedBy.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 39578), Tuple.Create("\'", 39599)
, Tuple.Create(Tuple.Create("", 39586), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 39586), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 40481), Tuple.Create("\'", 40554)
, Tuple.Create(Tuple.Create("", 40489), Tuple.Create("IQLabel100160", 40489), true)
, Tuple.Create(Tuple.Create(" ", 40502), Tuple.Create<System.Object, System.Int32>(!Model.CustUserName.LabelVisible ? " hide " : ""
, 40503), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 40555), Tuple.Create("\'", 40771)
                             , Tuple.Create(Tuple.Create("", 40564), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustUserName.BackHEXColor) ? "" : "color:" + Model.CustUserName.BackHEXColor + ";"
, 40564), false)
, Tuple.Create(Tuple.Create("", 40676), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:178px;", 40676), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 41396), Tuple.Create("\'", 41469)
, Tuple.Create(Tuple.Create("", 41404), Tuple.Create("IQLabel100161", 41404), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 41417), Tuple.Create<System.Object, System.Int32>(!Model.CustPassword.LabelVisible ? " hide " : ""
, 41418), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 41470), Tuple.Create("\'", 41686)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 41479), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustPassword.BackHEXColor) ? "" : "color:" + Model.CustPassword.BackHEXColor + ";"
, 41479), false)
, Tuple.Create(Tuple.Create("", 41591), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:655px;height:21px;width:12" +
"0px;top:203px;", 41591), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 42311), Tuple.Create("\'", 42388)
, Tuple.Create(Tuple.Create("", 42319), Tuple.Create("IQLabel100171", 42319), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 42332), Tuple.Create<System.Object, System.Int32>(!Model.CustDueDiligence.LabelVisible ? " hide " : ""
, 42333), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 42389), Tuple.Create("\'", 42611)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               , Tuple.Create(Tuple.Create("", 42398), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustDueDiligence.BackHEXColor) ? "" : "color:" + Model.CustDueDiligence.BackHEXColor + ";"
, 42398), false)
, Tuple.Create(Tuple.Create("", 42518), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:3px;", 42518), true)
);
WriteLiteral(">Due Diligence Received</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustDueDiligence\'");
WriteAttribute("class", Tuple.Create(" class=\'", 42705), Tuple.Create("\'", 42765)
, Tuple.Create(Tuple.Create("  ", 42713), Tuple.Create<System.Object, System.Int32>(!Model.CustDueDiligence.Visible ? " hide " : ""
, 42715), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 43436), Tuple.Create("\'", 43516)
, Tuple.Create(Tuple.Create("", 43444), Tuple.Create("IQLabel100172", 43444), true)
, Tuple.Create(Tuple.Create(" ", 43457), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScoreSearch.LabelVisible ? " hide " : ""
, 43458), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 43517), Tuple.Create("\'", 43746)
                        , Tuple.Create(Tuple.Create("", 43526), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCredScoreSearch.BackHEXColor) ? "" : "color:" + Model.CustCredScoreSearch.BackHEXColor + ";"
, 43526), false)
, Tuple.Create(Tuple.Create("", 43652), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:28px;", 43652), true)
);
WriteLiteral(">Credit Score Searched</label>\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" data-ScreenInfo=\'Customers_CustCredScoreSearch\'");
WriteAttribute("class", Tuple.Create(" class=\'", 43842), Tuple.Create("\'", 43905)
, Tuple.Create(Tuple.Create("  ", 43850), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScoreSearch.Visible ? " hide " : ""
, 43852), false)
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
WriteAttribute("class", Tuple.Create(" class=\'", 44598), Tuple.Create("\'", 44672)
, Tuple.Create(Tuple.Create("", 44606), Tuple.Create("IQLabel100173", 44606), true)
, Tuple.Create(Tuple.Create(" ", 44619), Tuple.Create<System.Object, System.Int32>(!Model.CustCredScore.LabelVisible ? " hide " : ""
, 44620), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 44673), Tuple.Create("\'", 44890)
                  , Tuple.Create(Tuple.Create("", 44682), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustCredScore.BackHEXColor) ? "" : "color:" + Model.CustCredScore.BackHEXColor + ";"
, 44682), false)
, Tuple.Create(Tuple.Create("", 44796), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:945px;height:21px;width:15" +
"0px;top:53px;", 44796), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 45525), Tuple.Create("\'", 45600)
, Tuple.Create(Tuple.Create("", 45533), Tuple.Create("IQLabel100175", 45533), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create(" ", 45546), Tuple.Create<System.Object, System.Int32>(!Model.CustAccContact.LabelVisible ? " hide " : ""
, 45547), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 45601), Tuple.Create("\'", 45821)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  , Tuple.Create(Tuple.Create("", 45610), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAccContact.BackHEXColor) ? "" : "color:" + Model.CustAccContact.BackHEXColor + ";"
, 45610), false)
, Tuple.Create(Tuple.Create("", 45726), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:975px;height:21px;width:12" +
"0px;top:103px;", 45726), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 46462), Tuple.Create("\'", 46535)
, Tuple.Create(Tuple.Create("", 46470), Tuple.Create("IQLabel100176", 46470), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          , Tuple.Create(Tuple.Create(" ", 46483), Tuple.Create<System.Object, System.Int32>(!Model.CustAccEmail.LabelVisible ? " hide " : ""
, 46484), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 46536), Tuple.Create("\'", 46752)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        , Tuple.Create(Tuple.Create("", 46545), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustAccEmail.BackHEXColor) ? "" : "color:" + Model.CustAccEmail.BackHEXColor + ";"
, 46545), false)
, Tuple.Create(Tuple.Create("", 46657), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:975px;height:21px;width:12" +
"0px;top:128px;", 46657), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 47976), Tuple.Create("\'", 48049)
, Tuple.Create(Tuple.Create("", 47984), Tuple.Create("IQLabel100188", 47984), true)
, Tuple.Create(Tuple.Create(" ", 47997), Tuple.Create<System.Object, System.Int32>(!Model.CustFTLNotes.LabelVisible ? " hide " : ""
, 47998), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 48050), Tuple.Create("\'", 48265)
                             , Tuple.Create(Tuple.Create("", 48059), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFTLNotes.BackHEXColor) ? "" : "color:" + Model.CustFTLNotes.BackHEXColor + ";"
, 48059), false)
, Tuple.Create(Tuple.Create("", 48171), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:820px;height:21px;width:120" +
"px;top:353px;", 48171), true)
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
WriteLiteral(">Rates</label>\r\n\t\t\t\t<div");
WriteLiteral(" id=\"RichEditor-PopulateCustRates\"");
WriteLiteral(" ");
                                                   Write(Model.RecordLocked ? "data-disabled='true'" :"");
WriteLiteral("  data-target=\"textarea[name=PopulateCustRates]\" class=\'RichEditor\' style=\'positi" +
"on: absolute; left:5px;height:396px;width:475px;top:53px;\'>");
                                                                                                                                                                                                                                                Write(Html.Raw(Model.PopulateCustRates));
WriteLiteral("</div>\r\n\t\t<textarea");
WriteLiteral("  data-ScreenInfo=\'Notes_CustRates\'");
                                                Write(Model.RecordLocked || !Model.CustRates.Enabled ? "disabled=disabled" : "");
WriteLiteral(" ");
                                                                                                                            Write(Html.Raw(Model.RecordID.HasValue ? "onchange=\"javascript:IQAutoSave('/Customer/SaveCustRates/?RecId=" + Model.RecordID + "',$(this));\"" :"onchange=\"javascript:IQDirtyCallback('/Customer/CallbackCustRates/',$(this));\""));
WriteLiteral("  class=\' ");
                                                                                                                                                                                                                                                                                                                                                                      Write(!Model.CustRates.Visible ? " hide " : "");
WriteLiteral(" form-control \' name=\'PopulateCustRates\' style=\'display:none\'>");
                                                                                                                                                                                                                                                                                                                                                                                                                                                                              Write(Html.Raw(Model.PopulateCustRates));
WriteLiteral("</textarea>\r\n\t\t\r\n\t\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1153), Tuple.Create("\'", 1222)
, Tuple.Create(Tuple.Create("", 1161), Tuple.Create("IQLabel101212", 1161), true)
, Tuple.Create(Tuple.Create(" ", 1174), Tuple.Create<System.Object, System.Int32>(!Model.CustName.LabelVisible ? " hide " : ""
, 1175), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 1223), Tuple.Create("\'", 1427)
              , Tuple.Create(Tuple.Create("", 1232), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustName.BackHEXColor) ? "" : "color:" + Model.CustName.BackHEXColor + ";"
, 1232), false)
, Tuple.Create(Tuple.Create("", 1336), Tuple.Create("position:absolute;font-size:12px;text-align:right;left:5px;height:21px;width:120p" +
"x;top:3px;", 1336), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 2024), Tuple.Create("\'", 2097)
, Tuple.Create(Tuple.Create("", 2032), Tuple.Create("IQLabel101231", 2032), true)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             , Tuple.Create(Tuple.Create(" ", 2045), Tuple.Create<System.Object, System.Int32>(!Model.CustGenNotes.LabelVisible ? " hide " : ""
, 2046), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 2098), Tuple.Create("\'", 2311)
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           , Tuple.Create(Tuple.Create("", 2107), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustGenNotes.BackHEXColor) ? "" : "color:" + Model.CustGenNotes.BackHEXColor + ";"
, 2107), false)
, Tuple.Create(Tuple.Create("", 2219), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:500px;height:21px;width:120" +
"px;top:3px;", 2219), true)
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
WriteAttribute("class", Tuple.Create(" class=\'", 3520), Tuple.Create("\'", 3593)
, Tuple.Create(Tuple.Create("", 3528), Tuple.Create("IQLabel101234", 3528), true)
, Tuple.Create(Tuple.Create(" ", 3541), Tuple.Create<System.Object, System.Int32>(!Model.CustFTLNotes.LabelVisible ? " hide " : ""
, 3542), false)
);
WriteAttribute("style", Tuple.Create("  style=\'", 3594), Tuple.Create("\'", 3809)
                                  , Tuple.Create(Tuple.Create("", 3603), Tuple.Create<System.Object, System.Int32>(string.IsNullOrEmpty(Model.CustFTLNotes.BackHEXColor) ? "" : "color:" + Model.CustFTLNotes.BackHEXColor + ";"
, 3603), false)
, Tuple.Create(Tuple.Create("", 3715), Tuple.Create("position:absolute;font-size:12px;text-align:left;left:500px;height:21px;width:120" +
"px;top:153px;", 3715), true)
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
                                Write(Html.Raw(Request["ActiveTab"] != "Contact" ? "data-loadTarget='#3382d1d6ac164b158720286d1002b448' data-dynamicContent='/Contact/ListFromQuery?Limit=50&Ord=ContFN&Clause=ContCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"3382d1d6ac164b158720286d1002b448\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#cbff101b1b7c41f8b81808cdc187311c' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"cbff101b1b7c41f8b81808cdc187311c\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#67753803012b43e8a124729858c17aef' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNTo=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"67753803012b43e8a124729858c17aef\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#1ce2b38136c14ae4ae078f33691e982b' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvTo=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"1ce2b38136c14ae4ae078f33691e982b\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Job" ? "data-loadTarget='#1af58e6715174647a4b27ed850c5a8a6' data-dynamicContent='/Job/ListFromQuery?Limit=50&Ord=JobNo&Clause=JobTransp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"1af58e6715174647a4b27ed850c5a8a6\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#91651fd433de481dbeb01a238f5a1b58' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"91651fd433de481dbeb01a238f5a1b58\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "ShipDoc" ? "data-loadTarget='#66e93b808d0243a2b7f41a356aa11376' data-dynamicContent='/ShipDoc/ListFromQuery?Limit=50&Ord=SDId&Clause=SDSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"66e93b808d0243a2b7f41a356aa11376\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "UKOrder" ? "data-loadTarget='#5604b64742a14e60a51041a6b819c391' data-dynamicContent='/UKOrder/ListFromQuery?Limit=50&Ord=UKOId&Clause=UKOCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"5604b64742a14e60a51041a6b819c391\"");
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
                                Write(Html.Raw(Request["ActiveTab"] != "Contact" ? "data-loadTarget='#7f7d2deba66847a2a83f24a63d8ac28a' data-dynamicContent='/Contact/ListFromQuery?Limit=50&Ord=ContFN&Clause=ContCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"7f7d2deba66847a2a83f24a63d8ac28a\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Certificates of Shipment").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CertShip" ? "data-loadTarget='#b380b6086cca4c0a90b59eddde248e85' data-dynamicContent='/CertShip/ListFromQuery?Limit=50&Ord=CSId&Clause=CSCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"b380b6086cca4c0a90b59eddde248e85\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Credit Notes").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "CN" ? "data-loadTarget='#3cbcb6f82a3f494daab9003931f07246' data-dynamicContent='/CN/ListFromQuery?Limit=50&Ord=CNId&Clause=CNTo=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"3cbcb6f82a3f494daab9003931f07246\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Invoices").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Inv" ? "data-loadTarget='#09611facc1424422aa83708b56b1b0dc' data-dynamicContent='/Inv/ListFromQuery?Limit=50&Ord=InvId&Clause=InvTo=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"09611facc1424422aa83708b56b1b0dc\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Jobs").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Job" ? "data-loadTarget='#f1621263d9dd429ea6768ae4e51aeaff' data-dynamicContent='/Job/ListFromQuery?Limit=50&Ord=JobNo&Clause=JobTransp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"f1621263d9dd429ea6768ae4e51aeaff\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "Orders" ? "data-loadTarget='#8057de33fde64280a5622b6c04af785d' data-dynamicContent='/Orders/ListFromQuery?Limit=50&Ord=OrdId&Clause=OrdSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"8057de33fde64280a5622b6c04af785d\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "Shipping Documents").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "ShipDoc" ? "data-loadTarget='#18dafa1d37fe4f8682ec707532f0e142' data-dynamicContent='/ShipDoc/ListFromQuery?Limit=50&Ord=SDId&Clause=SDSupp=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"18dafa1d37fe4f8682ec707532f0e142\"");
WriteLiteral(">\r\n\t\t\t\t\tLoading data...\r\n\t\t\t\t\t</div>\r\n");
					}
WriteLiteral("\t\t\t\t</div>\r\n");
				}
WriteLiteral("\t\t\t\t\t\t\t");
                             if(Model.CachedSubForms.Where(f=> f.Title == "UK Orders").Any()) {
WriteLiteral("\t\t\t\t<div");
WriteLiteral(" role=\"tabpanel\"");
WriteLiteral(" ");
                                Write(Html.Raw(Request["ActiveTab"] != "UKOrder" ? "data-loadTarget='#f975c169d3a94301b41b84847b53cdb4' data-dynamicContent='/UKOrder/ListFromQuery?Limit=50&Ord=UKOId&Clause=UKOCust=" + Model.CustIdValue + "&Partial=true'" : ""));
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
WriteLiteral(" id=\"f975c169d3a94301b41b84847b53cdb4\"");
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
