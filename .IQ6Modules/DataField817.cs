
	
public partial class Reporting_RptDataset : 
	DataFieldBase<string,Reporting>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "New Field";}
		set { } 
	}

	public string DFName=> "RptDataset";

	
	public Reporting_RptDataset(Reporting Parent) : 
		base(Parent, "RptDataset"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Reporting_RptDatasetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptDataset").Any()) 
			return DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptDataset").First().Value(new Reporting());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 817;
	}
	public string GetControlName() {
		return "RptDatasetValue";
	}
	public string GetDFName() {
		return "RptDataset";
	}
	public string GetTitle() {
		return "New Field";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Reporting ds;
					ds = (Reporting)dsI;
		 
		
		return ds.RptDataset.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Reporting ds;
				ds = (Reporting)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Reporting/SaveRptDataset/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='RptDataset'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RptDataset.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RptDataset";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RptDataset")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RptDataset", "@RptDataset", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RptDataset", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Reporting").GetFieldOperators("RptDataset", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

