
public class HM2Form_FEDateFrom : 
	 DateElementBase
	{
	public HM2Form_FEDateFrom() :base("DateFromValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class HM2Form_FEDateTo : 
	 DateElementBase
	{
	public HM2Form_FEDateTo() :base("DateToValue", ""
		)
	{
		Enabled = true;
	}
		
}
public class HM2Form_FESelection : 
	 SelectElementBase<string>
	{
	public HM2Form_FESelection() :base("SelectionValue", ""
		,"")
	{
		Enabled = true;
	}
		public override string GetDataSource() => DataSource;
		
}

public class HM2FormModel : ReportBase {
	public HM2FormModel() {
					DateFrom  = new HM2Form_FEDateFrom();
					DateTo  = new HM2Form_FEDateTo();
					Selection  = new HM2Form_FESelection();
			}
	public override void ForEachElement(Action<IElementBase> action) {
					action(DateFrom);
					action(DateTo);
					action(Selection);
			}
	
		public override string ExecuteView()
	{
        SC.GetManager<HM2FormModel>().OnLoad.ForEach(f => f(this));
        return WebUtil.GetView(this,GetView(), 
		typeof (FTL.ASP.IQ6_Views_HM2Form_cshtml));
    }
	
				public HM2Form_FEDateFrom DateFrom  { get;set;}
	
	public DateTime DateFromValue { 
		get { return DateFrom.DataValue;}
		set{ DateFrom.Value = value; }
	}
			public HM2Form_FEDateTo DateTo  { get;set;}
	
	public DateTime DateToValue { 
		get { return DateTo.DataValue;}
		set{ DateTo.Value = value; }
	}
			public HM2Form_FESelection Selection  { get;set;}
	
	public string SelectionValue { 
		get { return Selection.DataValue;}
		set{ Selection.Value = value; }
	}
		public override string GetView() {
				return "~/IQ6/Views/HM2Form.cshtml";
			}
}
public class HM2FormController : ScreenController<HM2FormModel> {
			public ActionResult AutoCompleteSelection(string q) {
			var mdl = new HM2FormModel();
			SC.GetManager<HM2FormModel>().OnLoad.ForEach(g=> g(mdl));
			
			var result = new {
					results = IQApp.DB.Load<Pair<string, string>>(
					"select * from (" + mdl.Selection.DataSource + ") IQD where [Description] like @query",
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/HM2Form.cshtml")]
    public partial class IQ6_Views_HM2Form_cshtml : System.Web.Mvc.WebViewPage<FTL.HM2FormModel>
    {
        public IQ6_Views_HM2Form_cshtml()
        {
        }
        public override void Execute()
        {
	ViewBag.Title = "HM2Form";
WriteLiteral("\r\n");
WriteLiteral("<div");
WriteLiteral(" class=\"btn-toolbar\"");
WriteLiteral(" role=\"toolbar\"");
WriteLiteral(" >\r\n\t<div");
WriteLiteral(" class=\"btn-group\"");
WriteLiteral(" role=\"group\"");
WriteLiteral(">\r\n");
         foreach(var itm in SC.GetManager<HM2FormModel>().OnDrawSingleToolbar) {
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
				Html.RenderPartial("~/IQ6/Views/HM2Form_HM2Form.cshtml", Model);
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
    [System.Web.WebPages.PageVirtualPathAttribute("~/IQ6/Views/HM2Form_HM2Form.cshtml")]
    public partial class IQ6_Views_HM2Form_HM2Form_cshtml : IQ6.Core.IQWebPageView<dynamic>
    {
        public IQ6_Views_HM2Form_HM2Form_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("\r\n<label");
WriteAttribute("class", Tuple.Create(" class=\'", 43), Tuple.Create("\'", 112)
, Tuple.Create(Tuple.Create("", 51), Tuple.Create("IQLabel407611", 51), true)
, Tuple.Create(Tuple.Create(" ", 64), Tuple.Create<System.Object, System.Int32>(!Model.DateFrom.LabelVisible ? " hide " : ""
, 65), false)
);
WriteLiteral("  data-target=\"#DateFromValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:3px;\'");
WriteLiteral(">Date From:\r\n\t\t</label><input   ");
                     Write(!Model.DateFrom.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateFrom.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/HM2Form/Callback/?fname=DateFrom\',$(thi" +
"s));\"  type=\'text\' name=\'DateFromValue\' value=\'");
                                                                                                                                                                                                                                              Write(Model.DateFrom.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:3px;\'/>\t\t<sele" +
"ct");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'DateFromOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 734), Tuple.Create("\'", 908)
, Tuple.Create(Tuple.Create("", 742), Tuple.Create("position:", 742), true)
, Tuple.Create(Tuple.Create(" ", 751), Tuple.Create("absolute;", 752), true)
, Tuple.Create(Tuple.Create(" ", 761), Tuple.Create("left:130px;height:21px;width:57px;top:3px;>", 762), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 805), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateFromOperator))
, 812), false)
, Tuple.Create(Tuple.Create("\t\t", 881), Tuple.Create("</select>", 883), true)
, Tuple.Create(Tuple.Create("\r\n\t", 892), Tuple.Create("<label", 895), true)
, Tuple.Create(Tuple.Create(" ", 901), Tuple.Create("class=", 902), true)
);
WriteLiteral("IQLabel407612 ");
                            Write(!Model.DateTo.LabelVisible ? " hide " : "");
WriteLiteral("\'  data-target=\"#DateToValue-Popover\" style=\'position:absolute;font-size:12px;tex" +
"t-align:right;left:5px;height:21px;width:120px;top:28px;\'>Date To:\r\n\t\t</label><i" +
"nput   ");
                     Write(!Model.DateTo.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\tdata-date-format=\'ddd DD-MMM-YYYY\' class=\'form-control dateBox   ");
                                                                     Write(!Model.DateTo.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/");
WriteLiteral("HM2Form/Callback/?fname=DateTo");
WriteLiteral("\',$(this));\"  type=\'text\' name=\'DateToValue\' value=\'");
                                                                                                                                                                                                                                        Write(Model.DateTo.ValueFormatted);
WriteLiteral("\' style=\'position: absolute; left:187px;height:21px;width:57px;top:28px;\'/>\t\t<sel" +
"ect class=\'form-control\' name=\'DateToOperator\' style=\'position: absolute; left:1" +
"30px;height:21px;width:57px;top:28px;>\r\n");
WriteLiteral("\t\t\t\t\t");
               Write(Html.Raw(IQApp.Operators.GetNumberOperators(Model.DateToOperator)));
WriteLiteral("\t\t</select>\r\n\t<label");
WriteAttribute("class", Tuple.Create(" class=\'", 1742), Tuple.Create("\'", 1812)
, Tuple.Create(Tuple.Create("", 1750), Tuple.Create("IQLabel407613", 1750), true)
, Tuple.Create(Tuple.Create(" ", 1763), Tuple.Create<System.Object, System.Int32>(!Model.Selection.LabelVisible ? " hide " : ""
, 1764), false)
);
WriteLiteral("  data-target=\"#SelectionValue-Popover\"");
WriteLiteral(" style=\'position:absolute;font-size:12px;text-align:right;left:5px;height:21px;wi" +
"dth:120px;top:53px;\'");
WriteLiteral(">Selection:\r\n\t\t</label><select");
WriteLiteral(" multiple=\"multiple\"");
WriteLiteral("  ");
                                         Write(!Model.Selection.Enabled ? "disabled=disabled" : "");
WriteLiteral(" \r\n\t\t class=\'form-control  \r\n");
WriteLiteral("\t\t  ");
      Write(!Model.Selection.Visible ? " hide " : "");
WriteLiteral("\'  onchange=\"javascript:IQDirtyCallback(\'/HM2Form/Callback/?fname=Selection\',$(th" +
"is));\"  \r\n\t\t   name=\'SelectionValue\'  style=\'position: absolute; left:210px;heig" +
"ht:21px;width:80px;top:53px;\'>\r\n");
             foreach(var itm in Model.Selection.Data) {
WriteLiteral("\t\t\t\t<option");
WriteAttribute("value", Tuple.Create(" value=\'", 2387), Tuple.Create("\'", 2408)
, Tuple.Create(Tuple.Create("", 2395), Tuple.Create<System.Object, System.Int32>(itm.KeyValue
, 2395), false)
);
WriteLiteral(" ");
                                          Write(itm.KeyValue == (Model.SelectionValue != null ? Model.SelectionValue : "") ? "selected=selected" : "");
WriteLiteral(">");
                                                                                                                                                  Write(itm.Description);
WriteLiteral("</option>\r\n");
			}
WriteLiteral("\t\t</select>\t\t<select");
WriteLiteral(" class=\'form-control\'");
WriteLiteral(" name=\'SelectionOperator\'");
WriteAttribute("style", Tuple.Create(" style=\'", 2614), Tuple.Create("", 2776)
, Tuple.Create(Tuple.Create("", 2622), Tuple.Create("position:", 2622), true)
, Tuple.Create(Tuple.Create(" ", 2631), Tuple.Create("absolute;", 2632), true)
, Tuple.Create(Tuple.Create(" ", 2641), Tuple.Create("left:130px;height:21px;width:80px;top:53px;>", 2642), true)
, Tuple.Create(Tuple.Create("\r\n\t\t\t\t\t", 2686), Tuple.Create<System.Object, System.Int32>(Html.Raw(IQApp.Operators.GetComboOperators(Model.SelectionOperator))
, 2693), false)
, Tuple.Create(Tuple.Create("\t\t", 2762), Tuple.Create("</select>", 2764), true)
, Tuple.Create(Tuple.Create("\r\n\t", 2773), Tuple.Create("", 2773), true)
);
        }
    }
}
 
