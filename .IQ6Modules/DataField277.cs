
	
public partial class DriverHrs_DrvHWk : 
	DataFieldSelectBase<int,DriverHrs>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Week";}
		set { } 
	}

	public string DFName=> "DrvHWk";

		public string GetDataSource() {
		if(DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHWk").Any()) 
			return DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHWk").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT WkId AS KeyValue, WkSDateText AS Description FROM Week UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public DriverHrs_DrvHWk(DriverHrs Parent) : 
		base(Parent, "DrvHWk"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class DriverHrs_DrvHWkFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHWk").Any()) 
			return DS.GetManager<DriverHrs>().OnDataSource.Where(f=> f.Key == "DrvHWk").First().Value(new DriverHrs());
		
		
			return  "SELECT WkId AS KeyValue, WkSDateText AS Description FROM Week UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 277;
	}
	public string GetControlName() {
		return "DrvHWkValue";
	}
	public string GetDFName() {
		return "DrvHWk";
	}
	public string GetTitle() {
		return "Week";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DriverHrs ds;
					ds = (DriverHrs)dsI;
		 
		
		return ds.DrvHWk.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DriverHrs ds;
				ds = (DriverHrs)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/DriverHrs/SaveDrvHWk/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='DrvHWk'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvHWk.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvHWk";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		string ret = $"<select class='form-control searchable' {extraHTML} multiple='multiple' name='{overridename}'>";
								foreach(var itm in IQApp.DB.Load<Pair<string, string>>(GetDataSource())) {
					ret += "<option value='" + itm.KeyValue + "'" + (filterValue == itm.KeyValue ? "selected=selected" : "") + ">" + itm.Description + "</option>";
				}
								ret += "</select>";
				return ret;	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DrvHWk")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvHWk", "@DrvHWk", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvHWk", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DriverHrs").GetFieldOperators("DrvHWk", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

