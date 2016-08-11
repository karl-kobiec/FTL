
	
public partial class Customer_CustRates : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Rates";}
		set { } 
	}

	public string DFName=> "CustRates";

	
	public Customer_CustRates(Customer Parent) : 
		base(Parent, "CustRates"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustRatesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustRates").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustRates").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 28;
	}
	public string GetControlName() {
		return "CustRatesValue";
	}
	public string GetDFName() {
		return "CustRates";
	}
	public string GetTitle() {
		return "Rates";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustRates.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "[[Val]]";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustRates.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustRates";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustRates")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustRates", "@CustRates", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustRates", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustRates", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

