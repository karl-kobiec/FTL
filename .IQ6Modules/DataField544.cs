
	
public partial class REDSTax_RDTaxDutyRate : 
	DataFieldBase<double,REDSTax>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Duty Rate £ per ltr";}
		set { } 
	}

	public string DFName=> "RDTaxDutyRate";

	
	public REDSTax_RDTaxDutyRate(REDSTax Parent) : 
		base(Parent, "RDTaxDutyRate"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class REDSTax_RDTaxDutyRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxDutyRate").Any()) 
			return DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxDutyRate").First().Value(new REDSTax());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 544;
	}
	public string GetControlName() {
		return "RDTaxDutyRateValue";
	}
	public string GetDFName() {
		return "RDTaxDutyRate";
	}
	public string GetTitle() {
		return "Duty Rate £ per ltr";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSTax ds;
					ds = (REDSTax)dsI;
		 
		
		return ds.RDTaxDutyRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSTax ds;
				ds = (REDSTax)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxDutyRate/?RecId=[[RecId]]',$(this));\" data-bound-name='RDTaxDutyRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDTaxDutyRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDTaxDutyRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDTaxDutyRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDTaxDutyRate", "@RDTaxDutyRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDTaxDutyRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSTax").GetFieldOperators("RDTaxDutyRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

