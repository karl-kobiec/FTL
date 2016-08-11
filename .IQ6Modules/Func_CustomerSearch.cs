
public class CustomerSearch_FEOrdId : 
	 ElementBase<string>{
	public CustomerSearch_FEOrdId() :base("OrdIdValue", "OrdId"
		)
	{
		Enabled = true;
	}
		
}
public class CustomerSearch_FEOrdCustOrd : 
	 ElementBase<string>{
	public CustomerSearch_FEOrdCustOrd() :base("OrdCustOrdValue", "OrdCustOrd"
		)
	{
		Enabled = true;
	}
		
}

public class CustomerSearchModel : ListScreenBase<Orders> {
	public CustomerSearchModel() {
					OrdId  = new CustomerSearch_FEOrdId();
					OrdCustOrd  = new CustomerSearch_FEOrdCustOrd();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(OrdId);
					action(OrdCustOrd);
			}
	
	
		public override void ForEachSearchElement(Action<IElementBase, int> action) {
					action(OrdId, OrdIdOperator);
					action(OrdCustOrd, OrdCustOrdOperator);
			}
	protected override string OrderBy => "RecordID asc";
	public override List<ListFieldDetail> Fields =>
			new List<ListFieldDetail>() {
							new ListFieldDetail() { Width = 40, DFName="CustId", Title="Company ID"},
							new ListFieldDetail() { Width = 80, DFName="CustName", Title="Company Name"},
							new ListFieldDetail() { Width = 80, DFName="CustTown", Title="Town"},
							new ListFieldDetail() { Width = 80, DFName="CustCounty", Title="County"},
				
			};

					public int OrdIdOperator { get;set;}
		public CustomerSearch_FEOrdId OrdId  { get;set;}
	
	public string OrdIdValue { 
		get { return OrdId.DataValue;}
		set{ OrdId.Value = value; }
	}
				public int OrdCustOrdOperator { get;set;}
		public CustomerSearch_FEOrdCustOrd OrdCustOrd  { get;set;}
	
