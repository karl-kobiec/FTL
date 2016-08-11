
	
public partial class Inv_InvJobLetter : 
	DataFieldBase<string,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Letter";}
		set { } 
	}

	public string DFName=> "InvJobLetter";

	
	public Inv_InvJobLetter(Inv Parent) : 
		base(Parent, "InvJobLetter"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Inv_InvJobLetterFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobLetter").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvJobLetter").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 162;
	}
	public string GetControlName() {
		return "InvJobLetterValue";
	}
	public string GetDFName() {
		return "InvJobLetter";
	}
	public string GetTitle() {
		return "Job Letter";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvJobLetter.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvJobLetter/?RecId=[[RecId]]',$(this));\" data-bound-name='InvJobLetter' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvJobLetter.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvJobLetter";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvJobLetter")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvJobLetter", "@InvJobLetter", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvJobLetter", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvJobLetter", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

