
	
public partial class Months_MthEDate : 
	DateDataFieldBase<Months>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "To";}
		set { } 
	}

	public string DFName=> "MthEDate";

	
	public Months_MthEDate(Months Parent) : 
		base(Parent, "MthEDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Months_MthEDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthEDate").Any()) 
			return DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthEDate").First().Value(new Months());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 657;
	}
	public string GetControlName() {
		return "MthEDateValue";
	}
	public string GetDFName() {
		return "MthEDate";
	}
	public string GetTitle() {
		return "To";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Months ds;
					ds = (Months)dsI;
		 
		
		return ds.MthEDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Months ds;
				ds = (Months)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Months/SaveMthEDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='MthEDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.MthEDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "MthEDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "MthEDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "MthEDate", "@MthEDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "MthEDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Months").GetFieldOperators("MthEDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

