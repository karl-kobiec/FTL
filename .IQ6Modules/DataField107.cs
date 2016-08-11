
	
public partial class Inv_InvNet : 
	FormattableDataFieldBase<double,Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Net Amount";}
		set { } 
	}

	public string DFName=> "InvNet";

	
	public Inv_InvNet(Inv Parent) : 
		base(Parent, "InvNet"
			,"f2"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class Inv_InvNetFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvNet").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvNet").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 107;
	}
	public string GetControlName() {
		return "InvNetValue";
	}
	public string GetDFName() {
		return "InvNet";
	}
	public string GetTitle() {
		return "Net Amount";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvNet.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/Inv/SaveInvNet/?RecId=[[RecId]]',$(this));\" data-bound-name='InvNet' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvNet.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvNet";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvNet")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvNet", "@InvNet", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvNet", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvNet", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

