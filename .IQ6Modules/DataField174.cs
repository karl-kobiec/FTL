
	
public partial class Inv_InvCustOrd : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Order No";}
		set { } 
	}

	public string DFName=> "InvCustOrd";

	
	public Inv_InvCustOrd(Inv Parent) : 
		base(Parent, "InvCustOrd"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvCustOrdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCustOrd").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvCustOrd").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 174;
	}
	public string GetControlName() {
		return "InvCustOrdValue";
	}
	public string GetDFName() {
		return "InvCustOrd";
	}
	public string GetTitle() {
		return "Client Order No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvCustOrd.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvCustOrd/?RecId=[[RecId]]',$(this));\" data-bound-name='InvCustOrd' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvCustOrd.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvCustOrd";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvCustOrd")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvCustOrd", "@InvCustOrd", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvCustOrd", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvCustOrd", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

