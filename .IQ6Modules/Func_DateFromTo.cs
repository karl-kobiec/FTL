
public class DateFromTo_FEDateFrom : 
	 DateElementBase
	{
	public DateFromTo_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class DateFromTo_FEDateTo : 
	 DateElementBase
	{
	public DateFromTo_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class DateFromToModel : ReportBase {
	public DateFromToModel() {
					DateFrom  = new DateFromTo_FEDateFrom();
					DateTo  = new DateFromTo_FEDateTo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateFrom);
					action(DateTo);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<DateFromToModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_DateFromTo_cshtml));
    }
	
				public DateFromTo_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public DateFromTo_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/DateFromTo.cshtml";
			}
}
public class DateFromToController : ScreenController<DateFromToModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateFromTo.cshtml")]
    public partial class IQ6_Views_DateFromTo_cshtml : System.Web.Mvc.WebViewPage<FTL.DateFromToModel>
    {
        public IQ6_Views_DateFromTo_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "DateFromTo";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<DateFromToModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/DateFromTo_DateFromTo.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateFromTo_DateFromTo.cshtml")]
    public partial class IQ6_Views_DateFromTo_DateFromTo_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_DateFromTo_DateFromTo_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406111", 51), true)
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
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/DateFromTo/Callback/?fname=DateFrom\',$(" +
"this));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                                 Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateFromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 737), Tuple.Create("\'", 911)
, Tuple.Create(Tuple.Create("", 745), Tuple.Create("position:", 745), true)
, Tuple.Create(Tuple.Create(" ", 754), Tuple.Create("absolute;", 755), true)
, Tuple.Create(Tuple.Create(" ", 764), Tuple.Create("left:130px;height:21px;width:57px;top:3px;>", 765), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 808), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator))
, 815), false)
, Tuple.Create(Tuple.Create("\t\t", 884), Tuple.Create("</select>", 886), true)
, Tuple.Create(Tuple.Create("\r\n\t", 895), Tuple.Create("<label", 898), true)
, Tuple.Create(Tuple.Create(" ", 904), Tuple.Create("class=", 905), true)
);
WriteLiteral("IQLabel406112 ");
                            Write(!Model.DateTo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateToValue-Popover\" style=\'position:absolute;font-size:12px;tex" +
"t-align:right;left:5px;height:21px;width:120px;top:28px;\'>Date To:\r\n\t\t</label><i" +
"nput   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("DateFromTo/Callback/?fname=DateTo");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                           Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect class=\'form-control\' name=\'DateToOperator\' style=\'position: absolute; left:1" +
"30px;height:21px;width:57px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
