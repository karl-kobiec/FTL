
	
public partial class Customer_CustUserName : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Portal UserName";}
		set { } 
	}

	public string DFName=> "CustUserName";

	
	public Customer_CustUserName(Customer Parent) : 
		base(Parent, "CustUserName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustUserNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustUserName").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustUserName").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 432;
	}
	public string GetControlName() {
		return "CustUserNameValue";
	}
	public string GetDFName() {
		return "CustUserName";
	}
	public string GetTitle() {
		return "Portal UserName";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustUserName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustUserName/?RecId=[[RecId]]',$(this));\" data-bound-name='CustUserName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustUserName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustUserName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustUserName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustUserName", "@CustUserName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustUserName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustUserName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

