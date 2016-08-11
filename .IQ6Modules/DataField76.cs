
	
public partial class Job_JobNo : 
	DataFieldBase<string,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Number";}
		set { } 
	}

	public string DFName=> "JobNo";

	
	public Job_JobNo(Job Parent) : 
		base(Parent, "JobNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobNo").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobNo").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 76;
	}
	public string GetControlName() {
		return "JobNoValue";
	}
	public string GetDFName() {
		return "JobNo";
	}
	public string GetTitle() {
		return "Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobNo/?RecId=[[RecId]]',$(this));\" data-bound-name='JobNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobNo", "@JobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

