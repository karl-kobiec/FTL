
	
public partial class DutyRateHist_DRHAlcPct : 
	FormattableDataFieldBase<double,DutyRateHist>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Alcohol %age";}
		set { } 
	}

	public string DFName=> "DRHAlcPct";

	
	public DutyRateHist_DRHAlcPct(DutyRateHist Parent) : 
		base(Parent, "DRHAlcPct"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class DutyRateHist_DRHAlcPctFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHAlcPct").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHAlcPct").First().Value(new DutyRateHist());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 549;
	}
	public string GetControlName() {
		return "DRHAlcPctValue";
	}
	public string GetDFName() {
		return "DRHAlcPct";
	}
	public string GetTitle() {
		return "Alcohol %age";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DutyRateHist ds;
					ds = (DutyRateHist)dsI;
		 
		
		return ds.DRHAlcPct.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DutyRateHist ds;
				ds = (DutyRateHist)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHAlcPct/?RecId=[[RecId]]',$(this));\" data-bound-name='DRHAlcPct' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DRHAlcPct.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DRHAlcPct";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DRHAlcPct")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DRHAlcPct", "@DRHAlcPct", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DRHAlcPct", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DutyRateHist").GetFieldOperators("DRHAlcPct", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

