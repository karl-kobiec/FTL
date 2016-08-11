
	
public partial class EMail_EMDS : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Dataset";}
		set { } 
	}

	public string DFName=> "EMDS";

	
	public EMail_EMDS(EMail Parent) : 
		base(Parent, "EMDS"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class EMail_EMDSFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDS").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDS").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 687;
	}
	public string GetControlName() {
		return "EMDSValue";
	}
	public string GetDFName() {
		return "EMDS";
	}
	public string GetTitle() {
		return "Dataset";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMDS.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EMail/SaveEMDS/?RecId=[[RecId]]',$(this));\" data-bound-name='EMDS' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMDS.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMDS";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMDS")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMDS", "@EMDS", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMDS", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMDS", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

