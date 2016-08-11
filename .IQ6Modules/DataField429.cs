
	
public partial class FerryRoute_FRId : 
	FormattableDataFieldBase<int,FerryRoute>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route Id";}
		set { } 
	}

	public string DFName=> "FRId";

	
	public FerryRoute_FRId(FerryRoute Parent) : 
		base(Parent, "FRId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class FerryRoute_FRIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRId").Any()) 
			return DS.GetManager<FerryRoute>().OnDataSource.Where(f=> f.Key == "FRId").First().Value(new FerryRoute());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 429;
	}
	public string GetControlName() {
		return "FRIdValue";
	}
	public string GetDFName() {
		return "FRId";
	}
	public string GetTitle() {
		return "Route Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		FerryRoute ds;
					ds = (FerryRoute)dsI;
		 
		
		return ds.FRId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		FerryRoute ds;
				ds = (FerryRoute)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/FerryRoute/SaveFRId/?RecId=[[RecId]]',$(this));\" data-bound-name='FRId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.FRId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "FRId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "FRId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "FRId", "@FRId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "FRId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("FerryRoute").GetFieldOperators("FRId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

