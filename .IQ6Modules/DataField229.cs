
	
public partial class CNLine_CNLVATAmt : 
	FormattableDataFieldBase<double,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Amount";}
		set { } 
	}

	public string DFName=> "CNLVATAmt";

	
	public CNLine_CNLVATAmt(CNLine Parent) : 
		base(Parent, "CNLVATAmt"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLVATAmtFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATAmt").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLVATAmt").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 229;
	}
	public string GetControlName() {
		return "CNLVATAmtValue";
	}
	public string GetDFName() {
		return "CNLVATAmt";
	}
	public string GetTitle() {
		return "VAT Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLVATAmt.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLVATAmt/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLVATAmt' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLVATAmt.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLVATAmt";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLVATAmt")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLVATAmt", "@CNLVATAmt", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLVATAmt", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLVATAmt", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

