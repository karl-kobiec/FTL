
	
public partial class CNLine_CNLNo : 
	FormattableDataFieldBase<int,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Number";}
		set { } 
	}

	public string DFName=> "CNLNo";

	
	public CNLine_CNLNo(CNLine Parent) : 
		base(Parent, "CNLNo"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLNo").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLNo").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 223;
	}
	public string GetControlName() {
		return "CNLNoValue";
	}
	public string GetDFName() {
		return "CNLNo";
	}
	public string GetTitle() {
		return "Credit Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLNo/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLNo", "@CNLNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

