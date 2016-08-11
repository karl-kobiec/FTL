
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/.IQ6Modules/Views/Jobs.cshtml")]
    public partial class @__IQ6Modules_Views_Jobs_cshtml : System.Web.Mvc.WebViewPage<Page<FTL.Job>>
    {
        public @__IQ6Modules_Views_Jobs_cshtml()
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
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\tonclick=\'", 586), Tuple.Create("\'", 688)
, Tuple.Create(Tuple.Create("", 602), Tuple.Create("$(\"input[name=start]\").val(", 602), true)
, Tuple.Create(Tuple.Create("", 629), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage-1
, 629), false)
, Tuple.Create(Tuple.Create("", 651), Tuple.Create(");DSSearch_RunSearch(\"", 651), true)
                 , Tuple.Create(Tuple.Create("", 673), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 673), false)
, Tuple.Create(Tuple.Create("", 685), Tuple.Create("\");", 685), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\r\n");
         if(Model.TotalPages > Model.CurrentPage) {
WriteLiteral("\t\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" value=\"Next >>\"");
WriteLiteral(" \r\n\t\t\t\tclass=\"search btn btn-info btn-sm\"");
WriteAttribute("onclick", Tuple.Create(" \r\n\t\t\t\t\tonclick=\'", 828), Tuple.Create("\'", 936)
, Tuple.Create(Tuple.Create("", 845), Tuple.Create("$(\"input[name=start]\").val(", 845), true)
, Tuple.Create(Tuple.Create("", 872), Tuple.Create<System.Object, System.Int32>(Model.CurrentPage
, 872), false)
, Tuple.Create(Tuple.Create("", 890), Tuple.Create("+1);", 890), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 894), Tuple.Create("DSSearch_RunSearch(\"", 901), true)
, Tuple.Create(Tuple.Create("", 921), Tuple.Create<System.Object, System.Int32>(ViewBag.Url
, 921), false)
, Tuple.Create(Tuple.Create("", 933), Tuple.Create("\");", 933), true)
);
WriteLiteral(" />\r\n");
		}
WriteLiteral("\t</div>\r\n</div>\r\n<table");
WriteLiteral(" class=\'table table-striped\'");
WriteLiteral(">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:100px;\'");
WriteLiteral("></th>\r\n\t\t\t\t<th");
WriteLiteral(" style=\'width:20px;\'");
WriteLiteral("></th>\r\n\t\t<th>Job Number</th><th>Transporter</th><th>Vehicle Number</th><th>Trail" +
"er Number</th>\t\t</tr>\r\n\t</thead>\r\n");
     foreach(var itm in Model.Items) {
WriteLiteral("\t\t");
WriteLiteral("\r\n\t\t\t<tr>\r\n\t\t\t\t\t\t<td><a");
WriteLiteral(" class=\'pjax btn btn-primary btn-xs\'");
WriteAttribute("href", Tuple.Create(" href=\"", 1301), Tuple.Create("\"", 1338)
, Tuple.Create(Tuple.Create("", 1308), Tuple.Create("/Job/Load/?RecId=", 1308), true)
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
                                       Write(itm.JobNo.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.JobTransp.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.JobVehNo.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t\t\t\t<td>");
                                           Write(itm.JobTrailerNo.DisplayValue);
WriteLiteral("</td>\r\n\t\t\t\t\t\t\t\t</tr>\r\n\t\t");
WriteLiteral("\r\n");
	}
WriteLiteral("</table>");
        }
    }
}
