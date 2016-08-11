
	
public partial class InvBatch_InvBExportedDate : 
	DateDataFieldBase<InvBatch>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent to Dover On";}
		set { } 
	}

	public string DFName=> "InvBExportedDate";

	
	public InvBatch_InvBExportedDate(InvBatch Parent) : 
		base(Parent, "InvBExportedDate"
			,"dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class InvBatch_InvBExportedDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBExportedDate").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBExportedDate").First().Value(new InvBatch());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 295;
	}
	public string GetControlName() {
		return "InvBExportedDateValue";
	}
	public string GetDFName() {
		return "InvBExportedDate";
	}
	public string GetTitle() {
		return "Sent to Dover On";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvBatch ds;
					ds = (InvBatch)dsI;
		 
		
		return ds.InvBExportedDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvBatch ds;
				ds = (InvBatch)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBExportedDate/?RecId=[[RecId]]',$(this));\" data-bound-name='InvBExportedDate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBExportedDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBExportedDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvBExportedDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBExportedDate", "@InvBExportedDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBExportedDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvBatch").GetFieldOperators("InvBExportedDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

