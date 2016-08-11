
	
public partial class Inv_InvTo : 
	DataFieldAutoCompleteSingleBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice To";}
		set { } 
	}

	public string DFName=> "InvTo";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";		}
		return _DataSource;

	}
    
	public Inv_InvTo(Inv Parent) : 
		base(Parent, "InvTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTo").First().Value(new Inv());
		
		
			return  "SELECT CustId AS KeyValue, CustName AS Description FROM Customer UNION SELECT 0, '' ORDER BY KeyValue";	}

	public int GetFieldUniqueId() {
		return 105;
	}
	public string GetControlName() {
		return "InvToValue";
	}
	public string GetDFName() {
		return "InvTo";
	}
	public string GetTitle() {
		return "Invoice To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Inv/AutoCompleteInvTo/' onchange=\"javascript:IQAutoSave('/Inv/SaveInvTo/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='InvTo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Inv/AutoCompleteInvTo/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvTo", "@InvTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

