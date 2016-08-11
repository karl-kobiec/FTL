
	
public partial class WordDocument_WrDocQueryType : 
	DataFieldSelectBase<int,WordDocument>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Query Type";}
		set { } 
	}

	public string DFName=> "WrDocQueryType";

		public string GetDataSource() {
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocQueryType").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocQueryType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.WrDocQueryTypeAsQuery();		}
		return _DataSource;

	}
    
	public WordDocument_WrDocQueryType(WordDocument Parent) : 
		base(Parent, "WrDocQueryType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class WordDocument_WrDocQueryTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocQueryType").Any()) 
			return DS.GetManager<WordDocument>().OnDataSource.Where(f=> f.Key == "WrDocQueryType").First().Value(new WordDocument());
		
		
			return DSUtil.WrDocQueryTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 747;
	}
	public string GetControlName() {
		return "WrDocQueryTypeValue";
	}
	public string GetDFName() {
		return "WrDocQueryType";
	}
	public string GetTitle() {
		return "Query Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		WordDocument ds;
					ds = (WordDocument)dsI;
		 
		
		return ds.WrDocQueryType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		WordDocument ds;
				ds = (WordDocument)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/WordDocument/SaveWrDocQueryType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='WrDocQueryType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WrDocQueryType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WrDocQueryType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "WrDocQueryType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WrDocQueryType", "@WrDocQueryType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WrDocQueryType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("WordDocument").GetFieldOperators("WrDocQueryType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

