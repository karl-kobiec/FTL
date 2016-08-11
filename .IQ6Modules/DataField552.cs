
	
public partial class REDSOrder_RDOrdLocked : 
	BoolDataFieldBase<REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Locked";}
		set { } 
	}

	public string DFName=> "RDOrdLocked";

	
	public REDSOrder_RDOrdLocked(REDSOrder Parent) : 
		base(Parent, "RDOrdLocked"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class REDSOrder_RDOrdLockedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdLocked").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdLocked").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 552;
	}
	public string GetControlName() {
		return "RDOrdLockedValue";
	}
	public string GetDFName() {
		return "RDOrdLocked";
	}
	public string GetTitle() {
		return "Locked";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdLocked.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdLocked/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='RDOrdLocked' [[Val]] /><input type = 'hidden' data-bound-name='RDOrdLocked' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdLocked.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdLocked";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "RDOrdLocked")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdLocked", "@RDOrdLocked", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdLocked", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdLocked", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

