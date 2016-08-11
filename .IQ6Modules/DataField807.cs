
	
public partial class Truck_TrkShellPIN : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Shell Pin No:";}
		set { } 
	}

	public string DFName=> "TrkShellPIN";

	
	public Truck_TrkShellPIN(Truck Parent) : 
		base(Parent, "TrkShellPIN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkShellPINFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkShellPIN").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkShellPIN").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 807;
	}
	public string GetControlName() {
		return "TrkShellPINValue";
	}
	public string GetDFName() {
		return "TrkShellPIN";
	}
	public string GetTitle() {
		return "Shell Pin No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkShellPIN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkShellPIN/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkShellPIN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkShellPIN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkShellPIN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkShellPIN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkShellPIN", "@TrkShellPIN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkShellPIN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkShellPIN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

