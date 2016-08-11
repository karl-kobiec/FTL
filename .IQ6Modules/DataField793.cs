
	
public partial class Driver_DrvAddress : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Address";}
		set { } 
	}

	public string DFName=> "DrvAddress";

	
	public Driver_DrvAddress(Driver Parent) : 
		base(Parent, "DrvAddress"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvAddressFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvAddress").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvAddress").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 793;
	}
	public string GetControlName() {
		return "DrvAddressValue";
	}
	public string GetDFName() {
		return "DrvAddress";
	}
	public string GetTitle() {
		return "Address";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvAddress.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvAddress/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='DrvAddress'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvAddress.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvAddress";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvAddress")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvAddress", "@DrvAddress", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvAddress", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvAddress", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

