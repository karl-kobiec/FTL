
	
public partial class CN_CNDutyCN : 
	BoolDataFieldBase<CN>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Duty CN";}
		set { } 
	}

	public string DFName=> "CNDutyCN";

	
	public CN_CNDutyCN(CN Parent) : 
		base(Parent, "CNDutyCN"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class CN_CNDutyCNFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDutyCN").Any()) 
			return DS.GetManager<CN>().OnDataSource.Where(f=> f.Key == "CNDutyCN").First().Value(new CN());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 251;
	}
	public string GetControlName() {
		return "CNDutyCNValue";
	}
	public string GetDFName() {
		return "CNDutyCN";
	}
	public string GetTitle() {
		return "Duty CN";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CN ds;
					ds = (CN)dsI;
		 
		
		return ds.CNDutyCN.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CN ds;
				ds = (CN)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/CN/SaveCNDutyCN/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='CNDutyCN' [[Val]] /><input type = 'hidden' data-bound-name='CNDutyCN' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CNDutyCN.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CNDutyCN";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "CNDutyCN")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CNDutyCN", "@CNDutyCN", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CNDutyCN", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CN").GetFieldOperators("CNDutyCN", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

