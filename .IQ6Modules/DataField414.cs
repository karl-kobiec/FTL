
	
public partial class Customer_CustTown : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Town";}
		set { } 
	}

	public string DFName=> "CustTown";

	
	public Customer_CustTown(Customer Parent) : 
		base(Parent, "CustTown"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustTownFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustTown").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustTown").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 414;
	}
	public string GetControlName() {
		return "CustTownValue";
	}
	public string GetDFName() {
		return "CustTown";
	}
	public string GetTitle() {
		return "Town";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustTown.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Customer/SaveCustTown/?RecId=[[RecId]]',$(this));\" data-bound-name='CustTown' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustTown.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustTown";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustTown")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustTown", "@CustTown", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustTown", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustTown", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

