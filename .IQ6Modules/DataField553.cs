
	
public partial class REDSOrder_RDOrdDutyPaid : 
	BoolDataFieldBase<REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Duty Paid";}
		set { } 
	}

	public string DFName=> "RDOrdDutyPaid";

	
	public REDSOrder_RDOrdDutyPaid(REDSOrder Parent) : 
		base(Parent, "RDOrdDutyPaid"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class REDSOrder_RDOrdDutyPaidFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdDutyPaid").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdDutyPaid").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 553;
	}
	public string GetControlName() {
		return "RDOrdDutyPaidValue";
	}
	public string GetDFName() {
		return "RDOrdDutyPaid";
	}
	public string GetTitle() {
		return "Duty Paid";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdDutyPaid.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDutyPaid/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='RDOrdDutyPaid' [[Val]] /><input type = 'hidden' data-bound-name='RDOrdDutyPaid' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdDutyPaid.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdDutyPaid";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "RDOrdDutyPaid")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdDutyPaid", "@RDOrdDutyPaid", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdDutyPaid", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdDutyPaid", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

