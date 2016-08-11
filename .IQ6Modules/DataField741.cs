
	
public partial class Staff_StfName : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Name";}
		set { } 
	}

	public string DFName=> "StfName";

	
	public Staff_StfName(Staff Parent) : 
		base(Parent, "StfName"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Staff_StfNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfName").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfName").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 741;
	}
	public string GetControlName() {
		return "StfNameValue";
	}
	public string GetDFName() {
		return "StfName";
	}
	public string GetTitle() {
		return "Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfName/?RecId=[[RecId]]',$(this));\" data-bound-name='StfName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfName", "@StfName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

