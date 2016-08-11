
	
public partial class Truck_TrkId : 
	FormattableDataFieldBase<int,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Truck ID";}
		set { } 
	}

	public string DFName=> "TrkId";

	
	public Truck_TrkId(Truck Parent) : 
		base(Parent, "TrkId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Truck_TrkIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkId").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkId").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 397;
	}
	public string GetControlName() {
		return "TrkIdValue";
	}
	public string GetDFName() {
		return "TrkId";
	}
	public string GetTitle() {
		return "Truck ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkId/?RecId=[[RecId]]',$(this));\" data-bound-name='TrkId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkId", "@TrkId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

