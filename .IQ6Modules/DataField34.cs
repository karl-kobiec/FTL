
	
public partial class Contact_ContFax : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Fax";}
		set { } 
	}

	public string DFName=> "ContFax";

	
	public Contact_ContFax(Contact Parent) : 
		base(Parent, "ContFax"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContFaxFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContFax").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContFax").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 34;
	}
	public string GetControlName() {
		return "ContFaxValue";
	}
	public string GetDFName() {
		return "ContFax";
	}
	public string GetTitle() {
		return "Fax";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContFax.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContFax/?RecId=[[RecId]]',$(this));\" data-bound-name='ContFax' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContFax.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContFax";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContFax")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContFax", "@ContFax", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContFax", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContFax", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

