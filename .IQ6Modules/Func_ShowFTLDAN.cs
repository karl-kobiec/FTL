
public class ShowFTLDAN_FEFTLDAN : 
	 ElementBase<bool>{
	public ShowFTLDAN_FEFTLDAN() :base("FTLDANValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class ShowFTLDANModel : ReportBase {
	public ShowFTLDANModel() {
					FTLDAN  = new ShowFTLDAN_FEFTLDAN();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(FTLDAN);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ShowFTLDANModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_ShowFTLDAN_cshtml));
    }
	
				public ShowFTLDAN_FEFTLDAN FTLDAN  { get;set;}
	
	public bool FTLDANValue { 
		get { return FTLDAN.DataValue;}
		set{ FTLDAN.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/ShowFTLDAN.cshtml";
			}
}
public class ShowFTLDANController : ScreenController<ShowFTLDANModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowFTLDAN.cshtml")]
    public partial class IQ6_Views_ShowFTLDAN_cshtml : System.Web.Mvc.WebViewPage<FTL.ShowFTLDANModel>
    {
        public IQ6_Views_ShowFTLDAN_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "ShowFTLDAN";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ShowFTLDANModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/ShowFTLDAN_ShowFTLDAN.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowFTLDAN_ShowFTLDAN.cshtml")]
    public partial class IQ6_Views_ShowFTLDAN_ShowFTLDAN_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_ShowFTLDAN_ShowFTLDAN_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 110)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407011", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.FTLDAN.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#FTLDANValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:35px;height:21px;w" +
"idth:120px;top:3px;\'");
WriteLiteral(">Show only FTL DAN\r\n\t\t</label>\t\t\t\r\n\t\t<input");
WriteAttribute("class", Tuple.Create("  class=\'", 291), Tuple.Create("\'", 342)
, Tuple.Create(Tuple.Create("  ", 300), Tuple.Create<System.Object, System.Int32>(!Model.FTLDAN.Visible ? " hide " : ""
, 302), false)
);
WriteLiteral(" \r\n\t\t ");
     Write(!Model.FTLDAN.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/ShowFTLDAN/" +
"Callback/?fname=FTLDAN\',$(this));\"  style=\'position: absolute; left:17px;height:" +
"21px;width:12px;top:3px;\' name=\'FTLDANValue\'   ");
                                                                                                                                                                                                                                                                        Write(Model.FTLDANValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input");
WriteLiteral(" type=\'hidden\'");
WriteLiteral(" name=\'FTLDANValue\'");
WriteLiteral(" value=\'false\'");
WriteLiteral(" ");
                                                          Write(!Model.FTLDANValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'FTLDANOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 826), Tuple.Create("", 984)
, Tuple.Create(Tuple.Create("", 834), Tuple.Create("position:", 834), true)
, Tuple.Create(Tuple.Create(" ", 843), Tuple.Create("absolute;", 844), true)
, Tuple.Create(Tuple.Create(" ", 853), Tuple.Create("left:5px;height:21px;width:12px;top:3px;>", 854), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 895), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.FTLDANOperator))
, 902), false)
, Tuple.Create(Tuple.Create("\t\t", 970), Tuple.Create("</select>", 972), true)
, Tuple.Create(Tuple.Create("\r\n\t", 981), Tuple.Create("", 981), true)
);
        }
    }
}
 
