
	
public partial class CN_CNVehicle : 
	DataFieldBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Vehicle";}
		set { } 
	}

	public string DFName=> "CNVehicle";

	
	public CN_CNVehicle(CN Parent) : 
		base(Parent, "CNVehicle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNVehicleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNVehicle").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNVehicle").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 205;
	}
	public string GetControlName() {
		return "CNVehicleValue";
	}
	public string GetDFName() {
		return "CNVehicle";
	}
	public string GetTitle() {
		return "Vehicle";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNVehicle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNVehicle/?RecId=[[RecId]]',$(this));\" data-bound-name='CNVehicle' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNVehicle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNVehicle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNVehicle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNVehicle", "@CNVehicle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNVehicle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNVehicle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

