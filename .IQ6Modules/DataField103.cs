
	
public partial class Inv_InvFerryDate : 
	DateDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Ferry Date";}
		set { } 
	}

	public string DFName=> "InvFerryDate";

	
	public Inv_InvFerryDate(Inv Parent) : 
		base(Parent, "InvFerryDate"
			,"dd-MMM-yyyy"
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvFerryDateFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryDate").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvFerryDate").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 103;
	}
	public string GetControlName() {
		return "InvFerryDateValue";
	}
	public string GetDFName() {
		return "InvFerryDate";
	}
	public string GetTitle() {
		return "Ferry Date";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvFerryDate.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input style='height:21px;[[Width]]' data-date-format='DD-MMM-YYYY' onchange=\"javascript:IQAutoSave('/Inv/SaveInvFerryDate/?RecId=[[RecId]]',$(this));\"class='form-control dateBox' type='text' data-bound-name='InvFerryDate' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvFerryDate.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvFerryDate";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control dateBox' type='text'  value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvFerryDate")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvFerryDate", "@InvFerryDate", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvFerryDate", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvFerryDate", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

