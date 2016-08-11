
	
public partial class VATCodes_VATName : 
	DataFieldBase<string,VATCodes>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description";}
		set { } 
	}

	public string DFName=> "VATName";

	
	public VATCodes_VATName(VATCodes Parent) : 
		base(Parent, "VATName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class VATCodes_VATNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATName").Any()) 
			return DS.GetManager<VATCodes>().OnDataSource.Where(f=> f.Key == "VATName").First().Value(new VATCodes());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 126;
	}
	public string GetControlName() {
		return "VATNameValue";
	}
	public string GetDFName() {
		return "VATName";
	}
	public string GetTitle() {
		return "Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		VATCodes ds;
					ds = (VATCodes)dsI;
		 
		
		return ds.VATName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		VATCodes ds;
				ds = (VATCodes)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/VATCodes/SaveVATName/?RecId=[[RecId]]',$(this));\" data-bound-name='VATName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.VATName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "VATName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "VATName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "VATName", "@VATName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "VATName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("VATCodes").GetFieldOperators("VATName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

