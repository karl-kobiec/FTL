
	
public partial class Query_QryCategory : 
	DataFieldBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Category";}
		set { } 
	}

	public string DFName=> "QryCategory";

	
	public Query_QryCategory(Query Parent) : 
		base(Parent, "QryCategory"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Query_QryCategoryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryCategory").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryCategory").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 791;
	}
	public string GetControlName() {
		return "QryCategoryValue";
	}
	public string GetDFName() {
		return "QryCategory";
	}
	public string GetTitle() {
		return "Category";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryCategory.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Query/SaveQryCategory/?RecId=[[RecId]]',$(this));\" data-bound-name='QryCategory' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryCategory.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryCategory";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryCategory")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryCategory", "@QryCategory", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryCategory", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryCategory", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

