
	
public partial class SMSTemplate_SMSTName : 
	DataFieldBase<string,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Name";}
		set { } 
	}

	public string DFName=> "SMSTName";

	
	public SMSTemplate_SMSTName(SMSTemplate Parent) : 
		base(Parent, "SMSTName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMSTemplate_SMSTNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTName").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTName").First().Value(new SMSTemplate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 761;
	}
	public string GetControlName() {
		return "SMSTNameValue";
	}
	public string GetDFName() {
		return "SMSTName";
	}
	public string GetTitle() {
		return "Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTName/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSTName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSTName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTName", "@SMSTName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

