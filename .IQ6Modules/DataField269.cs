
	
public partial class Inv_InvBelongsPInv : 
	FormattableDataFieldBase<int,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Belongs to P Inv";}
		set { } 
	}

	public string DFName=> "InvBelongsPInv";

	
	public Inv_InvBelongsPInv(Inv Parent) : 
		base(Parent, "InvBelongsPInv"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvBelongsPInvFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvBelongsPInv").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvBelongsPInv").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 269;
	}
	public string GetControlName() {
		return "InvBelongsPInvValue";
	}
	public string GetDFName() {
		return "InvBelongsPInv";
	}
	public string GetTitle() {
		return "Belongs to P Inv";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvBelongsPInv.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvBelongsPInv/?RecId=[[RecId]]',$(this));\" data-bound-name='InvBelongsPInv' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBelongsPInv.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBelongsPInv";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvBelongsPInv")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBelongsPInv", "@InvBelongsPInv", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBelongsPInv", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvBelongsPInv", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

