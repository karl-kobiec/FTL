
	
public partial class WordDocument_WrDocTitle : 
	DataFieldBase<string,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Title";}
		set { } 
	}

	public string DFName=> "WrDocTitle";

	
	public WordDocument_WrDocTitle(WordDocument Parent) : 
		base(Parent, "WrDocTitle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class WordDocument_WrDocTitleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocTitle").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocTitle").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 701;
	}
	public string GetControlName() {
		return "WrDocTitleValue";
	}
	public string GetDFName() {
		return "WrDocTitle";
	}
	public string GetTitle() {
		return "Title";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocTitle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocTitle/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='WrDocTitle'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocTitle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocTitle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocTitle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocTitle", "@WrDocTitle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocTitle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocTitle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

