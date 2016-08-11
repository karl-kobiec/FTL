
	
public partial class Query_QryContent : 
	DataFieldBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Content";}
		set { } 
	}

	public string DFName=> "QryContent";

	
	public Query_QryContent(Query Parent) : 
		base(Parent, "QryContent"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Query_QryContentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryContent").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryContent").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 706;
	}
	public string GetControlName() {
		return "QryContentValue";
	}
	public string GetDFName() {
		return "QryContent";
	}
	public string GetTitle() {
		return "Content";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryContent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Query/SaveQryContent/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='QryContent'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryContent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryContent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryContent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryContent", "@QryContent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryContent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryContent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

