
	
public partial class TruckMileage_TrkMNotes : 
	DataFieldBase<string,TruckMileage>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Notes";}
		set { } 
	}

	public string DFName=> "TrkMNotes";

	
	public TruckMileage_TrkMNotes(TruckMileage Parent) : 
		base(Parent, "TrkMNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class TruckMileage_TrkMNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMNotes").Any()) 
			return DS.GetManager<TruckMileage>().OnDataSource.Where(f=> f.Key == "TrkMNotes").First().Value(new TruckMileage());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 404;
	}
	public string GetControlName() {
		return "TrkMNotesValue";
	}
	public string GetDFName() {
		return "TrkMNotes";
	}
	public string GetTitle() {
		return "Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		TruckMileage ds;
					ds = (TruckMileage)dsI;
		 
		
		return ds.TrkMNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		TruckMileage ds;
				ds = (TruckMileage)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/TruckMileage/SaveTrkMNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='TrkMNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrkMNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrkMNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrkMNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrkMNotes", "@TrkMNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrkMNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("TruckMileage").GetFieldOperators("TrkMNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

