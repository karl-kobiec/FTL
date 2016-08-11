
	
public partial class CNLine_CNLTotal : 
	FormattableDataFieldBase<double,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Total";}
		set { } 
	}

	public string DFName=> "CNLTotal";

	
	public CNLine_CNLTotal(CNLine Parent) : 
		base(Parent, "CNLTotal"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLTotalFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLTotal").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLTotal").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 230;
	}
	public string GetControlName() {
		return "CNLTotalValue";
	}
	public string GetDFName() {
		return "CNLTotal";
	}
	public string GetTitle() {
		return "Line Total";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLTotal.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLTotal/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLTotal' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLTotal.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLTotal";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLTotal")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLTotal", "@CNLTotal", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLTotal", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLTotal", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

