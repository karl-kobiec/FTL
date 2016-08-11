
	
public partial class CertShip_CSShip : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ship";}
		set { } 
	}

	public string DFName=> "CSShip";

	
	public CertShip_CSShip(CertShip Parent) : 
		base(Parent, "CSShip"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSShipFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSShip").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSShip").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 189;
	}
	public string GetControlName() {
		return "CSShipValue";
	}
	public string GetDFName() {
		return "CSShip";
	}
	public string GetTitle() {
		return "Ship";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSShip.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSShip/?RecId=[[RecId]]',$(this));\" data-bound-name='CSShip' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSShip.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSShip";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSShip")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSShip", "@CSShip", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSShip", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSShip", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

