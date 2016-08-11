
	
public partial class EmailTemplatess_EMTSubject : 
	DataFieldBase<string,EmailTemplatess>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Subject";}
		set { } 
	}

	public string DFName=> "EMTSubject";

	
	public EmailTemplatess_EMTSubject(EmailTemplatess Parent) : 
		base(Parent, "EMTSubject"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EmailTemplatess_EMTSubjectFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTSubject").Any()) 
			return DS.GetManager<EmailTemplatess>().OnDataSource.Where(f=> f.Key == "EMTSubject").First().Value(new EmailTemplatess());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 727;
	}
	public string GetControlName() {
		return "EMTSubjectValue";
	}
	public string GetDFName() {
		return "EMTSubject";
	}
	public string GetTitle() {
		return "Subject";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EmailTemplatess ds;
					ds = (EmailTemplatess)dsI;
		 
		
		return ds.EMTSubject.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EmailTemplatess ds;
				ds = (EmailTemplatess)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EmailTemplatess/SaveEMTSubject/?RecId=[[RecId]]',$(this));\" data-bound-name='EMTSubject' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTSubject.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTSubject";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMTSubject")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTSubject", "@EMTSubject", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTSubject", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EmailTemplatess").GetFieldOperators("EMTSubject", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

