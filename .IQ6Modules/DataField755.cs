
	
public partial class SMS_SMSDateConfirmed : 
	DateDataFieldBase<SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivered";}
		set { } 
	}

	public string DFName=> "SMSDateConfirmed";

	
	public SMS_SMSDateConfirmed(SMS Parent) : 
		base(Parent, "SMSDateConfirmed"
			,"dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class SMS_SMSDateConfirmedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDateConfirmed").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDateConfirmed").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 755;
	}
	public string GetControlName() {
		return "SMSDateConfirmedValue";
	}
	public string GetDFName() {
		return "SMSDateConfirmed";
	}
	public string GetTitle() {
		return "Delivered";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSDateConfirmed.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDateConfirmed/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSDateConfirmed' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSDateConfirmed.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSDateConfirmed";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSDateConfirmed")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSDateConfirmed", "@SMSDateConfirmed", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSDateConfirmed", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSDateConfirmed", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

