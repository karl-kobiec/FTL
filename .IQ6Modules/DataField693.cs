
	
public partial class EMail_EMAttach : 
	DataFieldBase<string,EMail>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Attachments";}
		set { } 
	}

	public string DFName=> "EMAttach";

	
	public EMail_EMAttach(EMail Parent) : 
		base(Parent, "EMAttach"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class EMail_EMAttachFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMAttach").Any()) 
			return DS.GetManager<EMail>().OnDataSource.Where(f=> f.Key == "EMAttach").First().Value(new EMail());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 693;
	}
	public string GetControlName() {
		return "EMAttachValue";
	}
	public string GetDFName() {
		return "EMAttach";
	}
	public string GetTitle() {
		return "Attachments";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		EMail ds;
					ds = (EMail)dsI;
		 
		
		return ds.EMAttach.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		EMail ds;
				ds = (EMail)dsI;
		 

		string ctrl =  "<textarea style='height:21px;[[Width]]' onchange=\"javascript:IQAutoSave('/EMail/SaveEMAttach/?RecId=[[RecId]]',$(this));\" class='form-control' data-bound-name='EMAttach'>[[Val]]</textarea>";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.EMAttach.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "EMAttach";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "EMAttach")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "EMAttach", "@EMAttach", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "EMAttach", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("EMail").GetFieldOperators("EMAttach", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

