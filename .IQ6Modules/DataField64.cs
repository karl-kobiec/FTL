
	
public partial class Orders_OrdCollDate2 : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Date 2";}
		set { } 
	}

	public string DFName=> "OrdCollDate2";

	
	public Orders_OrdCollDate2(Orders Parent) : 
		base(Parent, "OrdCollDate2"
			,"ddd dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdCollDate2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollDate2").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollDate2").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 64;
	}
	public string GetControlName() {
		return "OrdCollDate2Value";
	}
	public string GetDFName() {
		return "OrdCollDate2";
	}
	public string GetTitle() {
		return "Collection Date 2";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollDate2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollDate2/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCollDate2' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollDate2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollDate2";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollDate2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollDate2", "@OrdCollDate2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollDate2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollDate2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

