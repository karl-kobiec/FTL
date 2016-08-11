
	
public partial class Orders_OrdGBWKNo : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "GBWK Number";}
		set { } 
	}

	public string DFName=> "OrdGBWKNo";

	
	public Orders_OrdGBWKNo(Orders Parent) : 
		base(Parent, "OrdGBWKNo"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdGBWKNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdGBWKNo").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 345;
	}
	public string GetControlName() {
		return "OrdGBWKNoValue";
	}
	public string GetDFName() {
		return "OrdGBWKNo";
	}
	public string GetTitle() {
		return "GBWK Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdGBWKNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdGBWKNo/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdGBWKNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdGBWKNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdGBWKNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdGBWKNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdGBWKNo", "@OrdGBWKNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdGBWKNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdGBWKNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

