
	
public partial class JobCost_JobCInvDate : 
	DateDataFieldBase<JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Date";}
		set { } 
	}

	public string DFName=> "JobCInvDate";

	
	public JobCost_JobCInvDate(JobCost Parent) : 
		base(Parent, "JobCInvDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class JobCost_JobCInvDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvDate").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvDate").First().Value(new JobCost());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 169;
	}
	public string GetControlName() {
		return "JobCInvDateValue";
	}
	public string GetDFName() {
		return "JobCInvDate";
	}
	public string GetTitle() {
		return "Invoice Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCInvDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='JobCInvDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCInvDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCInvDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCInvDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCInvDate", "@JobCInvDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCInvDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCInvDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

