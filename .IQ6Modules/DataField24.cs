
	
public partial class Customer_CustDANNo : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "DAN Number";}
		set { } 
	}

	public string DFName=> "CustDANNo";

	
	public Customer_CustDANNo(Customer Parent) : 
		base(Parent, "CustDANNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustDANNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDANNo").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDANNo").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 24;
	}
	public string GetControlName() {
		return "CustDANNoValue";
	}
	public string GetDFName() {
		return "CustDANNo";
	}
	public string GetTitle() {
		return "DAN Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustDANNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustDANNo/?RecId=[[RecId]]',$(this));\" data-bound-name='CustDANNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustDANNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustDANNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustDANNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustDANNo", "@CustDANNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustDANNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustDANNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

