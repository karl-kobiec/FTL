
	
public partial class Job_JobAccMonth : 
	DataFieldSelectBase<int,Job>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Accounting Month";}
		set { } 
	}

	public string DFName=> "JobAccMonth";

		public string GetDataSource() {
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobAccMonth").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobAccMonth").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.JobAccMonthAsQuery();		}
		return _DataSource;

	}
    
	public Job_JobAccMonth(Job Parent) : 
		base(Parent, "JobAccMonth"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Job_JobAccMonthFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobAccMonth").Any()) 
			return DS.GetManager<Job>().OnDataSource.Where(f=> f.Key == "JobAccMonth").First().Value(new Job());
		
		
			return DSUtil.JobAccMonthAsQuery();	}

	public int GetFieldUniqueId() {
		return 196;
	}
	public string GetControlName() {
		return "JobAccMonthValue";
	}
	public string GetDFName() {
		return "JobAccMonth";
	}
	public string GetTitle() {
		return "Accounting Month";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Job ds;
					ds = (Job)dsI;
		 
		
		return ds.JobAccMonth.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Job ds;
				ds = (Job)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Job/SaveJobAccMonth/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobAccMonth'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobAccMonth.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobAccMonth";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "JobAccMonth")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobAccMonth", "@JobAccMonth", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobAccMonth", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Job").GetFieldOperators("JobAccMonth", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

