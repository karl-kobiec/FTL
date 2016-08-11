
	
public partial class VATCodes_VATRate : 
	DataFieldBase<double,VATCodes>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Rate";}
		set { } 
	}

	public string DFName=> "VATRate";

	
	public VATCodes_VATRate(VATCodes Parent) : 
		base(Parent, "VATRate"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class VATCodes_VATRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATRate").Any()) 
			return DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATRate").First().Value(new VATCodes());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 127;
	}
	public string GetControlName() {
		return "VATRateValue";
	}
	public string GetDFName() {
		return "VATRate";
	}
	public string GetTitle() {
		return "VAT Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		VATCodes ds;
					ds = (VATCodes)dsI;
		 
		
		return ds.VATRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		VATCodes ds;
				ds = (VATCodes)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATRate/?RecId=[[RecId]]',$(this));\" data-bound-name='VATRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.VATRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "VATRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "VATRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "VATRate", "@VATRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "VATRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("VATCodes").GetFieldOperators("VATRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

