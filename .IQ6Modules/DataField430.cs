
	
public partial class VATCodes_VATId : 
	FormattableDataFieldBase<int,VATCodes>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Id";}
		set { } 
	}

	public string DFName=> "VATId";

	
	public VATCodes_VATId(VATCodes Parent) : 
		base(Parent, "VATId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class VATCodes_VATIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATId").Any()) 
			return DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATId").First().Value(new VATCodes());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 430;
	}
	public string GetControlName() {
		return "VATIdValue";
	}
	public string GetDFName() {
		return "VATId";
	}
	public string GetTitle() {
		return "VAT Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		VATCodes ds;
					ds = (VATCodes)dsI;
		 
		
		return ds.VATId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		VATCodes ds;
				ds = (VATCodes)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATId/?RecId=[[RecId]]',$(this));\" data-bound-name='VATId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.VATId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "VATId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "VATId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "VATId", "@VATId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "VATId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("VATCodes").GetFieldOperators("VATId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

