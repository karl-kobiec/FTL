
	
public partial class CN_CNTrailer : 
	DataFieldBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Trailer";}
		set { } 
	}

	public string DFName=> "CNTrailer";

	
	public CN_CNTrailer(CN Parent) : 
		base(Parent, "CNTrailer"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNTrailerFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTrailer").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTrailer").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 206;
	}
	public string GetControlName() {
		return "CNTrailerValue";
	}
	public string GetDFName() {
		return "CNTrailer";
	}
	public string GetTitle() {
		return "Trailer";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNTrailer.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNTrailer/?RecId=[[RecId]]',$(this));\" data-bound-name='CNTrailer' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNTrailer.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNTrailer";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNTrailer")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNTrailer", "@CNTrailer", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNTrailer", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNTrailer", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

