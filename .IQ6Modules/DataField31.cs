
	
public partial class Contact_ContFN : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Forename";}
		set { } 
	}

	public string DFName=> "ContFN";

	
	public Contact_ContFN(Contact Parent) : 
		base(Parent, "ContFN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContFNFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContFN").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContFN").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 31;
	}
	public string GetControlName() {
		return "ContFNValue";
	}
	public string GetDFName() {
		return "ContFN";
	}
	public string GetTitle() {
		return "Forename";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContFN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContFN/?RecId=[[RecId]]',$(this));\" data-bound-name='ContFN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContFN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContFN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContFN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContFN", "@ContFN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContFN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContFN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

