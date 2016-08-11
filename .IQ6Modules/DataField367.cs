
	
public partial class ShipDoc_SDDesc2 : 
	DataFieldBase<string,ShipDoc>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description (2)";}
		set { } 
	}

	public string DFName=> "SDDesc2";

	
	public ShipDoc_SDDesc2(ShipDoc Parent) : 
		base(Parent, "SDDesc2"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class ShipDoc_SDDesc2FieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDDesc2").Any()) 
			return DS.GetManager<ShipDoc>().OnDataSource.Where(f=> f.Key == "SDDesc2").First().Value(new ShipDoc());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 367;
	}
	public string GetControlName() {
		return "SDDesc2Value";
	}
	public string GetDFName() {
		return "SDDesc2";
	}
	public string GetTitle() {
		return "Description (2)";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		ShipDoc ds;
					ds = (ShipDoc)dsI;
		 
		
		return ds.SDDesc2.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		ShipDoc ds;
				ds = (ShipDoc)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/ShipDoc/SaveSDDesc2/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='SDDesc2'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.SDDesc2.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "SDDesc2";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "SDDesc2")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "SDDesc2", "@SDDesc2", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "SDDesc2", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("ShipDoc").GetFieldOperators("SDDesc2", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

