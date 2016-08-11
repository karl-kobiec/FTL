
	
public partial class EMail_EMSubject : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Subject";}
		set { } 
	}

	public string DFName=> "EMSubject";

	
	public EMail_EMSubject(EMail Parent) : 
		base(Parent, "EMSubject"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMSubjectFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMSubject").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMSubject").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 691;
	}
	public string GetControlName() {
		return "EMSubjectValue";
	}
	public string GetDFName() {
		return "EMSubject";
	}
	public string GetTitle() {
		return "Subject";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMSubject.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMSubject/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='EMSubject'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMSubject.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMSubject";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMSubject")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMSubject", "@EMSubject", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMSubject", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMSubject", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

