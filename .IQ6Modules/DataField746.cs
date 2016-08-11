
	
public partial class WordDocument_WrDocCategory : 
	DataFieldBase<string,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Category";}
		set { } 
	}

	public string DFName=> "WrDocCategory";

	
	public WordDocument_WrDocCategory(WordDocument Parent) : 
		base(Parent, "WrDocCategory"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class WordDocument_WrDocCategoryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocCategory").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocCategory").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 746;
	}
	public string GetControlName() {
		return "WrDocCategoryValue";
	}
	public string GetDFName() {
		return "WrDocCategory";
	}
	public string GetTitle() {
		return "Category";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocCategory.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocCategory/?RecId=[[RecId]]',$(this));\" data-bound-name='WrDocCategory' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocCategory.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocCategory";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocCategory")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocCategory", "@WrDocCategory", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocCategory", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocCategory", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

