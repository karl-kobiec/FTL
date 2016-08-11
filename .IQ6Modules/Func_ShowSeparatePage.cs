
public class ShowSeparatePage_FESepPage : 
	 ElementBase<bool>{
	public ShowSeparatePage_FESepPage() :base("SepPageValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class ShowSeparatePageModel : ReportBase {
	public ShowSeparatePageModel() {
					SepPage  = new ShowSeparatePage_FESepPage();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(SepPage);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ShowSeparatePageModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_ShowSeparatePage_cshtml));
    }
	
				public ShowSeparatePage_FESepPage SepPage  { get;set;}
	
	public bool SepPageValue { 
		get { return SepPage.DataValue;}
		set{ SepPage.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/ShowSeparatePage.cshtml";
			}
}
public class ShowSeparatePageController : ScreenController<ShowSeparatePageModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowSeparatePage.cshtml")]
    public partial class IQ6_Views_ShowSeparatePage_cshtml : System.Web.Mvc.WebViewPage<FTL.ShowSeparatePageModel>
    {
        public IQ6_Views_ShowSeparatePage_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "ShowSeparatePage";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ShowSeparatePageModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/ShowSeparatePage_ShowSeparatePage.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowSeparatePage_ShowSeparatePage.cshtml")]
    public partial class IQ6_Views_ShowSeparatePage_ShowSeparatePage_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_ShowSeparatePage_ShowSeparatePage_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 111)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406911", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.SepPage.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#SepPageValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:35px;height:21px;w" +
"idth:250px;top:3px;\'");
WriteLiteral(">Show each record on separate page\r\n\t\t</label>\t\t\t\r\n\t\t<input");
WriteAttribute("class", Tuple.Create("  class=\'", 309), Tuple.Create("\'", 361)
, Tuple.Create(Tuple.Create("  ", 318), Tuple.Create<System.Object, System.Int32>(!Model.SepPage.Visible ? " hide " : ""
, 320), false)
);
WriteLiteral(" \r\n\t\t ");
     Write(!Model.SepPage.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/ShowSeparat" +
"ePage/Callback/?fname=SepPage\',$(this));\"  style=\'position: absolute; left:17px;" +
"height:21px;width:12px;top:3px;\' name=\'SepPageValue\'   ");
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
WriteAttribute("style", Tuple.Create(" style=\'", 858), Tuple.Create("", 1017)
, Tuple.Create(Tuple.Create("", 866), Tuple.Create("position:", 866), true)
, Tuple.Create(Tuple.Create(" ", 875), Tuple.Create("absolute;", 876), true)
, Tuple.Create(Tuple.Create(" ", 885), Tuple.Create("left:5px;height:21px;width:12px;top:3px;>", 886), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 927), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.SepPageOperator))
, 934), false)
, Tuple.Create(Tuple.Create("\t\t", 1003), Tuple.Create("</select>", 1005), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1014), Tuple.Create("", 1014), true)
);
        }
    }
}
 
