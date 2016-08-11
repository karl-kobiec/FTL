
	
public partial class Inv_InvFerryTime : 
	TimeDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Time";}
		set { } 
	}

	public string DFName=> "InvFerryTime";

	
	public Inv_InvFerryTime(Inv Parent) : 
		base(Parent, "InvFerryTime"
			,"HH:mm"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvFerryTimeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryTime").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryTime").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 104;
	}
	public string GetControlName() {
		return "InvFerryTimeValue";
	}
	public string GetDFName() {
		return "InvFerryTime";
	}
	public string GetTitle() {
		return "Ferry Time";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvFerryTime.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryTime/?RecId=[[RecId]]',$(this));\" data-bound-name='InvFerryTime' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvFerryTime.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvFerryTime";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvFerryTime")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvFerryTime", "@InvFerryTime", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvFerryTime", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvFerryTime", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

