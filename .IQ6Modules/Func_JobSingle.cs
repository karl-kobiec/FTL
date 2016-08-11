
public class JobSingle_FEJob : 
	 SelectElementBase<string>
	{
	public JobSingle_FEJob() :base("JobValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class JobSingle_FEOrder : 
	 SelectElementBase<string>
	{
	public JobSingle_FEOrder() :base("OrderValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class JobSingleModel : ReportBase {
	public JobSingleModel() {
					Job  = new JobSingle_FEJob();
					Order  = new JobSingle_FEOrder();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Job);
					action(Order);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<JobSingleModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_JobSingle_cshtml));
    }
	
				public JobSingle_FEJob Job  { get;set;}
	
	public string JobValue { 
		get { return Job.DataValue;}
		set{ Job.Value = value; }
	}
			public JobSingle_FEOrder Order  { get;set;}
	
	public string OrderValue { 
		get { return Order.DataValue;}
		set{ Order.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/JobSingle.cshtml";
			}
}
public class JobSingleController : ScreenController<JobSingleModel> {
			public ActionResult AutoCompleteJob(string q) {
			var mdl = new JobSingleModel();
			SC.GetManager<JobSingleModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Job.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
		}
			public ActionResult AutoCompleteOrder(string q) {
			var mdl = new JobSingleModel();
			SC.GetManager<JobSingleModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Order.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/JobSingle.cshtml")]
    public partial class IQ6_Views_JobSingle_cshtml : System.Web.Mvc.WebViewPage<FTL.JobSingleModel>
    {
        public IQ6_Views_JobSingle_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "JobSingle";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<JobSingleModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/JobSingle_JobSingle.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/JobSingle_JobSingle.cshtml")]
    public partial class IQ6_Views_JobSingle_JobSingle_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_JobSingle_JobSingle_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 107)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407311", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Job.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#JobValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Job\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("\r\n\t   ");
   Write(!Model.Job.Enabled ? "disabled=disabled" : "");
WriteLiteral("  class=\'form-control    ");
                                                                            Write(!Model.Job.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete\' \r\n\t data-ajax--url=\'/JobSingle/AutoCompleteJob/\'  name=\'JobV" +
"alue\'  style=\'position: absolute; left:205px;height:21px;width:75px;top:3px;\'>\r\n" +
"");
                 if(Model.JobValue.ToString() != "" && Model.JobValue.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.Job.ValueFormatted));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'JobOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 762), Tuple.Create("\'", 930)
, Tuple.Create(Tuple.Create("", 770), Tuple.Create("position:", 770), true)
, Tuple.Create(Tuple.Create(" ", 779), Tuple.Create("absolute;", 780), true)
, Tuple.Create(Tuple.Create(" ", 789), Tuple.Create("left:130px;height:21px;width:75px;top:3px;>", 790), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 833), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.JobOperator))
, 840), false)
, Tuple.Create(Tuple.Create("\t\t", 903), Tuple.Create("</select>", 905), true)
, Tuple.Create(Tuple.Create("\r\n\t", 914), Tuple.Create("<label", 917), true)
, Tuple.Create(Tuple.Create(" ", 923), Tuple.Create("class=", 924), true)
);
WriteLiteral("IQLabel407312 ");
                            Write(!Model.Order.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#OrderValue-Popover\" style=\'position:absolute;font-size:12px;text" +
"-align:right;left:5px;height:21px;width:120px;top:53px;\'>Order\r\n\t\t</label><selec" +
"t multiple=\"multiple\"\r\n");
WriteLiteral("\t   ");
   Write(!Model.Order.Enabled ? "disabled=disabled" : "");
WriteLiteral("  class=\'form-control    ");
                                                                              Write(!Model.Order.Visible ? " hide " : "");
WriteLiteral(" searchautocomplete\' \r\n\t data-ajax--url=\'/JobSingle/AutoCompleteOrder/\'");
WriteLiteral("  name=\'OrderValue\'");
WriteLiteral("  style=\'position: absolute; left:205px;height:21px;width:75px;top:53px;\'");
WriteLiteral(">\r\n");
                 if(Model.OrderValue.ToString() != "" && Model.OrderValue.ToString() != "0") {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(Model.Order.ValueFormatted));
WriteLiteral("\r\n");
				}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'OrderOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 1666), Tuple.Create("", 1824)
, Tuple.Create(Tuple.Create("", 1674), Tuple.Create("position:", 1674), true)
, Tuple.Create(Tuple.Create(" ", 1683), Tuple.Create("absolute;", 1684), true)
, Tuple.Create(Tuple.Create(" ", 1693), Tuple.Create("left:130px;height:21px;width:75px;top:53px;>", 1694), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 1738), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.OrderOperator))
, 1745), false)
, Tuple.Create(Tuple.Create("\t\t", 1810), Tuple.Create("</select>", 1812), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1821), Tuple.Create("", 1821), true)
);
        }
    }
}
 
