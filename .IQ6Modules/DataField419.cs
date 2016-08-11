
	
public partial class Customer_CustFax : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Fax";}
		set { } 
	}

	public string DFName=> "CustFax";

	
	public Customer_CustFax(Customer Parent) : 
		base(Parent, "CustFax"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustFaxFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustFax").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustFax").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 419;
	}
	public string GetControlName() {
		return "CustFaxValue";
	}
	public string GetDFName() {
		return "CustFax";
	}
	public string GetTitle() {
		return "Fax";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustFax.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustFax/?RecId=[[RecId]]',$(this));\" data-bound-name='CustFax' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustFax.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustFax";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustFax")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustFax", "@CustFax", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustFax", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustFax", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

