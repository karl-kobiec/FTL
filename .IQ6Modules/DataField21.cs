
	
public partial class Customer_CustSortCode : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sort Code";}
		set { } 
	}

	public string DFName=> "CustSortCode";

	
	public Customer_CustSortCode(Customer Parent) : 
		base(Parent, "CustSortCode"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustSortCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustSortCode").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustSortCode").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 21;
	}
	public string GetControlName() {
		return "CustSortCodeValue";
	}
	public string GetDFName() {
		return "CustSortCode";
	}
	public string GetTitle() {
		return "Sort Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustSortCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustSortCode/?RecId=[[RecId]]',$(this));\" data-bound-name='CustSortCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustSortCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustSortCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustSortCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustSortCode", "@CustSortCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustSortCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustSortCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

