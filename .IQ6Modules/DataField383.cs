
	
public partial class ShipDoc_SDNWeight4 : 
	FormattableDataFieldBase<double,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Net weight (4)";}
		set { } 
	}

	public string DFName=> "SDNWeight4";

	
	public ShipDoc_SDNWeight4(ShipDoc Parent) : 
		base(Parent, "SDNWeight4"
			,"f2"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class ShipDoc_SDNWeight4FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDNWeight4").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDNWeight4").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 383;
	}
	public string GetControlName() {
		return "SDNWeight4Value";
	}
	public string GetDFName() {
		return "SDNWeight4";
	}
	public string GetTitle() {
		return "Net weight (4)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDNWeight4.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDNWeight4/?RecId=[[RecId]]',$(this));\" data-bound-name='SDNWeight4' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDNWeight4.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDNWeight4";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDNWeight4")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDNWeight4", "@SDNWeight4", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDNWeight4", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDNWeight4", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

