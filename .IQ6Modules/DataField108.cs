
	
public partial class Inv_InvVAT : 
	FormattableDataFieldBase<double,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "VAT Amount";}
		set { } 
	}

	public string DFName=> "InvVAT";

	
	public Inv_InvVAT(Inv Parent) : 
		base(Parent, "InvVAT"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvVATFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvVAT").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvVAT").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 108;
	}
	public string GetControlName() {
		return "InvVATValue";
	}
	public string GetDFName() {
		return "InvVAT";
	}
	public string GetTitle() {
		return "VAT Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvVAT.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvVAT/?RecId=[[RecId]]',$(this));\" data-bound-name='InvVAT' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvVAT.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvVAT";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvVAT")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvVAT", "@InvVAT", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvVAT", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvVAT", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

