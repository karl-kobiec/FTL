
	
public partial class Inv_InvTescoRef : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tesco Ref";}
		set { } 
	}

	public string DFName=> "InvTescoRef";

	
	public Inv_InvTescoRef(Inv Parent) : 
		base(Parent, "InvTescoRef"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvTescoRefFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTescoRef").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTescoRef").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 268;
	}
	public string GetControlName() {
		return "InvTescoRefValue";
	}
	public string GetDFName() {
		return "InvTescoRef";
	}
	public string GetTitle() {
		return "Tesco Ref";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvTescoRef.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvTescoRef/?RecId=[[RecId]]',$(this));\" data-bound-name='InvTescoRef' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvTescoRef.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvTescoRef";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvTescoRef")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvTescoRef", "@InvTescoRef", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvTescoRef", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvTescoRef", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

