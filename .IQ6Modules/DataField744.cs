
	
public partial class Staff_StfEM : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Email";}
		set { } 
	}

	public string DFName=> "StfEM";

	
	public Staff_StfEM(Staff Parent) : 
		base(Parent, "StfEM"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Staff_StfEMFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfEM").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfEM").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 744;
	}
	public string GetControlName() {
		return "StfEMValue";
	}
	public string GetDFName() {
		return "StfEM";
	}
	public string GetTitle() {
		return "Email";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfEM.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfEM/?RecId=[[RecId]]',$(this));\" data-bound-name='StfEM' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfEM.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfEM";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfEM")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfEM", "@StfEM", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfEM", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfEM", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

