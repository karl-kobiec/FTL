
	
public partial class Customer_CustCrdScr : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Score";}
		set { } 
	}

	public string DFName=> "CustCrdScr";

	
	public Customer_CustCrdScr(Customer Parent) : 
		base(Parent, "CustCrdScr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustCrdScrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdScr").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCrdScr").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 775;
	}
	public string GetControlName() {
		return "CustCrdScrValue";
	}
	public string GetDFName() {
		return "CustCrdScr";
	}
	public string GetTitle() {
		return "Credit Score";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCrdScr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCrdScr/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CustCrdScr'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCrdScr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCrdScr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustCrdScr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCrdScr", "@CustCrdScr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCrdScr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCrdScr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

