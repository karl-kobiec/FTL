
	
public partial class Truck_TrkShellNo : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Shell No:";}
		set { } 
	}

	public string DFName=> "TrkShellNo";

	
	public Truck_TrkShellNo(Truck Parent) : 
		base(Parent, "TrkShellNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkShellNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkShellNo").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkShellNo").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 806;
	}
	public string GetControlName() {
		return "TrkShellNoValue";
	}
	public string GetDFName() {
		return "TrkShellNo";
	}
	public string GetTitle() {
		return "Shell No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkShellNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkShellNo/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkShellNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkShellNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkShellNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkShellNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkShellNo", "@TrkShellNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkShellNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkShellNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

