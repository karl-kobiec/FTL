
	
public partial class Customer_CustAddr : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Address1";}
		set { } 
	}

	public string DFName=> "CustAddr";

	
	public Customer_CustAddr(Customer Parent) : 
		base(Parent, "CustAddr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 411;
	}
	public string GetControlName() {
		return "CustAddrValue";
	}
	public string GetDFName() {
		return "CustAddr";
	}
	public string GetTitle() {
		return "Address1";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr/?RecId=[[RecId]]',$(this));\" data-bound-name='CustAddr' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAddr", "@CustAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

