
public class JobSearch_FEJobNo : 
	 ElementBase<string>{
	public JobSearch_FEJobNo() :base("JobNoValue", "JobNo"
		)
	{
		Enabled = true;
	}
		
}

public class JobSearchModel : ListScreenBase<Job> {
	public JobSearchModel() {
					JobNo  = new JobSearch_FEJobNo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(JobNo);
			}
	
	
		public override void ForEachSearchElement(Action<IElementBase, int> action) {
					action(JobNo, JobNoOperator);
			}
	protected override string OrderBy => "RecordID asc";
	public override List<ListFieldDetail> Fields =>
			new List<ListFieldDetail>() {
							new ListFieldDetail() { Width = 80, DFName="JobNo", Title="Job Number"},
							new ListFieldDetail() { Width = 40, DFName="JobTransp", Title="Transporter"},
							new ListFieldDetail() { Width = 80, DFName="JobVehNo", Title="Vehicle Number"},
							new ListFieldDetail() { Width = 80, DFName="JobTrailerNo", Title="Trailer Number"},
				
			};

					public int JobNoOperator { get;set;}
		public JobSearch_FEJobNo JobNo  { get;set;}
	
	public string JobNoValue { 
		get { return JobNo.DataValue;}
		set{ JobNo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/JobSearch.cshtml";
			}
}
public class JobSearchController : ListScreenController<JobSearchModel,Job> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/JobSearch.cshtml")]
    public partial class IQ6_Views_JobSearch_cshtml : System.Web.Mvc.WebViewPage<FTL.JobSearchModel>
    {
        public IQ6_Views_JobSearch_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Job Search";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<JobSearchModel>().OnDrawSingleToolbar) {
			foreach(var elm in itm(Model)) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t</div>\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(" >\r\n\t\t<input");
WriteLiteral(" type=\"button\"");
WriteLiteral(" onclick=\'DSSearch_RunSearch(\"/JobSearch/DrawList\")\'");
WriteLiteral(" class=\"btn btn-primary\"");
WriteLiteral(" value=\"Search\"");
WriteLiteral(" />\r\n\t\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(">\r\n\t\t\t<button");
WriteLiteral(" class=\"btn btn-default dropdown-toggle\"");
WriteLiteral(" type=\"button\"");
WriteLiteral(" id=\"dropdownMenu1\"");
WriteLiteral(" data-toggle=\"dropdown\"");
WriteLiteral(" aria-haspopup=\"true\"");
WriteLiteral(" aria-expanded=\"true\"");
WriteLiteral(">Export <span");
WriteLiteral(" class=\"caret\"");
WriteLiteral("></span></button>\r\n\t\t\t<ul");
WriteLiteral(" class=\"dropdown-menu\"");
WriteLiteral(" aria-labelledby=\"dropdownMenu1\"");
WriteLiteral(">\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/JobSearch/SearchExport/\")\'");
WriteLiteral(">Export Current Page</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" onclick=\'javascript:DSSearch_RunPageAction(\"/JobSearch/SearchExportAll/\")\'");
WriteLiteral(" href=\'#\'");
WriteLiteral(">Export All Results</a></li>\r\n\t\t\t\t<li><a");
WriteLiteral(" href=\'#\'");
WriteLiteral(" onclick=\'javascript:if($(\"input[name=RecordIDs]\").val().length) {DSSearch_RunPag" +
"eAction(\"/JobSearch/SearchExportSelected\");} else { alert(\"You have not selected" +
" any records\"); }\'");
WriteLiteral(">Export Selected</a></li>\r\n\t\t\t</ul>\r\n\t\t</div>\r\n");
         foreach(var itm in DS.GetManager<Job>().OnDrawListToolbar) {
			foreach(var elm in itm()) {
WriteLiteral("\t\t\t\t");
                 Write(Html.Raw(elm.HTML));
WriteLiteral("\r\n");
			}
		}
WriteLiteral("\t\t");
         foreach (var itm in DS.GlobalManager.OnDrawListToolbar)
        {
            foreach (var elem in itm.Invoke("Job"))
            {
WriteLiteral("                ");
                 Write(Html.Raw(elem.HTML));
WriteLiteral("\r\n");
            }
        }
WriteLiteral("\t</div>\r\n\t<input");
WriteLiteral(" type=\"hidden\"");
WriteLiteral(" name=\"start\"");
WriteLiteral(" value=\"1\"");
WriteLiteral(" />\r\n\t</div>\r\n\r\n<div");
WriteLiteral(" class=\'row\'");
WriteLiteral(">\r\n\t<div");
WriteLiteral(" class=\'col-sm-12\'");
WriteLiteral("> \r\n\r\n\t\t\t\t\t<div");
WriteLiteral(" style=\'position:relative;height:24px\'");
WriteLiteral(">\r\n");
				Html.RenderPartial("~/IQ6/Views/JobSearch_JobSearch.cshtml", Model);
WriteLiteral("\r\n\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t<br");
WriteLiteral(" style=\'clear:both\'");
WriteLiteral(" />\r\n\t<div");
WriteLiteral(" id=\"resultsView\"");
WriteLiteral(">\r\n");
          Html.RenderAction("DrawList", "JobSearch"); 
WriteLiteral("\r\n\t</div>\r\n\t\t</div>\r\n</div>");
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/JobSearch_JobSearch.cshtml")]
    public partial class IQ6_Views_JobSearch_JobSearch_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_JobSearch_JobSearch_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 109)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel107901", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.JobNo.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#JobNoValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Job Number\r\n\t\t</label><input ");
                   Write(!Model.JobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.JobNo.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/JobSearch/Callback/?fname=\',$(this)" +
");\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'JobNoValue\' \r\n\t\t\tvalue=\'");
              Write(Model.JobNo.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:256px;height:21px;width:126px;top:3px;\'/>\t" +
"\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'JobNoOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 686), Tuple.Create("", 843)
, Tuple.Create(Tuple.Create("", 694), Tuple.Create("position:", 694), true)
, Tuple.Create(Tuple.Create(" ", 703), Tuple.Create("absolute;", 704), true)
, Tuple.Create(Tuple.Create(" ", 713), Tuple.Create("left:130px;height:21px;width:126px;top:3px;>", 714), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 758), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.JobNoOperator))
, 765), false)
, Tuple.Create(Tuple.Create("\t\t", 829), Tuple.Create("</select>", 831), true)
, Tuple.Create(Tuple.Create("\r\n\t", 840), Tuple.Create("", 840), true)
);
        }
    }
}
 
