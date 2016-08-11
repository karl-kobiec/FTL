
	
public partial class Customer_CustName : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Company Name";}
		set { } 
	}

	public string DFName=> "CustName";

	
	public Customer_CustName(Customer Parent) : 
		base(Parent, "CustName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustName").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustName").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 410;
	}
	public string GetControlName() {
		return "CustNameValue";
	}
	public string GetDFName() {
		return "CustName";
	}
	public string GetTitle() {
		return "Company Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustName/?RecId=[[RecId]]',$(this));\" data-bound-name='CustName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustName", "@CustName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

