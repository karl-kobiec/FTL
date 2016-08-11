
	
public partial class Week_WkEDate : 
	DateDataFieldBase<Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Week End (Sun)";}
		set { } 
	}

	public string DFName=> "WkEDate";

	
	public Week_WkEDate(Week Parent) : 
		base(Parent, "WkEDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Week_WkEDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkEDate").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkEDate").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 281;
	}
	public string GetControlName() {
		return "WkEDateValue";
	}
	public string GetDFName() {
		return "WkEDate";
	}
	public string GetTitle() {
		return "Week End (Sun)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkEDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkEDate/?RecId=[[RecId]]',$(this));\" data-bound-name='WkEDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkEDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkEDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkEDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkEDate", "@WkEDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkEDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkEDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

