
	
public partial class ChangeReq_CRIqNotesArch : 
	DataFieldBase<string,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Intrinsiq Notes Archive";}
		set { } 
	}

	public string DFName=> "CRIqNotesArch";

	
	public ChangeReq_CRIqNotesArch(ChangeReq Parent) : 
		base(Parent, "CRIqNotesArch"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ChangeReq_CRIqNotesArchFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIqNotesArch").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIqNotesArch").First().Value(new ChangeReq());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 669;
	}
	public string GetControlName() {
		return "CRIqNotesArchValue";
	}
	public string GetDFName() {
		return "CRIqNotesArch";
	}
	public string GetTitle() {
		return "Intrinsiq Notes Archive";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRIqNotesArch.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIqNotesArch/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CRIqNotesArch'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRIqNotesArch.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRIqNotesArch";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CRIqNotesArch")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRIqNotesArch", "@CRIqNotesArch", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRIqNotesArch", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRIqNotesArch", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

