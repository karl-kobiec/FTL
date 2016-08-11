
	
public partial class REDSOrder_RDOrdDesc : 
	DataFieldBase<string,REDSOrder>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description";}
		set { } 
	}

	public string DFName=> "RDOrdDesc";

	
	public REDSOrder_RDOrdDesc(REDSOrder Parent) : 
		base(Parent, "RDOrdDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class REDSOrder_RDOrdDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdDesc").Any()) 
			return DS.GetManager<REDSOrder>().OnDataSource.Where(f=> f.Key == "RDOrdDesc").First().Value(new REDSOrder());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 551;
	}
	public string GetControlName() {
		return "RDOrdDescValue";
	}
	public string GetDFName() {
		return "RDOrdDesc";
	}
	public string GetTitle() {
		return "Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		REDSOrder ds;
					ds = (REDSOrder)dsI;
		 
		
		return ds.RDOrdDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		REDSOrder ds;
				ds = (REDSOrder)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/REDSOrder/SaveRDOrdDesc/?RecId=[[RecId]]',$(this));\" data-bound-name='RDOrdDesc' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.RDOrdDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "RDOrdDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "RDOrdDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "RDOrdDesc", "@RDOrdDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "RDOrdDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("REDSOrder").GetFieldOperators("RDOrdDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

