
	
public partial class Contact_ContPhone : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Phone";}
		set { } 
	}

	public string DFName=> "ContPhone";

	
	public Contact_ContPhone(Contact Parent) : 
		base(Parent, "ContPhone"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContPhoneFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContPhone").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContPhone").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 33;
	}
	public string GetControlName() {
		return "ContPhoneValue";
	}
	public string GetDFName() {
		return "ContPhone";
	}
	public string GetTitle() {
		return "Phone";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContPhone.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContPhone/?RecId=[[RecId]]',$(this));\" data-bound-name='ContPhone' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContPhone.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContPhone";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContPhone")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContPhone", "@ContPhone", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContPhone", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContPhone", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

