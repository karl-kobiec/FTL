
	
public partial class WordDocument_WrDocId : 
	FormattableDataFieldBase<int,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Id";}
		set { } 
	}

	public string DFName=> "WrDocId";

	
	public WordDocument_WrDocId(WordDocument Parent) : 
		base(Parent, "WrDocId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class WordDocument_WrDocIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocId").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocId").First().Value(new WordDocument());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 699;
	}
	public string GetControlName() {
		return "WrDocIdValue";
	}
	public string GetDFName() {
		return "WrDocId";
	}
	public string GetTitle() {
		return "Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocId/?RecId=[[RecId]]',$(this));\" data-bound-name='WrDocId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocId", "@WrDocId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

