
	
public partial class TruckMileage_TrkMTruck : 
	DataFieldSelectBase<int,TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Truck";}
		set { } 
	}

	public string DFName=> "TrkMTruck";

		public string GetDataSource() {
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMTruck").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMTruck").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT TrkId AS KeyValue, TrkName AS Description FROM Truck UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public TruckMileage_TrkMTruck(TruckMileage Parent) : 
		base(Parent, "TrkMTruck"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class TruckMileage_TrkMTruckFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMTruck").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMTruck").First().Value(new TruckMileage());
		
		
			return  "SELECT TrkId AS KeyValue, TrkName AS Description FROM Truck UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 400;
	}
	public string GetControlName() {
		return "TrkMTruckValue";
	}
	public string GetDFName() {
		return "TrkMTruck";
	}
	public string GetTitle() {
		return "Truck";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMTruck.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMTruck/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='TrkMTruck'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMTruck.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMTruck";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "TrkMTruck")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMTruck", "@TrkMTruck", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMTruck", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMTruck", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

