
	
public partial class Customer_CustFTLNotes : 
	DataFieldBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "In House Notes";}
		set { } 
	}

	public string DFName=> "CustFTLNotes";

	
	public Customer_CustFTLNotes(Customer Parent) : 
		base(Parent, "CustFTLNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Customer_CustFTLNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustFTLNotes").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustFTLNotes").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 200;
	}
	public string GetControlName() {
		return "CustFTLNotesValue";
	}
	public string GetDFName() {
		return "CustFTLNotes";
	}
	public string GetTitle() {
		return "In House Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustFTLNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustFTLNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CustFTLNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustFTLNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustFTLNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CustFTLNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustFTLNotes", "@CustFTLNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustFTLNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustFTLNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

