
	
public partial class EMail_EMTo : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "To";}
		set { } 
	}

	public string DFName=> "EMTo";

	
	public EMail_EMTo(EMail Parent) : 
		base(Parent, "EMTo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMTo").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMTo").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 689;
	}
	public string GetControlName() {
		return "EMToValue";
	}
	public string GetDFName() {
		return "EMTo";
	}
	public string GetTitle() {
		return "To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMTo/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='EMTo'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMTo", "@EMTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

