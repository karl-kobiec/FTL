
	
public partial class REDSOrder_RDOrdCustId : 
	FormattableDataFieldBase<int,REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client ID";}
		set { } 
	}

	public string DFName=> "RDOrdCustId";

	
	public REDSOrder_RDOrdCustId(REDSOrder Parent) : 
		base(Parent, "RDOrdCustId"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class REDSOrder_RDOrdCustIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdCustId").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdCustId").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 522;
	}
	public string GetControlName() {
		return "RDOrdCustIdValue";
	}
	public string GetDFName() {
		return "RDOrdCustId";
	}
	public string GetTitle() {
		return "Client ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdCustId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdCustId/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOrdCustId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdCustId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdCustId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOrdCustId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdCustId", "@RDOrdCustId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdCustId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdCustId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

