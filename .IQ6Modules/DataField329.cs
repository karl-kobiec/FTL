
	
public partial class Customer_CustEM2 : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-Mail 2";}
		set { } 
	}

	public string DFName=> "CustEM2";

	
	public Customer_CustEM2(Customer Parent) : 
		base(Parent, "CustEM2"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustEM2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM2").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustEM2").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 329;
	}
	public string GetControlName() {
		return "CustEM2Value";
	}
	public string GetDFName() {
		return "CustEM2";
	}
	public string GetTitle() {
		return "E-Mail 2";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustEM2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustEM2/?RecId=[[RecId]]',$(this));\" data-bound-name='CustEM2' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustEM2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustEM2";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustEM2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustEM2", "@CustEM2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustEM2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustEM2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

