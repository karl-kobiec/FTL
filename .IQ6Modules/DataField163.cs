
	
public partial class JobCost_JobCJobNo : 
	DataFieldSelectBase<int,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Number";}
		set { } 
	}

	public string DFName=> "JobCJobNo";

		public string GetDataSource() {
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCJobNo").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCJobNo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public JobCost_JobCJobNo(JobCost Parent) : 
		base(Parent, "JobCJobNo"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class JobCost_JobCJobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCJobNo").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCJobNo").First().Value(new JobCost());
		
		
			return  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 163;
	}
	public string GetControlName() {
		return "JobCJobNoValue";
	}
	public string GetDFName() {
		return "JobCJobNo";
	}
	public string GetTitle() {
		return "Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCJobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCJobNo/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobCJobNo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCJobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCJobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								foreach(var itm in IQApp.DB.Load<Pair<string, string>>(GetDataSource())) {
					ret += "<option value='" + itm.KeyValue + "'" + (filterValue == itm.KeyValue ? "selected=selected" : "") + ">" + itm.Description + "</option>";
				}
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCJobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCJobNo", "@JobCJobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCJobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCJobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

