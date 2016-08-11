
	
public partial class Orders_OrdDutyInv : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Duty Inv";}
		set { } 
	}

	public string DFName=> "OrdDutyInv";

	
	public Orders_OrdDutyInv(Orders Parent) : 
		base(Parent, "OrdDutyInv"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdDutyInvFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDutyInv").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDutyInv").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 195;
	}
	public string GetControlName() {
		return "OrdDutyInvValue";
	}
	public string GetDFName() {
		return "OrdDutyInv";
	}
	public string GetTitle() {
		return "Duty Inv";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDutyInv.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDutyInv/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdDutyInv' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDutyInv.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDutyInv";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDutyInv")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDutyInv", "@OrdDutyInv", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDutyInv", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDutyInv", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

