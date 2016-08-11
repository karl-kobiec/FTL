
	
public partial class IStatRec_IStOrder : 
	FormattableDataFieldBase<int,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Number";}
		set { } 
	}

	public string DFName=> "IStOrder";

	
	public IStatRec_IStOrder(IStatRec Parent) : 
		base(Parent, "IStOrder"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class IStatRec_IStOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOrder").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStOrder").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 627;
	}
	public string GetControlName() {
		return "IStOrderValue";
	}
	public string GetDFName() {
		return "IStOrder";
	}
	public string GetTitle() {
		return "Order Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStOrder/?RecId=[[RecId]]',$(this));\" data-bound-name='IStOrder' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStOrder", "@IStOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

