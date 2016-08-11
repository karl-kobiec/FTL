
	
public partial class CertShip_CSOrder : 
	DataFieldAutoCompleteSingleBase<int,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Number";}
		set { } 
	}

	public string DFName=> "CSOrder";

		public string GetDataSource() {
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSOrder").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSOrder").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CertShip_CSOrder(CertShip Parent) : 
		base(Parent, "CSOrder"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CertShip_CSOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSOrder").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSOrder").First().Value(new CertShip());
		
		
			return  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 181;
	}
	public string GetControlName() {
		return "CSOrderValue";
	}
	public string GetDFName() {
		return "CSOrder";
	}
	public string GetTitle() {
		return "Order Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CertShip/AutoCompleteCSOrder/' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSOrder/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CSOrder'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CertShip/AutoCompleteCSOrder/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSOrder", "@CSOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

