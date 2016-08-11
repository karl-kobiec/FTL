
	
public partial class Query_QryType : 
	DataFieldSelectBase<int,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Type";}
		set { } 
	}

	public string DFName=> "QryType";

		public string GetDataSource() {
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryType").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.QryTypeAsQuery();		}
		return _DataSource;

	}
    
	public Query_QryType(Query Parent) : 
		base(Parent, "QryType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Query_QryTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryType").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryType").First().Value(new Query());
		
		
			return DSUtil.QryTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 784;
	}
	public string GetControlName() {
		return "QryTypeValue";
	}
	public string GetDFName() {
		return "QryType";
	}
	public string GetTitle() {
		return "Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Query/SaveQryType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='QryType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "QryType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryType", "@QryType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

