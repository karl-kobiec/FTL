
public class ExciseSummary_FEDateFrom : 
	 DateElementBase
	{
	public ExciseSummary_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ExciseSummary_FEDateTo : 
	 DateElementBase
	{
	public ExciseSummary_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ExciseSummary_FESepPage : 
	 ElementBase<bool>{
	public ExciseSummary_FESepPage() :base("SepPageValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class ExciseSummaryModel : ReportBase {
	public ExciseSummaryModel() {
					DateFrom  = new ExciseSummary_FEDateFrom();
					DateTo  = new ExciseSummary_FEDateTo();
					SepPage  = new ExciseSummary_FESepPage();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateFrom);
					action(DateTo);
					action(SepPage);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ExciseSummaryModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_ExciseSummary_cshtml));
    }
	
				public ExciseSummary_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public ExciseSummary_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
			public ExciseSummary_FESepPage SepPage  { get;set;}
	
	public bool SepPageValue { 
		get { return SepPage.DataValue;}
		set{ SepPage.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/ExciseSummary.cshtml";
			}
}
public class ExciseSummaryController : ScreenController<ExciseSummaryModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ExciseSummary.cshtml")]
    public partial class IQ6_Views_ExciseSummary_cshtml : System.Web.Mvc.WebViewPage<FTL.ExciseSummaryModel>
    {
        public IQ6_Views_ExciseSummary_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "ExciseSummary";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ExciseSummaryModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/ExciseSummary_ExciseSummary.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ExciseSummary_ExciseSummary.cshtml")]
    public partial class IQ6_Views_ExciseSummary_ExciseSummary_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_ExciseSummary_ExciseSummary_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407511", 51), true)
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
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/ExciseSummary/Callback/?fname=DateFrom\'" +
",$(this));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                                    Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateFromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 740), Tuple.Create("\'", 914)
, Tuple.Create(Tuple.Create("", 748), Tuple.Create("position:", 748), true)
, Tuple.Create(Tuple.Create(" ", 757), Tuple.Create("absolute;", 758), true)
, Tuple.Create(Tuple.Create(" ", 767), Tuple.Create("left:130px;height:21px;width:57px;top:3px;>", 768), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 811), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator))
, 818), false)
, Tuple.Create(Tuple.Create("\t\t", 887), Tuple.Create("</select>", 889), true)
, Tuple.Create(Tuple.Create("\r\n\t", 898), Tuple.Create("<label", 901), true)
, Tuple.Create(Tuple.Create(" ", 907), Tuple.Create("class=", 908), true)
);
WriteLiteral("IQLabel407512 ");
                            Write(!Model.DateTo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateToValue-Popover\" style=\'position:absolute;font-size:12px;tex" +
"t-align:right;left:5px;height:21px;width:120px;top:28px;\'>Date To:\r\n\t\t</label><i" +
"nput   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("ExciseSummary/Callback/?fname=DateTo");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                              Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect class=\'form-control\' name=\'DateToOperator\' style=\'position: absolute; left:1" +
"30px;height:21px;width:57px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1754), Tuple.Create("\'", 1822)
, Tuple.Create(Tuple.Create("", 1762), Tuple.Create("IQLabel407514", 1762), true)
, Tuple.Create(Tuple.Create(" ", 1775), Tuple.Create<System.Object, System.Int32>(!Model.SepPage.LabelVisible ? " hide " : ""
, 1776), false)
);
WriteLiteral("  data-target=\"#SepPageValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:35px;height:21px;w" +
"idth:250px;top:78px;\'");
WriteLiteral(">Show on separate page\r\n\t\t</label>\t\t\t\r\n\t\t<input");
WriteAttribute("class", Tuple.Create("  class=\'", 2009), Tuple.Create("\'", 2061)
, Tuple.Create(Tuple.Create("  ", 2018), Tuple.Create<System.Object, System.Int32>(!Model.SepPage.Visible ? " hide " : ""
, 2020), false)
);
WriteLiteral(" \r\n\t\t ");
     Write(!Model.SepPage.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/ExciseSumma" +
"ry/Callback/?fname=SepPage\',$(this));\"  style=\'position: absolute; left:17px;hei" +
"ght:21px;width:12px;top:78px;\' name=\'SepPageValue\'   ");
                                                                                                                                                                                                                                                                               Write(Model.SepPageValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'SepPageValue\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                           Write(!Model.SepPageValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'SepPageOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2556), Tuple.Create("", 2716)
, Tuple.Create(Tuple.Create("", 2564), Tuple.Create("position:", 2564), true)
, Tuple.Create(Tuple.Create(" ", 2573), Tuple.Create("absolute;", 2574), true)
, Tuple.Create(Tuple.Create(" ", 2583), Tuple.Create("left:5px;height:21px;width:12px;top:78px;>", 2584), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2626), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.SepPageOperator))
, 2633), false)
, Tuple.Create(Tuple.Create("\t\t", 2702), Tuple.Create("</select>", 2704), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2713), Tuple.Create("", 2713), true)
);
        }
    }
}
 
