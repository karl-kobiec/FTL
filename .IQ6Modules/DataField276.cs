
	
public partial class DriverHrs_DrvHDriver : 
	DataFieldAutoCompleteSingleBase<int,DriverHrs>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Driver";}
		set { } 
	}

	public string DFName=> "DrvHDriver";

		public string GetDataSource() {
		if(DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHDriver").Any()) 
			return DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHDriver").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT DrvId AS KeyValue, DrvName AS Description FROM Driver UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public DriverHrs_DrvHDriver(DriverHrs Parent) : 
		base(Parent, "DrvHDriver"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class DriverHrs_DrvHDriverFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHDriver").Any()) 
			return DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHDriver").First().Value(new DriverHrs());
		
		
			return  "SELECT DrvId AS KeyValue, DrvName AS Description FROM Driver UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 276;
	}
	public string GetControlName() {
		return "DrvHDriverValue";
	}
	public string GetDFName() {
		return "DrvHDriver";
	}
	public string GetTitle() {
		return "Driver";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DriverHrs ds;
					ds = (DriverHrs)dsI;
		 
		
		return ds.DrvHDriver.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DriverHrs ds;
				ds = (DriverHrs)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/DriverHrs/AutoCompleteDrvHDriver/' onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHDriver/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='DrvHDriver'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvHDriver.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvHDriver";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/DriverHrs/AutoCompleteDrvHDriver/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvHDriver")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvHDriver", "@DrvHDriver", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvHDriver", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DriverHrs").GetFieldOperators("DrvHDriver", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

