
	
public partial class DutyRateHist_DRHChangeDate : 
	DateDataFieldBase<DutyRateHist>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date of Change";}
		set { } 
	}

	public string DFName=> "DRHChangeDate";

	
	public DutyRateHist_DRHChangeDate(DutyRateHist Parent) : 
		base(Parent, "DRHChangeDate"
			,"dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class DutyRateHist_DRHChangeDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHChangeDate").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHChangeDate").First().Value(new DutyRateHist());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 547;
	}
	public string GetControlName() {
		return "DRHChangeDateValue";
	}
	public string GetDFName() {
		return "DRHChangeDate";
	}
	public string GetTitle() {
		return "Date of Change";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DutyRateHist ds;
					ds = (DutyRateHist)dsI;
		 
		
		return ds.DRHChangeDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DutyRateHist ds;
				ds = (DutyRateHist)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHChangeDate/?RecId=[[RecId]]',$(this));\" data-bound-name='DRHChangeDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DRHChangeDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DRHChangeDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DRHChangeDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DRHChangeDate", "@DRHChangeDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DRHChangeDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DutyRateHist").GetFieldOperators("DRHChangeDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

