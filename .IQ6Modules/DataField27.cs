
	
public partial class Customer_CustCurr : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Currency";}
		set { } 
	}

	public string DFName=> "CustCurr";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCurr").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCurr").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CustCurrAsQuery();		}
		return _DataSource;

	}
    
	public Customer_CustCurr(Customer Parent) : 
		base(Parent, "CustCurr"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustCurrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCurr").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCurr").First().Value(new Customer());
		
		
			return DSUtil.CustCurrAsQuery();	}

	public int GetFieldUniqueId() {
		return 27;
	}
	public string GetControlName() {
		return "CustCurrValue";
	}
	public string GetDFName() {
		return "CustCurr";
	}
	public string GetTitle() {
		return "Currency";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCurr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCurr/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustCurr'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCurr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCurr";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustCurr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCurr", "@CustCurr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCurr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCurr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

