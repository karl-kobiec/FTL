
	
public partial class Months_MthName : 
	DataFieldBase<string,Months>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Month Name";}
		set { } 
	}

	public string DFName=> "MthName";

	
	public Months_MthName(Months Parent) : 
		base(Parent, "MthName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Months_MthNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthName").Any()) 
			return DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthName").First().Value(new Months());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 655;
	}
	public string GetControlName() {
		return "MthNameValue";
	}
	public string GetDFName() {
		return "MthName";
	}
	public string GetTitle() {
		return "Month Name";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Months ds;
					ds = (Months)dsI;
		 
		
		return ds.MthName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Months ds;
				ds = (Months)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Months/SaveMthName/?RecId=[[RecId]]',$(this));\" data-bound-name='MthName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.MthName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "MthName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "MthName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "MthName", "@MthName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "MthName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Months").GetFieldOperators("MthName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

