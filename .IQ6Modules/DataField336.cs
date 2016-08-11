
	
public partial class ExchRate_ExRSDate : 
	DateDataFieldBase<ExchRate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "From";}
		set { } 
	}

	public string DFName=> "ExRSDate";

	
	public ExchRate_ExRSDate(ExchRate Parent) : 
		base(Parent, "ExRSDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ExchRate_ExRSDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRSDate").Any()) 
			return DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRSDate").First().Value(new ExchRate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 336;
	}
	public string GetControlName() {
		return "ExRSDateValue";
	}
	public string GetDFName() {
		return "ExRSDate";
	}
	public string GetTitle() {
		return "From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ExchRate ds;
					ds = (ExchRate)dsI;
		 
		
		return ds.ExRSDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ExchRate ds;
				ds = (ExchRate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRSDate/?RecId=[[RecId]]',$(this));\" data-bound-name='ExRSDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ExRSDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ExRSDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ExRSDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ExRSDate", "@ExRSDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ExRSDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ExchRate").GetFieldOperators("ExRSDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

