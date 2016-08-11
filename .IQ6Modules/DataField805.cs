
	
public partial class Truck_TrkDKVPIN : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "DKV Pin No:";}
		set { } 
	}

	public string DFName=> "TrkDKVPIN";

	
	public Truck_TrkDKVPIN(Truck Parent) : 
		base(Parent, "TrkDKVPIN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkDKVPINFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDKVPIN").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDKVPIN").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 805;
	}
	public string GetControlName() {
		return "TrkDKVPINValue";
	}
	public string GetDFName() {
		return "TrkDKVPIN";
	}
	public string GetTitle() {
		return "DKV Pin No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkDKVPIN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDKVPIN/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkDKVPIN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkDKVPIN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkDKVPIN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkDKVPIN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkDKVPIN", "@TrkDKVPIN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkDKVPIN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkDKVPIN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

