
	
public partial class Customer_CustCrdChecked : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score Checked";}
		set { } 
	}

	public string DFName=> "CustCrdChecked";

	
	public Customer_CustCrdChecked(Customer Parent) : 
		base(Parent, "CustCrdChecked"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustCrdCheckedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdChecked").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdChecked").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 774;
	}
	public string GetControlName() {
		return "CustCrdCheckedValue";
	}
	public string GetDFName() {
		return "CustCrdChecked";
	}
	public string GetTitle() {
		return "Credit Score Checked";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCrdChecked.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustCrdChecked/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustCrdChecked' [[Val]] /><input type = 'hidden' data-bound-name='CustCrdChecked' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCrdChecked.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCrdChecked";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustCrdChecked")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCrdChecked", "@CustCrdChecked", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCrdChecked", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCrdChecked", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

