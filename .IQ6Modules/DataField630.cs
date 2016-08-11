
	
public partial class IStatRec_IStSuppId : 
	FormattableDataFieldBase<int,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Supplier ID";}
		set { } 
	}

	public string DFName=> "IStSuppId";

	
	public IStatRec_IStSuppId(IStatRec Parent) : 
		base(Parent, "IStSuppId"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class IStatRec_IStSuppIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStSuppId").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStSuppId").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 630;
	}
	public string GetControlName() {
		return "IStSuppIdValue";
	}
	public string GetDFName() {
		return "IStSuppId";
	}
	public string GetTitle() {
		return "Supplier ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStSuppId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStSuppId/?RecId=[[RecId]]',$(this));\" data-bound-name='IStSuppId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStSuppId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStSuppId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStSuppId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStSuppId", "@IStSuppId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStSuppId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStSuppId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

