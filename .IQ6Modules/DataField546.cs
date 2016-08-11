
	
public partial class DutyRateHist_DRHTaxCode : 
	DataFieldAutoCompleteSingleBase<int,DutyRateHist>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tax Code";}
		set { } 
	}

	public string DFName=> "DRHTaxCode";

		public string GetDataSource() {
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHTaxCode").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHTaxCode").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT RDTaxId AS KeyValue, RDTaxCode AS Description FROM REDSTax UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public DutyRateHist_DRHTaxCode(DutyRateHist Parent) : 
		base(Parent, "DRHTaxCode"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class DutyRateHist_DRHTaxCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHTaxCode").Any()) 
			return DS.GetManager<DutyRateHist>().OnDataSource.Where(f=> f.Key == "DRHTaxCode").First().Value(new DutyRateHist());
		
		
			return  "SELECT RDTaxId AS KeyValue, RDTaxCode AS Description FROM REDSTax UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 546;
	}
	public string GetControlName() {
		return "DRHTaxCodeValue";
	}
	public string GetDFName() {
		return "DRHTaxCode";
	}
	public string GetTitle() {
		return "Tax Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DutyRateHist ds;
					ds = (DutyRateHist)dsI;
		 
		
		return ds.DRHTaxCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DutyRateHist ds;
				ds = (DutyRateHist)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/DutyRateHist/AutoCompleteDRHTaxCode/' onchange=\"javascript:IQAutoSave('/DutyRateHist/SaveDRHTaxCode/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='DRHTaxCode'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DRHTaxCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DRHTaxCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/DutyRateHist/AutoCompleteDRHTaxCode/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DRHTaxCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DRHTaxCode", "@DRHTaxCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DRHTaxCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DutyRateHist").GetFieldOperators("DRHTaxCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

