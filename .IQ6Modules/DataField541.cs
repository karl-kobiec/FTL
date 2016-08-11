
	
public partial class REDSTax_RDTaxCode : 
	DataFieldBase<string,REDSTax>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tax Code";}
		set { } 
	}

	public string DFName=> "RDTaxCode";

	
	public REDSTax_RDTaxCode(REDSTax Parent) : 
		base(Parent, "RDTaxCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class REDSTax_RDTaxCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxCode").Any()) 
			return DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxCode").First().Value(new REDSTax());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 541;
	}
	public string GetControlName() {
		return "RDTaxCodeValue";
	}
	public string GetDFName() {
		return "RDTaxCode";
	}
	public string GetTitle() {
		return "Tax Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSTax ds;
					ds = (REDSTax)dsI;
		 
		
		return ds.RDTaxCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSTax ds;
				ds = (REDSTax)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxCode/?RecId=[[RecId]]',$(this));\" data-bound-name='RDTaxCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDTaxCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDTaxCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDTaxCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDTaxCode", "@RDTaxCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDTaxCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSTax").GetFieldOperators("RDTaxCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

