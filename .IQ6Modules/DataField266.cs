
	
public partial class Trailer_TrlNotes : 
	DataFieldBase<string,Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Comments";}
		set { } 
	}

	public string DFName=> "TrlNotes";

	
	public Trailer_TrlNotes(Trailer Parent) : 
		base(Parent, "TrlNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNotes").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNotes").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 266;
	}
	public string GetControlName() {
		return "TrlNotesValue";
	}
	public string GetDFName() {
		return "TrlNotes";
	}
	public string GetTitle() {
		return "Comments";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='TrlNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlNotes", "@TrlNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

