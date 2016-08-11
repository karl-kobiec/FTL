
	
public partial class Orders_OrdExpImp : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Export or Import";}
		set { } 
	}

	public string DFName=> "OrdExpImp";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdExpImp").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdExpImp").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.OrdExpImpAsQuery();		}
		return _DataSource;

	}
    
	public Orders_OrdExpImp(Orders Parent) : 
		base(Parent, "OrdExpImp"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdExpImpFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdExpImp").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdExpImp").First().Value(new Orders());
		
		
			return DSUtil.OrdExpImpAsQuery();	}

	public int GetFieldUniqueId() {
		return 38;
	}
	public string GetControlName() {
		return "OrdExpImpValue";
	}
	public string GetDFName() {
		return "OrdExpImp";
	}
	public string GetTitle() {
		return "Export or Import";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdExpImp.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdExpImp/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdExpImp'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdExpImp.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdExpImp";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdExpImp")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdExpImp", "@OrdExpImp", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdExpImp", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdExpImp", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

