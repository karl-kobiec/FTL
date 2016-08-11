
public class OrderSearch_FECustId : 
	 ElementBase<string>{
	public OrderSearch_FECustId() :base("CustIdValue", "CustId"
		)
	{
		Enabled = true;
	}
		
}
public class OrderSearch_FECustName : 
	 ElementBase<string>{
	public OrderSearch_FECustName() :base("CustNameValue", "CustName"
		)
	{
		Enabled = true;
	}
		
}
public class OrderSearch_FECustCounty : 
	 ElementBase<string>{
	public OrderSearch_FECustCounty() :base("CustCountyValue", "CustCounty"
		)
	{
		Enabled = true;
	}
		
}

public class OrderSearchModel : ListScreenBase<Customer> {
	public OrderSearchModel() {
					CustId  = new OrderSearch_FECustId();
					CustName  = new OrderSearch_FECustName();
					CustCounty  = new OrderSearch_FECustCounty();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(CustId);
					action(CustName);
					action(CustCounty);
			}
	
	
		public override void ForEachSearchElement(Action<IElementBase, int> action) {
					action(CustId, CustIdOperator);
					action(CustName, CustNameOperator);
					action(CustCounty, CustCountyOperator);
			}
	protected override string OrderBy => "RecordID asc";
	public override List<ListFieldDetail> Fields =>
			new List<ListFieldDetail>() {
							new ListFieldDetail() { Width = 40, DFName="OrdId", Title="Order Number"},
							new ListFieldDetail() { Width = 80, DFName="OrdCustOrd", Title="Client Order No"},
							new ListFieldDetail() { Width = 80, DFName="OrdDate", Title="Order Date"},
							new ListFieldDetail() { Width = 40, DFName="OrdStatus", Title="Status"},
				
			};

					public int CustIdOperator { get;set;}
		public OrderSearch_FECustId CustId  { get;set;}
	
	public string CustIdValue { 
		get { return CustId.DataValue;}
		set{ CustId.Value = value; }
	}
				public int CustNameOperator { get;set;}
		public OrderSearch_FECustName CustName  { get;set;}
	
	public string CustNameValue { 
		get { return CustName.DataValue;}
		set{ CustName.Value = value; }
	}
				public int CustCountyOperator { get;set;}
		public OrderSearch_FECustCounty CustCounty  { get;set;}
	
