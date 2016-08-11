
	
public partial class FerryRoute_FRCode : 
	DataFieldBase<string,FerryRoute>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route Code";}
		set { } 
	}

	public string DFName=> "FRCode";

	
	public FerryRoute_FRCode(FerryRoute Parent) : 
		base(Parent, "FRCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class FerryRoute_FRCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRCode").Any()) 
			return DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRCode").First().Value(new FerryRoute());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 86;
	}
	public string GetControlName() {
		return "FRCodeValue";
	}
	public string GetDFName() {
		return "FRCode";
	}
	public string GetTitle() {
		return "Route Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		FerryRoute ds;
					ds = (FerryRoute)dsI;
		 
		
		return ds.FRCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		FerryRoute ds;
				ds = (FerryRoute)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRCode/?RecId=[[RecId]]',$(this));\" data-bound-name='FRCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.FRCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "FRCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "FRCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "FRCode", "@FRCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "FRCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("FerryRoute").GetFieldOperators("FRCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

