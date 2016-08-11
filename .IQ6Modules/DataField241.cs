
	
public partial class Job_JobChecked : 
	BoolDataFieldBase<Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Checked";}
		set { } 
	}

	public string DFName=> "JobChecked";

	
	public Job_JobChecked(Job Parent) : 
		base(Parent, "JobChecked"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Job_JobCheckedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobChecked").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobChecked").First().Value(new Job());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 241;
	}
	public string GetControlName() {
		return "JobCheckedValue";
	}
	public string GetDFName() {
		return "JobChecked";
	}
	public string GetTitle() {
		return "Checked";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobChecked.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Job/SaveJobChecked/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='JobChecked' [[Val]] /><input type = 'hidden' data-bound-name='JobChecked' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobChecked.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobChecked";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "JobChecked")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobChecked", "@JobChecked", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobChecked", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobChecked", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

