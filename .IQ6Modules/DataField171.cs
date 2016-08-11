
	
public partial class Inv_InvToExport : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Send to Dover";}
		set { } 
	}

	public string DFName=> "InvToExport";

	
	public Inv_InvToExport(Inv Parent) : 
		base(Parent, "InvToExport"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvToExportFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvToExport").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvToExport").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 171;
	}
	public string GetControlName() {
		return "InvToExportValue";
	}
	public string GetDFName() {
		return "InvToExport";
	}
	public string GetTitle() {
		return "Send to Dover";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvToExport.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvToExport/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvToExport' [[Val]] /><input type = 'hidden' data-bound-name='InvToExport' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvToExport.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvToExport";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvToExport")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvToExport", "@InvToExport", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvToExport", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvToExport", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