	public string OrdCustOrdValue { 
		get { return OrdCustOrd.DataValue;}
		set{ OrdCustOrd.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/CustomerSearch.cshtml";
			}
}
public class CustomerSearchController : ListScreenController<CustomerSearchModel,Orders> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/CustomerSearch.cshtml")]
    public partial class IQ6_Views_CustomerSearch_cshtml : System.Web.Mvc.WebViewPage<FTL.CustomerSearchModel>
    {
        public IQ6_Views_CustomerSearch_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Customer Search";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<CustomerSearchModel>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'DSSearch_RunSearch(\"/CustomerSearch/DrawList\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Search\"");
WriteLiteral(" />\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" class=\"btn btn-default dropdown-toggle\"");
WriteLiteral(" type=\"button\"");
WriteLiteral(" id=\"dropdownMenu1\"");
WriteLiteral(" data-toggle=\"dropdown\"");
WriteLiteral(" aria-haspopup=\"true\"");
WriteLiteral(" aria-expanded=\"true\"");
WriteLiteral(">Export <span");
WriteLiteral(" class=\"caret\"");
WriteLiteral("></span></button>\r\n\t\t\t<ul");
WriteLiteral(" class=\"dropdown-menu\"");
WriteLiteral(" aria-labelledby=\"dropdownMenu1\"");
WriteLiteral(">\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/CustomerSearch/SearchExport/\")\'");
WriteLiteral(">Export Current Page</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/CustomerSearch/SearchExportAll/\")\'");
WriteLiteral(" href=\'#\'");
WriteLiteral(">Export All Results</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:if($(\"input[name=RecordIDs]\").val().length) {DSSearch_RunPag" +
"eAction(\"/CustomerSearch/SearchExportSelected\");} else { alert(\"You have not sel" +
"ected any records\"); }\'");
WriteLiteral(">Export Selected</a></li>\r\n\t\t\t</ul>\r\n\t\t</div>\r\n");
         foreach(var itm in DS.GetManager<Orders>().OnDrawListToolbar) {
			foreach(var elm in itm()) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t\t");
         foreach (var itm in DS.GlobalManager.OnDrawListToolbar)
        {
            foreach (var elem in itm.Invoke("Orders"))
            {
WriteLiteral("                ");
                 Write(Html.Raw(elem.HTML));
WriteLiteral("\r\n");
            }
        }
WriteLiteral("\t</div>\r\n\t<input");
WriteLiteral(" type=\"hidden\"");
WriteLiteral(" name=\"start\"");
WriteLiteral(" value=\"1\"");
WriteLiteral(" />\r\n\t</div>\r\n\r\n<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\'col-sm-12\'");
WriteLiteral("> \r\n\r\n\t\t\t\t\t<div");
WriteLiteral(" style=\'position:relative;height:24px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/CustomerSearch_OrderSearch.cshtml", Model);
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t<br");
WriteLiteral(" style=\'clear:both\'");
WriteLiteral(" />\r\n\t<div");
WriteLiteral(" id=\"resultsView\"");
WriteLiteral(">\r\n");
          Html.RenderAction("DrawList", "CustomerSearch"); 
WriteLiteral("\r\n\t</div>\r\n\t\t</div>\r\n</div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/CustomerSearch_OrderSearch.cshtml")]
    public partial class IQ6_Views_CustomerSearch_OrderSearch_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_CustomerSearch_OrderSearch_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 109)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel108101", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.OrdId.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#OrdIdValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Order Number\r\n\t\t</label><input ");
                   Write(!Model.OrdId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.OrdId.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/CustomerSearch/Callback/?fname=\',$(" +
"this));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'OrdIdValue\' \r\n\t\t\tvalue=\'");
              Write(Model.OrdId.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:285px;height:21px;width:155px;top:3px;\'/>\t" +
"\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'OrdIdOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 693), Tuple.Create("\'", 865)
, Tuple.Create(Tuple.Create("", 701), Tuple.Create("position:", 701), true)
, Tuple.Create(Tuple.Create(" ", 710), Tuple.Create("absolute;", 711), true)
, Tuple.Create(Tuple.Create(" ", 720), Tuple.Create("left:130px;height:21px;width:155px;top:3px;>", 721), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 765), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.OrdIdOperator))
, 772), false)
, Tuple.Create(Tuple.Create("\t\t", 838), Tuple.Create("</select>", 840), true)
, Tuple.Create(Tuple.Create("\r\n\t", 849), Tuple.Create("<label", 852), true)
, Tuple.Create(Tuple.Create(" ", 858), Tuple.Create("class=", 859), true)
);
WriteLiteral("IQLabel108102 ");
                            Write(!Model.OrdCustOrd.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#OrdCustOrdValue-Popover\" style=\'position:absolute;font-size:12px" +
";text-align:right;left:440px;height:21px;width:120px;top:3px;\'>Client Order No\r\n" +
"\t\t</label><input ");
                   Write(!Model.OrdCustOrd.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.OrdCustOrd.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("CustomerSearch/Callback/?fname=\',$(this));\" \r\n\t\t\ttype=\'");
WriteLiteral("text\'");
WriteLiteral(" \r\n\t\t\tname=\'OrdCustOrdValue\'");
WriteAttribute("value", Tuple.Create(" \r\n\t\t\tvalue=\'", 1367), Tuple.Create("\'", 1412)
, Tuple.Create(Tuple.Create("", 1380), Tuple.Create<System.Object, System.Int32>(Model.OrdCustOrd.ValueFormatted
, 1380), false)
);
WriteLiteral(" \r\n\t\t\tstyle=\'position: absolute; left:718px;height:21px;width:153px;top:3px;\'");
WriteLiteral("/>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'OrdCustOrdOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 1548), Tuple.Create("", 1710)
, Tuple.Create(Tuple.Create("", 1556), Tuple.Create("position:", 1556), true)
, Tuple.Create(Tuple.Create(" ", 1565), Tuple.Create("absolute;", 1566), true)
, Tuple.Create(Tuple.Create(" ", 1575), Tuple.Create("left:565px;height:21px;width:153px;top:3px;>", 1576), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 1620), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.OrdCustOrdOperator))
, 1627), false)
, Tuple.Create(Tuple.Create("\t\t", 1696), Tuple.Create("</select>", 1698), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1707), Tuple.Create("", 1707), true)
);
        }
    }
}
 
