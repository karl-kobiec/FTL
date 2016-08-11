
	
public partial class Query_QryScreen : 
	DataFieldSelectBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Screen";}
		set { } 
	}

	public string DFName=> "QryScreen";

		public string GetDataSource() {
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryScreen").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryScreen").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "";		}
		return _DataSource;

	}
    
	public Query_QryScreen(Query Parent) : 
		base(Parent, "QryScreen"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Query_QryScreenFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryScreen").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryScreen").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 723;
	}
	public string GetControlName() {
		return "QryScreenValue";
	}
	public string GetDFName() {
		return "QryScreen";
	}
	public string GetTitle() {
		return "Screen";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryScreen.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Query/SaveQryScreen/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='QryScreen'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryScreen.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryScreen";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryScreen")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryScreen", "@QryScreen", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryScreen", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryScreen", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

