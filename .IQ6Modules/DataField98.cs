
	
public partial class Inv_InvVehicle : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Vehicle";}
		set { } 
	}

	public string DFName=> "InvVehicle";

	
	public Inv_InvVehicle(Inv Parent) : 
		base(Parent, "InvVehicle"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvVehicleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvVehicle").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvVehicle").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 98;
	}
	public string GetControlName() {
		return "InvVehicleValue";
	}
	public string GetDFName() {
		return "InvVehicle";
	}
	public string GetTitle() {
		return "Vehicle";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvVehicle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvVehicle/?RecId=[[RecId]]',$(this));\" data-bound-name='InvVehicle' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvVehicle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvVehicle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvVehicle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvVehicle", "@InvVehicle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvVehicle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvVehicle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

