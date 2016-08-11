
	
public partial class Customer_CustEM4 : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-Mail 4";}
		set { } 
	}

	public string DFName=> "CustEM4";

	
	public Customer_CustEM4(Customer Parent) : 
		base(Parent, "CustEM4"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustEM4FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM4").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM4").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 331;
	}
	public string GetControlName() {
		return "CustEM4Value";
	}
	public string GetDFName() {
		return "CustEM4";
	}
	public string GetTitle() {
		return "E-Mail 4";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustEM4.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM4/?RecId=[[RecId]]',$(this));\" data-bound-name='CustEM4' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustEM4.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustEM4";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustEM4")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustEM4", "@CustEM4", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustEM4", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustEM4", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

