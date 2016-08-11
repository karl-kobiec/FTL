
	
public partial class Job_JobCreatedBy : 
	DataFieldSelectBase<int,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Created By";}
		set { } 
	}

	public string DFName=> "JobCreatedBy";

		public string GetDataSource() {
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobCreatedBy").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobCreatedBy").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Job_JobCreatedBy(Job Parent) : 
		base(Parent, "JobCreatedBy"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Job_JobCreatedByFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobCreatedBy").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobCreatedBy").First().Value(new Job());
		
		
			return  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 289;
	}
	public string GetControlName() {
		return "JobCreatedByValue";
	}
	public string GetDFName() {
		return "JobCreatedBy";
	}
	public string GetTitle() {
		return "Created By";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobCreatedBy.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Job/SaveJobCreatedBy/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobCreatedBy'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobCreatedBy.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobCreatedBy";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "JobCreatedBy")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobCreatedBy", "@JobCreatedBy", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobCreatedBy", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobCreatedBy", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

