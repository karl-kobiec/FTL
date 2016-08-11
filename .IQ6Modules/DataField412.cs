
	
public partial class Customer_CustAddr2 : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Address2";}
		set { } 
	}

	public string DFName=> "CustAddr2";

	
	public Customer_CustAddr2(Customer Parent) : 
		base(Parent, "CustAddr2"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustAddr2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr2").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAddr2").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 412;
	}
	public string GetControlName() {
		return "CustAddr2Value";
	}
	public string GetDFName() {
		return "CustAddr2";
	}
	public string GetTitle() {
		return "Address2";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAddr2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAddr2/?RecId=[[RecId]]',$(this));\" data-bound-name='CustAddr2' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAddr2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAddr2";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustAddr2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAddr2", "@CustAddr2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAddr2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAddr2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

