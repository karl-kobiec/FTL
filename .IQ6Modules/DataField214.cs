
	
public partial class CN_CNTotal : 
	FormattableDataFieldBase<double,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Total";}
		set { } 
	}

	public string DFName=> "CNTotal";

	
	public CN_CNTotal(CN Parent) : 
		base(Parent, "CNTotal"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CN_CNTotalFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTotal").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNTotal").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 214;
	}
	public string GetControlName() {
		return "CNTotalValue";
	}
	public string GetDFName() {
		return "CNTotal";
	}
	public string GetTitle() {
		return "Credit Total";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNTotal.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNTotal/?RecId=[[RecId]]',$(this));\" data-bound-name='CNTotal' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNTotal.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNTotal";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNTotal")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNTotal", "@CNTotal", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNTotal", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNTotal", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

