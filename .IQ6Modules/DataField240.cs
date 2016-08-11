
	
public partial class UKOrder_UKOInvoiced : 
	BoolDataFieldBase<UKOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoiced";}
		set { } 
	}

	public string DFName=> "UKOInvoiced";

	
	public UKOrder_UKOInvoiced(UKOrder Parent) : 
		base(Parent, "UKOInvoiced"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class UKOrder_UKOInvoicedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOInvoiced").Any()) 
			return DS.GetManager<UKOrder>().OnDataSource.Where(f=> f.Key == "UKOInvoiced").First().Value(new UKOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 240;
	}
	public string GetControlName() {
		return "UKOInvoicedValue";
	}
	public string GetDFName() {
		return "UKOInvoiced";
	}
	public string GetTitle() {
		return "Invoiced";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		UKOrder ds;
					ds = (UKOrder)dsI;
		 
		
		return ds.UKOInvoiced.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		UKOrder ds;
				ds = (UKOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/UKOrder/SaveUKOInvoiced/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='UKOInvoiced' [[Val]] /><input type = 'hidden' data-bound-name='UKOInvoiced' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.UKOInvoiced.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "UKOInvoiced";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "UKOInvoiced")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "UKOInvoiced", "@UKOInvoiced", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "UKOInvoiced", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("UKOrder").GetFieldOperators("UKOInvoiced", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

