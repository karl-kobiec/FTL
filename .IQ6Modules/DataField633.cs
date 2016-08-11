
	
public partial class IStatRec_IStJobNo : 
	DataFieldBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Job Number";}
		set { } 
	}

	public string DFName=> "IStJobNo";

	
	public IStatRec_IStJobNo(IStatRec Parent) : 
		base(Parent, "IStJobNo"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class IStatRec_IStJobNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStJobNo").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStJobNo").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 633;
	}
	public string GetControlName() {
		return "IStJobNoValue";
	}
	public string GetDFName() {
		return "IStJobNo";
	}
	public string GetTitle() {
		return "Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStJobNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStJobNo/?RecId=[[RecId]]',$(this));\" data-bound-name='IStJobNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStJobNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStJobNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStJobNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStJobNo", "@IStJobNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStJobNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStJobNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

