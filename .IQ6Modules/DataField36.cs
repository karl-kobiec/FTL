
	
public partial class Contact_ContJobTitle : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Title";}
		set { } 
	}

	public string DFName=> "ContJobTitle";

	
	public Contact_ContJobTitle(Contact Parent) : 
		base(Parent, "ContJobTitle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContJobTitleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContJobTitle").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContJobTitle").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 36;
	}
	public string GetControlName() {
		return "ContJobTitleValue";
	}
	public string GetDFName() {
		return "ContJobTitle";
	}
	public string GetTitle() {
		return "Job Title";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContJobTitle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContJobTitle/?RecId=[[RecId]]',$(this));\" data-bound-name='ContJobTitle' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContJobTitle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContJobTitle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContJobTitle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContJobTitle", "@ContJobTitle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContJobTitle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContJobTitle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

