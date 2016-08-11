
public class CreatePeriodInv_FEClientNo : 
	 ElementBase<string>{
	public CreatePeriodInv_FEClientNo() :base("ClientNoValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class CreatePeriodInv_FEInvoiceNo : 
	 ElementBase<string>{
	public CreatePeriodInv_FEInvoiceNo() :base("InvoiceNoValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class CreatePeriodInv_FECreateInv : 
	 ElementBase<string>{
	public CreatePeriodInv_FECreateInv() :base("CreateInvValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class CreatePeriodInv_FEPrintInv : 
	 ElementBase<string>{
	public CreatePeriodInv_FEPrintInv() :base("PrintInvValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class CreatePeriodInvModel : ScreenBase {
	public CreatePeriodInvModel() {
					ClientNo  = new CreatePeriodInv_FEClientNo();
					InvoiceNo  = new CreatePeriodInv_FEInvoiceNo();
					CreateInv  = new CreatePeriodInv_FECreateInv();
					PrintInv  = new CreatePeriodInv_FEPrintInv();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(ClientNo);
					action(InvoiceNo);
					action(CreateInv);
					action(PrintInv);
			}
	
	
				public CreatePeriodInv_FEClientNo ClientNo  { get;set;}
	
	public string ClientNoValue { 
		get { return ClientNo.DataValue;}
		set{ ClientNo.Value = value; }
	}
			public CreatePeriodInv_FEInvoiceNo InvoiceNo  { get;set;}
	
	public string InvoiceNoValue { 
		get { return InvoiceNo.DataValue;}
		set{ InvoiceNo.Value = value; }
	}
			public CreatePeriodInv_FECreateInv CreateInv  { get;set;}
	
	public string CreateInvValue { 
		get { return CreateInv.DataValue;}
		set{ CreateInv.Value = value; }
	}
			public CreatePeriodInv_FEPrintInv PrintInv  { get;set;}
	
	public string PrintInvValue { 
		get { return PrintInv.DataValue;}
		set{ PrintInv.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/CreatePeriodInv.cshtml";
			}
}
public class CreatePeriodInvController : ScreenController<CreatePeriodInvModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/CreatePeriodInv.cshtml")]
    public partial class IQ6_Views_CreatePeriodInv_cshtml : System.Web.Mvc.WebViewPage<FTL.CreatePeriodInvModel>
    {
        public IQ6_Views_CreatePeriodInv_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Create Period Invoice";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<CreatePeriodInvModel>().OnDrawSingleToolbar) {
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
WriteLiteral("> \r\n\r\n\t\t\t\t\t<div");
WriteLiteral(" style=\'position:relative;height:99px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/CreatePeriodInv_PeriodInvIncludes.cshtml", Model);
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n</div>");
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
    using IQ6.Core;
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/CreatePeriodInv_PeriodInvIncludes.cshtml")]
    public partial class IQ6_Views_CreatePeriodInv_PeriodInvIncludes_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_CreatePeriodInv_PeriodInvIncludes_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel505111", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.ClientNo.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#ClientNoValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Client No:\r\n\t\t</label><input ");
                   Write(!Model.ClientNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.ClientNo.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/CreatePeriodInv/Callback/?fname=Cli" +
"entNo\',$(this));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'ClientNoValue\' \r\n\t\t\tvalue=\'");
              Write(Model.ClientNo.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:210px;height:21px;width:80px;top:3px;\'/>\t\t" +
"<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'ClientNoOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 720), Tuple.Create("\'", 892)
, Tuple.Create(Tuple.Create("", 728), Tuple.Create("position:", 728), true)
, Tuple.Create(Tuple.Create(" ", 737), Tuple.Create("absolute;", 738), true)
, Tuple.Create(Tuple.Create(" ", 747), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 748), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 791), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.ClientNoOperator))
, 798), false)
, Tuple.Create(Tuple.Create("\t\t", 865), Tuple.Create("</select>", 867), true)
, Tuple.Create(Tuple.Create("\r\n\t", 876), Tuple.Create("<label", 879), true)
, Tuple.Create(Tuple.Create(" ", 885), Tuple.Create("class=", 886), true)
);
WriteLiteral("IQLabel505112 ");
                            Write(!Model.InvoiceNo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#InvoiceNoValue-Popover\" style=\'position:absolute;font-size:12px;" +
"text-align:right;left:5px;height:21px;width:120px;top:28px;\'>Invoice No:\r\n\t\t</la" +
"bel><input ");
                   Write(!Model.InvoiceNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.InvoiceNo.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("CreatePeriodInv/Callback/?fname=InvoiceNo");
WriteLiteral("\',$(this));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'InvoiceNoValue\' \r\n\t\t\tvalue=\'");
              Write(Model.InvoiceNo.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:210px;height:21px;width:80px;top:28px;\'/>\t" +
"\t<select class=\'form-control\' name=\'InvoiceNoOperator\' style=\'position: absolute" +
"; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetTextOperators(Model.InvoiceNoOperator)));
WriteLiteral("\t\t</select>\r\n\t\t\t\t<button");
WriteLiteral(" type=\'button\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral("   onclick=\"javascript:IQDirtyCallback(\'/CreatePeriodInv/Callback/?fname=CreateIn" +
"v\',$(this));\"");
WriteLiteral("   style=\'position: absolute; left:230px;height:46px;width:100px;top:53px;\'");
WriteLiteral(">Create Invoice</button>\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'CreateInvOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2034), Tuple.Create("\'", 2212)
, Tuple.Create(Tuple.Create("", 2042), Tuple.Create("position:", 2042), true)
, Tuple.Create(Tuple.Create(" ", 2051), Tuple.Create("absolute;", 2052), true)
, Tuple.Create(Tuple.Create(" ", 2061), Tuple.Create("left:130px;height:46px;width:100px;top:53px;>", 2062), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2107), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.CreateInvOperator))
, 2114), false)
, Tuple.Create(Tuple.Create("\t\t", 2182), Tuple.Create("</select>", 2184), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t", 2193), Tuple.Create("<button", 2199), true)
, Tuple.Create(Tuple.Create(" ", 2206), Tuple.Create("type=", 2207), true)
);
WriteLiteral("button\'");
WriteLiteral(" class=\'btn btn-primary\'");
WriteLiteral("   onclick=\"javascript:IQDirtyCallback(\'/CreatePeriodInv/Callback/?fname=PrintInv" +
"\',$(this));\"");
WriteLiteral("   style=\'position: absolute; left:450px;height:46px;width:100px;top:53px;\'");
WriteLiteral(">Print Invoice</button>\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'PrintInvOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2493), Tuple.Create("", 2654)
, Tuple.Create(Tuple.Create("", 2501), Tuple.Create("position:", 2501), true)
, Tuple.Create(Tuple.Create(" ", 2510), Tuple.Create("absolute;", 2511), true)
, Tuple.Create(Tuple.Create(" ", 2520), Tuple.Create("left:350px;height:46px;width:100px;top:53px;>", 2521), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2566), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.PrintInvOperator))
, 2573), false)
, Tuple.Create(Tuple.Create("\t\t", 2640), Tuple.Create("</select>", 2642), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2651), Tuple.Create("", 2651), true)
);
        }
    }
}
 
