
	
public partial class Customer_CustCtry : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Country";}
		set { } 
	}

	public string DFName=> "CustCtry";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCtry").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCtry").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Customer_CustCtry(Customer Parent) : 
		base(Parent, "CustCtry"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("217");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustCtryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCtry").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustCtry").First().Value(new Customer());
		
		
			return  "SELECT CtryId AS KeyValue, CtryName AS Description FROM Country UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 417;
	}
	public string GetControlName() {
		return "CustCtryValue";
	}
	public string GetDFName() {
		return "CustCtry";
	}
	public string GetTitle() {
		return "Country";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustCtry.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustCtry/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustCtry'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustCtry.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustCtry";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustCtry")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustCtry", "@CustCtry", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustCtry", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustCtry", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

