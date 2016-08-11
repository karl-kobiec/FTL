
	
public partial class FerryRoute_FRName : 
	DataFieldBase<string,FerryRoute>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route";}
		set { } 
	}

	public string DFName=> "FRName";

	
	public FerryRoute_FRName(FerryRoute Parent) : 
		base(Parent, "FRName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class FerryRoute_FRNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRName").Any()) 
			return DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRName").First().Value(new FerryRoute());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 87;
	}
	public string GetControlName() {
		return "FRNameValue";
	}
	public string GetDFName() {
		return "FRName";
	}
	public string GetTitle() {
		return "Route";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		FerryRoute ds;
					ds = (FerryRoute)dsI;
		 
		
		return ds.FRName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		FerryRoute ds;
				ds = (FerryRoute)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRName/?RecId=[[RecId]]',$(this));\" data-bound-name='FRName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.FRName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "FRName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "FRName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "FRName", "@FRName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "FRName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("FerryRoute").GetFieldOperators("FRName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

