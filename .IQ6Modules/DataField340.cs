
	
public partial class Orders_OrdARCRef : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "eAD ARC Ref";}
		set { } 
	}

	public string DFName=> "OrdARCRef";

	
	public Orders_OrdARCRef(Orders Parent) : 
		base(Parent, "OrdARCRef"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdARCRefFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdARCRef").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdARCRef").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 340;
	}
	public string GetControlName() {
		return "OrdARCRefValue";
	}
	public string GetDFName() {
		return "OrdARCRef";
	}
	public string GetTitle() {
		return "eAD ARC Ref";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdARCRef.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdARCRef/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdARCRef' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdARCRef.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdARCRef";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdARCRef")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdARCRef", "@OrdARCRef", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdARCRef", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdARCRef", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

