
	
public partial class REDSOrdLine_RDOLLocked : 
	BoolDataFieldBase<REDSOrdLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Locked";}
		set { } 
	}

	public string DFName=> "RDOLLocked";

	
	public REDSOrdLine_RDOLLocked(REDSOrdLine Parent) : 
		base(Parent, "RDOLLocked"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class REDSOrdLine_RDOLLockedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLocked").Any()) 
			return DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLocked").First().Value(new REDSOrdLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 540;
	}
	public string GetControlName() {
		return "RDOLLockedValue";
	}
	public string GetDFName() {
		return "RDOLLocked";
	}
	public string GetTitle() {
		return "Locked";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrdLine ds;
					ds = (REDSOrdLine)dsI;
		 
		
		return ds.RDOLLocked.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrdLine ds;
				ds = (REDSOrdLine)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLocked/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='RDOLLocked' [[Val]] /><input type = 'hidden' data-bound-name='RDOLLocked' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOLLocked.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOLLocked";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "RDOLLocked")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOLLocked", "@RDOLLocked", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOLLocked", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrdLine").GetFieldOperators("RDOLLocked", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

