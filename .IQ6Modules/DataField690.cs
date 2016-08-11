
	
public partial class EMail_EMCC : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "CC";}
		set { } 
	}

	public string DFName=> "EMCC";

	
	public EMail_EMCC(EMail Parent) : 
		base(Parent, "EMCC"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMCCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCC").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMCC").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 690;
	}
	public string GetControlName() {
		return "EMCCValue";
	}
	public string GetDFName() {
		return "EMCC";
	}
	public string GetTitle() {
		return "CC";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMCC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMCC/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='EMCC'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMCC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMCC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMCC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMCC", "@EMCC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMCC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMCC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

