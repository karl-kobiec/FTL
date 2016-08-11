
	
public partial class SMS_SMSStatus : 
	DataFieldAutoCompleteSingleBase<int,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status";}
		set { } 
	}

	public string DFName=> "SMSStatus";

		public string GetDataSource() {
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatus").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatus").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.SMSStatusAsQuery();		}
		return _DataSource;

	}
    
	public SMS_SMSStatus(SMS Parent) : 
		base(Parent, "SMSStatus"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class SMS_SMSStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatus").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatus").First().Value(new SMS());
		
		
			return DSUtil.SMSStatusAsQuery();	}

	public int GetFieldUniqueId() {
		return 756;
	}
	public string GetControlName() {
		return "SMSStatusValue";
	}
	public string GetDFName() {
		return "SMSStatus";
	}
	public string GetTitle() {
		return "Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/SMS/AutoCompleteSMSStatus/' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSStatus/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='SMSStatus'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSStatus";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/SMS/AutoCompleteSMSStatus/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSStatus", "@SMSStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSStatus", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSStatus", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

