
	
public partial class Driver_DrvTacho : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Drivers Digital Tacho Card No";}
		set { } 
	}

	public string DFName=> "DrvTacho";

	
	public Driver_DrvTacho(Driver Parent) : 
		base(Parent, "DrvTacho"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvTachoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvTacho").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvTacho").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 797;
	}
	public string GetControlName() {
		return "DrvTachoValue";
	}
	public string GetDFName() {
		return "DrvTacho";
	}
	public string GetTitle() {
		return "Drivers Digital Tacho Card No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvTacho.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvTacho/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvTacho' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvTacho.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvTacho";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvTacho")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvTacho", "@DrvTacho", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvTacho", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvTacho", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

