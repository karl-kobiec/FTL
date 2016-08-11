
	
public partial class JobCost_JobCServProv : 
	DataFieldAutoCompleteSingleBase<int,JobCost>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Service Provider";}
		set { } 
	}

	public string DFName=> "JobCServProv";

		public string GetDataSource() {
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProv").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProv").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public JobCost_JobCServProv(JobCost Parent) : 
		base(Parent, "JobCServProv"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class JobCost_JobCServProvFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProv").Any()) 
			return DS.GetManager<JobCost>().OnDataSource.Where(f=> f.Key == "JobCServProv").First().Value(new JobCost());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 165;
	}
	public string GetControlName() {
		return "JobCServProvValue";
	}
	public string GetDFName() {
		return "JobCServProv";
	}
	public string GetTitle() {
		return "Service Provider";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobCost ds;
					ds = (JobCost)dsI;
		 
		
		return ds.JobCServProv.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobCost ds;
				ds = (JobCost)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/JobCost/AutoCompleteJobCServProv/' onchange=\"javascript:IQAutoSave('/JobCost/SaveJobCServProv/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='JobCServProv'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCServProv.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCServProv";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/JobCost/AutoCompleteJobCServProv/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobCServProv")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCServProv", "@JobCServProv", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCServProv", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobCost").GetFieldOperators("JobCServProv", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

