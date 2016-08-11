
	
public partial class PalletType_PallId : 
	FormattableDataFieldBase<int,PalletType>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Pallet Type ID";}
		set { } 
	}

	public string DFName=> "PallId";

	
	public PalletType_PallId(PalletType Parent) : 
		base(Parent, "PallId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class PalletType_PallIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PalletType>().OnDataSource.Where(f=> f.Key == "PallId").Any()) 
			return DS.GetManager<PalletType>().OnDataSource.Where(f=> f.Key == "PallId").First().Value(new PalletType());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 322;
	}
	public string GetControlName() {
		return "PallIdValue";
	}
	public string GetDFName() {
		return "PallId";
	}
	public string GetTitle() {
		return "Pallet Type ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PalletType ds;
					ds = (PalletType)dsI;
		 
		
		return ds.PallId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PalletType ds;
				ds = (PalletType)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PalletType/SavePallId/?RecId=[[RecId]]',$(this));\" data-bound-name='PallId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PallId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PallId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PallId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PallId", "@PallId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PallId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PalletType").GetFieldOperators("PallId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

