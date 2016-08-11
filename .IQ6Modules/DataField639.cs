
	
public partial class IStatRec_IStProcessed : 
	BoolDataFieldBase<IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Processed";}
		set { } 
	}

	public string DFName=> "IStProcessed";

	
	public IStatRec_IStProcessed(IStatRec Parent) : 
		base(Parent, "IStProcessed"
			
		)
    {
		        Enabled = false;
		
		        this.SetValue("False");
				    }
}


public partial class IStatRec_IStProcessedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStProcessed").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStProcessed").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 639;
	}
	public string GetControlName() {
		return "IStProcessedValue";
	}
	public string GetDFName() {
		return "IStProcessed";
	}
	public string GetTitle() {
		return "Processed";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStProcessed.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStProcessed/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='IStProcessed' [[Val]] /><input type = 'hidden' data-bound-name='IStProcessed' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStProcessed.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStProcessed";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "IStProcessed")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStProcessed", "@IStProcessed", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStProcessed", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStProcessed", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

