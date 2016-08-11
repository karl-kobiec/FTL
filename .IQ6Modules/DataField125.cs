
	
public partial class VATCodes_VATCode : 
	DataFieldBase<string,VATCodes>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Code";}
		set { } 
	}

	public string DFName=> "VATCode";

	
	public VATCodes_VATCode(VATCodes Parent) : 
		base(Parent, "VATCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class VATCodes_VATCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATCode").Any()) 
			return DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATCode").First().Value(new VATCodes());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 125;
	}
	public string GetControlName() {
		return "VATCodeValue";
	}
	public string GetDFName() {
		return "VATCode";
	}
	public string GetTitle() {
		return "VAT Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		VATCodes ds;
					ds = (VATCodes)dsI;
		 
		
		return ds.VATCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		VATCodes ds;
				ds = (VATCodes)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATCode/?RecId=[[RecId]]',$(this));\" data-bound-name='VATCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.VATCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "VATCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "VATCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "VATCode", "@VATCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "VATCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("VATCodes").GetFieldOperators("VATCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

