
	
public partial class InvBatch_InvBId : 
	FormattableDataFieldBase<int,InvBatch>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Batch Number";}
		set { } 
	}

	public string DFName=> "InvBId";

	
	public InvBatch_InvBId(InvBatch Parent) : 
		base(Parent, "InvBId"
			,"f0"
		)
    {
		        Enabled = false;
		
		        this.SetValue("0");
				    }
}


public partial class InvBatch_InvBIdFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBId").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBId").First().Value(new InvBatch());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 292;
	}
	public string GetControlName() {
		return "InvBIdValue";
	}
	public string GetDFName() {
		return "InvBId";
	}
	public string GetTitle() {
		return "Batch Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvBatch ds;
					ds = (InvBatch)dsI;
		 
		
		return ds.InvBId.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvBatch ds;
				ds = (InvBatch)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBId/?RecId=[[RecId]]',$(this));\" data-bound-name='InvBId' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBId.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBId";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "InvBId")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBId", "@InvBId", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBId", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvBatch").GetFieldOperators("InvBId", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

