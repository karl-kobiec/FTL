
	
public partial class Orders_OrdStatus : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status";}
		set { } 
	}

	public string DFName=> "OrdStatus";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdStatus").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdStatus").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.OrdStatusAsQuery();		}
		return _DataSource;

	}
    
	public Orders_OrdStatus(Orders Parent) : 
		base(Parent, "OrdStatus"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdStatus").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdStatus").First().Value(new Orders());
		
		
			return DSUtil.OrdStatusAsQuery();	}

	public int GetFieldUniqueId() {
		return 42;
	}
	public string GetControlName() {
		return "OrdStatusValue";
	}
	public string GetDFName() {
		return "OrdStatus";
	}
	public string GetTitle() {
		return "Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdStatus/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdStatus'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdStatus";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdStatus", "@OrdStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdStatus", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdStatus", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

