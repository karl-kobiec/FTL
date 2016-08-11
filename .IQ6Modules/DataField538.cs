
	
public partial class REDSOrdLine_RDOLLitres : 
	FormattableDataFieldBase<double,REDSOrdLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Litres";}
		set { } 
	}

	public string DFName=> "RDOLLitres";

	
	public REDSOrdLine_RDOLLitres(REDSOrdLine Parent) : 
		base(Parent, "RDOLLitres"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSOrdLine_RDOLLitresFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLitres").Any()) 
			return DS.GetManager<REDSOrdLine>().OnDataSource.Where(f=> f.Key == "RDOLLitres").First().Value(new REDSOrdLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 538;
	}
	public string GetControlName() {
		return "RDOLLitresValue";
	}
	public string GetDFName() {
		return "RDOLLitres";
	}
	public string GetTitle() {
		return "Litres";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrdLine ds;
					ds = (REDSOrdLine)dsI;
		 
		
		return ds.RDOLLitres.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrdLine ds;
				ds = (REDSOrdLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrdLine/SaveRDOLLitres/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOLLitres' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOLLitres.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOLLitres";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOLLitres")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOLLitres", "@RDOLLitres", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOLLitres", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrdLine").GetFieldOperators("RDOLLitres", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

