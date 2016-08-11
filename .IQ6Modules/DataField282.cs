
	
public partial class Driver_DrvActive : 
	BoolDataFieldBase<Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Active";}
		set { } 
	}

	public string DFName=> "DrvActive";

	
	public Driver_DrvActive(Driver Parent) : 
		base(Parent, "DrvActive"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("True");
				    }
}


public partial class Driver_DrvActiveFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvActive").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvActive").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 282;
	}
	public string GetControlName() {
		return "DrvActiveValue";
	}
	public string GetDFName() {
		return "DrvActive";
	}
	public string GetTitle() {
		return "Active";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvActive.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Driver/SaveDrvActive/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='DrvActive' [[Val]] /><input type = 'hidden' data-bound-name='DrvActive' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvActive.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvActive";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "DrvActive")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvActive", "@DrvActive", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvActive", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvActive", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

