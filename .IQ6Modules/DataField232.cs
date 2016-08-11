
	
public partial class Driver_DrvId : 
	FormattableDataFieldBase<int,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Driver ID";}
		set { } 
	}

	public string DFName=> "DrvId";

	
	public Driver_DrvId(Driver Parent) : 
		base(Parent, "DrvId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Driver_DrvIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvId").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvId").First().Value(new Driver());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 232;
	}
	public string GetControlName() {
		return "DrvIdValue";
	}
	public string GetDFName() {
		return "DrvId";
	}
	public string GetTitle() {
		return "Driver ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvId/?RecId=[[RecId]]',$(this));\" data-bound-name='DrvId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvId", "@DrvId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

