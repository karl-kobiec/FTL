
	
public partial class UKOrder_UKODelTo : 
	DataFieldBase<string,UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery To";}
		set { } 
	}

	public string DFName=> "UKODelTo";

	
	public UKOrder_UKODelTo(UKOrder Parent) : 
		base(Parent, "UKODelTo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class UKOrder_UKODelToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKODelTo").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKODelTo").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 134;
	}
	public string GetControlName() {
		return "UKODelToValue";
	}
	public string GetDFName() {
		return "UKODelTo";
	}
	public string GetTitle() {
		return "Delivery To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKODelTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKODelTo/?RecId=[[RecId]]',$(this));\" data-bound-name='UKODelTo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKODelTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKODelTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKODelTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKODelTo", "@UKODelTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKODelTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKODelTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

