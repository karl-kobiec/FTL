
	
public partial class Truck_TrkPermitNo : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Permit No:";}
		set { } 
	}

	public string DFName=> "TrkPermitNo";

	
	public Truck_TrkPermitNo(Truck Parent) : 
		base(Parent, "TrkPermitNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkPermitNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkPermitNo").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkPermitNo").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 808;
	}
	public string GetControlName() {
		return "TrkPermitNoValue";
	}
	public string GetDFName() {
		return "TrkPermitNo";
	}
	public string GetTitle() {
		return "Permit No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkPermitNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkPermitNo/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkPermitNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkPermitNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkPermitNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkPermitNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkPermitNo", "@TrkPermitNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkPermitNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkPermitNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

