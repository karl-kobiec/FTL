
	
public partial class UKOrder_UKOTransp : 
	DataFieldAutoCompleteSingleBase<int,UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Haulier Name";}
		set { } 
	}

	public string DFName=> "UKOTransp";

		public string GetDataSource() {
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOTransp").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOTransp").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public UKOrder_UKOTransp(UKOrder Parent) : 
		base(Parent, "UKOTransp"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class UKOrder_UKOTranspFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOTransp").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOTransp").First().Value(new UKOrder());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 137;
	}
	public string GetControlName() {
		return "UKOTranspValue";
	}
	public string GetDFName() {
		return "UKOTransp";
	}
	public string GetTitle() {
		return "Haulier Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOTransp.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/UKOrder/AutoCompleteUKOTransp/' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOTransp/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='UKOTransp'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOTransp.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOTransp";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/UKOrder/AutoCompleteUKOTransp/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKOTransp")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOTransp", "@UKOTransp", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOTransp", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOTransp", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

