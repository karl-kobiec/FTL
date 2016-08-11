
	
public partial class IStatRec_IStInvVal : 
	FormattableDataFieldBase<double,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Value";}
		set { } 
	}

	public string DFName=> "IStInvVal";

	
	public IStatRec_IStInvVal(IStatRec Parent) : 
		base(Parent, "IStInvVal"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class IStatRec_IStInvValFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStInvVal").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStInvVal").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 636;
	}
	public string GetControlName() {
		return "IStInvValValue";
	}
	public string GetDFName() {
		return "IStInvVal";
	}
	public string GetTitle() {
		return "Invoice Value";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStInvVal.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStInvVal/?RecId=[[RecId]]',$(this));\" data-bound-name='IStInvVal' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStInvVal.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStInvVal";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStInvVal")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStInvVal", "@IStInvVal", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStInvVal", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStInvVal", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

