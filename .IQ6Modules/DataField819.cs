
	
public partial class DelZone_DelZName : 
	DataFieldBase<string,DelZone>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Name";}
		set { } 
	}

	public string DFName=> "DelZName";

	
	public DelZone_DelZName(DelZone Parent) : 
		base(Parent, "DelZName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class DelZone_DelZNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DelZone>().OnDataSource.Where(f=> f.Key == "DelZName").Any()) 
			return DS.GetManager<DelZone>().OnDataSource.Where(f=> f.Key == "DelZName").First().Value(new DelZone());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 819;
	}
	public string GetControlName() {
		return "DelZNameValue";
	}
	public string GetDFName() {
		return "DelZName";
	}
	public string GetTitle() {
		return "Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DelZone ds;
					ds = (DelZone)dsI;
		 
		
		return ds.DelZName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DelZone ds;
				ds = (DelZone)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DelZone/SaveDelZName/?RecId=[[RecId]]',$(this));\" data-bound-name='DelZName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DelZName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DelZName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DelZName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DelZName", "@DelZName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DelZName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DelZone").GetFieldOperators("DelZName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

