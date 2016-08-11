
	
public partial class CertShip_CSTime : 
	TimeDataFieldBase<CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Time";}
		set { } 
	}

	public string DFName=> "CSTime";

	
	public CertShip_CSTime(CertShip Parent) : 
		base(Parent, "CSTime"
			,"HH:mm"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSTimeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSTime").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSTime").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 191;
	}
	public string GetControlName() {
		return "CSTimeValue";
	}
	public string GetDFName() {
		return "CSTime";
	}
	public string GetTitle() {
		return "Time";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSTime.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSTime/?RecId=[[RecId]]',$(this));\" data-bound-name='CSTime' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSTime.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSTime";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSTime")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSTime", "@CSTime", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSTime", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSTime", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

