
	
public partial class Customer_CustVATNo : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Number";}
		set { } 
	}

	public string DFName=> "CustVATNo";

	
	public Customer_CustVATNo(Customer Parent) : 
		base(Parent, "CustVATNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustVATNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustVATNo").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustVATNo").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 23;
	}
	public string GetControlName() {
		return "CustVATNoValue";
	}
	public string GetDFName() {
		return "CustVATNo";
	}
	public string GetTitle() {
		return "VAT Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustVATNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustVATNo/?RecId=[[RecId]]',$(this));\" data-bound-name='CustVATNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustVATNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustVATNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustVATNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustVATNo", "@CustVATNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustVATNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustVATNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

