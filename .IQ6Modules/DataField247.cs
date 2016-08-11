
	
public partial class Orders_OrdAvailChanged : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Available Changed";}
		set { } 
	}

	public string DFName=> "OrdAvailChanged";

	
	public Orders_OrdAvailChanged(Orders Parent) : 
		base(Parent, "OrdAvailChanged"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdAvailChangedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAvailChanged").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAvailChanged").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 247;
	}
	public string GetControlName() {
		return "OrdAvailChangedValue";
	}
	public string GetDFName() {
		return "OrdAvailChanged";
	}
	public string GetTitle() {
		return "Available Changed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdAvailChanged.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAvailChanged/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdAvailChanged' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdAvailChanged.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdAvailChanged";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdAvailChanged")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdAvailChanged", "@OrdAvailChanged", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdAvailChanged", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdAvailChanged", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

