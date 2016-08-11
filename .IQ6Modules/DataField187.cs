
	
public partial class CertShip_CSVehicle : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Vehicle";}
		set { } 
	}

	public string DFName=> "CSVehicle";

	
	public CertShip_CSVehicle(CertShip Parent) : 
		base(Parent, "CSVehicle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSVehicleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSVehicle").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSVehicle").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 187;
	}
	public string GetControlName() {
		return "CSVehicleValue";
	}
	public string GetDFName() {
		return "CSVehicle";
	}
	public string GetTitle() {
		return "Vehicle";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSVehicle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSVehicle/?RecId=[[RecId]]',$(this));\" data-bound-name='CSVehicle' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSVehicle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSVehicle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSVehicle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSVehicle", "@CSVehicle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSVehicle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSVehicle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

