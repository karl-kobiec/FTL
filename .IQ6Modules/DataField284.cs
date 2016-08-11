
	
public partial class Week_WkBelongsTo : 
	FormattableDataFieldBase<int,Week>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Belongs to Period";}
		set { } 
	}

	public string DFName=> "WkBelongsTo";

	
	public Week_WkBelongsTo(Week Parent) : 
		base(Parent, "WkBelongsTo"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Week_WkBelongsToFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkBelongsTo").Any()) 
			return DS.GetManager<Week>().OnDataSource.Where(f=> f.Key == "WkBelongsTo").First().Value(new Week());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 284;
	}
	public string GetControlName() {
		return "WkBelongsToValue";
	}
	public string GetDFName() {
		return "WkBelongsTo";
	}
	public string GetTitle() {
		return "Belongs to Period";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Week ds;
					ds = (Week)dsI;
		 
		
		return ds.WkBelongsTo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Week ds;
				ds = (Week)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Week/SaveWkBelongsTo/?RecId=[[RecId]]',$(this));\" data-bound-name='WkBelongsTo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.WkBelongsTo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "WkBelongsTo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "WkBelongsTo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "WkBelongsTo", "@WkBelongsTo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "WkBelongsTo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Week").GetFieldOperators("WkBelongsTo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

