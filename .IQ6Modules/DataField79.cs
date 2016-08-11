
	
public partial class Job_JobVehNo : 
	DataFieldBase<string,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Vehicle Number";}
		set { } 
	}

	public string DFName=> "JobVehNo";

	
	public Job_JobVehNo(Job Parent) : 
		base(Parent, "JobVehNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobVehNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobVehNo").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobVehNo").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 79;
	}
	public string GetControlName() {
		return "JobVehNoValue";
	}
	public string GetDFName() {
		return "JobVehNo";
	}
	public string GetTitle() {
		return "Vehicle Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobVehNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobVehNo/?RecId=[[RecId]]',$(this));\" data-bound-name='JobVehNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobVehNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobVehNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobVehNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobVehNo", "@JobVehNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobVehNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobVehNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

