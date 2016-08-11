
	
public partial class DriverHrs_DrvHHrs : 
	FormattableDataFieldBase<double,DriverHrs>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Hours";}
		set { } 
	}

	public string DFName=> "DrvHHrs";

	
	public DriverHrs_DrvHHrs(DriverHrs Parent) : 
		base(Parent, "DrvHHrs"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class DriverHrs_DrvHHrsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHHrs").Any()) 
			return DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHHrs").First().Value(new DriverHrs());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 278;
	}
	public string GetControlName() {
		return "DrvHHrsValue";
	}
	public string GetDFName() {
		return "DrvHHrs";
	}
	public string GetTitle() {
		return "Hours";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DriverHrs ds;
					ds = (DriverHrs)dsI;
		 
		
		return ds.DrvHHrs.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DriverHrs ds;
				ds = (DriverHrs)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHHrs/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvHHrs' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvHHrs.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvHHrs";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvHHrs")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvHHrs", "@DrvHHrs", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvHHrs", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DriverHrs").GetFieldOperators("DrvHHrs", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

