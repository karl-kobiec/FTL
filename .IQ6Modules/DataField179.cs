
	
public partial class CertShip_CSJobNo : 
	DataFieldAutoCompleteSingleBase<int,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Number";}
		set { } 
	}

	public string DFName=> "CSJobNo";

		public string GetDataSource() {
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobNo").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobNo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public CertShip_CSJobNo(CertShip Parent) : 
		base(Parent, "CSJobNo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CertShip_CSJobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobNo").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobNo").First().Value(new CertShip());
		
		
			return  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 179;
	}
	public string GetControlName() {
		return "CSJobNoValue";
	}
	public string GetDFName() {
		return "CSJobNo";
	}
	public string GetTitle() {
		return "Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSJobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CertShip/AutoCompleteCSJobNo/' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSJobNo/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CSJobNo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSJobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSJobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CertShip/AutoCompleteCSJobNo/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSJobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSJobNo", "@CSJobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSJobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSJobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

