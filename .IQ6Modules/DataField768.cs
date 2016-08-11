
	
public partial class Truck_TrkTAXDate : 
	DateDataFieldBase<Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "TAX Due Date";}
		set { } 
	}

	public string DFName=> "TrkTAXDate";

	
	public Truck_TrkTAXDate(Truck Parent) : 
		base(Parent, "TrkTAXDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkTAXDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkTAXDate").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkTAXDate").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 768;
	}
	public string GetControlName() {
		return "TrkTAXDateValue";
	}
	public string GetDFName() {
		return "TrkTAXDate";
	}
	public string GetTitle() {
		return "TAX Due Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkTAXDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkTAXDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrkTAXDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkTAXDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkTAXDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkTAXDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkTAXDate", "@TrkTAXDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkTAXDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkTAXDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

