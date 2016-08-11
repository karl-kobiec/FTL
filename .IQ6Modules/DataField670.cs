
	
public partial class Orders_OrdSelEMTo : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Select E-Mail To";}
		set { } 
	}

	public string DFName=> "OrdSelEMTo";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSelEMTo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSelEMTo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustEM AS Description FROM Customer WHERE CustId=0 UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdSelEMTo(Orders Parent) : 
		base(Parent, "OrdSelEMTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdSelEMToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSelEMTo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSelEMTo").First().Value(new Orders());
		
		
			return  "SELECT CustId AS KeyValue, CustEM AS Description FROM Customer WHERE CustId=0 UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 670;
	}
	public string GetControlName() {
		return "OrdSelEMToValue";
	}
	public string GetDFName() {
		return "OrdSelEMTo";
	}
	public string GetTitle() {
		return "Select E-Mail To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdSelEMTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSelEMTo/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdSelEMTo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdSelEMTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdSelEMTo";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdSelEMTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdSelEMTo", "@OrdSelEMTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdSelEMTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdSelEMTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

