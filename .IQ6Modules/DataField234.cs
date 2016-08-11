
	
public partial class Driver_DrvVehicle : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Vehicle Assigned To";}
		set { } 
	}

	public string DFName=> "DrvVehicle";

	
	public Driver_DrvVehicle(Driver Parent) : 
		base(Parent, "DrvVehicle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvVehicleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvVehicle").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvVehicle").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 234;
	}
	public string GetControlName() {
		return "DrvVehicleValue";
	}
	public string GetDFName() {
		return "DrvVehicle";
	}
	public string GetTitle() {
		return "Vehicle Assigned To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvVehicle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvVehicle/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvVehicle' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvVehicle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvVehicle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvVehicle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvVehicle", "@DrvVehicle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvVehicle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvVehicle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

