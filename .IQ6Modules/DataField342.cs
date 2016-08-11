
	
public partial class EADNum_EADNo : 
	DataFieldBase<string,EADNum>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "eAD Number";}
		set { } 
	}

	public string DFName=> "EADNo";

	
	public EADNum_EADNo(EADNum Parent) : 
		base(Parent, "EADNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EADNum_EADNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EADNum>().OnDataSource.Where(f=> f.Key == "EADNo").Any()) 
			return DS.GetManager<EADNum>().OnDataSource.Where(f=> f.Key == "EADNo").First().Value(new EADNum());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 342;
	}
	public string GetControlName() {
		return "EADNoValue";
	}
	public string GetDFName() {
		return "EADNo";
	}
	public string GetTitle() {
		return "eAD Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EADNum ds;
					ds = (EADNum)dsI;
		 
		
		return ds.EADNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EADNum ds;
				ds = (EADNum)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EADNum/SaveEADNo/?RecId=[[RecId]]',$(this));\" data-bound-name='EADNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EADNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EADNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EADNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EADNo", "@EADNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EADNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EADNum").GetFieldOperators("EADNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

