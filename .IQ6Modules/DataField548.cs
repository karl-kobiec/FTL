
	
public partial class DutyRateHist_DRHDutyRate : 
	FormattableDataFieldBase<double,DutyRateHist>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Duty Rate";}
		set { } 
	}

	public string DFName=> "DRHDutyRate";

	
	public DutyRateHist_DRHDutyRate(DutyRateHist Parent) : 
		base(Parent, "DRHDutyRate"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class DutyRateHist_DRHDutyRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHDutyRate").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHDutyRate").First().Value(new DutyRateHist());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 548;
	}
	public string GetControlName() {
		return "DRHDutyRateValue";
	}
	public string GetDFName() {
		return "DRHDutyRate";
	}
	public string GetTitle() {
		return "Duty Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DutyRateHist ds;
					ds = (DutyRateHist)dsI;
		 
		
		return ds.DRHDutyRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DutyRateHist ds;
				ds = (DutyRateHist)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHDutyRate/?RecId=[[RecId]]',$(this));\" data-bound-name='DRHDutyRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DRHDutyRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DRHDutyRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DRHDutyRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DRHDutyRate", "@DRHDutyRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DRHDutyRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DutyRateHist").GetFieldOperators("DRHDutyRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

