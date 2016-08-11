
	
public partial class ExchRate_ExRName : 
	DataFieldBase<string,ExchRate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Period Rate";}
		set { } 
	}

	public string DFName=> "ExRName";

	
	public ExchRate_ExRName(ExchRate Parent) : 
		base(Parent, "ExRName"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ExchRate_ExRNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRName").Any()) 
			return DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRName").First().Value(new ExchRate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 255;
	}
	public string GetControlName() {
		return "ExRNameValue";
	}
	public string GetDFName() {
		return "ExRName";
	}
	public string GetTitle() {
		return "Period Rate";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ExchRate ds;
					ds = (ExchRate)dsI;
		 
		
		return ds.ExRName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ExchRate ds;
				ds = (ExchRate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRName/?RecId=[[RecId]]',$(this));\" data-bound-name='ExRName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ExRName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ExRName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ExRName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ExRName", "@ExRName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ExRName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ExchRate").GetFieldOperators("ExRName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

