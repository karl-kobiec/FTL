
	
public partial class Staff_StfFN : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Forename";}
		set { } 
	}

	public string DFName=> "StfFN";

	
	public Staff_StfFN(Staff Parent) : 
		base(Parent, "StfFN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Staff_StfFNFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfFN").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfFN").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 739;
	}
	public string GetControlName() {
		return "StfFNValue";
	}
	public string GetDFName() {
		return "StfFN";
	}
	public string GetTitle() {
		return "Forename";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfFN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfFN/?RecId=[[RecId]]',$(this));\" data-bound-name='StfFN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfFN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfFN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfFN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfFN", "@StfFN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfFN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfFN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

