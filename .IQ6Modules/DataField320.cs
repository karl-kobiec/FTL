
	
public partial class BottleSize_BSzId : 
	FormattableDataFieldBase<int,BottleSize>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Size ID";}
		set { } 
	}

	public string DFName=> "BSzId";

	
	public BottleSize_BSzId(BottleSize Parent) : 
		base(Parent, "BSzId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class BottleSize_BSzIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzId").Any()) 
			return DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzId").First().Value(new BottleSize());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 320;
	}
	public string GetControlName() {
		return "BSzIdValue";
	}
	public string GetDFName() {
		return "BSzId";
	}
	public string GetTitle() {
		return "Size ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		BottleSize ds;
					ds = (BottleSize)dsI;
		 
		
		return ds.BSzId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		BottleSize ds;
				ds = (BottleSize)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzId/?RecId=[[RecId]]',$(this));\" data-bound-name='BSzId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.BSzId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "BSzId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "BSzId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "BSzId", "@BSzId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "BSzId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("BottleSize").GetFieldOperators("BSzId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

