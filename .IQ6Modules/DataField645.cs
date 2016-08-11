
	
public partial class IStatRec_IStSuppUnitType : 
	DataFieldBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Supp Unit Type";}
		set { } 
	}

	public string DFName=> "IStSuppUnitType";

	
	public IStatRec_IStSuppUnitType(IStatRec Parent) : 
		base(Parent, "IStSuppUnitType"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class IStatRec_IStSuppUnitTypeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStSuppUnitType").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStSuppUnitType").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 645;
	}
	public string GetControlName() {
		return "IStSuppUnitTypeValue";
	}
	public string GetDFName() {
		return "IStSuppUnitType";
	}
	public string GetTitle() {
		return "Supp Unit Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStSuppUnitType.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSuppUnitType/?RecId=[[RecId]]',$(this));\" data-bound-name='IStSuppUnitType' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStSuppUnitType.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStSuppUnitType";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStSuppUnitType")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStSuppUnitType", "@IStSuppUnitType", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStSuppUnitType", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStSuppUnitType", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

