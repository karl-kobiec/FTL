
	
public partial class Orders_OrdEMTo : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "E-Mail To";}
		set { } 
	}

	public string DFName=> "OrdEMTo";

	
	public Orders_OrdEMTo(Orders Parent) : 
		base(Parent, "OrdEMTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Orders_OrdEMToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdEMTo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdEMTo").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 332;
	}
	public string GetControlName() {
		return "OrdEMToValue";
	}
	public string GetDFName() {
		return "OrdEMTo";
	}
	public string GetTitle() {
		return "E-Mail To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdEMTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdEMTo/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdEMTo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdEMTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdEMTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdEMTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdEMTo", "@OrdEMTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdEMTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdEMTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

