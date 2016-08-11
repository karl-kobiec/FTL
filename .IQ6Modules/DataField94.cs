
	
public partial class Inv_InvId : 
	FormattableDataFieldBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Number";}
		set { } 
	}

	public string DFName=> "InvId";

	
	public Inv_InvId(Inv Parent) : 
		base(Parent, "InvId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvId").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvId").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 94;
	}
	public string GetControlName() {
		return "InvIdValue";
	}
	public string GetDFName() {
		return "InvId";
	}
	public string GetTitle() {
		return "Invoice Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvId/?RecId=[[RecId]]',$(this));\" data-bound-name='InvId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvId", "@InvId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

