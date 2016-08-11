
	
public partial class Orders_OrdFreightInv : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Freight Inv";}
		set { } 
	}

	public string DFName=> "OrdFreightInv";

	
	public Orders_OrdFreightInv(Orders Parent) : 
		base(Parent, "OrdFreightInv"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdFreightInvFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdFreightInv").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdFreightInv").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 177;
	}
	public string GetControlName() {
		return "OrdFreightInvValue";
	}
	public string GetDFName() {
		return "OrdFreightInv";
	}
	public string GetTitle() {
		return "Freight Inv";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdFreightInv.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdFreightInv/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='OrdFreightInv'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdFreightInv.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdFreightInv";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdFreightInv")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdFreightInv", "@OrdFreightInv", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdFreightInv", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdFreightInv", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

