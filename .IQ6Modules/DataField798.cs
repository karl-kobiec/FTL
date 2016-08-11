
	
public partial class Driver_DrvCPC : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Drivers CPC Card No";}
		set { } 
	}

	public string DFName=> "DrvCPC";

	
	public Driver_DrvCPC(Driver Parent) : 
		base(Parent, "DrvCPC"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvCPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvCPC").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvCPC").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 798;
	}
	public string GetControlName() {
		return "DrvCPCValue";
	}
	public string GetDFName() {
		return "DrvCPC";
	}
	public string GetTitle() {
		return "Drivers CPC Card No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvCPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvCPC/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvCPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvCPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvCPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvCPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvCPC", "@DrvCPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvCPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvCPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

