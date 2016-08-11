
	
public partial class EMail_EMFrom : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "From";}
		set { } 
	}

	public string DFName=> "EMFrom";

	
	public EMail_EMFrom(EMail Parent) : 
		base(Parent, "EMFrom"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class EMail_EMFromFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMFrom").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMFrom").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 686;
	}
	public string GetControlName() {
		return "EMFromValue";
	}
	public string GetDFName() {
		return "EMFrom";
	}
	public string GetTitle() {
		return "From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMFrom.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EMail/SaveEMFrom/?RecId=[[RecId]]',$(this));\" data-bound-name='EMFrom' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMFrom.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMFrom";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMFrom")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMFrom", "@EMFrom", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMFrom", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMFrom", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

