
	
public partial class CN_CNTo : 
	DataFieldAutoCompleteSingleBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit To";}
		set { } 
	}

	public string DFName=> "CNTo";

		public string GetDataSource() {
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTo").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public CN_CNTo(CN Parent) : 
		base(Parent, "CNTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class CN_CNToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTo").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTo").First().Value(new CN());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 209;
	}
	public string GetControlName() {
		return "CNToValue";
	}
	public string GetDFName() {
		return "CNTo";
	}
	public string GetTitle() {
		return "Credit To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/CN/AutoCompleteCNTo/' onchange=\"javascript:IQAutoSave('/CN/SaveCNTo/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='CNTo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/CN/AutoCompleteCNTo/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNTo", "@CNTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

