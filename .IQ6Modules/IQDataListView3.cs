
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
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/.IQ6Modules/Views/Customer.cshtml")]
    public partial class @__IQ6Modules_Views_Customer_cshtml : System.Web.Mvc.WebViewPage<Page<FTL.Customer>>
    {
        public @__IQ6Modules_Views_Customer_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<div");
WriteLiteral(" class=\"row-fluid\"");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\"col-sm-3\"");
WriteLiteral("><b>Total Results:</b>\r\n\t\t<span");
WriteLiteral(" id=\"TotalResults\"");
WriteLiteral(">");
                           Write(Model.TotalItems);
WriteLiteral("</span>, \r\n\t\t<b>Total Selected:</b><span");
WriteLiteral(" id=\"TotalSelected\"");
WriteLiteral(">0</span></div>\r\n");
     if(Model.TotalItems ==0) {
WriteLiteral("\t<div");
WriteLiteral(" class=\"col-sm-3\"");
WriteLiteral("><b>No Results</b></div> \r\n");
	} else {
WriteLiteral("\t<div");
WriteLiteral(" class=\"col-sm-3\"");
WriteLiteral("><b>Showing Page:</b>\r\n");
WriteLiteral("\t ");
 Write(Model.CurrentPage);
WriteLiteral(" of ");
                         Write(Model.TotalPages);
WriteLiteral("\r\n\t </div>\r\n");
	}
WriteLiteral("\t<div");
WriteLiteral(" class=\'col-sm-3\'");
WriteLiteral(">\r\n");
         if(Model.CurrentPage>1) {
WriteLiteral("\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" value=\"<< Previous\"");
WriteLiteral(" \r\n\t\t\t\tclass=\"search btn btn-info btn-sm\"");
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\tonclick=\'", 591), Tuple.Create("\'", 693)
, Tuple.Create(Tuple.Create("", 607), Tuple.Create("$(\"input[name=start]\").val(", 607), true)
, Tuple.Create(Tuple.Create("", 634), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage-1
, 634), false)
, Tuple.Create(Tuple.Create("", 656), Tuple.Create(");DSSearch_RunSearch(\"", 656), true)
                 , Tuple.Create(Tuple.Create("", 678), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 678), false)
, Tuple.Create(Tuple.Create("", 690), Tuple.Create("\");", 690), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\r\n");
         if(Model.TotalPages > Model.CurrentPage) {
WriteLiteral("\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" value=\"Next >>\"");
WriteLiteral(" \r\n\t\t\t\tclass=\"search btn btn-info btn-sm\"");
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\t\tonclick=\'", 833), Tuple.Create("\'", 941)
, Tuple.Create(Tuple.Create("", 850), Tuple.Create("$(\"input[name=start]\").val(", 850), true)
, Tuple.Create(Tuple.Create("", 877), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage
, 877), false)
, Tuple.Create(Tuple.Create("", 895), Tuple.Create("+1);", 895), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 899), Tuple.Create("DSSearch_RunSearch(\"", 906), true)
, Tuple.Create(Tuple.Create("", 926), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 926), false)
, Tuple.Create(Tuple.Create("", 938), Tuple.Create("\");", 938), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\t</div>\r\n</div>\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:20px;\'");
WriteLiteral("></th>\r\n\t\t<th>Company ID</th><th>Town</th><th>Company Name</th><th>County</th>\t\t<" +
"/tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model.Items) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral(" class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1289), Tuple.Create("\"", 1331)
, Tuple.Create(Tuple.Create("", 1296), Tuple.Create("/Customer/Load/?RecId=", 1296), true)
               , Tuple.Create(Tuple.Create("", 1318), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1318), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t<td><input");
WriteLiteral(" type=\"checkbox\"");
WriteLiteral(" name=\"RecordIDs\"");
WriteLiteral(" onchange=\'DSSearch_RecordIDChange()\'");
WriteAttribute("value", Tuple.Create("  value=\"", 1499), Tuple.Create("\"", 1521)
                                 , Tuple.Create(Tuple.Create("", 1508), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1508), false)
);
WriteLiteral(" /></td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
                                       Write(itm.CustId.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.CustTown.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.CustName.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.CustCounty.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}
