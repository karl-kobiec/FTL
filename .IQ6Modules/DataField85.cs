
	
public partial class Job_JobRouteTo : 
	DataFieldSelectBase<int,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route To";}
		set { } 
	}

	public string DFName=> "JobRouteTo";

		public string GetDataSource() {
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteTo").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteTo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Job_JobRouteTo(Job Parent) : 
		base(Parent, "JobRouteTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Job_JobRouteToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteTo").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteTo").First().Value(new Job());
		
		
			return  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 85;
	}
	public string GetControlName() {
		return "JobRouteToValue";
	}
	public string GetDFName() {
		return "JobRouteTo";
	}
	public string GetTitle() {
		return "Route To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobRouteTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Job/SaveJobRouteTo/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobRouteTo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobRouteTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobRouteTo";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "JobRouteTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobRouteTo", "@JobRouteTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobRouteTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobRouteTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

