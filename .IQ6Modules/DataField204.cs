
	
public partial class CN_CNOrder : 
	DataFieldAutoCompleteSingleBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Number";}
		set { } 
	}

	public string DFName=> "CNOrder";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNOrder").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNOrder").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CN_CNOrder(CN Parent) : 
		base(Parent, "CNOrder"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNOrder").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNOrder").First().Value(new CN());
		
		
			return  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 204;
	}
	public string GetControlName() {
		return "CNOrderValue";
	}
	public string GetDFName() {
		return "CNOrder";
	}
	public string GetTitle() {
		return "Order Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CN/AutoCompleteCNOrder/' onchange=\"javascript:IQAutoSave('/CN/SaveCNOrder/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CNOrder'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CN/AutoCompleteCNOrder/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNOrder", "@CNOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

