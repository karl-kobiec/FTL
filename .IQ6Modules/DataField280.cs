
	
public partial class Week_WkSDate : 
	DateDataFieldBase<Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Week Start (Mon)";}
		set { } 
	}

	public string DFName=> "WkSDate";

	
	public Week_WkSDate(Week Parent) : 
		base(Parent, "WkSDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Week_WkSDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkSDate").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkSDate").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 280;
	}
	public string GetControlName() {
		return "WkSDateValue";
	}
	public string GetDFName() {
		return "WkSDate";
	}
	public string GetTitle() {
		return "Week Start (Mon)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkSDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkSDate/?RecId=[[RecId]]',$(this));\" data-bound-name='WkSDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkSDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkSDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkSDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkSDate", "@WkSDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkSDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkSDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

