
	
public partial class Inv_InvSentToClient : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent to Client";}
		set { } 
	}

	public string DFName=> "InvSentToClient";

	
	public Inv_InvSentToClient(Inv Parent) : 
		base(Parent, "InvSentToClient"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvSentToClientFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvSentToClient").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvSentToClient").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 787;
	}
	public string GetControlName() {
		return "InvSentToClientValue";
	}
	public string GetDFName() {
		return "InvSentToClient";
	}
	public string GetTitle() {
		return "Sent to Client";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvSentToClient.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvSentToClient/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvSentToClient' [[Val]] /><input type = 'hidden' data-bound-name='InvSentToClient' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvSentToClient.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvSentToClient";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvSentToClient")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvSentToClient", "@InvSentToClient", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvSentToClient", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvSentToClient", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

