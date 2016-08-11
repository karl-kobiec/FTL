
	
public partial class Contact_ContMainContact : 
	BoolDataFieldBase<Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Main Contact";}
		set { } 
	}

	public string DFName=> "ContMainContact";

	
	public Contact_ContMainContact(Contact Parent) : 
		base(Parent, "ContMainContact"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Contact_ContMainContactFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContMainContact").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContMainContact").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 143;
	}
	public string GetControlName() {
		return "ContMainContactValue";
	}
	public string GetDFName() {
		return "ContMainContact";
	}
	public string GetTitle() {
		return "Main Contact";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContMainContact.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Contact/SaveContMainContact/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='ContMainContact' [[Val]] /><input type = 'hidden' data-bound-name='ContMainContact' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContMainContact.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContMainContact";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "ContMainContact")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContMainContact", "@ContMainContact", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContMainContact", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContMainContact", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

