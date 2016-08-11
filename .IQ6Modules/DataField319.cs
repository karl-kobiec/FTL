
	
public partial class PackageType_PackName : 
	DataFieldBase<string,PackageType>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Package Type";}
		set { } 
	}

	public string DFName=> "PackName";

	
	public PackageType_PackName(PackageType Parent) : 
		base(Parent, "PackName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class PackageType_PackNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PackageType>().OnDataSource.Where(f=> f.Key == "PackName").Any()) 
			return DS.GetManager<PackageType>().OnDataSource.Where(f=> f.Key == "PackName").First().Value(new PackageType());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 319;
	}
	public string GetControlName() {
		return "PackNameValue";
	}
	public string GetDFName() {
		return "PackName";
	}
	public string GetTitle() {
		return "Package Type";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PackageType ds;
					ds = (PackageType)dsI;
		 
		
		return ds.PackName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PackageType ds;
				ds = (PackageType)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PackageType/SavePackName/?RecId=[[RecId]]',$(this));\" data-bound-name='PackName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PackName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PackName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PackName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PackName", "@PackName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PackName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PackageType").GetFieldOperators("PackName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

