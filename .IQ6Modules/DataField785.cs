
	
public partial class WordDocument_WrDocUseSimple : 
	BoolDataFieldBase<WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Simple Merge Fields";}
		set { } 
	}

	public string DFName=> "WrDocUseSimple";

	
	public WordDocument_WrDocUseSimple(WordDocument Parent) : 
		base(Parent, "WrDocUseSimple"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("True");
				    }
}


public partial class WordDocument_WrDocUseSimpleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocUseSimple").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocUseSimple").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 785;
	}
	public string GetControlName() {
		return "WrDocUseSimpleValue";
	}
	public string GetDFName() {
		return "WrDocUseSimple";
	}
	public string GetTitle() {
		return "Simple Merge Fields";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocUseSimple.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocUseSimple/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='WrDocUseSimple' [[Val]] /><input type = 'hidden' data-bound-name='WrDocUseSimple' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocUseSimple.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocUseSimple";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "WrDocUseSimple")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocUseSimple", "@WrDocUseSimple", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocUseSimple", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocUseSimple", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

