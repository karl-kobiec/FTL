
	
public partial class ShipDoc_SDRecip : 
	DataFieldAutoCompleteSingleBase<int,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Recipient Name";}
		set { } 
	}

	public string DFName=> "SDRecip";

		public string GetDataSource() {
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDRecip").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDRecip").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public ShipDoc_SDRecip(ShipDoc Parent) : 
		base(Parent, "SDRecip"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class ShipDoc_SDRecipFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDRecip").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDRecip").First().Value(new ShipDoc());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 355;
	}
	public string GetControlName() {
		return "SDRecipValue";
	}
	public string GetDFName() {
		return "SDRecip";
	}
	public string GetTitle() {
		return "Recipient Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDRecip.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/ShipDoc/AutoCompleteSDRecip/' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDRecip/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='SDRecip'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDRecip.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDRecip";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/ShipDoc/AutoCompleteSDRecip/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDRecip")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDRecip", "@SDRecip", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDRecip", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDRecip", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

