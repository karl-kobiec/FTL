
	
public partial class Months_MthId : 
	FormattableDataFieldBase<int,Months>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Month ID";}
		set { } 
	}

	public string DFName=> "MthId";

	
	public Months_MthId(Months Parent) : 
		base(Parent, "MthId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Months_MthIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthId").Any()) 
			return DS.GetManager<Months>().OnDataSource.Where(f=> f.Key == "MthId").First().Value(new Months());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 654;
	}
	public string GetControlName() {
		return "MthIdValue";
	}
	public string GetDFName() {
		return "MthId";
	}
	public string GetTitle() {
		return "Month ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Months ds;
					ds = (Months)dsI;
		 
		
		return ds.MthId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Months ds;
				ds = (Months)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Months/SaveMthId/?RecId=[[RecId]]',$(this));\" data-bound-name='MthId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.MthId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "MthId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "MthId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "MthId", "@MthId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "MthId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Months").GetFieldOperators("MthId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

