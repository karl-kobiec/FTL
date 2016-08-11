
	
public partial class InvLine_InvLVATAmt : 
	FormattableDataFieldBase<double,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Amount";}
		set { } 
	}

	public string DFName=> "InvLVATAmt";

	
	public InvLine_InvLVATAmt(InvLine Parent) : 
		base(Parent, "InvLVATAmt"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLVATAmtFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATAmt").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATAmt").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 123;
	}
	public string GetControlName() {
		return "InvLVATAmtValue";
	}
	public string GetDFName() {
		return "InvLVATAmt";
	}
	public string GetTitle() {
		return "VAT Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLVATAmt.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATAmt/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLVATAmt' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLVATAmt.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLVATAmt";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLVATAmt")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLVATAmt", "@InvLVATAmt", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLVATAmt", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLVATAmt", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

