
	
public partial class IStatRec_IStDelTerms : 
	DataFieldSelectBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Terms";}
		set { } 
	}

	public string DFName=> "IStDelTerms";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStDelTerms").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStDelTerms").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.IStDelTermsAsQuery();		}
		return _DataSource;

	}
    
	public IStatRec_IStDelTerms(IStatRec Parent) : 
		base(Parent, "IStDelTerms"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("EXW");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStDelTermsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStDelTerms").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStDelTerms").First().Value(new IStatRec());
		
		
			return DSUtil.IStDelTermsAsQuery();	}

	public int GetFieldUniqueId() {
		return 640;
	}
	public string GetControlName() {
		return "IStDelTermsValue";
	}
	public string GetDFName() {
		return "IStDelTerms";
	}
	public string GetTitle() {
		return "Delivery Terms";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStDelTerms.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStDelTerms/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='IStDelTerms'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStDelTerms.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStDelTerms";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "IStDelTerms")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStDelTerms", "@IStDelTerms", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStDelTerms", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStDelTerms", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

