
	
public partial class OrderLine_OrdLWeight : 
	FormattableDataFieldBase<int,OrderLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Weight";}
		set { } 
	}

	public string DFName=> "OrdLWeight";

	
	public OrderLine_OrdLWeight(OrderLine Parent) : 
		base(Parent, "OrdLWeight"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class OrderLine_OrdLWeightFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLWeight").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLWeight").First().Value(new OrderLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 73;
	}
	public string GetControlName() {
		return "OrdLWeightValue";
	}
	public string GetDFName() {
		return "OrdLWeight";
	}
	public string GetTitle() {
		return "Weight";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		OrderLine ds;
					ds = (OrderLine)dsI;
		 
		
		return ds.OrdLWeight.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		OrderLine ds;
				ds = (OrderLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLWeight/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdLWeight' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdLWeight.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdLWeight";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdLWeight")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdLWeight", "@OrdLWeight", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdLWeight", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("OrderLine").GetFieldOperators("OrdLWeight", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

