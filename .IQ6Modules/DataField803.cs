
	
public partial class Truck_TrkAS24PIN : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "AS24 Pin No:";}
		set { } 
	}

	public string DFName=> "TrkAS24PIN";

	
	public Truck_TrkAS24PIN(Truck Parent) : 
		base(Parent, "TrkAS24PIN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkAS24PINFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkAS24PIN").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkAS24PIN").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 803;
	}
	public string GetControlName() {
		return "TrkAS24PINValue";
	}
	public string GetDFName() {
		return "TrkAS24PIN";
	}
	public string GetTitle() {
		return "AS24 Pin No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkAS24PIN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkAS24PIN/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkAS24PIN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkAS24PIN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkAS24PIN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkAS24PIN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkAS24PIN", "@TrkAS24PIN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkAS24PIN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkAS24PIN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

