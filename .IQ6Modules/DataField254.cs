
	
public partial class ExchRate_ExRId : 
	FormattableDataFieldBase<int,ExchRate>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Period Rate ID";}
		set { } 
	}

	public string DFName=> "ExRId";

	
	public ExchRate_ExRId(ExchRate Parent) : 
		base(Parent, "ExRId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class ExchRate_ExRIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRId").Any()) 
			return DS.GetManager<ExchRate>().OnDataSource.Where(f=> f.Key == "ExRId").First().Value(new ExchRate());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 254;
	}
	public string GetControlName() {
		return "ExRIdValue";
	}
	public string GetDFName() {
		return "ExRId";
	}
	public string GetTitle() {
		return "Period Rate ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ExchRate ds;
					ds = (ExchRate)dsI;
		 
		
		return ds.ExRId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ExchRate ds;
				ds = (ExchRate)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ExchRate/SaveExRId/?RecId=[[RecId]]',$(this));\" data-bound-name='ExRId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.ExRId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "ExRId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "ExRId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "ExRId", "@ExRId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "ExRId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ExchRate").GetFieldOperators("ExRId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

