
	
public partial class Truck_TrkNotes : 
	DataFieldBase<string,Truck>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Notes";}
		set { } 
	}

	public string DFName=> "TrkNotes";

	
	public Truck_TrkNotes(Truck Parent) : 
		base(Parent, "TrkNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Truck_TrkNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkNotes").Any()) 
			return DS.GetManager<Truck>().OnDataSource.Where(f=> f.Key == "TrkNotes").First().Value(new Truck());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 399;
	}
	public string GetControlName() {
		return "TrkNotesValue";
	}
	public string GetDFName() {
		return "TrkNotes";
	}
	public string GetTitle() {
		return "Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Truck ds;
					ds = (Truck)dsI;
		 
		
		return ds.TrkNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Truck ds;
				ds = (Truck)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Truck/SaveTrkNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='TrkNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkNotes", "@TrkNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Truck").GetFieldOperators("TrkNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

