
	
public partial class EADNum_EADOrder : 
	FormattableDataFieldBase<int,EADNum>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Number";}
		set { } 
	}

	public string DFName=> "EADOrder";

	
	public EADNum_EADOrder(EADNum Parent) : 
		base(Parent, "EADOrder"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class EADNum_EADOrderFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EADNum>().OnDataSource.Where(f=> f.Key == "EADOrder").Any()) 
			return DS.GetManager<EADNum>().OnDataSource.Where(f=> f.Key == "EADOrder").First().Value(new EADNum());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 343;
	}
	public string GetControlName() {
		return "EADOrderValue";
	}
	public string GetDFName() {
		return "EADOrder";
	}
	public string GetTitle() {
		return "Order Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EADNum ds;
					ds = (EADNum)dsI;
		 
		
		return ds.EADOrder.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EADNum ds;
				ds = (EADNum)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/EADNum/SaveEADOrder/?RecId=[[RecId]]',$(this));\" data-bound-name='EADOrder' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EADOrder.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EADOrder";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EADOrder")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EADOrder", "@EADOrder", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EADOrder", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EADNum").GetFieldOperators("EADOrder", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

