
	
public partial class CertShip_CSCust : 
	DataFieldAutoCompleteSingleBase<int,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client";}
		set { } 
	}

	public string DFName=> "CSCust";

		public string GetDataSource() {
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCust").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCust").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CertShip_CSCust(CertShip Parent) : 
		base(Parent, "CSCust"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CertShip_CSCustFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCust").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSCust").First().Value(new CertShip());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 182;
	}
	public string GetControlName() {
		return "CSCustValue";
	}
	public string GetDFName() {
		return "CSCust";
	}
	public string GetTitle() {
		return "Client";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSCust.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CertShip/AutoCompleteCSCust/' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSCust/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CSCust'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSCust.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSCust";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CertShip/AutoCompleteCSCust/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSCust")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSCust", "@CSCust", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSCust", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSCust", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

