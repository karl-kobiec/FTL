
	
public partial class Contact_ContSN : 
	DataFieldBase<string,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Surname";}
		set { } 
	}

	public string DFName=> "ContSN";

	
	public Contact_ContSN(Contact Parent) : 
		base(Parent, "ContSN"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Contact_ContSNFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContSN").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContSN").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 32;
	}
	public string GetControlName() {
		return "ContSNValue";
	}
	public string GetDFName() {
		return "ContSN";
	}
	public string GetTitle() {
		return "Surname";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContSN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContSN/?RecId=[[RecId]]',$(this));\" data-bound-name='ContSN' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContSN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContSN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContSN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContSN", "@ContSN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContSN", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContSN", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

