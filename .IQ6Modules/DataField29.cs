
	
public partial class Customer_CustGenNotes : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "General Notes";}
		set { } 
	}

	public string DFName=> "CustGenNotes";

	
	public Customer_CustGenNotes(Customer Parent) : 
		base(Parent, "CustGenNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustGenNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustGenNotes").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustGenNotes").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 29;
	}
	public string GetControlName() {
		return "CustGenNotesValue";
	}
	public string GetDFName() {
		return "CustGenNotes";
	}
	public string GetTitle() {
		return "General Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustGenNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustGenNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CustGenNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustGenNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustGenNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustGenNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustGenNotes", "@CustGenNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustGenNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustGenNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

