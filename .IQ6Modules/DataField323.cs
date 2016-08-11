
	
public partial class PalletType_PallName : 
	DataFieldBase<string,PalletType>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Pallet Type";}
		set { } 
	}

	public string DFName=> "PallName";

	
	public PalletType_PallName(PalletType Parent) : 
		base(Parent, "PallName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class PalletType_PallNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PalletType>().OnDataSource.Where(f=> f.Key == "PallName").Any()) 
			return DS.GetManager<PalletType>().OnDataSource.Where(f=> f.Key == "PallName").First().Value(new PalletType());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 323;
	}
	public string GetControlName() {
		return "PallNameValue";
	}
	public string GetDFName() {
		return "PallName";
	}
	public string GetTitle() {
		return "Pallet Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PalletType ds;
					ds = (PalletType)dsI;
		 
		
		return ds.PallName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PalletType ds;
				ds = (PalletType)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PalletType/SavePallName/?RecId=[[RecId]]',$(this));\" data-bound-name='PallName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PallName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PallName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PallName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PallName", "@PallName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PallName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PalletType").GetFieldOperators("PallName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

