
	
public partial class Job_JobFerryDate : 
	DateDataFieldBase<Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Date";}
		set { } 
	}

	public string DFName=> "JobFerryDate";

	
	public Job_JobFerryDate(Job Parent) : 
		base(Parent, "JobFerryDate"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobFerryDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryDate").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryDate").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 82;
	}
	public string GetControlName() {
		return "JobFerryDateValue";
	}
	public string GetDFName() {
		return "JobFerryDate";
	}
	public string GetTitle() {
		return "Ferry Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobFerryDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='JobFerryDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobFerryDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobFerryDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobFerryDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobFerryDate", "@JobFerryDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobFerryDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobFerryDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

