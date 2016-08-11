
	
public partial class TruckMileage_TrkMOdometer : 
	FormattableDataFieldBase<int,TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Odometer (km)";}
		set { } 
	}

	public string DFName=> "TrkMOdometer";

	
	public TruckMileage_TrkMOdometer(TruckMileage Parent) : 
		base(Parent, "TrkMOdometer"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class TruckMileage_TrkMOdometerFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMOdometer").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMOdometer").First().Value(new TruckMileage());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 403;
	}
	public string GetControlName() {
		return "TrkMOdometerValue";
	}
	public string GetDFName() {
		return "TrkMOdometer";
	}
	public string GetTitle() {
		return "Odometer (km)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMOdometer.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMOdometer/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkMOdometer' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMOdometer.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMOdometer";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMOdometer")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMOdometer", "@TrkMOdometer", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMOdometer", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMOdometer", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

