
	
public partial class EmailTemplatess_EMTQuery : 
	DataFieldSelectBase<string,EmailTemplatess>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Query";}
		set { } 
	}

	public string DFName=> "EMTQuery";

		public string GetDataSource() {
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTQuery").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTQuery").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT QryId AS KeyValue, QryName AS Description FROM Query UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public EmailTemplatess_EMTQuery(EmailTemplatess Parent) : 
		base(Parent, "EMTQuery"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EmailTemplatess_EMTQueryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTQuery").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTQuery").First().Value(new EmailTemplatess());
		
		
			return  "SELECT QryId AS KeyValue, QryName AS Description FROM Query UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 737;
	}
	public string GetControlName() {
		return "EMTQueryValue";
	}
	public string GetDFName() {
		return "EMTQuery";
	}
	public string GetTitle() {
		return "Query";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EmailTemplatess ds;
					ds = (EmailTemplatess)dsI;
		 
		
		return ds.EMTQuery.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EmailTemplatess ds;
				ds = (EmailTemplatess)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTQuery/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='EMTQuery'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTQuery.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTQuery";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "EMTQuery")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTQuery", "@EMTQuery", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTQuery", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EmailTemplatess").GetFieldOperators("EMTQuery", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

