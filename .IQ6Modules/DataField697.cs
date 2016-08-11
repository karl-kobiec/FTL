
	
public partial class Customer_CustWebsite : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Website";}
		set { } 
	}

	public string DFName=> "CustWebsite";

	
	public Customer_CustWebsite(Customer Parent) : 
		base(Parent, "CustWebsite"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustWebsiteFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustWebsite").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustWebsite").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 697;
	}
	public string GetControlName() {
		return "CustWebsiteValue";
	}
	public string GetDFName() {
		return "CustWebsite";
	}
	public string GetTitle() {
		return "Website";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustWebsite.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustWebsite/?RecId=[[RecId]]',$(this));\" data-bound-name='CustWebsite' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustWebsite.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustWebsite";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustWebsite")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustWebsite", "@CustWebsite", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustWebsite", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustWebsite", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

