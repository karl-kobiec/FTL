
	
public partial class CertShip_CSId : 
	FormattableDataFieldBase<int,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Certificate Number";}
		set { } 
	}

	public string DFName=> "CSId";

	
	public CertShip_CSId(CertShip Parent) : 
		base(Parent, "CSId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CertShip_CSIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSId").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSId").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 178;
	}
	public string GetControlName() {
		return "CSIdValue";
	}
	public string GetDFName() {
		return "CSId";
	}
	public string GetTitle() {
		return "Certificate Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSId/?RecId=[[RecId]]',$(this));\" data-bound-name='CSId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSId", "@CSId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

