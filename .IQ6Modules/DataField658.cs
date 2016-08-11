
	
public partial class IStatRec_IStRatePeriod : 
	DataFieldAutoCompleteSingleBase<int,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Exch Rate Period";}
		set { } 
	}

	public string DFName=> "IStRatePeriod";

		public string GetDataSource() {
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStRatePeriod").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStRatePeriod").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT ExRId AS KeyValue, ExRName AS Description FROM ExchRate UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public IStatRec_IStRatePeriod(IStatRec Parent) : 
		base(Parent, "IStRatePeriod"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class IStatRec_IStRatePeriodFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStRatePeriod").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStRatePeriod").First().Value(new IStatRec());
		
		
			return  "SELECT ExRId AS KeyValue, ExRName AS Description FROM ExchRate UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 658;
	}
	public string GetControlName() {
		return "IStRatePeriodValue";
	}
	public string GetDFName() {
		return "IStRatePeriod";
	}
	public string GetTitle() {
		return "Exch Rate Period";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStRatePeriod.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/IStatRec/AutoCompleteIStRatePeriod/' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStRatePeriod/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='IStRatePeriod'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStRatePeriod.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStRatePeriod";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/IStatRec/AutoCompleteIStRatePeriod/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStRatePeriod")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStRatePeriod", "@IStRatePeriod", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStRatePeriod", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStRatePeriod", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

