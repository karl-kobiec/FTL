
	
public partial class Orders_OrdJob : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Job Number";}
		set { } 
	}

	public string DFName=> "OrdJob";

	
	public Orders_OrdJob(Orders Parent) : 
		base(Parent, "OrdJob"
			
		)
    {
		        Enabled = false;
		
				    }
}


public partial class Orders_OrdJobFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJob").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdJob").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 62;
	}
	public string GetControlName() {
		return "OrdJobValue";
	}
	public string GetDFName() {
		return "OrdJob";
	}
	public string GetTitle() {
		return "Order Job Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdJob.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdJob/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdJob' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdJob.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdJob";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdJob")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdJob", "@OrdJob", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdJob", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdJob", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

