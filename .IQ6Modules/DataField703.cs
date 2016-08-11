
	
public partial class Query_QryId : 
	FormattableDataFieldBase<int,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Id";}
		set { } 
	}

	public string DFName=> "QryId";

	
	public Query_QryId(Query Parent) : 
		base(Parent, "QryId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Query_QryIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryId").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryId").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 703;
	}
	public string GetControlName() {
		return "QryIdValue";
	}
	public string GetDFName() {
		return "QryId";
	}
	public string GetTitle() {
		return "Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Query/SaveQryId/?RecId=[[RecId]]',$(this));\" data-bound-name='QryId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryId", "@QryId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

