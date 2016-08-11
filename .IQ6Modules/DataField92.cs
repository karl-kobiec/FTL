
	
public partial class JobLine_JobLCollDate : 
	DateDataFieldBase<JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Date";}
		set { } 
	}

	public string DFName=> "JobLCollDate";

	
	public JobLine_JobLCollDate(JobLine Parent) : 
		base(Parent, "JobLCollDate"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLCollDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCollDate").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCollDate").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 92;
	}
	public string GetControlName() {
		return "JobLCollDateValue";
	}
	public string GetDFName() {
		return "JobLCollDate";
	}
	public string GetTitle() {
		return "Collection Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLCollDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCollDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='JobLCollDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLCollDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLCollDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLCollDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLCollDate", "@JobLCollDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLCollDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLCollDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

