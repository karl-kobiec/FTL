
	
public partial class CN_CNDesc : 
	DataFieldBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Credit Description";}
		set { } 
	}

	public string DFName=> "CNDesc";

	
	public CN_CNDesc(CN Parent) : 
		base(Parent, "CNDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDesc").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDesc").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 211;
	}
	public string GetControlName() {
		return "CNDescValue";
	}
	public string GetDFName() {
		return "CNDesc";
	}
	public string GetTitle() {
		return "Credit Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CN/SaveCNDesc/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CNDesc'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNDesc", "@CNDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

