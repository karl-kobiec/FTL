
	
public partial class EMail_EMBody : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Body";}
		set { } 
	}

	public string DFName=> "EMBody";

	
	public EMail_EMBody(EMail Parent) : 
		base(Parent, "EMBody"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMBodyFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBody").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMBody").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 692;
	}
	public string GetControlName() {
		return "EMBodyValue";
	}
	public string GetDFName() {
		return "EMBody";
	}
	public string GetTitle() {
		return "Body";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMBody.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "[[Val]]";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMBody.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMBody";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMBody")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMBody", "@EMBody", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMBody", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMBody", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

