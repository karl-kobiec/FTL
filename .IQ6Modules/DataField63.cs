
	
public partial class Orders_OrdCollDate : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Date";}
		set { } 
	}

	public string DFName=> "OrdCollDate";

	
	public Orders_OrdCollDate(Orders Parent) : 
		base(Parent, "OrdCollDate"
			,"ddd dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdCollDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollDate").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollDate").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 63;
	}
	public string GetControlName() {
		return "OrdCollDateValue";
	}
	public string GetDFName() {
		return "OrdCollDate";
	}
	public string GetTitle() {
		return "Collection Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollDate/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCollDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollDate", "@OrdCollDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

