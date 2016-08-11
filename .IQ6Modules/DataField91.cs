
	
public partial class JobLine_JobLCust : 
	DataFieldBase<string,JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Customer";}
		set { } 
	}

	public string DFName=> "JobLCust";

	
	public JobLine_JobLCust(JobLine Parent) : 
		base(Parent, "JobLCust"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLCustFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCust").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCust").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 91;
	}
	public string GetControlName() {
		return "JobLCustValue";
	}
	public string GetDFName() {
		return "JobLCust";
	}
	public string GetTitle() {
		return "Customer";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLCust.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCust/?RecId=[[RecId]]',$(this));\" data-bound-name='JobLCust' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLCust.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLCust";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLCust")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLCust", "@JobLCust", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLCust", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLCust", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

