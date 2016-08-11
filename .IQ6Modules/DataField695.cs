
	
public partial class EMail_EMDateSent : 
	DateDataFieldBase<EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date Sent";}
		set { } 
	}

	public string DFName=> "EMDateSent";

	
	public EMail_EMDateSent(EMail Parent) : 
		base(Parent, "EMDateSent"
			,"dd-MMM-yyyy HH:mm"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class EMail_EMDateSentFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDateSent").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMDateSent").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 695;
	}
	public string GetControlName() {
		return "EMDateSentValue";
	}
	public string GetDFName() {
		return "EMDateSent";
	}
	public string GetTitle() {
		return "Date Sent";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMDateSent.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY HH:mm' onchange=\"javascript:IQAutoSave('/EMail/SaveEMDateSent/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='EMDateSent' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMDateSent.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMDateSent";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMDateSent")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMDateSent", "@EMDateSent", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMDateSent", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMDateSent", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

