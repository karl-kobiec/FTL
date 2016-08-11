
	
public partial class Inv_InvISPInv : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Is Period Invoice";}
		set { } 
	}

	public string DFName=> "InvISPInv";

	
	public Inv_InvISPInv(Inv Parent) : 
		base(Parent, "InvISPInv"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvISPInvFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvISPInv").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvISPInv").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 270;
	}
	public string GetControlName() {
		return "InvISPInvValue";
	}
	public string GetDFName() {
		return "InvISPInv";
	}
	public string GetTitle() {
		return "Is Period Invoice";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvISPInv.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvISPInv/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvISPInv' [[Val]] /><input type = 'hidden' data-bound-name='InvISPInv' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvISPInv.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvISPInv";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvISPInv")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvISPInv", "@InvISPInv", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvISPInv", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvISPInv", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

