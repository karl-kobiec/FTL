
	
public partial class Trailer_TrlLastMOT : 
	DateDataFieldBase<Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Last MOT";}
		set { } 
	}

	public string DFName=> "TrlLastMOT";

	
	public Trailer_TrlLastMOT(Trailer Parent) : 
		base(Parent, "TrlLastMOT"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlLastMOTFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlLastMOT").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlLastMOT").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 263;
	}
	public string GetControlName() {
		return "TrlLastMOTValue";
	}
	public string GetDFName() {
		return "TrlLastMOT";
	}
	public string GetTitle() {
		return "Last MOT";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlLastMOT.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlLastMOT/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrlLastMOT' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlLastMOT.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlLastMOT";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlLastMOT")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlLastMOT", "@TrlLastMOT", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlLastMOT", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlLastMOT", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

