
	
public partial class REDSOrder_RDOrdARCNo : 
	DataFieldBase<string,REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "ARC Number";}
		set { } 
	}

	public string DFName=> "RDOrdARCNo";

	
	public REDSOrder_RDOrdARCNo(REDSOrder Parent) : 
		base(Parent, "RDOrdARCNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class REDSOrder_RDOrdARCNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdARCNo").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdARCNo").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 554;
	}
	public string GetControlName() {
		return "RDOrdARCNoValue";
	}
	public string GetDFName() {
		return "RDOrdARCNo";
	}
	public string GetTitle() {
		return "ARC Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdARCNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdARCNo/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOrdARCNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdARCNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdARCNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOrdARCNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdARCNo", "@RDOrdARCNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdARCNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdARCNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

