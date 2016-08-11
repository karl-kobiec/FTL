
	
public partial class IStatRec_IStInvNo : 
	DataFieldBase<string,IStatRec>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Invoice Number";}
		set { } 
	}

	public string DFName=> "IStInvNo";

	
	public IStatRec_IStInvNo(IStatRec Parent) : 
		base(Parent, "IStInvNo"
			
		)
    {
				Enabled = true; 
		
				    }
}


public partial class IStatRec_IStInvNoFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStInvNo").Any()) 
			return DS.GetManager<IStatRec>().OnDataSource.Where(f=> f.Key == "IStInvNo").First().Value(new IStatRec());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 648;
	}
	public string GetControlName() {
		return "IStInvNoValue";
	}
	public string GetDFName() {
		return "IStInvNo";
	}
	public string GetTitle() {
		return "Invoice Number";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		IStatRec ds;
					ds = (IStatRec)dsI;
		 
		
		return ds.IStInvNo.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		IStatRec ds;
				ds = (IStatRec)dsI;
		 

		string ctrl =  "<input  class='form-control' type='text' onchange=\"javascript:IQAutoSave('/IStatRec/SaveIStInvNo/?RecId=[[RecId]]',$(this));\" data-bound-name='IStInvNo' style='height:21px;[[Width]]' value='[[Val]]' />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.IStInvNo.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "IStInvNo";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return $"<input class='form-control' type='text' value='{filterValue}' {extraHTML} name='{overridename}' />";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
				if(FilterValue != "" ) {
					if(!Params.Any(f=> f.KeyValue == "IStInvNo")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "IStInvNo", "@IStInvNo", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "IStInvNo", Description=FilterValue});
				return ret;
			}
				}
		
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("IStatRec").GetFieldOperators("IStInvNo", selected);
	}

	public bool IsCheckBox() {
				return false;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

