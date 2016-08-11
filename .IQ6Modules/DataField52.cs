
	
public partial class Orders_OrdDelPointPC : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Delivery Postcode";}
		set { } 
	}

	public string DFName=> "OrdDelPointPC";

	
	public Orders_OrdDelPointPC(Orders Parent) : 
		base(Parent, "OrdDelPointPC"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdDelPointPCFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPointPC").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDelPointPC").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 52;
	}
	public string GetControlName() {
		return "OrdDelPointPCValue";
	}
	public string GetDFName() {
		return "OrdDelPointPC";
	}
	public string GetTitle() {
		return "Delivery Postcode";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDelPointPC.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDelPointPC/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdDelPointPC' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDelPointPC.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDelPointPC";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDelPointPC")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDelPointPC", "@OrdDelPointPC", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDelPointPC", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDelPointPC", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

