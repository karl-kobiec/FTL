
	
public partial class Customer_CustRecDueDil : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Received Due Diligence";}
		set { } 
	}

	public string DFName=> "CustRecDueDil";

	
	public Customer_CustRecDueDil(Customer Parent) : 
		base(Parent, "CustRecDueDil"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustRecDueDilFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustRecDueDil").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustRecDueDil").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 773;
	}
	public string GetControlName() {
		return "CustRecDueDilValue";
	}
	public string GetDFName() {
		return "CustRecDueDil";
	}
	public string GetTitle() {
		return "Received Due Diligence";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustRecDueDil.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustRecDueDil/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustRecDueDil' [[Val]] /><input type = 'hidden' data-bound-name='CustRecDueDil' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustRecDueDil.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustRecDueDil";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustRecDueDil")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustRecDueDil", "@CustRecDueDil", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustRecDueDil", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustRecDueDil", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

