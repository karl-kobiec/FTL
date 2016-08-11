
public class ShowSeparatePageAddress_FESepPage : 
	 ElementBase<bool>{
	public ShowSeparatePageAddress_FESepPage() :base("SepPageValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class ShowSeparatePageAddress_FEShowAddress : 
	 ElementBase<bool>{
	public ShowSeparatePageAddress_FEShowAddress() :base("ShowAddressValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class ShowSeparatePageAddressModel : ReportBase {
	public ShowSeparatePageAddressModel() {
					SepPage  = new ShowSeparatePageAddress_FESepPage();
					ShowAddress  = new ShowSeparatePageAddress_FEShowAddress();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(SepPage);
					action(ShowAddress);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ShowSeparatePageAddressModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_ShowSeparatePageAddress_cshtml));
    }
	
				public ShowSeparatePageAddress_FESepPage SepPage  { get;set;}
	
	public bool SepPageValue { 
		get { return SepPage.DataValue;}
		set{ SepPage.Value = value; }
	}
			public ShowSeparatePageAddress_FEShowAddress ShowAddress  { get;set;}
	
	public bool ShowAddressValue { 
		get { return ShowAddress.DataValue;}
		set{ ShowAddress.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/ShowSeparatePageAddress.cshtml";
			}
}
public class ShowSeparatePageAddressController : ScreenController<ShowSeparatePageAddressModel> {
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowSeparatePageAddress.cshtml")]
    public partial class IQ6_Views_ShowSeparatePageAddress_cshtml : System.Web.Mvc.WebViewPage<FTL.ShowSeparatePageAddressModel>
    {
        public IQ6_Views_ShowSeparatePageAddress_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "ShowSeparatePageAddress";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ShowSeparatePageAddressModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/ShowSeparatePageAddress_ShowSeparatePageAddress.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/ShowSeparatePageAddress_ShowSeparatePageAddress.cshtml")]
    public partial class IQ6_Views_ShowSeparatePageAddress_ShowSeparatePageAddress_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_ShowSeparatePageAddress_ShowSeparatePageAddress_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 111)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406811", 51), true)
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
"ePageAddress/Callback/?fname=SepPage\',$(this));\"  style=\'position: absolute; lef" +
"t:17px;height:21px;width:12px;top:3px;\' name=\'SepPageValue\'   ");
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
WriteAttribute("style", Tuple.Create(" style=\'", 865), Tuple.Create("\'", 1037)
, Tuple.Create(Tuple.Create("", 873), Tuple.Create("position:", 873), true)
, Tuple.Create(Tuple.Create(" ", 882), Tuple.Create("absolute;", 883), true)
, Tuple.Create(Tuple.Create(" ", 892), Tuple.Create("left:5px;height:21px;width:12px;top:3px;>", 893), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 934), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.SepPageOperator))
, 941), false)
, Tuple.Create(Tuple.Create("\t\t", 1010), Tuple.Create("</select>", 1012), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1021), Tuple.Create("<label", 1024), true)
, Tuple.Create(Tuple.Create(" ", 1030), Tuple.Create("class=", 1031), true)
);
WriteLiteral("IQLabel406812 ");
                            Write(!Model.ShowAddress.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#ShowAddressValue-Popover\" style=\'position:absolute;font-size:12p" +
"x;text-align:right;left:35px;height:21px;width:250px;top:28px;\'>Show Address det" +
"ails\r\n\t\t</label>\t\t\t\r\n\t\t<input  class=\'  ");
                     Write(!Model.ShowAddress.Visible ? " hide " : "");
WriteLiteral("\' \r\n");
WriteLiteral("\t\t ");
     Write(!Model.ShowAddress.Enabled ? "disabled=disabled" : "");
WriteLiteral("  type=\'checkbox\' value=\'true\' onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("ShowSeparatePageAddress/Callback/?fname=ShowAddress");
WriteLiteral("\',$(this));\"  style=\'position: absolute; left:17px;height:21px;width:12px;top:28p" +
"x;\' name=\'ShowAddressValue\'   ");
                                                                                                                                                                                                                                                                                                     Write(Model.ShowAddressValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t\t\r\n\t\t<input type=\'hidden\' name=\'ShowAddressValue\' value=\'false\' ");
                                                               Write(!Model.ShowAddressValue ? "checked=checked" : "");
WriteLiteral(" />\r\n\t\t\t\t<select class=\'form-control\' name=\'ShowAddressOperator\' style=\'position:" +
" absolute; left:5px;height:21px;width:12px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetBooleanOperators(Model.ShowAddressOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
