
public class ExciseDetail_FEDateFrom : 
	 DateElementBase
	{
	public ExciseDetail_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ExciseDetail_FEDateTo : 
	 DateElementBase
	{
	public ExciseDetail_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ExciseDetail_FESelection : 
	 SelectElementBase<string>
	{
	public ExciseDetail_FESelection() :base("SelectionValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class ExciseDetail_FESepPage : 
	 ElementBase<bool>{
	public ExciseDetail_FESepPage() :base("SepPageValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ExciseDetail_FEShowAddr : 
	 ElementBase<bool>{
	public ExciseDetail_FEShowAddr() :base("ShowAddrValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class ExciseDetailModel : ReportBase {
	public ExciseDetailModel() {
					DateFrom  = new ExciseDetail_FEDateFrom();
					DateTo  = new ExciseDetail_FEDateTo();
					Selection  = new ExciseDetail_FESelection();
					SepPage  = new ExciseDetail_FESepPage();
					ShowAddr  = new ExciseDetail_FEShowAddr();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateFrom);
					action(DateTo);
					action(Selection);
					action(SepPage);
					action(ShowAddr);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ExciseDetailModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_ExciseDetail_cshtml));
    }
	
				public ExciseDetail_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public ExciseDetail_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
			public ExciseDetail_FESelection Selection  { get;set;}
	
	public string SelectionValue { 
		get { return Selection.DataValue;}
		set{ Selection.Value = value; }
	}
			public ExciseDetail_FESepPage SepPage  { get;set;}
	
	public bool SepPageValue { 
		get { return SepPage.DataValue;}
		set{ SepPage.Value = value; }
	}
			public ExciseDetail_FEShowAddr ShowAddr  { get;set;}
	
	public bool ShowAddrValue { 
		get { return ShowAddr.DataValue;}
		set{ ShowAddr.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/ExciseDetail.cshtml";
			}
}
public class ExciseDetailController : ScreenController<ExciseDetailModel> {
			public ActionResult AutoCompleteSelection(string q) {
			var mdl = new ExciseDetailModel();
			SC.GetManager<ExciseDetailModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Selection.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ExciseDetail.cshtml")]
    public partial class IQ6_Views_ExciseDetail_cshtml : System.Web.Mvc.WebViewPage<FTL.ExciseDetailModel>
    {
        public IQ6_Views_ExciseDetail_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "ExciseDetail";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ExciseDetailModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/ExciseDetail_ExciseDetail.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ExciseDetail_ExciseDetail.cshtml")]
    public partial class IQ6_Views_ExciseDetail_ExciseDetail_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_ExciseDetail_ExciseDetail_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407411", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.DateFrom.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#DateFromValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Date From:\r\n\t\t</label><input   ");
                     Write(!Model.DateFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateFrom.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/ExciseDetail/Callback/?fname=DateFrom\'," +
"$(this));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                                   Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateFromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 739), Tuple.Create("\'", 913)
, Tuple.Create(Tuple.Create("", 747), Tuple.Create("position:", 747), true)
, Tuple.Create(Tuple.Create(" ", 756), Tuple.Create("absolute;", 757), true)
, Tuple.Create(Tuple.Create(" ", 766), Tuple.Create("left:130px;height:21px;width:57px;top:3px;>", 767), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 810), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator))
, 817), false)
, Tuple.Create(Tuple.Create("\t\t", 886), Tuple.Create("</select>", 888), true)
, Tuple.Create(Tuple.Create("\r\n\t", 897), Tuple.Create("<label", 900), true)
, Tuple.Create(Tuple.Create(" ", 906), Tuple.Create("class=", 907), true)
);
WriteLiteral("IQLabel407412 ");
                            Write(!Model.DateTo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateToValue-Popover\" style=\'position:absolute;font-size:12px;tex" +
"t-align:right;left:5px;height:21px;width:120px;top:28px;\'>Date To:\r\n\t\t</label><i" +
"nput   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("ExciseDetail/Callback/?fname=DateTo");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                             Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect class=\'form-control\' name=\'DateToOperator\' style=\'position: absolute; left:1" +
"30px;height:21px;width:57px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1752), Tuple.Create("\'", 1822)
, Tuple.Create(Tuple.Create("", 1760), Tuple.Create("IQLabel407413", 1760), true)
, Tuple.Create(Tuple.Create(" ", 1773), Tuple.Create<System.Object, System.Int32>(!Model.Selection.LabelVisible ? " hide " : ""
, 1774), false)
);
WriteLiteral("  data-target=\"#SelectionValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:53px;\'");
WriteLiteral(">Selection:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Selection.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Selection.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/ExciseDetail/Callback/?fname=Selection\'" +
",$(this));\"  \r\n\t\t   name=\'SelectionValue\'  style=\'position: absolute; left:210px" +
";height:21px;width:80px;top:53px;\'>\r\n");
             foreach(var itm in Model.Selection.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2402), Tuple.Create("\'", 2423)
, Tuple.Create(Tuple.Create("", 2410), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2410), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.SelectionValue != null ? Model.SelectionValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                  Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'SelectionOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2629), Tuple.Create("\'", 2804)
, Tuple.Create(Tuple.Create("", 2637), Tuple.Create("position:", 2637), true)
, Tuple.Create(Tuple.Create(" ", 2646), Tuple.Create("absolute;", 2647), true)
, Tuple.Create(Tuple.Create(" ", 2656), Tuple.Create("left:130px;height:21px;width:80px;top:53px;>", 2657), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2701), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.SelectionOperator))
, 2708), false)
, Tuple.Create(Tuple.Create("\t\t", 2777), Tuple.Create("</select>", 2779), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2788), Tuple.Create("<label", 2791), true)
, Tuple.Create(Tuple.Create(" ", 2797), Tuple.Create("class=", 2798), true)
);
WriteLiteral("IQLabel407414 ");
                            Write(!Model.SepPage.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#SepPageValue-Popover\" style=\'position:absolute;font-size:12px;te" +
"xt-align:right;left:35px;height:21px;width:250px;top:78px;\'>Show separate page\r\n" +
"\t\t</label>\t\t\t\r\n\t\t<input  class=\'  ");
                     Write(!Model.SepPage.Visible ? " hide " : "");
