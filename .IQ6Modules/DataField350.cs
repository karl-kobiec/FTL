
	
public partial class ShipDoc_SDSuppAddr : 
	DataFieldBase<string,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Supplier Address";}
		set { } 
	}

	public string DFName=> "SDSuppAddr";

	
	public ShipDoc_SDSuppAddr(ShipDoc Parent) : 
		base(Parent, "SDSuppAddr"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ShipDoc_SDSuppAddrFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDSuppAddr").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDSuppAddr").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 350;
	}
	public string GetControlName() {
		return "SDSuppAddrValue";
	}
	public string GetDFName() {
		return "SDSuppAddr";
	}
	public string GetTitle() {
		return "Supplier Address";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDSuppAddr.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDSuppAddr/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='SDSuppAddr'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDSuppAddr.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDSuppAddr";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDSuppAddr")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDSuppAddr", "@SDSuppAddr", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDSuppAddr", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDSuppAddr", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

