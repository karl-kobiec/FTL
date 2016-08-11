
	
public partial class CN_CNRouteFrom : 
	DataFieldSelectBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route From";}
		set { } 
	}

	public string DFName=> "CNRouteFrom";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNRouteFrom").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNRouteFrom").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CN_CNRouteFrom(CN Parent) : 
		base(Parent, "CNRouteFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNRouteFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNRouteFrom").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNRouteFrom").First().Value(new CN());
		
		
			return  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 207;
	}
	public string GetControlName() {
		return "CNRouteFromValue";
	}
	public string GetDFName() {
		return "CNRouteFrom";
	}
	public string GetTitle() {
		return "Route From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNRouteFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CN/SaveCNRouteFrom/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CNRouteFrom'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNRouteFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNRouteFrom";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CNRouteFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNRouteFrom", "@CNRouteFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNRouteFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNRouteFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

