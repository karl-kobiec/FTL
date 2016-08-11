
	
public partial class Truck_TrkDKVNo : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "DKV No:";}
		set { } 
	}

	public string DFName=> "TrkDKVNo";

	
	public Truck_TrkDKVNo(Truck Parent) : 
		base(Parent, "TrkDKVNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkDKVNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDKVNo").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkDKVNo").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 804;
	}
	public string GetControlName() {
		return "TrkDKVNoValue";
	}
	public string GetDFName() {
		return "TrkDKVNo";
	}
	public string GetTitle() {
		return "DKV No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkDKVNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkDKVNo/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkDKVNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkDKVNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkDKVNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkDKVNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkDKVNo", "@TrkDKVNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkDKVNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkDKVNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

