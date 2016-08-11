
	
public partial class Country_CtryId : 
	FormattableDataFieldBase<int,Country>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country ID";}
		set { } 
	}

	public string DFName=> "CtryId";

	
	public Country_CtryId(Country Parent) : 
		base(Parent, "CtryId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Country_CtryIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryId").Any()) 
			return DS.GetManager<Country>().OnDataSource.Where(f=> f.Key == "CtryId").First().Value(new Country());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 421;
	}
	public string GetControlName() {
		return "CtryIdValue";
	}
	public string GetDFName() {
		return "CtryId";
	}
	public string GetTitle() {
		return "Country ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Country ds;
					ds = (Country)dsI;
		 
		
		return ds.CtryId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Country ds;
				ds = (Country)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Country/SaveCtryId/?RecId=[[RecId]]',$(this));\" data-bound-name='CtryId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CtryId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CtryId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CtryId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CtryId", "@CtryId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CtryId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Country").GetFieldOperators("CtryId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

