
	
public partial class WordDocument_WrDocTemplate : 
	DataFieldFileBase<string,WordDocument>, IQ6.Core.IDSFieldBase
{
		public string FullUrl { 
		get { return IQApp.Files.GetFileUrl(Value.ToString()); }  set { Value = value;}
	}
	
	public string LabelText { 
		get { return "Template";}
		set { } 
	}

	public string DFName=> "WrDocTemplate";

	
	public WordDocument_WrDocTemplate(WordDocument Parent) : 
		base(Parent, "WrDocTemplate"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class WordDocument_WrDocTemplateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocTemplate").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocTemplate").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 700;
	}
	public string GetControlName() {
		return "WrDocTemplateValue";
	}
	public string GetDFName() {
		return "WrDocTemplate";
	}
	public string GetTitle() {
		return "Template";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocTemplate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocTemplate/?RecId=[[RecId]]',$(this));\" data-bound-name='WrDocTemplate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocTemplate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocTemplate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocTemplate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocTemplate", "@WrDocTemplate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocTemplate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocTemplate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

