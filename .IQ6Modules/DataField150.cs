
	
public partial class Customer_CustLang : 
	DataFieldSelectBase<string,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Language";}
		set { } 
	}

	public string DFName=> "CustLang";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustLang").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustLang").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CustLangAsQuery();		}
		return _DataSource;

	}
    
	public Customer_CustLang(Customer Parent) : 
		base(Parent, "CustLang"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustLangFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustLang").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustLang").First().Value(new Customer());
		
		
			return DSUtil.CustLangAsQuery();	}

	public int GetFieldUniqueId() {
		return 150;
	}
	public string GetControlName() {
		return "CustLangValue";
	}
	public string GetDFName() {
		return "CustLang";
	}
	public string GetTitle() {
		return "Language";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustLang.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustLang/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustLang'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustLang.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustLang";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustLang")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustLang", "@CustLang", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustLang", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustLang", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