	public string CustCountyValue { 
		get { return CustCounty.DataValue;}
		set{ CustCounty.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/OrderSearch.cshtml";
			}
}
public class OrderSearchController : ListScreenController<OrderSearchModel,Customer> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/OrderSearch.cshtml")]
    public partial class IQ6_Views_OrderSearch_cshtml : System.Web.Mvc.WebViewPage<FTL.OrderSearchModel>
    {
        public IQ6_Views_OrderSearch_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Order Search";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<OrderSearchModel>().OnDrawSingleToolbar) {
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
WriteLiteral(" onclick=\'DSSearch_RunSearch(\"/OrderSearch/DrawList\")\'");
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
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/OrderSearch/SearchExport/\")\'");
WriteLiteral(">Export Current Page</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/OrderSearch/SearchExportAll/\")\'");
WriteLiteral(" href=\'#\'");
WriteLiteral(">Export All Results</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:if($(\"input[name=RecordIDs]\").val().length) {DSSearch_RunPag" +
"eAction(\"/OrderSearch/SearchExportSelected\");} else { alert(\"You have not select" +
"ed any records\"); }\'");
WriteLiteral(">Export Selected</a></li>\r\n\t\t\t</ul>\r\n\t\t</div>\r\n");
         foreach(var itm in DS.GetManager<Customer>().OnDrawListToolbar) {
			foreach(var elm in itm()) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t\t");
         foreach (var itm in DS.GlobalManager.OnDrawListToolbar)
        {
            foreach (var elem in itm.Invoke("Customer"))
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
WriteLiteral(" style=\'position:relative;height:52px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/OrderSearch_CustomerSearch.cshtml", Model);
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t<br");
WriteLiteral(" style=\'clear:both\'");
WriteLiteral(" />\r\n\t<div");
WriteLiteral(" id=\"resultsView\"");
WriteLiteral(">\r\n");
          Html.RenderAction("DrawList", "OrderSearch"); 
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/OrderSearch_CustomerSearch.cshtml")]
    public partial class IQ6_Views_OrderSearch_CustomerSearch_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_OrderSearch_CustomerSearch_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 110)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel108001", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.CustId.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#CustIdValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Company ID\r\n\t\t</label><input ");
                   Write(!Model.CustId.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.CustId.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/OrderSearch/Callback/?fname=\',$(thi" +
"s));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'CustIdValue\' \r\n\t\t\tvalue=\'");
              Write(Model.CustId.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:268px;height:21px;width:138px;top:4px;\'/>\t" +
"\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'CustIdOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 695), Tuple.Create("\'", 868)
, Tuple.Create(Tuple.Create("", 703), Tuple.Create("position:", 703), true)
, Tuple.Create(Tuple.Create(" ", 712), Tuple.Create("absolute;", 713), true)
, Tuple.Create(Tuple.Create(" ", 722), Tuple.Create("left:130px;height:21px;width:138px;top:4px;>", 723), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 767), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.CustIdOperator))
, 774), false)
, Tuple.Create(Tuple.Create("\t\t", 841), Tuple.Create("</select>", 843), true)
, Tuple.Create(Tuple.Create("\r\n\t", 852), Tuple.Create("<label", 855), true)
, Tuple.Create(Tuple.Create(" ", 861), Tuple.Create("class=", 862), true)
);
WriteLiteral("IQLabel108002 ");
                            Write(!Model.CustName.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#CustNameValue-Popover\" style=\'position:absolute;font-size:12px;t" +
"ext-align:right;left:440px;height:21px;width:120px;top:3px;\'>Company Name\r\n\t\t</l" +
"abel><input ");
                   Write(!Model.CustName.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.CustName.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("OrderSearch/Callback/?fname=\',$(this));\" \r\n\t\t\ttype=\'");
WriteLiteral("text\'");
WriteLiteral(" \r\n\t\t\tname=\'CustNameValue\'");
WriteAttribute("value", Tuple.Create(" \r\n\t\t\tvalue=\'", 1354), Tuple.Create("\'", 1397)
, Tuple.Create(Tuple.Create("", 1367), Tuple.Create<System.Object, System.Int32>(Model.CustName.ValueFormatted
, 1367), false)
);
WriteLiteral(" \r\n\t\t\tstyle=\'position: absolute; left:714px;height:21px;width:149px;top:3px;\'");
WriteLiteral("/>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'CustNameOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 1531), Tuple.Create("\'", 1704)
, Tuple.Create(Tuple.Create("", 1539), Tuple.Create("position:", 1539), true)
, Tuple.Create(Tuple.Create(" ", 1548), Tuple.Create("absolute;", 1549), true)
, Tuple.Create(Tuple.Create(" ", 1558), Tuple.Create("left:565px;height:21px;width:149px;top:3px;>", 1559), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 1603), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.CustNameOperator))
, 1610), false)
, Tuple.Create(Tuple.Create("\t\t", 1677), Tuple.Create("</select>", 1679), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1688), Tuple.Create("<label", 1691), true)
, Tuple.Create(Tuple.Create(" ", 1697), Tuple.Create("class=", 1698), true)
);
WriteLiteral("IQLabel108003 ");
                            Write(!Model.CustCounty.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#CustCountyValue-Popover\" style=\'position:absolute;font-size:12px" +
";text-align:right;left:5px;height:21px;width:120px;top:3px;\'>County\r\n\t\t</label><" +
"input ");
                   Write(!Model.CustCounty.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.CustCounty.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("OrderSearch/Callback/?fname=\',$(this));\" \r\n\t\t\ttype=\'");
WriteLiteral("text\'");
WriteLiteral(" \r\n\t\t\tname=\'CustCountyValue\'");
WriteAttribute("value", Tuple.Create(" \r\n\t\t\tvalue=\'", 2192), Tuple.Create("\'", 2237)
, Tuple.Create(Tuple.Create("", 2205), Tuple.Create<System.Object, System.Int32>(Model.CustCounty.ValueFormatted
, 2205), false)
);
WriteLiteral(" \r\n\t\t\tstyle=\'position: absolute; left:268px;height:21px;width:138px;top:31px;\'");
WriteLiteral("/>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'CustCountyOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2374), Tuple.Create("", 2537)
, Tuple.Create(Tuple.Create("", 2382), Tuple.Create("position:", 2382), true)
, Tuple.Create(Tuple.Create(" ", 2391), Tuple.Create("absolute;", 2392), true)
, Tuple.Create(Tuple.Create(" ", 2401), Tuple.Create("left:130px;height:21px;width:138px;top:31px;>", 2402), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2447), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.CustCountyOperator))
, 2454), false)
, Tuple.Create(Tuple.Create("\t\t", 2523), Tuple.Create("</select>", 2525), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2534), Tuple.Create("", 2534), true)
);
        }
    }
}
 
