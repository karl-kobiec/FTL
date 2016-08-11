
	
public partial class Orders_OrdAgent : 
	DataFieldAutoCompleteSingleBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Agent";}
		set { } 
	}

	public string DFName=> "OrdAgent";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgent").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgent").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdAgent(Orders Parent) : 
		base(Parent, "OrdAgent"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdAgentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgent").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgent").First().Value(new Orders());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 335;
	}
	public string GetControlName() {
		return "OrdAgentValue";
	}
	public string GetDFName() {
		return "OrdAgent";
	}
	public string GetTitle() {
		return "Agent";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdAgent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Orders/AutoCompleteOrdAgent/' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAgent/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='OrdAgent'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdAgent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdAgent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Orders/AutoCompleteOrdAgent/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdAgent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdAgent", "@OrdAgent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdAgent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdAgent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

