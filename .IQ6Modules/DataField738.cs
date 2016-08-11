
	
public partial class Staff_StfId : 
	DataFieldBase<int,Staff>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Id";}
		set { } 
	}

	public string DFName=> "StfId";

	
	public Staff_StfId(Staff Parent) : 
		base(Parent, "StfId"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Staff_StfIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfId").Any()) 
			return DS.GetManager<Staff>().OnDataSource.Where(f=> f.Key == "StfId").First().Value(new Staff());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 738;
	}
	public string GetControlName() {
		return "StfIdValue";
	}
	public string GetDFName() {
		return "StfId";
	}
	public string GetTitle() {
		return "Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Staff ds;
					ds = (Staff)dsI;
		 
		
		return ds.StfId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Staff ds;
				ds = (Staff)dsI;
		 

		string ctrl =  "[[Val]]";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.StfId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "StfId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "StfId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "StfId", "@StfId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "StfId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Staff").GetFieldOperators("StfId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

