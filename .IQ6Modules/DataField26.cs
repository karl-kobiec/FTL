
	
public partial class Customer_CustIntrastat : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Intrastat";}
		set { } 
	}

	public string DFName=> "CustIntrastat";

	
	public Customer_CustIntrastat(Customer Parent) : 
		base(Parent, "CustIntrastat"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustIntrastatFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustIntrastat").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustIntrastat").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 26;
	}
	public string GetControlName() {
		return "CustIntrastatValue";
	}
	public string GetDFName() {
		return "CustIntrastat";
	}
	public string GetTitle() {
		return "Intrastat";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustIntrastat.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustIntrastat/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustIntrastat' [[Val]] /><input type = 'hidden' data-bound-name='CustIntrastat' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustIntrastat.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustIntrastat";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustIntrastat")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustIntrastat", "@CustIntrastat", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustIntrastat", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustIntrastat", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

