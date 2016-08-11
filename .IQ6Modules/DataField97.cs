
	
public partial class Inv_InvOrder : 
	DataFieldAutoCompleteSingleBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Number";}
		set { } 
	}

	public string DFName=> "InvOrder";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvOrder").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvOrder").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Inv_InvOrder(Inv Parent) : 
		base(Parent, "InvOrder"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvOrder").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvOrder").First().Value(new Inv());
		
		
			return  "SELECT OrdId AS KeyValue, Cast(OrdId AS varchar(100)) AS Description FROM Orders UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 97;
	}
	public string GetControlName() {
		return "InvOrderValue";
	}
	public string GetDFName() {
		return "InvOrder";
	}
	public string GetTitle() {
		return "Order Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Inv/AutoCompleteInvOrder/' onchange=\"javascript:IQAutoSave('/Inv/SaveInvOrder/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='InvOrder'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Inv/AutoCompleteInvOrder/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvOrder", "@InvOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

