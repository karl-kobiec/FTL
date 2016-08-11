
	
public partial class UKOrder_UKOCust : 
	DataFieldAutoCompleteSingleBase<int,UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Customer Name";}
		set { } 
	}

	public string DFName=> "UKOCust";

		public string GetDataSource() {
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCust").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCust").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public UKOrder_UKOCust(UKOrder Parent) : 
		base(Parent, "UKOCust"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class UKOrder_UKOCustFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCust").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCust").First().Value(new UKOrder());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 132;
	}
	public string GetControlName() {
		return "UKOCustValue";
	}
	public string GetDFName() {
		return "UKOCust";
	}
	public string GetTitle() {
		return "Customer Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOCust.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/UKOrder/AutoCompleteUKOCust/' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCust/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='UKOCust'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOCust.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOCust";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/UKOrder/AutoCompleteUKOCust/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKOCust")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOCust", "@UKOCust", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOCust", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOCust", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

