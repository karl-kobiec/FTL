
	
public partial class Inv_InvJobNo : 
	DataFieldAutoCompleteSingleBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job No";}
		set { } 
	}

	public string DFName=> "InvJobNo";

		public string GetDataSource() {
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobNo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobNo").First().Value(_Parent);
		
		if(string.IsNullOrEmpty(_DataSource)) { _DataSource =  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";		}
		return _DataSource;

	}
    
	public Inv_InvJobNo(Inv Parent) : 
		base(Parent, "InvJobNo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
						base.GetCustomDataSource = GetDataSource;
		    }
}


public partial class Inv_InvJobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobNo").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobNo").First().Value(new Inv());
		
		
			return  "SELECT JobId AS KeyValue, JobNo AS Description FROM Job UNION SELECT 0, '' ORDER BY Description, KeyValue";	}

	public int GetFieldUniqueId() {
		return 96;
	}
	public string GetControlName() {
		return "InvJobNoValue";
	}
	public string GetDFName() {
		return "InvJobNo";
	}
	public string GetTitle() {
		return "Job No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvJobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<select style='height:21px;[[Width]]' data-ajax--url='/Inv/AutoCompleteInvJobNo/' onchange=\"javascript:IQAutoSave('/Inv/SaveInvJobNo/?RecId=[[RecId]]',$(this));\"class='form-control searchautocomplete' data-bound-name='InvJobNo'  >[[Val]]</select>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvJobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvJobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<select class='form-control  searchautocomplete' data-ajax--url='/Inv/AutoCompleteInvJobNo/' {extraHTML} multiple='multiple' name='{overridename}'></select>";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvJobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvJobNo", "@InvJobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvJobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvJobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return true;
			}
}

