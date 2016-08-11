
	
public partial class SMS_SMSDataset : 
	DataFieldBase<string,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Dataset";}
		set { } 
	}

	public string DFName=> "SMSDataset";

	
	public SMS_SMSDataset(SMS Parent) : 
		base(Parent, "SMSDataset"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMS_SMSDatasetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDataset").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSDataset").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 752;
	}
	public string GetControlName() {
		return "SMSDatasetValue";
	}
	public string GetDFName() {
		return "SMSDataset";
	}
	public string GetTitle() {
		return "Dataset";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSDataset.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSDataset/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSDataset' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSDataset.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSDataset";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSDataset")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSDataset", "@SMSDataset", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSDataset", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSDataset", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

