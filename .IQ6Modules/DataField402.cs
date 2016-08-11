
	
public partial class TruckMileage_TrkMPurchLitre : 
	FormattableDataFieldBase<double,TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Litres purchased";}
		set { } 
	}

	public string DFName=> "TrkMPurchLitre";

	
	public TruckMileage_TrkMPurchLitre(TruckMileage Parent) : 
		base(Parent, "TrkMPurchLitre"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class TruckMileage_TrkMPurchLitreFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMPurchLitre").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMPurchLitre").First().Value(new TruckMileage());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 402;
	}
	public string GetControlName() {
		return "TrkMPurchLitreValue";
	}
	public string GetDFName() {
		return "TrkMPurchLitre";
	}
	public string GetTitle() {
		return "Litres purchased";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMPurchLitre.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMPurchLitre/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkMPurchLitre' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMPurchLitre.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMPurchLitre";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMPurchLitre")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMPurchLitre", "@TrkMPurchLitre", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMPurchLitre", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMPurchLitre", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

