
	
public partial class Trailer_TrlNextMOTDue : 
	DateDataFieldBase<Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Next MOT Due";}
		set { } 
	}

	public string DFName=> "TrlNextMOTDue";

	
	public Trailer_TrlNextMOTDue(Trailer Parent) : 
		base(Parent, "TrlNextMOTDue"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlNextMOTDueFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNextMOTDue").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNextMOTDue").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 264;
	}
	public string GetControlName() {
		return "TrlNextMOTDueValue";
	}
	public string GetDFName() {
		return "TrlNextMOTDue";
	}
	public string GetTitle() {
		return "Next MOT Due";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlNextMOTDue.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNextMOTDue/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrlNextMOTDue' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlNextMOTDue.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlNextMOTDue";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlNextMOTDue")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlNextMOTDue", "@TrlNextMOTDue", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlNextMOTDue", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlNextMOTDue", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

