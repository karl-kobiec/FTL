
	
public partial class EmailTemplatess_EMTFromAddr : 
	DataFieldBase<string,EmailTemplatess>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "From Address";}
		set { } 
	}

	public string DFName=> "EMTFromAddr";

	
	public EmailTemplatess_EMTFromAddr(EmailTemplatess Parent) : 
		base(Parent, "EMTFromAddr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EmailTemplatess_EMTFromAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTFromAddr").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTFromAddr").First().Value(new EmailTemplatess());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 728;
	}
	public string GetControlName() {
		return "EMTFromAddrValue";
	}
	public string GetDFName() {
		return "EMTFromAddr";
	}
	public string GetTitle() {
		return "From Address";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EmailTemplatess ds;
					ds = (EmailTemplatess)dsI;
		 
		
		return ds.EMTFromAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EmailTemplatess ds;
				ds = (EmailTemplatess)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTFromAddr/?RecId=[[RecId]]',$(this));\" data-bound-name='EMTFromAddr' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTFromAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTFromAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMTFromAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTFromAddr", "@EMTFromAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTFromAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EmailTemplatess").GetFieldOperators("EMTFromAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

