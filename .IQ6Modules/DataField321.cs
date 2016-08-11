
	
public partial class BottleSize_BSzSize : 
	DataFieldBase<string,BottleSize>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Bottle Size";}
		set { } 
	}

	public string DFName=> "BSzSize";

	
	public BottleSize_BSzSize(BottleSize Parent) : 
		base(Parent, "BSzSize"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class BottleSize_BSzSizeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzSize").Any()) 
			return DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzSize").First().Value(new BottleSize());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 321;
	}
	public string GetControlName() {
		return "BSzSizeValue";
	}
	public string GetDFName() {
		return "BSzSize";
	}
	public string GetTitle() {
		return "Bottle Size";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		BottleSize ds;
					ds = (BottleSize)dsI;
		 
		
		return ds.BSzSize.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		BottleSize ds;
				ds = (BottleSize)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzSize/?RecId=[[RecId]]',$(this));\" data-bound-name='BSzSize' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.BSzSize.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "BSzSize";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "BSzSize")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "BSzSize", "@BSzSize", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "BSzSize", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("BottleSize").GetFieldOperators("BSzSize", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

