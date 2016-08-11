
	
public partial class ChangeReq_CRIssues : 
	DataFieldBase<string,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description";}
		set { } 
	}

	public string DFName=> "CRIssues";

	
	public ChangeReq_CRIssues(ChangeReq Parent) : 
		base(Parent, "CRIssues"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ChangeReq_CRIssuesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIssues").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIssues").First().Value(new ChangeReq());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 666;
	}
	public string GetControlName() {
		return "CRIssuesValue";
	}
	public string GetDFName() {
		return "CRIssues";
	}
	public string GetTitle() {
		return "Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRIssues.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIssues/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CRIssues'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRIssues.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRIssues";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CRIssues")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRIssues", "@CRIssues", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRIssues", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRIssues", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

