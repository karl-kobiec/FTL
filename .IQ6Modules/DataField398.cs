
	
public partial class Truck_TrkName : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Registration No";}
		set { } 
	}

	public string DFName=> "TrkName";

	
	public Truck_TrkName(Truck Parent) : 
		base(Parent, "TrkName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkName").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkName").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 398;
	}
	public string GetControlName() {
		return "TrkNameValue";
	}
	public string GetDFName() {
		return "TrkName";
	}
	public string GetTitle() {
		return "Registration No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkName/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkName", "@TrkName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

