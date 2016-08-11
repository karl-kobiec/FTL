
	
public partial class Customer_CustType : 
	DataFieldSelectBase<int,Customer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Type";}
		set { } 
	}

	public string DFName=> "CustType";

		public string GetDataSource() {
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustType").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustType").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { return DSUtil.CustTypeAsQuery();		}
		return _DataSource;

	}
    
	public Customer_CustType(Customer Parent) : 
		base(Parent, "CustType"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Customer_CustTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustType").Any()) 
			return DS.GetManager<Customer>().OnDataSource.Where(f=> f.Key == "CustType").First().Value(new Customer());
		
		
			return DSUtil.CustTypeAsQuery();	}

	public int GetFieldUniqueId() {
		return 22;
	}
	public string GetControlName() {
		return "CustTypeValue";
	}
	public string GetDFName() {
		return "CustType";
	}
	public string GetTitle() {
		return "Client Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Customer ds;
					ds = (Customer)dsI;
		 
		
		return ds.CustType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Customer ds;
				ds = (Customer)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Customer/SaveCustType/?RecId=[[RecId]]',$(this));\"class='form-control' data-bound-name='CustType'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CustType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CustType";} set { }}

		
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
					if(!Params.Any(f=> f.KeyValue == "CustType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CustType", "@CustType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CustType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Customer").GetFieldOperators("CustType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

