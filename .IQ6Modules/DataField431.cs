
	
public partial class Trailer_TrlId : 
	FormattableDataFieldBase<int,Trailer>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Trailer Id";}
		set { } 
	}

	public string DFName=> "TrlId";

	
	public Trailer_TrlId(Trailer Parent) : 
		base(Parent, "TrlId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Trailer_TrlIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlId").Any()) 
			return DS.GetManager<Trailer>().OnDataSource.Where(f=> f.Key == "TrlId").First().Value(new Trailer());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 431;
	}
	public string GetControlName() {
		return "TrlIdValue";
	}
	public string GetDFName() {
		return "TrlId";
	}
	public string GetTitle() {
		return "Trailer Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Trailer ds;
					ds = (Trailer)dsI;
		 
		
		return ds.TrlId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Trailer ds;
				ds = (Trailer)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Trailer/SaveTrlId/?RecId=[[RecId]]',$(this));\" data-bound-name='TrlId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.TrlId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "TrlId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "TrlId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "TrlId", "@TrlId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "TrlId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Trailer").GetFieldOperators("TrlId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

