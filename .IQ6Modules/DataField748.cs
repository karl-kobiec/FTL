
	
public partial class WordDocument_WrDocBuiltInQuery : 
	DataFieldBase<string,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Query";}
		set { } 
	}

	public string DFName=> "WrDocBuiltInQuery";

	
	public WordDocument_WrDocBuiltInQuery(WordDocument Parent) : 
		base(Parent, "WrDocBuiltInQuery"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class WordDocument_WrDocBuiltInQueryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocBuiltInQuery").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocBuiltInQuery").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 748;
	}
	public string GetControlName() {
		return "WrDocBuiltInQueryValue";
	}
	public string GetDFName() {
		return "WrDocBuiltInQuery";
	}
	public string GetTitle() {
		return "Query";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocBuiltInQuery.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocBuiltInQuery/?RecId=[[RecId]]',$(this));\" data-bound-name='WrDocBuiltInQuery' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocBuiltInQuery.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocBuiltInQuery";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocBuiltInQuery")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocBuiltInQuery", "@WrDocBuiltInQuery", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocBuiltInQuery", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocBuiltInQuery", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

