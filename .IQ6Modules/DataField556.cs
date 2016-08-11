
	
public partial class REDSEAD_RDEADId : 
	DataFieldBase<string,REDSEAD>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "eAD Number";}
		set { } 
	}

	public string DFName=> "RDEADId";

	
	public REDSEAD_RDEADId(REDSEAD Parent) : 
		base(Parent, "RDEADId"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class REDSEAD_RDEADIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSEAD>().OnDataSource.Where(f=> f.Key == "RDEADId").Any()) 
			return DS.GetManager<REDSEAD>().OnDataSource.Where(f=> f.Key == "RDEADId").First().Value(new REDSEAD());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 556;
	}
	public string GetControlName() {
		return "RDEADIdValue";
	}
	public string GetDFName() {
		return "RDEADId";
	}
	public string GetTitle() {
		return "eAD Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSEAD ds;
					ds = (REDSEAD)dsI;
		 
		
		return ds.RDEADId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSEAD ds;
				ds = (REDSEAD)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSEAD/SaveRDEADId/?RecId=[[RecId]]',$(this));\" data-bound-name='RDEADId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDEADId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDEADId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDEADId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDEADId", "@RDEADId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDEADId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSEAD").GetFieldOperators("RDEADId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

