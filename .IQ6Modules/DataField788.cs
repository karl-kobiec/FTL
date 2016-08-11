
	
public partial class Customer_CustAccContact : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Accounts Contact";}
		set { } 
	}

	public string DFName=> "CustAccContact";

	
	public Customer_CustAccContact(Customer Parent) : 
		base(Parent, "CustAccContact"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustAccContactFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAccContact").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAccContact").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 788;
	}
	public string GetControlName() {
		return "CustAccContactValue";
	}
	public string GetDFName() {
		return "CustAccContact";
	}
	public string GetTitle() {
		return "Accounts Contact";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAccContact.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAccContact/?RecId=[[RecId]]',$(this));\" data-bound-name='CustAccContact' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAccContact.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAccContact";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustAccContact")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAccContact", "@CustAccContact", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAccContact", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAccContact", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

