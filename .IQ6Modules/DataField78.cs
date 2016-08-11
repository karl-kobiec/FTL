
	
public partial class Job_JobTranspRate : 
	DataFieldBase<string,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Transporter Rate";}
		set { } 
	}

	public string DFName=> "JobTranspRate";

	
	public Job_JobTranspRate(Job Parent) : 
		base(Parent, "JobTranspRate"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobTranspRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTranspRate").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTranspRate").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 78;
	}
	public string GetControlName() {
		return "JobTranspRateValue";
	}
	public string GetDFName() {
		return "JobTranspRate";
	}
	public string GetTitle() {
		return "Transporter Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobTranspRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobTranspRate/?RecId=[[RecId]]',$(this));\" data-bound-name='JobTranspRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobTranspRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobTranspRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobTranspRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobTranspRate", "@JobTranspRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobTranspRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobTranspRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

