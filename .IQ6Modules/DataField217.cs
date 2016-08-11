
	
public partial class CN_CNDate : 
	DateDataFieldBase<CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Date";}
		set { } 
	}

	public string DFName=> "CNDate";

	
	public CN_CNDate(CN Parent) : 
		base(Parent, "CNDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDate").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDate").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 217;
	}
	public string GetControlName() {
		return "CNDateValue";
	}
	public string GetDFName() {
		return "CNDate";
	}
	public string GetTitle() {
		return "Credit Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/CN/SaveCNDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='CNDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNDate", "@CNDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

