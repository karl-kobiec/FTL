
	
public partial class Orders_OrdFaxTo : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Fax To";}
		set { } 
	}

	public string DFName=> "OrdFaxTo";

	
	public Orders_OrdFaxTo(Orders Parent) : 
		base(Parent, "OrdFaxTo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Orders_OrdFaxToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdFaxTo").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdFaxTo").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 333;
	}
	public string GetControlName() {
		return "OrdFaxToValue";
	}
	public string GetDFName() {
		return "OrdFaxTo";
	}
	public string GetTitle() {
		return "Fax To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdFaxTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdFaxTo/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdFaxTo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdFaxTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdFaxTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdFaxTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdFaxTo", "@OrdFaxTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdFaxTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdFaxTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

