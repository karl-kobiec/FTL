
	
public partial class JobCost_JobCInvNo : 
	DataFieldBase<string,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Number";}
		set { } 
	}

	public string DFName=> "JobCInvNo";

	
	public JobCost_JobCInvNo(JobCost Parent) : 
		base(Parent, "JobCInvNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobCost_JobCInvNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvNo").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvNo").First().Value(new JobCost());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 168;
	}
	public string GetControlName() {
		return "JobCInvNoValue";
	}
	public string GetDFName() {
		return "JobCInvNo";
	}
	public string GetTitle() {
		return "Invoice Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCInvNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvNo/?RecId=[[RecId]]',$(this));\" data-bound-name='JobCInvNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCInvNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCInvNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCInvNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCInvNo", "@JobCInvNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCInvNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCInvNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

