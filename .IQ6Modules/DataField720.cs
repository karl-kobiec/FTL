
	
public partial class EMail_EMBCC : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "BCC";}
		set { } 
	}

	public string DFName=> "EMBCC";

	
	public EMail_EMBCC(EMail Parent) : 
		base(Parent, "EMBCC"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMBCCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCC").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBCC").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 720;
	}
	public string GetControlName() {
		return "EMBCCValue";
	}
	public string GetDFName() {
		return "EMBCC";
	}
	public string GetTitle() {
		return "BCC";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMBCC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMBCC/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='EMBCC'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMBCC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMBCC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMBCC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMBCC", "@EMBCC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMBCC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMBCC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

