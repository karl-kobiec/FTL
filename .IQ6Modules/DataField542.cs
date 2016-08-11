
	
public partial class REDSTax_RDTaxAlcPct : 
	FormattableDataFieldBase<double,REDSTax>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Alcohol Percentage";}
		set { } 
	}

	public string DFName=> "RDTaxAlcPct";

	
	public REDSTax_RDTaxAlcPct(REDSTax Parent) : 
		base(Parent, "RDTaxAlcPct"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class REDSTax_RDTaxAlcPctFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxAlcPct").Any()) 
			return DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxAlcPct").First().Value(new REDSTax());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 542;
	}
	public string GetControlName() {
		return "RDTaxAlcPctValue";
	}
	public string GetDFName() {
		return "RDTaxAlcPct";
	}
	public string GetTitle() {
		return "Alcohol Percentage";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSTax ds;
					ds = (REDSTax)dsI;
		 
		
		return ds.RDTaxAlcPct.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSTax ds;
				ds = (REDSTax)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxAlcPct/?RecId=[[RecId]]',$(this));\" data-bound-name='RDTaxAlcPct' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDTaxAlcPct.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDTaxAlcPct";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDTaxAlcPct")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDTaxAlcPct", "@RDTaxAlcPct", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDTaxAlcPct", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSTax").GetFieldOperators("RDTaxAlcPct", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

