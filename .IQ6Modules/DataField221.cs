
	
public partial class CN_CNExported : 
	BoolDataFieldBase<CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent to Dover";}
		set { } 
	}

	public string DFName=> "CNExported";

	
	public CN_CNExported(CN Parent) : 
		base(Parent, "CNExported"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class CN_CNExportedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNExported").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNExported").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 221;
	}
	public string GetControlName() {
		return "CNExportedValue";
	}
	public string GetDFName() {
		return "CNExported";
	}
	public string GetTitle() {
		return "Sent to Dover";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNExported.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/CN/SaveCNExported/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CNExported' [[Val]] /><input type = 'hidden' data-bound-name='CNExported' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNExported.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNExported";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CNExported")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNExported", "@CNExported", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNExported", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNExported", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

