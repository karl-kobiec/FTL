
	
public partial class Customer_CustCredScoreSearch : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score Searched";}
		set { } 
	}

	public string DFName=> "CustCredScoreSearch";

	
	public Customer_CustCredScoreSearch(Customer Parent) : 
		base(Parent, "CustCredScoreSearch"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustCredScoreSearchFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScoreSearch").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScoreSearch").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 673;
	}
	public string GetControlName() {
		return "CustCredScoreSearchValue";
	}
	public string GetDFName() {
		return "CustCredScoreSearch";
	}
	public string GetTitle() {
		return "Credit Score Searched";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCredScoreSearch.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScoreSearch/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustCredScoreSearch' [[Val]] /><input type = 'hidden' data-bound-name='CustCredScoreSearch' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCredScoreSearch.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCredScoreSearch";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustCredScoreSearch")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCredScoreSearch", "@CustCredScoreSearch", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCredScoreSearch", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCredScoreSearch", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

