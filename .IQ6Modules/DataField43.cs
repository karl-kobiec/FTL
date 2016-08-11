
	
public partial class Orders_OrdReqDate : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Required Date";}
		set { } 
	}

	public string DFName=> "OrdReqDate";

	
	public Orders_OrdReqDate(Orders Parent) : 
		base(Parent, "OrdReqDate"
			,"ddd dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdReqDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdReqDate").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdReqDate").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 43;
	}
	public string GetControlName() {
		return "OrdReqDateValue";
	}
	public string GetDFName() {
		return "OrdReqDate";
	}
	public string GetTitle() {
		return "Required Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdReqDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='ddd DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdReqDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='OrdReqDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdReqDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdReqDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdReqDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdReqDate", "@OrdReqDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdReqDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdReqDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

