
	
public partial class REDSOrder_RDOrdJobLetter : 
	DataFieldBase<string,REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Letter";}
		set { } 
	}

	public string DFName=> "RDOrdJobLetter";

	
	public REDSOrder_RDOrdJobLetter(REDSOrder Parent) : 
		base(Parent, "RDOrdJobLetter"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class REDSOrder_RDOrdJobLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdJobLetter").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdJobLetter").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 525;
	}
	public string GetControlName() {
		return "RDOrdJobLetterValue";
	}
	public string GetDFName() {
		return "RDOrdJobLetter";
	}
	public string GetTitle() {
		return "Job Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdJobLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdJobLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOrdJobLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdJobLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdJobLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOrdJobLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdJobLetter", "@RDOrdJobLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdJobLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdJobLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

