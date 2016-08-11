
	
public partial class Trailer_TrlDaysRem : 
	FormattableDataFieldBase<int,Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Days Remaining";}
		set { } 
	}

	public string DFName=> "TrlDaysRem";

	
	public Trailer_TrlDaysRem(Trailer Parent) : 
		base(Parent, "TrlDaysRem"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Trailer_TrlDaysRemFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlDaysRem").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlDaysRem").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 262;
	}
	public string GetControlName() {
		return "TrlDaysRemValue";
	}
	public string GetDFName() {
		return "TrlDaysRem";
	}
	public string GetTitle() {
		return "Days Remaining";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlDaysRem.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlDaysRem/?RecId=[[RecId]]',$(this));\" data-bound-name='TrlDaysRem' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlDaysRem.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlDaysRem";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlDaysRem")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlDaysRem", "@TrlDaysRem", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlDaysRem", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlDaysRem", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