WriteLiteral("\' \r\n");
WriteLiteral("\t\t ");
     Write(!Model.SepPage.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("ExciseDetail/Callback/?fname=SepPage");
WriteLiteral("\',$(this));\"  style=\'position: absolute; left:17px;height:21px;width:12px;top:78p" +
"x;\' name=\'SepPageValue\'   ");
                                                                                                                                                                                                                                                                              Write(Model.SepPageValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input type=\'hidden\' name=\'SepPageValue\' value=\'false\' ");
                                                           Write(!Model.SepPageValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select class=\'form-control\' name=\'SepPageOperator\' style=\'position: abs" +
"olute; left:5px;height:21px;width:12px;top:78px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.SepPageOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 3761), Tuple.Create("\'", 3830)
, Tuple.Create(Tuple.Create("", 3769), Tuple.Create("IQLabel407415", 3769), true)
, Tuple.Create(Tuple.Create(" ", 3782), Tuple.Create<System.Object, System.Int32>(!Model.ShowAddr.LabelVisible ? " hide " : ""
, 3783), false)
);
WriteLiteral("  data-target=\"#ShowAddrValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:35px;height:21px;w" +
"idth:250px;top:103px;\'");
WriteLiteral(">Show address details\r\n\t\t</label>\t\t\t\r\n\t\t<input");
WriteAttribute("class", Tuple.Create("  class=\'", 4018), Tuple.Create("\'", 4071)
, Tuple.Create(Tuple.Create("  ", 4027), Tuple.Create<System.Object, System.Int32>(!Model.ShowAddr.Visible ? " hide " : ""
, 4029), false)
);
WriteLiteral(" \r\n\t\t ");
     Write(!Model.ShowAddr.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/ExciseDetai" +
"l/Callback/?fname=ShowAddr\',$(this));\"  style=\'position: absolute; left:17px;hei" +
"ght:21px;width:12px;top:103px;\' name=\'ShowAddrValue\'   ");
                                                                                                                                                                                                                                                                                  Write(Model.ShowAddrValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'ShowAddrValue\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                            Write(!Model.ShowAddrValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'ShowAddrOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 4573), Tuple.Create("", 4735)
, Tuple.Create(Tuple.Create("", 4581), Tuple.Create("position:", 4581), true)
, Tuple.Create(Tuple.Create(" ", 4590), Tuple.Create("absolute;", 4591), true)
, Tuple.Create(Tuple.Create(" ", 4600), Tuple.Create("left:5px;height:21px;width:12px;top:103px;>", 4601), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 4644), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.ShowAddrOperator))
, 4651), false)
, Tuple.Create(Tuple.Create("\t\t", 4721), Tuple.Create("</select>", 4723), true)
, Tuple.Create(Tuple.Create("\r\n\t", 4732), Tuple.Create("", 4732), true)
);
        }
    }
}
 
