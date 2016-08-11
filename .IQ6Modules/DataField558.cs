
	
public partial class REDSTax_RDTaxId : 
	FormattableDataFieldBase<int,REDSTax>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tax Code Id";}
		set { } 
	}

	public string DFName=> "RDTaxId";

	
	public REDSTax_RDTaxId(REDSTax Parent) : 
		base(Parent, "RDTaxId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class REDSTax_RDTaxIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxId").Any()) 
			return DS.GetManager<REDSTax>().OnDataSource.Where(f=> f.Key == "RDTaxId").First().Value(new REDSTax());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 558;
	}
	public string GetControlName() {
		return "RDTaxIdValue";
	}
	public string GetDFName() {
		return "RDTaxId";
	}
	public string GetTitle() {
		return "Tax Code Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSTax ds;
					ds = (REDSTax)dsI;
		 
		
		return ds.RDTaxId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSTax ds;
				ds = (REDSTax)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSTax/SaveRDTaxId/?RecId=[[RecId]]',$(this));\" data-bound-name='RDTaxId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDTaxId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDTaxId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDTaxId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDTaxId", "@RDTaxId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDTaxId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSTax").GetFieldOperators("RDTaxId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

