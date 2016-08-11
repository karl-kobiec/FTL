
	
public partial class SMS_SMSDestination : 
	DataFieldBase<string,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Destination";}
		set { } 
	}

	public string DFName=> "SMSDestination";

	
	public SMS_SMSDestination(SMS Parent) : 
		base(Parent, "SMSDestination"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMS_SMSDestinationFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDestination").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDestination").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 751;
	}
	public string GetControlName() {
		return "SMSDestinationValue";
	}
	public string GetDFName() {
		return "SMSDestination";
	}
	public string GetTitle() {
		return "Destination";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSDestination.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDestination/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSDestination' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSDestination.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSDestination";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSDestination")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSDestination", "@SMSDestination", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSDestination", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSDestination", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

