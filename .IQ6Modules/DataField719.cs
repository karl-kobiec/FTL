
	
public partial class EMail_EMCCRecords : 
	DataFieldAutoCompleteMultipleBase<EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "CC (Records)";}
		set { } 
	}

	public string DFName=> "EMCCRecords";

		public string GetDataSource() {
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCCRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCCRecords").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "";		}
		return _DataSource;

	}
    
	public EMail_EMCCRecords(EMail Parent) : 
		base(Parent, "EMCCRecords"
			
		)
    {
				Enabled = true; 
		
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EMail_EMCCRecordsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCCRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCCRecords").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 719;
	}
	public string GetControlName() {
		return "EMCCRecordsValue";
	}
	public string GetDFName() {
		return "EMCCRecords";
	}
	public string GetTitle() {
		return "CC (Records)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMCCRecords.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/EMail/AutoCompleteEMCCRecords/' onchange=\"javascript:IQAutoSave('/EMail/SaveEMCCRecords/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='EMCCRecords'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMCCRecords.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMCCRecords";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/EMail/AutoCompleteEMCCRecords/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMCCRecords")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMCCRecords", "@EMCCRecords", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMCCRecords", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMCCRecords", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

