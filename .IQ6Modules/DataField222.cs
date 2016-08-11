
	
public partial class CN_CNCustOrd : 
	DataFieldBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Client Order No";}
		set { } 
	}

	public string DFName=> "CNCustOrd";

	
	public CN_CNCustOrd(CN Parent) : 
		base(Parent, "CNCustOrd"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNCustOrdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNCustOrd").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNCustOrd").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 222;
	}
	public string GetControlName() {
		return "CNCustOrdValue";
	}
	public string GetDFName() {
		return "CNCustOrd";
	}
	public string GetTitle() {
		return "Client Order No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNCustOrd.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNCustOrd/?RecId=[[RecId]]',$(this));\" data-bound-name='CNCustOrd' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNCustOrd.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNCustOrd";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNCustOrd")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNCustOrd", "@CNCustOrd", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNCustOrd", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNCustOrd", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

