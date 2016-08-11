
	
public partial class Inv_InvTotal : 
	FormattableDataFieldBase<double,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Total";}
		set { } 
	}

	public string DFName=> "InvTotal";

	
	public Inv_InvTotal(Inv Parent) : 
		base(Parent, "InvTotal"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvTotalFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTotal").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTotal").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 109;
	}
	public string GetControlName() {
		return "InvTotalValue";
	}
	public string GetDFName() {
		return "InvTotal";
	}
	public string GetTitle() {
		return "Invoice Total";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvTotal.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvTotal/?RecId=[[RecId]]',$(this));\" data-bound-name='InvTotal' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvTotal.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvTotal";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvTotal")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvTotal", "@InvTotal", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvTotal", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvTotal", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

