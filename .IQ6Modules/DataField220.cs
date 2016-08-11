
	
public partial class CN_CNToExport : 
	BoolDataFieldBase<CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Send to Dover";}
		set { } 
	}

	public string DFName=> "CNToExport";

	
	public CN_CNToExport(CN Parent) : 
		base(Parent, "CNToExport"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class CN_CNToExportFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNToExport").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNToExport").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 220;
	}
	public string GetControlName() {
		return "CNToExportValue";
	}
	public string GetDFName() {
		return "CNToExport";
	}
	public string GetTitle() {
		return "Send to Dover";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNToExport.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/CN/SaveCNToExport/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CNToExport' [[Val]] /><input type = 'hidden' data-bound-name='CNToExport' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNToExport.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNToExport";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CNToExport")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNToExport", "@CNToExport", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNToExport", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNToExport", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

