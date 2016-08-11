
	
public partial class Contact_ContId : 
	FormattableDataFieldBase<int,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Contact ID";}
		set { } 
	}

	public string DFName=> "ContId";

	
	public Contact_ContId(Contact Parent) : 
		base(Parent, "ContId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Contact_ContIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContId").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContId").First().Value(new Contact());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 30;
	}
	public string GetControlName() {
		return "ContIdValue";
	}
	public string GetDFName() {
		return "ContId";
	}
	public string GetTitle() {
		return "Contact ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Contact/SaveContId/?RecId=[[RecId]]',$(this));\" data-bound-name='ContId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContId", "@ContId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

