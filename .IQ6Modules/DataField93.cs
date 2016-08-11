
	
public partial class JobLine_JobLCollDate2 : 
	DateDataFieldBase<JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Date 2";}
		set { } 
	}

	public string DFName=> "JobLCollDate2";

	
	public JobLine_JobLCollDate2(JobLine Parent) : 
		base(Parent, "JobLCollDate2"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLCollDate2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCollDate2").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLCollDate2").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 93;
	}
	public string GetControlName() {
		return "JobLCollDate2Value";
	}
	public string GetDFName() {
		return "JobLCollDate2";
	}
	public string GetTitle() {
		return "Collection Date 2";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLCollDate2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLCollDate2/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='JobLCollDate2' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLCollDate2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLCollDate2";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLCollDate2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLCollDate2", "@JobLCollDate2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLCollDate2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLCollDate2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

