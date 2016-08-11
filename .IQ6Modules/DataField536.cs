
	
public partial class REDSOrder_RDOrdCust : 
	DataFieldBase<string,REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Name";}
		set { } 
	}

	public string DFName=> "RDOrdCust";

	
	public REDSOrder_RDOrdCust(REDSOrder Parent) : 
		base(Parent, "RDOrdCust"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class REDSOrder_RDOrdCustFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdCust").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdCust").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 536;
	}
	public string GetControlName() {
		return "RDOrdCustValue";
	}
	public string GetDFName() {
		return "RDOrdCust";
	}
	public string GetTitle() {
		return "Client Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdCust.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdCust/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOrdCust' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdCust.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdCust";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOrdCust")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdCust", "@RDOrdCust", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdCust", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdCust", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

