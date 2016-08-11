
	
public partial class Week_WkId : 
	FormattableDataFieldBase<int,Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Week ID";}
		set { } 
	}

	public string DFName=> "WkId";

	
	public Week_WkId(Week Parent) : 
		base(Parent, "WkId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Week_WkIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkId").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkId").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 279;
	}
	public string GetControlName() {
		return "WkIdValue";
	}
	public string GetDFName() {
		return "WkId";
	}
	public string GetTitle() {
		return "Week ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkId/?RecId=[[RecId]]',$(this));\" data-bound-name='WkId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkId", "@WkId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

