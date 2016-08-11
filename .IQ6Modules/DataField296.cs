
	
public partial class InvBatch_InvBExported : 
	BoolDataFieldBase<InvBatch>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent";}
		set { } 
	}

	public string DFName=> "InvBExported";

	
	public InvBatch_InvBExported(InvBatch Parent) : 
		base(Parent, "InvBExported"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class InvBatch_InvBExportedFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBExported").Any()) 
			return DS.GetManager<InvBatch>().OnDataSource.Where(f=> f.Key == "InvBExported").First().Value(new InvBatch());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 296;
	}
	public string GetControlName() {
		return "InvBExportedValue";
	}
	public string GetDFName() {
		return "InvBExported";
	}
	public string GetTitle() {
		return "Sent";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		InvBatch ds;
					ds = (InvBatch)dsI;
		 
		
		return ds.InvBExported.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		InvBatch ds;
				ds = (InvBatch)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/InvBatch/SaveInvBExported/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvBExported' [[Val]] /><input type = 'hidden' data-bound-name='InvBExported' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvBExported.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvBExported";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvBExported")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvBExported", "@InvBExported", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvBExported", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("InvBatch").GetFieldOperators("InvBExported", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

