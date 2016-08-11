
	
public partial class Inv_InvTrailer : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Trailer";}
		set { } 
	}

	public string DFName=> "InvTrailer";

	
	public Inv_InvTrailer(Inv Parent) : 
		base(Parent, "InvTrailer"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Inv_InvTrailerFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTrailer").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvTrailer").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 99;
	}
	public string GetControlName() {
		return "InvTrailerValue";
	}
	public string GetDFName() {
		return "InvTrailer";
	}
	public string GetTitle() {
		return "Trailer";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvTrailer.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvTrailer/?RecId=[[RecId]]',$(this));\" data-bound-name='InvTrailer' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvTrailer.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvTrailer";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvTrailer")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvTrailer", "@InvTrailer", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvTrailer", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvTrailer", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

