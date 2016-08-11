
	
public partial class Country_CtryName : 
	DataFieldBase<string,Country>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country";}
		set { } 
	}

	public string DFName=> "CtryName";

	
	public Country_CtryName(Country Parent) : 
		base(Parent, "CtryName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Country_CtryNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryName").Any()) 
			return DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryName").First().Value(new Country());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 423;
	}
	public string GetControlName() {
		return "CtryNameValue";
	}
	public string GetDFName() {
		return "CtryName";
	}
	public string GetTitle() {
		return "Country";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Country ds;
					ds = (Country)dsI;
		 
		
		return ds.CtryName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Country ds;
				ds = (Country)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Country/SaveCtryName/?RecId=[[RecId]]',$(this));\" data-bound-name='CtryName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CtryName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CtryName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CtryName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CtryName", "@CtryName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CtryName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Country").GetFieldOperators("CtryName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

