
	
public partial class Orders_OrdDateDel : 
	DateDataFieldBase<Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Date Delivered";}
		set { } 
	}

	public string DFName=> "OrdDateDel";

	
	public Orders_OrdDateDel(Orders Parent) : 
		base(Parent, "OrdDateDel"
			,"ddd dd-MMM-yyyy"
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdDateDelFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDateDel").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdDateDel").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 66;
	}
	public string GetControlName() {
		return "OrdDateDelValue";
	}
	public string GetDFName() {
		return "OrdDateDel";
	}
	public string GetTitle() {
		return "Date Delivered";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdDateDel.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdDateDel/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdDateDel' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdDateDel.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdDateDel";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdDateDel")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdDateDel", "@OrdDateDel", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdDateDel", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdDateDel", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

