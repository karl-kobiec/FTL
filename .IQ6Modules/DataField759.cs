
	
public partial class SMSTemplate_SMSTContent : 
	DataFieldBase<string,SMSTemplate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Content";}
		set { } 
	}

	public string DFName=> "SMSTContent";

	
	public SMSTemplate_SMSTContent(SMSTemplate Parent) : 
		base(Parent, "SMSTContent"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMSTemplate_SMSTContentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTContent").Any()) 
			return DS.GetManager<SMSTemplate>().OnDataSource.Where(f=> f.Key == "SMSTContent").First().Value(new SMSTemplate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 759;
	}
	public string GetControlName() {
		return "SMSTContentValue";
	}
	public string GetDFName() {
		return "SMSTContent";
	}
	public string GetTitle() {
		return "Content";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMSTemplate ds;
					ds = (SMSTemplate)dsI;
		 
		
		return ds.SMSTContent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMSTemplate ds;
				ds = (SMSTemplate)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/SMSTemplate/SaveSMSTContent/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='SMSTContent'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSTContent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSTContent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSTContent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSTContent", "@SMSTContent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSTContent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMSTemplate").GetFieldOperators("SMSTContent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

