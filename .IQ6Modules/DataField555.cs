
	
public partial class REDSOrder_RDOrdHM10 : 
	BoolDataFieldBase<REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "HM10";}
		set { } 
	}

	public string DFName=> "RDOrdHM10";

	
	public REDSOrder_RDOrdHM10(REDSOrder Parent) : 
		base(Parent, "RDOrdHM10"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class REDSOrder_RDOrdHM10FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdHM10").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdHM10").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 555;
	}
	public string GetControlName() {
		return "RDOrdHM10Value";
	}
	public string GetDFName() {
		return "RDOrdHM10";
	}
	public string GetTitle() {
		return "HM10";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdHM10.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdHM10/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='RDOrdHM10' [[Val]] /><input type = 'hidden' data-bound-name='RDOrdHM10' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdHM10.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdHM10";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "RDOrdHM10")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdHM10", "@RDOrdHM10", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdHM10", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdHM10", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

