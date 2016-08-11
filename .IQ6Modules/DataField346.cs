
	
public partial class Orders_OrdTescoPSWk : 
	FormattableDataFieldBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tesco PS Wk";}
		set { } 
	}

	public string DFName=> "OrdTescoPSWk";

	
	public Orders_OrdTescoPSWk(Orders Parent) : 
		base(Parent, "OrdTescoPSWk"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Orders_OrdTescoPSWkFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTescoPSWk").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTescoPSWk").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 346;
	}
	public string GetControlName() {
		return "OrdTescoPSWkValue";
	}
	public string GetDFName() {
		return "OrdTescoPSWk";
	}
	public string GetTitle() {
		return "Tesco PS Wk";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdTescoPSWk.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdTescoPSWk/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdTescoPSWk' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdTescoPSWk.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdTescoPSWk";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdTescoPSWk")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdTescoPSWk", "@OrdTescoPSWk", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdTescoPSWk", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdTescoPSWk", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

