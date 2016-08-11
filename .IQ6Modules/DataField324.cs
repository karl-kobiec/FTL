
	
public partial class BottleSize_BSzOrder : 
	FormattableDataFieldBase<int,BottleSize>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sort Order";}
		set { } 
	}

	public string DFName=> "BSzOrder";

	
	public BottleSize_BSzOrder(BottleSize Parent) : 
		base(Parent, "BSzOrder"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class BottleSize_BSzOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzOrder").Any()) 
			return DS.GetManager<BottleSize>().OnDataSource.Where(f=> f.Key == "BSzOrder").First().Value(new BottleSize());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 324;
	}
	public string GetControlName() {
		return "BSzOrderValue";
	}
	public string GetDFName() {
		return "BSzOrder";
	}
	public string GetTitle() {
		return "Sort Order";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		BottleSize ds;
					ds = (BottleSize)dsI;
		 
		
		return ds.BSzOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		BottleSize ds;
				ds = (BottleSize)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/BottleSize/SaveBSzOrder/?RecId=[[RecId]]',$(this));\" data-bound-name='BSzOrder' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.BSzOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "BSzOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "BSzOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "BSzOrder", "@BSzOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "BSzOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("BottleSize").GetFieldOperators("BSzOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

