
	
public partial class Job_JobFerryTime : 
	TimeDataFieldBase<Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Time";}
		set { } 
	}

	public string DFName=> "JobFerryTime";

	
	public Job_JobFerryTime(Job Parent) : 
		base(Parent, "JobFerryTime"
			,"HH:mm"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobFerryTimeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryTime").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryTime").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 83;
	}
	public string GetControlName() {
		return "JobFerryTimeValue";
	}
	public string GetDFName() {
		return "JobFerryTime";
	}
	public string GetTitle() {
		return "Ferry Time";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobFerryTime.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryTime/?RecId=[[RecId]]',$(this));\" data-bound-name='JobFerryTime' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobFerryTime.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobFerryTime";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobFerryTime")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobFerryTime", "@JobFerryTime", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobFerryTime", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobFerryTime", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

