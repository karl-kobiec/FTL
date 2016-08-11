
public class StaffSelect_FEStaff : 
	 SelectElementBase<string>
	{
	public StaffSelect_FEStaff() :base("StaffValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class StaffSelectModel : ReportBase {
	public StaffSelectModel() {
					Staff  = new StaffSelect_FEStaff();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Staff);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<StaffSelectModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_StaffSelect_cshtml));
    }
	
				public StaffSelect_FEStaff Staff  { get;set;}
	
	public string StaffValue { 
		get { return Staff.DataValue;}
		set{ Staff.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/StaffSelect.cshtml";
			}
}
public class StaffSelectController : ScreenController<StaffSelectModel> {
			public ActionResult AutoCompleteStaff(string q) {
			var mdl = new StaffSelectModel();
			SC.GetManager<StaffSelectModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Staff.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/StaffSelect.cshtml")]
    public partial class IQ6_Views_StaffSelect_cshtml : System.Web.Mvc.WebViewPage<FTL.StaffSelectModel>
    {
        public IQ6_Views_StaffSelect_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "StaffSelect";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<StaffSelectModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/StaffSelect_StaffSelect.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/StaffSelect_StaffSelect.cshtml")]
    public partial class IQ6_Views_StaffSelect_StaffSelect_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_StaffSelect_StaffSelect_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 109)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel405611", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Staff.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#StaffValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">From:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Staff.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Staff.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/StaffSelect/Callback/?fname=Staff\',$(th" +
"is));\"  \r\n\t\t   name=\'StaffValue\'  style=\'position: absolute; left:210px;height:2" +
"1px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Staff.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 657), Tuple.Create("\'", 678)
, Tuple.Create(Tuple.Create("", 665), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 665), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.StaffValue != null ? Model.StaffValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'StaffOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 872), Tuple.Create("", 1029)
, Tuple.Create(Tuple.Create("", 880), Tuple.Create("position:", 880), true)
, Tuple.Create(Tuple.Create(" ", 889), Tuple.Create("absolute;", 890), true)
, Tuple.Create(Tuple.Create(" ", 899), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 900), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 943), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.StaffOperator))
, 950), false)
, Tuple.Create(Tuple.Create("\t\t", 1015), Tuple.Create("</select>", 1017), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1026), Tuple.Create("", 1026), true)
);
        }
    }
}
 
