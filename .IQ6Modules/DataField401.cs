
	
public partial class TruckMileage_TrkMPurchDate : 
	DateDataFieldBase<TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date of Purchase";}
		set { } 
	}

	public string DFName=> "TrkMPurchDate";

	
	public TruckMileage_TrkMPurchDate(TruckMileage Parent) : 
		base(Parent, "TrkMPurchDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class TruckMileage_TrkMPurchDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMPurchDate").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMPurchDate").First().Value(new TruckMileage());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 401;
	}
	public string GetControlName() {
		return "TrkMPurchDateValue";
	}
	public string GetDFName() {
		return "TrkMPurchDate";
	}
	public string GetTitle() {
		return "Date of Purchase";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMPurchDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMPurchDate/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkMPurchDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMPurchDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMPurchDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMPurchDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMPurchDate", "@TrkMPurchDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMPurchDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMPurchDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

