
	
public partial class Customer_CustDelZone : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Zone";}
		set { } 
	}

	public string DFName=> "CustDelZone";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDelZone").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDelZone").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT DelZId AS KeyValue, DelZName AS Description FROM DelZone UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Customer_CustDelZone(Customer Parent) : 
		base(Parent, "CustDelZone"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustDelZoneFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDelZone").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustDelZone").First().Value(new Customer());
		
		
			return  "SELECT DelZId AS KeyValue, DelZName AS Description FROM DelZone UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 287;
	}
	public string GetControlName() {
		return "CustDelZoneValue";
	}
	public string GetDFName() {
		return "CustDelZone";
	}
	public string GetTitle() {
		return "Delivery Zone";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustDelZone.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustDelZone/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustDelZone'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustDelZone.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustDelZone";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustDelZone")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustDelZone", "@CustDelZone", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustDelZone", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustDelZone", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

