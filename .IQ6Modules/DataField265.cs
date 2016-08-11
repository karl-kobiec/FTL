
	
public partial class Trailer_TrlStatus : 
	DataFieldBase<string,Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Status";}
		set { } 
	}

	public string DFName=> "TrlStatus";

	
	public Trailer_TrlStatus(Trailer Parent) : 
		base(Parent, "TrlStatus"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Trailer_TrlStatusFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlStatus").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlStatus").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 265;
	}
	public string GetControlName() {
		return "TrlStatusValue";
	}
	public string GetDFName() {
		return "TrlStatus";
	}
	public string GetTitle() {
		return "Status";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlStatus.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlStatus/?RecId=[[RecId]]',$(this));\" data-bound-name='TrlStatus' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlStatus.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlStatus";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlStatus")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlStatus", "@TrlStatus", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlStatus", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlStatus", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

