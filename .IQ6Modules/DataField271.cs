
	
public partial class PeriodInv_PInvId : 
	FormattableDataFieldBase<int,PeriodInv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Period Inv No";}
		set { } 
	}

	public string DFName=> "PInvId";

	
	public PeriodInv_PInvId(PeriodInv Parent) : 
		base(Parent, "PInvId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class PeriodInv_PInvIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<PeriodInv>().OnDataSource.Where(f=> f.Key == "PInvId").Any()) 
			return DS.GetManager<PeriodInv>().OnDataSource.Where(f=> f.Key == "PInvId").First().Value(new PeriodInv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 271;
	}
	public string GetControlName() {
		return "PInvIdValue";
	}
	public string GetDFName() {
		return "PInvId";
	}
	public string GetTitle() {
		return "Period Inv No";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		PeriodInv ds;
					ds = (PeriodInv)dsI;
		 
		
		return ds.PInvId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		PeriodInv ds;
				ds = (PeriodInv)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/PeriodInv/SavePInvId/?RecId=[[RecId]]',$(this));\" data-bound-name='PInvId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.PInvId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "PInvId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "PInvId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "PInvId", "@PInvId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "PInvId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("PeriodInv").GetFieldOperators("PInvId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

