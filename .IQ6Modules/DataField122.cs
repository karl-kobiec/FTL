
	
public partial class InvLine_InvLAmt : 
	FormattableDataFieldBase<double,InvLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Amount";}
		set { } 
	}

	public string DFName=> "InvLAmt";

	
	public InvLine_InvLAmt(InvLine Parent) : 
		base(Parent, "InvLAmt"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class InvLine_InvLAmtFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLAmt").Any()) 
			return DS.GetManager<InvLine>().OnDataSource.Where(f=> f.Key == "InvLAmt").First().Value(new InvLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 122;
	}
	public string GetControlName() {
		return "InvLAmtValue";
	}
	public string GetDFName() {
		return "InvLAmt";
	}
	public string GetTitle() {
		return "Line Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvLine ds;
					ds = (InvLine)dsI;
		 
		
		return ds.InvLAmt.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvLine ds;
				ds = (InvLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvLine/SaveInvLAmt/?RecId=[[RecId]]',$(this));\" data-bound-name='InvLAmt' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvLAmt.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvLAmt";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvLAmt")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvLAmt", "@InvLAmt", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvLAmt", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvLine").GetFieldOperators("InvLAmt", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

