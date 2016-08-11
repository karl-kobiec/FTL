
public class SummaryDetail_FEType : 
	 SelectElementBase<string>
	{
	public SummaryDetail_FEType() :base("TypeValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class SummaryDetailModel : ReportBase {
	public SummaryDetailModel() {
					Type  = new SummaryDetail_FEType();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Type);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<SummaryDetailModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_SummaryDetail_cshtml));
    }
	
				public SummaryDetail_FEType Type  { get;set;}
	
	public string TypeValue { 
		get { return Type.DataValue;}
		set{ Type.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/SummaryDetail.cshtml";
			}
}
public class SummaryDetailController : ScreenController<SummaryDetailModel> {
			public ActionResult AutoCompleteType(string q) {
			var mdl = new SummaryDetailModel();
			SC.GetManager<SummaryDetailModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Type.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/SummaryDetail.cshtml")]
    public partial class IQ6_Views_SummaryDetail_cshtml : System.Web.Mvc.WebViewPage<FTL.SummaryDetailModel>
    {
        public IQ6_Views_SummaryDetail_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "SummaryDetail";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<SummaryDetailModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/SummaryDetail_SummaryDetail.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/SummaryDetail_SummaryDetail.cshtml")]
    public partial class IQ6_Views_SummaryDetail_SummaryDetail_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_SummaryDetail_SummaryDetail_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 108)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406711", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Type.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#TypeValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Type:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Type.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Type.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/SummaryDetail/Callback/?fname=Type\',$(t" +
"his));\"  \r\n\t\t   name=\'TypeValue\'  style=\'position: absolute; left:210px;height:2" +
"1px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Type.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 652), Tuple.Create("\'", 673)
, Tuple.Create(Tuple.Create("", 660), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 660), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.TypeValue != null ? Model.TypeValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'TypeOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 864), Tuple.Create("", 1020)
, Tuple.Create(Tuple.Create("", 872), Tuple.Create("position:", 872), true)
, Tuple.Create(Tuple.Create(" ", 881), Tuple.Create("absolute;", 882), true)
, Tuple.Create(Tuple.Create(" ", 891), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 892), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 935), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.TypeOperator))
, 942), false)
, Tuple.Create(Tuple.Create("\t\t", 1006), Tuple.Create("</select>", 1008), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1017), Tuple.Create("", 1017), true)
);
        }
    }
}
 
