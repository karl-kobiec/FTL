
	
public partial class Alerts_AlrtCallbackUrl : 
	DataFieldBase<string,Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Callback URL";}
		set { } 
	}

	public string DFName=> "AlrtCallbackUrl";

	
	public Alerts_AlrtCallbackUrl(Alerts Parent) : 
		base(Parent, "AlrtCallbackUrl"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Alerts_AlrtCallbackUrlFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtCallbackUrl").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtCallbackUrl").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 783;
	}
	public string GetControlName() {
		return "AlrtCallbackUrlValue";
	}
	public string GetDFName() {
		return "AlrtCallbackUrl";
	}
	public string GetTitle() {
		return "Callback URL";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtCallbackUrl.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtCallbackUrl/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='AlrtCallbackUrl'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtCallbackUrl.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtCallbackUrl";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtCallbackUrl")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtCallbackUrl", "@AlrtCallbackUrl", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtCallbackUrl", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtCallbackUrl", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

