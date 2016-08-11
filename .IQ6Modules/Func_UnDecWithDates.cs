
public class UnDecWithDates_FEUnDecOnly : 
	 ElementBase<bool>{
	public UnDecWithDates_FEUnDecOnly() :base("UnDecOnlyValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class UnDecWithDates_FEDateFrom : 
	 DateElementBase
	{
	public UnDecWithDates_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class UnDecWithDates_FEDateTo : 
	 DateElementBase
	{
	public UnDecWithDates_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class UnDecWithDatesModel : ReportBase {
	public UnDecWithDatesModel() {
					UnDecOnly  = new UnDecWithDates_FEUnDecOnly();
					DateFrom  = new UnDecWithDates_FEDateFrom();
					DateTo  = new UnDecWithDates_FEDateTo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(UnDecOnly);
					action(DateFrom);
					action(DateTo);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<UnDecWithDatesModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_UnDecWithDates_cshtml));
    }
	
				public UnDecWithDates_FEUnDecOnly UnDecOnly  { get;set;}
	
	public bool UnDecOnlyValue { 
		get { return UnDecOnly.DataValue;}
		set{ UnDecOnly.Value = value; }
	}
			public UnDecWithDates_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public UnDecWithDates_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/UnDecWithDates.cshtml";
			}
}
public class UnDecWithDatesController : ScreenController<UnDecWithDatesModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/UnDecWithDates.cshtml")]
    public partial class IQ6_Views_UnDecWithDates_cshtml : System.Web.Mvc.WebViewPage<FTL.UnDecWithDatesModel>
    {
        public IQ6_Views_UnDecWithDates_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "UnDecWithDates";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<UnDecWithDatesModel>().OnDrawSingleToolbar) {
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
WriteLiteral(" style=\'position:relative;height:74px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/UnDecWithDates_UnDecWithDates.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/UnDecWithDates_UnDecWithDates.cshtml")]
    public partial class IQ6_Views_UnDecWithDates_UnDecWithDates_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_UnDecWithDates_UnDecWithDates_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 113)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407111", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.UnDecOnly.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#UnDecOnlyValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:35px;height:21px;w" +
"idth:250px;top:53px;\'");
WriteLiteral(">Undeclared records only\r\n\t\t</label>\t\t\t\r\n\t\t<input");
WriteAttribute("class", Tuple.Create("  class=\'", 304), Tuple.Create("\'", 358)
, Tuple.Create(Tuple.Create("  ", 313), Tuple.Create<System.Object, System.Int32>(!Model.UnDecOnly.Visible ? " hide " : ""
, 315), false)
);
WriteLiteral(" \r\n\t\t ");
     Write(!Model.UnDecOnly.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/UnDecWithDa" +
"tes/Callback/?fname=UnDecOnly\',$(this));\"  style=\'position: absolute; left:17px;" +
"height:21px;width:12px;top:53px;\' name=\'UnDecOnlyValue\'   ");
                                                                                                                                                                                                                                                                                      Write(Model.UnDecOnlyValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'UnDecOnlyValue\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                             Write(!Model.UnDecOnlyValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'UnDecOnlyOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 868), Tuple.Create("\'", 1043)
, Tuple.Create(Tuple.Create("", 876), Tuple.Create("position:", 876), true)
, Tuple.Create(Tuple.Create(" ", 885), Tuple.Create("absolute;", 886), true)
, Tuple.Create(Tuple.Create(" ", 895), Tuple.Create("left:5px;height:21px;width:12px;top:53px;>", 896), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 938), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.UnDecOnlyOperator))
, 945), false)
, Tuple.Create(Tuple.Create("\t\t", 1016), Tuple.Create("</select>", 1018), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1027), Tuple.Create("<label", 1030), true)
, Tuple.Create(Tuple.Create(" ", 1036), Tuple.Create("class=", 1037), true)
);
WriteLiteral("IQLabel407112 ");
                            Write(!Model.DateFrom.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateFromValue-Popover\" style=\'position:absolute;font-size:12px;t" +
"ext-align:right;left:5px;height:21px;width:120px;top:3px;\'>Date From:\r\n\t\t</label" +
"><input   ");
                     Write(!Model.DateFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateFrom.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("UnDecWithDates/Callback/?fname=DateFrom");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                                     Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct class=\'form-control\' name=\'DateFromOperator\' style=\'position: absolute; left:" +
"130px;height:21px;width:57px;top:3px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1901), Tuple.Create("\'", 1968)
, Tuple.Create(Tuple.Create("", 1909), Tuple.Create("IQLabel407113", 1909), true)
, Tuple.Create(Tuple.Create(" ", 1922), Tuple.Create<System.Object, System.Int32>(!Model.DateTo.LabelVisible ? " hide " : ""
, 1923), false)
);
WriteLiteral("  data-target=\"#DateToValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:28px;\'");
WriteLiteral(">Date To:\r\n\t\t</label><input   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/UnDecWithDates/Callback/?fname=DateTo\'," +
"$(this));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                               Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateToOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2583), Tuple.Create("", 2743)
, Tuple.Create(Tuple.Create("", 2591), Tuple.Create("position:", 2591), true)
, Tuple.Create(Tuple.Create(" ", 2600), Tuple.Create("absolute;", 2601), true)
, Tuple.Create(Tuple.Create(" ", 2610), Tuple.Create("left:130px;height:21px;width:57px;top:28px;>", 2611), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2655), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator))
, 2662), false)
, Tuple.Create(Tuple.Create("\t\t", 2729), Tuple.Create("</select>", 2731), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2740), Tuple.Create("", 2740), true)
);
        }
    }
}
 
