
	
public partial class Trailer_TrlLastServ : 
	DateDataFieldBase<Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Last Service";}
		set { } 
	}

	public string DFName=> "TrlLastServ";

	
	public Trailer_TrlLastServ(Trailer Parent) : 
		base(Parent, "TrlLastServ"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlLastServFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlLastServ").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlLastServ").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 260;
	}
	public string GetControlName() {
		return "TrlLastServValue";
	}
	public string GetDFName() {
		return "TrlLastServ";
	}
	public string GetTitle() {
		return "Last Service";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlLastServ.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlLastServ/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='TrlLastServ' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlLastServ.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlLastServ";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlLastServ")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlLastServ", "@TrlLastServ", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlLastServ", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlLastServ", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

