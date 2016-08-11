
	
public partial class ExchRate_ExRRate : 
	FormattableDataFieldBase<double,ExchRate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Rate";}
		set { } 
	}

	public string DFName=> "ExRRate";

	
	public ExchRate_ExRRate(ExchRate Parent) : 
		base(Parent, "ExRRate"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class ExchRate_ExRRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRRate").Any()) 
			return DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRRate").First().Value(new ExchRate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 256;
	}
	public string GetControlName() {
		return "ExRRateValue";
	}
	public string GetDFName() {
		return "ExRRate";
	}
	public string GetTitle() {
		return "Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ExchRate ds;
					ds = (ExchRate)dsI;
		 
		
		return ds.ExRRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ExchRate ds;
				ds = (ExchRate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRRate/?RecId=[[RecId]]',$(this));\" data-bound-name='ExRRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ExRRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ExRRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ExRRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ExRRate", "@ExRRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ExRRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ExchRate").GetFieldOperators("ExRRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

