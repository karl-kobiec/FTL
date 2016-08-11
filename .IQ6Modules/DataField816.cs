
	
public partial class Reporting_RptContent : 
	DataFieldBase<string,Reporting>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "New Field";}
		set { } 
	}

	public string DFName=> "RptContent";

	
	public Reporting_RptContent(Reporting Parent) : 
		base(Parent, "RptContent"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Reporting_RptContentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptContent").Any()) 
			return DS.GetManager<Reporting>().OnDataSource.Where(f=> f.Key == "RptContent").First().Value(new Reporting());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 816;
	}
	public string GetControlName() {
		return "RptContentValue";
	}
	public string GetDFName() {
		return "RptContent";
	}
	public string GetTitle() {
		return "New Field";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Reporting ds;
					ds = (Reporting)dsI;
		 
		
		return ds.RptContent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Reporting ds;
				ds = (Reporting)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Reporting/SaveRptContent/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='RptContent'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RptContent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RptContent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RptContent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RptContent", "@RptContent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RptContent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Reporting").GetFieldOperators("RptContent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

