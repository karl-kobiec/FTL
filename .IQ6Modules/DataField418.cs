
	
public partial class Customer_CustPhone : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Telephone";}
		set { } 
	}

	public string DFName=> "CustPhone";

	
	public Customer_CustPhone(Customer Parent) : 
		base(Parent, "CustPhone"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustPhoneFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPhone").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPhone").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 418;
	}
	public string GetControlName() {
		return "CustPhoneValue";
	}
	public string GetDFName() {
		return "CustPhone";
	}
	public string GetTitle() {
		return "Telephone";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustPhone.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustPhone/?RecId=[[RecId]]',$(this));\" data-bound-name='CustPhone' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustPhone.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustPhone";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustPhone")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustPhone", "@CustPhone", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustPhone", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustPhone", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

