
	
public partial class Reporting_RptTitle : 
	DataFieldBase<string,Reporting>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "New Field";}
		set { } 
	}

	public string DFName=> "RptTitle";

	
	public Reporting_RptTitle(Reporting Parent) : 
		base(Parent, "RptTitle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Reporting_RptTitleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptTitle").Any()) 
			return DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptTitle").First().Value(new Reporting());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 815;
	}
	public string GetControlName() {
		return "RptTitleValue";
	}
	public string GetDFName() {
		return "RptTitle";
	}
	public string GetTitle() {
		return "New Field";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Reporting ds;
					ds = (Reporting)dsI;
		 
		
		return ds.RptTitle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Reporting ds;
				ds = (Reporting)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Reporting/SaveRptTitle/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='RptTitle'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RptTitle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RptTitle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RptTitle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RptTitle", "@RptTitle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RptTitle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Reporting").GetFieldOperators("RptTitle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

