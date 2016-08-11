
	
public partial class Orders_OrdVATNo : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Number";}
		set { } 
	}

	public string DFName=> "OrdVATNo";

	
	public Orders_OrdVATNo(Orders Parent) : 
		base(Parent, "OrdVATNo"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdVATNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATNo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdVATNo").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 54;
	}
	public string GetControlName() {
		return "OrdVATNoValue";
	}
	public string GetDFName() {
		return "OrdVATNo";
	}
	public string GetTitle() {
		return "VAT Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdVATNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdVATNo/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdVATNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdVATNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdVATNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdVATNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdVATNo", "@OrdVATNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdVATNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdVATNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

