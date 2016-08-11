
	
public partial class Orders_OrdInvoiced : 
	BoolDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoiced";}
		set { } 
	}

	public string DFName=> "OrdInvoiced";

	
	public Orders_OrdInvoiced(Orders Parent) : 
		base(Parent, "OrdInvoiced"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("False");
				    }
}


public partial class Orders_OrdInvoicedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdInvoiced").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdInvoiced").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 176;
	}
	public string GetControlName() {
		return "OrdInvoicedValue";
	}
	public string GetDFName() {
		return "OrdInvoiced";
	}
	public string GetTitle() {
		return "Invoiced";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdInvoiced.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Orders/SaveOrdInvoiced/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='OrdInvoiced' [[Val]] /><input type = 'hidden' data-bound-name='OrdInvoiced' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdInvoiced.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdInvoiced";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "OrdInvoiced")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdInvoiced", "@OrdInvoiced", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdInvoiced", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdInvoiced", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

