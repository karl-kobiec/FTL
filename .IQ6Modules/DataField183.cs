
	
public partial class CertShip_CSCustOrd : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Order No";}
		set { } 
	}

	public string DFName=> "CSCustOrd";

	
	public CertShip_CSCustOrd(CertShip Parent) : 
		base(Parent, "CSCustOrd"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSCustOrdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCustOrd").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCustOrd").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 183;
	}
	public string GetControlName() {
		return "CSCustOrdValue";
	}
	public string GetDFName() {
		return "CSCustOrd";
	}
	public string GetTitle() {
		return "Client Order No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSCustOrd.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSCustOrd/?RecId=[[RecId]]',$(this));\" data-bound-name='CSCustOrd' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSCustOrd.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSCustOrd";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSCustOrd")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSCustOrd", "@CSCustOrd", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSCustOrd", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSCustOrd", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

