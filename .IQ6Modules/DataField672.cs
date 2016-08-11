
	
public partial class Customer_CustDueDiligence : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Due Diligence Received";}
		set { } 
	}

	public string DFName=> "CustDueDiligence";

	
	public Customer_CustDueDiligence(Customer Parent) : 
		base(Parent, "CustDueDiligence"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustDueDiligenceFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDueDiligence").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDueDiligence").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 672;
	}
	public string GetControlName() {
		return "CustDueDiligenceValue";
	}
	public string GetDFName() {
		return "CustDueDiligence";
	}
	public string GetTitle() {
		return "Due Diligence Received";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustDueDiligence.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustDueDiligence/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustDueDiligence' [[Val]] /><input type = 'hidden' data-bound-name='CustDueDiligence' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustDueDiligence.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustDueDiligence";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustDueDiligence")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustDueDiligence", "@CustDueDiligence", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustDueDiligence", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustDueDiligence", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

