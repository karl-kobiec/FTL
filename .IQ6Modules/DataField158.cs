
	
public partial class JobLine_JobLDelPoint : 
	DataFieldSelectBase<int,JobLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Point";}
		set { } 
	}

	public string DFName=> "JobLDelPoint";

		public string GetDataSource() {
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelPoint").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelPoint").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.JobLDelPointAsQuery();		}
		return _DataSource;

	}
    
	public JobLine_JobLDelPoint(JobLine Parent) : 
		base(Parent, "JobLDelPoint"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class JobLine_JobLDelPointFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelPoint").Any()) 
			return DS.GetManager<JobLine>().OnDataSource.Where(f=> f.Key == "JobLDelPoint").First().Value(new JobLine());
		
		
			return DSUtil.JobLDelPointAsQuery();	}

	public int GetFieldUniqueId() {
		return 158;
	}
	public string GetControlName() {
		return "JobLDelPointValue";
	}
	public string GetDFName() {
		return "JobLDelPoint";
	}
	public string GetTitle() {
		return "Delivery Point";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		JobLine ds;
					ds = (JobLine)dsI;
		 
		
		return ds.JobLDelPoint.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		JobLine ds;
				ds = (JobLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/JobLine/SaveJobLDelPoint/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='JobLDelPoint'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.JobLDelPoint.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "JobLDelPoint";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "JobLDelPoint")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "JobLDelPoint", "@JobLDelPoint", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "JobLDelPoint", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("JobLine").GetFieldOperators("JobLDelPoint", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

