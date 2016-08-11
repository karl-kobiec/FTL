
	
public partial class InvBatch_InvBPrintedOn : 
	DateDataFieldBase<InvBatch>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Printed On";}
		set { } 
	}

	public string DFName=> "InvBPrintedOn";

	
	public InvBatch_InvBPrintedOn(InvBatch Parent) : 
		base(Parent, "InvBPrintedOn"
			,"dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class InvBatch_InvBPrintedOnFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBPrintedOn").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBPrintedOn").First().Value(new InvBatch());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 294;
	}
	public string GetControlName() {
		return "InvBPrintedOnValue";
	}
	public string GetDFName() {
		return "InvBPrintedOn";
	}
	public string GetTitle() {
		return "Printed On";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvBatch ds;
					ds = (InvBatch)dsI;
		 
		
		return ds.InvBPrintedOn.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvBatch ds;
				ds = (InvBatch)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBPrintedOn/?RecId=[[RecId]]',$(this));\" data-bound-name='InvBPrintedOn' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBPrintedOn.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBPrintedOn";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvBPrintedOn")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBPrintedOn", "@InvBPrintedOn", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBPrintedOn", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvBatch").GetFieldOperators("InvBPrintedOn", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

