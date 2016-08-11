
	
public partial class CN_CNNet : 
	FormattableDataFieldBase<double,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Net Amount";}
		set { } 
	}

	public string DFName=> "CNNet";

	
	public CN_CNNet(CN Parent) : 
		base(Parent, "CNNet"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CN_CNNetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNet").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNNet").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 212;
	}
	public string GetControlName() {
		return "CNNetValue";
	}
	public string GetDFName() {
		return "CNNet";
	}
	public string GetTitle() {
		return "Net Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNNet.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNNet/?RecId=[[RecId]]',$(this));\" data-bound-name='CNNet' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNNet.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNNet";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNNet")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNNet", "@CNNet", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNNet", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNNet", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

