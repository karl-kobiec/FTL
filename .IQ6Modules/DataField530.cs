
	
public partial class REDSOrdLine_RDOLLineNo : 
	FormattableDataFieldBase<int,REDSOrdLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Number";}
		set { } 
	}

	public string DFName=> "RDOLLineNo";

	
	public REDSOrdLine_RDOLLineNo(REDSOrdLine Parent) : 
		base(Parent, "RDOLLineNo"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSOrdLine_RDOLLineNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLineNo").Any()) 
			return DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLineNo").First().Value(new REDSOrdLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 530;
	}
	public string GetControlName() {
		return "RDOLLineNoValue";
	}
	public string GetDFName() {
		return "RDOLLineNo";
	}
	public string GetTitle() {
		return "Line Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrdLine ds;
					ds = (REDSOrdLine)dsI;
		 
		
		return ds.RDOLLineNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrdLine ds;
				ds = (REDSOrdLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLineNo/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOLLineNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOLLineNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOLLineNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOLLineNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOLLineNo", "@RDOLLineNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOLLineNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrdLine").GetFieldOperators("RDOLLineNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

