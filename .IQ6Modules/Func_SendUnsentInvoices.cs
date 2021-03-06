

public class SendUnsentInvoicesModel : ScreenBase {
	public SendUnsentInvoicesModel() {
			}
	public override void ForEachElement(Action<IElementBase> action) {
			}
	
	
			public override string GetView() {
				return "~/Views/Functions/SendUnsentInvoices.cshtml";
			}
}
public class SendUnsentInvoicesController : ScreenController<SendUnsentInvoicesModel> {
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
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/SendUnsentInvoices.cshtml")]
    public partial class IQ6_Views_SendUnsentInvoices_cshtml : System.Web.Mvc.WebViewPage<FTL.SendUnsentInvoicesModel>
    {
        public IQ6_Views_SendUnsentInvoices_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Send Unsent Invoices";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<SendUnsentInvoicesModel>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n\t</div>\r\n\r\n<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\'col-sm-12\'");
WriteLiteral("> \r\n\r\n\t\t\t\r\n\t\t\t</div>\r\n\t\t</div>\r\n</div>");
        }
    }
}
 
 
