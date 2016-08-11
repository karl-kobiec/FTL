
	
public partial class Query_QryRelationships : 
	DataFieldBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Relationships";}
		set { } 
	}

	public string DFName=> "QryRelationships";

	
	public Query_QryRelationships(Query Parent) : 
		base(Parent, "QryRelationships"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Query_QryRelationshipsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryRelationships").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryRelationships").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 792;
	}
	public string GetControlName() {
		return "QryRelationshipsValue";
	}
	public string GetDFName() {
		return "QryRelationships";
	}
	public string GetTitle() {
		return "Relationships";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryRelationships.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Query/SaveQryRelationships/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='QryRelationships'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryRelationships.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryRelationships";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryRelationships")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryRelationships", "@QryRelationships", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryRelationships", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryRelationships", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

