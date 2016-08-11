
	
public partial class CN_CNJobLetter : 
	DataFieldBase<string,CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Letter";}
		set { } 
	}

	public string DFName=> "CNJobLetter";

	
	public CN_CNJobLetter(CN Parent) : 
		base(Parent, "CNJobLetter"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CN_CNJobLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNJobLetter").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNJobLetter").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 219;
	}
	public string GetControlName() {
		return "CNJobLetterValue";
	}
	public string GetDFName() {
		return "CNJobLetter";
	}
	public string GetTitle() {
		return "Job Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNJobLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/CN/SaveCNJobLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='CNJobLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNJobLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNJobLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CNJobLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNJobLetter", "@CNJobLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNJobLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNJobLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

