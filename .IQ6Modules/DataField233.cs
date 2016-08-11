
	
public partial class Driver_DrvName : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Driver Name";}
		set { } 
	}

	public string DFName=> "DrvName";

	
	public Driver_DrvName(Driver Parent) : 
		base(Parent, "DrvName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvName").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvName").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 233;
	}
	public string GetControlName() {
		return "DrvNameValue";
	}
	public string GetDFName() {
		return "DrvName";
	}
	public string GetTitle() {
		return "Driver Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvName/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvName", "@DrvName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

