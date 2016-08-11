
	
public partial class DutyRateHist_DRHId : 
	FormattableDataFieldBase<int,DutyRateHist>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "History Id";}
		set { } 
	}

	public string DFName=> "DRHId";

	
	public DutyRateHist_DRHId(DutyRateHist Parent) : 
		base(Parent, "DRHId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class DutyRateHist_DRHIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHId").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHId").First().Value(new DutyRateHist());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 559;
	}
	public string GetControlName() {
		return "DRHIdValue";
	}
	public string GetDFName() {
		return "DRHId";
	}
	public string GetTitle() {
		return "History Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DutyRateHist ds;
					ds = (DutyRateHist)dsI;
		 
		
		return ds.DRHId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DutyRateHist ds;
				ds = (DutyRateHist)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHId/?RecId=[[RecId]]',$(this));\" data-bound-name='DRHId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DRHId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DRHId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DRHId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DRHId", "@DRHId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DRHId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DutyRateHist").GetFieldOperators("DRHId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

