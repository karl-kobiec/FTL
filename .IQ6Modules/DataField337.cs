
	
public partial class ExchRate_ExREDate : 
	DateDataFieldBase<ExchRate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "To";}
		set { } 
	}

	public string DFName=> "ExREDate";

	
	public ExchRate_ExREDate(ExchRate Parent) : 
		base(Parent, "ExREDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ExchRate_ExREDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExREDate").Any()) 
			return DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExREDate").First().Value(new ExchRate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 337;
	}
	public string GetControlName() {
		return "ExREDateValue";
	}
	public string GetDFName() {
		return "ExREDate";
	}
	public string GetTitle() {
		return "To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ExchRate ds;
					ds = (ExchRate)dsI;
		 
		
		return ds.ExREDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ExchRate ds;
				ds = (ExchRate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ExchRate/SaveExREDate/?RecId=[[RecId]]',$(this));\" data-bound-name='ExREDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ExREDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ExREDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ExREDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ExREDate", "@ExREDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ExREDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ExchRate").GetFieldOperators("ExREDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

