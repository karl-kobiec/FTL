
	
public partial class CN_CNExchRate : 
	FormattableDataFieldBase<double,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Exchange Rate";}
		set { } 
	}

	public string DFName=> "CNExchRate";

	
	public CN_CNExchRate(CN Parent) : 
		base(Parent, "CNExchRate"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("1");
				    }
}


public partial class CN_CNExchRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNExchRate").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNExchRate").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 258;
	}
	public string GetControlName() {
		return "CNExchRateValue";
	}
	public string GetDFName() {
		return "CNExchRate";
	}
	public string GetTitle() {
		return "Exchange Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNExchRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNExchRate/?RecId=[[RecId]]',$(this));\" data-bound-name='CNExchRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNExchRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNExchRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNExchRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNExchRate", "@CNExchRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNExchRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNExchRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

