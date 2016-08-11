
	
public partial class Orders_OrdCustName : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Name (Text)";}
		set { } 
	}

	public string DFName=> "OrdCustName";

	
	public Orders_OrdCustName(Orders Parent) : 
		base(Parent, "OrdCustName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdCustNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCustName").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCustName").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 698;
	}
	public string GetControlName() {
		return "OrdCustNameValue";
	}
	public string GetDFName() {
		return "OrdCustName";
	}
	public string GetTitle() {
		return "Client Name (Text)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCustName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCustName/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCustName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCustName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCustName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCustName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCustName", "@OrdCustName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCustName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCustName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

