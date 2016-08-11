
	
public partial class EmailTemplatess_EMTBCCAddr : 
	DataFieldBase<string,EmailTemplatess>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "BCC Address";}
		set { } 
	}

	public string DFName=> "EMTBCCAddr";

	
	public EmailTemplatess_EMTBCCAddr(EmailTemplatess Parent) : 
		base(Parent, "EMTBCCAddr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EmailTemplatess_EMTBCCAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTBCCAddr").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTBCCAddr").First().Value(new EmailTemplatess());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 731;
	}
	public string GetControlName() {
		return "EMTBCCAddrValue";
	}
	public string GetDFName() {
		return "EMTBCCAddr";
	}
	public string GetTitle() {
		return "BCC Address";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EmailTemplatess ds;
					ds = (EmailTemplatess)dsI;
		 
		
		return ds.EMTBCCAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EmailTemplatess ds;
				ds = (EmailTemplatess)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTBCCAddr/?RecId=[[RecId]]',$(this));\" data-bound-name='EMTBCCAddr' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTBCCAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTBCCAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMTBCCAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTBCCAddr", "@EMTBCCAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTBCCAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EmailTemplatess").GetFieldOperators("EMTBCCAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

