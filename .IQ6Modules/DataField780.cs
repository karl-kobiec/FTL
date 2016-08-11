
	
public partial class Alerts_AlrtTitle : 
	DataFieldBase<string,Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Title";}
		set { } 
	}

	public string DFName=> "AlrtTitle";

	
	public Alerts_AlrtTitle(Alerts Parent) : 
		base(Parent, "AlrtTitle"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Alerts_AlrtTitleFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtTitle").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtTitle").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 780;
	}
	public string GetControlName() {
		return "AlrtTitleValue";
	}
	public string GetDFName() {
		return "AlrtTitle";
	}
	public string GetTitle() {
		return "Title";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtTitle.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtTitle/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='AlrtTitle'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtTitle.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtTitle";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtTitle")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtTitle", "@AlrtTitle", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtTitle", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtTitle", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

