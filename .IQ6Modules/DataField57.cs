
	
public partial class Orders_OrdBondFrom : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "REDS/Bond From";}
		set { } 
	}

	public string DFName=> "OrdBondFrom";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondFrom").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondFrom").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.OrdVATPaidByAsQuery();		}
		return _DataSource;

	}
    
	public Orders_OrdBondFrom(Orders Parent) : 
		base(Parent, "OrdBondFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdBondFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondFrom").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondFrom").First().Value(new Orders());
		
		
			return DSUtil.OrdVATPaidByAsQuery();	}

	public int GetFieldUniqueId() {
		return 57;
	}
	public string GetControlName() {
		return "OrdBondFromValue";
	}
	public string GetDFName() {
		return "OrdBondFrom";
	}
	public string GetTitle() {
		return "REDS/Bond From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdBondFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdBondFrom/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdBondFrom'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdBondFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdBondFrom";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdBondFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdBondFrom", "@OrdBondFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdBondFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdBondFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

