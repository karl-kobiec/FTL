
	
public partial class Orders_OrdJobNo : 
	DataFieldAutoCompleteSingleBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Number";}
		set { } 
	}

	public string DFName=> "OrdJobNo";

		public string GetDataSource() {
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobNo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobNo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Orders_OrdJobNo(Orders Parent) : 
		base(Parent, "OrdJobNo"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Orders_OrdJobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobNo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJobNo").First().Value(new Orders());
		
		
			return  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 155;
	}
	public string GetControlName() {
		return "OrdJobNoValue";
	}
	public string GetDFName() {
		return "OrdJobNo";
	}
	public string GetTitle() {
		return "Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdJobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Orders/AutoCompleteOrdJobNo/' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdJobNo/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='OrdJobNo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdJobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdJobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Orders/AutoCompleteOrdJobNo/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdJobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdJobNo", "@OrdJobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdJobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdJobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

