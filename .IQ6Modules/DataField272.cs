
	
public partial class PeriodInv_PInvName : 
	FormattableDataFieldBase<int,PeriodInv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Include Invoice";}
		set { } 
	}

	public string DFName=> "PInvName";

	
	public PeriodInv_PInvName(PeriodInv Parent) : 
		base(Parent, "PInvName"
			,"f0"
		)
    {
				Enabled = true; 
		
		        this.SetValue("0");
				    }
}


public partial class PeriodInv_PInvNameFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PeriodInv>().OnDataSource.Where(f=> f.Key == "PInvName").Any()) 
			return DS.GetManager<PeriodInv>().OnDataSource.Where(f=> f.Key == "PInvName").First().Value(new PeriodInv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 272;
	}
	public string GetControlName() {
		return "PInvNameValue";
	}
	public string GetDFName() {
		return "PInvName";
	}
	public string GetTitle() {
		return "Include Invoice";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PeriodInv ds;
					ds = (PeriodInv)dsI;
		 
		
		return ds.PInvName.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PeriodInv ds;
				ds = (PeriodInv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PeriodInv/SavePInvName/?RecId=[[RecId]]',$(this));\" data-bound-name='PInvName' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PInvName.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PInvName";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PInvName")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PInvName", "@PInvName", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PInvName", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PeriodInv").GetFieldOperators("PInvName", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

