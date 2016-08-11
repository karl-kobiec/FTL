
	
public partial class UKOrder_UKOCollDate : 
	DateDataFieldBase<UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Date";}
		set { } 
	}

	public string DFName=> "UKOCollDate";

	
	public UKOrder_UKOCollDate(UKOrder Parent) : 
		base(Parent, "UKOCollDate"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class UKOrder_UKOCollDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCollDate").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOCollDate").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 130;
	}
	public string GetControlName() {
		return "UKOCollDateValue";
	}
	public string GetDFName() {
		return "UKOCollDate";
	}
	public string GetTitle() {
		return "Collection Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOCollDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOCollDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='UKOCollDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOCollDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOCollDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "UKOCollDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOCollDate", "@UKOCollDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOCollDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOCollDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

