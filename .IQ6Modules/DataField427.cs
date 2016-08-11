
	
public partial class Week_WkEDateText : 
	DataFieldBase<string,Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sunday Text";}
		set { } 
	}

	public string DFName=> "WkEDateText";

	
	public Week_WkEDateText(Week Parent) : 
		base(Parent, "WkEDateText"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Week_WkEDateTextFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkEDateText").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkEDateText").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 427;
	}
	public string GetControlName() {
		return "WkEDateTextValue";
	}
	public string GetDFName() {
		return "WkEDateText";
	}
	public string GetTitle() {
		return "Sunday Text";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkEDateText.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkEDateText/?RecId=[[RecId]]',$(this));\" data-bound-name='WkEDateText' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkEDateText.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkEDateText";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkEDateText")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkEDateText", "@WkEDateText", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkEDateText", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkEDateText", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

