
	
public partial class Driver_DrvNextOfKin : 
	DataFieldBase<string,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Next of Kin";}
		set { } 
	}

	public string DFName=> "DrvNextOfKin";

	
	public Driver_DrvNextOfKin(Driver Parent) : 
		base(Parent, "DrvNextOfKin"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Driver_DrvNextOfKinFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvNextOfKin").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvNextOfKin").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 800;
	}
	public string GetControlName() {
		return "DrvNextOfKinValue";
	}
	public string GetDFName() {
		return "DrvNextOfKin";
	}
	public string GetTitle() {
		return "Next of Kin";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvNextOfKin.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvNextOfKin/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='DrvNextOfKin'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvNextOfKin.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvNextOfKin";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvNextOfKin")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvNextOfKin", "@DrvNextOfKin", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvNextOfKin", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvNextOfKin", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

