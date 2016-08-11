
	
public partial class WordDocument_WrDocDataset : 
	DataFieldSelectBase<string,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Applies To";}
		set { } 
	}

	public string DFName=> "WrDocDataset";

		public string GetDataSource() {
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocDataset").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocDataset").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT  AS KeyValue,  AS Description FROM  UNION SELECT 0, '' ORDER BY ";		}
		return _DataSource;

	}
    
	public WordDocument_WrDocDataset(WordDocument Parent) : 
		base(Parent, "WrDocDataset"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class WordDocument_WrDocDatasetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocDataset").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocDataset").First().Value(new WordDocument());
		
		
			return  "SELECT  AS KeyValue,  AS Description FROM  UNION SELECT 0, '' ORDER BY ";	}

	public int GetFieldUniqueId() {
		return 702;
	}
	public string GetControlName() {
		return "WrDocDatasetValue";
	}
	public string GetDFName() {
		return "WrDocDataset";
	}
	public string GetTitle() {
		return "Applies To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocDataset.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocDataset/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='WrDocDataset'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocDataset.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocDataset";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								foreach(var itm in IQApp.DB.Load<Pair<string, string>>(GetDataSource())) {
					ret += "<option value='" + itm.KeyValue + "'" + (filterValue == itm.KeyValue ? "selected=selected" : "") + ">" + itm.Description + "</option>";
				}
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WrDocDataset")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocDataset", "@WrDocDataset", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocDataset", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocDataset", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

