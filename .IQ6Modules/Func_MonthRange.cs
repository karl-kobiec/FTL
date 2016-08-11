
public class MonthRange_FEStartMonth : 
	 SelectElementBase<string>
	{
	public MonthRange_FEStartMonth() :base("StartMonthValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class MonthRange_FEEndMonth : 
	 SelectElementBase<string>
	{
	public MonthRange_FEEndMonth() :base("EndMonthValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class MonthRangeModel : ReportBase {
	public MonthRangeModel() {
					StartMonth  = new MonthRange_FEStartMonth();
					EndMonth  = new MonthRange_FEEndMonth();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(StartMonth);
					action(EndMonth);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<MonthRangeModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_MonthRange_cshtml));
    }
	
				public MonthRange_FEStartMonth StartMonth  { get;set;}
	
	public string StartMonthValue { 
		get { return StartMonth.DataValue;}
		set{ StartMonth.Value = value; }
	}
			public MonthRange_FEEndMonth EndMonth  { get;set;}
	
	public string EndMonthValue { 
		get { return EndMonth.DataValue;}
		set{ EndMonth.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/MonthRange.cshtml";
			}
}
public class MonthRangeController : ScreenController<MonthRangeModel> {
			public ActionResult AutoCompleteStartMonth(string q) {
			var mdl = new MonthRangeModel();
			SC.GetManager<MonthRangeModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.StartMonth.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
		}
			public ActionResult AutoCompleteEndMonth(string q) {
			var mdl = new MonthRangeModel();
			SC.GetManager<MonthRangeModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.EndMonth.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/MonthRange.cshtml")]
    public partial class IQ6_Views_MonthRange_cshtml : System.Web.Mvc.WebViewPage<FTL.MonthRangeModel>
    {
        public IQ6_Views_MonthRange_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "MonthRange";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<MonthRangeModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/MonthRange_MonthRange.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/MonthRange_MonthRange.cshtml")]
    public partial class IQ6_Views_MonthRange_MonthRange_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_MonthRange_MonthRange_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 114)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406511", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.StartMonth.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#StartMonthValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Start Month:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.StartMonth.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.StartMonth.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/MonthRange/Callback/?fname=StartMonth\'," +
"$(this));\"  \r\n\t\t   name=\'StartMonthValue\'  style=\'position: absolute; left:210px" +
";height:21px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.StartMonth.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 698), Tuple.Create("\'", 719)
, Tuple.Create(Tuple.Create("", 706), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 706), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.StartMonthValue != null ? Model.StartMonthValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                    Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'StartMonthOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 928), Tuple.Create("\'", 1103)
, Tuple.Create(Tuple.Create("", 936), Tuple.Create("position:", 936), true)
, Tuple.Create(Tuple.Create(" ", 945), Tuple.Create("absolute;", 946), true)
, Tuple.Create(Tuple.Create(" ", 955), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 956), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 999), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.StartMonthOperator))
, 1006), false)
, Tuple.Create(Tuple.Create("\t\t", 1076), Tuple.Create("</select>", 1078), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1087), Tuple.Create("<label", 1090), true)
, Tuple.Create(Tuple.Create(" ", 1096), Tuple.Create("class=", 1097), true)
);
WriteLiteral("IQLabel406512 ");
                            Write(!Model.EndMonth.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#EndMonthValue-Popover\" style=\'position:absolute;font-size:12px;t" +
"ext-align:right;left:5px;height:21px;width:120px;top:28px;\'>End Month:\r\n\t\t</labe" +
"l><select multiple=\"multiple\"  ");
                                         Write(!Model.EndMonth.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.EndMonth.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("MonthRange/Callback/?fname=EndMonth");
WriteLiteral("\',$(this));\"  \r\n\t\t   name=\'EndMonthValue\'  style=\'position: absolute; left:210px;" +
"height:21px;width:80px;top:28px;\'>\r\n");
             foreach(var itm in Model.EndMonth.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1737), Tuple.Create("\'", 1758)
, Tuple.Create(Tuple.Create("", 1745), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1745), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.EndMonthValue != null ? Model.EndMonthValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select class=\'form-control\' name=\'EndMonthOperator\' style=\'position" +
": absolute; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetComboOperators(Model.EndMonthOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
