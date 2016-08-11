
	
public partial class Contact_ContCust : 
	DataFieldAutoCompleteSingleBase<int,Contact>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Company";}
		set { } 
	}

	public string DFName=> "ContCust";

		public string GetDataSource() {
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContCust").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContCust").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Contact_ContCust(Contact Parent) : 
		base(Parent, "ContCust"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Contact_ContCustFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContCust").Any()) 
			return DS.GetManager<Contact>().OnDataSource.Where(f=> f.Key == "ContCust").First().Value(new Contact());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 424;
	}
	public string GetControlName() {
		return "ContCustValue";
	}
	public string GetDFName() {
		return "ContCust";
	}
	public string GetTitle() {
		return "Company";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Contact ds;
					ds = (Contact)dsI;
		 
		
		return ds.ContCust.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Contact ds;
				ds = (Contact)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Contact/AutoCompleteContCust/' onchange=\"javascript:IQAutoSave('/Contact/SaveContCust/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='ContCust'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ContCust.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ContCust";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Contact/AutoCompleteContCust/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ContCust")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ContCust", "@ContCust", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ContCust", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Contact").GetFieldOperators("ContCust", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

