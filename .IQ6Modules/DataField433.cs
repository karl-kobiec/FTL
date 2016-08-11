
	
public partial class Customer_CustPassword : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Portal Password";}
		set { } 
	}

	public string DFName=> "CustPassword";

	
	public Customer_CustPassword(Customer Parent) : 
		base(Parent, "CustPassword"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustPasswordFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPassword").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPassword").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 433;
	}
	public string GetControlName() {
		return "CustPasswordValue";
	}
	public string GetDFName() {
		return "CustPassword";
	}
	public string GetTitle() {
		return "Portal Password";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustPassword.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustPassword/?RecId=[[RecId]]',$(this));\" data-bound-name='CustPassword' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustPassword.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustPassword";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustPassword")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustPassword", "@CustPassword", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustPassword", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustPassword", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

