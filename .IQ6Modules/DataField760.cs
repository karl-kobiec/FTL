
	
public partial class SMSTemplate_SMSTDestination : 
	DataFieldBase<string,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Destination";}
		set { } 
	}

	public string DFName=> "SMSTDestination";

	
	public SMSTemplate_SMSTDestination(SMSTemplate Parent) : 
		base(Parent, "SMSTDestination"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMSTemplate_SMSTDestinationFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDestination").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTDestination").First().Value(new SMSTemplate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 760;
	}
	public string GetControlName() {
		return "SMSTDestinationValue";
	}
	public string GetDFName() {
		return "SMSTDestination";
	}
	public string GetTitle() {
		return "Destination";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTDestination.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTDestination/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSTDestination' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTDestination.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTDestination";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSTDestination")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTDestination", "@SMSTDestination", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTDestination", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTDestination", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

