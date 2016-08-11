
	
public partial class CN_CNImpExp : 
	DataFieldSelectBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Import or Export";}
		set { } 
	}

	public string DFName=> "CNImpExp";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNImpExp").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNImpExp").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return "select 0 as KeyValue, '' as [Description]";		}
		return _DataSource;

	}
    
	public CN_CNImpExp(CN Parent) : 
		base(Parent, "CNImpExp"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNImpExpFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNImpExp").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNImpExp").First().Value(new CN());
		
		
			return "select 0 as KeyValue, '' as [Description]";	}

	public int GetFieldUniqueId() {
		return 202;
	}
	public string GetControlName() {
		return "CNImpExpValue";
	}
	public string GetDFName() {
		return "CNImpExp";
	}
	public string GetTitle() {
		return "Import or Export";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNImpExp.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CN/SaveCNImpExp/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNImpExp'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNImpExp.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNImpExp";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CNImpExp")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNImpExp", "@CNImpExp", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNImpExp", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNImpExp", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

