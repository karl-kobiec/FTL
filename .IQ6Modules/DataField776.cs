
	
public partial class Customer_CustCrdRvDate : 
	DateDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score Review Date";}
		set { } 
	}

	public string DFName=> "CustCrdRvDate";

	
	public Customer_CustCrdRvDate(Customer Parent) : 
		base(Parent, "CustCrdRvDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustCrdRvDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdRvDate").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdRvDate").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 776;
	}
	public string GetControlName() {
		return "CustCrdRvDateValue";
	}
	public string GetDFName() {
		return "CustCrdRvDate";
	}
	public string GetTitle() {
		return "Credit Score Review Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCrdRvDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCrdRvDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='CustCrdRvDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCrdRvDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCrdRvDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustCrdRvDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCrdRvDate", "@CustCrdRvDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCrdRvDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCrdRvDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

