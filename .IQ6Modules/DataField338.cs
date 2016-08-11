
	
public partial class Customer_CustAADSys : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "AAD System";}
		set { } 
	}

	public string DFName=> "CustAADSys";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAADSys").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAADSys").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CustAADSysAsQuery();		}
		return _DataSource;

	}
    
	public Customer_CustAADSys(Customer Parent) : 
		base(Parent, "CustAADSys"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustAADSysFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAADSys").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustAADSys").First().Value(new Customer());
		
		
			return DSUtil.CustAADSysAsQuery();	}

	public int GetFieldUniqueId() {
		return 338;
	}
	public string GetControlName() {
		return "CustAADSysValue";
	}
	public string GetDFName() {
		return "CustAADSys";
	}
	public string GetTitle() {
		return "AAD System";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustAADSys.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustAADSys/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustAADSys'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustAADSys.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustAADSys";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustAADSys")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustAADSys", "@CustAADSys", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustAADSys", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustAADSys", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

