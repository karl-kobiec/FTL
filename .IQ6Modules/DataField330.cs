
	
public partial class Customer_CustEM3 : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-Mail 3";}
		set { } 
	}

	public string DFName=> "CustEM3";

	
	public Customer_CustEM3(Customer Parent) : 
		base(Parent, "CustEM3"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustEM3FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM3").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM3").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 330;
	}
	public string GetControlName() {
		return "CustEM3Value";
	}
	public string GetDFName() {
		return "CustEM3";
	}
	public string GetTitle() {
		return "E-Mail 3";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustEM3.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM3/?RecId=[[RecId]]',$(this));\" data-bound-name='CustEM3' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustEM3.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustEM3";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustEM3")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustEM3", "@CustEM3", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustEM3", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustEM3", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

