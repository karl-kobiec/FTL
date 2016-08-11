
	
public partial class Inv_InvDesc : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Description";}
		set { } 
	}

	public string DFName=> "InvDesc";

	
	public Inv_InvDesc(Inv Parent) : 
		base(Parent, "InvDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvDesc").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvDesc").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 106;
	}
	public string GetControlName() {
		return "InvDescValue";
	}
	public string GetDFName() {
		return "InvDesc";
	}
	public string GetTitle() {
		return "Invoice Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Inv/SaveInvDesc/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='InvDesc'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvDesc", "@InvDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

