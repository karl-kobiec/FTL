
public class UnDecWithMonth_FEMonth : 
	 SelectElementBase<string>
	{
	public UnDecWithMonth_FEMonth() :base("MonthValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class UnDecWithMonth_FEUnDecOnly : 
	 ElementBase<bool>{
	public UnDecWithMonth_FEUnDecOnly() :base("UnDecOnlyValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class UnDecWithMonthModel : ReportBase {
	public UnDecWithMonthModel() {
					Month  = new UnDecWithMonth_FEMonth();
					UnDecOnly  = new UnDecWithMonth_FEUnDecOnly();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Month);
					action(UnDecOnly);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<UnDecWithMonthModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_UnDecWithMonth_cshtml));
    }
	
				public UnDecWithMonth_FEMonth Month  { get;set;}
	
	public string MonthValue { 
		get { return Month.DataValue;}
		set{ Month.Value = value; }
	}
			public UnDecWithMonth_FEUnDecOnly UnDecOnly  { get;set;}
	
	public bool UnDecOnlyValue { 
		get { return UnDecOnly.DataValue;}
		set{ UnDecOnly.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/UnDecWithMonth.cshtml";
			}
}
public class UnDecWithMonthController : ScreenController<UnDecWithMonthModel> {
			public ActionResult AutoCompleteMonth(string q) {
			var mdl = new UnDecWithMonthModel();
			SC.GetManager<UnDecWithMonthModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Month.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/UnDecWithMonth.cshtml")]
    public partial class IQ6_Views_UnDecWithMonth_cshtml : System.Web.Mvc.WebViewPage<FTL.UnDecWithMonthModel>
    {
        public IQ6_Views_UnDecWithMonth_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "UnDecWithMonth";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<UnDecWithMonthModel>().OnDrawSingleToolbar) {
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
WriteLiteral(" style=\'position:relative;height:49px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/UnDecWithMonth_UnDecWithMonth.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/UnDecWithMonth_UnDecWithMonth.cshtml")]
    public partial class IQ6_Views_UnDecWithMonth_UnDecWithMonth_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_UnDecWithMonth_UnDecWithMonth_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 109)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407211", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Month.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#MonthValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Month:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Month.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Month.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/UnDecWithMonth/Callback/?fname=Month\',$" +
"(this));\"  \r\n\t\t   name=\'MonthValue\'  style=\'position: absolute; left:210px;heigh" +
"t:21px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Month.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 661), Tuple.Create("\'", 682)
, Tuple.Create(Tuple.Create("", 669), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 669), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.MonthValue != null ? Model.MonthValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'MonthOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 876), Tuple.Create("\'", 1046)
, Tuple.Create(Tuple.Create("", 884), Tuple.Create("position:", 884), true)
, Tuple.Create(Tuple.Create(" ", 893), Tuple.Create("absolute;", 894), true)
, Tuple.Create(Tuple.Create(" ", 903), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 904), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 947), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.MonthOperator))
, 954), false)
, Tuple.Create(Tuple.Create("\t\t", 1019), Tuple.Create("</select>", 1021), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1030), Tuple.Create("<label", 1033), true)
, Tuple.Create(Tuple.Create(" ", 1039), Tuple.Create("class=", 1040), true)
);
WriteLiteral("IQLabel407212 ");
                            Write(!Model.UnDecOnly.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#UnDecOnlyValue-Popover\" style=\'position:absolute;font-size:12px;" +
"text-align:right;left:35px;height:21px;width:250px;top:28px;\'>Undeclared records" +
" only\r\n\t\t</label>\t\t\t\r\n\t\t<input  class=\'  ");
                     Write(!Model.UnDecOnly.Visible ? " hide " : "");
WriteLiteral("\' \r\n");
WriteLiteral("\t\t ");
     Write(!Model.UnDecOnly.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("UnDecWithMonth/Callback/?fname=UnDecOnly");
WriteLiteral("\',$(this));\"  style=\'position: absolute; left:17px;height:21px;width:12px;top:28p" +
"x;\' name=\'UnDecOnlyValue\'   ");
                                                                                                                                                                                                                                                                                      Write(Model.UnDecOnlyValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input type=\'hidden\' name=\'UnDecOnlyValue\' value=\'false\' ");
                                                             Write(!Model.UnDecOnlyValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select class=\'form-control\' name=\'UnDecOnlyOperator\' style=\'position: a" +
"bsolute; left:5px;height:21px;width:12px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.UnDecOnlyOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
