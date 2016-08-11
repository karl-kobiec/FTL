
	
public partial class Contact_ContEM : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-Mail";}
		set { } 
	}

	public string DFName=> "ContEM";

	
	public Contact_ContEM(Contact Parent) : 
		base(Parent, "ContEM"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContEMFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContEM").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContEM").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 35;
	}
	public string GetControlName() {
		return "ContEMValue";
	}
	public string GetDFName() {
		return "ContEM";
	}
	public string GetTitle() {
		return "E-Mail";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContEM.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContEM/?RecId=[[RecId]]',$(this));\" data-bound-name='ContEM' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContEM.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContEM";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContEM")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContEM", "@ContEM", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContEM", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContEM", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

