
	
public partial class Inv_InvExchRate : 
	FormattableDataFieldBase<double,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Exchange Rate";}
		set { } 
	}

	public string DFName=> "InvExchRate";

	
	public Inv_InvExchRate(Inv Parent) : 
		base(Parent, "InvExchRate"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("1");
				    }
}


public partial class Inv_InvExchRateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvExchRate").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvExchRate").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 253;
	}
	public string GetControlName() {
		return "InvExchRateValue";
	}
	public string GetDFName() {
		return "InvExchRate";
	}
	public string GetTitle() {
		return "Exchange Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvExchRate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvExchRate/?RecId=[[RecId]]',$(this));\" data-bound-name='InvExchRate' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvExchRate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvExchRate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvExchRate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvExchRate", "@InvExchRate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvExchRate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvExchRate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

