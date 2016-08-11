
	
public partial class Orders_OrdReqdChanged : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Reqd Changed";}
		set { } 
	}

	public string DFName=> "OrdReqdChanged";

	
	public Orders_OrdReqdChanged(Orders Parent) : 
		base(Parent, "OrdReqdChanged"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdReqdChangedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdReqdChanged").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdReqdChanged").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 246;
	}
	public string GetControlName() {
		return "OrdReqdChangedValue";
	}
	public string GetDFName() {
		return "OrdReqdChanged";
	}
	public string GetTitle() {
		return "Reqd Changed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdReqdChanged.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdReqdChanged/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdReqdChanged' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdReqdChanged.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdReqdChanged";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdReqdChanged")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdReqdChanged", "@OrdReqdChanged", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdReqdChanged", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdReqdChanged", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

