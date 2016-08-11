
	
public partial class Months_MthSDate : 
	DateDataFieldBase<Months>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "From";}
		set { } 
	}

	public string DFName=> "MthSDate";

	
	public Months_MthSDate(Months Parent) : 
		base(Parent, "MthSDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Months_MthSDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthSDate").Any()) 
			return DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthSDate").First().Value(new Months());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 656;
	}
	public string GetControlName() {
		return "MthSDateValue";
	}
	public string GetDFName() {
		return "MthSDate";
	}
	public string GetTitle() {
		return "From";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Months ds;
					ds = (Months)dsI;
		 
		
		return ds.MthSDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Months ds;
				ds = (Months)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Months/SaveMthSDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='MthSDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.MthSDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "MthSDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "MthSDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "MthSDate", "@MthSDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "MthSDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Months").GetFieldOperators("MthSDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

