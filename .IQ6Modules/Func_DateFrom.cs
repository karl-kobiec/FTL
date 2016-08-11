
public class DateFrom_FEDateFrom : 
	 DateElementBase
	{
	public DateFrom_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class DateFromModel : ReportBase {
	public DateFromModel() {
					DateFrom  = new DateFrom_FEDateFrom();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateFrom);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<DateFromModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_DateFrom_cshtml));
    }
	
				public DateFrom_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/DateFrom.cshtml";
			}
}
public class DateFromController : ScreenController<DateFromModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateFrom.cshtml")]
    public partial class IQ6_Views_DateFrom_cshtml : System.Web.Mvc.WebViewPage<FTL.DateFromModel>
    {
        public IQ6_Views_DateFrom_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Date From";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<DateFromModel>().OnDrawSingleToolbar) {
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
WriteLiteral(" style=\'position:relative;height:24px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/DateFrom_DateFrom.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateFrom_DateFrom.cshtml")]
    public partial class IQ6_Views_DateFrom_DateFrom_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_DateFrom_DateFrom_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel405211", 51), true)
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
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/DateFrom/Callback/?fname=DateFrom\',$(th" +
"is));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                               Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateFromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 735), Tuple.Create("", 896)
, Tuple.Create(Tuple.Create("", 743), Tuple.Create("position:", 743), true)
, Tuple.Create(Tuple.Create(" ", 752), Tuple.Create("absolute;", 753), true)
, Tuple.Create(Tuple.Create(" ", 762), Tuple.Create("left:130px;height:21px;width:57px;top:3px;>", 763), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 806), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator))
, 813), false)
, Tuple.Create(Tuple.Create("\t\t", 882), Tuple.Create("</select>", 884), true)
, Tuple.Create(Tuple.Create("\r\n\t", 893), Tuple.Create("", 893), true)
);
        }
    }
}
 
