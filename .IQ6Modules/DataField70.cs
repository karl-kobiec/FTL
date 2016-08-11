
	
public partial class OrderLine_OrdLPackageType : 
	DataFieldSelectBase<int,OrderLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Package Type";}
		set { } 
	}

	public string DFName=> "OrdLPackageType";

		public string GetDataSource() {
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPackageType").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPackageType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT PackId AS KeyValue, PackName AS Description FROM PackageType UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public OrderLine_OrdLPackageType(OrderLine Parent) : 
		base(Parent, "OrdLPackageType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class OrderLine_OrdLPackageTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPackageType").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLPackageType").First().Value(new OrderLine());
		
		
			return  "SELECT PackId AS KeyValue, PackName AS Description FROM PackageType UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 70;
	}
	public string GetControlName() {
		return "OrdLPackageTypeValue";
	}
	public string GetDFName() {
		return "OrdLPackageType";
	}
	public string GetTitle() {
		return "Package Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		OrderLine ds;
					ds = (OrderLine)dsI;
		 
		
		return ds.OrdLPackageType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		OrderLine ds;
				ds = (OrderLine)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLPackageType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='OrdLPackageType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdLPackageType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdLPackageType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "OrdLPackageType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdLPackageType", "@OrdLPackageType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdLPackageType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("OrderLine").GetFieldOperators("OrdLPackageType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

