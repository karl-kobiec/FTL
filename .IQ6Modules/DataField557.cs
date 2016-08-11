
	
public partial class REDSEAD_RDEADRDId : 
	FormattableDataFieldBase<int,REDSEAD>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "REDS ID";}
		set { } 
	}

	public string DFName=> "RDEADRDId";

	
	public REDSEAD_RDEADRDId(REDSEAD Parent) : 
		base(Parent, "RDEADRDId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class REDSEAD_RDEADRDIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSEAD>().OnDataSource.Where(f=> f.Key == "RDEADRDId").Any()) 
			return DS.GetManager<REDSEAD>().OnDataSource.Where(f=> f.Key == "RDEADRDId").First().Value(new REDSEAD());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 557;
	}
	public string GetControlName() {
		return "RDEADRDIdValue";
	}
	public string GetDFName() {
		return "RDEADRDId";
	}
	public string GetTitle() {
		return "REDS ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSEAD ds;
					ds = (REDSEAD)dsI;
		 
		
		return ds.RDEADRDId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSEAD ds;
				ds = (REDSEAD)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSEAD/SaveRDEADRDId/?RecId=[[RecId]]',$(this));\" data-bound-name='RDEADRDId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDEADRDId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDEADRDId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDEADRDId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDEADRDId", "@RDEADRDId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDEADRDId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSEAD").GetFieldOperators("RDEADRDId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

