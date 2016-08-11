
	
public partial class Trailer_TrlFleetNo : 
	DataFieldBase<string,Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Fleet Number";}
		set { } 
	}

	public string DFName=> "TrlFleetNo";

	
	public Trailer_TrlFleetNo(Trailer Parent) : 
		base(Parent, "TrlFleetNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Trailer_TrlFleetNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlFleetNo").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlFleetNo").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 259;
	}
	public string GetControlName() {
		return "TrlFleetNoValue";
	}
	public string GetDFName() {
		return "TrlFleetNo";
	}
	public string GetTitle() {
		return "Fleet Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlFleetNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlFleetNo/?RecId=[[RecId]]',$(this));\" data-bound-name='TrlFleetNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlFleetNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlFleetNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlFleetNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlFleetNo", "@TrlFleetNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlFleetNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlFleetNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

