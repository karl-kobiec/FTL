
	
public partial class Driver_DrvLicense : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Drivers License No";}
		set { } 
	}

	public string DFName=> "DrvLicense";

	
	public Driver_DrvLicense(Driver Parent) : 
		base(Parent, "DrvLicense"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvLicenseFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvLicense").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvLicense").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 796;
	}
	public string GetControlName() {
		return "DrvLicenseValue";
	}
	public string GetDFName() {
		return "DrvLicense";
	}
	public string GetTitle() {
		return "Drivers License No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvLicense.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvLicense/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvLicense' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvLicense.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvLicense";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvLicense")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvLicense", "@DrvLicense", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvLicense", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvLicense", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

