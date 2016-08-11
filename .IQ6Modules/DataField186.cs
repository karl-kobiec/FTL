
	
public partial class CertShip_CSWeight : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Weight";}
		set { } 
	}

	public string DFName=> "CSWeight";

	
	public CertShip_CSWeight(CertShip Parent) : 
		base(Parent, "CSWeight"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSWeightFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSWeight").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSWeight").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 186;
	}
	public string GetControlName() {
		return "CSWeightValue";
	}
	public string GetDFName() {
		return "CSWeight";
	}
	public string GetTitle() {
		return "Weight";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSWeight.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSWeight/?RecId=[[RecId]]',$(this));\" data-bound-name='CSWeight' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSWeight.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSWeight";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSWeight")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSWeight", "@CSWeight", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSWeight", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSWeight", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

