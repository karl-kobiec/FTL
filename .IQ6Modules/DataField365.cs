
	
public partial class ShipDoc_SDNWeight1 : 
	FormattableDataFieldBase<double,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Net weight (1)";}
		set { } 
	}

	public string DFName=> "SDNWeight1";

	
	public ShipDoc_SDNWeight1(ShipDoc Parent) : 
		base(Parent, "SDNWeight1"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class ShipDoc_SDNWeight1FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDNWeight1").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDNWeight1").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 365;
	}
	public string GetControlName() {
		return "SDNWeight1Value";
	}
	public string GetDFName() {
		return "SDNWeight1";
	}
	public string GetTitle() {
		return "Net weight (1)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDNWeight1.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight1/?RecId=[[RecId]]',$(this));\" data-bound-name='SDNWeight1' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDNWeight1.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDNWeight1";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDNWeight1")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDNWeight1", "@SDNWeight1", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDNWeight1", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDNWeight1", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

