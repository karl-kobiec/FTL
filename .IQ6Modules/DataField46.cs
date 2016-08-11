
	
public partial class Orders_OrdCollPoint : 
	DataFieldAutoCompleteSingleBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Point";}
		set { } 
	}

	public string DFName=> "OrdCollPoint";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPoint").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPoint").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdCollPoint(Orders Parent) : 
		base(Parent, "OrdCollPoint"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdCollPointFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPoint").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPoint").First().Value(new Orders());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 46;
	}
	public string GetControlName() {
		return "OrdCollPointValue";
	}
	public string GetDFName() {
		return "OrdCollPoint";
	}
	public string GetTitle() {
		return "Collection Point";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollPoint.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Orders/AutoCompleteOrdCollPoint/' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollPoint/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='OrdCollPoint'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollPoint.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollPoint";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Orders/AutoCompleteOrdCollPoint/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollPoint")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollPoint", "@OrdCollPoint", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollPoint", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollPoint", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

