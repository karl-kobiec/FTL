
	
public partial class Job_JobTrailerNo : 
	DataFieldBase<string,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Trailer Number";}
		set { } 
	}

	public string DFName=> "JobTrailerNo";

	
	public Job_JobTrailerNo(Job Parent) : 
		base(Parent, "JobTrailerNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Job_JobTrailerNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTrailerNo").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTrailerNo").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 80;
	}
	public string GetControlName() {
		return "JobTrailerNoValue";
	}
	public string GetDFName() {
		return "JobTrailerNo";
	}
	public string GetTitle() {
		return "Trailer Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobTrailerNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Job/SaveJobTrailerNo/?RecId=[[RecId]]',$(this));\" data-bound-name='JobTrailerNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobTrailerNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobTrailerNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobTrailerNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobTrailerNo", "@JobTrailerNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobTrailerNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobTrailerNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

