
	
public partial class ShipDoc_SDHMRCDets : 
	BoolDataFieldBase<ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Show HMRC details";}
		set { } 
	}

	public string DFName=> "SDHMRCDets";

	
	public ShipDoc_SDHMRCDets(ShipDoc Parent) : 
		base(Parent, "SDHMRCDets"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("True");
				    }
}


public partial class ShipDoc_SDHMRCDetsFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDHMRCDets").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDHMRCDets").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 396;
	}
	public string GetControlName() {
		return "SDHMRCDetsValue";
	}
	public string GetDFName() {
		return "SDHMRCDets";
	}
	public string GetTitle() {
		return "Show HMRC details";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDHMRCDets.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDHMRCDets/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='SDHMRCDets' [[Val]] /><input type = 'hidden' data-bound-name='SDHMRCDets' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDHMRCDets.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDHMRCDets";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "SDHMRCDets")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDHMRCDets", "@SDHMRCDets", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDHMRCDets", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDHMRCDets", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

