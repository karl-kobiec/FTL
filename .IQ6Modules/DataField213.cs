
	
public partial class CN_CNVAT : 
	FormattableDataFieldBase<double,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Amount";}
		set { } 
	}

	public string DFName=> "CNVAT";

	
	public CN_CNVAT(CN Parent) : 
		base(Parent, "CNVAT"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class CN_CNVATFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNVAT").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNVAT").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 213;
	}
	public string GetControlName() {
		return "CNVATValue";
	}
	public string GetDFName() {
		return "CNVAT";
	}
	public string GetTitle() {
		return "VAT Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNVAT.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNVAT/?RecId=[[RecId]]',$(this));\" data-bound-name='CNVAT' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNVAT.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNVAT";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNVAT")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNVAT", "@CNVAT", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNVAT", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNVAT", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

