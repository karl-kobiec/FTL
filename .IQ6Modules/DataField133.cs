
	
public partial class UKOrder_UKOCollFrom : 
	DataFieldBase<string,UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection From";}
		set { } 
	}

	public string DFName=> "UKOCollFrom";

	
	public UKOrder_UKOCollFrom(UKOrder Parent) : 
		base(Parent, "UKOCollFrom"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class UKOrder_UKOCollFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCollFrom").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCollFrom").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 133;
	}
	public string GetControlName() {
		return "UKOCollFromValue";
	}
	public string GetDFName() {
		return "UKOCollFrom";
	}
	public string GetTitle() {
		return "Collection From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOCollFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCollFrom/?RecId=[[RecId]]',$(this));\" data-bound-name='UKOCollFrom' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOCollFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOCollFrom";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKOCollFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOCollFrom", "@UKOCollFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOCollFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOCollFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

