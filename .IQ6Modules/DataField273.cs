
	
public partial class Driver_DrvSDate : 
	DataFieldSelectBase<int,Driver>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Start Date";}
		set { } 
	}

	public string DFName=> "DrvSDate";

		public string GetDataSource() {
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvSDate").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvSDate").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT WkId AS KeyValue, WkSDateText AS Description FROM Week UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Driver_DrvSDate(Driver Parent) : 
		base(Parent, "DrvSDate"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Driver_DrvSDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvSDate").Any()) 
			return DS.GetManager<Driver>().OnDataSource.Where(f=> f.Key == "DrvSDate").First().Value(new Driver());
		
		
			return  "SELECT WkId AS KeyValue, WkSDateText AS Description FROM Week UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 273;
	}
	public string GetControlName() {
		return "DrvSDateValue";
	}
	public string GetDFName() {
		return "DrvSDate";
	}
	public string GetTitle() {
		return "Start Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Driver ds;
					ds = (Driver)dsI;
		 
		
		return ds.DrvSDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Driver ds;
				ds = (Driver)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Driver/SaveDrvSDate/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='DrvSDate'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DrvSDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DrvSDate";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "DrvSDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DrvSDate", "@DrvSDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DrvSDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Driver").GetFieldOperators("DrvSDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

