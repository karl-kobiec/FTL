
	
public partial class InvLine_InvLLineNo : 
	FormattableDataFieldBase<int,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Number";}
		set { } 
	}

	public string DFName=> "InvLLineNo";

	
	public InvLine_InvLLineNo(InvLine Parent) : 
		base(Parent, "InvLLineNo"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLLineNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLLineNo").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLLineNo").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 118;
	}
	public string GetControlName() {
		return "InvLLineNoValue";
	}
	public string GetDFName() {
		return "InvLLineNo";
	}
	public string GetTitle() {
		return "Line Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLLineNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLLineNo/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLLineNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLLineNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLLineNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLLineNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLLineNo", "@InvLLineNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLLineNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLLineNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

