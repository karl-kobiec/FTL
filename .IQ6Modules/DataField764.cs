
	
public partial class SMS_SMSSender : 
	DataFieldBase<string,SMS>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sender";}
		set { } 
	}

	public string DFName=> "SMSSender";

	
	public SMS_SMSSender(SMS Parent) : 
		base(Parent, "SMSSender"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class SMS_SMSSenderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSSender").Any()) 
			return DS.GetManager<SMS>().OnDataSource.Where(f=> f.Key == "SMSSender").First().Value(new SMS());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 764;
	}
	public string GetControlName() {
		return "SMSSenderValue";
	}
	public string GetDFName() {
		return "SMSSender";
	}
	public string GetTitle() {
		return "Sender";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		SMS ds;
					ds = (SMS)dsI;
		 
		
		return ds.SMSSender.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		SMS ds;
				ds = (SMS)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/SMS/SaveSMSSender/?RecId=[[RecId]]',$(this));\" data-bound-name='SMSSender' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SMSSender.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SMSSender";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SMSSender")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SMSSender", "@SMSSender", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SMSSender", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("SMS").GetFieldOperators("SMSSender", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

