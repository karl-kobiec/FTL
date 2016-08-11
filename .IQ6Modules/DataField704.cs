
	
public partial class Query_QryName : 
	DataFieldBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Name";}
		set { } 
	}

	public string DFName=> "QryName";

	
	public Query_QryName(Query Parent) : 
		base(Parent, "QryName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Query_QryNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryName").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QryName").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 704;
	}
	public string GetControlName() {
		return "QryNameValue";
	}
	public string GetDFName() {
		return "QryName";
	}
	public string GetTitle() {
		return "Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QryName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Query/SaveQryName/?RecId=[[RecId]]',$(this));\" data-bound-name='QryName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QryName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QryName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QryName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QryName", "@QryName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QryName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QryName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

