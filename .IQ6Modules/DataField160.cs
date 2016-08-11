
	
public partial class JobLine_JobLDelTime : 
	TimeDataFieldBase<JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Time";}
		set { } 
	}

	public string DFName=> "JobLDelTime";

	
	public JobLine_JobLDelTime(JobLine Parent) : 
		base(Parent, "JobLDelTime"
			,"HH:mm"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLDelTimeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelTime").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelTime").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 160;
	}
	public string GetControlName() {
		return "JobLDelTimeValue";
	}
	public string GetDFName() {
		return "JobLDelTime";
	}
	public string GetTitle() {
		return "Delivery Time";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLDelTime.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelTime/?RecId=[[RecId]]',$(this));\" data-bound-name='JobLDelTime' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLDelTime.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLDelTime";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLDelTime")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLDelTime", "@JobLDelTime", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLDelTime", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLDelTime", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

