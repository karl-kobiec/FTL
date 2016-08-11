
	
public partial class Truck_TrkMOTDate : 
	DateDataFieldBase<Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "MOT Date";}
		set { } 
	}

	public string DFName=> "TrkMOTDate";

	
	public Truck_TrkMOTDate(Truck Parent) : 
		base(Parent, "TrkMOTDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkMOTDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkMOTDate").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkMOTDate").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 767;
	}
	public string GetControlName() {
		return "TrkMOTDateValue";
	}
	public string GetDFName() {
		return "TrkMOTDate";
	}
	public string GetTitle() {
		return "MOT Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkMOTDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkMOTDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrkMOTDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMOTDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMOTDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMOTDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMOTDate", "@TrkMOTDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMOTDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkMOTDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

