
	
public partial class REDSTax_RDTaxType : 
	FormattableDataFieldBase<int,REDSTax>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Type";}
		set { } 
	}

	public string DFName=> "RDTaxType";

	
	public REDSTax_RDTaxType(REDSTax Parent) : 
		base(Parent, "RDTaxType"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSTax_RDTaxTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxType").Any()) 
			return DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxType").First().Value(new REDSTax());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 543;
	}
	public string GetControlName() {
		return "RDTaxTypeValue";
	}
	public string GetDFName() {
		return "RDTaxType";
	}
	public string GetTitle() {
		return "Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSTax ds;
					ds = (REDSTax)dsI;
		 
		
		return ds.RDTaxType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSTax ds;
				ds = (REDSTax)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxType/?RecId=[[RecId]]',$(this));\" data-bound-name='RDTaxType' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDTaxType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDTaxType";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDTaxType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDTaxType", "@RDTaxType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDTaxType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSTax").GetFieldOperators("RDTaxType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

