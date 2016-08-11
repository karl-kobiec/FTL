
	
public partial class Inv_InvDate : 
	DateDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Date";}
		set { } 
	}

	public string DFName=> "InvDate";

	
	public Inv_InvDate(Inv Parent) : 
		base(Parent, "InvDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvDate").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvDate").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 128;
	}
	public string GetControlName() {
		return "InvDateValue";
	}
	public string GetDFName() {
		return "InvDate";
	}
	public string GetTitle() {
		return "Invoice Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Inv/SaveInvDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='InvDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvDate", "@InvDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

