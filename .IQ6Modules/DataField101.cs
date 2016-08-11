
	
public partial class Inv_InvRouteTo : 
	DataFieldSelectBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Route To";}
		set { } 
	}

	public string DFName=> "InvRouteTo";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteTo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteTo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Inv_InvRouteTo(Inv Parent) : 
		base(Parent, "InvRouteTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvRouteToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteTo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvRouteTo").First().Value(new Inv());
		
		
			return  "SELECT FRId AS KeyValue, FRName AS Description FROM FerryRoute UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 101;
	}
	public string GetControlName() {
		return "InvRouteToValue";
	}
	public string GetDFName() {
		return "InvRouteTo";
	}
	public string GetTitle() {
		return "Route To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvRouteTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvRouteTo/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='InvRouteTo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvRouteTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvRouteTo";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "InvRouteTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvRouteTo", "@InvRouteTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvRouteTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvRouteTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

