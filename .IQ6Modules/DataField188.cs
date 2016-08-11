
	
public partial class CertShip_CSRoute : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route";}
		set { } 
	}

	public string DFName=> "CSRoute";

	
	public CertShip_CSRoute(CertShip Parent) : 
		base(Parent, "CSRoute"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSRouteFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSRoute").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSRoute").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 188;
	}
	public string GetControlName() {
		return "CSRouteValue";
	}
	public string GetDFName() {
		return "CSRoute";
	}
	public string GetTitle() {
		return "Route";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSRoute.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSRoute/?RecId=[[RecId]]',$(this));\" data-bound-name='CSRoute' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSRoute.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSRoute";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSRoute")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSRoute", "@CSRoute", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSRoute", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSRoute", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

