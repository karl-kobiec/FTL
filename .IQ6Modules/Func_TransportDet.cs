
public class TransportDet_FEStaff : 
	 SelectElementBase<string>
	{
	public TransportDet_FEStaff() :base("StaffValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class TransportDet_FEType : 
	 SelectElementBase<string>
	{
	public TransportDet_FEType() :base("TypeValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class TransportDetModel : ReportBase {
	public TransportDetModel() {
					Staff  = new TransportDet_FEStaff();
					Type  = new TransportDet_FEType();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Staff);
					action(Type);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<TransportDetModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_TransportDet_cshtml));
    }
	
				public TransportDet_FEStaff Staff  { get;set;}
	
	public string StaffValue { 
		get { return Staff.DataValue;}
		set{ Staff.Value = value; }
	}
			public TransportDet_FEType Type  { get;set;}
	
	public string TypeValue { 
		get { return Type.DataValue;}
		set{ Type.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/TransportDet.cshtml";
			}
}
public class TransportDetController : ScreenController<TransportDetModel> {
			public ActionResult AutoCompleteStaff(string q) {
			var mdl = new TransportDetModel();
			SC.GetManager<TransportDetModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Staff.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
		}
			public ActionResult AutoCompleteType(string q) {
			var mdl = new TransportDetModel();
			SC.GetManager<TransportDetModel>().OnLoad.ForEach(g=> g(mdl));
			
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/TransportDet.cshtml")]
    public partial class IQ6_Views_TransportDet_cshtml : System.Web.Mvc.WebViewPage<FTL.TransportDetModel>
    {
        public IQ6_Views_TransportDet_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "TransportDet";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<TransportDetModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/TransportDet_TransportDet.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/TransportDet_TransportDet.cshtml")]
    public partial class IQ6_Views_TransportDet_TransportDet_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_TransportDet_TransportDet_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 109)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel405711", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.Staff.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#StaffValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Staff:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Staff.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Staff.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/TransportDet/Callback/?fname=Staff\',$(t" +
"his));\"  \r\n\t\t   name=\'StaffValue\'  style=\'position: absolute; left:210px;height:" +
"21px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Staff.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 659), Tuple.Create("\'", 680)
, Tuple.Create(Tuple.Create("", 667), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 667), false)
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
WriteAttribute("style", Tuple.Create(" style=\'", 874), Tuple.Create("\'", 1044)
, Tuple.Create(Tuple.Create("", 882), Tuple.Create("position:", 882), true)
, Tuple.Create(Tuple.Create(" ", 891), Tuple.Create("absolute;", 892), true)
, Tuple.Create(Tuple.Create(" ", 901), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 902), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 945), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.StaffOperator))
, 952), false)
, Tuple.Create(Tuple.Create("\t\t", 1017), Tuple.Create("</select>", 1019), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1028), Tuple.Create("<label", 1031), true)
, Tuple.Create(Tuple.Create(" ", 1037), Tuple.Create("class=", 1038), true)
);
WriteLiteral("IQLabel405712 ");
                            Write(!Model.Type.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#TypeValue-Popover\" style=\'position:absolute;font-size:12px;text-" +
"align:right;left:5px;height:21px;width:120px;top:28px;\'>Type:\r\n\t\t</label><select" +
" multiple=\"multiple\"  ");
                                         Write(!Model.Type.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Type.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("TransportDet/Callback/?fname=Type");
WriteLiteral("\',$(this));\"  \r\n\t\t   name=\'TypeValue\'  style=\'position: absolute; left:210px;heig" +
"ht:21px;width:80px;top:28px;\'>\r\n");
             foreach(var itm in Model.Type.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1647), Tuple.Create("\'", 1668)
, Tuple.Create(Tuple.Create("", 1655), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1655), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.TypeValue != null ? Model.TypeValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                        Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select class=\'form-control\' name=\'TypeOperator\' style=\'position: ab" +
"solute; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetComboOperators(Model.TypeOperator)));
WriteLiteral("\t\t</select>\r\n\t");
        }
    }
}
 
