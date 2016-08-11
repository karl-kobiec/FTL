
	
public partial class Query_QryPrimaryDS : 
	DataFieldSelectBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Primary Data Source";}
		set { } 
	}

	public string DFName=> "QryPrimaryDS";

		public string GetDataSource() {
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryPrimaryDS").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryPrimaryDS").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "";		}
		return _DataSource;

	}
    
	public Query_QryPrimaryDS(Query Parent) : 
		base(Parent, "QryPrimaryDS"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Query_QryPrimaryDSFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryPrimaryDS").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryPrimaryDS").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 707;
	}
	public string GetControlName() {
		return "QryPrimaryDSValue";
	}
	public string GetDFName() {
		return "QryPrimaryDS";
	}
	public string GetTitle() {
		return "Primary Data Source";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryPrimaryDS.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Query/SaveQryPrimaryDS/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='QryPrimaryDS'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryPrimaryDS.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryPrimaryDS";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryPrimaryDS")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryPrimaryDS", "@QryPrimaryDS", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryPrimaryDS", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryPrimaryDS", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

