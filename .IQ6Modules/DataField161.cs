
	
public partial class JobLine_JobLDelRef : 
	DataFieldBase<string,JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Ref";}
		set { } 
	}

	public string DFName=> "JobLDelRef";

	
	public JobLine_JobLDelRef(JobLine Parent) : 
		base(Parent, "JobLDelRef"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobLine_JobLDelRefFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelRef").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelRef").First().Value(new JobLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 161;
	}
	public string GetControlName() {
		return "JobLDelRefValue";
	}
	public string GetDFName() {
		return "JobLDelRef";
	}
	public string GetTitle() {
		return "Delivery Ref";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLDelRef.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelRef/?RecId=[[RecId]]',$(this));\" data-bound-name='JobLDelRef' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLDelRef.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLDelRef";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobLDelRef")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLDelRef", "@JobLDelRef", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLDelRef", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLDelRef", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

