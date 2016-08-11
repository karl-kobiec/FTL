
	
public partial class Inv_InvAddr : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Inv Co Address1";}
		set { } 
	}

	public string DFName=> "InvAddr";

	
	public Inv_InvAddr(Inv Parent) : 
		base(Parent, "InvAddr"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvAddr").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvAddr").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 242;
	}
	public string GetControlName() {
		return "InvAddrValue";
	}
	public string GetDFName() {
		return "InvAddr";
	}
	public string GetTitle() {
		return "Inv Co Address1";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvAddr/?RecId=[[RecId]]',$(this));\" data-bound-name='InvAddr' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvAddr", "@InvAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

