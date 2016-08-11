
	
public partial class Customer_CustCreatedBy : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Created By";}
		set { } 
	}

	public string DFName=> "CustCreatedBy";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCreatedBy").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCreatedBy").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Customer_CustCreatedBy(Customer Parent) : 
		base(Parent, "CustCreatedBy"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustCreatedByFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCreatedBy").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCreatedBy").First().Value(new Customer());
		
		
			return  "SELECT StfId AS KeyValue, StfName AS Description FROM Staff UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 291;
	}
	public string GetControlName() {
		return "CustCreatedByValue";
	}
	public string GetDFName() {
		return "CustCreatedBy";
	}
	public string GetTitle() {
		return "Created By";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCreatedBy.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCreatedBy/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustCreatedBy'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCreatedBy.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCreatedBy";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustCreatedBy")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCreatedBy", "@CustCreatedBy", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCreatedBy", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCreatedBy", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

