
	
public partial class Job_JobFerryName : 
	DataFieldBase<string,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Name";}
		set { } 
	}

	public string DFName=> "JobFerryName";

	
	public Job_JobFerryName(Job Parent) : 
		base(Parent, "JobFerryName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobFerryNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryName").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobFerryName").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 81;
	}
	public string GetControlName() {
		return "JobFerryNameValue";
	}
	public string GetDFName() {
		return "JobFerryName";
	}
	public string GetTitle() {
		return "Ferry Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobFerryName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobFerryName/?RecId=[[RecId]]',$(this));\" data-bound-name='JobFerryName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobFerryName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobFerryName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobFerryName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobFerryName", "@JobFerryName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobFerryName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobFerryName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

