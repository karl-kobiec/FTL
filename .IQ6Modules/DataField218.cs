
	
public partial class CN_CNPrintBatch : 
	FormattableDataFieldBase<int,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Print Batch No";}
		set { } 
	}

	public string DFName=> "CNPrintBatch";

	
	public CN_CNPrintBatch(CN Parent) : 
		base(Parent, "CNPrintBatch"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class CN_CNPrintBatchFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNPrintBatch").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNPrintBatch").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 218;
	}
	public string GetControlName() {
		return "CNPrintBatchValue";
	}
	public string GetDFName() {
		return "CNPrintBatch";
	}
	public string GetTitle() {
		return "Print Batch No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNPrintBatch.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNPrintBatch/?RecId=[[RecId]]',$(this));\" data-bound-name='CNPrintBatch' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNPrintBatch.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNPrintBatch";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNPrintBatch")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNPrintBatch", "@CNPrintBatch", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNPrintBatch", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNPrintBatch", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

