
	
public partial class JobCost_JobCServProvId : 
	FormattableDataFieldBase<int,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Service Provider Id";}
		set { } 
	}

	public string DFName=> "JobCServProvId";

	
	public JobCost_JobCServProvId(JobCost Parent) : 
		base(Parent, "JobCServProvId"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class JobCost_JobCServProvIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProvId").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProvId").First().Value(new JobCost());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 164;
	}
	public string GetControlName() {
		return "JobCServProvIdValue";
	}
	public string GetDFName() {
		return "JobCServProvId";
	}
	public string GetTitle() {
		return "Service Provider Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCServProvId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCServProvId/?RecId=[[RecId]]',$(this));\" data-bound-name='JobCServProvId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCServProvId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCServProvId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCServProvId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCServProvId", "@JobCServProvId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCServProvId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCServProvId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

