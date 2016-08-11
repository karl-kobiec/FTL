
	
public partial class Driver_DrvEmpStart : 
	DateDataFieldBase<Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Emp Start Date";}
		set { } 
	}

	public string DFName=> "DrvEmpStart";

	
	public Driver_DrvEmpStart(Driver Parent) : 
		base(Parent, "DrvEmpStart"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvEmpStartFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvEmpStart").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvEmpStart").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 795;
	}
	public string GetControlName() {
		return "DrvEmpStartValue";
	}
	public string GetDFName() {
		return "DrvEmpStart";
	}
	public string GetTitle() {
		return "Emp Start Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvEmpStart.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvEmpStart/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='DrvEmpStart' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvEmpStart.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvEmpStart";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvEmpStart")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvEmpStart", "@DrvEmpStart", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvEmpStart", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvEmpStart", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

