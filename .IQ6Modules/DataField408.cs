
	
public partial class Orders_OrdCollectCtry : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Collect Country";}
		set { } 
	}

	public string DFName=> "OrdCollectCtry";

	
	public Orders_OrdCollectCtry(Orders Parent) : 
		base(Parent, "OrdCollectCtry"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdCollectCtryFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollectCtry").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdCollectCtry").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 408;
	}
	public string GetControlName() {
		return "OrdCollectCtryValue";
	}
	public string GetDFName() {
		return "OrdCollectCtry";
	}
	public string GetTitle() {
		return "Collect Country";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdCollectCtry.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdCollectCtry/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdCollectCtry' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdCollectCtry.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdCollectCtry";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdCollectCtry")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdCollectCtry", "@OrdCollectCtry", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdCollectCtry", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdCollectCtry", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

