
	
public partial class EMail_EMDF : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "DataField";}
		set { } 
	}

	public string DFName=> "EMDF";

	
	public EMail_EMDF(EMail Parent) : 
		base(Parent, "EMDF"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMDFFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDF").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDF").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 718;
	}
	public string GetControlName() {
		return "EMDFValue";
	}
	public string GetDFName() {
		return "EMDF";
	}
	public string GetTitle() {
		return "DataField";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMDF.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EMail/SaveEMDF/?RecId=[[RecId]]',$(this));\" data-bound-name='EMDF' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMDF.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMDF";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMDF")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMDF", "@EMDF", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMDF", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMDF", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

