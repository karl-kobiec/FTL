
	
public partial class Orders_OrdBondCode : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "REDS/Bond Code";}
		set { } 
	}

	public string DFName=> "OrdBondCode";

	
	public Orders_OrdBondCode(Orders Parent) : 
		base(Parent, "OrdBondCode"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdBondCodeFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondCode").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdBondCode").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 58;
	}
	public string GetControlName() {
		return "OrdBondCodeValue";
	}
	public string GetDFName() {
		return "OrdBondCode";
	}
	public string GetTitle() {
		return "REDS/Bond Code";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdBondCode.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdBondCode/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdBondCode' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdBondCode.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdBondCode";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdBondCode")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdBondCode", "@OrdBondCode", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdBondCode", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdBondCode", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

