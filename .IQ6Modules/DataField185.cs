
	
public partial class CertShip_CSGoodsDesc : 
	DataFieldBase<string,CertShip>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Goods Desc";}
		set { } 
	}

	public string DFName=> "CSGoodsDesc";

	
	public CertShip_CSGoodsDesc(CertShip Parent) : 
		base(Parent, "CSGoodsDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class CertShip_CSGoodsDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSGoodsDesc").Any()) 
			return DS.GetManager<CertShip>().OnDataSource.Where(f=> f.Key == "CSGoodsDesc").First().Value(new CertShip());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 185;
	}
	public string GetControlName() {
		return "CSGoodsDescValue";
	}
	public string GetDFName() {
		return "CSGoodsDesc";
	}
	public string GetTitle() {
		return "Goods Desc";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		CertShip ds;
					ds = (CertShip)dsI;
		 
		
		return ds.CSGoodsDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		CertShip ds;
				ds = (CertShip)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/CertShip/SaveCSGoodsDesc/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='CSGoodsDesc'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.CSGoodsDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "CSGoodsDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "CSGoodsDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "CSGoodsDesc", "@CSGoodsDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "CSGoodsDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("CertShip").GetFieldOperators("CSGoodsDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

