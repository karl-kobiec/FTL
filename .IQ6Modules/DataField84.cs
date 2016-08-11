
	
public partial class Job_JobRouteFrom : 
	DataFieldSelectBase<int,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route From";}
		set { } 
	}

	public string DFName=> "JobRouteFrom";

		public string GetDataSource() {
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteFrom").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteFrom").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Job_JobRouteFrom(Job Parent) : 
		base(Parent, "JobRouteFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Job_JobRouteFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteFrom").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobRouteFrom").First().Value(new Job());
		
		
			return  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 84;
	}
	public string GetControlName() {
		return "JobRouteFromValue";
	}
	public string GetDFName() {
		return "JobRouteFrom";
	}
	public string GetTitle() {
		return "Route From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobRouteFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Job/SaveJobRouteFrom/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobRouteFrom'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobRouteFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobRouteFrom";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "JobRouteFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobRouteFrom", "@JobRouteFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobRouteFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobRouteFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

