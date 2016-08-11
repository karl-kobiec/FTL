
public class OrdersRequired_FEColPointID : 
	 ElementBase<string>{
	public OrdersRequired_FEColPointID() :base("ColPointIDValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class OrdersRequired_FEColPoint : 
	 SelectElementBase<string>
	{
	public OrdersRequired_FEColPoint() :base("ColPointValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class OrdersRequired_FEFrom : 
	 DateElementBase
	{
	public OrdersRequired_FEFrom() :base("FromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class OrdersRequired_FETo : 
	 DateElementBase
	{
	public OrdersRequired_FETo() :base("ToValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class OrdersRequiredModel : ReportBase {
	public OrdersRequiredModel() {
					ColPointID  = new OrdersRequired_FEColPointID();
					ColPoint  = new OrdersRequired_FEColPoint();
					From  = new OrdersRequired_FEFrom();
					To  = new OrdersRequired_FETo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(ColPointID);
					action(ColPoint);
					action(From);
					action(To);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<OrdersRequiredModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_OrdersRequired_cshtml));
    }
	
				public OrdersRequired_FEColPointID ColPointID  { get;set;}
	
	public string ColPointIDValue { 
		get { return ColPointID.DataValue;}
		set{ ColPointID.Value = value; }
	}
			public OrdersRequired_FEColPoint ColPoint  { get;set;}
	
	public string ColPointValue { 
		get { return ColPoint.DataValue;}
		set{ ColPoint.Value = value; }
	}
			public OrdersRequired_FEFrom From  { get;set;}
	
	public DateTime FromValue { 
		get { return From.DataValue;}
		set{ From.Value = value; }
	}
			public OrdersRequired_FETo To  { get;set;}
	
	public DateTime ToValue { 
		get { return To.DataValue;}
		set{ To.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/OrdersRequired.cshtml";
			}
}
public class OrdersRequiredController : ScreenController<OrdersRequiredModel> {
			public ActionResult AutoCompleteColPoint(string q) {
			var mdl = new OrdersRequiredModel();
			SC.GetManager<OrdersRequiredModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.ColPoint.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/OrdersRequired.cshtml")]
    public partial class IQ6_Views_OrdersRequired_cshtml : System.Web.Mvc.WebViewPage<FTL.OrdersRequiredModel>
    {
        public IQ6_Views_OrdersRequired_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "OrdersRequired";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<OrdersRequiredModel>().OnDrawSingleToolbar) {
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
WriteLiteral(" style=\'position:relative;height:124px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/OrdersRequired_OrdersRequired.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/OrdersRequired_OrdersRequired.cshtml")]
    public partial class IQ6_Views_OrdersRequired_OrdersRequired_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_OrdersRequired_OrdersRequired_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 114)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406011", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.ColPointID.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#ColPointIDValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Col Point ID:\r\n\t\t</label><input ");
                   Write(!Model.ColPointID.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.ColPointID.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/OrdersRequired/Callback/?fname=ColP" +
"ointID\',$(this));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'ColPointIDValue\' \r\n\t\t\tvalue=\'");
              Write(Model.ColPointID.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:210px;height:21px;width:80px;top:3px;\'/>\t\t" +
"<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'ColPointIDOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 738), Tuple.Create("\'", 912)
, Tuple.Create(Tuple.Create("", 746), Tuple.Create("position:", 746), true)
, Tuple.Create(Tuple.Create(" ", 755), Tuple.Create("absolute;", 756), true)
, Tuple.Create(Tuple.Create(" ", 765), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 766), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 809), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.ColPointIDOperator))
, 816), false)
, Tuple.Create(Tuple.Create("\t\t", 885), Tuple.Create("</select>", 887), true)
, Tuple.Create(Tuple.Create("\r\n\t", 896), Tuple.Create("<label", 899), true)
, Tuple.Create(Tuple.Create(" ", 905), Tuple.Create("class=", 906), true)
);
WriteLiteral("IQLabel406012 ");
                            Write(!Model.ColPoint.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#ColPointValue-Popover\" style=\'position:absolute;font-size:12px;t" +
"ext-align:right;left:5px;height:21px;width:120px;top:28px;\'>Collect Point:\r\n\t\t</" +
"label><select multiple=\"multiple\"  ");
                                         Write(!Model.ColPoint.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.ColPoint.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("OrdersRequired/Callback/?fname=ColPoint");
WriteLiteral("\',$(this));\"  \r\n\t\t   name=\'ColPointValue\'  style=\'position: absolute; left:210px;" +
"height:21px;width:80px;top:28px;\'>\r\n");
             foreach(var itm in Model.ColPoint.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1554), Tuple.Create("\'", 1575)
, Tuple.Create(Tuple.Create("", 1562), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1562), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.ColPointValue != null ? Model.ColPointValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select class=\'form-control\' name=\'ColPointOperator\' style=\'position" +
": absolute; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetComboOperators(Model.ColPointOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1945), Tuple.Create("\'", 2010)
, Tuple.Create(Tuple.Create("", 1953), Tuple.Create("IQLabel406014", 1953), true)
, Tuple.Create(Tuple.Create(" ", 1966), Tuple.Create<System.Object, System.Int32>(!Model.From.LabelVisible ? " hide " : ""
, 1967), false)
);
WriteLiteral("  data-target=\"#FromValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:78px;\'");
WriteLiteral(">From:\r\n\t\t</label><input   ");
                     Write(!Model.From.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.From.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/OrdersRequired/Callback/?fname=From\',$(" +
"this));\"  type=\'text\' name=\'FromValue\' value=\'");
                                                                                                                                                                                                                                         Write(Model.From.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:78px;\'/>\t\t<sel" +
"ect");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'FromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2608), Tuple.Create("\'", 2779)
, Tuple.Create(Tuple.Create("", 2616), Tuple.Create("position:", 2616), true)
, Tuple.Create(Tuple.Create(" ", 2625), Tuple.Create("absolute;", 2626), true)
, Tuple.Create(Tuple.Create(" ", 2635), Tuple.Create("left:130px;height:21px;width:57px;top:78px;>", 2636), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2680), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.FromOperator))
, 2687), false)
, Tuple.Create(Tuple.Create("\t\t", 2752), Tuple.Create("</select>", 2754), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2763), Tuple.Create("<label", 2766), true)
, Tuple.Create(Tuple.Create(" ", 2772), Tuple.Create("class=", 2773), true)
);
WriteLiteral("IQLabel406015 ");
                            Write(!Model.To.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#ToValue-Popover\" style=\'position:absolute;font-size:12px;text-al" +
"ign:right;left:5px;height:21px;width:120px;top:103px;\'>To:\r\n\t\t</label><input   ");
                     Write(!Model.To.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.To.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("OrdersRequired/Callback/?fname=To");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'ToValue\' value=\'");
                                                                                                                                                                                                                                   Write(Model.To.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:103px;\'/>\t\t<se" +
"lect class=\'form-control\' name=\'ToOperator\' style=\'position: absolute; left:130p" +
"x;height:21px;width:57px;top:103px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.ToOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
