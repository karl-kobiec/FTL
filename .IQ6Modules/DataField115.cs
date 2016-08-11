
	
public partial class InvComment_InvCId : 
	FormattableDataFieldBase<int,InvComment>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Inv Comment ID";}
		set { } 
	}

	public string DFName=> "InvCId";

	
	public InvComment_InvCId(InvComment Parent) : 
		base(Parent, "InvCId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class InvComment_InvCIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvComment>().OnDataSource.Where(f=> f.Key == "InvCId").Any()) 
			return DS.GetManager<InvComment>().OnDataSource.Where(f=> f.Key == "InvCId").First().Value(new InvComment());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 115;
	}
	public string GetControlName() {
		return "InvCIdValue";
	}
	public string GetDFName() {
		return "InvCId";
	}
	public string GetTitle() {
		return "Inv Comment ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvComment ds;
					ds = (InvComment)dsI;
		 
		
		return ds.InvCId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvComment ds;
				ds = (InvComment)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvComment/SaveInvCId/?RecId=[[RecId]]',$(this));\" data-bound-name='InvCId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvCId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvCId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvCId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvCId", "@InvCId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvCId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvComment").GetFieldOperators("InvCId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

