
	
public partial class Country_CtryCode : 
	DataFieldBase<string,Country>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country Code";}
		set { } 
	}

	public string DFName=> "CtryCode";

	
	public Country_CtryCode(Country Parent) : 
		base(Parent, "CtryCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Country_CtryCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryCode").Any()) 
			return DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryCode").First().Value(new Country());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 422;
	}
	public string GetControlName() {
		return "CtryCodeValue";
	}
	public string GetDFName() {
		return "CtryCode";
	}
	public string GetTitle() {
		return "Country Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Country ds;
					ds = (Country)dsI;
		 
		
		return ds.CtryCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Country ds;
				ds = (Country)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Country/SaveCtryCode/?RecId=[[RecId]]',$(this));\" data-bound-name='CtryCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CtryCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CtryCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CtryCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CtryCode", "@CtryCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CtryCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Country").GetFieldOperators("CtryCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

