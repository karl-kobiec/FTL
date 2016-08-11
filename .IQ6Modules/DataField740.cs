
	
public partial class Staff_StfSN : 
	DataFieldBase<string,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Surname";}
		set { } 
	}

	public string DFName=> "StfSN";

	
	public Staff_StfSN(Staff Parent) : 
		base(Parent, "StfSN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Staff_StfSNFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSN").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfSN").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 740;
	}
	public string GetControlName() {
		return "StfSNValue";
	}
	public string GetDFName() {
		return "StfSN";
	}
	public string GetTitle() {
		return "Surname";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfSN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Staff/SaveStfSN/?RecId=[[RecId]]',$(this));\" data-bound-name='StfSN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfSN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfSN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfSN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfSN", "@StfSN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfSN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfSN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

