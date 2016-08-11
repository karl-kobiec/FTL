
	
public partial class ChangeReq_CRIqNotes : 
	DataFieldBase<string,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Intrinsiq Notes";}
		set { } 
	}

	public string DFName=> "CRIqNotes";

	
	public ChangeReq_CRIqNotes(ChangeReq Parent) : 
		base(Parent, "CRIqNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ChangeReq_CRIqNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIqNotes").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRIqNotes").First().Value(new ChangeReq());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 667;
	}
	public string GetControlName() {
		return "CRIqNotesValue";
	}
	public string GetDFName() {
		return "CRIqNotes";
	}
	public string GetTitle() {
		return "Intrinsiq Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRIqNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRIqNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CRIqNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRIqNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRIqNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CRIqNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRIqNotes", "@CRIqNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRIqNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRIqNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

