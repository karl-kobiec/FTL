
	
public partial class EmailTemplatess_EMTToAddr : 
	DataFieldBase<string,EmailTemplatess>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "To Address";}
		set { } 
	}

	public string DFName=> "EMTToAddr";

	
	public EmailTemplatess_EMTToAddr(EmailTemplatess Parent) : 
		base(Parent, "EMTToAddr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EmailTemplatess_EMTToAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTToAddr").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTToAddr").First().Value(new EmailTemplatess());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 729;
	}
	public string GetControlName() {
		return "EMTToAddrValue";
	}
	public string GetDFName() {
		return "EMTToAddr";
	}
	public string GetTitle() {
		return "To Address";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EmailTemplatess ds;
					ds = (EmailTemplatess)dsI;
		 
		
		return ds.EMTToAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EmailTemplatess ds;
				ds = (EmailTemplatess)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTToAddr/?RecId=[[RecId]]',$(this));\" data-bound-name='EMTToAddr' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTToAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTToAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMTToAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTToAddr", "@EMTToAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTToAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EmailTemplatess").GetFieldOperators("EMTToAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

