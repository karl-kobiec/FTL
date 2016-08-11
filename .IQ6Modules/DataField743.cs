
	
public partial class Staff_StfPassword : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Password";}
		set { } 
	}

	public string DFName=> "StfPassword";

	
	public Staff_StfPassword(Staff Parent) : 
		base(Parent, "StfPassword"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Staff_StfPasswordFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfPassword").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfPassword").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 743;
	}
	public string GetControlName() {
		return "StfPasswordValue";
	}
	public string GetDFName() {
		return "StfPassword";
	}
	public string GetTitle() {
		return "Password";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfPassword.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfPassword/?RecId=[[RecId]]',$(this));\" data-bound-name='StfPassword' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfPassword.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfPassword";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfPassword")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfPassword", "@StfPassword", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfPassword", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfPassword", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

