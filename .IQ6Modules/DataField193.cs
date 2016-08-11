
	
public partial class Customer_CustSendStatus : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Send Status";}
		set { } 
	}

	public string DFName=> "CustSendStatus";

	
	public Customer_CustSendStatus(Customer Parent) : 
		base(Parent, "CustSendStatus"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustSendStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustSendStatus").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustSendStatus").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 193;
	}
	public string GetControlName() {
		return "CustSendStatusValue";
	}
	public string GetDFName() {
		return "CustSendStatus";
	}
	public string GetTitle() {
		return "Send Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustSendStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustSendStatus/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustSendStatus' [[Val]] /><input type = 'hidden' data-bound-name='CustSendStatus' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustSendStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustSendStatus";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustSendStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustSendStatus", "@CustSendStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustSendStatus", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustSendStatus", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

