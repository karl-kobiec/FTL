
	
public partial class Orders_OrdAgentId : 
	FormattableDataFieldBase<int,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Agent ID";}
		set { } 
	}

	public string DFName=> "OrdAgentId";

	
	public Orders_OrdAgentId(Orders Parent) : 
		base(Parent, "OrdAgentId"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Orders_OrdAgentIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgentId").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdAgentId").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 334;
	}
	public string GetControlName() {
		return "OrdAgentIdValue";
	}
	public string GetDFName() {
		return "OrdAgentId";
	}
	public string GetTitle() {
		return "Agent ID";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdAgentId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdAgentId/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdAgentId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdAgentId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdAgentId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdAgentId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdAgentId", "@OrdAgentId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdAgentId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdAgentId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

