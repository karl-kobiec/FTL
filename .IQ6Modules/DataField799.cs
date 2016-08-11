
	
public partial class Driver_DrvPpNo : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Passport No";}
		set { } 
	}

	public string DFName=> "DrvPpNo";

	
	public Driver_DrvPpNo(Driver Parent) : 
		base(Parent, "DrvPpNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvPpNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvPpNo").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvPpNo").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 799;
	}
	public string GetControlName() {
		return "DrvPpNoValue";
	}
	public string GetDFName() {
		return "DrvPpNo";
	}
	public string GetTitle() {
		return "Passport No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvPpNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvPpNo/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvPpNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvPpNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvPpNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvPpNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvPpNo", "@DrvPpNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvPpNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvPpNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

