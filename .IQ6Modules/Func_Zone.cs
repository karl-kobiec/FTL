
public class Zone_FEZone : 
	 SelectElementBase<string>
	{
	public Zone_FEZone() :base("ZoneValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class ZoneModel : ReportBase {
	public ZoneModel() {
					Zone  = new Zone_FEZone();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Zone);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<ZoneModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_Zone_cshtml));
    }
	
				public Zone_FEZone Zone  { get;set;}
	
	public string ZoneValue { 
		get { return Zone.DataValue;}
		set{ Zone.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/Zone.cshtml";
			}
}
public class ZoneController : ScreenController<ZoneModel> {
			public ActionResult AutoCompleteZone(string q) {
			var mdl = new ZoneModel();
			SC.GetManager<ZoneModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Zone.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Zone.cshtml")]
    public partial class IQ6_Views_Zone_cshtml : System.Web.Mvc.WebViewPage<FTL.ZoneModel>
    {
        public IQ6_Views_Zone_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "Zone";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<ZoneModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/Zone_Zone.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/Zone_Zone.cshtml")]
    public partial class IQ6_Views_Zone_Zone_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_Zone_Zone_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 108)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel406611", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Zone.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#ZoneValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Zone:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Zone.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Zone.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/Zone/Callback/?fname=Zone\',$(this));\"  " +
"\r\n\t\t   name=\'ZoneValue\'  style=\'position: absolute; left:210px;height:21px;width" +
":80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Zone.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 643), Tuple.Create("\'", 664)
, Tuple.Create(Tuple.Create("", 651), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 651), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.ZoneValue != null ? Model.ZoneValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'ZoneOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 855), Tuple.Create("", 1011)
, Tuple.Create(Tuple.Create("", 863), Tuple.Create("position:", 863), true)
, Tuple.Create(Tuple.Create(" ", 872), Tuple.Create("absolute;", 873), true)
, Tuple.Create(Tuple.Create(" ", 882), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 883), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 926), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.ZoneOperator))
, 933), false)
, Tuple.Create(Tuple.Create("\t\t", 997), Tuple.Create("</select>", 999), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1008), Tuple.Create("", 1008), true)
);
        }
    }
}
 
