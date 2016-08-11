
	
public partial class Driver_DrvMobile : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Mobile Number";}
		set { } 
	}

	public string DFName=> "DrvMobile";

	
	public Driver_DrvMobile(Driver Parent) : 
		base(Parent, "DrvMobile"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvMobileFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvMobile").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvMobile").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 786;
	}
	public string GetControlName() {
		return "DrvMobileValue";
	}
	public string GetDFName() {
		return "DrvMobile";
	}
	public string GetTitle() {
		return "Mobile Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvMobile.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvMobile/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvMobile' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvMobile.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvMobile";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvMobile")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvMobile", "@DrvMobile", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvMobile", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvMobile", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

