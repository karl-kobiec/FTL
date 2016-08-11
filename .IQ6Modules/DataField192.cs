
	
public partial class Orders_OrdTimeAvail : 
	TimeDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Time Available";}
		set { } 
	}

	public string DFName=> "OrdTimeAvail";

	
	public Orders_OrdTimeAvail(Orders Parent) : 
		base(Parent, "OrdTimeAvail"
			,"HH:mm"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdTimeAvailFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTimeAvail").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTimeAvail").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 192;
	}
	public string GetControlName() {
		return "OrdTimeAvailValue";
	}
	public string GetDFName() {
		return "OrdTimeAvail";
	}
	public string GetTitle() {
		return "Time Available";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdTimeAvail.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdTimeAvail/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdTimeAvail' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdTimeAvail.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdTimeAvail";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdTimeAvail")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdTimeAvail", "@OrdTimeAvail", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdTimeAvail", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdTimeAvail", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

