
	
public partial class Orders_OrdGBWKNoFrom : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "GBWK No From";}
		set { } 
	}

	public string DFName=> "OrdGBWKNoFrom";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNoFrom").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNoFrom").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.OrdVATPaidByAsQuery();		}
		return _DataSource;

	}
    
	public Orders_OrdGBWKNoFrom(Orders Parent) : 
		base(Parent, "OrdGBWKNoFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdGBWKNoFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNoFrom").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNoFrom").First().Value(new Orders());
		
		
			return DSUtil.OrdVATPaidByAsQuery();	}

	public int GetFieldUniqueId() {
		return 344;
	}
	public string GetControlName() {
		return "OrdGBWKNoFromValue";
	}
	public string GetDFName() {
		return "OrdGBWKNoFrom";
	}
	public string GetTitle() {
		return "GBWK No From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdGBWKNoFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdGBWKNoFrom/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdGBWKNoFrom'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdGBWKNoFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdGBWKNoFrom";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdGBWKNoFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdGBWKNoFrom", "@OrdGBWKNoFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdGBWKNoFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdGBWKNoFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

