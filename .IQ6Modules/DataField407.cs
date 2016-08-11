
	
public partial class Inv_InvSentTradeshift : 
	BoolDataFieldBase<Inv>, IQ6.Core.IDSFieldBase
{
	
	public string LabelText { 
		get { return "Sent to Tradeshift";}
		set { } 
	}

	public string DFName=> "InvSentTradeshift";

	
	public Inv_InvSentTradeshift(Inv Parent) : 
		base(Parent, "InvSentTradeshift"
			
		)
    {
				Enabled = true; 
		
		        this.SetValue("False");
				    }
}


public partial class Inv_InvSentTradeshiftFieldDef 
	: IFieldDefinition {
	
	public string GetDataSource()
	{
		if(DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvSentTradeshift").Any()) 
			return DS.GetManager<Inv>().OnDataSource.Where(f=> f.Key == "InvSentTradeshift").First().Value(new Inv());
		
		
			return  "";	}

	public int GetFieldUniqueId() {
		return 407;
	}
	public string GetControlName() {
		return "InvSentTradeshiftValue";
	}
	public string GetDFName() {
		return "InvSentTradeshift";
	}
	public string GetTitle() {
		return "Sent to Tradeshift";
	}
	
	public string DrawDisplayValue(IDSBase dsI) {
		Inv ds;
					ds = (Inv)dsI;
		 
		
		return ds.InvSentTradeshift.DisplayValue.ToString();
	}

	public string DrawAutoSaveEditor(IDSBase dsI, double widthPercentage=0) {
		Inv ds;
				ds = (Inv)dsI;
		 

		string ctrl =  "<input type='checkbox'onchange=\"javascript:IQAutoSave('/Inv/SaveInvSentTradeshift/?RecId=[[RecId]]',$(this));\" value='true' data-bound-name='InvSentTradeshift' [[Val]] /><input type = 'hidden' data-bound-name='InvSentTradeshift' value='false'  />";
		ctrl = ctrl.Replace("[[RecId]]", ds.RecordID.ToString()).Replace("[[Val]]", ds.InvSentTradeshift.HTMLValue.ToString());
		if(widthPercentage > 0) 
			ctrl = ctrl.Replace("[[Width]]", "width:" + widthPercentage.ToString() + "%;");
		else
			ctrl = ctrl.Replace("[[Width]]", "");

		return ctrl;
	}

	public  string Name { get { return "InvSentTradeshift";} set { }}

		
	public string DrawResultsEditor(int id, string filterValue, string extraHTML = "", string overridename = "") {
		if(string.IsNullOrEmpty(overridename)) overridename = "FilterValue-" + id.ToString();
		return "";	}

	public string GetSearchClause(int OperatorID, string FilterValue, ref List<Pair<string, string>> Params) {
			
					if(!Params.Any(f=> f.KeyValue == "InvSentTradeshift")) {
				string ret =  IQApp.Operators.GetClause(OperatorID, "InvSentTradeshift", "@InvSentTradeshift", ref FilterValue);
				Params.Add(new Pair<string, string>() {  KeyValue = "InvSentTradeshift", Description=FilterValue});
				return ret;
			}
					return "";
	}

	public string DrawSearchOperators(int selected) {
		return IQApp.Datasets.GetDS("Inv").GetFieldOperators("InvSentTradeshift", selected);
	}

	public bool IsCheckBox() {
				return true;
			}
	public bool IsAutoComplete() {
				return false;
			}
}

