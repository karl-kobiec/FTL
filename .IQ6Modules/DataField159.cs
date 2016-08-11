
	
public partial class JobLine_JobLDelDate : 
	DateDataFieldBase<JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Date";}
		set { } 
	}

	public string DFName=> "JobLDelDate";

	
	public JobLine_JobLDelDate(JobLine Parent) : 
		base(Parent, "JobLDelDate"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLDelDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelDate").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelDate").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 159;
	}
	public string GetControlName() {
		return "JobLDelDateValue";
	}
	public string GetDFName() {
		return "JobLDelDate";
	}
	public string GetTitle() {
		return "Delivery Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLDelDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='JobLDelDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLDelDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLDelDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLDelDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLDelDate", "@JobLDelDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLDelDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLDelDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

