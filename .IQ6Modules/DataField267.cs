
	
public partial class Orders_OrdTescoRef : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Tesco Ref";}
		set { } 
	}

	public string DFName=> "OrdTescoRef";

	
	public Orders_OrdTescoRef(Orders Parent) : 
		base(Parent, "OrdTescoRef"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdTescoRefFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTescoRef").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdTescoRef").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 267;
	}
	public string GetControlName() {
		return "OrdTescoRefValue";
	}
	public string GetDFName() {
		return "OrdTescoRef";
	}
	public string GetTitle() {
		return "Tesco Ref";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdTescoRef.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdTescoRef/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdTescoRef' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdTescoRef.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdTescoRef";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdTescoRef")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdTescoRef", "@OrdTescoRef", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdTescoRef", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdTescoRef", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

