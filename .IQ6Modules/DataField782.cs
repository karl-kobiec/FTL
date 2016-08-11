
	
public partial class Alerts_AlrtCompletedDat : 
	DateDataFieldBase<Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "CompletedDate";}
		set { } 
	}

	public string DFName=> "AlrtCompletedDat";

	
	public Alerts_AlrtCompletedDat(Alerts Parent) : 
		base(Parent, "AlrtCompletedDat"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Alerts_AlrtCompletedDatFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtCompletedDat").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtCompletedDat").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 782;
	}
	public string GetControlName() {
		return "AlrtCompletedDatValue";
	}
	public string GetDFName() {
		return "AlrtCompletedDat";
	}
	public string GetTitle() {
		return "CompletedDate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtCompletedDat.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtCompletedDat/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='AlrtCompletedDat' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtCompletedDat.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtCompletedDat";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtCompletedDat")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtCompletedDat", "@AlrtCompletedDat", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtCompletedDat", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtCompletedDat", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

