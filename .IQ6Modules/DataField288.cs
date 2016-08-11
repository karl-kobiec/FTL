
	
public partial class Orders_OrdCreatedBy : 
	DataFieldSelectBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Created By";}
		set { } 
	}

	public string DFName=> "OrdCreatedBy";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCreatedBy").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCreatedBy").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdCreatedBy(Orders Parent) : 
		base(Parent, "OrdCreatedBy"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdCreatedByFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCreatedBy").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCreatedBy").First().Value(new Orders());
		
		
			return  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 288;
	}
	public string GetControlName() {
		return "OrdCreatedByValue";
	}
	public string GetDFName() {
		return "OrdCreatedBy";
	}
	public string GetTitle() {
		return "Created By";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCreatedBy.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCreatedBy/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdCreatedBy'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCreatedBy.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCreatedBy";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdCreatedBy")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCreatedBy", "@OrdCreatedBy", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCreatedBy", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCreatedBy", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

