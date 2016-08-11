
	
public partial class Reporting_RptId : 
	DataFieldBase<int,Reporting>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Id";}
		set { } 
	}

	public string DFName=> "RptId";

	
	public Reporting_RptId(Reporting Parent) : 
		base(Parent, "RptId"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Reporting_RptIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptId").Any()) 
			return DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptId").First().Value(new Reporting());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 814;
	}
	public string GetControlName() {
		return "RptIdValue";
	}
	public string GetDFName() {
		return "RptId";
	}
	public string GetTitle() {
		return "Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Reporting ds;
					ds = (Reporting)dsI;
		 
		
		return ds.RptId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Reporting ds;
				ds = (Reporting)dsI;
		 

		string ctrl =  "[[Val]]";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RptId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RptId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RptId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RptId", "@RptId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RptId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Reporting").GetFieldOperators("RptId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

