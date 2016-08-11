
	
public partial class CertShip_CSDelPoint : 
	DataFieldAutoCompleteSingleBase<int,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Point";}
		set { } 
	}

	public string DFName=> "CSDelPoint";

		public string GetDataSource() {
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDelPoint").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDelPoint").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CertShip_CSDelPoint(CertShip Parent) : 
		base(Parent, "CSDelPoint"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CertShip_CSDelPointFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDelPoint").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSDelPoint").First().Value(new CertShip());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 184;
	}
	public string GetControlName() {
		return "CSDelPointValue";
	}
	public string GetDFName() {
		return "CSDelPoint";
	}
	public string GetTitle() {
		return "Delivery Point";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSDelPoint.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CertShip/AutoCompleteCSDelPoint/' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSDelPoint/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CSDelPoint'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSDelPoint.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSDelPoint";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CertShip/AutoCompleteCSDelPoint/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSDelPoint")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSDelPoint", "@CSDelPoint", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSDelPoint", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSDelPoint", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

