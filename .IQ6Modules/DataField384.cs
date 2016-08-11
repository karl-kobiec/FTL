
	
public partial class ShipDoc_SDValue4 : 
	FormattableDataFieldBase<double,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Value (4)";}
		set { } 
	}

	public string DFName=> "SDValue4";

	
	public ShipDoc_SDValue4(ShipDoc Parent) : 
		base(Parent, "SDValue4"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class ShipDoc_SDValue4FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDValue4").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDValue4").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 384;
	}
	public string GetControlName() {
		return "SDValue4Value";
	}
	public string GetDFName() {
		return "SDValue4";
	}
	public string GetTitle() {
		return "Value (4)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDValue4.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDValue4/?RecId=[[RecId]]',$(this));\" data-bound-name='SDValue4' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDValue4.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDValue4";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDValue4")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDValue4", "@SDValue4", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDValue4", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDValue4", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

