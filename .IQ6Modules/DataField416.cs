
	
public partial class Customer_CustPC : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Postcode";}
		set { } 
	}

	public string DFName=> "CustPC";

	
	public Customer_CustPC(Customer Parent) : 
		base(Parent, "CustPC"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPC").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustPC").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 416;
	}
	public string GetControlName() {
		return "CustPCValue";
	}
	public string GetDFName() {
		return "CustPC";
	}
	public string GetTitle() {
		return "Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustPC/?RecId=[[RecId]]',$(this));\" data-bound-name='CustPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustPC", "@CustPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

