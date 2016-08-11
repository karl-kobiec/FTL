
	
public partial class Inv_InvExported : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent to Dover";}
		set { } 
	}

	public string DFName=> "InvExported";

	
	public Inv_InvExported(Inv Parent) : 
		base(Parent, "InvExported"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvExportedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvExported").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvExported").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 172;
	}
	public string GetControlName() {
		return "InvExportedValue";
	}
	public string GetDFName() {
		return "InvExported";
	}
	public string GetTitle() {
		return "Sent to Dover";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvExported.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvExported/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvExported' [[Val]] /><input type = 'hidden' data-bound-name='InvExported' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvExported.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvExported";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvExported")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvExported", "@InvExported", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvExported", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvExported", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

