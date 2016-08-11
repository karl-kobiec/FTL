
	
public partial class EMail_EMBCCRecords : 
	DataFieldAutoCompleteMultipleBase<EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "BCC (Records)";}
		set { } 
	}

	public string DFName=> "EMBCCRecords";

		public string GetDataSource() {
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCCRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCCRecords").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT  AS KeyValue,  AS Description FROM  UNION SELECT 0, '' ORDER BY ";		}
		return _DataSource;

	}
    
	public EMail_EMBCCRecords(EMail Parent) : 
		base(Parent, "EMBCCRecords"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EMail_EMBCCRecordsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCCRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCCRecords").First().Value(new EMail());
		
		
			return  "SELECT  AS KeyValue,  AS Description FROM  UNION SELECT 0, '' ORDER BY ";	}

	public int GetFieldUniqueId() {
		return 721;
	}
	public string GetControlName() {
		return "EMBCCRecordsValue";
	}
	public string GetDFName() {
		return "EMBCCRecords";
	}
	public string GetTitle() {
		return "BCC (Records)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMBCCRecords.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/EMail/AutoCompleteEMBCCRecords/' onchange=\"javascript:IQAutoSave('/EMail/SaveEMBCCRecords/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='EMBCCRecords'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMBCCRecords.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMBCCRecords";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/EMail/AutoCompleteEMBCCRecords/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMBCCRecords")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMBCCRecords", "@EMBCCRecords", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMBCCRecords", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMBCCRecords", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

