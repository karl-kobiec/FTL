
	
public partial class REDSOrder_RDOrdInvCreated : 
	BoolDataFieldBase<REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Created";}
		set { } 
	}

	public string DFName=> "RDOrdInvCreated";

	
	public REDSOrder_RDOrdInvCreated(REDSOrder Parent) : 
		base(Parent, "RDOrdInvCreated"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class REDSOrder_RDOrdInvCreatedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdInvCreated").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdInvCreated").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 545;
	}
	public string GetControlName() {
		return "RDOrdInvCreatedValue";
	}
	public string GetDFName() {
		return "RDOrdInvCreated";
	}
	public string GetTitle() {
		return "Invoice Created";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdInvCreated.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdInvCreated/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='RDOrdInvCreated' [[Val]] /><input type = 'hidden' data-bound-name='RDOrdInvCreated' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdInvCreated.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdInvCreated";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "RDOrdInvCreated")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdInvCreated", "@RDOrdInvCreated", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdInvCreated", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdInvCreated", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

