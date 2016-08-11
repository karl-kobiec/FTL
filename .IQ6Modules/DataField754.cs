
	
public partial class SMS_SMSDateQueued : 
	DateDataFieldBase<SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Queued";}
		set { } 
	}

	public string DFName=> "SMSDateQueued";

	
	public SMS_SMSDateQueued(SMS Parent) : 
		base(Parent, "SMSDateQueued"
			,"dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class SMS_SMSDateQueuedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDateQueued").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDateQueued").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 754;
	}
	public string GetControlName() {
		return "SMSDateQueuedValue";
	}
	public string GetDFName() {
		return "SMSDateQueued";
	}
	public string GetTitle() {
		return "Queued";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSDateQueued.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDateQueued/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSDateQueued' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSDateQueued.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSDateQueued";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSDateQueued")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSDateQueued", "@SMSDateQueued", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSDateQueued", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSDateQueued", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

