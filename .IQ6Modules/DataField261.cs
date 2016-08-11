
	
public partial class Trailer_TrlNextServDue : 
	DateDataFieldBase<Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Next Service Due";}
		set { } 
	}

	public string DFName=> "TrlNextServDue";

	
	public Trailer_TrlNextServDue(Trailer Parent) : 
		base(Parent, "TrlNextServDue"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlNextServDueFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNextServDue").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlNextServDue").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 261;
	}
	public string GetControlName() {
		return "TrlNextServDueValue";
	}
	public string GetDFName() {
		return "TrlNextServDue";
	}
	public string GetTitle() {
		return "Next Service Due";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlNextServDue.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlNextServDue/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrlNextServDue' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlNextServDue.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlNextServDue";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlNextServDue")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlNextServDue", "@TrlNextServDue", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlNextServDue", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlNextServDue", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

