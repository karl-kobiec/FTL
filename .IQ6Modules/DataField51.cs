
	
public partial class Orders_OrdDelPoint : 
	DataFieldAutoCompleteSingleBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Point";}
		set { } 
	}

	public string DFName=> "OrdDelPoint";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPoint").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPoint").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdDelPoint(Orders Parent) : 
		base(Parent, "OrdDelPoint"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdDelPointFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPoint").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPoint").First().Value(new Orders());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 51;
	}
	public string GetControlName() {
		return "OrdDelPointValue";
	}
	public string GetDFName() {
		return "OrdDelPoint";
	}
	public string GetTitle() {
		return "Delivery Point";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDelPoint.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Orders/AutoCompleteOrdDelPoint/' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelPoint/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='OrdDelPoint'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDelPoint.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDelPoint";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Orders/AutoCompleteOrdDelPoint/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDelPoint")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDelPoint", "@OrdDelPoint", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDelPoint", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDelPoint", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

