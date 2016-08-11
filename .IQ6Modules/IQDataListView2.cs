
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/.IQ6Modules/Views/Orders.cshtml")]
    public partial class @__IQ6Modules_Views_Orders_cshtml : System.Web.Mvc.WebViewPage<Page<FTL.Orders>>
    {
        public @__IQ6Modules_Views_Orders_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\tonclick=\'", 589), Tuple.Create("\'", 691)
, Tuple.Create(Tuple.Create("", 605), Tuple.Create("$(\"input[name=start]\").val(", 605), true)
, Tuple.Create(Tuple.Create("", 632), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage-1
, 632), false)
, Tuple.Create(Tuple.Create("", 654), Tuple.Create(");DSSearch_RunSearch(\"", 654), true)
                 , Tuple.Create(Tuple.Create("", 676), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 676), false)
, Tuple.Create(Tuple.Create("", 688), Tuple.Create("\");", 688), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\r\n");
         if(Model.TotalPages > Model.CurrentPage) {
WriteLiteral("\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" value=\"Next >>\"");
WriteLiteral(" \r\n\t\t\t\tclass=\"search btn btn-info btn-sm\"");
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\t\tonclick=\'", 831), Tuple.Create("\'", 939)
, Tuple.Create(Tuple.Create("", 848), Tuple.Create("$(\"input[name=start]\").val(", 848), true)
, Tuple.Create(Tuple.Create("", 875), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage
, 875), false)
, Tuple.Create(Tuple.Create("", 893), Tuple.Create("+1);", 893), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 897), Tuple.Create("DSSearch_RunSearch(\"", 904), true)
, Tuple.Create(Tuple.Create("", 924), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 924), false)
, Tuple.Create(Tuple.Create("", 936), Tuple.Create("\");", 936), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\t</div>\r\n</div>\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:20px;\'");
WriteLiteral("></th>\r\n\t\t<th>Client Order No</th><th>Status</th><th>Order Number</th><th>Order D" +
"ate</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model.Items) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral(" class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1298), Tuple.Create("\"", 1338)
, Tuple.Create(Tuple.Create("", 1305), Tuple.Create("/Orders/Load/?RecId=", 1305), true)
             , Tuple.Create(Tuple.Create("", 1325), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1325), false)
);
WriteLiteral("><img");
WriteLiteral(" src=\"/IQ6/viewrecord.png\"");
WriteLiteral(" style=\'max-height:21px;\'");
WriteLiteral(" />View Record</a></td>\r\n\t\t\t\t\t\t<td><input");
WriteLiteral(" type=\"checkbox\"");
WriteLiteral(" name=\"RecordIDs\"");
WriteLiteral(" onchange=\'DSSearch_RecordIDChange()\'");
WriteAttribute("value", Tuple.Create("  value=\"", 1506), Tuple.Create("\"", 1528)
                                 , Tuple.Create(Tuple.Create("", 1515), Tuple.Create<System.Object, System.Int32>(itm.RecordID
, 1515), false)
);
WriteLiteral(" /></td>\r\n\t\t\t\t\t\t\t\t\t\t<td>");
                                       Write(itm.OrdCustOrd.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.OrdStatus.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.OrdId.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.OrdDate.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}
