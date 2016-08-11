
	
public partial class CNLine_CNLVATRate : 
	DataFieldBase<double,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Rate";}
		set { } 
	}

	public string DFName=> "CNLVATRate";

	
	public CNLine_CNLVATRate(CNLine Parent) : 
		base(Parent, "CNLVATRate"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLVATRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATRate").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATRate").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 227;
	}
	public string GetControlName() {
		return "CNLVATRateValue";
	}
	public string GetDFName() {
		return "CNLVATRate";
	}
	public string GetTitle() {
		return "VAT Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLVATRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATRate/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLVATRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLVATRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLVATRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLVATRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLVATRate", "@CNLVATRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLVATRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLVATRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

