
	
public partial class CNLine_CNLLineNo : 
	FormattableDataFieldBase<int,CNLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Line Number";}
		set { } 
	}

	public string DFName=> "CNLLineNo";

	
	public CNLine_CNLLineNo(CNLine Parent) : 
		base(Parent, "CNLLineNo"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class CNLine_CNLLineNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLLineNo").Any()) 
			return DS.GetManager<CNLine>().OnDataSource.Where(f=> f.Key == "CNLLineNo").First().Value(new CNLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 224;
	}
	public string GetControlName() {
		return "CNLLineNoValue";
	}
	public string GetDFName() {
		return "CNLLineNo";
	}
	public string GetTitle() {
		return "Line Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CNLine ds;
					ds = (CNLine)dsI;
		 
		
		return ds.CNLLineNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CNLine ds;
				ds = (CNLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CNLine/SaveCNLLineNo/?RecId=[[RecId]]',$(this));\" data-bound-name='CNLLineNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNLLineNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNLLineNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNLLineNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNLLineNo", "@CNLLineNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNLLineNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CNLine").GetFieldOperators("CNLLineNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

