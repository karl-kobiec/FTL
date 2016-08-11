
	
public partial class InvLine_InvLInvNo : 
	FormattableDataFieldBase<int,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Number";}
		set { } 
	}

	public string DFName=> "InvLInvNo";

	
	public InvLine_InvLInvNo(InvLine Parent) : 
		base(Parent, "InvLInvNo"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLInvNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLInvNo").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLInvNo").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 117;
	}
	public string GetControlName() {
		return "InvLInvNoValue";
	}
	public string GetDFName() {
		return "InvLInvNo";
	}
	public string GetTitle() {
		return "Invoice Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLInvNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLInvNo/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLInvNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLInvNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLInvNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLInvNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLInvNo", "@InvLInvNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLInvNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLInvNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

