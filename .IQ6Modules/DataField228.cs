
	
public partial class CNLine_CNLAmt : 
	FormattableDataFieldBase<double,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Amount";}
		set { } 
	}

	public string DFName=> "CNLAmt";

	
	public CNLine_CNLAmt(CNLine Parent) : 
		base(Parent, "CNLAmt"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLAmtFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLAmt").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLAmt").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 228;
	}
	public string GetControlName() {
		return "CNLAmtValue";
	}
	public string GetDFName() {
		return "CNLAmt";
	}
	public string GetTitle() {
		return "Line Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLAmt.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLAmt/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLAmt' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLAmt.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLAmt";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLAmt")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLAmt", "@CNLAmt", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLAmt", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLAmt", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

