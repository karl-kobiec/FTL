
	
public partial class SMSTemplate_SMSTSender : 
	DataFieldBase<string,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sender";}
		set { } 
	}

	public string DFName=> "SMSTSender";

	
	public SMSTemplate_SMSTSender(SMSTemplate Parent) : 
		base(Parent, "SMSTSender"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMSTemplate_SMSTSenderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTSender").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTSender").First().Value(new SMSTemplate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 763;
	}
	public string GetControlName() {
		return "SMSTSenderValue";
	}
	public string GetDFName() {
		return "SMSTSender";
	}
	public string GetTitle() {
		return "Sender";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTSender.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTSender/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSTSender' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTSender.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTSender";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSTSender")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTSender", "@SMSTSender", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTSender", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTSender", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

