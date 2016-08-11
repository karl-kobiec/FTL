
	
public partial class Customer_CustCounty : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "County";}
		set { } 
	}

	public string DFName=> "CustCounty";

	
	public Customer_CustCounty(Customer Parent) : 
		base(Parent, "CustCounty"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustCountyFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCounty").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCounty").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 415;
	}
	public string GetControlName() {
		return "CustCountyValue";
	}
	public string GetDFName() {
		return "CustCounty";
	}
	public string GetTitle() {
		return "County";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCounty.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCounty/?RecId=[[RecId]]',$(this));\" data-bound-name='CustCounty' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCounty.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCounty";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustCounty")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCounty", "@CustCounty", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCounty", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCounty", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

