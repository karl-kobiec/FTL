
	
public partial class Orders_OrdNotes : 
	DataFieldBase<string,Orders>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Order Notes";}
		set { } 
	}

	public string DFName=> "OrdNotes";

	
	public Orders_OrdNotes(Orders Parent) : 
		base(Parent, "OrdNotes"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class Orders_OrdNotesFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdNotes").Any()) 
			return DS.GetManager<Orders>().OnDataSource.Where(f=> f.Key == "OrdNotes").First().Value(new Orders());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 149;
	}
	public string GetControlName() {
		return "OrdNotesValue";
	}
	public string GetDFName() {
		return "OrdNotes";
	}
	public string GetTitle() {
		return "Order Notes";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Orders ds;
					ds = (Orders)dsI;
		 
		
		return ds.OrdNotes.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Orders ds;
				ds = (Orders)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/Orders/SaveOrdNotes/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='OrdNotes'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.OrdNotes.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "OrdNotes";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "OrdNotes")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "OrdNotes", "@OrdNotes", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "OrdNotes", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Orders").GetFieldOperators("OrdNotes", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

