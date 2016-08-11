
	
public partial class Orders_OrdCollPointPC : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collection Postcode";}
		set { } 
	}

	public string DFName=> "OrdCollPointPC";

	
	public Orders_OrdCollPointPC(Orders Parent) : 
		base(Parent, "OrdCollPointPC"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdCollPointPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPointPC").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollPointPC").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 47;
	}
	public string GetControlName() {
		return "OrdCollPointPCValue";
	}
	public string GetDFName() {
		return "OrdCollPointPC";
	}
	public string GetTitle() {
		return "Collection Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollPointPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollPointPC/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCollPointPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollPointPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollPointPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollPointPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollPointPC", "@OrdCollPointPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollPointPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollPointPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

