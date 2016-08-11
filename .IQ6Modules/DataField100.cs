
	
public partial class Inv_InvRouteFrom : 
	DataFieldSelectBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route From";}
		set { } 
	}

	public string DFName=> "InvRouteFrom";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteFrom").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteFrom").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Inv_InvRouteFrom(Inv Parent) : 
		base(Parent, "InvRouteFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvRouteFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteFrom").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteFrom").First().Value(new Inv());
		
		
			return  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 100;
	}
	public string GetControlName() {
		return "InvRouteFromValue";
	}
	public string GetDFName() {
		return "InvRouteFrom";
	}
	public string GetTitle() {
		return "Route From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvRouteFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvRouteFrom/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvRouteFrom'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvRouteFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvRouteFrom";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvRouteFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvRouteFrom", "@InvRouteFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvRouteFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvRouteFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

