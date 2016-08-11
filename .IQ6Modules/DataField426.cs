
	
public partial class Week_WkSDateText : 
	DataFieldBase<string,Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Monday Text";}
		set { } 
	}

	public string DFName=> "WkSDateText";

	
	public Week_WkSDateText(Week Parent) : 
		base(Parent, "WkSDateText"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Week_WkSDateTextFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkSDateText").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkSDateText").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 426;
	}
	public string GetControlName() {
		return "WkSDateTextValue";
	}
	public string GetDFName() {
		return "WkSDateText";
	}
	public string GetTitle() {
		return "Monday Text";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkSDateText.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkSDateText/?RecId=[[RecId]]',$(this));\" data-bound-name='WkSDateText' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkSDateText.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkSDateText";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkSDateText")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkSDateText", "@WkSDateText", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkSDateText", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkSDateText", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

