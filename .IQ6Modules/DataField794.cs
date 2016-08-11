
	
public partial class Driver_DrvDoB : 
	DateDataFieldBase<Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date Of Birth";}
		set { } 
	}

	public string DFName=> "DrvDoB";

	
	public Driver_DrvDoB(Driver Parent) : 
		base(Parent, "DrvDoB"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvDoBFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvDoB").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvDoB").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 794;
	}
	public string GetControlName() {
		return "DrvDoBValue";
	}
	public string GetDFName() {
		return "DrvDoB";
	}
	public string GetTitle() {
		return "Date Of Birth";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvDoB.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvDoB/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='DrvDoB' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvDoB.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvDoB";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvDoB")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvDoB", "@DrvDoB", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvDoB", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvDoB", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

