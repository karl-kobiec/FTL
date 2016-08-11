
	
public partial class InvLine_InvLVATRate : 
	DataFieldBase<double,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Rate";}
		set { } 
	}

	public string DFName=> "InvLVATRate";

	
	public InvLine_InvLVATRate(InvLine Parent) : 
		base(Parent, "InvLVATRate"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLVATRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATRate").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLVATRate").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 121;
	}
	public string GetControlName() {
		return "InvLVATRateValue";
	}
	public string GetDFName() {
		return "InvLVATRate";
	}
	public string GetTitle() {
		return "VAT Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLVATRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLVATRate/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLVATRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLVATRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLVATRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLVATRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLVATRate", "@InvLVATRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLVATRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLVATRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

