
	
public partial class Alerts_AlrtData : 
	DataFieldBase<string,Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Data";}
		set { } 
	}

	public string DFName=> "AlrtData";

	
	public Alerts_AlrtData(Alerts Parent) : 
		base(Parent, "AlrtData"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Alerts_AlrtDataFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtData").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtData").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 779;
	}
	public string GetControlName() {
		return "AlrtDataValue";
	}
	public string GetDFName() {
		return "AlrtData";
	}
	public string GetTitle() {
		return "Data";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtData.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtData/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='AlrtData'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtData.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtData";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtData")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtData", "@AlrtData", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtData", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtData", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

