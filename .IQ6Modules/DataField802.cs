
	
public partial class Truck_TrkAS24No : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "AS24 Card No:";}
		set { } 
	}

	public string DFName=> "TrkAS24No";

	
	public Truck_TrkAS24No(Truck Parent) : 
		base(Parent, "TrkAS24No"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkAS24NoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkAS24No").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkAS24No").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 802;
	}
	public string GetControlName() {
		return "TrkAS24NoValue";
	}
	public string GetDFName() {
		return "TrkAS24No";
	}
	public string GetTitle() {
		return "AS24 Card No:";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkAS24No.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkAS24No/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkAS24No' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkAS24No.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkAS24No";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkAS24No")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkAS24No", "@TrkAS24No", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkAS24No", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkAS24No", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

