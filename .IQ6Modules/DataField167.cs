
	
public partial class JobCost_JobCInvAmt : 
	FormattableDataFieldBase<double,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Amount";}
		set { } 
	}

	public string DFName=> "JobCInvAmt";

	
	public JobCost_JobCInvAmt(JobCost Parent) : 
		base(Parent, "JobCInvAmt"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class JobCost_JobCInvAmtFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvAmt").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCInvAmt").First().Value(new JobCost());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 167;
	}
	public string GetControlName() {
		return "JobCInvAmtValue";
	}
	public string GetDFName() {
		return "JobCInvAmt";
	}
	public string GetTitle() {
		return "Invoice Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCInvAmt.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCInvAmt/?RecId=[[RecId]]',$(this));\" data-bound-name='JobCInvAmt' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCInvAmt.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCInvAmt";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCInvAmt")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCInvAmt", "@JobCInvAmt", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCInvAmt", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCInvAmt", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

