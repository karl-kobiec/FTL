
	
public partial class Alerts_AlrtQueueDate : 
	DateDataFieldBase<Alerts>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Alert Date";}
		set { } 
	}

	public string DFName=> "AlrtQueueDate";

	
	public Alerts_AlrtQueueDate(Alerts Parent) : 
		base(Parent, "AlrtQueueDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Alerts_AlrtQueueDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtQueueDate").Any()) 
			return DS.GetManager<Alerts>().OnDataSource.Where(f=> f.Key == "AlrtQueueDate").First().Value(new Alerts());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 781;
	}
	public string GetControlName() {
		return "AlrtQueueDateValue";
	}
	public string GetDFName() {
		return "AlrtQueueDate";
	}
	public string GetTitle() {
		return "Alert Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Alerts ds;
					ds = (Alerts)dsI;
		 
		
		return ds.AlrtQueueDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Alerts ds;
				ds = (Alerts)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Alerts/SaveAlrtQueueDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='AlrtQueueDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.AlrtQueueDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "AlrtQueueDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "AlrtQueueDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "AlrtQueueDate", "@AlrtQueueDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "AlrtQueueDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Alerts").GetFieldOperators("AlrtQueueDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

