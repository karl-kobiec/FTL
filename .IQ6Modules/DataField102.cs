
	
public partial class Inv_InvFerryName : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Name";}
		set { } 
	}

	public string DFName=> "InvFerryName";

	
	public Inv_InvFerryName(Inv Parent) : 
		base(Parent, "InvFerryName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvFerryNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryName").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryName").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 102;
	}
	public string GetControlName() {
		return "InvFerryNameValue";
	}
	public string GetDFName() {
		return "InvFerryName";
	}
	public string GetTitle() {
		return "Ferry Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvFerryName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryName/?RecId=[[RecId]]',$(this));\" data-bound-name='InvFerryName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvFerryName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvFerryName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvFerryName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvFerryName", "@InvFerryName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvFerryName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvFerryName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

