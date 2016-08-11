
	
public partial class Inv_InvPC : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Inv Co Postcode";}
		set { } 
	}

	public string DFName=> "InvPC";

	
	public Inv_InvPC(Inv Parent) : 
		base(Parent, "InvPC"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvPC").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvPC").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 244;
	}
	public string GetControlName() {
		return "InvPCValue";
	}
	public string GetDFName() {
		return "InvPC";
	}
	public string GetTitle() {
		return "Inv Co Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvPC/?RecId=[[RecId]]',$(this));\" data-bound-name='InvPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvPC", "@InvPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

