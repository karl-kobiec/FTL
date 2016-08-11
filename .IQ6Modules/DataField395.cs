
	
public partial class ShipDoc_SDCurr : 
	DataFieldSelectBase<int,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Currency";}
		set { } 
	}

	public string DFName=> "SDCurr";

		public string GetDataSource() {
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDCurr").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDCurr").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return "select 0 as KeyValue, '' as [Description]";		}
		return _DataSource;

	}
    
	public ShipDoc_SDCurr(ShipDoc Parent) : 
		base(Parent, "SDCurr"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("1");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class ShipDoc_SDCurrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDCurr").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDCurr").First().Value(new ShipDoc());
		
		
			return "select 0 as KeyValue, '' as [Description]";	}

	public int GetFieldUniqueId() {
		return 395;
	}
	public string GetControlName() {
		return "SDCurrValue";
	}
	public string GetDFName() {
		return "SDCurr";
	}
	public string GetTitle() {
		return "Currency";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDCurr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDCurr/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='SDCurr'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDCurr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDCurr";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "SDCurr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDCurr", "@SDCurr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDCurr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDCurr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

