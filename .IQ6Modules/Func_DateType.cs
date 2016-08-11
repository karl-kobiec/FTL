
public class DateType_FEDateType : 
	 SelectElementBase<string>
	{
	public DateType_FEDateType() :base("DateTypeValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class DateType_FEDateFrom : 
	 DateElementBase
	{
	public DateType_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class DateType_FEDateTo : 
	 DateElementBase
	{
	public DateType_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class DateTypeModel : ReportBase {
	public DateTypeModel() {
					DateType  = new DateType_FEDateType();
					DateFrom  = new DateType_FEDateFrom();
					DateTo  = new DateType_FEDateTo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateType);
					action(DateFrom);
					action(DateTo);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<DateTypeModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_DateType_cshtml));
    }
	
				public DateType_FEDateType DateType  { get;set;}
	
	public string DateTypeValue { 
		get { return DateType.DataValue;}
		set{ DateType.Value = value; }
	}
			public DateType_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public DateType_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/DateType.cshtml";
			}
}
public class DateTypeController : ScreenController<DateTypeModel> {
			public ActionResult AutoCompleteDateType(string q) {
			var mdl = new DateTypeModel();
			SC.GetManager<DateTypeModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.DateType.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateType.cshtml")]
    public partial class IQ6_Views_DateType_cshtml : System.Web.Mvc.WebViewPage<FTL.DateTypeModel>
    {
        public IQ6_Views_DateType_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "DateType";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<DateTypeModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/DateType_DateType.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/DateType_DateType.cshtml")]
    public partial class IQ6_Views_DateType_DateType_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_DateType_DateType_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406411", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.DateType.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#DateTypeValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:53px;\'");
WriteLiteral(">Date Type:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.DateType.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.DateType.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/DateType/Callback/?fname=DateType\',$(th" +
"is));\"  \r\n\t\t   name=\'DateTypeValue\'  style=\'position: absolute; left:210px;heigh" +
"t:21px;width:80px;top:53px;\'>\r\n");
             foreach(var itm in Model.DateType.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 682), Tuple.Create("\'", 703)
, Tuple.Create(Tuple.Create("", 690), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 690), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.DateTypeValue != null ? Model.DateTypeValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateTypeOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 906), Tuple.Create("\'", 1080)
, Tuple.Create(Tuple.Create("", 914), Tuple.Create("position:", 914), true)
, Tuple.Create(Tuple.Create(" ", 923), Tuple.Create("absolute;", 924), true)
, Tuple.Create(Tuple.Create(" ", 933), Tuple.Create("left:130px;height:21px;width:80px;top:53px;>", 934), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 978), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.DateTypeOperator))
, 985), false)
, Tuple.Create(Tuple.Create("\t\t", 1053), Tuple.Create("</select>", 1055), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1064), Tuple.Create("<label", 1067), true)
, Tuple.Create(Tuple.Create(" ", 1073), Tuple.Create("class=", 1074), true)
);
WriteLiteral("IQLabel406412 ");
                            Write(!Model.DateFrom.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateFromValue-Popover\" style=\'position:absolute;font-size:12px;t" +
"ext-align:right;left:5px;height:21px;width:120px;top:3px;\'>Date From:\r\n\t\t</label" +
"><input   ");
                     Write(!Model.DateFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateFrom.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("DateType/Callback/?fname=DateFrom");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                               Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct class=\'form-control\' name=\'DateFromOperator\' style=\'position: absolute; left:" +
"130px;height:21px;width:57px;top:3px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1932), Tuple.Create("\'", 1999)
, Tuple.Create(Tuple.Create("", 1940), Tuple.Create("IQLabel406413", 1940), true)
, Tuple.Create(Tuple.Create(" ", 1953), Tuple.Create<System.Object, System.Int32>(!Model.DateTo.LabelVisible ? " hide " : ""
, 1954), false)
);
WriteLiteral("  data-target=\"#DateToValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:28px;\'");
WriteLiteral(">Date To:\r\n\t\t</label><input   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/DateType/Callback/?fname=DateTo\',$(this" +
"));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                         Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateToOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2608), Tuple.Create("", 2768)
, Tuple.Create(Tuple.Create("", 2616), Tuple.Create("position:", 2616), true)
, Tuple.Create(Tuple.Create(" ", 2625), Tuple.Create("absolute;", 2626), true)
, Tuple.Create(Tuple.Create(" ", 2635), Tuple.Create("left:130px;height:21px;width:57px;top:28px;>", 2636), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2680), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator))
, 2687), false)
, Tuple.Create(Tuple.Create("\t\t", 2754), Tuple.Create("</select>", 2756), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2765), Tuple.Create("", 2765), true)
);
        }
    }
}
 
