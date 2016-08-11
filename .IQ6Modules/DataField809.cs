
	
public partial class Truck_TrkTruckMob : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Truck Mobile:";}
		set { } 
	}

	public string DFName=> "TrkTruckMob";

	
	public Truck_TrkTruckMob(Truck Parent) : 
		base(Parent, "TrkTruckMob"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkTruckMobFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkTruckMob").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkTruckMob").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 809;
	}
	public string GetControlName() {
		return "TrkTruckMobValue";
	}
	public string GetDFName() {
		return "TrkTruckMob";
	}
	public string GetTitle() {
		return "Truck Mobile:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkTruckMob.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkTruckMob/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkTruckMob' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkTruckMob.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkTruckMob";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkTruckMob")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkTruckMob", "@TrkTruckMob", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkTruckMob", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkTruckMob", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

