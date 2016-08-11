
	
public partial class Inv_InvTown : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Inv Co Town";}
		set { } 
	}

	public string DFName=> "InvTown";

	
	public Inv_InvTown(Inv Parent) : 
		base(Parent, "InvTown"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvTownFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTown").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTown").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 243;
	}
	public string GetControlName() {
		return "InvTownValue";
	}
	public string GetDFName() {
		return "InvTown";
	}
	public string GetTitle() {
		return "Inv Co Town";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvTown.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvTown/?RecId=[[RecId]]',$(this));\" data-bound-name='InvTown' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvTown.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvTown";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvTown")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvTown", "@InvTown", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvTown", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvTown", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

