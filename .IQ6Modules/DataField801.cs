
	
public partial class Truck_TrkServiceDue : 
	DateDataFieldBase<Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Service Due";}
		set { } 
	}

	public string DFName=> "TrkServiceDue";

	
	public Truck_TrkServiceDue(Truck Parent) : 
		base(Parent, "TrkServiceDue"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkServiceDueFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkServiceDue").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkServiceDue").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 801;
	}
	public string GetControlName() {
		return "TrkServiceDueValue";
	}
	public string GetDFName() {
		return "TrkServiceDue";
	}
	public string GetTitle() {
		return "Service Due";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkServiceDue.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkServiceDue/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrkServiceDue' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkServiceDue.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkServiceDue";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkServiceDue")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkServiceDue", "@TrkServiceDue", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkServiceDue", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkServiceDue", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

