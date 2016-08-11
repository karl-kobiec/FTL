
	
public partial class Orders_OrdCollChanged : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collected Changed";}
		set { } 
	}

	public string DFName=> "OrdCollChanged";

	
	public Orders_OrdCollChanged(Orders Parent) : 
		base(Parent, "OrdCollChanged"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdCollChangedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollChanged").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollChanged").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 248;
	}
	public string GetControlName() {
		return "OrdCollChangedValue";
	}
	public string GetDFName() {
		return "OrdCollChanged";
	}
	public string GetTitle() {
		return "Collected Changed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollChanged.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollChanged/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCollChanged' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollChanged.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollChanged";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollChanged")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollChanged", "@OrdCollChanged", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollChanged", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollChanged", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

