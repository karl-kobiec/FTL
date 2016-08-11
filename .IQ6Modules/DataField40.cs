
	
public partial class Orders_OrdCustOrd : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Order No";}
		set { } 
	}

	public string DFName=> "OrdCustOrd";

	
	public Orders_OrdCustOrd(Orders Parent) : 
		base(Parent, "OrdCustOrd"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdCustOrdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCustOrd").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCustOrd").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 40;
	}
	public string GetControlName() {
		return "OrdCustOrdValue";
	}
	public string GetDFName() {
		return "OrdCustOrd";
	}
	public string GetTitle() {
		return "Client Order No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCustOrd.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCustOrd/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCustOrd' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCustOrd.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCustOrd";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCustOrd")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCustOrd", "@OrdCustOrd", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCustOrd", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCustOrd", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

