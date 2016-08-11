
	
public partial class CertShip_CSDate : 
	DateDataFieldBase<CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date";}
		set { } 
	}

	public string DFName=> "CSDate";

	
	public CertShip_CSDate(CertShip Parent) : 
		base(Parent, "CSDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDate").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDate").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 190;
	}
	public string GetControlName() {
		return "CSDateValue";
	}
	public string GetDFName() {
		return "CSDate";
	}
	public string GetTitle() {
		return "Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='CSDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSDate", "@CSDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

