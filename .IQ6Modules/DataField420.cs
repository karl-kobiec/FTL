
	
public partial class Customer_CustEM : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "EMail";}
		set { } 
	}

	public string DFName=> "CustEM";

	
	public Customer_CustEM(Customer Parent) : 
		base(Parent, "CustEM"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustEMFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 420;
	}
	public string GetControlName() {
		return "CustEMValue";
	}
	public string GetDFName() {
		return "CustEM";
	}
	public string GetTitle() {
		return "EMail";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustEM.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM/?RecId=[[RecId]]',$(this));\" data-bound-name='CustEM' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustEM.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustEM";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustEM")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustEM", "@CustEM", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustEM", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustEM", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

