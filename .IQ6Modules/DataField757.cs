
	
public partial class SMS_SMSStatusMsg : 
	DataFieldBase<string,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status Message";}
		set { } 
	}

	public string DFName=> "SMSStatusMsg";

	
	public SMS_SMSStatusMsg(SMS Parent) : 
		base(Parent, "SMSStatusMsg"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class SMS_SMSStatusMsgFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatusMsg").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSStatusMsg").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 757;
	}
	public string GetControlName() {
		return "SMSStatusMsgValue";
	}
	public string GetDFName() {
		return "SMSStatusMsg";
	}
	public string GetTitle() {
		return "Status Message";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSStatusMsg.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSStatusMsg/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='SMSStatusMsg'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSStatusMsg.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSStatusMsg";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSStatusMsg")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSStatusMsg", "@SMSStatusMsg", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSStatusMsg", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSStatusMsg", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

