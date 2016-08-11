
	
public partial class Orders_OrdConsignPC : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Consign Postcode";}
		set { } 
	}

	public string DFName=> "OrdConsignPC";

	
	public Orders_OrdConsignPC(Orders Parent) : 
		base(Parent, "OrdConsignPC"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdConsignPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdConsignPC").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdConsignPC").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 50;
	}
	public string GetControlName() {
		return "OrdConsignPCValue";
	}
	public string GetDFName() {
		return "OrdConsignPC";
	}
	public string GetTitle() {
		return "Consign Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdConsignPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdConsignPC/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdConsignPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdConsignPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdConsignPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdConsignPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdConsignPC", "@OrdConsignPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdConsignPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdConsignPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

