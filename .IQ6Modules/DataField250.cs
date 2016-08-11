
	
public partial class Customer_CustOnFTrack : 
	BoolDataFieldBase<Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "On FreightTrack";}
		set { } 
	}

	public string DFName=> "CustOnFTrack";

	
	public Customer_CustOnFTrack(Customer Parent) : 
		base(Parent, "CustOnFTrack"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("False");
				    }
}


public partial class Customer_CustOnFTrackFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustOnFTrack").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustOnFTrack").First().Value(new Customer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 250;
	}
	public string GetControlName() {
		return "CustOnFTrackValue";
	}
	public string GetDFName() {
		return "CustOnFTrack";
	}
	public string GetTitle() {
		return "On FreightTrack";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustOnFTrack.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Customer/SaveCustOnFTrack/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CustOnFTrack' [[Val]] /><input type = 'hidden' data-bound-name='CustOnFTrack' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustOnFTrack.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustOnFTrack";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CustOnFTrack")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustOnFTrack", "@CustOnFTrack", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustOnFTrack", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustOnFTrack", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

