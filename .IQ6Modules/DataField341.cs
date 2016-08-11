
	
public partial class Customer_CustGBWK : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "GBWK";}
		set { } 
	}

	public string DFName=> "CustGBWK";

	
	public Customer_CustGBWK(Customer Parent) : 
		base(Parent, "CustGBWK"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustGBWKFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustGBWK").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustGBWK").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 341;
	}
	public string GetControlName() {
		return "CustGBWKValue";
	}
	public string GetDFName() {
		return "CustGBWK";
	}
	public string GetTitle() {
		return "GBWK";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustGBWK.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustGBWK/?RecId=[[RecId]]',$(this));\" data-bound-name='CustGBWK' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustGBWK.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustGBWK";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustGBWK")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustGBWK", "@CustGBWK", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustGBWK", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustGBWK", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

