
	
public partial class Staff_StfUsername : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Username";}
		set { } 
	}

	public string DFName=> "StfUsername";

	
	public Staff_StfUsername(Staff Parent) : 
		base(Parent, "StfUsername"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Staff_StfUsernameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfUsername").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfUsername").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 742;
	}
	public string GetControlName() {
		return "StfUsernameValue";
	}
	public string GetDFName() {
		return "StfUsername";
	}
	public string GetTitle() {
		return "Username";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfUsername.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfUsername/?RecId=[[RecId]]',$(this));\" data-bound-name='StfUsername' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfUsername.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfUsername";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfUsername")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfUsername", "@StfUsername", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfUsername", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfUsername", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

