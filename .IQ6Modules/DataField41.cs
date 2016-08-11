
	
public partial class Orders_OrdDate : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Date";}
		set { } 
	}

	public string DFName=> "OrdDate";

	
	public Orders_OrdDate(Orders Parent) : 
		base(Parent, "OrdDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
		        this.SetValue(DateTime.Now.ToString("dd MMM yy"));
				    }
}


public partial class Orders_OrdDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDate").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDate").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 41;
	}
	public string GetControlName() {
		return "OrdDateValue";
	}
	public string GetDFName() {
		return "OrdDate";
	}
	public string GetTitle() {
		return "Order Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='OrdDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDate", "@OrdDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

