
	
public partial class Inv_InvPrintBatch : 
	FormattableDataFieldBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Print Batch No";}
		set { } 
	}

	public string DFName=> "InvPrintBatch";

	
	public Inv_InvPrintBatch(Inv Parent) : 
		base(Parent, "InvPrintBatch"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvPrintBatchFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvPrintBatch").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvPrintBatch").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 157;
	}
	public string GetControlName() {
		return "InvPrintBatchValue";
	}
	public string GetDFName() {
		return "InvPrintBatch";
	}
	public string GetTitle() {
		return "Print Batch No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvPrintBatch.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvPrintBatch/?RecId=[[RecId]]',$(this));\" data-bound-name='InvPrintBatch' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvPrintBatch.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvPrintBatch";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvPrintBatch")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvPrintBatch", "@InvPrintBatch", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvPrintBatch", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvPrintBatch", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

