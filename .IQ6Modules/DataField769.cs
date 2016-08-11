
	
public partial class Truck_TrkDriver : 
	DataFieldSelectBase<int,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Driver";}
		set { } 
	}

	public string DFName=> "TrkDriver";

		public string GetDataSource() {
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDriver").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDriver").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT DrvId AS KeyValue, DrvName AS Description FROM Driver UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Truck_TrkDriver(Truck Parent) : 
		base(Parent, "TrkDriver"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Truck_TrkDriverFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDriver").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDriver").First().Value(new Truck());
		
		
			return  "SELECT DrvId AS KeyValue, DrvName AS Description FROM Driver UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 769;
	}
	public string GetControlName() {
		return "TrkDriverValue";
	}
	public string GetDFName() {
		return "TrkDriver";
	}
	public string GetTitle() {
		return "Driver";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkDriver.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDriver/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='TrkDriver'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkDriver.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkDriver";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "TrkDriver")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkDriver", "@TrkDriver", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkDriver", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkDriver", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

