
	
public partial class Orders_OrdPriceAllowed : 
	FormattableDataFieldBase<double,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Price Allowed";}
		set { } 
	}

	public string DFName=> "OrdPriceAllowed";

	
	public Orders_OrdPriceAllowed(Orders Parent) : 
		base(Parent, "OrdPriceAllowed"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Orders_OrdPriceAllowedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdPriceAllowed").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdPriceAllowed").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 245;
	}
	public string GetControlName() {
		return "OrdPriceAllowedValue";
	}
	public string GetDFName() {
		return "OrdPriceAllowed";
	}
	public string GetTitle() {
		return "Price Allowed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdPriceAllowed.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdPriceAllowed/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdPriceAllowed' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdPriceAllowed.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdPriceAllowed";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdPriceAllowed")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdPriceAllowed", "@OrdPriceAllowed", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdPriceAllowed", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdPriceAllowed", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

