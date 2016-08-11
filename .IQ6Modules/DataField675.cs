
	
public partial class Customer_CustCredScoreReview : 
	DateDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score Review date";}
		set { } 
	}

	public string DFName=> "CustCredScoreReview";

	
	public Customer_CustCredScoreReview(Customer Parent) : 
		base(Parent, "CustCredScoreReview"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustCredScoreReviewFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScoreReview").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScoreReview").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 675;
	}
	public string GetControlName() {
		return "CustCredScoreReviewValue";
	}
	public string GetDFName() {
		return "CustCredScoreReview";
	}
	public string GetTitle() {
		return "Credit Score Review date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCredScoreReview.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScoreReview/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='CustCredScoreReview' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCredScoreReview.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCredScoreReview";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustCredScoreReview")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCredScoreReview", "@CustCredScoreReview", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCredScoreReview", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCredScoreReview", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

