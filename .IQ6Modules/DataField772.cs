
	
public partial class Driver_DrvPspExpiry : 
	DateDataFieldBase<Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Passport Expiry";}
		set { } 
	}

	public string DFName=> "DrvPspExpiry";

	
	public Driver_DrvPspExpiry(Driver Parent) : 
		base(Parent, "DrvPspExpiry"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvPspExpiryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvPspExpiry").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvPspExpiry").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 772;
	}
	public string GetControlName() {
		return "DrvPspExpiryValue";
	}
	public string GetDFName() {
		return "DrvPspExpiry";
	}
	public string GetTitle() {
		return "Passport Expiry";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvPspExpiry.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvPspExpiry/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='DrvPspExpiry' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvPspExpiry.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvPspExpiry";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvPspExpiry")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvPspExpiry", "@DrvPspExpiry", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvPspExpiry", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvPspExpiry", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

