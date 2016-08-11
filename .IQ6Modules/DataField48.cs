
	
public partial class Orders_OrdSuppRef : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Supplier Reference";}
		set { } 
	}

	public string DFName=> "OrdSuppRef";

	
	public Orders_OrdSuppRef(Orders Parent) : 
		base(Parent, "OrdSuppRef"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdSuppRefFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSuppRef").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdSuppRef").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 48;
	}
	public string GetControlName() {
		return "OrdSuppRefValue";
	}
	public string GetDFName() {
		return "OrdSuppRef";
	}
	public string GetTitle() {
		return "Supplier Reference";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdSuppRef.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdSuppRef/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdSuppRef' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdSuppRef.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdSuppRef";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdSuppRef")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdSuppRef", "@OrdSuppRef", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdSuppRef", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdSuppRef", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

