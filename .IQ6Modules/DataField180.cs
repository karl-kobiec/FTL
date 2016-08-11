
	
public partial class CertShip_CSJobLetter : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Letter";}
		set { } 
	}

	public string DFName=> "CSJobLetter";

	
	public CertShip_CSJobLetter(CertShip Parent) : 
		base(Parent, "CSJobLetter"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSJobLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobLetter").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSJobLetter").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 180;
	}
	public string GetControlName() {
		return "CSJobLetterValue";
	}
	public string GetDFName() {
		return "CSJobLetter";
	}
	public string GetTitle() {
		return "Job Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSJobLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSJobLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='CSJobLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSJobLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSJobLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSJobLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSJobLetter", "@CSJobLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSJobLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSJobLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

