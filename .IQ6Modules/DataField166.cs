
	
public partial class JobCost_JobCDesc : 
	DataFieldBase<string,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description";}
		set { } 
	}

	public string DFName=> "JobCDesc";

	
	public JobCost_JobCDesc(JobCost Parent) : 
		base(Parent, "JobCDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobCost_JobCDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCDesc").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCDesc").First().Value(new JobCost());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 166;
	}
	public string GetControlName() {
		return "JobCDescValue";
	}
	public string GetDFName() {
		return "JobCDesc";
	}
	public string GetTitle() {
		return "Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCDesc/?RecId=[[RecId]]',$(this));\" data-bound-name='JobCDesc' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCDesc", "@JobCDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

