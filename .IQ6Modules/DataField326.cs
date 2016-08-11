
	
public partial class Inv_InvProforma : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Proforma";}
		set { } 
	}

	public string DFName=> "InvProforma";

	
	public Inv_InvProforma(Inv Parent) : 
		base(Parent, "InvProforma"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvProformaFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvProforma").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvProforma").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 326;
	}
	public string GetControlName() {
		return "InvProformaValue";
	}
	public string GetDFName() {
		return "InvProforma";
	}
	public string GetTitle() {
		return "Proforma";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvProforma.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvProforma/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvProforma' [[Val]] /><input type = 'hidden' data-bound-name='InvProforma' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvProforma.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvProforma";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvProforma")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvProforma", "@InvProforma", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvProforma", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvProforma", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

