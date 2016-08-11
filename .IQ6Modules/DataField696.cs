
	
public partial class Orders_OrdConsOrd : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Consign Order No";}
		set { } 
	}

	public string DFName=> "OrdConsOrd";

	
	public Orders_OrdConsOrd(Orders Parent) : 
		base(Parent, "OrdConsOrd"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdConsOrdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdConsOrd").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdConsOrd").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 696;
	}
	public string GetControlName() {
		return "OrdConsOrdValue";
	}
	public string GetDFName() {
		return "OrdConsOrd";
	}
	public string GetTitle() {
		return "Consign Order No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdConsOrd.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdConsOrd/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdConsOrd' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdConsOrd.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdConsOrd";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdConsOrd")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdConsOrd", "@OrdConsOrd", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdConsOrd", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdConsOrd", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

