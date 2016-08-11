
	
public partial class Orders_OrdSupPC : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Supplier Postcode";}
		set { } 
	}

	public string DFName=> "OrdSupPC";

	
	public Orders_OrdSupPC(Orders Parent) : 
		base(Parent, "OrdSupPC"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdSupPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSupPC").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSupPC").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 45;
	}
	public string GetControlName() {
		return "OrdSupPCValue";
	}
	public string GetDFName() {
		return "OrdSupPC";
	}
	public string GetTitle() {
		return "Supplier Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdSupPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSupPC/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdSupPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdSupPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdSupPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdSupPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdSupPC", "@OrdSupPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdSupPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdSupPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

