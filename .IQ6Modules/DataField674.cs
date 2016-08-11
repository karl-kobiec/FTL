
	
public partial class Customer_CustCredScore : 
	FormattableDataFieldBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score Number";}
		set { } 
	}

	public string DFName=> "CustCredScore";

	
	public Customer_CustCredScore(Customer Parent) : 
		base(Parent, "CustCredScore"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Customer_CustCredScoreFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScore").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCredScore").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 674;
	}
	public string GetControlName() {
		return "CustCredScoreValue";
	}
	public string GetDFName() {
		return "CustCredScore";
	}
	public string GetTitle() {
		return "Credit Score Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCredScore.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCredScore/?RecId=[[RecId]]',$(this));\" data-bound-name='CustCredScore' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCredScore.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCredScore";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustCredScore")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCredScore", "@CustCredScore", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCredScore", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCredScore", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

