
	
public partial class DelZone_DelZId : 
	DataFieldBase<int,DelZone>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Id";}
		set { } 
	}

	public string DFName=> "DelZId";

	
	public DelZone_DelZId(DelZone Parent) : 
		base(Parent, "DelZId"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class DelZone_DelZIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<DelZone>().OnDataSource.Where(f=> f.Key == "DelZId").Any()) 
			return DS.GetManager<DelZone>().OnDataSource.Where(f=> f.Key == "DelZId").First().Value(new DelZone());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 818;
	}
	public string GetControlName() {
		return "DelZIdValue";
	}
	public string GetDFName() {
		return "DelZId";
	}
	public string GetTitle() {
		return "Id";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		DelZone ds;
					ds = (DelZone)dsI;
		 
		
		return ds.DelZId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		DelZone ds;
				ds = (DelZone)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/DelZone/SaveDelZId/?RecId=[[RecId]]',$(this));\" data-bound-name='DelZId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.DelZId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "DelZId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "DelZId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "DelZId", "@DelZId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "DelZId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("DelZone").GetFieldOperators("DelZId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

