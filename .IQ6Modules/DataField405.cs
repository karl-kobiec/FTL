
	
public partial class TruckMileage_TrkMNextReading : 
	FormattableDataFieldBase<int,TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Next reading (km)";}
		set { } 
	}

	public string DFName=> "TrkMNextReading";

	
	public TruckMileage_TrkMNextReading(TruckMileage Parent) : 
		base(Parent, "TrkMNextReading"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class TruckMileage_TrkMNextReadingFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMNextReading").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMNextReading").First().Value(new TruckMileage());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 405;
	}
	public string GetControlName() {
		return "TrkMNextReadingValue";
	}
	public string GetDFName() {
		return "TrkMNextReading";
	}
	public string GetTitle() {
		return "Next reading (km)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMNextReading.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMNextReading/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkMNextReading' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMNextReading.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMNextReading";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMNextReading")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMNextReading", "@TrkMNextReading", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMNextReading", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMNextReading", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

