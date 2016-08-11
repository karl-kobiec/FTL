
	
public partial class REDSOrdLine_RDOLCases : 
	FormattableDataFieldBase<int,REDSOrdLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Cases";}
		set { } 
	}

	public string DFName=> "RDOLCases";

	
	public REDSOrdLine_RDOLCases(REDSOrdLine Parent) : 
		base(Parent, "RDOLCases"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSOrdLine_RDOLCasesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLCases").Any()) 
			return DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLCases").First().Value(new REDSOrdLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 531;
	}
	public string GetControlName() {
		return "RDOLCasesValue";
	}
	public string GetDFName() {
		return "RDOLCases";
	}
	public string GetTitle() {
		return "Cases";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrdLine ds;
					ds = (REDSOrdLine)dsI;
		 
		
		return ds.RDOLCases.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrdLine ds;
				ds = (REDSOrdLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLCases/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOLCases' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOLCases.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOLCases";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOLCases")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOLCases", "@RDOLCases", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOLCases", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrdLine").GetFieldOperators("RDOLCases", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

