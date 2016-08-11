
	
public partial class Customer_CustBondCode : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "REDS / Bond Code";}
		set { } 
	}

	public string DFName=> "CustBondCode";

	
	public Customer_CustBondCode(Customer Parent) : 
		base(Parent, "CustBondCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustBondCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustBondCode").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustBondCode").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 25;
	}
	public string GetControlName() {
		return "CustBondCodeValue";
	}
	public string GetDFName() {
		return "CustBondCode";
	}
	public string GetTitle() {
		return "REDS / Bond Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustBondCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustBondCode/?RecId=[[RecId]]',$(this));\" data-bound-name='CustBondCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustBondCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustBondCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustBondCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustBondCode", "@CustBondCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustBondCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustBondCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

