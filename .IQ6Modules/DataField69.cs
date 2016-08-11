
	
public partial class OrderLine_OrdLQty : 
	FormattableDataFieldBase<int,OrderLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Quantity";}
		set { } 
	}

	public string DFName=> "OrdLQty";

	
	public OrderLine_OrdLQty(OrderLine Parent) : 
		base(Parent, "OrdLQty"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class OrderLine_OrdLQtyFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLQty").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLQty").First().Value(new OrderLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 69;
	}
	public string GetControlName() {
		return "OrdLQtyValue";
	}
	public string GetDFName() {
		return "OrdLQty";
	}
	public string GetTitle() {
		return "Quantity";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		OrderLine ds;
					ds = (OrderLine)dsI;
		 
		
		return ds.OrdLQty.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		OrderLine ds;
				ds = (OrderLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLQty/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdLQty' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdLQty.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdLQty";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdLQty")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdLQty", "@OrdLQty", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdLQty", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("OrderLine").GetFieldOperators("OrdLQty", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

