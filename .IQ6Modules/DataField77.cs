
	
public partial class Job_JobTransp : 
	DataFieldAutoCompleteSingleBase<int,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Transporter";}
		set { } 
	}

	public string DFName=> "JobTransp";

		public string GetDataSource() {
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTransp").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTransp").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Job_JobTransp(Job Parent) : 
		base(Parent, "JobTransp"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Job_JobTranspFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTransp").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobTransp").First().Value(new Job());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 77;
	}
	public string GetControlName() {
		return "JobTranspValue";
	}
	public string GetDFName() {
		return "JobTransp";
	}
	public string GetTitle() {
		return "Transporter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobTransp.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Job/AutoCompleteJobTransp/' onchange=\"javascript:IQAutoSave('/Job/SaveJobTransp/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='JobTransp'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobTransp.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobTransp";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Job/AutoCompleteJobTransp/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "JobTransp")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobTransp", "@JobTransp", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobTransp", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobTransp", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

