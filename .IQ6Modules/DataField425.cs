
	
public partial class Contact_ContName : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Full Name";}
		set { } 
	}

	public string DFName=> "ContName";

	
	public Contact_ContName(Contact Parent) : 
		base(Parent, "ContName"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Contact_ContNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContName").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContName").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 425;
	}
	public string GetControlName() {
		return "ContNameValue";
	}
	public string GetDFName() {
		return "ContName";
	}
	public string GetTitle() {
		return "Full Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContName/?RecId=[[RecId]]',$(this));\" data-bound-name='ContName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContName", "@ContName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

