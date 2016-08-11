
	
public partial class EMail_EMToRecords : 
	DataFieldAutoCompleteMultipleBase<EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "To (Records)";}
		set { } 
	}

	public string DFName=> "EMToRecords";

		public string GetDataSource() {
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMToRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMToRecords").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "";		}
		return _DataSource;

	}
    
	public EMail_EMToRecords(EMail Parent) : 
		base(Parent, "EMToRecords"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class EMail_EMToRecordsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMToRecords").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMToRecords").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 717;
	}
	public string GetControlName() {
		return "EMToRecordsValue";
	}
	public string GetDFName() {
		return "EMToRecords";
	}
	public string GetTitle() {
		return "To (Records)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMToRecords.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/EMail/AutoCompleteEMToRecords/' onchange=\"javascript:IQAutoSave('/EMail/SaveEMToRecords/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='EMToRecords'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMToRecords.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMToRecords";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/EMail/AutoCompleteEMToRecords/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMToRecords")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMToRecords", "@EMToRecords", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMToRecords", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMToRecords", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

