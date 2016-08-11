
	
public partial class Orders_OrdDelChanged : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivered Changed";}
		set { } 
	}

	public string DFName=> "OrdDelChanged";

	
	public Orders_OrdDelChanged(Orders Parent) : 
		base(Parent, "OrdDelChanged"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdDelChangedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelChanged").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelChanged").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 249;
	}
	public string GetControlName() {
		return "OrdDelChangedValue";
	}
	public string GetDFName() {
		return "OrdDelChanged";
	}
	public string GetTitle() {
		return "Delivered Changed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDelChanged.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelChanged/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdDelChanged' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDelChanged.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDelChanged";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDelChanged")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDelChanged", "@OrdDelChanged", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDelChanged", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDelChanged", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

