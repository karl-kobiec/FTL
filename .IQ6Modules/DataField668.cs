
	
public partial class ChangeReq_CRResolved : 
	DataFieldBase<string,ChangeReq>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Resolved";}
		set { } 
	}

	public string DFName=> "CRResolved";

	
	public ChangeReq_CRResolved(ChangeReq Parent) : 
		base(Parent, "CRResolved"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ChangeReq_CRResolvedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRResolved").Any()) 
			return DS.GetManager<ChangeReq>().OnDataSource.Where(f=> f.Key == "CRResolved").First().Value(new ChangeReq());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 668;
	}
	public string GetControlName() {
		return "CRResolvedValue";
	}
	public string GetDFName() {
		return "CRResolved";
	}
	public string GetTitle() {
		return "Resolved";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ChangeReq ds;
					ds = (ChangeReq)dsI;
		 
		
		return ds.CRResolved.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ChangeReq ds;
				ds = (ChangeReq)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ChangeReq/SaveCRResolved/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CRResolved'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CRResolved.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CRResolved";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CRResolved")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CRResolved", "@CRResolved", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CRResolved", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ChangeReq").GetFieldOperators("CRResolved", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

