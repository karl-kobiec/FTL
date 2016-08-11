
	
public partial class OrderLine_OrdLDesc : 
	DataFieldBase<string,OrderLine>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Description";}
		set { } 
	}

	public string DFName=> "OrdLDesc";

	
	public OrderLine_OrdLDesc(OrderLine Parent) : 
		base(Parent, "OrdLDesc"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class OrderLine_OrdLDescFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLDesc").Any()) 
			return DS.GetManager<OrderLine>().OnDataSource.Where(f=> f.Key == "OrdLDesc").First().Value(new OrderLine());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 72;
	}
	public string GetControlName() {
		return "OrdLDescValue";
	}
	public string GetDFName() {
		return "OrdLDesc";
	}
	public string GetTitle() {
		return "Description";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		OrderLine ds;
					ds = (OrderLine)dsI;
		 
		
		return ds.OrdLDesc.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		OrderLine ds;
				ds = (OrderLine)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/OrderLine/SaveOrdLDesc/?RecId=[[RecId]]',$(this));\" data-bound-name='OrdLDesc' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdLDesc.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdLDesc";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdLDesc")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdLDesc", "@OrdLDesc", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdLDesc", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("OrderLine").GetFieldOperators("OrdLDesc", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

