
	
public partial class InvLine_InvLTotal : 
	FormattableDataFieldBase<double,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Total";}
		set { } 
	}

	public string DFName=> "InvLTotal";

	
	public InvLine_InvLTotal(InvLine Parent) : 
		base(Parent, "InvLTotal"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLTotalFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLTotal").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLTotal").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 124;
	}
	public string GetControlName() {
		return "InvLTotalValue";
	}
	public string GetDFName() {
		return "InvLTotal";
	}
	public string GetTitle() {
		return "Line Total";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLTotal.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLTotal/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLTotal' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLTotal.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLTotal";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLTotal")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLTotal", "@InvLTotal", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLTotal", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLTotal", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

