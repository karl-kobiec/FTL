
public class StaffAndDest_FEFrom : 
	 SelectElementBase<string>
	{
	public StaffAndDest_FEFrom() :base("FromValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class StaffAndDest_FEEmailTo : 
	 SelectElementBase<string>
	{
	public StaffAndDest_FEEmailTo() :base("EmailToValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class StaffAndDestModel : ReportBase {
	public StaffAndDestModel() {
					From  = new StaffAndDest_FEFrom();
					EmailTo  = new StaffAndDest_FEEmailTo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(From);
					action(EmailTo);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<StaffAndDestModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_StaffAndDest_cshtml));
    }
	
				public StaffAndDest_FEFrom From  { get;set;}
	
	public string FromValue { 
		get { return From.DataValue;}
		set{ From.Value = value; }
	}
			public StaffAndDest_FEEmailTo EmailTo  { get;set;}
	
	public string EmailToValue { 
		get { return EmailTo.DataValue;}
		set{ EmailTo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/StaffAndDest.cshtml";
			}
}
public class StaffAndDestController : ScreenController<StaffAndDestModel> {
			public ActionResult AutoCompleteFrom(string q) {
			var mdl = new StaffAndDestModel();
			SC.GetManager<StaffAndDestModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.From.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
		}
			public ActionResult AutoCompleteEmailTo(string q) {
			var mdl = new StaffAndDestModel();
			SC.GetManager<StaffAndDestModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.EmailTo.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/StaffAndDest.cshtml")]
    public partial class IQ6_Views_StaffAndDest_cshtml : System.Web.Mvc.WebViewPage<FTL.StaffAndDestModel>
    {
        public IQ6_Views_StaffAndDest_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "StaffAndDest";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<StaffAndDestModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/StaffAndDest_StaffAndDest.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/StaffAndDest_StaffAndDest.cshtml")]
    public partial class IQ6_Views_StaffAndDest_StaffAndDest_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_StaffAndDest_StaffAndDest_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 108)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel405511", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.From.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#FromValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">From:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.From.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.From.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/StaffAndDest/Callback/?fname=From\',$(th" +
"is));\"  \r\n\t\t   name=\'FromValue\'  style=\'position: absolute; left:210px;height:21" +
"px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.From.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 651), Tuple.Create("\'", 672)
, Tuple.Create(Tuple.Create("", 659), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 659), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.FromValue != null ? Model.FromValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'FromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 863), Tuple.Create("\'", 1032)
, Tuple.Create(Tuple.Create("", 871), Tuple.Create("position:", 871), true)
, Tuple.Create(Tuple.Create(" ", 880), Tuple.Create("absolute;", 881), true)
, Tuple.Create(Tuple.Create(" ", 890), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 891), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 934), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.FromOperator))
, 941), false)
, Tuple.Create(Tuple.Create("\t\t", 1005), Tuple.Create("</select>", 1007), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1016), Tuple.Create("<label", 1019), true)
, Tuple.Create(Tuple.Create(" ", 1025), Tuple.Create("class=", 1026), true)
);
WriteLiteral("IQLabel405512 ");
                            Write(!Model.EmailTo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#EmailToValue-Popover\" style=\'position:absolute;font-size:12px;te" +
"xt-align:right;left:5px;height:21px;width:120px;top:28px;\'>Email To:\r\n\t\t</label>" +
"<select multiple=\"multiple\"  ");
                                         Write(!Model.EmailTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.EmailTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("StaffAndDest/Callback/?fname=EmailTo");
WriteLiteral("\',$(this));\"  \r\n\t\t   name=\'EmailToValue\'  style=\'position: absolute; left:210px;h" +
"eight:21px;width:80px;top:28px;\'>\r\n");
             foreach(var itm in Model.EmailTo.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1660), Tuple.Create("\'", 1681)
, Tuple.Create(Tuple.Create("", 1668), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1668), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.EmailToValue != null ? Model.EmailToValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                              Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select class=\'form-control\' name=\'EmailToOperator\' style=\'position:" +
" absolute; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetComboOperators(Model.EmailToOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
