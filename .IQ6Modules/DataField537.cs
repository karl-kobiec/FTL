
	
public partial class REDSOrdLine_RDOLAlcPct : 
	FormattableDataFieldBase<double,REDSOrdLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Alcohol Percentage";}
		set { } 
	}

	public string DFName=> "RDOLAlcPct";

	
	public REDSOrdLine_RDOLAlcPct(REDSOrdLine Parent) : 
		base(Parent, "RDOLAlcPct"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSOrdLine_RDOLAlcPctFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLAlcPct").Any()) 
			return DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLAlcPct").First().Value(new REDSOrdLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 537;
	}
	public string GetControlName() {
		return "RDOLAlcPctValue";
	}
	public string GetDFName() {
		return "RDOLAlcPct";
	}
	public string GetTitle() {
		return "Alcohol Percentage";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrdLine ds;
					ds = (REDSOrdLine)dsI;
		 
		
		return ds.RDOLAlcPct.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrdLine ds;
				ds = (REDSOrdLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLAlcPct/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOLAlcPct' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOLAlcPct.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOLAlcPct";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOLAlcPct")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOLAlcPct", "@RDOLAlcPct", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOLAlcPct", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrdLine").GetFieldOperators("RDOLAlcPct", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

