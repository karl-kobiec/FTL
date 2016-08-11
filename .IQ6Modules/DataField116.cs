
	
public partial class InvComment_InvCName : 
	DataFieldBase<string,InvComment>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Inv Comment";}
		set { } 
	}

	public string DFName=> "InvCName";

	
	public InvComment_InvCName(InvComment Parent) : 
		base(Parent, "InvCName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class InvComment_InvCNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvComment>().OnDataSource.Where(f=> f.Key == "InvCName").Any()) 
			return DS.GetManager<InvComment>().OnDataSource.Where(f=> f.Key == "InvCName").First().Value(new InvComment());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 116;
	}
	public string GetControlName() {
		return "InvCNameValue";
	}
	public string GetDFName() {
		return "InvCName";
	}
	public string GetTitle() {
		return "Inv Comment";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvComment ds;
					ds = (InvComment)dsI;
		 
		
		return ds.InvCName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvComment ds;
				ds = (InvComment)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/InvComment/SaveInvCName/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='InvCName'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvCName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvCName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvCName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvCName", "@InvCName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvCName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvComment").GetFieldOperators("InvCName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

