
	
public partial class Customer_CustAccEmail : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Accounts Email";}
		set { } 
	}

	public string DFName=> "CustAccEmail";

	
	public Customer_CustAccEmail(Customer Parent) : 
		base(Parent, "CustAccEmail"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustAccEmailFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAccEmail").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAccEmail").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 789;
	}
	public string GetControlName() {
		return "CustAccEmailValue";
	}
	public string GetDFName() {
		return "CustAccEmail";
	}
	public string GetTitle() {
		return "Accounts Email";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAccEmail.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAccEmail/?RecId=[[RecId]]',$(this));\" data-bound-name='CustAccEmail' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAccEmail.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAccEmail";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustAccEmail")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAccEmail", "@CustAccEmail", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAccEmail", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAccEmail", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

