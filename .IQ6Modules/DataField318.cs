
	
public partial class PackageType_PackId : 
	FormattableDataFieldBase<int,PackageType>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Package Type ID";}
		set { } 
	}

	public string DFName=> "PackId";

	
	public PackageType_PackId(PackageType Parent) : 
		base(Parent, "PackId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class PackageType_PackIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PackageType>().OnDataSource.Where(f=> f.Key == "PackId").Any()) 
			return DS.GetManager<PackageType>().OnDataSource.Where(f=> f.Key == "PackId").First().Value(new PackageType());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 318;
	}
	public string GetControlName() {
		return "PackIdValue";
	}
	public string GetDFName() {
		return "PackId";
	}
	public string GetTitle() {
		return "Package Type ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PackageType ds;
					ds = (PackageType)dsI;
		 
		
		return ds.PackId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PackageType ds;
				ds = (PackageType)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PackageType/SavePackId/?RecId=[[RecId]]',$(this));\" data-bound-name='PackId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PackId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PackId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PackId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PackId", "@PackId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PackId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PackageType").GetFieldOperators("PackId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

