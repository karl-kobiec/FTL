
	
public partial class Customer_CustAddr3 : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Address3";}
		set { } 
	}

	public string DFName=> "CustAddr3";

	
	public Customer_CustAddr3(Customer Parent) : 
		base(Parent, "CustAddr3"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustAddr3FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr3").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr3").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 413;
	}
	public string GetControlName() {
		return "CustAddr3Value";
	}
	public string GetDFName() {
		return "CustAddr3";
	}
	public string GetTitle() {
		return "Address3";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAddr3.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr3/?RecId=[[RecId]]',$(this));\" data-bound-name='CustAddr3' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAddr3.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAddr3";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustAddr3")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAddr3", "@CustAddr3", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAddr3", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAddr3", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

