
	
public partial class SMS_SMSContent : 
	DataFieldBase<string,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Content";}
		set { } 
	}

	public string DFName=> "SMSContent";

	
	public SMS_SMSContent(SMS Parent) : 
		base(Parent, "SMSContent"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMS_SMSContentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSContent").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSContent").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 750;
	}
	public string GetControlName() {
		return "SMSContentValue";
	}
	public string GetDFName() {
		return "SMSContent";
	}
	public string GetTitle() {
		return "Content";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSContent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSContent/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='SMSContent'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSContent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSContent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSContent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSContent", "@SMSContent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSContent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSContent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

