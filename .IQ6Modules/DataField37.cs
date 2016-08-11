
	
public partial class Contact_ContNotes : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Notes";}
		set { } 
	}

	public string DFName=> "ContNotes";

	
	public Contact_ContNotes(Contact Parent) : 
		base(Parent, "ContNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContNotes").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContNotes").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 37;
	}
	public string GetControlName() {
		return "ContNotesValue";
	}
	public string GetDFName() {
		return "ContNotes";
	}
	public string GetTitle() {
		return "Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Contact/SaveContNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='ContNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContNotes", "@ContNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

