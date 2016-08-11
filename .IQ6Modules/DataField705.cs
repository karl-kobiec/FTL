
	
public partial class Query_QrySysName : 
	DataFieldBase<string,Query>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "System Name";}
		set { } 
	}

	public string DFName=> "QrySysName";

	
	public Query_QrySysName(Query Parent) : 
		base(Parent, "QrySysName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Query_QrySysNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QrySysName").Any()) 
			return DS.GetManager<Query>().OnDataSource.Where(f=> f.Key == "QrySysName").First().Value(new Query());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 705;
	}
	public string GetControlName() {
		return "QrySysNameValue";
	}
	public string GetDFName() {
		return "QrySysName";
	}
	public string GetTitle() {
		return "System Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Query ds;
					ds = (Query)dsI;
		 
		
		return ds.QrySysName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Query ds;
				ds = (Query)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Query/SaveQrySysName/?RecId=[[RecId]]',$(this));\" data-bound-name='QrySysName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.QrySysName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "QrySysName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "QrySysName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "QrySysName", "@QrySysName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "QrySysName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Query").GetFieldOperators("QrySysName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

