
	
public partial class JobLine_JobLLineLetter : 
	DataFieldBase<string,JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Letter";}
		set { } 
	}

	public string DFName=> "JobLLineLetter";

	
	public JobLine_JobLLineLetter(JobLine Parent) : 
		base(Parent, "JobLLineLetter"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLLineLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLLineLetter").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLLineLetter").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 89;
	}
	public string GetControlName() {
		return "JobLLineLetterValue";
	}
	public string GetDFName() {
		return "JobLLineLetter";
	}
	public string GetTitle() {
		return "Line Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLLineLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLLineLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='JobLLineLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLLineLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLLineLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLLineLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLLineLetter", "@JobLLineLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLLineLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLLineLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

