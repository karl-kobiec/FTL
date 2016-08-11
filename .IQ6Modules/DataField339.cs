
	
public partial class Orders_OrdAADSys : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "AAD System";}
		set { } 
	}

	public string DFName=> "OrdAADSys";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAADSys").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAADSys").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return "select 0 as KeyValue, '' as [Description]";		}
		return _DataSource;

	}
    
	public Orders_OrdAADSys(Orders Parent) : 
		base(Parent, "OrdAADSys"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdAADSysFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAADSys").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAADSys").First().Value(new Orders());
		
		
			return "select 0 as KeyValue, '' as [Description]";	}

	public int GetFieldUniqueId() {
		return 339;
	}
	public string GetControlName() {
		return "OrdAADSysValue";
	}
	public string GetDFName() {
		return "OrdAADSys";
	}
	public string GetTitle() {
		return "AAD System";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdAADSys.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAADSys/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdAADSys'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdAADSys.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdAADSys";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdAADSys")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdAADSys", "@OrdAADSys", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdAADSys", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdAADSys", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

