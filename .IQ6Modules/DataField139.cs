
	
public partial class UKOrder_UKOFTLCost : 
	FormattableDataFieldBase<double,UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Cost to FTL";}
		set { } 
	}

	public string DFName=> "UKOFTLCost";

	
	public UKOrder_UKOFTLCost(UKOrder Parent) : 
		base(Parent, "UKOFTLCost"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class UKOrder_UKOFTLCostFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOFTLCost").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOFTLCost").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 139;
	}
	public string GetControlName() {
		return "UKOFTLCostValue";
	}
	public string GetDFName() {
		return "UKOFTLCost";
	}
	public string GetTitle() {
		return "Cost to FTL";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOFTLCost.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOFTLCost/?RecId=[[RecId]]',$(this));\" data-bound-name='UKOFTLCost' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOFTLCost.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOFTLCost";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKOFTLCost")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOFTLCost", "@UKOFTLCost", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOFTLCost", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOFTLCost", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

