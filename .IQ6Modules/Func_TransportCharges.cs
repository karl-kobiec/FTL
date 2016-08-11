
public class TransportCharges_FEType : 
	 SelectElementBase<string>
	{
	public TransportCharges_FEType() :base("TypeValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class TransportCharges_FEMonth : 
	 SelectElementBase<string>
	{
	public TransportCharges_FEMonth() :base("MonthValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}
public class TransportCharges_FEJobNo : 
	 ElementBase<string>{
	public TransportCharges_FEJobNo() :base("JobNoValue", ""
		)
	{
		Enabled = true;
	}
		
}

public class TransportChargesModel : ReportBase {
	public TransportChargesModel() {
					Type  = new TransportCharges_FEType();
					Month  = new TransportCharges_FEMonth();
					JobNo  = new TransportCharges_FEJobNo();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(Type);
					action(Month);
					action(JobNo);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<TransportChargesModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_TransportCharges_cshtml));
    }
	
				public TransportCharges_FEType Type  { get;set;}
	
	public string TypeValue { 
		get { return Type.DataValue;}
		set{ Type.Value = value; }
	}
			public TransportCharges_FEMonth Month  { get;set;}
	
	public string MonthValue { 
		get { return Month.DataValue;}
		set{ Month.Value = value; }
	}
			public TransportCharges_FEJobNo JobNo  { get;set;}
	
	public string JobNoValue { 
		get { return JobNo.DataValue;}
		set{ JobNo.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/TransportCharges.cshtml";
			}
}
public class TransportChargesController : ScreenController<TransportChargesModel> {
			public ActionResult AutoCompleteType(string q) {
			var mdl = new TransportChargesModel();
			SC.GetManager<TransportChargesModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Type.DataSource + ") IQD where [Description] like @query",
						new { query = q + "%"}).Select(f=> new { id = f.KeyValue, text= f.Description}),
				more = false } ;
		
			return Json(result);
		}
			public ActionResult AutoCompleteMonth(string q) {
			var mdl = new TransportChargesModel();
			SC.GetManager<TransportChargesModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Month.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/TransportCharges.cshtml")]
    public partial class IQ6_Views_TransportCharges_cshtml : System.Web.Mvc.WebViewPage<FTL.TransportChargesModel>
    {
        public IQ6_Views_TransportCharges_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "TransportCharges";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<TransportChargesModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/TransportCharges_TransportCharges.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/TransportCharges_TransportCharges.cshtml")]
    public partial class IQ6_Views_TransportCharges_TransportCharges_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_TransportCharges_TransportCharges_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 108)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel405811", 51), true)
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
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/TransportCharges/Callback/?fname=Type\'," +
"$(this));\"  \r\n\t\t   name=\'TypeValue\'  style=\'position: absolute; left:210px;heigh" +
"t:21px;width:80px;top:3px;\'>\r\n");
             foreach(var itm in Model.Type.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 655), Tuple.Create("\'", 676)
, Tuple.Create(Tuple.Create("", 663), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 663), false)
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
WriteAttribute("style", Tuple.Create(" style=\'", 867), Tuple.Create("\'", 1036)
, Tuple.Create(Tuple.Create("", 875), Tuple.Create("position:", 875), true)
, Tuple.Create(Tuple.Create(" ", 884), Tuple.Create("absolute;", 885), true)
, Tuple.Create(Tuple.Create(" ", 894), Tuple.Create("left:130px;height:21px;width:80px;top:3px;>", 895), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 938), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.TypeOperator))
, 945), false)
, Tuple.Create(Tuple.Create("\t\t", 1009), Tuple.Create("</select>", 1011), true)
, Tuple.Create(Tuple.Create("\r\n\t", 1020), Tuple.Create("<label", 1023), true)
, Tuple.Create(Tuple.Create(" ", 1029), Tuple.Create("class=", 1030), true)
);
WriteLiteral("IQLabel405812 ");
                            Write(!Model.Month.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#MonthValue-Popover\" style=\'position:absolute;font-size:12px;text" +
"-align:right;left:5px;height:21px;width:120px;top:28px;\'>Month:\r\n\t\t</label><sele" +
"ct multiple=\"multiple\"  ");
                                         Write(!Model.Month.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Month.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("TransportCharges/Callback/?fname=Month");
WriteLiteral("\',$(this));\"  \r\n\t\t   name=\'MonthValue\'  style=\'position: absolute; left:210px;hei" +
"ght:21px;width:80px;top:28px;\'>\r\n");
             foreach(var itm in Model.Month.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 1651), Tuple.Create("\'", 1672)
, Tuple.Create(Tuple.Create("", 1659), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 1659), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.MonthValue != null ? Model.MonthValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                          Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select class=\'form-control\' name=\'MonthOperator\' style=\'position: a" +
"bsolute; left:130px;height:21px;width:80px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetComboOperators(Model.MonthOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 2030), Tuple.Create("\'", 2096)
, Tuple.Create(Tuple.Create("", 2038), Tuple.Create("IQLabel405813", 2038), true)
, Tuple.Create(Tuple.Create(" ", 2051), Tuple.Create<System.Object, System.Int32>(!Model.JobNo.LabelVisible ? " hide " : ""
, 2052), false)
);
WriteLiteral("  data-target=\"#JobNoValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:53px;\'");
WriteLiteral(">Job No:\r\n\t\t</label><input ");
                   Write(!Model.JobNo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t\tclass=\'form-control  ");
                             Write(!Model.JobNo.Visible ? " hide " : "");
WriteLiteral("\' \r\n\t\t\tonchange=\"javascript:IQDirtyCallback(\'/TransportCharges/Callback/?fname=Jo" +
"bNo\',$(this));\" \r\n\t\t\ttype=\'text\' \r\n\t\t\tname=\'JobNoValue\' \r\n\t\t\tvalue=\'");
              Write(Model.JobNo.ValueFormatted);
WriteLiteral("\' \r\n\t\t\tstyle=\'position: absolute; left:210px;height:21px;width:80px;top:53px;\'/>\t" +
"\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'JobNoOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2683), Tuple.Create("", 2840)
, Tuple.Create(Tuple.Create("", 2691), Tuple.Create("position:", 2691), true)
, Tuple.Create(Tuple.Create(" ", 2700), Tuple.Create("absolute;", 2701), true)
, Tuple.Create(Tuple.Create(" ", 2710), Tuple.Create("left:130px;height:21px;width:80px;top:53px;>", 2711), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2755), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetTextOperators(Model.JobNoOperator))
, 2762), false)
, Tuple.Create(Tuple.Create("\t\t", 2826), Tuple.Create("</select>", 2828), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2837), Tuple.Create("", 2837), true)
);
        }
    }
}
 
