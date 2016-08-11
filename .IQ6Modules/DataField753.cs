
	
public partial class SMS_SMSRecordID : 
	FormattableDataFieldBase<int,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "RecordID";}
		set { } 
	}

	public string DFName=> "SMSRecordID";

	
	public SMS_SMSRecordID(SMS Parent) : 
		base(Parent, "SMSRecordID"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class SMS_SMSRecordIDFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSRecordID").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSRecordID").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 753;
	}
	public string GetControlName() {
		return "SMSRecordIDValue";
	}
	public string GetDFName() {
		return "SMSRecordID";
	}
	public string GetTitle() {
		return "RecordID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSRecordID.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSRecordID/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSRecordID' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSRecordID.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSRecordID";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSRecordID")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSRecordID", "@SMSRecordID", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSRecordID", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSRecordID", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

